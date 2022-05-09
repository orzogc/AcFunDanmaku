// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GroupJoinRequestGetResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from GroupJoinRequestGetResponse.proto</summary>
  public static partial class GroupJoinRequestGetResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for GroupJoinRequestGetResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupJoinRequestGetResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFHcm91cEpvaW5SZXF1ZXN0R2V0UmVzcG9uc2UucHJvdG8SG0FjRnVuRGFu",
            "bXUuSW0uQ2xvdWQuTWVzc2FnZRoRR3JvdXBNZW1iZXIucHJvdG8aF0pvaW5S",
            "ZXF1ZXN0U3RhdHVzLnByb3RvGgpVc2VyLnByb3RvIsMCChtHcm91cEpvaW5S",
            "ZXF1ZXN0R2V0UmVzcG9uc2USDwoHZ3JvdXBJZBgBIAEoCRIqCgdpbnZpdGVy",
            "GAIgASgLMhkuQWNGdW5EYW5tdS5JbS5CYXNpYy5Vc2VyEisKCGludml0ZWVz",
            "GAMgAygLMhkuQWNGdW5EYW5tdS5JbS5CYXNpYy5Vc2VyEg8KB2ZpbmRXYXkY",
            "BCABKAUSEwoLZGVzY0NvbnRlbnQYBSABKAkSPgoGc3RhdHVzGAYgASgOMi4u",
            "QWNGdW5EYW5tdS5JbS5DbG91ZC5NZXNzYWdlLkpvaW5SZXF1ZXN0U3RhdHVz",
            "ElQKEmludml0ZWVNZW1iZXJzUm9sZRgHIAEoDjI4LkFjRnVuRGFubXUuSW0u",
            "Q2xvdWQuTWVzc2FnZS5Hcm91cE1lbWJlci5Hcm91cE1lbWJlclJvbGViBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Cloud.Message.GroupMemberReflection.Descriptor, global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatusReflection.Descriptor, global::AcFunDanmu.Im.Basic.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.GroupJoinRequestGetResponse), global::AcFunDanmu.Im.Cloud.Message.GroupJoinRequestGetResponse.Parser, new[]{ "GroupId", "Inviter", "Invitees", "FindWay", "DescContent", "Status", "InviteeMembersRole" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GroupJoinRequestGetResponse : pb::IMessage<GroupJoinRequestGetResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GroupJoinRequestGetResponse> _parser = new pb::MessageParser<GroupJoinRequestGetResponse>(() => new GroupJoinRequestGetResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GroupJoinRequestGetResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Message.GroupJoinRequestGetResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupJoinRequestGetResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupJoinRequestGetResponse(GroupJoinRequestGetResponse other) : this() {
      groupId_ = other.groupId_;
      inviter_ = other.inviter_ != null ? other.inviter_.Clone() : null;
      invitees_ = other.invitees_.Clone();
      findWay_ = other.findWay_;
      descContent_ = other.descContent_;
      status_ = other.status_;
      inviteeMembersRole_ = other.inviteeMembersRole_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupJoinRequestGetResponse Clone() {
      return new GroupJoinRequestGetResponse(this);
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

    /// <summary>Field number for the "inviter" field.</summary>
    public const int InviterFieldNumber = 2;
    private global::AcFunDanmu.Im.Basic.User inviter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.User Inviter {
      get { return inviter_; }
      set {
        inviter_ = value;
      }
    }

    /// <summary>Field number for the "invitees" field.</summary>
    public const int InviteesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Basic.User> _repeated_invitees_codec
        = pb::FieldCodec.ForMessage(26, global::AcFunDanmu.Im.Basic.User.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User> invitees_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User> Invitees {
      get { return invitees_; }
    }

    /// <summary>Field number for the "findWay" field.</summary>
    public const int FindWayFieldNumber = 4;
    private int findWay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int FindWay {
      get { return findWay_; }
      set {
        findWay_ = value;
      }
    }

    /// <summary>Field number for the "descContent" field.</summary>
    public const int DescContentFieldNumber = 5;
    private string descContent_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DescContent {
      get { return descContent_; }
      set {
        descContent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus status_ = global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "inviteeMembersRole" field.</summary>
    public const int InviteeMembersRoleFieldNumber = 7;
    private global::AcFunDanmu.Im.Cloud.Message.GroupMember.Types.GroupMemberRole inviteeMembersRole_ = global::AcFunDanmu.Im.Cloud.Message.GroupMember.Types.GroupMemberRole.UnknownRole;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.GroupMember.Types.GroupMemberRole InviteeMembersRole {
      get { return inviteeMembersRole_; }
      set {
        inviteeMembersRole_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GroupJoinRequestGetResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GroupJoinRequestGetResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupId != other.GroupId) return false;
      if (!object.Equals(Inviter, other.Inviter)) return false;
      if(!invitees_.Equals(other.invitees_)) return false;
      if (FindWay != other.FindWay) return false;
      if (DescContent != other.DescContent) return false;
      if (Status != other.Status) return false;
      if (InviteeMembersRole != other.InviteeMembersRole) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupId.Length != 0) hash ^= GroupId.GetHashCode();
      if (inviter_ != null) hash ^= Inviter.GetHashCode();
      hash ^= invitees_.GetHashCode();
      if (FindWay != 0) hash ^= FindWay.GetHashCode();
      if (DescContent.Length != 0) hash ^= DescContent.GetHashCode();
      if (Status != global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus) hash ^= Status.GetHashCode();
      if (InviteeMembersRole != global::AcFunDanmu.Im.Cloud.Message.GroupMember.Types.GroupMemberRole.UnknownRole) hash ^= InviteeMembersRole.GetHashCode();
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
      if (inviter_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Inviter);
      }
      invitees_.WriteTo(output, _repeated_invitees_codec);
      if (FindWay != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(FindWay);
      }
      if (DescContent.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DescContent);
      }
      if (Status != global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (InviteeMembersRole != global::AcFunDanmu.Im.Cloud.Message.GroupMember.Types.GroupMemberRole.UnknownRole) {
        output.WriteRawTag(56);
        output.WriteEnum((int) InviteeMembersRole);
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
      if (inviter_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Inviter);
      }
      invitees_.WriteTo(ref output, _repeated_invitees_codec);
      if (FindWay != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(FindWay);
      }
      if (DescContent.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DescContent);
      }
      if (Status != global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (InviteeMembersRole != global::AcFunDanmu.Im.Cloud.Message.GroupMember.Types.GroupMemberRole.UnknownRole) {
        output.WriteRawTag(56);
        output.WriteEnum((int) InviteeMembersRole);
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
      if (inviter_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Inviter);
      }
      size += invitees_.CalculateSize(_repeated_invitees_codec);
      if (FindWay != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FindWay);
      }
      if (DescContent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DescContent);
      }
      if (Status != global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (InviteeMembersRole != global::AcFunDanmu.Im.Cloud.Message.GroupMember.Types.GroupMemberRole.UnknownRole) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) InviteeMembersRole);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GroupJoinRequestGetResponse other) {
      if (other == null) {
        return;
      }
      if (other.GroupId.Length != 0) {
        GroupId = other.GroupId;
      }
      if (other.inviter_ != null) {
        if (inviter_ == null) {
          Inviter = new global::AcFunDanmu.Im.Basic.User();
        }
        Inviter.MergeFrom(other.Inviter);
      }
      invitees_.Add(other.invitees_);
      if (other.FindWay != 0) {
        FindWay = other.FindWay;
      }
      if (other.DescContent.Length != 0) {
        DescContent = other.DescContent;
      }
      if (other.Status != global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus) {
        Status = other.Status;
      }
      if (other.InviteeMembersRole != global::AcFunDanmu.Im.Cloud.Message.GroupMember.Types.GroupMemberRole.UnknownRole) {
        InviteeMembersRole = other.InviteeMembersRole;
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
            if (inviter_ == null) {
              Inviter = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(Inviter);
            break;
          }
          case 26: {
            invitees_.AddEntriesFrom(input, _repeated_invitees_codec);
            break;
          }
          case 32: {
            FindWay = input.ReadInt32();
            break;
          }
          case 42: {
            DescContent = input.ReadString();
            break;
          }
          case 48: {
            Status = (global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus) input.ReadEnum();
            break;
          }
          case 56: {
            InviteeMembersRole = (global::AcFunDanmu.Im.Cloud.Message.GroupMember.Types.GroupMemberRole) input.ReadEnum();
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
            if (inviter_ == null) {
              Inviter = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(Inviter);
            break;
          }
          case 26: {
            invitees_.AddEntriesFrom(ref input, _repeated_invitees_codec);
            break;
          }
          case 32: {
            FindWay = input.ReadInt32();
            break;
          }
          case 42: {
            DescContent = input.ReadString();
            break;
          }
          case 48: {
            Status = (global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus) input.ReadEnum();
            break;
          }
          case 56: {
            InviteeMembersRole = (global::AcFunDanmu.Im.Cloud.Message.GroupMember.Types.GroupMemberRole) input.ReadEnum();
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