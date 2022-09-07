﻿using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using AcFunDanmu.Enums;
using AcFunDanmu.Im.Basic;
using Google.Protobuf;
using Microsoft.Extensions.Logging;
using static AcFunDanmu.ClientUtils;

namespace AcFunDanmu
{
    internal class ClientRequestUtils
    {
        private const string AppName = "link-sdk";
        private const string SdkVersion = "1.4.0.145";
        private const string KPN = "ACFUN_APP.LIVE_MATE";
        private const string KPF = "WINDOWS_PC";
        private const string SubBiz = "mainApp";
        private const string ClientLiveSdkVersion = "kwai-acfun-live-link";
        private const string LinkVersion = "2.13.8";
        private const uint RetryCount = 1;
        private readonly string Did;
        private readonly string EnterRoomAttach;
        private readonly string LiveId;
        private readonly string SecurityKey;
        private readonly string ServiceToken;
        private readonly string[] Tickets;

        private readonly long UserId;

        private int AppId;
        private long InstanceId;
        private long Lz4CompressionThreshold;

        private long SeqId = 1;
        private int TicketIndex;

        public ClientRequestUtils(long userid, string did, string servicetoken, string securitykey, string liveid,
            string enterroomattach, string[] tickets)
        {
            UserId = userid;
            Did = did;
            ServiceToken = Convert.ToBase64String(Encoding.UTF8.GetBytes(servicetoken));
            SecurityKey = securitykey;
            LiveId = liveid;
            EnterRoomAttach = enterroomattach;
            Tickets = tickets;
        }

        public string SessionKey { get; private set; }
        public long HeartbeatSeqId { get; private set; }

        private string Ticket => Tickets[TicketIndex];

        public void Register(int appId, long instanceId, string sessionKey, long lz4compressionthreshold)
        {
            AppId = appId;
            InstanceId = instanceId;
            SessionKey = sessionKey;
            Lz4CompressionThreshold = lz4compressionthreshold;
        }

        public void NextTicket()
        {
            TicketIndex = TicketIndex++ % Tickets.Length;
        }

        public byte[] HandshakeRequest()
        {
            var handshake = new HandshakeRequest
            {
                Unknown1 = 1,
                Unknown2 = 1
            };

            var payload = GeneratePayload(Command.HANDSHAKE, handshake);

            var body = payload.ToByteArray();

            var header = GenerateHeader(body, PacketHeader.Types.EncryptionMode.KEncryptionServiceToken);
            header.TokenInfo = new TokenInfo
            {
                TokenType = TokenInfo.Types.TokenType.KServiceToken,
                Token = ByteString.FromBase64(ServiceToken)
            };

            Client.Logger.LogDebug("--------");
            Client.Logger.LogDebug("Up\t\t {HeaderSeqId}, {SeqId}, {Command}", header.SeqId, payload.SeqId,
                payload.Command);
            Client.Logger.LogDebug("Header: {Header}", header);
            Client.Logger.LogDebug("Payload Base64: {Payload}", Convert.ToBase64String(body));
            Client.Logger.LogDebug("Payload: {Payload}", payload);
            Client.Logger.LogDebug("\t{Handshake}", handshake);
            Client.Logger.LogDebug("--------");

            return Encode(header, body, SecurityKey);
        }

        public byte[] RegisterRequest()
        {
            var register = new RegisterRequest
            {
                AppInfo = new AppInfo
                {
                    SdkVersion = ClientLiveSdkVersion,
                    LinkVersion = LinkVersion
                },
                DeviceInfo = new DeviceInfo
                {
                    PlatformType = DeviceInfo.Types.PlatformType.H5Windows,
                    DeviceModel = "h5"
                },
                PresenceStatus = Im.Basic.RegisterRequest.Types.PresenceStatus.KPresenceOnline,
                AppActiveStatus = Im.Basic.RegisterRequest.Types.ActiveStatus.KAppInForeground,
                InstanceId = InstanceId,
                ZtCommonInfo = new ZtCommonInfo
                {
                    Kpn = KPN,
                    Kpf = KPF,
                    Uid = UserId
                }
            };

            var payload = GeneratePayload(Command.REGISTER, register);

            var body = payload.ToByteArray();

            var header = GenerateHeader(body, PacketHeader.Types.EncryptionMode.KEncryptionServiceToken);
            header.TokenInfo = new TokenInfo
            {
                TokenType = TokenInfo.Types.TokenType.KServiceToken,
                Token = ByteString.FromBase64(ServiceToken)
            };

            Interlocked.Increment(ref SeqId);

            Client.Logger.LogDebug("--------");
            Client.Logger.LogDebug("Up\t\t {HeaderSeqId}, {SeqId}, {Command}", header.SeqId, payload.SeqId,
                payload.Command);
            Client.Logger.LogDebug("Header: {Header}", header);
            Client.Logger.LogDebug("Payload Base64: {Payload}", Convert.ToBase64String(body));
            Client.Logger.LogDebug("Payload: {Payload}", payload);
            Client.Logger.LogDebug("\t{Register}", register);
            Client.Logger.LogDebug("--------");

            return Encode(header, body, SecurityKey);
        }

        public byte[] KeepAliveRequest()
        {
            var keepalive = new KeepAliveRequest
            {
                PresenceStatus = Im.Basic.RegisterRequest.Types.PresenceStatus.KPresenceOnline,
                AppActiveStatus = Im.Basic.RegisterRequest.Types.ActiveStatus.KAppInForeground
            };

            var payload = GeneratePayload(Command.KEEP_ALIVE, keepalive);

            var body = payload.ToByteArray();

            var header = GenerateHeader(body);

            Interlocked.Increment(ref SeqId);

            Client.Logger.LogDebug("--------");
            Client.Logger.LogDebug("Up\t\t {HeaderSeqId}, {SeqId}, {Command}", header.SeqId, payload.SeqId,
                payload.Command);
            Client.Logger.LogDebug("Header: {Header}", header);
            Client.Logger.LogDebug("Payload Base64: {Payload}", Convert.ToBase64String(body));
            Client.Logger.LogDebug("Payload: {Payload}", payload);
            Client.Logger.LogDebug("\t{KeepAlive}", keepalive);
            Client.Logger.LogDebug("--------");

            return Encode(header, body, SessionKey);
        }

        public byte[] EnterRoomRequest()
        {
            var enterroom = new ZtLiveCsEnterRoom
            {
                EnterRoomAttach = EnterRoomAttach,
                ClientLiveSdkVersion = ClientLiveSdkVersion
            };

            var cmd = GenerateCommand(GlobalCommand.ENTER_ROOM, enterroom);

            var payload = GeneratePayload(Command.GLOBAL_COMMAND, cmd);

            var body = payload.ToByteArray();

            var header = GenerateHeader(body);

            Interlocked.Increment(ref SeqId);

            Client.Logger.LogDebug("--------");
            Client.Logger.LogDebug("Up\t\t {HeaderSeqId}, {SeqId}, {Command}", header.SeqId, payload.SeqId,
                payload.Command);
            Client.Logger.LogDebug("Header: {Header}", header);
            Client.Logger.LogDebug("Payload Base64: {Payload}", Convert.ToBase64String(body));
            Client.Logger.LogDebug("Payload: {Payload}", payload);
            Client.Logger.LogDebug("\t{Command}", cmd);
            Client.Logger.LogDebug("\t\t{EnterRoom}", enterroom);
            Client.Logger.LogDebug("--------");

            return Encode(header, body, SessionKey);
        }

        public byte[] PushMessageResponse(long HeaderSeqId)
        {
            var payload = GeneratePayload(Command.PUSH_MESSAGE);

            var body = payload.ToByteArray();

            var header = GenerateHeader(body);
            header.SeqId = HeaderSeqId;

            Client.Logger.LogDebug("Up\t\t {HeaderSeqId}, {SeqId}, {Command}", header.SeqId, payload.SeqId,
                payload.Command);
            Client.Logger.LogDebug("Header: {Header}", header);
            Client.Logger.LogDebug("Payload Base64: {Payload}", Convert.ToBase64String(body));
            Client.Logger.LogDebug("Payload: {Payload}", payload);
            Client.Logger.LogDebug("\t{PushMessage}", "Empty");

            return Encode(header, body, SessionKey);
        }

        public byte[] HeartbeatReqeust()
        {
            var heartbeat = new ZtLiveCsHeartbeat
            {
                ClientTimestampMs = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                Sequence = HeartbeatSeqId
            };

            var cmd = GenerateCommand(GlobalCommand.HEARTBEAT, heartbeat);

            var payload = GeneratePayload(Command.GLOBAL_COMMAND, cmd);

            var body = payload.ToByteArray();

            var header = GenerateHeader(body);

            HeartbeatSeqId++;
            Interlocked.Increment(ref SeqId);

            Client.Logger.LogDebug("--------");
            Client.Logger.LogDebug("Up\t\t {HeaderSeqId}, {SeqId}, {Command}", header.SeqId, payload.SeqId,
                payload.Command);
            Client.Logger.LogDebug("Header: {Header}", header);
            Client.Logger.LogDebug("Payload Base64: {Payload}", Convert.ToBase64String(body));
            Client.Logger.LogDebug("Payload: {Payload}", payload);
            Client.Logger.LogDebug("\t{Command}", cmd);
            Client.Logger.LogDebug("\t\t{Heartbeat}", heartbeat);
            Client.Logger.LogDebug("--------");

            return Encode(header, body, SessionKey);
        }

        public byte[] UserExitRequest()
        {
            var userexit = GenerateCommand(GlobalCommand.USER_EXIT);

            var payload = GeneratePayload(Command.GLOBAL_COMMAND, userexit);

            var body = payload.ToByteArray();

            var header = GenerateHeader(body);

            Interlocked.Increment(ref SeqId);

            Client.Logger.LogDebug("--------");
            Client.Logger.LogDebug("Up\t\t {HeaderSeqId}, {SeqId}, {Command}", header.SeqId, payload.SeqId,
                payload.Command);
            Client.Logger.LogDebug("Header: {Header}", header);
            Client.Logger.LogDebug("Payload Base64: {Payload}", Convert.ToBase64String(body));
            Client.Logger.LogDebug("Payload: {Payload}", payload);
            Client.Logger.LogDebug("\t{UserExit}", userexit);
            Client.Logger.LogDebug("--------");

            return Encode(header, body, SessionKey);
        }

        public byte[] UnregisterRequest()
        {
            var payload = GeneratePayload(Command.UNREGISTER);

            var body = payload.ToByteArray();

            var header = GenerateHeader(body);

            Client.Logger.LogDebug("--------");
            Client.Logger.LogDebug("Up\t\t {HeaderSeqId}, {SeqId}, {Command}", header.SeqId, payload.SeqId,
                payload.Command);
            Client.Logger.LogDebug("Header: {Header}", header);
            Client.Logger.LogDebug("Payload Base64: {Payload}", Convert.ToBase64String(body));
            Client.Logger.LogDebug("Payload: {Payload}", payload);
            Client.Logger.LogDebug("\t{Unregister}", "Empty");
            Client.Logger.LogDebug("--------");

            return Encode(header, body, SessionKey);
        }

        public byte[] PingRequest()
        {
            var ping = new PingRequest
            {
                PingType = Im.Basic.PingRequest.Types.PingType.KPostRegister
            };

            var payload = GeneratePayload(Command.PING, ping);

            var body = payload.ToByteArray();

            var header = GenerateHeader(body);

            Client.Logger.LogDebug("--------");
            Client.Logger.LogDebug("Up\t\t {HeaderSeqId}, {SeqId}, {Command}", header.SeqId, payload.SeqId,
                payload.Command);
            Client.Logger.LogDebug("Header: {Header}", header);
            Client.Logger.LogDebug("Payload Base64: {Payload}", Convert.ToBase64String(body));
            Client.Logger.LogDebug("Payload: {Payload}", payload);
            Client.Logger.LogDebug("\t{Ping}", ping);
            Client.Logger.LogDebug("--------");

            return Encode(header, body, SessionKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ZtLiveCsCmd GenerateCommand(in string command, in IMessage msg = null)
        {
            return new ZtLiveCsCmd
            {
                CmdType = command,
                Ticket = Ticket,
                LiveId = LiveId,
                Payload = msg?.ToByteString() ?? ByteString.Empty
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private UpstreamPayload GeneratePayload(in string command, in IMessage msg = null)
        {
            return new UpstreamPayload
            {
                Command = command,
                RetryCount = RetryCount,
                SeqId = SeqId,
                SubBiz = SubBiz,
                PayloadData = msg?.ToByteString() ?? ByteString.Empty
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private PacketHeader GenerateHeader(in ByteString body,
            in PacketHeader.Types.EncryptionMode encryptionMode =
                PacketHeader.Types.EncryptionMode.KEncryptionSessionKey)
        {
            return new PacketHeader
            {
                AppId = AppId,
                Uid = UserId,
                InstanceId = InstanceId,
                DecodedPayloadLen = Convert.ToUInt32(body.Length),
                EncryptionMode = encryptionMode,
                SeqId = SeqId,
                Kpn = KPN
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private PacketHeader GenerateHeader(in ReadOnlySpan<byte> body,
            in PacketHeader.Types.EncryptionMode encryptionMode =
                PacketHeader.Types.EncryptionMode.KEncryptionSessionKey)
        {
            return new PacketHeader
            {
                AppId = AppId,
                Uid = UserId,
                InstanceId = InstanceId,
                DecodedPayloadLen = Convert.ToUInt32(body.Length),
                EncryptionMode = encryptionMode,
                SeqId = SeqId,
                Kpn = KPN
            };
        }
    }
}