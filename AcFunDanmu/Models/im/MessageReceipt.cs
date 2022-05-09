// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageReceipt.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Data.Update {

  /// <summary>Holder for reflection information generated from MessageReceipt.proto</summary>
  public static partial class MessageReceiptReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageReceipt.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageReceiptReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRNZXNzYWdlUmVjZWlwdC5wcm90bxIfQWNGdW5EYW5tdS5JbS5DbG91ZC5E",
            "YXRhLlVwZGF0ZRoQQ2hhdFRhcmdldC5wcm90bxoaTWVzc2FnZVJlY2VpcHRT",
            "dGF0dXMucHJvdG8aClVzZXIucHJvdG8itgEKDk1lc3NhZ2VSZWNlaXB0EjUK",
            "CmNoYXRUYXJnZXQYASABKAsyIS5BY0Z1bkRhbm11LkltLk1lc3NhZ2UuQ2hh",
            "dFRhcmdldBJCCg1yZWNlaXB0U3RhdHVzGAIgASgLMisuQWNGdW5EYW5tdS5J",
            "bS5NZXNzYWdlLk1lc3NhZ2VSZWNlaXB0U3RhdHVzEikKBnJlYWRlchgDIAEo",
            "CzIZLkFjRnVuRGFubXUuSW0uQmFzaWMuVXNlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Message.ChatTargetReflection.Descriptor, global::AcFunDanmu.Im.Message.MessageReceiptStatusReflection.Descriptor, global::AcFunDanmu.Im.Basic.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Data.Update.MessageReceipt), global::AcFunDanmu.Im.Cloud.Data.Update.MessageReceipt.Parser, new[]{ "ChatTarget", "ReceiptStatus", "Reader" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MessageReceipt : pb::IMessage<MessageReceipt>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MessageReceipt> _parser = new pb::MessageParser<MessageReceipt>(() => new MessageReceipt());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MessageReceipt> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Data.Update.MessageReceiptReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageReceipt() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageReceipt(MessageReceipt other) : this() {
      chatTarget_ = other.chatTarget_ != null ? other.chatTarget_.Clone() : null;
      receiptStatus_ = other.receiptStatus_ != null ? other.receiptStatus_.Clone() : null;
      reader_ = other.reader_ != null ? other.reader_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageReceipt Clone() {
      return new MessageReceipt(this);
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

    /// <summary>Field number for the "receiptStatus" field.</summary>
    public const int ReceiptStatusFieldNumber = 2;
    private global::AcFunDanmu.Im.Message.MessageReceiptStatus receiptStatus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Message.MessageReceiptStatus ReceiptStatus {
      get { return receiptStatus_; }
      set {
        receiptStatus_ = value;
      }
    }

    /// <summary>Field number for the "reader" field.</summary>
    public const int ReaderFieldNumber = 3;
    private global::AcFunDanmu.Im.Basic.User reader_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.User Reader {
      get { return reader_; }
      set {
        reader_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MessageReceipt);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MessageReceipt other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ChatTarget, other.ChatTarget)) return false;
      if (!object.Equals(ReceiptStatus, other.ReceiptStatus)) return false;
      if (!object.Equals(Reader, other.Reader)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (chatTarget_ != null) hash ^= ChatTarget.GetHashCode();
      if (receiptStatus_ != null) hash ^= ReceiptStatus.GetHashCode();
      if (reader_ != null) hash ^= Reader.GetHashCode();
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
      if (receiptStatus_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ReceiptStatus);
      }
      if (reader_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Reader);
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
      if (receiptStatus_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ReceiptStatus);
      }
      if (reader_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Reader);
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
      if (receiptStatus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReceiptStatus);
      }
      if (reader_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reader);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MessageReceipt other) {
      if (other == null) {
        return;
      }
      if (other.chatTarget_ != null) {
        if (chatTarget_ == null) {
          ChatTarget = new global::AcFunDanmu.Im.Message.ChatTarget();
        }
        ChatTarget.MergeFrom(other.ChatTarget);
      }
      if (other.receiptStatus_ != null) {
        if (receiptStatus_ == null) {
          ReceiptStatus = new global::AcFunDanmu.Im.Message.MessageReceiptStatus();
        }
        ReceiptStatus.MergeFrom(other.ReceiptStatus);
      }
      if (other.reader_ != null) {
        if (reader_ == null) {
          Reader = new global::AcFunDanmu.Im.Basic.User();
        }
        Reader.MergeFrom(other.Reader);
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
            if (receiptStatus_ == null) {
              ReceiptStatus = new global::AcFunDanmu.Im.Message.MessageReceiptStatus();
            }
            input.ReadMessage(ReceiptStatus);
            break;
          }
          case 26: {
            if (reader_ == null) {
              Reader = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(Reader);
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
            if (receiptStatus_ == null) {
              ReceiptStatus = new global::AcFunDanmu.Im.Message.MessageReceiptStatus();
            }
            input.ReadMessage(ReceiptStatus);
            break;
          }
          case 26: {
            if (reader_ == null) {
              Reader = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(Reader);
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