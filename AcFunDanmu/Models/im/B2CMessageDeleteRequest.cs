// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: B2CMessageDeleteRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Message {

  /// <summary>Holder for reflection information generated from B2CMessageDeleteRequest.proto</summary>
  public static partial class B2CMessageDeleteRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for B2CMessageDeleteRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static B2CMessageDeleteRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1CMkNNZXNzYWdlRGVsZXRlUmVxdWVzdC5wcm90bxIVQWNGdW5EYW5tdS5J",
            "bS5NZXNzYWdlIj0KF0IyQ01lc3NhZ2VEZWxldGVSZXF1ZXN0EhMKC3N0clRh",
            "cmdldElkGAEgASgJEg0KBXNlcUlkGAMgAygDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Message.B2CMessageDeleteRequest), global::AcFunDanmu.Im.Message.B2CMessageDeleteRequest.Parser, new[]{ "StrTargetId", "SeqId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class B2CMessageDeleteRequest : pb::IMessage<B2CMessageDeleteRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<B2CMessageDeleteRequest> _parser = new pb::MessageParser<B2CMessageDeleteRequest>(() => new B2CMessageDeleteRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<B2CMessageDeleteRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Message.B2CMessageDeleteRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CMessageDeleteRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CMessageDeleteRequest(B2CMessageDeleteRequest other) : this() {
      strTargetId_ = other.strTargetId_;
      seqId_ = other.seqId_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CMessageDeleteRequest Clone() {
      return new B2CMessageDeleteRequest(this);
    }

    /// <summary>Field number for the "strTargetId" field.</summary>
    public const int StrTargetIdFieldNumber = 1;
    private string strTargetId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StrTargetId {
      get { return strTargetId_; }
      set {
        strTargetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "seqId" field.</summary>
    public const int SeqIdFieldNumber = 3;
    private static readonly pb::FieldCodec<long> _repeated_seqId_codec
        = pb::FieldCodec.ForInt64(26);
    private readonly pbc::RepeatedField<long> seqId_ = new pbc::RepeatedField<long>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<long> SeqId {
      get { return seqId_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as B2CMessageDeleteRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(B2CMessageDeleteRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StrTargetId != other.StrTargetId) return false;
      if(!seqId_.Equals(other.seqId_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StrTargetId.Length != 0) hash ^= StrTargetId.GetHashCode();
      hash ^= seqId_.GetHashCode();
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
      if (StrTargetId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(StrTargetId);
      }
      seqId_.WriteTo(output, _repeated_seqId_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (StrTargetId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(StrTargetId);
      }
      seqId_.WriteTo(ref output, _repeated_seqId_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StrTargetId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StrTargetId);
      }
      size += seqId_.CalculateSize(_repeated_seqId_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(B2CMessageDeleteRequest other) {
      if (other == null) {
        return;
      }
      if (other.StrTargetId.Length != 0) {
        StrTargetId = other.StrTargetId;
      }
      seqId_.Add(other.seqId_);
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
            StrTargetId = input.ReadString();
            break;
          }
          case 26:
          case 24: {
            seqId_.AddEntriesFrom(input, _repeated_seqId_codec);
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
            StrTargetId = input.ReadString();
            break;
          }
          case 26:
          case 24: {
            seqId_.AddEntriesFrom(ref input, _repeated_seqId_codec);
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
