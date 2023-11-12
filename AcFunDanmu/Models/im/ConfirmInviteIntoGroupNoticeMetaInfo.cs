// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ConfirmInviteIntoGroupNoticeMetaInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from ConfirmInviteIntoGroupNoticeMetaInfo.proto</summary>
  public static partial class ConfirmInviteIntoGroupNoticeMetaInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ConfirmInviteIntoGroupNoticeMetaInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfirmInviteIntoGroupNoticeMetaInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipDb25maXJtSW52aXRlSW50b0dyb3VwTm90aWNlTWV0YUluZm8ucHJvdG8S",
            "G0FjRnVuRGFubXUuSW0uQ2xvdWQuTWVzc2FnZRoXSm9pblJlcXVlc3RTdGF0",
            "dXMucHJvdG8iigEKJENvbmZpcm1JbnZpdGVJbnRvR3JvdXBOb3RpY2VNZXRh",
            "SW5mbxIRCglyZXF1ZXN0SWQYASABKAMSDwoHZ3JvdXBJZBgCIAEoCRI+CgZz",
            "dGF0dXMYAyABKA4yLi5BY0Z1bkRhbm11LkltLkNsb3VkLk1lc3NhZ2UuSm9p",
            "blJlcXVlc3RTdGF0dXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.ConfirmInviteIntoGroupNoticeMetaInfo), global::AcFunDanmu.Im.Cloud.Message.ConfirmInviteIntoGroupNoticeMetaInfo.Parser, new[]{ "RequestId", "GroupId", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ConfirmInviteIntoGroupNoticeMetaInfo : pb::IMessage<ConfirmInviteIntoGroupNoticeMetaInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConfirmInviteIntoGroupNoticeMetaInfo> _parser = new pb::MessageParser<ConfirmInviteIntoGroupNoticeMetaInfo>(() => new ConfirmInviteIntoGroupNoticeMetaInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConfirmInviteIntoGroupNoticeMetaInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Message.ConfirmInviteIntoGroupNoticeMetaInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfirmInviteIntoGroupNoticeMetaInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfirmInviteIntoGroupNoticeMetaInfo(ConfirmInviteIntoGroupNoticeMetaInfo other) : this() {
      requestId_ = other.requestId_;
      groupId_ = other.groupId_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfirmInviteIntoGroupNoticeMetaInfo Clone() {
      return new ConfirmInviteIntoGroupNoticeMetaInfo(this);
    }

    /// <summary>Field number for the "requestId" field.</summary>
    public const int RequestIdFieldNumber = 1;
    private long requestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long RequestId {
      get { return requestId_; }
      set {
        requestId_ = value;
      }
    }

    /// <summary>Field number for the "groupId" field.</summary>
    public const int GroupIdFieldNumber = 2;
    private string groupId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GroupId {
      get { return groupId_; }
      set {
        groupId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus status_ = global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConfirmInviteIntoGroupNoticeMetaInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConfirmInviteIntoGroupNoticeMetaInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RequestId != other.RequestId) return false;
      if (GroupId != other.GroupId) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RequestId != 0L) hash ^= RequestId.GetHashCode();
      if (GroupId.Length != 0) hash ^= GroupId.GetHashCode();
      if (Status != global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus) hash ^= Status.GetHashCode();
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
      if (RequestId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RequestId);
      }
      if (GroupId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(GroupId);
      }
      if (Status != global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
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
      if (RequestId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RequestId);
      }
      if (GroupId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(GroupId);
      }
      if (Status != global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
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
      if (RequestId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RequestId);
      }
      if (GroupId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GroupId);
      }
      if (Status != global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ConfirmInviteIntoGroupNoticeMetaInfo other) {
      if (other == null) {
        return;
      }
      if (other.RequestId != 0L) {
        RequestId = other.RequestId;
      }
      if (other.GroupId.Length != 0) {
        GroupId = other.GroupId;
      }
      if (other.Status != global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus.UnknownStatus) {
        Status = other.Status;
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
          case 8: {
            RequestId = input.ReadInt64();
            break;
          }
          case 18: {
            GroupId = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus) input.ReadEnum();
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
          case 8: {
            RequestId = input.ReadInt64();
            break;
          }
          case 18: {
            GroupId = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::AcFunDanmu.Im.Cloud.Message.JoinRequestStatus) input.ReadEnum();
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
