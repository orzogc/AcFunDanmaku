// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GroupInviteRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from GroupInviteRequest.proto</summary>
  public static partial class GroupInviteRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for GroupInviteRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupInviteRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhHcm91cEludml0ZVJlcXVlc3QucHJvdG8SG0FjRnVuRGFubXUuSW0uQ2xv",
            "dWQuTWVzc2FnZRoKVXNlci5wcm90byKGAQoSR3JvdXBJbnZpdGVSZXF1ZXN0",
            "Eg8KB2dyb3VwSWQYASABKAkSKgoHbWVtYmVycxgCIAMoCzIZLkFjRnVuRGFu",
            "bXUuSW0uQmFzaWMuVXNlchITCgtkZXNjQ29udGVudBgDIAEoCRIeChZoaXN0",
            "b3J5TWVzc2FnZXNWaXNpYmxlGAQgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Basic.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.GroupInviteRequest), global::AcFunDanmu.Im.Cloud.Message.GroupInviteRequest.Parser, new[]{ "GroupId", "Members", "DescContent", "HistoryMessagesVisible" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GroupInviteRequest : pb::IMessage<GroupInviteRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GroupInviteRequest> _parser = new pb::MessageParser<GroupInviteRequest>(() => new GroupInviteRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GroupInviteRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Message.GroupInviteRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupInviteRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupInviteRequest(GroupInviteRequest other) : this() {
      groupId_ = other.groupId_;
      members_ = other.members_.Clone();
      descContent_ = other.descContent_;
      historyMessagesVisible_ = other.historyMessagesVisible_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupInviteRequest Clone() {
      return new GroupInviteRequest(this);
    }

    /// <summary>Field number for the "groupId" field.</summary>
    public const int GroupIdFieldNumber = 1;
    private string groupId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GroupId {
      get { return groupId_; }
      set {
        groupId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "members" field.</summary>
    public const int MembersFieldNumber = 2;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Basic.User> _repeated_members_codec
        = pb::FieldCodec.ForMessage(18, global::AcFunDanmu.Im.Basic.User.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User> members_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User> Members {
      get { return members_; }
    }

    /// <summary>Field number for the "descContent" field.</summary>
    public const int DescContentFieldNumber = 3;
    private string descContent_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DescContent {
      get { return descContent_; }
      set {
        descContent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "historyMessagesVisible" field.</summary>
    public const int HistoryMessagesVisibleFieldNumber = 4;
    private bool historyMessagesVisible_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HistoryMessagesVisible {
      get { return historyMessagesVisible_; }
      set {
        historyMessagesVisible_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GroupInviteRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GroupInviteRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupId != other.GroupId) return false;
      if(!members_.Equals(other.members_)) return false;
      if (DescContent != other.DescContent) return false;
      if (HistoryMessagesVisible != other.HistoryMessagesVisible) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupId.Length != 0) hash ^= GroupId.GetHashCode();
      hash ^= members_.GetHashCode();
      if (DescContent.Length != 0) hash ^= DescContent.GetHashCode();
      if (HistoryMessagesVisible != false) hash ^= HistoryMessagesVisible.GetHashCode();
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
      if (GroupId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GroupId);
      }
      members_.WriteTo(output, _repeated_members_codec);
      if (DescContent.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DescContent);
      }
      if (HistoryMessagesVisible != false) {
        output.WriteRawTag(32);
        output.WriteBool(HistoryMessagesVisible);
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
      if (GroupId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GroupId);
      }
      members_.WriteTo(ref output, _repeated_members_codec);
      if (DescContent.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DescContent);
      }
      if (HistoryMessagesVisible != false) {
        output.WriteRawTag(32);
        output.WriteBool(HistoryMessagesVisible);
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
      if (GroupId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GroupId);
      }
      size += members_.CalculateSize(_repeated_members_codec);
      if (DescContent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DescContent);
      }
      if (HistoryMessagesVisible != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GroupInviteRequest other) {
      if (other == null) {
        return;
      }
      if (other.GroupId.Length != 0) {
        GroupId = other.GroupId;
      }
      members_.Add(other.members_);
      if (other.DescContent.Length != 0) {
        DescContent = other.DescContent;
      }
      if (other.HistoryMessagesVisible != false) {
        HistoryMessagesVisible = other.HistoryMessagesVisible;
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
            GroupId = input.ReadString();
            break;
          }
          case 18: {
            members_.AddEntriesFrom(input, _repeated_members_codec);
            break;
          }
          case 26: {
            DescContent = input.ReadString();
            break;
          }
          case 32: {
            HistoryMessagesVisible = input.ReadBool();
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
            GroupId = input.ReadString();
            break;
          }
          case 18: {
            members_.AddEntriesFrom(ref input, _repeated_members_codec);
            break;
          }
          case 26: {
            DescContent = input.ReadString();
            break;
          }
          case 32: {
            HistoryMessagesVisible = input.ReadBool();
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