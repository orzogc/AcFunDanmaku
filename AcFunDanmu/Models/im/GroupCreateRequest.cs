// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GroupCreateRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from GroupCreateRequest.proto</summary>
  public static partial class GroupCreateRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for GroupCreateRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupCreateRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhHcm91cENyZWF0ZVJlcXVlc3QucHJvdG8SG0FjRnVuRGFubXUuSW0uQ2xv",
            "dWQuTWVzc2FnZRoQR3JvdXBMYWJlbC5wcm90bxoPR3JvdXBUeXBlLnByb3Rv",
            "Gg5Mb2NhdGlvbi5wcm90bxoKVXNlci5wcm90byLQAgoSR3JvdXBDcmVhdGVS",
            "ZXF1ZXN0EioKB21lbWJlcnMYASADKAsyGS5BY0Z1bkRhbm11LkltLkJhc2lj",
            "LlVzZXISEQoJZ3JvdXBOYW1lGAIgASgJEhQKDGdyb3VwSGVhZFVybBgDIAEo",
            "CRI3Cghsb2NhdGlvbhgEIAEoCzIlLkFjRnVuRGFubXUuSW0uQ2xvdWQuTWVz",
            "c2FnZS5Mb2NhdGlvbhILCgN0YWcYBSABKAkSOQoJZ3JvdXBUeXBlGAYgASgO",
            "MiYuQWNGdW5EYW5tdS5JbS5DbG91ZC5NZXNzYWdlLkdyb3VwVHlwZRIUCgxp",
            "bnRyb2R1Y3Rpb24YByABKAkSFgoOb3JpZ2luYWxUYXJnZXQYCCABKAkSNgoF",
            "bGFiZWwYCSADKAsyJy5BY0Z1bkRhbm11LkltLkNsb3VkLk1lc3NhZ2UuR3Jv",
            "dXBMYWJlbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Cloud.Message.GroupLabelReflection.Descriptor, global::AcFunDanmu.Im.Cloud.Message.GroupTypeReflection.Descriptor, global::AcFunDanmu.Im.Cloud.Message.LocationReflection.Descriptor, global::AcFunDanmu.Im.Basic.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.GroupCreateRequest), global::AcFunDanmu.Im.Cloud.Message.GroupCreateRequest.Parser, new[]{ "Members", "GroupName", "GroupHeadUrl", "Location", "Tag", "GroupType", "Introduction", "OriginalTarget", "Label" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GroupCreateRequest : pb::IMessage<GroupCreateRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GroupCreateRequest> _parser = new pb::MessageParser<GroupCreateRequest>(() => new GroupCreateRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GroupCreateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Message.GroupCreateRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupCreateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupCreateRequest(GroupCreateRequest other) : this() {
      members_ = other.members_.Clone();
      groupName_ = other.groupName_;
      groupHeadUrl_ = other.groupHeadUrl_;
      location_ = other.location_ != null ? other.location_.Clone() : null;
      tag_ = other.tag_;
      groupType_ = other.groupType_;
      introduction_ = other.introduction_;
      originalTarget_ = other.originalTarget_;
      label_ = other.label_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupCreateRequest Clone() {
      return new GroupCreateRequest(this);
    }

    /// <summary>Field number for the "members" field.</summary>
    public const int MembersFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Basic.User> _repeated_members_codec
        = pb::FieldCodec.ForMessage(10, global::AcFunDanmu.Im.Basic.User.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User> members_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User> Members {
      get { return members_; }
    }

    /// <summary>Field number for the "groupName" field.</summary>
    public const int GroupNameFieldNumber = 2;
    private string groupName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GroupName {
      get { return groupName_; }
      set {
        groupName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "groupHeadUrl" field.</summary>
    public const int GroupHeadUrlFieldNumber = 3;
    private string groupHeadUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GroupHeadUrl {
      get { return groupHeadUrl_; }
      set {
        groupHeadUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "location" field.</summary>
    public const int LocationFieldNumber = 4;
    private global::AcFunDanmu.Im.Cloud.Message.Location location_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.Location Location {
      get { return location_; }
      set {
        location_ = value;
      }
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 5;
    private string tag_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "groupType" field.</summary>
    public const int GroupTypeFieldNumber = 6;
    private global::AcFunDanmu.Im.Cloud.Message.GroupType groupType_ = global::AcFunDanmu.Im.Cloud.Message.GroupType.UnknowGroupType;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.GroupType GroupType {
      get { return groupType_; }
      set {
        groupType_ = value;
      }
    }

    /// <summary>Field number for the "introduction" field.</summary>
    public const int IntroductionFieldNumber = 7;
    private string introduction_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Introduction {
      get { return introduction_; }
      set {
        introduction_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "originalTarget" field.</summary>
    public const int OriginalTargetFieldNumber = 8;
    private string originalTarget_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OriginalTarget {
      get { return originalTarget_; }
      set {
        originalTarget_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 9;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Cloud.Message.GroupLabel> _repeated_label_codec
        = pb::FieldCodec.ForMessage(74, global::AcFunDanmu.Im.Cloud.Message.GroupLabel.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.GroupLabel> label_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.GroupLabel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.GroupLabel> Label {
      get { return label_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GroupCreateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GroupCreateRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!members_.Equals(other.members_)) return false;
      if (GroupName != other.GroupName) return false;
      if (GroupHeadUrl != other.GroupHeadUrl) return false;
      if (!object.Equals(Location, other.Location)) return false;
      if (Tag != other.Tag) return false;
      if (GroupType != other.GroupType) return false;
      if (Introduction != other.Introduction) return false;
      if (OriginalTarget != other.OriginalTarget) return false;
      if(!label_.Equals(other.label_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= members_.GetHashCode();
      if (GroupName.Length != 0) hash ^= GroupName.GetHashCode();
      if (GroupHeadUrl.Length != 0) hash ^= GroupHeadUrl.GetHashCode();
      if (location_ != null) hash ^= Location.GetHashCode();
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
      if (GroupType != global::AcFunDanmu.Im.Cloud.Message.GroupType.UnknowGroupType) hash ^= GroupType.GetHashCode();
      if (Introduction.Length != 0) hash ^= Introduction.GetHashCode();
      if (OriginalTarget.Length != 0) hash ^= OriginalTarget.GetHashCode();
      hash ^= label_.GetHashCode();
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
      members_.WriteTo(output, _repeated_members_codec);
      if (GroupName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(GroupName);
      }
      if (GroupHeadUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GroupHeadUrl);
      }
      if (location_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Location);
      }
      if (Tag.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Tag);
      }
      if (GroupType != global::AcFunDanmu.Im.Cloud.Message.GroupType.UnknowGroupType) {
        output.WriteRawTag(48);
        output.WriteEnum((int) GroupType);
      }
      if (Introduction.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Introduction);
      }
      if (OriginalTarget.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(OriginalTarget);
      }
      label_.WriteTo(output, _repeated_label_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      members_.WriteTo(ref output, _repeated_members_codec);
      if (GroupName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(GroupName);
      }
      if (GroupHeadUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GroupHeadUrl);
      }
      if (location_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Location);
      }
      if (Tag.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Tag);
      }
      if (GroupType != global::AcFunDanmu.Im.Cloud.Message.GroupType.UnknowGroupType) {
        output.WriteRawTag(48);
        output.WriteEnum((int) GroupType);
      }
      if (Introduction.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Introduction);
      }
      if (OriginalTarget.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(OriginalTarget);
      }
      label_.WriteTo(ref output, _repeated_label_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += members_.CalculateSize(_repeated_members_codec);
      if (GroupName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GroupName);
      }
      if (GroupHeadUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GroupHeadUrl);
      }
      if (location_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Location);
      }
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (GroupType != global::AcFunDanmu.Im.Cloud.Message.GroupType.UnknowGroupType) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GroupType);
      }
      if (Introduction.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Introduction);
      }
      if (OriginalTarget.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OriginalTarget);
      }
      size += label_.CalculateSize(_repeated_label_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GroupCreateRequest other) {
      if (other == null) {
        return;
      }
      members_.Add(other.members_);
      if (other.GroupName.Length != 0) {
        GroupName = other.GroupName;
      }
      if (other.GroupHeadUrl.Length != 0) {
        GroupHeadUrl = other.GroupHeadUrl;
      }
      if (other.location_ != null) {
        if (location_ == null) {
          Location = new global::AcFunDanmu.Im.Cloud.Message.Location();
        }
        Location.MergeFrom(other.Location);
      }
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
      }
      if (other.GroupType != global::AcFunDanmu.Im.Cloud.Message.GroupType.UnknowGroupType) {
        GroupType = other.GroupType;
      }
      if (other.Introduction.Length != 0) {
        Introduction = other.Introduction;
      }
      if (other.OriginalTarget.Length != 0) {
        OriginalTarget = other.OriginalTarget;
      }
      label_.Add(other.label_);
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
            members_.AddEntriesFrom(input, _repeated_members_codec);
            break;
          }
          case 18: {
            GroupName = input.ReadString();
            break;
          }
          case 26: {
            GroupHeadUrl = input.ReadString();
            break;
          }
          case 34: {
            if (location_ == null) {
              Location = new global::AcFunDanmu.Im.Cloud.Message.Location();
            }
            input.ReadMessage(Location);
            break;
          }
          case 42: {
            Tag = input.ReadString();
            break;
          }
          case 48: {
            GroupType = (global::AcFunDanmu.Im.Cloud.Message.GroupType) input.ReadEnum();
            break;
          }
          case 58: {
            Introduction = input.ReadString();
            break;
          }
          case 66: {
            OriginalTarget = input.ReadString();
            break;
          }
          case 74: {
            label_.AddEntriesFrom(input, _repeated_label_codec);
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
            members_.AddEntriesFrom(ref input, _repeated_members_codec);
            break;
          }
          case 18: {
            GroupName = input.ReadString();
            break;
          }
          case 26: {
            GroupHeadUrl = input.ReadString();
            break;
          }
          case 34: {
            if (location_ == null) {
              Location = new global::AcFunDanmu.Im.Cloud.Message.Location();
            }
            input.ReadMessage(Location);
            break;
          }
          case 42: {
            Tag = input.ReadString();
            break;
          }
          case 48: {
            GroupType = (global::AcFunDanmu.Im.Cloud.Message.GroupType) input.ReadEnum();
            break;
          }
          case 58: {
            Introduction = input.ReadString();
            break;
          }
          case 66: {
            OriginalTarget = input.ReadString();
            break;
          }
          case 74: {
            label_.AddEntriesFrom(ref input, _repeated_label_codec);
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