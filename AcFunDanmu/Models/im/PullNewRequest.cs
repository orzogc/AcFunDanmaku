// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PullNewRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Message {

  /// <summary>Holder for reflection information generated from PullNewRequest.proto</summary>
  public static partial class PullNewRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for PullNewRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PullNewRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQdWxsTmV3UmVxdWVzdC5wcm90bxIVQWNGdW5EYW5tdS5JbS5NZXNzYWdl",
            "GgpVc2VyLnByb3RvIoEBCg5QdWxsTmV3UmVxdWVzdBIpCgZ0YXJnZXQYASAB",
            "KAsyGS5BY0Z1bkRhbm11LkltLkJhc2ljLlVzZXISDgoGbWluU2VxGAIgASgD",
            "Eg0KBWNvdW50GAMgASgFEhAKCHRhcmdldElkGAQgASgDEhMKC3N0clRhcmdl",
            "dElkGAUgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Basic.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Message.PullNewRequest), global::AcFunDanmu.Im.Message.PullNewRequest.Parser, new[]{ "Target", "MinSeq", "Count", "TargetId", "StrTargetId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PullNewRequest : pb::IMessage<PullNewRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PullNewRequest> _parser = new pb::MessageParser<PullNewRequest>(() => new PullNewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PullNewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Message.PullNewRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PullNewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PullNewRequest(PullNewRequest other) : this() {
      target_ = other.target_ != null ? other.target_.Clone() : null;
      minSeq_ = other.minSeq_;
      count_ = other.count_;
      targetId_ = other.targetId_;
      strTargetId_ = other.strTargetId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PullNewRequest Clone() {
      return new PullNewRequest(this);
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 1;
    private global::AcFunDanmu.Im.Basic.User target_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.User Target {
      get { return target_; }
      set {
        target_ = value;
      }
    }

    /// <summary>Field number for the "minSeq" field.</summary>
    public const int MinSeqFieldNumber = 2;
    private long minSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long MinSeq {
      get { return minSeq_; }
      set {
        minSeq_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 3;
    private int count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "targetId" field.</summary>
    public const int TargetIdFieldNumber = 4;
    private long targetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long TargetId {
      get { return targetId_; }
      set {
        targetId_ = value;
      }
    }

    /// <summary>Field number for the "strTargetId" field.</summary>
    public const int StrTargetIdFieldNumber = 5;
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
      return Equals(other as PullNewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PullNewRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Target, other.Target)) return false;
      if (MinSeq != other.MinSeq) return false;
      if (Count != other.Count) return false;
      if (TargetId != other.TargetId) return false;
      if (StrTargetId != other.StrTargetId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (target_ != null) hash ^= Target.GetHashCode();
      if (MinSeq != 0L) hash ^= MinSeq.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
      if (TargetId != 0L) hash ^= TargetId.GetHashCode();
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
      if (target_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Target);
      }
      if (MinSeq != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(MinSeq);
      }
      if (Count != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Count);
      }
      if (TargetId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(TargetId);
      }
      if (StrTargetId.Length != 0) {
        output.WriteRawTag(42);
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
      if (target_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Target);
      }
      if (MinSeq != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(MinSeq);
      }
      if (Count != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Count);
      }
      if (TargetId != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(TargetId);
      }
      if (StrTargetId.Length != 0) {
        output.WriteRawTag(42);
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
      if (target_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Target);
      }
      if (MinSeq != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MinSeq);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
      }
      if (TargetId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TargetId);
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
    public void MergeFrom(PullNewRequest other) {
      if (other == null) {
        return;
      }
      if (other.target_ != null) {
        if (target_ == null) {
          Target = new global::AcFunDanmu.Im.Basic.User();
        }
        Target.MergeFrom(other.Target);
      }
      if (other.MinSeq != 0L) {
        MinSeq = other.MinSeq;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.TargetId != 0L) {
        TargetId = other.TargetId;
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
          case 10: {
            if (target_ == null) {
              Target = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(Target);
            break;
          }
          case 16: {
            MinSeq = input.ReadInt64();
            break;
          }
          case 24: {
            Count = input.ReadInt32();
            break;
          }
          case 32: {
            TargetId = input.ReadInt64();
            break;
          }
          case 42: {
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
            if (target_ == null) {
              Target = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(Target);
            break;
          }
          case 16: {
            MinSeq = input.ReadInt64();
            break;
          }
          case 24: {
            Count = input.ReadInt32();
            break;
          }
          case 32: {
            TargetId = input.ReadInt64();
            break;
          }
          case 42: {
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
