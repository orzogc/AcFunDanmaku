// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PkRoundInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from PkRoundInfo.proto</summary>
  public static partial class PkRoundInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PkRoundInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PkRoundInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQa1JvdW5kSW5mby5wcm90bxIKQWNGdW5EYW5tdSJECgtQa1JvdW5kSW5m",
            "bxIJCgFhGAEgASgDEgkKAWIYAiABKAUSCQoBYxgDIAEoBRIJCgFkGAQgASgD",
            "EgkKAWUYBSABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.PkRoundInfo), global::AcFunDanmu.PkRoundInfo.Parser, new[]{ "A", "B", "C", "D", "E" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PkRoundInfo : pb::IMessage<PkRoundInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PkRoundInfo> _parser = new pb::MessageParser<PkRoundInfo>(() => new PkRoundInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PkRoundInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.PkRoundInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PkRoundInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PkRoundInfo(PkRoundInfo other) : this() {
      a_ = other.a_;
      b_ = other.b_;
      c_ = other.c_;
      d_ = other.d_;
      e_ = other.e_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PkRoundInfo Clone() {
      return new PkRoundInfo(this);
    }

    /// <summary>Field number for the "a" field.</summary>
    public const int AFieldNumber = 1;
    private long a_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long A {
      get { return a_; }
      set {
        a_ = value;
      }
    }

    /// <summary>Field number for the "b" field.</summary>
    public const int BFieldNumber = 2;
    private int b_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int B {
      get { return b_; }
      set {
        b_ = value;
      }
    }

    /// <summary>Field number for the "c" field.</summary>
    public const int CFieldNumber = 3;
    private int c_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int C {
      get { return c_; }
      set {
        c_ = value;
      }
    }

    /// <summary>Field number for the "d" field.</summary>
    public const int DFieldNumber = 4;
    private long d_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long D {
      get { return d_; }
      set {
        d_ = value;
      }
    }

    /// <summary>Field number for the "e" field.</summary>
    public const int EFieldNumber = 5;
    private int e_;
    /// <summary>
    ///enum
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int E {
      get { return e_; }
      set {
        e_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PkRoundInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PkRoundInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (A != other.A) return false;
      if (B != other.B) return false;
      if (C != other.C) return false;
      if (D != other.D) return false;
      if (E != other.E) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (A != 0L) hash ^= A.GetHashCode();
      if (B != 0) hash ^= B.GetHashCode();
      if (C != 0) hash ^= C.GetHashCode();
      if (D != 0L) hash ^= D.GetHashCode();
      if (E != 0) hash ^= E.GetHashCode();
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
      if (A != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(A);
      }
      if (B != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(B);
      }
      if (C != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(C);
      }
      if (D != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(D);
      }
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
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (A != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(A);
      }
      if (B != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(B);
      }
      if (C != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(C);
      }
      if (D != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(D);
      }
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
    public int CalculateSize() {
      int size = 0;
      if (A != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(A);
      }
      if (B != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(B);
      }
      if (C != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(C);
      }
      if (D != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(D);
      }
      if (E != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(E);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PkRoundInfo other) {
      if (other == null) {
        return;
      }
      if (other.A != 0L) {
        A = other.A;
      }
      if (other.B != 0) {
        B = other.B;
      }
      if (other.C != 0) {
        C = other.C;
      }
      if (other.D != 0L) {
        D = other.D;
      }
      if (other.E != 0) {
        E = other.E;
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
            A = input.ReadInt64();
            break;
          }
          case 16: {
            B = input.ReadInt32();
            break;
          }
          case 24: {
            C = input.ReadInt32();
            break;
          }
          case 32: {
            D = input.ReadInt64();
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
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            A = input.ReadInt64();
            break;
          }
          case 16: {
            B = input.ReadInt32();
            break;
          }
          case 24: {
            C = input.ReadInt32();
            break;
          }
          case 32: {
            D = input.ReadInt64();
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
