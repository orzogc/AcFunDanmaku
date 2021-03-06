// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CommonStateSignalChatReady.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from CommonStateSignalChatReady.proto</summary>
  public static partial class CommonStateSignalChatReadyReflection {

    #region Descriptor
    /// <summary>File descriptor for CommonStateSignalChatReady.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonStateSignalChatReadyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBDb21tb25TdGF0ZVNpZ25hbENoYXRSZWFkeS5wcm90bxIKQWNGdW5EYW5t",
            "dRoTQ2hhdE1lZGlhVHlwZS5wcm90bxoUWnRMaXZlVXNlckluZm8ucHJvdG8i",
            "jQEKGkNvbW1vblN0YXRlU2lnbmFsQ2hhdFJlYWR5Eg4KBmNoYXRJZBgBIAEo",
            "CRIxCg1ndWVzdFVzZXJJbmZvGAIgASgLMhouQWNGdW5EYW5tdS5adExpdmVV",
            "c2VySW5mbxIsCgltZWRpYVR5cGUYAyABKA4yGS5BY0Z1bkRhbm11LkNoYXRN",
            "ZWRpYVR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.ChatMediaTypeReflection.Descriptor, global::AcFunDanmu.ZtLiveUserInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.CommonStateSignalChatReady), global::AcFunDanmu.CommonStateSignalChatReady.Parser, new[]{ "ChatId", "GuestUserInfo", "MediaType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CommonStateSignalChatReady : pb::IMessage<CommonStateSignalChatReady>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CommonStateSignalChatReady> _parser = new pb::MessageParser<CommonStateSignalChatReady>(() => new CommonStateSignalChatReady());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommonStateSignalChatReady> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.CommonStateSignalChatReadyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonStateSignalChatReady() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonStateSignalChatReady(CommonStateSignalChatReady other) : this() {
      chatId_ = other.chatId_;
      guestUserInfo_ = other.guestUserInfo_ != null ? other.guestUserInfo_.Clone() : null;
      mediaType_ = other.mediaType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonStateSignalChatReady Clone() {
      return new CommonStateSignalChatReady(this);
    }

    /// <summary>Field number for the "chatId" field.</summary>
    public const int ChatIdFieldNumber = 1;
    private string chatId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ChatId {
      get { return chatId_; }
      set {
        chatId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "guestUserInfo" field.</summary>
    public const int GuestUserInfoFieldNumber = 2;
    private global::AcFunDanmu.ZtLiveUserInfo guestUserInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.ZtLiveUserInfo GuestUserInfo {
      get { return guestUserInfo_; }
      set {
        guestUserInfo_ = value;
      }
    }

    /// <summary>Field number for the "mediaType" field.</summary>
    public const int MediaTypeFieldNumber = 3;
    private global::AcFunDanmu.ChatMediaType mediaType_ = global::AcFunDanmu.ChatMediaType.Unknown;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.ChatMediaType MediaType {
      get { return mediaType_; }
      set {
        mediaType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommonStateSignalChatReady);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommonStateSignalChatReady other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChatId != other.ChatId) return false;
      if (!object.Equals(GuestUserInfo, other.GuestUserInfo)) return false;
      if (MediaType != other.MediaType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ChatId.Length != 0) hash ^= ChatId.GetHashCode();
      if (guestUserInfo_ != null) hash ^= GuestUserInfo.GetHashCode();
      if (MediaType != global::AcFunDanmu.ChatMediaType.Unknown) hash ^= MediaType.GetHashCode();
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
      if (ChatId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ChatId);
      }
      if (guestUserInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GuestUserInfo);
      }
      if (MediaType != global::AcFunDanmu.ChatMediaType.Unknown) {
        output.WriteRawTag(24);
        output.WriteEnum((int) MediaType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ChatId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ChatId);
      }
      if (guestUserInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GuestUserInfo);
      }
      if (MediaType != global::AcFunDanmu.ChatMediaType.Unknown) {
        output.WriteRawTag(24);
        output.WriteEnum((int) MediaType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ChatId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChatId);
      }
      if (guestUserInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GuestUserInfo);
      }
      if (MediaType != global::AcFunDanmu.ChatMediaType.Unknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MediaType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommonStateSignalChatReady other) {
      if (other == null) {
        return;
      }
      if (other.ChatId.Length != 0) {
        ChatId = other.ChatId;
      }
      if (other.guestUserInfo_ != null) {
        if (guestUserInfo_ == null) {
          GuestUserInfo = new global::AcFunDanmu.ZtLiveUserInfo();
        }
        GuestUserInfo.MergeFrom(other.GuestUserInfo);
      }
      if (other.MediaType != global::AcFunDanmu.ChatMediaType.Unknown) {
        MediaType = other.MediaType;
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
          case 10: {
            ChatId = input.ReadString();
            break;
          }
          case 18: {
            if (guestUserInfo_ == null) {
              GuestUserInfo = new global::AcFunDanmu.ZtLiveUserInfo();
            }
            input.ReadMessage(GuestUserInfo);
            break;
          }
          case 24: {
            MediaType = (global::AcFunDanmu.ChatMediaType) input.ReadEnum();
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
          case 10: {
            ChatId = input.ReadString();
            break;
          }
          case 18: {
            if (guestUserInfo_ == null) {
              GuestUserInfo = new global::AcFunDanmu.ZtLiveUserInfo();
            }
            input.ReadMessage(GuestUserInfo);
            break;
          }
          case 24: {
            MediaType = (global::AcFunDanmu.ChatMediaType) input.ReadEnum();
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
