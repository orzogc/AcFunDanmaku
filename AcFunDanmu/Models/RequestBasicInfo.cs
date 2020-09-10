// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RequestBasicInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from RequestBasicInfo.proto</summary>
  public static partial class RequestBasicInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RequestBasicInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestBasicInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZSZXF1ZXN0QmFzaWNJbmZvLnByb3RvEgpBY0Z1bkRhbm11GhBEZXZpY2VJ",
            "bmZvLnByb3RvGg1BcHBJbmZvLnByb3RvGg1FbnZJbmZvLnByb3RvIr8CChBS",
            "ZXF1ZXN0QmFzaWNJbmZvEjcKCmNsaWVudFR5cGUYASABKA4yIy5BY0Z1bkRh",
            "bm11LkRldmljZUluZm8uUGxhdGZvcm1UeXBlEhAKCGRldmljZUlkGAIgASgJ",
            "EhAKCGNsaWVudElwGAMgASgJEhIKCmFwcFZlcnNpb24YBCABKAkSDwoHY2hh",
            "bm5lbBgFIAEoCRIkCgdhcHBJbmZvGAYgASgLMhMuQWNGdW5EYW5tdS5BcHBJ",
            "bmZvEioKCmRldmljZUluZm8YByABKAsyFi5BY0Z1bkRhbm11LkRldmljZUlu",
            "Zm8SJAoHZW52SW5mbxgIIAEoCzITLkFjRnVuRGFubXUuRW52SW5mbxISCgpj",
            "bGllbnRQb3J0GAkgASgFEhAKCGxvY2F0aW9uGAogASgJEgsKA2twZhgLIAEo",
            "CWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.DeviceInfoReflection.Descriptor, global::AcFunDanmu.AppInfoReflection.Descriptor, global::AcFunDanmu.EnvInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.RequestBasicInfo), global::AcFunDanmu.RequestBasicInfo.Parser, new[]{ "ClientType", "DeviceId", "ClientIp", "AppVersion", "Channel", "AppInfo", "DeviceInfo", "EnvInfo", "ClientPort", "Location", "Kpf" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///RequsetBasicInfo
  /// </summary>
  public sealed partial class RequestBasicInfo : pb::IMessage<RequestBasicInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RequestBasicInfo> _parser = new pb::MessageParser<RequestBasicInfo>(() => new RequestBasicInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestBasicInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.RequestBasicInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestBasicInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestBasicInfo(RequestBasicInfo other) : this() {
      clientType_ = other.clientType_;
      deviceId_ = other.deviceId_;
      clientIp_ = other.clientIp_;
      appVersion_ = other.appVersion_;
      channel_ = other.channel_;
      appInfo_ = other.appInfo_ != null ? other.appInfo_.Clone() : null;
      deviceInfo_ = other.deviceInfo_ != null ? other.deviceInfo_.Clone() : null;
      envInfo_ = other.envInfo_ != null ? other.envInfo_.Clone() : null;
      clientPort_ = other.clientPort_;
      location_ = other.location_;
      kpf_ = other.kpf_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestBasicInfo Clone() {
      return new RequestBasicInfo(this);
    }

    /// <summary>Field number for the "clientType" field.</summary>
    public const int ClientTypeFieldNumber = 1;
    private global::AcFunDanmu.DeviceInfo.Types.PlatformType clientType_ = global::AcFunDanmu.DeviceInfo.Types.PlatformType.KInvalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.DeviceInfo.Types.PlatformType ClientType {
      get { return clientType_; }
      set {
        clientType_ = value;
      }
    }

    /// <summary>Field number for the "deviceId" field.</summary>
    public const int DeviceIdFieldNumber = 2;
    private string deviceId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceId {
      get { return deviceId_; }
      set {
        deviceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "clientIp" field.</summary>
    public const int ClientIpFieldNumber = 3;
    private string clientIp_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientIp {
      get { return clientIp_; }
      set {
        clientIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "appVersion" field.</summary>
    public const int AppVersionFieldNumber = 4;
    private string appVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppVersion {
      get { return appVersion_; }
      set {
        appVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "channel" field.</summary>
    public const int ChannelFieldNumber = 5;
    private string channel_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Channel {
      get { return channel_; }
      set {
        channel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "appInfo" field.</summary>
    public const int AppInfoFieldNumber = 6;
    private global::AcFunDanmu.AppInfo appInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.AppInfo AppInfo {
      get { return appInfo_; }
      set {
        appInfo_ = value;
      }
    }

    /// <summary>Field number for the "deviceInfo" field.</summary>
    public const int DeviceInfoFieldNumber = 7;
    private global::AcFunDanmu.DeviceInfo deviceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.DeviceInfo DeviceInfo {
      get { return deviceInfo_; }
      set {
        deviceInfo_ = value;
      }
    }

    /// <summary>Field number for the "envInfo" field.</summary>
    public const int EnvInfoFieldNumber = 8;
    private global::AcFunDanmu.EnvInfo envInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.EnvInfo EnvInfo {
      get { return envInfo_; }
      set {
        envInfo_ = value;
      }
    }

    /// <summary>Field number for the "clientPort" field.</summary>
    public const int ClientPortFieldNumber = 9;
    private int clientPort_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ClientPort {
      get { return clientPort_; }
      set {
        clientPort_ = value;
      }
    }

    /// <summary>Field number for the "location" field.</summary>
    public const int LocationFieldNumber = 10;
    private string location_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Location {
      get { return location_; }
      set {
        location_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "kpf" field.</summary>
    public const int KpfFieldNumber = 11;
    private string kpf_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Kpf {
      get { return kpf_; }
      set {
        kpf_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestBasicInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestBasicInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientType != other.ClientType) return false;
      if (DeviceId != other.DeviceId) return false;
      if (ClientIp != other.ClientIp) return false;
      if (AppVersion != other.AppVersion) return false;
      if (Channel != other.Channel) return false;
      if (!object.Equals(AppInfo, other.AppInfo)) return false;
      if (!object.Equals(DeviceInfo, other.DeviceInfo)) return false;
      if (!object.Equals(EnvInfo, other.EnvInfo)) return false;
      if (ClientPort != other.ClientPort) return false;
      if (Location != other.Location) return false;
      if (Kpf != other.Kpf) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientType != global::AcFunDanmu.DeviceInfo.Types.PlatformType.KInvalid) hash ^= ClientType.GetHashCode();
      if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
      if (ClientIp.Length != 0) hash ^= ClientIp.GetHashCode();
      if (AppVersion.Length != 0) hash ^= AppVersion.GetHashCode();
      if (Channel.Length != 0) hash ^= Channel.GetHashCode();
      if (appInfo_ != null) hash ^= AppInfo.GetHashCode();
      if (deviceInfo_ != null) hash ^= DeviceInfo.GetHashCode();
      if (envInfo_ != null) hash ^= EnvInfo.GetHashCode();
      if (ClientPort != 0) hash ^= ClientPort.GetHashCode();
      if (Location.Length != 0) hash ^= Location.GetHashCode();
      if (Kpf.Length != 0) hash ^= Kpf.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ClientType != global::AcFunDanmu.DeviceInfo.Types.PlatformType.KInvalid) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ClientType);
      }
      if (DeviceId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceId);
      }
      if (ClientIp.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ClientIp);
      }
      if (AppVersion.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AppVersion);
      }
      if (Channel.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Channel);
      }
      if (appInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AppInfo);
      }
      if (deviceInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(DeviceInfo);
      }
      if (envInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(EnvInfo);
      }
      if (ClientPort != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(ClientPort);
      }
      if (Location.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Location);
      }
      if (Kpf.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Kpf);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ClientType != global::AcFunDanmu.DeviceInfo.Types.PlatformType.KInvalid) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ClientType);
      }
      if (DeviceId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceId);
      }
      if (ClientIp.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ClientIp);
      }
      if (AppVersion.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AppVersion);
      }
      if (Channel.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Channel);
      }
      if (appInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AppInfo);
      }
      if (deviceInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(DeviceInfo);
      }
      if (envInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(EnvInfo);
      }
      if (ClientPort != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(ClientPort);
      }
      if (Location.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Location);
      }
      if (Kpf.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Kpf);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClientType != global::AcFunDanmu.DeviceInfo.Types.PlatformType.KInvalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ClientType);
      }
      if (DeviceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceId);
      }
      if (ClientIp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientIp);
      }
      if (AppVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppVersion);
      }
      if (Channel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Channel);
      }
      if (appInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppInfo);
      }
      if (deviceInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DeviceInfo);
      }
      if (envInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnvInfo);
      }
      if (ClientPort != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ClientPort);
      }
      if (Location.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Location);
      }
      if (Kpf.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Kpf);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequestBasicInfo other) {
      if (other == null) {
        return;
      }
      if (other.ClientType != global::AcFunDanmu.DeviceInfo.Types.PlatformType.KInvalid) {
        ClientType = other.ClientType;
      }
      if (other.DeviceId.Length != 0) {
        DeviceId = other.DeviceId;
      }
      if (other.ClientIp.Length != 0) {
        ClientIp = other.ClientIp;
      }
      if (other.AppVersion.Length != 0) {
        AppVersion = other.AppVersion;
      }
      if (other.Channel.Length != 0) {
        Channel = other.Channel;
      }
      if (other.appInfo_ != null) {
        if (appInfo_ == null) {
          AppInfo = new global::AcFunDanmu.AppInfo();
        }
        AppInfo.MergeFrom(other.AppInfo);
      }
      if (other.deviceInfo_ != null) {
        if (deviceInfo_ == null) {
          DeviceInfo = new global::AcFunDanmu.DeviceInfo();
        }
        DeviceInfo.MergeFrom(other.DeviceInfo);
      }
      if (other.envInfo_ != null) {
        if (envInfo_ == null) {
          EnvInfo = new global::AcFunDanmu.EnvInfo();
        }
        EnvInfo.MergeFrom(other.EnvInfo);
      }
      if (other.ClientPort != 0) {
        ClientPort = other.ClientPort;
      }
      if (other.Location.Length != 0) {
        Location = other.Location;
      }
      if (other.Kpf.Length != 0) {
        Kpf = other.Kpf;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ClientType = (global::AcFunDanmu.DeviceInfo.Types.PlatformType) input.ReadEnum();
            break;
          }
          case 18: {
            DeviceId = input.ReadString();
            break;
          }
          case 26: {
            ClientIp = input.ReadString();
            break;
          }
          case 34: {
            AppVersion = input.ReadString();
            break;
          }
          case 42: {
            Channel = input.ReadString();
            break;
          }
          case 50: {
            if (appInfo_ == null) {
              AppInfo = new global::AcFunDanmu.AppInfo();
            }
            input.ReadMessage(AppInfo);
            break;
          }
          case 58: {
            if (deviceInfo_ == null) {
              DeviceInfo = new global::AcFunDanmu.DeviceInfo();
            }
            input.ReadMessage(DeviceInfo);
            break;
          }
          case 66: {
            if (envInfo_ == null) {
              EnvInfo = new global::AcFunDanmu.EnvInfo();
            }
            input.ReadMessage(EnvInfo);
            break;
          }
          case 72: {
            ClientPort = input.ReadInt32();
            break;
          }
          case 82: {
            Location = input.ReadString();
            break;
          }
          case 90: {
            Kpf = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ClientType = (global::AcFunDanmu.DeviceInfo.Types.PlatformType) input.ReadEnum();
            break;
          }
          case 18: {
            DeviceId = input.ReadString();
            break;
          }
          case 26: {
            ClientIp = input.ReadString();
            break;
          }
          case 34: {
            AppVersion = input.ReadString();
            break;
          }
          case 42: {
            Channel = input.ReadString();
            break;
          }
          case 50: {
            if (appInfo_ == null) {
              AppInfo = new global::AcFunDanmu.AppInfo();
            }
            input.ReadMessage(AppInfo);
            break;
          }
          case 58: {
            if (deviceInfo_ == null) {
              DeviceInfo = new global::AcFunDanmu.DeviceInfo();
            }
            input.ReadMessage(DeviceInfo);
            break;
          }
          case 66: {
            if (envInfo_ == null) {
              EnvInfo = new global::AcFunDanmu.EnvInfo();
            }
            input.ReadMessage(EnvInfo);
            break;
          }
          case 72: {
            ClientPort = input.ReadInt32();
            break;
          }
          case 82: {
            Location = input.ReadString();
            break;
          }
          case 90: {
            Kpf = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
