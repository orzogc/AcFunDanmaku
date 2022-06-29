// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UserLoginDeviceInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Profile {

  /// <summary>Holder for reflection information generated from UserLoginDeviceInfo.proto</summary>
  public static partial class UserLoginDeviceInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for UserLoginDeviceInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserLoginDeviceInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVc2VyTG9naW5EZXZpY2VJbmZvLnByb3RvEhtBY0Z1bkRhbm11LkltLkNs",
            "b3VkLlByb2ZpbGUicwoTVXNlckxvZ2luRGV2aWNlSW5mbxIQCghkZXZpY2VJ",
            "ZBgBIAEoCRISCgpkZXZpY2VOYW1lGAIgASgJEgsKA2twZhgDIAEoCRIWCg5s",
            "YXN0T25saW5lVGltZRgEIAEoAxIRCgliaXpTdGF0dXMYBSABKAViBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Profile.UserLoginDeviceInfo), global::AcFunDanmu.Im.Cloud.Profile.UserLoginDeviceInfo.Parser, new[]{ "DeviceId", "DeviceName", "Kpf", "LastOnlineTime", "BizStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UserLoginDeviceInfo : pb::IMessage<UserLoginDeviceInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserLoginDeviceInfo> _parser = new pb::MessageParser<UserLoginDeviceInfo>(() => new UserLoginDeviceInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserLoginDeviceInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Profile.UserLoginDeviceInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserLoginDeviceInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserLoginDeviceInfo(UserLoginDeviceInfo other) : this() {
      deviceId_ = other.deviceId_;
      deviceName_ = other.deviceName_;
      kpf_ = other.kpf_;
      lastOnlineTime_ = other.lastOnlineTime_;
      bizStatus_ = other.bizStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserLoginDeviceInfo Clone() {
      return new UserLoginDeviceInfo(this);
    }

    /// <summary>Field number for the "deviceId" field.</summary>
    public const int DeviceIdFieldNumber = 1;
    private string deviceId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DeviceId {
      get { return deviceId_; }
      set {
        deviceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deviceName" field.</summary>
    public const int DeviceNameFieldNumber = 2;
    private string deviceName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DeviceName {
      get { return deviceName_; }
      set {
        deviceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "kpf" field.</summary>
    public const int KpfFieldNumber = 3;
    private string kpf_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Kpf {
      get { return kpf_; }
      set {
        kpf_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lastOnlineTime" field.</summary>
    public const int LastOnlineTimeFieldNumber = 4;
    private long lastOnlineTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long LastOnlineTime {
      get { return lastOnlineTime_; }
      set {
        lastOnlineTime_ = value;
      }
    }

    /// <summary>Field number for the "bizStatus" field.</summary>
    public const int BizStatusFieldNumber = 5;
    private int bizStatus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int BizStatus {
      get { return bizStatus_; }
      set {
        bizStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserLoginDeviceInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserLoginDeviceInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DeviceId != other.DeviceId) return false;
      if (DeviceName != other.DeviceName) return false;
      if (Kpf != other.Kpf) return false;
      if (LastOnlineTime != other.LastOnlineTime) return false;
      if (BizStatus != other.BizStatus) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
      if (DeviceName.Length != 0) hash ^= DeviceName.GetHashCode();
      if (Kpf.Length != 0) hash ^= Kpf.GetHashCode();
      if (LastOnlineTime != 0L) hash ^= LastOnlineTime.GetHashCode();
      if (BizStatus != 0) hash ^= BizStatus.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (DeviceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DeviceId);
      }
      if (DeviceName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceName);
      }
      if (Kpf.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Kpf);
      }
      if (LastOnlineTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(LastOnlineTime);
      }
      if (BizStatus != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(BizStatus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (DeviceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DeviceId);
      }
      if (DeviceName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DeviceName);
      }
      if (Kpf.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Kpf);
      }
      if (LastOnlineTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(LastOnlineTime);
      }
      if (BizStatus != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(BizStatus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (DeviceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceId);
      }
      if (DeviceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceName);
      }
      if (Kpf.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Kpf);
      }
      if (LastOnlineTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastOnlineTime);
      }
      if (BizStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BizStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UserLoginDeviceInfo other) {
      if (other == null) {
        return;
      }
      if (other.DeviceId.Length != 0) {
        DeviceId = other.DeviceId;
      }
      if (other.DeviceName.Length != 0) {
        DeviceName = other.DeviceName;
      }
      if (other.Kpf.Length != 0) {
        Kpf = other.Kpf;
      }
      if (other.LastOnlineTime != 0L) {
        LastOnlineTime = other.LastOnlineTime;
      }
      if (other.BizStatus != 0) {
        BizStatus = other.BizStatus;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
          case 10: {
            DeviceId = input.ReadString();
            break;
          }
          case 18: {
            DeviceName = input.ReadString();
            break;
          }
          case 26: {
            Kpf = input.ReadString();
            break;
          }
          case 32: {
            LastOnlineTime = input.ReadInt64();
            break;
          }
          case 40: {
            BizStatus = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            DeviceId = input.ReadString();
            break;
          }
          case 18: {
            DeviceName = input.ReadString();
            break;
          }
          case 26: {
            Kpf = input.ReadString();
            break;
          }
          case 32: {
            LastOnlineTime = input.ReadInt64();
            break;
          }
          case 40: {
            BizStatus = input.ReadInt32();
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
