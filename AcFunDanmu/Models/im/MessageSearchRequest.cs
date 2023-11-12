// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageSearchRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Search {

  /// <summary>Holder for reflection information generated from MessageSearchRequest.proto</summary>
  public static partial class MessageSearchRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageSearchRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageSearchRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpNZXNzYWdlU2VhcmNoUmVxdWVzdC5wcm90bxIaQWNGdW5EYW5tdS5JbS5D",
            "bG91ZC5TZWFyY2gaEENoYXRUYXJnZXQucHJvdG8aFEltY01lc3NhZ2VUeXBl",
            "LnByb3RvGhBUaW1lRmlsdGVyLnByb3RvGgpVc2VyLnByb3RvIu0CChRNZXNz",
            "YWdlU2VhcmNoUmVxdWVzdBI1CgpjaGF0VGFyZ2V0GAEgASgLMiEuQWNGdW5E",
            "YW5tdS5JbS5NZXNzYWdlLkNoYXRUYXJnZXQSJwoEZnJvbRgCIAEoCzIZLkFj",
            "RnVuRGFubXUuSW0uQmFzaWMuVXNlchI8Cgdtc2dUeXBlGAMgAygOMisuQWNG",
            "dW5EYW5tdS5JbS5DbG91ZC5NZXNzYWdlLkltY01lc3NhZ2VUeXBlEhAKCGZp",
            "bGVOYW1lGAQgAygJEg0KBXF1ZXJ5GAUgAygJEg4KBm9mZnNldBgGIAEoCRI6",
            "Cgp0aW1lRmlsdGVyGAcgASgLMiYuQWNGdW5EYW5tdS5JbS5DbG91ZC5TZWFy",
            "Y2guVGltZUZpbHRlchIaChJtc2dDb3VudFBlclNlc3Npb24YCCABKAUSEwoL",
            "bWVzc2FnZVR5cGUYCSADKAUSGQoRc2VhcmNoQWZ0ZXJPZmZzZXQYCiABKAhi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Message.ChatTargetReflection.Descriptor, global::AcFunDanmu.Im.Cloud.Message.ImcMessageTypeReflection.Descriptor, global::AcFunDanmu.Im.Cloud.Search.TimeFilterReflection.Descriptor, global::AcFunDanmu.Im.Basic.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Search.MessageSearchRequest), global::AcFunDanmu.Im.Cloud.Search.MessageSearchRequest.Parser, new[]{ "ChatTarget", "From", "MsgType", "FileName", "Query", "Offset", "TimeFilter", "MsgCountPerSession", "MessageType", "SearchAfterOffset" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MessageSearchRequest : pb::IMessage<MessageSearchRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MessageSearchRequest> _parser = new pb::MessageParser<MessageSearchRequest>(() => new MessageSearchRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MessageSearchRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Search.MessageSearchRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageSearchRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageSearchRequest(MessageSearchRequest other) : this() {
      chatTarget_ = other.chatTarget_ != null ? other.chatTarget_.Clone() : null;
      from_ = other.from_ != null ? other.from_.Clone() : null;
      msgType_ = other.msgType_.Clone();
      fileName_ = other.fileName_.Clone();
      query_ = other.query_.Clone();
      offset_ = other.offset_;
      timeFilter_ = other.timeFilter_ != null ? other.timeFilter_.Clone() : null;
      msgCountPerSession_ = other.msgCountPerSession_;
      messageType_ = other.messageType_.Clone();
      searchAfterOffset_ = other.searchAfterOffset_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageSearchRequest Clone() {
      return new MessageSearchRequest(this);
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

    /// <summary>Field number for the "from" field.</summary>
    public const int FromFieldNumber = 2;
    private global::AcFunDanmu.Im.Basic.User from_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.User From {
      get { return from_; }
      set {
        from_ = value;
      }
    }

    /// <summary>Field number for the "msgType" field.</summary>
    public const int MsgTypeFieldNumber = 3;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Cloud.Message.ImcMessageType> _repeated_msgType_codec
        = pb::FieldCodec.ForEnum(26, x => (int) x, x => (global::AcFunDanmu.Im.Cloud.Message.ImcMessageType) x);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.ImcMessageType> msgType_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.ImcMessageType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.ImcMessageType> MsgType {
      get { return msgType_; }
    }

    /// <summary>Field number for the "fileName" field.</summary>
    public const int FileNameFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_fileName_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> fileName_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> FileName {
      get { return fileName_; }
    }

    /// <summary>Field number for the "query" field.</summary>
    public const int QueryFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_query_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> query_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Query {
      get { return query_; }
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 6;
    private string offset_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Offset {
      get { return offset_; }
      set {
        offset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timeFilter" field.</summary>
    public const int TimeFilterFieldNumber = 7;
    private global::AcFunDanmu.Im.Cloud.Search.TimeFilter timeFilter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Search.TimeFilter TimeFilter {
      get { return timeFilter_; }
      set {
        timeFilter_ = value;
      }
    }

    /// <summary>Field number for the "msgCountPerSession" field.</summary>
    public const int MsgCountPerSessionFieldNumber = 8;
    private int msgCountPerSession_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MsgCountPerSession {
      get { return msgCountPerSession_; }
      set {
        msgCountPerSession_ = value;
      }
    }

    /// <summary>Field number for the "messageType" field.</summary>
    public const int MessageTypeFieldNumber = 9;
    private static readonly pb::FieldCodec<int> _repeated_messageType_codec
        = pb::FieldCodec.ForInt32(74);
    private readonly pbc::RepeatedField<int> messageType_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> MessageType {
      get { return messageType_; }
    }

    /// <summary>Field number for the "searchAfterOffset" field.</summary>
    public const int SearchAfterOffsetFieldNumber = 10;
    private bool searchAfterOffset_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SearchAfterOffset {
      get { return searchAfterOffset_; }
      set {
        searchAfterOffset_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MessageSearchRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MessageSearchRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ChatTarget, other.ChatTarget)) return false;
      if (!object.Equals(From, other.From)) return false;
      if(!msgType_.Equals(other.msgType_)) return false;
      if(!fileName_.Equals(other.fileName_)) return false;
      if(!query_.Equals(other.query_)) return false;
      if (Offset != other.Offset) return false;
      if (!object.Equals(TimeFilter, other.TimeFilter)) return false;
      if (MsgCountPerSession != other.MsgCountPerSession) return false;
      if(!messageType_.Equals(other.messageType_)) return false;
      if (SearchAfterOffset != other.SearchAfterOffset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (chatTarget_ != null) hash ^= ChatTarget.GetHashCode();
      if (from_ != null) hash ^= From.GetHashCode();
      hash ^= msgType_.GetHashCode();
      hash ^= fileName_.GetHashCode();
      hash ^= query_.GetHashCode();
      if (Offset.Length != 0) hash ^= Offset.GetHashCode();
      if (timeFilter_ != null) hash ^= TimeFilter.GetHashCode();
      if (MsgCountPerSession != 0) hash ^= MsgCountPerSession.GetHashCode();
      hash ^= messageType_.GetHashCode();
      if (SearchAfterOffset != false) hash ^= SearchAfterOffset.GetHashCode();
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
      if (from_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(From);
      }
      msgType_.WriteTo(output, _repeated_msgType_codec);
      fileName_.WriteTo(output, _repeated_fileName_codec);
      query_.WriteTo(output, _repeated_query_codec);
      if (Offset.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Offset);
      }
      if (timeFilter_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(TimeFilter);
      }
      if (MsgCountPerSession != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(MsgCountPerSession);
      }
      messageType_.WriteTo(output, _repeated_messageType_codec);
      if (SearchAfterOffset != false) {
        output.WriteRawTag(80);
        output.WriteBool(SearchAfterOffset);
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
      if (from_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(From);
      }
      msgType_.WriteTo(ref output, _repeated_msgType_codec);
      fileName_.WriteTo(ref output, _repeated_fileName_codec);
      query_.WriteTo(ref output, _repeated_query_codec);
      if (Offset.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Offset);
      }
      if (timeFilter_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(TimeFilter);
      }
      if (MsgCountPerSession != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(MsgCountPerSession);
      }
      messageType_.WriteTo(ref output, _repeated_messageType_codec);
      if (SearchAfterOffset != false) {
        output.WriteRawTag(80);
        output.WriteBool(SearchAfterOffset);
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
      if (from_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(From);
      }
      size += msgType_.CalculateSize(_repeated_msgType_codec);
      size += fileName_.CalculateSize(_repeated_fileName_codec);
      size += query_.CalculateSize(_repeated_query_codec);
      if (Offset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Offset);
      }
      if (timeFilter_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TimeFilter);
      }
      if (MsgCountPerSession != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MsgCountPerSession);
      }
      size += messageType_.CalculateSize(_repeated_messageType_codec);
      if (SearchAfterOffset != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MessageSearchRequest other) {
      if (other == null) {
        return;
      }
      if (other.chatTarget_ != null) {
        if (chatTarget_ == null) {
          ChatTarget = new global::AcFunDanmu.Im.Message.ChatTarget();
        }
        ChatTarget.MergeFrom(other.ChatTarget);
      }
      if (other.from_ != null) {
        if (from_ == null) {
          From = new global::AcFunDanmu.Im.Basic.User();
        }
        From.MergeFrom(other.From);
      }
      msgType_.Add(other.msgType_);
      fileName_.Add(other.fileName_);
      query_.Add(other.query_);
      if (other.Offset.Length != 0) {
        Offset = other.Offset;
      }
      if (other.timeFilter_ != null) {
        if (timeFilter_ == null) {
          TimeFilter = new global::AcFunDanmu.Im.Cloud.Search.TimeFilter();
        }
        TimeFilter.MergeFrom(other.TimeFilter);
      }
      if (other.MsgCountPerSession != 0) {
        MsgCountPerSession = other.MsgCountPerSession;
      }
      messageType_.Add(other.messageType_);
      if (other.SearchAfterOffset != false) {
        SearchAfterOffset = other.SearchAfterOffset;
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
            if (from_ == null) {
              From = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(From);
            break;
          }
          case 26:
          case 24: {
            msgType_.AddEntriesFrom(input, _repeated_msgType_codec);
            break;
          }
          case 34: {
            fileName_.AddEntriesFrom(input, _repeated_fileName_codec);
            break;
          }
          case 42: {
            query_.AddEntriesFrom(input, _repeated_query_codec);
            break;
          }
          case 50: {
            Offset = input.ReadString();
            break;
          }
          case 58: {
            if (timeFilter_ == null) {
              TimeFilter = new global::AcFunDanmu.Im.Cloud.Search.TimeFilter();
            }
            input.ReadMessage(TimeFilter);
            break;
          }
          case 64: {
            MsgCountPerSession = input.ReadInt32();
            break;
          }
          case 74:
          case 72: {
            messageType_.AddEntriesFrom(input, _repeated_messageType_codec);
            break;
          }
          case 80: {
            SearchAfterOffset = input.ReadBool();
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
            if (from_ == null) {
              From = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(From);
            break;
          }
          case 26:
          case 24: {
            msgType_.AddEntriesFrom(ref input, _repeated_msgType_codec);
            break;
          }
          case 34: {
            fileName_.AddEntriesFrom(ref input, _repeated_fileName_codec);
            break;
          }
          case 42: {
            query_.AddEntriesFrom(ref input, _repeated_query_codec);
            break;
          }
          case 50: {
            Offset = input.ReadString();
            break;
          }
          case 58: {
            if (timeFilter_ == null) {
              TimeFilter = new global::AcFunDanmu.Im.Cloud.Search.TimeFilter();
            }
            input.ReadMessage(TimeFilter);
            break;
          }
          case 64: {
            MsgCountPerSession = input.ReadInt32();
            break;
          }
          case 74:
          case 72: {
            messageType_.AddEntriesFrom(ref input, _repeated_messageType_codec);
            break;
          }
          case 80: {
            SearchAfterOffset = input.ReadBool();
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
