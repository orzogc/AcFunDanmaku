﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using AcFunDanmuSongRequest.Platform.Interfaces;
using AcFunDanmuSongRequest.Platform.NetEase.Request;
using AcFunDanmuSongRequest.Platform.NetEase.Response;
using Aes = System.Security.Cryptography.Aes;

namespace AcFunDanmuSongRequest.Platform.NetEase;

internal sealed class NetEasePlatform : BasePlatform
{
    public NetEasePlatform(Config config) : base(config)
    {
    }

    public override async ValueTask<ISong> AddSong(string keyword)
    {
        //await Request<SuggestSearchResult>(new SuggestSearchGetRequest { Keyword = keyword, Offset = 0, Limit = 1 }, SearchResult.Options);
        //await Request<SearchGetResponse, EncodedResponse>(new SearchGetRequest { Keyword = keyword, Offset = 0, Limit = 1 }, SearchResult.Options);

        var result = await GetAsync<CloudSearchResponse, EncodedResponse>(
            new CloudSearchGetRequest { Keyword = keyword, Offset = 0, Limit = 10 }, SearchResult.Options);
        if (result.Songs.Length == 0) return null;

        foreach (var item in result.Songs)
        {
            var source = await GetAsync<PlayResponse>(new PlayGetRequest { Id = item.Id, BitRate = 320000 },
                PlayResponse.Options);

            if (source.Data.Length == 0 || string.IsNullOrEmpty(source.Data[0].Url))
            {
                continue;
            }

            var song = new Song
            {
                Id = item.Id,
                Name = item.Name,
                Artist = item.Ar[0].Name,
                Album = item.Al.Name,
                Duration = item.Dt,
                Source = source.Data[0].Url
            };
            _songs.Add(song);
            return song;
        }

        return null;
    }

    public override ValueTask<ISong> NextSong()
    {
        if (_songs.Count == 0) return ValueTask.FromResult<ISong>(null);
        var song = _songs[0];
        _songs.RemoveAt(0);

        return ValueTask.FromResult(song);
    }

    public override async ValueTask<Lyrics> GetLyrics(ISong song)
    {
        var result =
            await GetAsync<LyricResponse>(new LyricGetRequest { Id = ((Song)song).Id }, LyricResponse.Options);

        return Lyrics.Parse(result.Lrc.Lyric);
    }


    internal static class NetEaseDecodeUtil
    {
        //private const string Key = "fuck~#$%^&*(458";
        private const int BLOCK_SIZE = 64;
        private const int LENGTH_OFFSET = 4;

        //private static readonly int[] DecodecKey = new int[] { 102, 117, 99, 107, 126, 35, 36, 37, 94, 38, 42, 40, 52, 53, 56 };
        private static readonly byte[] FullKey =
        {
            102, 117, 99, 107, 126, 35, 36, 37, 94, 38, 42, 40, 52, 53, 56, 102, 117, 99, 107, 126, 35, 36, 37, 94,
            38, 42, 40, 52, 53, 56, 102, 117, 99, 107, 126, 35, 36, 37, 94, 38, 42, 40, 52, 53, 56, 102, 117, 99,
            107, 126, 35, 36, 37, 94, 38, 42, 40, 52, 53, 56, 102, 117, 99, 107
        };

        //private static readonly int[] Code =
        //{
        //    82, 9, 106, -43, 48, 54, -91, 56, -65, 64, -93, -98, -127, -13, -41, -5, 124, -29, 57, -126, -101, 47,
        //    -1, -121, 52, -114, 67, 68, -60, -34, -23, -53, 84, 123, -108, 50, -90, -62, 35, 61, -18, 76, -107, 11,
        //    66, -6, -61, 78, 8, 46, -95, 102, 40, -39, 36, -78, 118, 91, -94, 73, 109, -117, -47, 37, 114, -8, -10,
        //    100, -122, 104, -104, 22, -44, -92, 92, -52, 93, 101, -74, -110, 108, 112, 72, 80, -3, -19, -71, -38,
        //    94, 21, 70, 87, -89, -115, -99, -124, -112, -40, -85, 0, -116, -68, -45, 10, -9, -28, 88, 5, -72, -77,
        //    69, 6, -48, 44, 30, -113, -54, 63, 15, 2, -63, -81, -67, 3, 1, 19, -118, 107, 58, -111, 17, 65, 79, 103,
        //    -36, -22, -105, -14, -49, -50, -16, -76, -26, 115, -106, -84, 116, 34, -25, -83, 53, -123, -30, -7, 55,
        //    -24, 28, 117, -33, 110, 71, -15, 26, 113, 29, 41, -59, -119, 111, -73, 98, 14, -86, 24, -66, 27, -4, 86,
        //    62, 75, -58, -46, 121, 32, -102, -37, -64, -2, 120, -51, 90, -12, 31, -35, -88, 51, -120, 7, -57, 49,
        //    -79, 18, 16, 89, 39, -128, -20, 95, 96, 81, 127, -87, 25, -75, 74, 13, 45, -27, 122, -97, -109, -55,
        //    -100, -17, -96, -32, 59, 77, -82, 42, -11, -80, -56, -21, -69, 60, -125, 83, -103, 97, 23, 43, 4, 126,
        //    -70, 119, -42, 38, -31, 105, 20, 99, 85, 33, 12, 125
        //};
        //private static readonly byte[] Code =
        //{
        //    82, 9, 106, 213, 48, 54, 165, 56, 191, 64, 163, 158, 129, 243, 215, 251, 124, 227, 57, 130, 155, 47,
        //    255, 135, 52, 142, 67, 68, 196, 222, 233, 203, 84, 123, 148, 50, 166, 194, 35, 61, 238, 76, 149, 11, 66,
        //    250, 195, 78, 8, 46, 161, 102, 40, 217, 36, 178, 118, 91, 162, 73, 109, 139, 209, 37, 114, 248, 246,
        //    100, 134, 104, 152, 22, 212, 164, 92, 204, 93, 101, 182, 146, 108, 112, 72, 80, 253, 237, 185, 218, 94,
        //    21, 70, 87, 167, 141, 157, 132, 144, 216, 171, 0, 140, 188, 211, 10, 247, 228, 88, 5, 184, 179, 69, 6,
        //    208, 44, 30, 143, 202, 63, 15, 2, 193, 175, 189, 3, 1, 19, 138, 107, 58, 145, 17, 65, 79, 103, 220, 234,
        //    151, 242, 207, 206, 240, 180, 230, 115, 150, 172, 116, 34, 231, 173, 53, 133, 226, 249, 55, 232, 28,
        //    117, 223, 110, 71, 241, 26, 113, 29, 41, 197, 137, 111, 183, 98, 14, 170, 24, 190, 27, 252, 86, 62, 75,
        //    198, 210, 121, 32, 154, 219, 192, 254, 120, 205, 90, 244, 31, 221, 168, 51, 136, 7, 199, 49, 177, 18,
        //    16, 89, 39, 128, 236, 95, 96, 81, 127, 169, 25, 181, 74, 13, 45, 229, 122, 159, 147, 201, 156, 239, 160,
        //    224, 59, 77, 174, 42, 245, 176, 200, 235, 187, 60, 131, 83, 153, 97, 23, 43, 4, 126, 186, 119, 214, 38,
        //    225, 105, 20, 99, 85, 33, 12, 125
        //};
        private static readonly byte[] Code =
        {
            72, 64, 88, 181, 8, 36, 41, 118, 244, 114, 113, 223, 145, 126, 13, 99, 1, 77, 91, 17, 232, 78, 125, 234, 40,
            230, 100, 134, 136, 156, 235, 89, 253, 3, 231, 161, 197, 168, 50, 139, 153, 93, 173, 158, 246, 20, 51, 182,
            191, 195, 241, 211, 238, 229, 166, 62, 15, 87, 26, 164, 179, 206, 81, 194, 30, 225, 214, 140, 220, 247, 226,
            255, 25, 29, 167, 39, 141, 188, 121, 116, 184, 208, 212, 108, 33, 83, 219, 122, 157, 47, 152, 218, 137, 180,
            117, 79, 150, 45, 14, 82, 240, 120, 169, 163, 38, 174, 94, 54, 154, 75, 104, 165, 96, 66, 233, 115, 16, 37,
            251, 106, 221, 27, 205, 213, 9, 130, 207, 5, 162, 172, 227, 248, 146, 10, 147, 187, 133, 4, 95, 236, 23,
            198, 245, 143, 53, 170, 202, 148, 176, 24, 217, 103, 59, 105, 178, 200, 196, 63, 239, 69, 22, 43, 67, 44,
            222, 76, 7, 242, 6, 32, 171, 215, 98, 52, 90, 68, 85, 185, 209, 204, 199, 127, 175, 84, 55, 159, 31, 12,
            193, 128, 70, 186, 203, 201, 111, 102, 151, 56, 49, 46, 86, 57, 124, 21, 61, 58, 131, 132, 144, 112, 107,
            183, 142, 210, 92, 243, 250, 42, 189, 110, 34, 18, 28, 97, 71, 160, 73, 101, 190, 149, 119, 252, 177, 60,
            254, 109, 65, 80, 249, 216, 135, 11, 48, 138, 192, 2, 74, 35, 224, 228, 155, 0, 237, 123, 129, 19
        };

        public static unsafe string Decode(in string data)
        {
            if (string.IsNullOrEmpty(data)) return null;

            var dataLength = data.Length >> 1;
            if ((dataLength & 63) != 0) return null;

            Span<byte> decodedData = stackalloc byte[BLOCK_SIZE + dataLength];
            Span<byte> decryptedData = stackalloc byte[dataLength];

            for (var i = 0; i < dataLength; i++)
            {
                var decoded = byte.Parse(data.AsSpan(i << 1, 2), NumberStyles.HexNumber);
                decodedData[i + BLOCK_SIZE] = decoded;
                decryptedData[i] = Code[decoded];
            }

            fixed (byte* pDecrypted = decryptedData, pDecoded = decodedData, pKey = FullKey)
            {
                if (Avx2.IsSupported)
                {
                    Trace.WriteLine("Using Avx2");
                    var temp = (Vector256<byte>*)pDecoded;
                    *temp = Avx.LoadVector256(pKey);
                    temp = (Vector256<byte>*)(pDecoded + 32);
                    *temp = Avx.LoadVector256(pKey + 32);

                    for (var i = 0; i < dataLength; i += 32)
                    {
                        var decrypt = (Vector256<byte>*)(pDecrypted + i);
                        var decoded = (Vector256<byte>*)(pDecoded + i);
                        var key = (Vector256<byte>*)(pKey + (i & 63));

                        *decrypt = Avx2.Xor(*decrypt, *decoded);
                        *decrypt = Avx2.Subtract(*decrypt, *decoded);
                        *decrypt = Avx2.Xor(*decrypt, *key);
                    }
                }
                else if (Sse2.IsSupported)
                {
                    Trace.WriteLine("Using Sse2");
                    var temp = (Vector128<byte>*)pDecoded;
                    *temp = Sse2.LoadVector128(pKey);
                    temp = (Vector128<byte>*)(pDecoded + 16);
                    *temp = Sse2.LoadVector128(pKey + 16);
                    temp = (Vector128<byte>*)(pDecoded + 32);
                    *temp = Sse2.LoadVector128(pKey + 32);
                    temp = (Vector128<byte>*)(pDecoded + 48);
                    *temp = Sse2.LoadVector128(pKey + 48);

                    for (var i = 0; i < dataLength; i += 16)
                    {
                        var decrypt = (Vector128<byte>*)(pDecrypted + i);
                        var decoded = (Vector128<byte>*)(pDecoded + i);
                        var key = (Vector128<byte>*)(pKey + (i & 63));

                        *decrypt = Sse2.Xor(*decrypt, *decoded);
                        *decrypt = Sse2.Subtract(*decrypt, *decoded);
                        *decrypt = Sse2.Xor(*decrypt, *key);
                    }
                }
                else
                {
                    Trace.WriteLine("SIMD not supported");
                    for (var i = 0; i < BLOCK_SIZE; i += 8)
                    {
                        decodedData[i + 0] = FullKey[i + 0];
                        decodedData[i + 1] = FullKey[i + 1];
                        decodedData[i + 2] = FullKey[i + 2];
                        decodedData[i + 3] = FullKey[i + 3];
                        decodedData[i + 4] = FullKey[i + 4];
                        decodedData[i + 5] = FullKey[i + 5];
                        decodedData[i + 6] = FullKey[i + 6];
                        decodedData[i + 7] = FullKey[i + 7];
                    }

                    for (var i = 0; i < dataLength; i++)
                        decryptedData[i] = (byte)(((decryptedData[i] ^ decodedData[i]) - decodedData[i]) ^
                                                  FullKey[i & 63]);
                }
            }

            var lenData = decryptedData.Slice(dataLength - LENGTH_OFFSET, LENGTH_OFFSET);
            if (BitConverter.IsLittleEndian) lenData.Reverse();

            var length = BitConverter.ToInt32(lenData);
            if (length > dataLength) return null;

            var hex = '%' + BitConverter.ToString(decryptedData[..length].ToArray()).Replace('-', '%');
            return HttpUtility.UrlDecode(hex);
        }

        //private static readonly char[] Char = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };

        #region Decode Key to byte array

#if DEBUG
        private static byte[] DecodeKey(string key)
        {
            var encoded = HttpUtility.UrlEncode(key).AsSpan();
            Span<byte> result = stackalloc byte[encoded.Length];
            var count = encoded.Length;
            for (var i = 0; i < encoded.Length; i++)
                if (encoded[i] == '%')
                {
                    result[count] = byte.Parse(encoded.Slice(i + 1, 2), NumberStyles.HexNumber);
                    i += 2;
                    count++;
                }
                else
                {
                    result[count] = (byte)encoded[i];
                    count++;
                }

            return result[..count].ToArray();
        }

        private static byte[] ExpandKey(ReadOnlySpan<byte> key)
        {
            Span<byte> result = stackalloc byte[BLOCK_SIZE];
            if (key == null || key.Length == 0)
                result.Fill(0);
            else if (key.Length >= BLOCK_SIZE)
                key[..BLOCK_SIZE].CopyTo(result);
            else
                for (var index = 0; index < BLOCK_SIZE; index++)
                    result[index] = key[index % key.Length];

            return result.ToArray();
        }
#endif

        #endregion
    }

    internal static class NetEaseEncryptionUtil
    {
        private const string IV = "0102030405060708";

        private const string PubKey =
            "-----BEGIN PUBLIC KEY-----\nMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDgtQn2JZ34ZC28NWYpAUd98iZ37BUrX/aKzmFbt7clFSs6sXqHauqKWqdtLkF2KexO40H1YTX8z2lSgBBOAxLsvaklV8k4cBFK9snQXE9/DDaFt6Rr7iVZMldczhC0JNgTz+SHXT6CBHuX3e9SdB1Ua44oncaTWz7OBGLbCiK45wIDAQAB\n-----END PUBLIC KEY-----";

        private const int MAX_ENCRYPT_BLOCK = 1024;
        private const string EXPONENT = "010001";

        private const string MODULUS =
            "00e0b509f6259df8642dbc35662901477df22677ec152b5ff68ace615bb7b725152b3ab17a876aea8a5aa76d2e417629ec4ee341f56135fccf695280104e0312ecbda92557c93870114af6c9d05c4f7f0c3685b7a46bee255932575cce10b424d813cfe4875d3e82047b97ddef52741d546b8e289dc6935b3ece0462db0a22b8e7";

        private const string AES_KEY = "0CoJUm6Qyw8W8jud";

        private const int RANDOM_SIZE = 16;
        private static readonly byte[] Iv = Encoding.UTF8.GetBytes(IV);
        private static readonly BigInteger Exponent = BigInteger.Parse(EXPONENT, NumberStyles.HexNumber);

        private static readonly BigInteger Modulus = BigInteger.Parse(MODULUS, NumberStyles.HexNumber);
        private static readonly byte[] AesKey = Encoding.UTF8.GetBytes(AES_KEY);

        private static readonly byte[] Chars =
            "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Select(ch => (byte)ch).ToArray();

        public static ReadOnlyDictionary<string, string> GenerateParams(string data)
        {
            var random = GenerateRandom();
            var p = EncodeParams(data, AesKey, random);
            var k = EncryptKey(random.Reverse().ToArray());

            return new ReadOnlyDictionary<string, string>(
                new Dictionary<string, string>
                {
                    { "params", p },
                    { "encSecKey", k }
                }
            );
        }

        private static string EncryptKey(in ReadOnlySpan<byte> random)
        {
            using var rsa = RSA.Create();
            rsa.ImportFromPem(PubKey);

            Span<byte> data = stackalloc byte[128];
            data.Fill(0);
            for (var i = 0; i < random.Length; i++) data[128 - random.Length + i] = random[i];

            var encrypted = rsa.Encrypt(data.ToArray(), RSAEncryptionPadding.Pkcs1);

            //var bData = new BigInteger(data);

            //var encrypted = BigInteger.ModPow(bData, exponent, modulus).ToByteArray();

            var hex = BitConverter.ToString(encrypted).Replace("-", string.Empty).ToLower();

            return hex;
        }

        private static string EncodeParams(in string data, in ReadOnlySpan<byte> aeskey,
            in ReadOnlySpan<byte> random)
        {
            return EncodeParams(Encoding.UTF8.GetBytes(data), aeskey, random);
        }

        private static string EncodeParams(in ReadOnlySpan<byte> data, in ReadOnlySpan<byte> aeskey,
            in ReadOnlySpan<byte> random)
        {
            var pass1 = AesEncrypt(aeskey, Iv, data);

            var pass2 = AesEncrypt(random, Iv, Encoding.UTF8.GetBytes(Convert.ToBase64String(pass1)));

            return Convert.ToBase64String(pass2);
        }

        private static byte[] AesEncrypt(in ReadOnlySpan<byte> key, in ReadOnlySpan<byte> iv,
            in ReadOnlySpan<byte> text)
        {
            using var aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            using var encryptor = aes.CreateEncryptor(key.ToArray(), iv.ToArray());
            using var ms = new MemoryStream();
            using var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
            cs.Write(text);
            cs.FlushFinalBlock();

            return ms.ToArray();
        }

        private static byte[] GenerateRandom()
        {
            return RandomNumberGenerator.GetBytes(RANDOM_SIZE).Select(b => Chars[b & 61]).ToArray();
        }
    }
}