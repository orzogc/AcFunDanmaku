// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VisibleAmountRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Message {

  /// <summary>Holder for reflection information generated from VisibleAmountRequest.proto</summary>
  public static partial class VisibleAmountRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for VisibleAmountRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VisibleAmountRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpWaXNpYmxlQW1vdW50UmVxdWVzdC5wcm90bxIVQWNGdW5EYW5tdS5JbS5N",
            "ZXNzYWdlIksKFFZpc2libGVBbW91bnRSZXF1ZXN0Eg4KBm1pblNlcRgBIAEo",
            "AxIOCgZtYXhTZXEYAiABKAMSEwoLc3RyVGFyZ2V0SWQYBiABKAliBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Message.VisibleAmountRequest), global::AcFunDanmu.Im.Message.VisibleAmountRequest.Parser, new[]{ "MinSeq", "MaxSeq", "StrTargetId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class VisibleAmountRequest : pb::IMessage<VisibleAmountRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VisibleAmountRequest> _parser = new pb::MessageParser<VisibleAmountRequest>(() => new VisibleAmountRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VisibleAmountRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Message.VisibleAmountRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VisibleAmountRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VisibleAmountRequest(VisibleAmountRequest other) : this() {
      minSeq_ = other.minSeq_;
      maxSeq_ = other.maxSeq_;
      strTargetId_ = other.strTargetId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VisibleAmountRequest Clone() {
      return new VisibleAmountRequest(this);
    }

    /// <summary>Field number for the "minSeq" field.</summary>
    public const int MinSeqFieldNumber = 1;
    private long minSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long MinSeq {
      get { return minSeq_; }
      set {
        minSeq_ = value;
      }
    }

    /// <summary>Field number for the "maxSeq" field.</summary>
    public const int MaxSeqFieldNumber = 2;
    private long maxSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long MaxSeq {
      get { return maxSeq_; }
      set {
        maxSeq_ = value;
      }
    }

    /// <summary>Field number for the "strTargetId" field.</summary>
    public const int StrTargetIdFieldNumber = 6;
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
      return Equals(other as VisibleAmountRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VisibleAmountRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MinSeq != other.MinSeq) return false;
      if (MaxSeq != other.MaxSeq) return false;
      if (StrTargetId != other.StrTargetId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MinSeq != 0L) hash ^= MinSeq.GetHashCode();
      if (MaxSeq != 0L) hash ^= MaxSeq.GetHashCode();
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
      if (MinSeq != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(MinSeq);
      }
      if (MaxSeq != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(MaxSeq);
      }
      if (StrTargetId.Length != 0) {
        output.WriteRawTag(50);
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
      if (MinSeq != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(MinSeq);
      }
      if (MaxSeq != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(MaxSeq);
      }
      if (StrTargetId.Length != 0) {
        output.WriteRawTag(50);
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
      if (MinSeq != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MinSeq);
      }
      if (MaxSeq != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MaxSeq);
      }
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
    public void MergeFrom(VisibleAmountRequest other) {
      if (other == null) {
        return;
      }
      if (other.MinSeq != 0L) {
        MinSeq = other.MinSeq;
      }
      if (other.MaxSeq != 0L) {
        MaxSeq = other.MaxSeq;
      }
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
          case 8: {
            MinSeq = input.ReadInt64();
            break;
          }
          case 16: {
            MaxSeq = input.ReadInt64();
            break;
          }
          case 50: {
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
          case 8: {
            MinSeq = input.ReadInt64();
            break;
          }
          case 16: {
            MaxSeq = input.ReadInt64();
            break;
          }
          case 50: {
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
