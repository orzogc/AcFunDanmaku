// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KwaiStateSignalEcommerceCartItemPopup.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from KwaiStateSignalEcommerceCartItemPopup.proto</summary>
  public static partial class KwaiStateSignalEcommerceCartItemPopupReflection {

    #region Descriptor
    /// <summary>File descriptor for KwaiStateSignalEcommerceCartItemPopup.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KwaiStateSignalEcommerceCartItemPopupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitLd2FpU3RhdGVTaWduYWxFY29tbWVyY2VDYXJ0SXRlbVBvcHVwLnByb3Rv",
            "EgpBY0Z1bkRhbm11IrIBCiVLd2FpU3RhdGVTaWduYWxFY29tbWVyY2VDYXJ0",
            "SXRlbVBvcHVwEkQKAWEYASABKA4yOS5BY0Z1bkRhbm11Lkt3YWlTdGF0ZVNp",
            "Z25hbEVjb21tZXJjZUNhcnRJdGVtUG9wdXAudW5rbm93bhIJCgFiGAIgASgJ",
            "EgkKAWMYAyABKAkSCQoBZBgEIAEoCRIJCgFlGAUgASgJIhcKB3Vua25vd24S",
            "BQoBZhAAEgUKAWcQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup), global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Parser, new[]{ "A", "B", "C", "D", "E" }, null, new[]{ typeof(global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Types.unknown) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class KwaiStateSignalEcommerceCartItemPopup : pb::IMessage<KwaiStateSignalEcommerceCartItemPopup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KwaiStateSignalEcommerceCartItemPopup> _parser = new pb::MessageParser<KwaiStateSignalEcommerceCartItemPopup>(() => new KwaiStateSignalEcommerceCartItemPopup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KwaiStateSignalEcommerceCartItemPopup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KwaiStateSignalEcommerceCartItemPopup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KwaiStateSignalEcommerceCartItemPopup(KwaiStateSignalEcommerceCartItemPopup other) : this() {
      a_ = other.a_;
      b_ = other.b_;
      c_ = other.c_;
      d_ = other.d_;
      e_ = other.e_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KwaiStateSignalEcommerceCartItemPopup Clone() {
      return new KwaiStateSignalEcommerceCartItemPopup(this);
    }

    /// <summary>Field number for the "a" field.</summary>
    public const int AFieldNumber = 1;
    private global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Types.unknown a_ = global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Types.unknown.F;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Types.unknown A {
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
    private string c_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string C {
      get { return c_; }
      set {
        c_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "d" field.</summary>
    public const int DFieldNumber = 4;
    private string d_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string D {
      get { return d_; }
      set {
        d_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "e" field.</summary>
    public const int EFieldNumber = 5;
    private string e_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string E {
      get { return e_; }
      set {
        e_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KwaiStateSignalEcommerceCartItemPopup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KwaiStateSignalEcommerceCartItemPopup other) {
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (A != global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Types.unknown.F) hash ^= A.GetHashCode();
      if (B.Length != 0) hash ^= B.GetHashCode();
      if (C.Length != 0) hash ^= C.GetHashCode();
      if (D.Length != 0) hash ^= D.GetHashCode();
      if (E.Length != 0) hash ^= E.GetHashCode();
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
      if (A != global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Types.unknown.F) {
        output.WriteRawTag(8);
        output.WriteEnum((int) A);
      }
      if (B.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(B);
      }
      if (C.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(C);
      }
      if (D.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(D);
      }
      if (E.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(E);
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
      if (A != global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Types.unknown.F) {
        output.WriteRawTag(8);
        output.WriteEnum((int) A);
      }
      if (B.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(B);
      }
      if (C.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(C);
      }
      if (D.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(D);
      }
      if (E.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(E);
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
      if (A != global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Types.unknown.F) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) A);
      }
      if (B.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(B);
      }
      if (C.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(C);
      }
      if (D.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(D);
      }
      if (E.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(E);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KwaiStateSignalEcommerceCartItemPopup other) {
      if (other == null) {
        return;
      }
      if (other.A != global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Types.unknown.F) {
        A = other.A;
      }
      if (other.B.Length != 0) {
        B = other.B;
      }
      if (other.C.Length != 0) {
        C = other.C;
      }
      if (other.D.Length != 0) {
        D = other.D;
      }
      if (other.E.Length != 0) {
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
          case 8: {
            A = (global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Types.unknown) input.ReadEnum();
            break;
          }
          case 18: {
            B = input.ReadString();
            break;
          }
          case 26: {
            C = input.ReadString();
            break;
          }
          case 34: {
            D = input.ReadString();
            break;
          }
          case 42: {
            E = input.ReadString();
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
            A = (global::AcFunDanmu.KwaiStateSignalEcommerceCartItemPopup.Types.unknown) input.ReadEnum();
            break;
          }
          case 18: {
            B = input.ReadString();
            break;
          }
          case 26: {
            C = input.ReadString();
            break;
          }
          case 34: {
            D = input.ReadString();
            break;
          }
          case 42: {
            E = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the KwaiStateSignalEcommerceCartItemPopup message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum unknown {
        [pbr::OriginalName("f")] F = 0,
        [pbr::OriginalName("g")] G = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
