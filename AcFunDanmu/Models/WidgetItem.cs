// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from WidgetItem.proto</summary>
  public static partial class WidgetItemReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBXaWRnZXRJdGVtLnByb3RvEgpBY0Z1bkRhbm11GhhXaWRnZXREaXNwbGF5",
            "U3R5bGUucHJvdG8aF1dpZGdldFBpY3R1cmVJbmZvLnByb3RvGhdadExpdmVX",
            "aWRnZXRQcm90by5wcm90byLFAgoKV2lkZ2V0SXRlbRIJCgFhGAEgASgDEgkK",
            "AWIYAiABKAkSCQoBYxgDIAEoBRIJCgFkGAQgASgDEgkKAWUYBSABKAMSKAoB",
            "ZhgGIAEoCzIdLkFjRnVuRGFubXUuV2lkZ2V0UGljdHVyZUluZm8SCQoBZxgH",
            "IAEoCRIpCgFoGAggASgOMh4uQWNGdW5EYW5tdS5adExpdmVXaWRnZXRQcm90",
            "b0ESKQoBaRgJIAEoDjIeLkFjRnVuRGFubXUuWnRMaXZlV2lkZ2V0UHJvdG9C",
            "EikKAWoYCiABKAsyHi5BY0Z1bkRhbm11LldpZGdldERpc3BsYXlTdHlsZRIp",
            "CgFrGAsgASgOMh4uQWNGdW5EYW5tdS5adExpdmVXaWRnZXRQcm90b0MSCQoB",
            "bBgMIAMoCRIJCgFtGA0gAygJEgkKAW4YDiABKANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.WidgetDisplayStyleReflection.Descriptor, global::AcFunDanmu.WidgetPictureInfoReflection.Descriptor, global::AcFunDanmu.ZtLiveWidgetProtoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.WidgetItem), global::AcFunDanmu.WidgetItem.Parser, new[]{ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WidgetItem : pb::IMessage<WidgetItem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WidgetItem> _parser = new pb::MessageParser<WidgetItem>(() => new WidgetItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WidgetItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.WidgetItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetItem(WidgetItem other) : this() {
      a_ = other.a_;
      b_ = other.b_;
      c_ = other.c_;
      d_ = other.d_;
      e_ = other.e_;
      f_ = other.f_ != null ? other.f_.Clone() : null;
      g_ = other.g_;
      h_ = other.h_;
      i_ = other.i_;
      j_ = other.j_ != null ? other.j_.Clone() : null;
      k_ = other.k_;
      l_ = other.l_.Clone();
      m_ = other.m_.Clone();
      n_ = other.n_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetItem Clone() {
      return new WidgetItem(this);
    }

    /// <summary>Field number for the "a" field.</summary>
    public const int AFieldNumber = 1;
    private long a_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long A {
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
    private int c_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long D {
      get { return d_; }
      set {
        d_ = value;
      }
    }

    /// <summary>Field number for the "e" field.</summary>
    public const int EFieldNumber = 5;
    private long e_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long E {
      get { return e_; }
      set {
        e_ = value;
      }
    }

    /// <summary>Field number for the "f" field.</summary>
    public const int FFieldNumber = 6;
    private global::AcFunDanmu.WidgetPictureInfo f_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.WidgetPictureInfo F {
      get { return f_; }
      set {
        f_ = value;
      }
    }

    /// <summary>Field number for the "g" field.</summary>
    public const int GFieldNumber = 7;
    private string g_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string G {
      get { return g_; }
      set {
        g_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "h" field.</summary>
    public const int HFieldNumber = 8;
    private global::AcFunDanmu.ZtLiveWidgetProtoA h_ = global::AcFunDanmu.ZtLiveWidgetProtoA.A;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.ZtLiveWidgetProtoA H {
      get { return h_; }
      set {
        h_ = value;
      }
    }

    /// <summary>Field number for the "i" field.</summary>
    public const int IFieldNumber = 9;
    private global::AcFunDanmu.ZtLiveWidgetProtoB i_ = global::AcFunDanmu.ZtLiveWidgetProtoB.A;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.ZtLiveWidgetProtoB I {
      get { return i_; }
      set {
        i_ = value;
      }
    }

    /// <summary>Field number for the "j" field.</summary>
    public const int JFieldNumber = 10;
    private global::AcFunDanmu.WidgetDisplayStyle j_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.WidgetDisplayStyle J {
      get { return j_; }
      set {
        j_ = value;
      }
    }

    /// <summary>Field number for the "k" field.</summary>
    public const int KFieldNumber = 11;
    private global::AcFunDanmu.ZtLiveWidgetProtoC k_ = global::AcFunDanmu.ZtLiveWidgetProtoC.A;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.ZtLiveWidgetProtoC K {
      get { return k_; }
      set {
        k_ = value;
      }
    }

    /// <summary>Field number for the "l" field.</summary>
    public const int LFieldNumber = 12;
    private static readonly pb::FieldCodec<string> _repeated_l_codec
        = pb::FieldCodec.ForString(98);
    private readonly pbc::RepeatedField<string> l_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> L {
      get { return l_; }
    }

    /// <summary>Field number for the "m" field.</summary>
    public const int MFieldNumber = 13;
    private static readonly pb::FieldCodec<string> _repeated_m_codec
        = pb::FieldCodec.ForString(106);
    private readonly pbc::RepeatedField<string> m_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> M {
      get { return m_; }
    }

    /// <summary>Field number for the "n" field.</summary>
    public const int NFieldNumber = 14;
    private long n_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long N {
      get { return n_; }
      set {
        n_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WidgetItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WidgetItem other) {
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
      if (!object.Equals(F, other.F)) return false;
      if (G != other.G) return false;
      if (H != other.H) return false;
      if (I != other.I) return false;
      if (!object.Equals(J, other.J)) return false;
      if (K != other.K) return false;
      if(!l_.Equals(other.l_)) return false;
      if(!m_.Equals(other.m_)) return false;
      if (N != other.N) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (A != 0L) hash ^= A.GetHashCode();
      if (B.Length != 0) hash ^= B.GetHashCode();
      if (C != 0) hash ^= C.GetHashCode();
      if (D != 0L) hash ^= D.GetHashCode();
      if (E != 0L) hash ^= E.GetHashCode();
      if (f_ != null) hash ^= F.GetHashCode();
      if (G.Length != 0) hash ^= G.GetHashCode();
      if (H != global::AcFunDanmu.ZtLiveWidgetProtoA.A) hash ^= H.GetHashCode();
      if (I != global::AcFunDanmu.ZtLiveWidgetProtoB.A) hash ^= I.GetHashCode();
      if (j_ != null) hash ^= J.GetHashCode();
      if (K != global::AcFunDanmu.ZtLiveWidgetProtoC.A) hash ^= K.GetHashCode();
      hash ^= l_.GetHashCode();
      hash ^= m_.GetHashCode();
      if (N != 0L) hash ^= N.GetHashCode();
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
      if (A != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(A);
      }
      if (B.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(B);
      }
      if (C != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(C);
      }
      if (D != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(D);
      }
      if (E != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(E);
      }
      if (f_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(F);
      }
      if (G.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(G);
      }
      if (H != global::AcFunDanmu.ZtLiveWidgetProtoA.A) {
        output.WriteRawTag(64);
        output.WriteEnum((int) H);
      }
      if (I != global::AcFunDanmu.ZtLiveWidgetProtoB.A) {
        output.WriteRawTag(72);
        output.WriteEnum((int) I);
      }
      if (j_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(J);
      }
      if (K != global::AcFunDanmu.ZtLiveWidgetProtoC.A) {
        output.WriteRawTag(88);
        output.WriteEnum((int) K);
      }
      l_.WriteTo(output, _repeated_l_codec);
      m_.WriteTo(output, _repeated_m_codec);
      if (N != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(N);
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
      if (A != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(A);
      }
      if (B.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(B);
      }
      if (C != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(C);
      }
      if (D != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(D);
      }
      if (E != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(E);
      }
      if (f_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(F);
      }
      if (G.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(G);
      }
      if (H != global::AcFunDanmu.ZtLiveWidgetProtoA.A) {
        output.WriteRawTag(64);
        output.WriteEnum((int) H);
      }
      if (I != global::AcFunDanmu.ZtLiveWidgetProtoB.A) {
        output.WriteRawTag(72);
        output.WriteEnum((int) I);
      }
      if (j_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(J);
      }
      if (K != global::AcFunDanmu.ZtLiveWidgetProtoC.A) {
        output.WriteRawTag(88);
        output.WriteEnum((int) K);
      }
      l_.WriteTo(ref output, _repeated_l_codec);
      m_.WriteTo(ref output, _repeated_m_codec);
      if (N != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(N);
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
      if (A != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(A);
      }
      if (B.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(B);
      }
      if (C != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(C);
      }
      if (D != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(D);
      }
      if (E != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(E);
      }
      if (f_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(F);
      }
      if (G.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(G);
      }
      if (H != global::AcFunDanmu.ZtLiveWidgetProtoA.A) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) H);
      }
      if (I != global::AcFunDanmu.ZtLiveWidgetProtoB.A) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) I);
      }
      if (j_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(J);
      }
      if (K != global::AcFunDanmu.ZtLiveWidgetProtoC.A) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) K);
      }
      size += l_.CalculateSize(_repeated_l_codec);
      size += m_.CalculateSize(_repeated_m_codec);
      if (N != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(N);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WidgetItem other) {
      if (other == null) {
        return;
      }
      if (other.A != 0L) {
        A = other.A;
      }
      if (other.B.Length != 0) {
        B = other.B;
      }
      if (other.C != 0) {
        C = other.C;
      }
      if (other.D != 0L) {
        D = other.D;
      }
      if (other.E != 0L) {
        E = other.E;
      }
      if (other.f_ != null) {
        if (f_ == null) {
          F = new global::AcFunDanmu.WidgetPictureInfo();
        }
        F.MergeFrom(other.F);
      }
      if (other.G.Length != 0) {
        G = other.G;
      }
      if (other.H != global::AcFunDanmu.ZtLiveWidgetProtoA.A) {
        H = other.H;
      }
      if (other.I != global::AcFunDanmu.ZtLiveWidgetProtoB.A) {
        I = other.I;
      }
      if (other.j_ != null) {
        if (j_ == null) {
          J = new global::AcFunDanmu.WidgetDisplayStyle();
        }
        J.MergeFrom(other.J);
      }
      if (other.K != global::AcFunDanmu.ZtLiveWidgetProtoC.A) {
        K = other.K;
      }
      l_.Add(other.l_);
      m_.Add(other.m_);
      if (other.N != 0L) {
        N = other.N;
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
            A = input.ReadInt64();
            break;
          }
          case 18: {
            B = input.ReadString();
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
            E = input.ReadInt64();
            break;
          }
          case 50: {
            if (f_ == null) {
              F = new global::AcFunDanmu.WidgetPictureInfo();
            }
            input.ReadMessage(F);
            break;
          }
          case 58: {
            G = input.ReadString();
            break;
          }
          case 64: {
            H = (global::AcFunDanmu.ZtLiveWidgetProtoA) input.ReadEnum();
            break;
          }
          case 72: {
            I = (global::AcFunDanmu.ZtLiveWidgetProtoB) input.ReadEnum();
            break;
          }
          case 82: {
            if (j_ == null) {
              J = new global::AcFunDanmu.WidgetDisplayStyle();
            }
            input.ReadMessage(J);
            break;
          }
          case 88: {
            K = (global::AcFunDanmu.ZtLiveWidgetProtoC) input.ReadEnum();
            break;
          }
          case 98: {
            l_.AddEntriesFrom(input, _repeated_l_codec);
            break;
          }
          case 106: {
            m_.AddEntriesFrom(input, _repeated_m_codec);
            break;
          }
          case 112: {
            N = input.ReadInt64();
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
            A = input.ReadInt64();
            break;
          }
          case 18: {
            B = input.ReadString();
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
            E = input.ReadInt64();
            break;
          }
          case 50: {
            if (f_ == null) {
              F = new global::AcFunDanmu.WidgetPictureInfo();
            }
            input.ReadMessage(F);
            break;
          }
          case 58: {
            G = input.ReadString();
            break;
          }
          case 64: {
            H = (global::AcFunDanmu.ZtLiveWidgetProtoA) input.ReadEnum();
            break;
          }
          case 72: {
            I = (global::AcFunDanmu.ZtLiveWidgetProtoB) input.ReadEnum();
            break;
          }
          case 82: {
            if (j_ == null) {
              J = new global::AcFunDanmu.WidgetDisplayStyle();
            }
            input.ReadMessage(J);
            break;
          }
          case 88: {
            K = (global::AcFunDanmu.ZtLiveWidgetProtoC) input.ReadEnum();
            break;
          }
          case 98: {
            l_.AddEntriesFrom(ref input, _repeated_l_codec);
            break;
          }
          case 106: {
            m_.AddEntriesFrom(ref input, _repeated_m_codec);
            break;
          }
          case 112: {
            N = input.ReadInt64();
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
