// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PkPlayerStatistic.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from PkPlayerStatistic.proto</summary>
  public static partial class PkPlayerStatisticReflection {

    #region Descriptor
    /// <summary>File descriptor for PkPlayerStatistic.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PkPlayerStatisticReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQa1BsYXllclN0YXRpc3RpYy5wcm90bxIKQWNGdW5EYW5tdRoUWnRMaXZl",
            "VXNlckluZm8ucHJvdG8aHFBrUGxheWVyUm91bmRTdGF0aXN0aWMucHJvdG8i",
            "igEKEVBrUGxheWVyU3RhdGlzdGljEiUKAWEYASABKAsyGi5BY0Z1bkRhbm11",
            "Llp0TGl2ZVVzZXJJbmZvEgkKAWIYAiABKAkSCQoBYxgDIAEoAxItCgFkGAQg",
            "AygLMiIuQWNGdW5EYW5tdS5Qa1BsYXllclJvdW5kU3RhdGlzdGljEgkKAWUY",
            "BSABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.ZtLiveUserInfoReflection.Descriptor, global::AcFunDanmu.PkPlayerRoundStatisticReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.PkPlayerStatistic), global::AcFunDanmu.PkPlayerStatistic.Parser, new[]{ "A", "B", "C", "D", "E" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PkPlayerStatistic : pb::IMessage<PkPlayerStatistic>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PkPlayerStatistic> _parser = new pb::MessageParser<PkPlayerStatistic>(() => new PkPlayerStatistic());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PkPlayerStatistic> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.PkPlayerStatisticReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PkPlayerStatistic() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PkPlayerStatistic(PkPlayerStatistic other) : this() {
      a_ = other.a_ != null ? other.a_.Clone() : null;
      b_ = other.b_;
      c_ = other.c_;
      d_ = other.d_.Clone();
      e_ = other.e_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PkPlayerStatistic Clone() {
      return new PkPlayerStatistic(this);
    }

    /// <summary>Field number for the "a" field.</summary>
    public const int AFieldNumber = 1;
    private global::AcFunDanmu.ZtLiveUserInfo a_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.ZtLiveUserInfo A {
      get { return a_; }
      set {
        a_ = value;
      }
    }

    /// <summary>Field number for the "b" field.</summary>
    public const int BFieldNumber = 2;
    private string b_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string B {
      get { return b_; }
      set {
        b_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "c" field.</summary>
    public const int CFieldNumber = 3;
    private long c_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long C {
      get { return c_; }
      set {
        c_ = value;
      }
    }

    /// <summary>Field number for the "d" field.</summary>
    public const int DFieldNumber = 4;
    private static readonly pb::FieldCodec<global::AcFunDanmu.PkPlayerRoundStatistic> _repeated_d_codec
        = pb::FieldCodec.ForMessage(34, global::AcFunDanmu.PkPlayerRoundStatistic.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.PkPlayerRoundStatistic> d_ = new pbc::RepeatedField<global::AcFunDanmu.PkPlayerRoundStatistic>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.PkPlayerRoundStatistic> D {
      get { return d_; }
    }

    /// <summary>Field number for the "e" field.</summary>
    public const int EFieldNumber = 5;
    private int e_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int E {
      get { return e_; }
      set {
        e_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PkPlayerStatistic);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PkPlayerStatistic other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(A, other.A)) return false;
      if (B != other.B) return false;
      if (C != other.C) return false;
      if(!d_.Equals(other.d_)) return false;
      if (E != other.E) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (a_ != null) hash ^= A.GetHashCode();
      if (B.Length != 0) hash ^= B.GetHashCode();
      if (C != 0L) hash ^= C.GetHashCode();
      hash ^= d_.GetHashCode();
      if (E != 0) hash ^= E.GetHashCode();
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
      if (a_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(A);
      }
      if (B.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(B);
      }
      if (C != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(C);
      }
      d_.WriteTo(output, _repeated_d_codec);
      if (E != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(E);
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
      if (a_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(A);
      }
      if (B.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(B);
      }
      if (C != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(C);
      }
      d_.WriteTo(ref output, _repeated_d_codec);
      if (E != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(E);
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
      if (a_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(A);
      }
      if (B.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(B);
      }
      if (C != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(C);
      }
      size += d_.CalculateSize(_repeated_d_codec);
      if (E != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(E);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PkPlayerStatistic other) {
      if (other == null) {
        return;
      }
      if (other.a_ != null) {
        if (a_ == null) {
          A = new global::AcFunDanmu.ZtLiveUserInfo();
        }
        A.MergeFrom(other.A);
      }
      if (other.B.Length != 0) {
        B = other.B;
      }
      if (other.C != 0L) {
        C = other.C;
      }
      d_.Add(other.d_);
      if (other.E != 0) {
        E = other.E;
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
            if (a_ == null) {
              A = new global::AcFunDanmu.ZtLiveUserInfo();
            }
            input.ReadMessage(A);
            break;
          }
          case 18: {
            B = input.ReadString();
            break;
          }
          case 24: {
            C = input.ReadInt64();
            break;
          }
          case 34: {
            d_.AddEntriesFrom(input, _repeated_d_codec);
            break;
          }
          case 40: {
            E = input.ReadInt32();
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
            if (a_ == null) {
              A = new global::AcFunDanmu.ZtLiveUserInfo();
            }
            input.ReadMessage(A);
            break;
          }
          case 18: {
            B = input.ReadString();
            break;
          }
          case 24: {
            C = input.ReadInt64();
            break;
          }
          case 34: {
            d_.AddEntriesFrom(ref input, _repeated_d_codec);
            break;
          }
          case 40: {
            E = input.ReadInt32();
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
