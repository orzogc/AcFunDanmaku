// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KeepAliveResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Basic {

  /// <summary>Holder for reflection information generated from KeepAliveResponse.proto</summary>
  public static partial class KeepAliveResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for KeepAliveResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeepAliveResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdLZWVwQWxpdmVSZXNwb25zZS5wcm90bxITQWNGdW5EYW5tdS5JbS5CYXNp",
            "YxoYQWNjZXNzUG9pbnRzQ29uZmlnLnByb3RvIpIDChFLZWVwQWxpdmVSZXNw",
            "b25zZRJDChJhY2Nlc3NQb2ludHNDb25maWcYASABKAsyJy5BY0Z1bkRhbm11",
            "LkltLkJhc2ljLkFjY2Vzc1BvaW50c0NvbmZpZxISCgpzZXJ2ZXJNc2VjGAIg",
            "ASgDEkcKFmFjY2Vzc1BvaW50c0NvbmZpZ0lwdjYYAyABKAsyJy5BY0Z1bkRh",
            "bm11LkltLkJhc2ljLkFjY2Vzc1BvaW50c0NvbmZpZxJHChZhY2Nlc3NQb2lu",
            "dHNDb25maWdRdWljGAYgASgLMicuQWNGdW5EYW5tdS5JbS5CYXNpYy5BY2Nl",
            "c3NQb2ludHNDb25maWcSSwoaYWNjZXNzUG9pbnRzQ29uZmlnUXVpY0lwdjYY",
            "ByABKAsyJy5BY0Z1bkRhbm11LkltLkJhc2ljLkFjY2Vzc1BvaW50c0NvbmZp",
            "ZxJFChRhY2Nlc3NQb2ludHNDb25maWdXcxgIIAEoCzInLkFjRnVuRGFubXUu",
            "SW0uQmFzaWMuQWNjZXNzUG9pbnRzQ29uZmlnYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Basic.AccessPointsConfigReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Basic.KeepAliveResponse), global::AcFunDanmu.Im.Basic.KeepAliveResponse.Parser, new[]{ "AccessPointsConfig", "ServerMsec", "AccessPointsConfigIpv6", "AccessPointsConfigQuic", "AccessPointsConfigQuicIpv6", "AccessPointsConfigWs" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class KeepAliveResponse : pb::IMessage<KeepAliveResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KeepAliveResponse> _parser = new pb::MessageParser<KeepAliveResponse>(() => new KeepAliveResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KeepAliveResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Basic.KeepAliveResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeepAliveResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeepAliveResponse(KeepAliveResponse other) : this() {
      accessPointsConfig_ = other.accessPointsConfig_ != null ? other.accessPointsConfig_.Clone() : null;
      serverMsec_ = other.serverMsec_;
      accessPointsConfigIpv6_ = other.accessPointsConfigIpv6_ != null ? other.accessPointsConfigIpv6_.Clone() : null;
      accessPointsConfigQuic_ = other.accessPointsConfigQuic_ != null ? other.accessPointsConfigQuic_.Clone() : null;
      accessPointsConfigQuicIpv6_ = other.accessPointsConfigQuicIpv6_ != null ? other.accessPointsConfigQuicIpv6_.Clone() : null;
      accessPointsConfigWs_ = other.accessPointsConfigWs_ != null ? other.accessPointsConfigWs_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeepAliveResponse Clone() {
      return new KeepAliveResponse(this);
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

    /// <summary>Field number for the "serverMsec" field.</summary>
    public const int ServerMsecFieldNumber = 2;
    private long serverMsec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ServerMsec {
      get { return serverMsec_; }
      set {
        serverMsec_ = value;
      }
    }

    /// <summary>Field number for the "accessPointsConfigIpv6" field.</summary>
    public const int AccessPointsConfigIpv6FieldNumber = 3;
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

    /// <summary>Field number for the "accessPointsConfigWs" field.</summary>
    public const int AccessPointsConfigWsFieldNumber = 8;
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
      return Equals(other as KeepAliveResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KeepAliveResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AccessPointsConfig, other.AccessPointsConfig)) return false;
      if (ServerMsec != other.ServerMsec) return false;
      if (!object.Equals(AccessPointsConfigIpv6, other.AccessPointsConfigIpv6)) return false;
      if (!object.Equals(AccessPointsConfigQuic, other.AccessPointsConfigQuic)) return false;
      if (!object.Equals(AccessPointsConfigQuicIpv6, other.AccessPointsConfigQuicIpv6)) return false;
      if (!object.Equals(AccessPointsConfigWs, other.AccessPointsConfigWs)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (accessPointsConfig_ != null) hash ^= AccessPointsConfig.GetHashCode();
      if (ServerMsec != 0L) hash ^= ServerMsec.GetHashCode();
      if (accessPointsConfigIpv6_ != null) hash ^= AccessPointsConfigIpv6.GetHashCode();
      if (accessPointsConfigQuic_ != null) hash ^= AccessPointsConfigQuic.GetHashCode();
      if (accessPointsConfigQuicIpv6_ != null) hash ^= AccessPointsConfigQuicIpv6.GetHashCode();
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
      if (ServerMsec != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ServerMsec);
      }
      if (accessPointsConfigIpv6_ != null) {
        output.WriteRawTag(26);
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
      if (accessPointsConfigWs_ != null) {
        output.WriteRawTag(66);
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
      if (ServerMsec != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ServerMsec);
      }
      if (accessPointsConfigIpv6_ != null) {
        output.WriteRawTag(26);
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
      if (accessPointsConfigWs_ != null) {
        output.WriteRawTag(66);
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
      if (ServerMsec != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ServerMsec);
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
    public void MergeFrom(KeepAliveResponse other) {
      if (other == null) {
        return;
      }
      if (other.accessPointsConfig_ != null) {
        if (accessPointsConfig_ == null) {
          AccessPointsConfig = new global::AcFunDanmu.Im.Basic.AccessPointsConfig();
        }
        AccessPointsConfig.MergeFrom(other.AccessPointsConfig);
      }
      if (other.ServerMsec != 0L) {
        ServerMsec = other.ServerMsec;
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
          case 16: {
            ServerMsec = input.ReadInt64();
            break;
          }
          case 26: {
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
          case 66: {
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
          case 16: {
            ServerMsec = input.ReadInt64();
            break;
          }
          case 26: {
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
          case 66: {
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
