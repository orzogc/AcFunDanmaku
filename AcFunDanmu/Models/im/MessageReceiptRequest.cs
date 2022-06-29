// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageReceiptRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Message {

  /// <summary>Holder for reflection information generated from MessageReceiptRequest.proto</summary>
  public static partial class MessageReceiptRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageReceiptRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageReceiptRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtNZXNzYWdlUmVjZWlwdFJlcXVlc3QucHJvdG8SFUFjRnVuRGFubXUuSW0u",
            "TWVzc2FnZRoQQ2hhdFRhcmdldC5wcm90bxoYTWVzc2FnZVJlY2VpcHRJbmZv",
            "LnByb3RvIpUBChVNZXNzYWdlUmVjZWlwdFJlcXVlc3QSRQoSbWVzc2FnZVJl",
            "Y2VpcHRJbmZvGAEgAygLMikuQWNGdW5EYW5tdS5JbS5NZXNzYWdlLk1lc3Nh",
            "Z2VSZWNlaXB0SW5mbxI1CgpjaGF0VGFyZ2V0GAIgASgLMiEuQWNGdW5EYW5t",
            "dS5JbS5NZXNzYWdlLkNoYXRUYXJnZXRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Message.ChatTargetReflection.Descriptor, global::AcFunDanmu.Im.Message.MessageReceiptInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Message.MessageReceiptRequest), global::AcFunDanmu.Im.Message.MessageReceiptRequest.Parser, new[]{ "MessageReceiptInfo", "ChatTarget" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MessageReceiptRequest : pb::IMessage<MessageReceiptRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MessageReceiptRequest> _parser = new pb::MessageParser<MessageReceiptRequest>(() => new MessageReceiptRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MessageReceiptRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Message.MessageReceiptRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageReceiptRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageReceiptRequest(MessageReceiptRequest other) : this() {
      messageReceiptInfo_ = other.messageReceiptInfo_.Clone();
      chatTarget_ = other.chatTarget_ != null ? other.chatTarget_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageReceiptRequest Clone() {
      return new MessageReceiptRequest(this);
    }

    /// <summary>Field number for the "messageReceiptInfo" field.</summary>
    public const int MessageReceiptInfoFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Message.MessageReceiptInfo> _repeated_messageReceiptInfo_codec
        = pb::FieldCodec.ForMessage(10, global::AcFunDanmu.Im.Message.MessageReceiptInfo.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Message.MessageReceiptInfo> messageReceiptInfo_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Message.MessageReceiptInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Message.MessageReceiptInfo> MessageReceiptInfo {
      get { return messageReceiptInfo_; }
    }

    /// <summary>Field number for the "chatTarget" field.</summary>
    public const int ChatTargetFieldNumber = 2;
    private global::AcFunDanmu.Im.Message.ChatTarget chatTarget_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Message.ChatTarget ChatTarget {
      get { return chatTarget_; }
      set {
        chatTarget_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MessageReceiptRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MessageReceiptRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!messageReceiptInfo_.Equals(other.messageReceiptInfo_)) return false;
      if (!object.Equals(ChatTarget, other.ChatTarget)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= messageReceiptInfo_.GetHashCode();
      if (chatTarget_ != null) hash ^= ChatTarget.GetHashCode();
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
      messageReceiptInfo_.WriteTo(output, _repeated_messageReceiptInfo_codec);
      if (chatTarget_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ChatTarget);
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
      messageReceiptInfo_.WriteTo(ref output, _repeated_messageReceiptInfo_codec);
      if (chatTarget_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ChatTarget);
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
      size += messageReceiptInfo_.CalculateSize(_repeated_messageReceiptInfo_codec);
      if (chatTarget_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChatTarget);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MessageReceiptRequest other) {
      if (other == null) {
        return;
      }
      messageReceiptInfo_.Add(other.messageReceiptInfo_);
      if (other.chatTarget_ != null) {
        if (chatTarget_ == null) {
          ChatTarget = new global::AcFunDanmu.Im.Message.ChatTarget();
        }
        ChatTarget.MergeFrom(other.ChatTarget);
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
            messageReceiptInfo_.AddEntriesFrom(input, _repeated_messageReceiptInfo_codec);
            break;
          }
          case 18: {
            if (chatTarget_ == null) {
              ChatTarget = new global::AcFunDanmu.Im.Message.ChatTarget();
            }
            input.ReadMessage(ChatTarget);
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
            messageReceiptInfo_.AddEntriesFrom(ref input, _repeated_messageReceiptInfo_codec);
            break;
          }
          case 18: {
            if (chatTarget_ == null) {
              ChatTarget = new global::AcFunDanmu.Im.Message.ChatTarget();
            }
            input.ReadMessage(ChatTarget);
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
