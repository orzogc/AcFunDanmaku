// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CommonStateSignalWishSheetCurrentState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from CommonStateSignalWishSheetCurrentState.proto</summary>
  public static partial class CommonStateSignalWishSheetCurrentStateReflection {

    #region Descriptor
    /// <summary>File descriptor for CommonStateSignalWishSheetCurrentState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonStateSignalWishSheetCurrentStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixDb21tb25TdGF0ZVNpZ25hbFdpc2hTaGVldEN1cnJlbnRTdGF0ZS5wcm90",
            "bxIKQWNGdW5EYW5tdSLZAQomQ29tbW9uU3RhdGVTaWduYWxXaXNoU2hlZXRD",
            "dXJyZW50U3RhdGUSCQoBYRgBIAEoCRJOCgFiGAIgAygLMkMuQWNGdW5EYW5t",
            "dS5Db21tb25TdGF0ZVNpZ25hbFdpc2hTaGVldEN1cnJlbnRTdGF0ZS5XaXNo",
            "Q3VycmVudFN0YXRlGlQKEFdpc2hDdXJyZW50U3RhdGUSCQoBYRgBIAEoCRIJ",
            "CgFiGAIgASgDEgkKAWMYAyABKAMSCQoBZBgEIAEoAxIJCgFlGAUgASgJEgkK",
            "AWYYBiABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.CommonStateSignalWishSheetCurrentState), global::AcFunDanmu.CommonStateSignalWishSheetCurrentState.Parser, new[]{ "A", "B" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.CommonStateSignalWishSheetCurrentState.Types.WishCurrentState), global::AcFunDanmu.CommonStateSignalWishSheetCurrentState.Types.WishCurrentState.Parser, new[]{ "A", "B", "C", "D", "E", "F" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CommonStateSignalWishSheetCurrentState : pb::IMessage<CommonStateSignalWishSheetCurrentState>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CommonStateSignalWishSheetCurrentState> _parser = new pb::MessageParser<CommonStateSignalWishSheetCurrentState>(() => new CommonStateSignalWishSheetCurrentState());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CommonStateSignalWishSheetCurrentState> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.CommonStateSignalWishSheetCurrentStateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonStateSignalWishSheetCurrentState() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonStateSignalWishSheetCurrentState(CommonStateSignalWishSheetCurrentState other) : this() {
      a_ = other.a_;
      b_ = other.b_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonStateSignalWishSheetCurrentState Clone() {
      return new CommonStateSignalWishSheetCurrentState(this);
    }

    /// <summary>Field number for the "a" field.</summary>
    public const int AFieldNumber = 1;
    private string a_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string A {
      get { return a_; }
      set {
        a_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "b" field.</summary>
    public const int BFieldNumber = 2;
    private static readonly pb::FieldCodec<global::AcFunDanmu.CommonStateSignalWishSheetCurrentState.Types.WishCurrentState> _repeated_b_codec
        = pb::FieldCodec.ForMessage(18, global::AcFunDanmu.CommonStateSignalWishSheetCurrentState.Types.WishCurrentState.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.CommonStateSignalWishSheetCurrentState.Types.WishCurrentState> b_ = new pbc::RepeatedField<global::AcFunDanmu.CommonStateSignalWishSheetCurrentState.Types.WishCurrentState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.CommonStateSignalWishSheetCurrentState.Types.WishCurrentState> B {
      get { return b_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CommonStateSignalWishSheetCurrentState);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CommonStateSignalWishSheetCurrentState other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (A != other.A) return false;
      if(!b_.Equals(other.b_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (A.Length != 0) hash ^= A.GetHashCode();
      hash ^= b_.GetHashCode();
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
      if (A.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(A);
      }
      b_.WriteTo(output, _repeated_b_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (A.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(A);
      }
      b_.WriteTo(ref output, _repeated_b_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (A.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(A);
      }
      size += b_.CalculateSize(_repeated_b_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CommonStateSignalWishSheetCurrentState other) {
      if (other == null) {
        return;
      }
      if (other.A.Length != 0) {
        A = other.A;
      }
      b_.Add(other.b_);
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
            A = input.ReadString();
            break;
          }
          case 18: {
            b_.AddEntriesFrom(input, _repeated_b_codec);
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
            A = input.ReadString();
            break;
          }
          case 18: {
            b_.AddEntriesFrom(ref input, _repeated_b_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CommonStateSignalWishSheetCurrentState message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class WishCurrentState : pb::IMessage<WishCurrentState>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<WishCurrentState> _parser = new pb::MessageParser<WishCurrentState>(() => new WishCurrentState());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<WishCurrentState> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::AcFunDanmu.CommonStateSignalWishSheetCurrentState.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public WishCurrentState() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public WishCurrentState(WishCurrentState other) : this() {
          a_ = other.a_;
          b_ = other.b_;
          c_ = other.c_;
          d_ = other.d_;
          e_ = other.e_;
          f_ = other.f_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public WishCurrentState Clone() {
          return new WishCurrentState(this);
        }

        /// <summary>Field number for the "a" field.</summary>
        public const int AFieldNumber = 1;
        private string a_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string A {
          get { return a_; }
          set {
            a_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "b" field.</summary>
        public const int BFieldNumber = 2;
        private long b_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long B {
          get { return b_; }
          set {
            b_ = value;
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
        private string e_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string E {
          get { return e_; }
          set {
            e_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "f" field.</summary>
        public const int FFieldNumber = 6;
        private string f_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string F {
          get { return f_; }
          set {
            f_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as WishCurrentState);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(WishCurrentState other) {
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
          if (F != other.F) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (A.Length != 0) hash ^= A.GetHashCode();
          if (B != 0L) hash ^= B.GetHashCode();
          if (C != 0L) hash ^= C.GetHashCode();
          if (D != 0L) hash ^= D.GetHashCode();
          if (E.Length != 0) hash ^= E.GetHashCode();
          if (F.Length != 0) hash ^= F.GetHashCode();
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
          if (A.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(A);
          }
          if (B != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(B);
          }
          if (C != 0L) {
            output.WriteRawTag(24);
            output.WriteInt64(C);
          }
          if (D != 0L) {
            output.WriteRawTag(32);
            output.WriteInt64(D);
          }
          if (E.Length != 0) {
            output.WriteRawTag(42);
            output.WriteString(E);
          }
          if (F.Length != 0) {
            output.WriteRawTag(50);
            output.WriteString(F);
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
          if (A.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(A);
          }
          if (B != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(B);
          }
          if (C != 0L) {
            output.WriteRawTag(24);
            output.WriteInt64(C);
          }
          if (D != 0L) {
            output.WriteRawTag(32);
            output.WriteInt64(D);
          }
          if (E.Length != 0) {
            output.WriteRawTag(42);
            output.WriteString(E);
          }
          if (F.Length != 0) {
            output.WriteRawTag(50);
            output.WriteString(F);
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
          if (A.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(A);
          }
          if (B != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(B);
          }
          if (C != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(C);
          }
          if (D != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(D);
          }
          if (E.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(E);
          }
          if (F.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(F);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(WishCurrentState other) {
          if (other == null) {
            return;
          }
          if (other.A.Length != 0) {
            A = other.A;
          }
          if (other.B != 0L) {
            B = other.B;
          }
          if (other.C != 0L) {
            C = other.C;
          }
          if (other.D != 0L) {
            D = other.D;
          }
          if (other.E.Length != 0) {
            E = other.E;
          }
          if (other.F.Length != 0) {
            F = other.F;
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
                A = input.ReadString();
                break;
              }
              case 16: {
                B = input.ReadInt64();
                break;
              }
              case 24: {
                C = input.ReadInt64();
                break;
              }
              case 32: {
                D = input.ReadInt64();
                break;
              }
              case 42: {
                E = input.ReadString();
                break;
              }
              case 50: {
                F = input.ReadString();
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
                A = input.ReadString();
                break;
              }
              case 16: {
                B = input.ReadInt64();
                break;
              }
              case 24: {
                C = input.ReadInt64();
                break;
              }
              case 32: {
                D = input.ReadInt64();
                break;
              }
              case 42: {
                E = input.ReadString();
                break;
              }
              case 50: {
                F = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
