// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ImcPassThroughPush.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from ImcPassThroughPush.proto</summary>
  public static partial class ImcPassThroughPushReflection {

    #region Descriptor
    /// <summary>File descriptor for ImcPassThroughPush.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImcPassThroughPushReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhJbWNQYXNzVGhyb3VnaFB1c2gucHJvdG8SG0FjRnVuRGFubXUuSW0uQ2xv",
            "dWQuTWVzc2FnZRoQQ2hhdFRhcmdldC5wcm90bxoKVXNlci5wcm90byKeAQoS",
            "SW1jUGFzc1Rocm91Z2hQdXNoEjUKCmNoYXRUYXJnZXQYASABKAsyIS5BY0Z1",
            "bkRhbm11LkltLk1lc3NhZ2UuQ2hhdFRhcmdldBIrCghmcm9tVXNlchgCIAEo",
            "CzIZLkFjRnVuRGFubXUuSW0uQmFzaWMuVXNlchIPCgdjb250ZW50GAMgASgM",
            "EhMKC2NvbnRlbnRUeXBlGAQgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Message.ChatTargetReflection.Descriptor, global::AcFunDanmu.Im.Basic.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.ImcPassThroughPush), global::AcFunDanmu.Im.Cloud.Message.ImcPassThroughPush.Parser, new[]{ "ChatTarget", "FromUser", "Content", "ContentType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ImcPassThroughPush : pb::IMessage<ImcPassThroughPush>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ImcPassThroughPush> _parser = new pb::MessageParser<ImcPassThroughPush>(() => new ImcPassThroughPush());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ImcPassThroughPush> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Message.ImcPassThroughPushReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImcPassThroughPush() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImcPassThroughPush(ImcPassThroughPush other) : this() {
      chatTarget_ = other.chatTarget_ != null ? other.chatTarget_.Clone() : null;
      fromUser_ = other.fromUser_ != null ? other.fromUser_.Clone() : null;
      content_ = other.content_;
      contentType_ = other.contentType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImcPassThroughPush Clone() {
      return new ImcPassThroughPush(this);
    }

    /// <summary>Field number for the "chatTarget" field.</summary>
    public const int ChatTargetFieldNumber = 1;
    private global::AcFunDanmu.Im.Message.ChatTarget chatTarget_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Message.ChatTarget ChatTarget {
      get { return chatTarget_; }
      set {
        chatTarget_ = value;
      }
    }

    /// <summary>Field number for the "fromUser" field.</summary>
    public const int FromUserFieldNumber = 2;
    private global::AcFunDanmu.Im.Basic.User fromUser_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.User FromUser {
      get { return fromUser_; }
      set {
        fromUser_ = value;
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 3;
    private pb::ByteString content_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "contentType" field.</summary>
    public const int ContentTypeFieldNumber = 4;
    private int contentType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ContentType {
      get { return contentType_; }
      set {
        contentType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ImcPassThroughPush);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ImcPassThroughPush other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ChatTarget, other.ChatTarget)) return false;
      if (!object.Equals(FromUser, other.FromUser)) return false;
      if (Content != other.Content) return false;
      if (ContentType != other.ContentType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (chatTarget_ != null) hash ^= ChatTarget.GetHashCode();
      if (fromUser_ != null) hash ^= FromUser.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (ContentType != 0) hash ^= ContentType.GetHashCode();
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
      if (chatTarget_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ChatTarget);
      }
      if (fromUser_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(FromUser);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Content);
      }
      if (ContentType != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ContentType);
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
      if (chatTarget_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ChatTarget);
      }
      if (fromUser_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(FromUser);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Content);
      }
      if (ContentType != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ContentType);
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
      if (chatTarget_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChatTarget);
      }
      if (fromUser_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FromUser);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Content);
      }
      if (ContentType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ContentType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ImcPassThroughPush other) {
      if (other == null) {
        return;
      }
      if (other.chatTarget_ != null) {
        if (chatTarget_ == null) {
          ChatTarget = new global::AcFunDanmu.Im.Message.ChatTarget();
        }
        ChatTarget.MergeFrom(other.ChatTarget);
      }
      if (other.fromUser_ != null) {
        if (fromUser_ == null) {
          FromUser = new global::AcFunDanmu.Im.Basic.User();
        }
        FromUser.MergeFrom(other.FromUser);
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.ContentType != 0) {
        ContentType = other.ContentType;
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
            if (chatTarget_ == null) {
              ChatTarget = new global::AcFunDanmu.Im.Message.ChatTarget();
            }
            input.ReadMessage(ChatTarget);
            break;
          }
          case 18: {
            if (fromUser_ == null) {
              FromUser = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(FromUser);
            break;
          }
          case 26: {
            Content = input.ReadBytes();
            break;
          }
          case 32: {
            ContentType = input.ReadInt32();
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
            if (chatTarget_ == null) {
              ChatTarget = new global::AcFunDanmu.Im.Message.ChatTarget();
            }
            input.ReadMessage(ChatTarget);
            break;
          }
          case 18: {
            if (fromUser_ == null) {
              FromUser = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(FromUser);
            break;
          }
          case 26: {
            Content = input.ReadBytes();
            break;
          }
          case 32: {
            ContentType = input.ReadInt32();
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
