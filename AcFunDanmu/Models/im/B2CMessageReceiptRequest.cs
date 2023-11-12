// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: B2CMessageReceiptRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Message {

  /// <summary>Holder for reflection information generated from B2CMessageReceiptRequest.proto</summary>
  public static partial class B2CMessageReceiptRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for B2CMessageReceiptRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static B2CMessageReceiptRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5CMkNNZXNzYWdlUmVjZWlwdFJlcXVlc3QucHJvdG8SFUFjRnVuRGFubXUu",
            "SW0uTWVzc2FnZRobQjJDTWVzc2FnZVJlY2VpcHRJbmZvLnByb3RvInkKGEIy",
            "Q01lc3NhZ2VSZWNlaXB0UmVxdWVzdBJIChJtZXNzYWdlUmVjZWlwdEluZm8Y",
            "ASADKAsyLC5BY0Z1bkRhbm11LkltLk1lc3NhZ2UuQjJDTWVzc2FnZVJlY2Vp",
            "cHRJbmZvEhMKC3N0clRhcmdldElkGAIgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Message.B2CMessageReceiptInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Message.B2CMessageReceiptRequest), global::AcFunDanmu.Im.Message.B2CMessageReceiptRequest.Parser, new[]{ "MessageReceiptInfo", "StrTargetId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class B2CMessageReceiptRequest : pb::IMessage<B2CMessageReceiptRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<B2CMessageReceiptRequest> _parser = new pb::MessageParser<B2CMessageReceiptRequest>(() => new B2CMessageReceiptRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<B2CMessageReceiptRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Message.B2CMessageReceiptRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CMessageReceiptRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CMessageReceiptRequest(B2CMessageReceiptRequest other) : this() {
      messageReceiptInfo_ = other.messageReceiptInfo_.Clone();
      strTargetId_ = other.strTargetId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CMessageReceiptRequest Clone() {
      return new B2CMessageReceiptRequest(this);
    }

    /// <summary>Field number for the "messageReceiptInfo" field.</summary>
    public const int MessageReceiptInfoFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Message.B2CMessageReceiptInfo> _repeated_messageReceiptInfo_codec
        = pb::FieldCodec.ForMessage(10, global::AcFunDanmu.Im.Message.B2CMessageReceiptInfo.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Message.B2CMessageReceiptInfo> messageReceiptInfo_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Message.B2CMessageReceiptInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Message.B2CMessageReceiptInfo> MessageReceiptInfo {
      get { return messageReceiptInfo_; }
    }

    /// <summary>Field number for the "strTargetId" field.</summary>
    public const int StrTargetIdFieldNumber = 2;
    private string strTargetId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StrTargetId {
      get { return strTargetId_; }
      set {
        strTargetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as B2CMessageReceiptRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(B2CMessageReceiptRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!messageReceiptInfo_.Equals(other.messageReceiptInfo_)) return false;
      if (StrTargetId != other.StrTargetId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= messageReceiptInfo_.GetHashCode();
      if (StrTargetId.Length != 0) hash ^= StrTargetId.GetHashCode();
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
      messageReceiptInfo_.WriteTo(output, _repeated_messageReceiptInfo_codec);
      if (StrTargetId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StrTargetId);
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
      messageReceiptInfo_.WriteTo(ref output, _repeated_messageReceiptInfo_codec);
      if (StrTargetId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StrTargetId);
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
      size += messageReceiptInfo_.CalculateSize(_repeated_messageReceiptInfo_codec);
      if (StrTargetId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StrTargetId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(B2CMessageReceiptRequest other) {
      if (other == null) {
        return;
      }
      messageReceiptInfo_.Add(other.messageReceiptInfo_);
      if (other.StrTargetId.Length != 0) {
        StrTargetId = other.StrTargetId;
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
            messageReceiptInfo_.AddEntriesFrom(input, _repeated_messageReceiptInfo_codec);
            break;
          }
          case 18: {
            StrTargetId = input.ReadString();
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
            messageReceiptInfo_.AddEntriesFrom(ref input, _repeated_messageReceiptInfo_codec);
            break;
          }
          case 18: {
            StrTargetId = input.ReadString();
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
