// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Attachment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Message {

  /// <summary>Holder for reflection information generated from Attachment.proto</summary>
  public static partial class AttachmentReflection {

    #region Descriptor
    /// <summary>File descriptor for Attachment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AttachmentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBBdHRhY2htZW50LnByb3RvEhVBY0Z1bkRhbm11LkltLk1lc3NhZ2UaFUF1",
            "ZGlvQXR0YWNobWVudC5wcm90bxoVSW1hZ2VBdHRhY2htZW50LnByb3RvIqAB",
            "CgpBdHRhY2htZW50EkEKD2ltYWdlQXR0YWNobWVudBgBIAEoCzImLkFjRnVu",
            "RGFubXUuSW0uTWVzc2FnZS5JbWFnZUF0dGFjaG1lbnRIABJBCg9hdWRpb0F0",
            "dGFjaG1lbnQYAiABKAsyJi5BY0Z1bkRhbm11LkltLk1lc3NhZ2UuQXVkaW9B",
            "dHRhY2htZW50SABCDAoKYXR0YWNobWVudGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Message.AudioAttachmentReflection.Descriptor, global::AcFunDanmu.Im.Message.ImageAttachmentReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Message.Attachment), global::AcFunDanmu.Im.Message.Attachment.Parser, new[]{ "ImageAttachment", "AudioAttachment" }, new[]{ "Attachment" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Attachment : pb::IMessage<Attachment>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Attachment> _parser = new pb::MessageParser<Attachment>(() => new Attachment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Attachment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Message.AttachmentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Attachment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Attachment(Attachment other) : this() {
      switch (other.AttachmentCase) {
        case AttachmentOneofCase.ImageAttachment:
          ImageAttachment = other.ImageAttachment.Clone();
          break;
        case AttachmentOneofCase.AudioAttachment:
          AudioAttachment = other.AudioAttachment.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Attachment Clone() {
      return new Attachment(this);
    }

    /// <summary>Field number for the "imageAttachment" field.</summary>
    public const int ImageAttachmentFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Message.ImageAttachment ImageAttachment {
      get { return attachmentCase_ == AttachmentOneofCase.ImageAttachment ? (global::AcFunDanmu.Im.Message.ImageAttachment) attachment_ : null; }
      set {
        attachment_ = value;
        attachmentCase_ = value == null ? AttachmentOneofCase.None : AttachmentOneofCase.ImageAttachment;
      }
    }

    /// <summary>Field number for the "audioAttachment" field.</summary>
    public const int AudioAttachmentFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Message.AudioAttachment AudioAttachment {
      get { return attachmentCase_ == AttachmentOneofCase.AudioAttachment ? (global::AcFunDanmu.Im.Message.AudioAttachment) attachment_ : null; }
      set {
        attachment_ = value;
        attachmentCase_ = value == null ? AttachmentOneofCase.None : AttachmentOneofCase.AudioAttachment;
      }
    }

    private object attachment_;
    /// <summary>Enum of possible cases for the "attachment" oneof.</summary>
    public enum AttachmentOneofCase {
      None = 0,
      ImageAttachment = 1,
      AudioAttachment = 2,
    }
    private AttachmentOneofCase attachmentCase_ = AttachmentOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AttachmentOneofCase AttachmentCase {
      get { return attachmentCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAttachment() {
      attachmentCase_ = AttachmentOneofCase.None;
      attachment_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Attachment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Attachment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ImageAttachment, other.ImageAttachment)) return false;
      if (!object.Equals(AudioAttachment, other.AudioAttachment)) return false;
      if (AttachmentCase != other.AttachmentCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (attachmentCase_ == AttachmentOneofCase.ImageAttachment) hash ^= ImageAttachment.GetHashCode();
      if (attachmentCase_ == AttachmentOneofCase.AudioAttachment) hash ^= AudioAttachment.GetHashCode();
      hash ^= (int) attachmentCase_;
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
      if (attachmentCase_ == AttachmentOneofCase.ImageAttachment) {
        output.WriteRawTag(10);
        output.WriteMessage(ImageAttachment);
      }
      if (attachmentCase_ == AttachmentOneofCase.AudioAttachment) {
        output.WriteRawTag(18);
        output.WriteMessage(AudioAttachment);
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
      if (attachmentCase_ == AttachmentOneofCase.ImageAttachment) {
        output.WriteRawTag(10);
        output.WriteMessage(ImageAttachment);
      }
      if (attachmentCase_ == AttachmentOneofCase.AudioAttachment) {
        output.WriteRawTag(18);
        output.WriteMessage(AudioAttachment);
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
      if (attachmentCase_ == AttachmentOneofCase.ImageAttachment) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ImageAttachment);
      }
      if (attachmentCase_ == AttachmentOneofCase.AudioAttachment) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AudioAttachment);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Attachment other) {
      if (other == null) {
        return;
      }
      switch (other.AttachmentCase) {
        case AttachmentOneofCase.ImageAttachment:
          if (ImageAttachment == null) {
            ImageAttachment = new global::AcFunDanmu.Im.Message.ImageAttachment();
          }
          ImageAttachment.MergeFrom(other.ImageAttachment);
          break;
        case AttachmentOneofCase.AudioAttachment:
          if (AudioAttachment == null) {
            AudioAttachment = new global::AcFunDanmu.Im.Message.AudioAttachment();
          }
          AudioAttachment.MergeFrom(other.AudioAttachment);
          break;
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
            global::AcFunDanmu.Im.Message.ImageAttachment subBuilder = new global::AcFunDanmu.Im.Message.ImageAttachment();
            if (attachmentCase_ == AttachmentOneofCase.ImageAttachment) {
              subBuilder.MergeFrom(ImageAttachment);
            }
            input.ReadMessage(subBuilder);
            ImageAttachment = subBuilder;
            break;
          }
          case 18: {
            global::AcFunDanmu.Im.Message.AudioAttachment subBuilder = new global::AcFunDanmu.Im.Message.AudioAttachment();
            if (attachmentCase_ == AttachmentOneofCase.AudioAttachment) {
              subBuilder.MergeFrom(AudioAttachment);
            }
            input.ReadMessage(subBuilder);
            AudioAttachment = subBuilder;
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
            global::AcFunDanmu.Im.Message.ImageAttachment subBuilder = new global::AcFunDanmu.Im.Message.ImageAttachment();
            if (attachmentCase_ == AttachmentOneofCase.ImageAttachment) {
              subBuilder.MergeFrom(ImageAttachment);
            }
            input.ReadMessage(subBuilder);
            ImageAttachment = subBuilder;
            break;
          }
          case 18: {
            global::AcFunDanmu.Im.Message.AudioAttachment subBuilder = new global::AcFunDanmu.Im.Message.AudioAttachment();
            if (attachmentCase_ == AttachmentOneofCase.AudioAttachment) {
              subBuilder.MergeFrom(AudioAttachment);
            }
            input.ReadMessage(subBuilder);
            AudioAttachment = subBuilder;
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