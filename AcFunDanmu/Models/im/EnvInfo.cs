// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnvInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Basic {

  /// <summary>Holder for reflection information generated from EnvInfo.proto</summary>
  public static partial class EnvInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EnvInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnvInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1FbnZJbmZvLnByb3RvEhNBY0Z1bkRhbm11LkltLkJhc2ljIpABCgdFbnZJ",
            "bmZvEj0KC25ldHdvcmtUeXBlGAEgASgOMiguQWNGdW5EYW5tdS5JbS5CYXNp",
            "Yy5FbnZJbmZvLk5ldHdvcmtUeXBlEg8KB2Fwbk5hbWUYAiABKAwiNQoLTmV0",
            "d29ya1R5cGUSDAoIa0ludmFsaWQQABIJCgVrV0lGSRABEg0KCWtDZWxsdWxh",
            "chACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Basic.EnvInfo), global::AcFunDanmu.Im.Basic.EnvInfo.Parser, new[]{ "NetworkType", "ApnName" }, null, new[]{ typeof(global::AcFunDanmu.Im.Basic.EnvInfo.Types.NetworkType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnvInfo : pb::IMessage<EnvInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnvInfo> _parser = new pb::MessageParser<EnvInfo>(() => new EnvInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnvInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Basic.EnvInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnvInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnvInfo(EnvInfo other) : this() {
      networkType_ = other.networkType_;
      apnName_ = other.apnName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnvInfo Clone() {
      return new EnvInfo(this);
    }

    /// <summary>Field number for the "networkType" field.</summary>
    public const int NetworkTypeFieldNumber = 1;
    private global::AcFunDanmu.Im.Basic.EnvInfo.Types.NetworkType networkType_ = global::AcFunDanmu.Im.Basic.EnvInfo.Types.NetworkType.KInvalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.EnvInfo.Types.NetworkType NetworkType {
      get { return networkType_; }
      set {
        networkType_ = value;
      }
    }

    /// <summary>Field number for the "apnName" field.</summary>
    public const int ApnNameFieldNumber = 2;
    private pb::ByteString apnName_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString ApnName {
      get { return apnName_; }
      set {
        apnName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnvInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnvInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NetworkType != other.NetworkType) return false;
      if (ApnName != other.ApnName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NetworkType != global::AcFunDanmu.Im.Basic.EnvInfo.Types.NetworkType.KInvalid) hash ^= NetworkType.GetHashCode();
      if (ApnName.Length != 0) hash ^= ApnName.GetHashCode();
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
      if (NetworkType != global::AcFunDanmu.Im.Basic.EnvInfo.Types.NetworkType.KInvalid) {
        output.WriteRawTag(8);
        output.WriteEnum((int) NetworkType);
      }
      if (ApnName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(ApnName);
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
      if (NetworkType != global::AcFunDanmu.Im.Basic.EnvInfo.Types.NetworkType.KInvalid) {
        output.WriteRawTag(8);
        output.WriteEnum((int) NetworkType);
      }
      if (ApnName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(ApnName);
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
      if (NetworkType != global::AcFunDanmu.Im.Basic.EnvInfo.Types.NetworkType.KInvalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NetworkType);
      }
      if (ApnName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ApnName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnvInfo other) {
      if (other == null) {
        return;
      }
      if (other.NetworkType != global::AcFunDanmu.Im.Basic.EnvInfo.Types.NetworkType.KInvalid) {
        NetworkType = other.NetworkType;
      }
      if (other.ApnName.Length != 0) {
        ApnName = other.ApnName;
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
          case 8: {
            NetworkType = (global::AcFunDanmu.Im.Basic.EnvInfo.Types.NetworkType) input.ReadEnum();
            break;
          }
          case 18: {
            ApnName = input.ReadBytes();
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
          case 8: {
            NetworkType = (global::AcFunDanmu.Im.Basic.EnvInfo.Types.NetworkType) input.ReadEnum();
            break;
          }
          case 18: {
            ApnName = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EnvInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum NetworkType {
        [pbr::OriginalName("kInvalid")] KInvalid = 0,
        [pbr::OriginalName("kWIFI")] KWifi = 1,
        [pbr::OriginalName("kCellular")] KCellular = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
