// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LinkErrorCode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Basic {

  /// <summary>Holder for reflection information generated from LinkErrorCode.proto</summary>
  public static partial class LinkErrorCodeReflection {

    #region Descriptor
    /// <summary>File descriptor for LinkErrorCode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LinkErrorCodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNMaW5rRXJyb3JDb2RlLnByb3RvEhNBY0Z1bkRhbm11LkltLkJhc2ljKs0H",
            "Cg1MaW5rRXJyb3JDb2RlEggKBFNVQ0MQABIOCglCQVNJQ19NSU4QkE4SEwoO",
            "SU5URVJORUxfRVJST1IQkU4SGAoTU0VSVklDRV9VTkFWQUlMQUJMRRCSThIU",
            "Cg9TRVJWSUNFX1RJTUVPVVQQk04SEgoNSU5WQUxJRF9UT0tFThCUThIeChlS",
            "RUdfRU5DWVJQVF9XSVRIT1VUX1RPS0VOEJVOEhYKEVBBUlNFX1BCX0hEUl9G",
            "QUlMEJZOEhYKEVBBUlNFX1BCX1BMRF9GQUlMEJdOEhIKDVBBUlNFX1BCX0ZB",
            "SUwQmE4SFQoQREVDT0RFRF9MRU5fRkFJTBCZThIQCgtJTlZBTElEX0tFWRCa",
            "ThIRCgxFTkNSWVBUX0ZBSUwQm04SEQoMREVDUllQVF9GQUlMEJxOEhAKC0lO",
            "VkFMSURfVEFHEJ1OEhAKC0lOVkFMSURfVkVSEJ5OEhoKFUlOVkFMSURfQ09N",
            "UFJFU1NfVFlQRRCgThIZChRJTlZBTElEX0VOQ1JZUFRfVFlQRRChThIRCgxO",
            "T1RfUkVHSVNURVIQok4SFAoPVVNFUl9OT1RfT05MSU5FEKNOEhQKD0lOVkFM",
            "SURfQ09NTUFORBCkThIaChVQVVNIX1VOUkVHSVNURVJfRVJST1IQpU4SEAoL",
            "SU5WQUxJRF9TSUQQpk4SGAoTSU5WQUxJRF9JTlNUQU5DRV9JRBCnThIcChdD",
            "TElFTlRfTE9DQUxFX05PVF9NQVRDSBCoThIjCh5JTlZBTElEX1RPS0VOX1BB",
            "U1NXT1JEX0NIQU5HRUQQqU4SIAobSU5WQUxJRF9UT0tFTl9UT0tFTl9FWFBJ",
            "UkVEEKpOEiQKH0lOVkFMSURfVE9LRU5fVE9LRU5fVkFMVUVfRVJST1IQq04S",
            "KAojSU5WQUxJRF9UT0tFTl9MT0dJTl9PTl9PVEhFUl9ERVZJQ0UQrE4SFAoP",
            "Rk9SQ0VfUkVDT05ORUNUEK1OEhMKDkNMSUVOVF9USU1FT1VUEK5OEhUKEElO",
            "VkFMSURfQVJHVU1FTlQQr04SGQoUSU5WQUxJRF9GT1JNQVRfVE9LRU4QsE4S",
            "EgoNRU1QVFlfUEFZTE9BRBCxThISCg1DT01QUkVTU19GQUlMELJOEhQKD0RF",
            "Q09NUFJFU1NfRkFJTBCzThIRCgxPVVRfT0ZfT1JERVIQtE4SEQoMT1VUX09G",
            "X0xJTUlUELVOEhYKEVRPT19MQVJHRV9QQVlMT0FEELZOEhUKEEFOT05ZTU9V",
            "U0VfRVJST1IQt04SDwoJQkFTSUNfTUFYEJ+cAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::AcFunDanmu.Im.Basic.LinkErrorCode), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum LinkErrorCode {
    [pbr::OriginalName("SUCC")] Succ = 0,
    [pbr::OriginalName("BASIC_MIN")] BasicMin = 10000,
    [pbr::OriginalName("INTERNEL_ERROR")] InternelError = 10001,
    [pbr::OriginalName("SERVICE_UNAVAILABLE")] ServiceUnavailable = 10002,
    [pbr::OriginalName("SERVICE_TIMEOUT")] ServiceTimeout = 10003,
    [pbr::OriginalName("INVALID_TOKEN")] InvalidToken = 10004,
    [pbr::OriginalName("REG_ENCYRPT_WITHOUT_TOKEN")] RegEncyrptWithoutToken = 10005,
    [pbr::OriginalName("PARSE_PB_HDR_FAIL")] ParsePbHdrFail = 10006,
    [pbr::OriginalName("PARSE_PB_PLD_FAIL")] ParsePbPldFail = 10007,
    [pbr::OriginalName("PARSE_PB_FAIL")] ParsePbFail = 10008,
    [pbr::OriginalName("DECODED_LEN_FAIL")] DecodedLenFail = 10009,
    [pbr::OriginalName("INVALID_KEY")] InvalidKey = 10010,
    [pbr::OriginalName("ENCRYPT_FAIL")] EncryptFail = 10011,
    [pbr::OriginalName("DECRYPT_FAIL")] DecryptFail = 10012,
    [pbr::OriginalName("INVALID_TAG")] InvalidTag = 10013,
    [pbr::OriginalName("INVALID_VER")] InvalidVer = 10014,
    [pbr::OriginalName("INVALID_COMPRESS_TYPE")] InvalidCompressType = 10016,
    [pbr::OriginalName("INVALID_ENCRYPT_TYPE")] InvalidEncryptType = 10017,
    [pbr::OriginalName("NOT_REGISTER")] NotRegister = 10018,
    [pbr::OriginalName("USER_NOT_ONLINE")] UserNotOnline = 10019,
    [pbr::OriginalName("INVALID_COMMAND")] InvalidCommand = 10020,
    [pbr::OriginalName("PUSH_UNREGISTER_ERROR")] PushUnregisterError = 10021,
    [pbr::OriginalName("INVALID_SID")] InvalidSid = 10022,
    [pbr::OriginalName("INVALID_INSTANCE_ID")] InvalidInstanceId = 10023,
    [pbr::OriginalName("CLIENT_LOCALE_NOT_MATCH")] ClientLocaleNotMatch = 10024,
    [pbr::OriginalName("INVALID_TOKEN_PASSWORD_CHANGED")] InvalidTokenPasswordChanged = 10025,
    [pbr::OriginalName("INVALID_TOKEN_TOKEN_EXPIRED")] InvalidTokenTokenExpired = 10026,
    [pbr::OriginalName("INVALID_TOKEN_TOKEN_VALUE_ERROR")] InvalidTokenTokenValueError = 10027,
    [pbr::OriginalName("INVALID_TOKEN_LOGIN_ON_OTHER_DEVICE")] InvalidTokenLoginOnOtherDevice = 10028,
    [pbr::OriginalName("FORCE_RECONNECT")] ForceReconnect = 10029,
    [pbr::OriginalName("CLIENT_TIMEOUT")] ClientTimeout = 10030,
    [pbr::OriginalName("INVALID_ARGUMENT")] InvalidArgument = 10031,
    [pbr::OriginalName("INVALID_FORMAT_TOKEN")] InvalidFormatToken = 10032,
    [pbr::OriginalName("EMPTY_PAYLOAD")] EmptyPayload = 10033,
    [pbr::OriginalName("COMPRESS_FAIL")] CompressFail = 10034,
    [pbr::OriginalName("DECOMPRESS_FAIL")] DecompressFail = 10035,
    [pbr::OriginalName("OUT_OF_ORDER")] OutOfOrder = 10036,
    [pbr::OriginalName("OUT_OF_LIMIT")] OutOfLimit = 10037,
    [pbr::OriginalName("TOO_LARGE_PAYLOAD")] TooLargePayload = 10038,
    [pbr::OriginalName("ANONYMOUSE_ERROR")] AnonymouseError = 10039,
    [pbr::OriginalName("BASIC_MAX")] BasicMax = 19999,
  }

  #endregion

}

#endregion Designer generated code