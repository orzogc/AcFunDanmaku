// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetPictureInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from WidgetPictureInfo.proto</summary>
  public static partial class WidgetPictureInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetPictureInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetPictureInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdXaWRnZXRQaWN0dXJlSW5mby5wcm90bxIKQWNGdW5EYW5tdRoSSW1hZ2VD",
            "ZG5Ob2RlLnByb3RvIk4KEVdpZGdldFBpY3R1cmVJbmZvEiMKAWEYASABKAsy",
            "GC5BY0Z1bkRhbm11LkltYWdlQ2RuTm9kZRIJCgFiGAIgASgFEgkKAWMYAyAB",
            "KAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.ImageCdnNodeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.WidgetPictureInfo), global::AcFunDanmu.WidgetPictureInfo.Parser, new[]{ "A", "B", "C" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WidgetPictureInfo : pb::IMessage<WidgetPictureInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WidgetPictureInfo> _parser = new pb::MessageParser<WidgetPictureInfo>(() => new WidgetPictureInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WidgetPictureInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.WidgetPictureInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetPictureInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetPictureInfo(WidgetPictureInfo other) : this() {
      a_ = other.a_ != null ? other.a_.Clone() : null;
      b_ = other.b_;
      c_ = other.c_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetPictureInfo Clone() {
      return new WidgetPictureInfo(this);
    }

    /// <summary>Field number for the "a" field.</summary>
    public const int AFieldNumber = 1;
    private global::AcFunDanmu.ImageCdnNode a_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.ImageCdnNode A {
      get { return a_; }
      set {
        a_ = value;
      }
    }

    /// <summary>Field number for the "b" field.</summary>
    public const int BFieldNumber = 2;
    private int b_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int C {
      get { return c_; }
      set {
        c_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WidgetPictureInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WidgetPictureInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(A, other.A)) return false;
      if (B != other.B) return false;
      if (C != other.C) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (a_ != null) hash ^= A.GetHashCode();
      if (B != 0) hash ^= B.GetHashCode();
      if (C != 0) hash ^= C.GetHashCode();
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
      if (B != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(B);
      }
      if (C != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(C);
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
      if (B != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(B);
      }
      if (C != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(C);
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
      if (B != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(B);
      }
      if (C != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(C);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WidgetPictureInfo other) {
      if (other == null) {
        return;
      }
      if (other.a_ != null) {
        if (a_ == null) {
          A = new global::AcFunDanmu.ImageCdnNode();
        }
        A.MergeFrom(other.A);
      }
      if (other.B != 0) {
        B = other.B;
      }
      if (other.C != 0) {
        C = other.C;
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
              A = new global::AcFunDanmu.ImageCdnNode();
            }
            input.ReadMessage(A);
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
              A = new global::AcFunDanmu.ImageCdnNode();
            }
            input.ReadMessage(A);
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code