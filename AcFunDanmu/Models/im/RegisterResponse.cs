// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RegisterResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Basic {

  /// <summary>Holder for reflection information generated from RegisterResponse.proto</summary>
  public static partial class RegisterResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for RegisterResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RegisterResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZSZWdpc3RlclJlc3BvbnNlLnByb3RvEhNBY0Z1bkRhbm11LkltLkJhc2lj",
            "GhhBY2Nlc3NQb2ludHNDb25maWcucHJvdG8aD1Nka09wdGlvbi5wcm90byLv",
            "AwoQUmVnaXN0ZXJSZXNwb25zZRJDChJhY2Nlc3NQb2ludHNDb25maWcYASAB",
            "KAsyJy5BY0Z1bkRhbm11LkltLkJhc2ljLkFjY2Vzc1BvaW50c0NvbmZpZxIP",
            "CgdzZXNzS2V5GAIgASgMEhIKCmluc3RhbmNlSWQYAyABKAMSMQoJc2RrT3B0",
            "aW9uGAQgASgLMh4uQWNGdW5EYW5tdS5JbS5CYXNpYy5TZGtPcHRpb24SRwoW",
            "YWNjZXNzUG9pbnRzQ29uZmlnSXB2NhgFIAEoCzInLkFjRnVuRGFubXUuSW0u",
            "QmFzaWMuQWNjZXNzUG9pbnRzQ29uZmlnEkcKFmFjY2Vzc1BvaW50c0NvbmZp",
            "Z1F1aWMYBiABKAsyJy5BY0Z1bkRhbm11LkltLkJhc2ljLkFjY2Vzc1BvaW50",
            "c0NvbmZpZxJLChphY2Nlc3NQb2ludHNDb25maWdRdWljSXB2NhgHIAEoCzIn",
            "LkFjRnVuRGFubXUuSW0uQmFzaWMuQWNjZXNzUG9pbnRzQ29uZmlnEhgKEGNs",
            "ZWFuQWNjZXNzUG9pbnQYCCABKAgSRQoUYWNjZXNzUG9pbnRzQ29uZmlnV3MY",
            "CSABKAsyJy5BY0Z1bkRhbm11LkltLkJhc2ljLkFjY2Vzc1BvaW50c0NvbmZp",
            "Z2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Basic.AccessPointsConfigReflection.Descriptor, global::AcFunDanmu.Im.Basic.SdkOptionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Basic.RegisterResponse), global::AcFunDanmu.Im.Basic.RegisterResponse.Parser, new[]{ "AccessPointsConfig", "SessKey", "InstanceId", "SdkOption", "AccessPointsConfigIpv6", "AccessPointsConfigQuic", "AccessPointsConfigQuicIpv6", "CleanAccessPoint", "AccessPointsConfigWs" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RegisterResponse : pb::IMessage<RegisterResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RegisterResponse> _parser = new pb::MessageParser<RegisterResponse>(() => new RegisterResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RegisterResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Basic.RegisterResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegisterResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegisterResponse(RegisterResponse other) : this() {
      accessPointsConfig_ = other.accessPointsConfig_ != null ? other.accessPointsConfig_.Clone() : null;
      sessKey_ = other.sessKey_;
      instanceId_ = other.instanceId_;
      sdkOption_ = other.sdkOption_ != null ? other.sdkOption_.Clone() : null;
      accessPointsConfigIpv6_ = other.accessPointsConfigIpv6_ != null ? other.accessPointsConfigIpv6_.Clone() : null;
      accessPointsConfigQuic_ = other.accessPointsConfigQuic_ != null ? other.accessPointsConfigQuic_.Clone() : null;
      accessPointsConfigQuicIpv6_ = other.accessPointsConfigQuicIpv6_ != null ? other.accessPointsConfigQuicIpv6_.Clone() : null;
      cleanAccessPoint_ = other.cleanAccessPoint_;
      accessPointsConfigWs_ = other.accessPointsConfigWs_ != null ? other.accessPointsConfigWs_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegisterResponse Clone() {
      return new RegisterResponse(this);
    }

    /// <summary>Field number for the "accessPointsConfig" field.</summary>
    public const int AccessPointsConfigFieldNumber = 1;
    private global::AcFunDanmu.Im.Basic.AccessPointsConfig accessPointsConfig_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.AccessPointsConfig AccessPointsConfig {
      get { return accessPointsConfig_; }
      set {
        accessPointsConfig_ = value;
      }
    }

    /// <summary>Field number for the "sessKey" field.</summary>
    public const int SessKeyFieldNumber = 2;
    private pb::ByteString sessKey_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString SessKey {
      get { return sessKey_; }
      set {
        sessKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "instanceId" field.</summary>
    public const int InstanceIdFieldNumber = 3;
    private long instanceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long InstanceId {
      get { return instanceId_; }
      set {
        instanceId_ = value;
      }
    }

    /// <summary>Field number for the "sdkOption" field.</summary>
    public const int SdkOptionFieldNumber = 4;
    private global::AcFunDanmu.Im.Basic.SdkOption sdkOption_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.SdkOption SdkOption {
      get { return sdkOption_; }
      set {
        sdkOption_ = value;
      }
    }

    /// <summary>Field number for the "accessPointsConfigIpv6" field.</summary>
    public const int AccessPointsConfigIpv6FieldNumber = 5;
    private global::AcFunDanmu.Im.Basic.AccessPointsConfig accessPointsConfigIpv6_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.AccessPointsConfig AccessPointsConfigIpv6 {
      get { return accessPointsConfigIpv6_; }
      set {
        accessPointsConfigIpv6_ = value;
      }
    }

    /// <summary>Field number for the "accessPointsConfigQuic" field.</summary>
    public const int AccessPointsConfigQuicFieldNumber = 6;
    private global::AcFunDanmu.Im.Basic.AccessPointsConfig accessPointsConfigQuic_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.AccessPointsConfig AccessPointsConfigQuic {
      get { return accessPointsConfigQuic_; }
      set {
        accessPointsConfigQuic_ = value;
      }
    }

    /// <summary>Field number for the "accessPointsConfigQuicIpv6" field.</summary>
    public const int AccessPointsConfigQuicIpv6FieldNumber = 7;
    private global::AcFunDanmu.Im.Basic.AccessPointsConfig accessPointsConfigQuicIpv6_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.AccessPointsConfig AccessPointsConfigQuicIpv6 {
      get { return accessPointsConfigQuicIpv6_; }
      set {
        accessPointsConfigQuicIpv6_ = value;
      }
    }

    /// <summary>Field number for the "cleanAccessPoint" field.</summary>
    public const int CleanAccessPointFieldNumber = 8;
    private bool cleanAccessPoint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CleanAccessPoint {
      get { return cleanAccessPoint_; }
      set {
        cleanAccessPoint_ = value;
      }
    }

    /// <summary>Field number for the "accessPointsConfigWs" field.</summary>
    public const int AccessPointsConfigWsFieldNumber = 9;
    private global::AcFunDanmu.Im.Basic.AccessPointsConfig accessPointsConfigWs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.AccessPointsConfig AccessPointsConfigWs {
      get { return accessPointsConfigWs_; }
      set {
        accessPointsConfigWs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RegisterResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RegisterResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AccessPointsConfig, other.AccessPointsConfig)) return false;
      if (SessKey != other.SessKey) return false;
      if (InstanceId != other.InstanceId) return false;
      if (!object.Equals(SdkOption, other.SdkOption)) return false;
      if (!object.Equals(AccessPointsConfigIpv6, other.AccessPointsConfigIpv6)) return false;
      if (!object.Equals(AccessPointsConfigQuic, other.AccessPointsConfigQuic)) return false;
      if (!object.Equals(AccessPointsConfigQuicIpv6, other.AccessPointsConfigQuicIpv6)) return false;
      if (CleanAccessPoint != other.CleanAccessPoint) return false;
      if (!object.Equals(AccessPointsConfigWs, other.AccessPointsConfigWs)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (accessPointsConfig_ != null) hash ^= AccessPointsConfig.GetHashCode();
      if (SessKey.Length != 0) hash ^= SessKey.GetHashCode();
      if (InstanceId != 0L) hash ^= InstanceId.GetHashCode();
      if (sdkOption_ != null) hash ^= SdkOption.GetHashCode();
      if (accessPointsConfigIpv6_ != null) hash ^= AccessPointsConfigIpv6.GetHashCode();
      if (accessPointsConfigQuic_ != null) hash ^= AccessPointsConfigQuic.GetHashCode();
      if (accessPointsConfigQuicIpv6_ != null) hash ^= AccessPointsConfigQuicIpv6.GetHashCode();
      if (CleanAccessPoint != false) hash ^= CleanAccessPoint.GetHashCode();
      if (accessPointsConfigWs_ != null) hash ^= AccessPointsConfigWs.GetHashCode();
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
      if (accessPointsConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPointsConfig);
      }
      if (SessKey.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(SessKey);
      }
      if (InstanceId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(InstanceId);
      }
      if (sdkOption_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SdkOption);
      }
      if (accessPointsConfigIpv6_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(AccessPointsConfigIpv6);
      }
      if (accessPointsConfigQuic_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AccessPointsConfigQuic);
      }
      if (accessPointsConfigQuicIpv6_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(AccessPointsConfigQuicIpv6);
      }
      if (CleanAccessPoint != false) {
        output.WriteRawTag(64);
        output.WriteBool(CleanAccessPoint);
      }
      if (accessPointsConfigWs_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(AccessPointsConfigWs);
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
      if (accessPointsConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AccessPointsConfig);
      }
      if (SessKey.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(SessKey);
      }
      if (InstanceId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(InstanceId);
      }
      if (sdkOption_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SdkOption);
      }
      if (accessPointsConfigIpv6_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(AccessPointsConfigIpv6);
      }
      if (accessPointsConfigQuic_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AccessPointsConfigQuic);
      }
      if (accessPointsConfigQuicIpv6_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(AccessPointsConfigQuicIpv6);
      }
      if (CleanAccessPoint != false) {
        output.WriteRawTag(64);
        output.WriteBool(CleanAccessPoint);
      }
      if (accessPointsConfigWs_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(AccessPointsConfigWs);
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
      if (accessPointsConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccessPointsConfig);
      }
      if (SessKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(SessKey);
      }
      if (InstanceId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(InstanceId);
      }
      if (sdkOption_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SdkOption);
      }
      if (accessPointsConfigIpv6_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccessPointsConfigIpv6);
      }
      if (accessPointsConfigQuic_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccessPointsConfigQuic);
      }
      if (accessPointsConfigQuicIpv6_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccessPointsConfigQuicIpv6);
      }
      if (CleanAccessPoint != false) {
        size += 1 + 1;
      }
      if (accessPointsConfigWs_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccessPointsConfigWs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RegisterResponse other) {
      if (other == null) {
        return;
      }
      if (other.accessPointsConfig_ != null) {
        if (accessPointsConfig_ == null) {
          AccessPointsConfig = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
        }
        AccessPointsConfig.MergeFrom(other.AccessPointsConfig);
      }
      if (other.SessKey.Length != 0) {
        SessKey = other.SessKey;
      }
      if (other.InstanceId != 0L) {
        InstanceId = other.InstanceId;
      }
      if (other.sdkOption_ != null) {
        if (sdkOption_ == null) {
          SdkOption = new global::AcFunDanmu.Im.Basic.SdkOption();
        }
        SdkOption.MergeFrom(other.SdkOption);
      }
      if (other.accessPointsConfigIpv6_ != null) {
        if (accessPointsConfigIpv6_ == null) {
          AccessPointsConfigIpv6 = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
        }
        AccessPointsConfigIpv6.MergeFrom(other.AccessPointsConfigIpv6);
      }
      if (other.accessPointsConfigQuic_ != null) {
        if (accessPointsConfigQuic_ == null) {
          AccessPointsConfigQuic = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
        }
        AccessPointsConfigQuic.MergeFrom(other.AccessPointsConfigQuic);
      }
      if (other.accessPointsConfigQuicIpv6_ != null) {
        if (accessPointsConfigQuicIpv6_ == null) {
          AccessPointsConfigQuicIpv6 = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
        }
        AccessPointsConfigQuicIpv6.MergeFrom(other.AccessPointsConfigQuicIpv6);
      }
      if (other.CleanAccessPoint != false) {
        CleanAccessPoint = other.CleanAccessPoint;
      }
      if (other.accessPointsConfigWs_ != null) {
        if (accessPointsConfigWs_ == null) {
          AccessPointsConfigWs = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
        }
        AccessPointsConfigWs.MergeFrom(other.AccessPointsConfigWs);
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
            if (accessPointsConfig_ == null) {
              AccessPointsConfig = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
            }
            input.ReadMessage(AccessPointsConfig);
            break;
          }
          case 18: {
            SessKey = input.ReadBytes();
            break;
          }
          case 24: {
            InstanceId = input.ReadInt64();
            break;
          }
          case 34: {
            if (sdkOption_ == null) {
              SdkOption = new global::AcFunDanmu.Im.Basic.SdkOption();
            }
            input.ReadMessage(SdkOption);
            break;
          }
          case 42: {
            if (accessPointsConfigIpv6_ == null) {
              AccessPointsConfigIpv6 = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
            }
            input.ReadMessage(AccessPointsConfigIpv6);
            break;
          }
          case 50: {
            if (accessPointsConfigQuic_ == null) {
              AccessPointsConfigQuic = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
            }
            input.ReadMessage(AccessPointsConfigQuic);
            break;
          }
          case 58: {
            if (accessPointsConfigQuicIpv6_ == null) {
              AccessPointsConfigQuicIpv6 = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
            }
            input.ReadMessage(AccessPointsConfigQuicIpv6);
            break;
          }
          case 64: {
            CleanAccessPoint = input.ReadBool();
            break;
          }
          case 74: {
            if (accessPointsConfigWs_ == null) {
              AccessPointsConfigWs = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
            }
            input.ReadMessage(AccessPointsConfigWs);
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
            if (accessPointsConfig_ == null) {
              AccessPointsConfig = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
            }
            input.ReadMessage(AccessPointsConfig);
            break;
          }
          case 18: {
            SessKey = input.ReadBytes();
            break;
          }
          case 24: {
            InstanceId = input.ReadInt64();
            break;
          }
          case 34: {
            if (sdkOption_ == null) {
              SdkOption = new global::AcFunDanmu.Im.Basic.SdkOption();
            }
            input.ReadMessage(SdkOption);
            break;
          }
          case 42: {
            if (accessPointsConfigIpv6_ == null) {
              AccessPointsConfigIpv6 = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
            }
            input.ReadMessage(AccessPointsConfigIpv6);
            break;
          }
          case 50: {
            if (accessPointsConfigQuic_ == null) {
              AccessPointsConfigQuic = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
            }
            input.ReadMessage(AccessPointsConfigQuic);
            break;
          }
          case 58: {
            if (accessPointsConfigQuicIpv6_ == null) {
              AccessPointsConfigQuicIpv6 = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
            }
            input.ReadMessage(AccessPointsConfigQuicIpv6);
            break;
          }
          case 64: {
            CleanAccessPoint = input.ReadBool();
            break;
          }
          case 74: {
            if (accessPointsConfigWs_ == null) {
              AccessPointsConfigWs = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
            }
            input.ReadMessage(AccessPointsConfigWs);
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
