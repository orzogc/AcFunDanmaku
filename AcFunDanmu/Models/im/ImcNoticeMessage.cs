// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ImcNoticeMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from ImcNoticeMessage.proto</summary>
  public static partial class ImcNoticeMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for ImcNoticeMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImcNoticeMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZJbWNOb3RpY2VNZXNzYWdlLnByb3RvEhtBY0Z1bkRhbm11LkltLkNsb3Vk",
            "Lk1lc3NhZ2UaG05vdGljZVBsYWNlaG9sZGVyTWV0YS5wcm90byK5AQoQSW1j",
            "Tm90aWNlTWVzc2FnZRIMCgR0ZXh0GAEgASgJElEKFW5vdGljZVBsYWNlaG9s",
            "ZGVyTWV0YRgCIAMoCzIyLkFjRnVuRGFubXUuSW0uQ2xvdWQuTWVzc2FnZS5O",
            "b3RpY2VQbGFjZWhvbGRlck1ldGESFgoObm90aWNlTWV0YVR5cGUYAyABKAUS",
            "FgoObm90aWNlTWV0YUluZm8YBCABKAwSFAoMZGlzcGxheVN0eWxlGAUgASgF",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Cloud.Message.NoticePlaceholderMetaReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.ImcNoticeMessage), global::AcFunDanmu.Im.Cloud.Message.ImcNoticeMessage.Parser, new[]{ "Text", "NoticePlaceholderMeta", "NoticeMetaType", "NoticeMetaInfo", "DisplayStyle" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ImcNoticeMessage : pb::IMessage<ImcNoticeMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ImcNoticeMessage> _parser = new pb::MessageParser<ImcNoticeMessage>(() => new ImcNoticeMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ImcNoticeMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Message.ImcNoticeMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImcNoticeMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImcNoticeMessage(ImcNoticeMessage other) : this() {
      text_ = other.text_;
      noticePlaceholderMeta_ = other.noticePlaceholderMeta_.Clone();
      noticeMetaType_ = other.noticeMetaType_;
      noticeMetaInfo_ = other.noticeMetaInfo_;
      displayStyle_ = other.displayStyle_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImcNoticeMessage Clone() {
      return new ImcNoticeMessage(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 1;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "noticePlaceholderMeta" field.</summary>
    public const int NoticePlaceholderMetaFieldNumber = 2;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Cloud.Message.NoticePlaceholderMeta> _repeated_noticePlaceholderMeta_codec
        = pb::FieldCodec.ForMessage(18, global::AcFunDanmu.Im.Cloud.Message.NoticePlaceholderMeta.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.NoticePlaceholderMeta> noticePlaceholderMeta_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.NoticePlaceholderMeta>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.NoticePlaceholderMeta> NoticePlaceholderMeta {
      get { return noticePlaceholderMeta_; }
    }

    /// <summary>Field number for the "noticeMetaType" field.</summary>
    public const int NoticeMetaTypeFieldNumber = 3;
    private int noticeMetaType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int NoticeMetaType {
      get { return noticeMetaType_; }
      set {
        noticeMetaType_ = value;
      }
    }

    /// <summary>Field number for the "noticeMetaInfo" field.</summary>
    public const int NoticeMetaInfoFieldNumber = 4;
    private pb::ByteString noticeMetaInfo_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString NoticeMetaInfo {
      get { return noticeMetaInfo_; }
      set {
        noticeMetaInfo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "displayStyle" field.</summary>
    public const int DisplayStyleFieldNumber = 5;
    private int displayStyle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int DisplayStyle {
      get { return displayStyle_; }
      set {
        displayStyle_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ImcNoticeMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ImcNoticeMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Text != other.Text) return false;
      if(!noticePlaceholderMeta_.Equals(other.noticePlaceholderMeta_)) return false;
      if (NoticeMetaType != other.NoticeMetaType) return false;
      if (NoticeMetaInfo != other.NoticeMetaInfo) return false;
      if (DisplayStyle != other.DisplayStyle) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      hash ^= noticePlaceholderMeta_.GetHashCode();
      if (NoticeMetaType != 0) hash ^= NoticeMetaType.GetHashCode();
      if (NoticeMetaInfo.Length != 0) hash ^= NoticeMetaInfo.GetHashCode();
      if (DisplayStyle != 0) hash ^= DisplayStyle.GetHashCode();
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
      if (Text.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Text);
      }
      noticePlaceholderMeta_.WriteTo(output, _repeated_noticePlaceholderMeta_codec);
      if (NoticeMetaType != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(NoticeMetaType);
      }
      if (NoticeMetaInfo.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(NoticeMetaInfo);
      }
      if (DisplayStyle != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(DisplayStyle);
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
      if (Text.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Text);
      }
      noticePlaceholderMeta_.WriteTo(ref output, _repeated_noticePlaceholderMeta_codec);
      if (NoticeMetaType != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(NoticeMetaType);
      }
      if (NoticeMetaInfo.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(NoticeMetaInfo);
      }
      if (DisplayStyle != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(DisplayStyle);
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
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      size += noticePlaceholderMeta_.CalculateSize(_repeated_noticePlaceholderMeta_codec);
      if (NoticeMetaType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NoticeMetaType);
      }
      if (NoticeMetaInfo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(NoticeMetaInfo);
      }
      if (DisplayStyle != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DisplayStyle);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ImcNoticeMessage other) {
      if (other == null) {
        return;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      noticePlaceholderMeta_.Add(other.noticePlaceholderMeta_);
      if (other.NoticeMetaType != 0) {
        NoticeMetaType = other.NoticeMetaType;
      }
      if (other.NoticeMetaInfo.Length != 0) {
        NoticeMetaInfo = other.NoticeMetaInfo;
      }
      if (other.DisplayStyle != 0) {
        DisplayStyle = other.DisplayStyle;
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
            Text = input.ReadString();
            break;
          }
          case 18: {
            noticePlaceholderMeta_.AddEntriesFrom(input, _repeated_noticePlaceholderMeta_codec);
            break;
          }
          case 24: {
            NoticeMetaType = input.ReadInt32();
            break;
          }
          case 34: {
            NoticeMetaInfo = input.ReadBytes();
            break;
          }
          case 40: {
            DisplayStyle = input.ReadInt32();
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
            Text = input.ReadString();
            break;
          }
          case 18: {
            noticePlaceholderMeta_.AddEntriesFrom(ref input, _repeated_noticePlaceholderMeta_codec);
            break;
          }
          case 24: {
            NoticeMetaType = input.ReadInt32();
            break;
          }
          case 34: {
            NoticeMetaInfo = input.ReadBytes();
            break;
          }
          case 40: {
            DisplayStyle = input.ReadInt32();
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
