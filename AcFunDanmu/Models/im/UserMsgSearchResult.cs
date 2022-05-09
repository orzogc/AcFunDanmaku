// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UserMsgSearchResult.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Search {

  /// <summary>Holder for reflection information generated from UserMsgSearchResult.proto</summary>
  public static partial class UserMsgSearchResultReflection {

    #region Descriptor
    /// <summary>File descriptor for UserMsgSearchResult.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserMsgSearchResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVc2VyTXNnU2VhcmNoUmVzdWx0LnByb3RvEhpBY0Z1bkRhbm11LkltLkNs",
            "b3VkLlNlYXJjaBoNTWVzc2FnZS5wcm90bxoKVXNlci5wcm90byKfAQoTVXNl",
            "ck1zZ1NlYXJjaFJlc3VsdBIpCgZ0YXJnZXQYASABKAsyGS5BY0Z1bkRhbm11",
            "LkltLkJhc2ljLlVzZXISDwoHbXNnU2l6ZRgCIAEoBRIrCgNtc2cYAyADKAsy",
            "Hi5BY0Z1bkRhbm11LkltLk1lc3NhZ2UuTWVzc2FnZRIOCgZvZmZzZXQYBCAB",
            "KAkSDwoHaGFzTW9yZRgFIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Message.MessageReflection.Descriptor, global::AcFunDanmu.Im.Basic.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Search.UserMsgSearchResult), global::AcFunDanmu.Im.Cloud.Search.UserMsgSearchResult.Parser, new[]{ "Target", "MsgSize", "Msg", "Offset", "HasMore" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UserMsgSearchResult : pb::IMessage<UserMsgSearchResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserMsgSearchResult> _parser = new pb::MessageParser<UserMsgSearchResult>(() => new UserMsgSearchResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserMsgSearchResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Search.UserMsgSearchResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserMsgSearchResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserMsgSearchResult(UserMsgSearchResult other) : this() {
      target_ = other.target_ != null ? other.target_.Clone() : null;
      msgSize_ = other.msgSize_;
      msg_ = other.msg_.Clone();
      offset_ = other.offset_;
      hasMore_ = other.hasMore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserMsgSearchResult Clone() {
      return new UserMsgSearchResult(this);
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 1;
    private global::AcFunDanmu.Im.Basic.User target_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.User Target {
      get { return target_; }
      set {
        target_ = value;
      }
    }

    /// <summary>Field number for the "msgSize" field.</summary>
    public const int MsgSizeFieldNumber = 2;
    private int msgSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MsgSize {
      get { return msgSize_; }
      set {
        msgSize_ = value;
      }
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 3;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Message.Message> _repeated_msg_codec
        = pb::FieldCodec.ForMessage(26, global::AcFunDanmu.Im.Message.Message.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Message.Message> msg_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Message.Message>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Message.Message> Msg {
      get { return msg_; }
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 4;
    private string offset_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Offset {
      get { return offset_; }
      set {
        offset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hasMore" field.</summary>
    public const int HasMoreFieldNumber = 5;
    private bool hasMore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMore {
      get { return hasMore_; }
      set {
        hasMore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserMsgSearchResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserMsgSearchResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Target, other.Target)) return false;
      if (MsgSize != other.MsgSize) return false;
      if(!msg_.Equals(other.msg_)) return false;
      if (Offset != other.Offset) return false;
      if (HasMore != other.HasMore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (target_ != null) hash ^= Target.GetHashCode();
      if (MsgSize != 0) hash ^= MsgSize.GetHashCode();
      hash ^= msg_.GetHashCode();
      if (Offset.Length != 0) hash ^= Offset.GetHashCode();
      if (HasMore != false) hash ^= HasMore.GetHashCode();
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
      if (target_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Target);
      }
      if (MsgSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MsgSize);
      }
      msg_.WriteTo(output, _repeated_msg_codec);
      if (Offset.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Offset);
      }
      if (HasMore != false) {
        output.WriteRawTag(40);
        output.WriteBool(HasMore);
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
      if (target_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Target);
      }
      if (MsgSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MsgSize);
      }
      msg_.WriteTo(ref output, _repeated_msg_codec);
      if (Offset.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Offset);
      }
      if (HasMore != false) {
        output.WriteRawTag(40);
        output.WriteBool(HasMore);
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
      if (target_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Target);
      }
      if (MsgSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MsgSize);
      }
      size += msg_.CalculateSize(_repeated_msg_codec);
      if (Offset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Offset);
      }
      if (HasMore != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UserMsgSearchResult other) {
      if (other == null) {
        return;
      }
      if (other.target_ != null) {
        if (target_ == null) {
          Target = new global::AcFunDanmu.Im.Basic.User();
        }
        Target.MergeFrom(other.Target);
      }
      if (other.MsgSize != 0) {
        MsgSize = other.MsgSize;
      }
      msg_.Add(other.msg_);
      if (other.Offset.Length != 0) {
        Offset = other.Offset;
      }
      if (other.HasMore != false) {
        HasMore = other.HasMore;
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
            if (target_ == null) {
              Target = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(Target);
            break;
          }
          case 16: {
            MsgSize = input.ReadInt32();
            break;
          }
          case 26: {
            msg_.AddEntriesFrom(input, _repeated_msg_codec);
            break;
          }
          case 34: {
            Offset = input.ReadString();
            break;
          }
          case 40: {
            HasMore = input.ReadBool();
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
            if (target_ == null) {
              Target = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(Target);
            break;
          }
          case 16: {
            MsgSize = input.ReadInt32();
            break;
          }
          case 26: {
            msg_.AddEntriesFrom(ref input, _repeated_msg_codec);
            break;
          }
          case 34: {
            Offset = input.ReadString();
            break;
          }
          case 40: {
            HasMore = input.ReadBool();
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