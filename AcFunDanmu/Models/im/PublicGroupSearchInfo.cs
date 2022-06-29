// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PublicGroupSearchInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Search {

  /// <summary>Holder for reflection information generated from PublicGroupSearchInfo.proto</summary>
  public static partial class PublicGroupSearchInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PublicGroupSearchInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PublicGroupSearchInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQdWJsaWNHcm91cFNlYXJjaEluZm8ucHJvdG8SGkFjRnVuRGFubXUuSW0u",
            "Q2xvdWQuU2VhcmNoGhRHcm91cEJhc2ljSW5mby5wcm90bxoVR3JvdXBKb2lu",
            "U3RhdHVzLnByb3RvGhRQdWJsaWNHcm91cEhpdC5wcm90byLYAQoVUHVibGlj",
            "R3JvdXBTZWFyY2hJbmZvEkMKDmdyb3VwQmFzaWNJbmZvGAEgASgLMisuQWNG",
            "dW5EYW5tdS5JbS5DbG91ZC5NZXNzYWdlLkdyb3VwQmFzaWNJbmZvEjwKBnN0",
            "YXR1cxgCIAEoDjIsLkFjRnVuRGFubXUuSW0uQ2xvdWQuTWVzc2FnZS5Hcm91",
            "cEpvaW5TdGF0dXMSPAoIZ3JvdXBIaXQYAyABKAsyKi5BY0Z1bkRhbm11Lklt",
            "LkNsb3VkLlNlYXJjaC5QdWJsaWNHcm91cEhpdGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Cloud.Message.GroupBasicInfoReflection.Descriptor, global::AcFunDanmu.Im.Cloud.Message.GroupJoinStatusReflection.Descriptor, global::AcFunDanmu.Im.Cloud.Search.PublicGroupHitReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Search.PublicGroupSearchInfo), global::AcFunDanmu.Im.Cloud.Search.PublicGroupSearchInfo.Parser, new[]{ "GroupBasicInfo", "Status", "GroupHit" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PublicGroupSearchInfo : pb::IMessage<PublicGroupSearchInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PublicGroupSearchInfo> _parser = new pb::MessageParser<PublicGroupSearchInfo>(() => new PublicGroupSearchInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PublicGroupSearchInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Search.PublicGroupSearchInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PublicGroupSearchInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PublicGroupSearchInfo(PublicGroupSearchInfo other) : this() {
      groupBasicInfo_ = other.groupBasicInfo_ != null ? other.groupBasicInfo_.Clone() : null;
      status_ = other.status_;
      groupHit_ = other.groupHit_ != null ? other.groupHit_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PublicGroupSearchInfo Clone() {
      return new PublicGroupSearchInfo(this);
    }

    /// <summary>Field number for the "groupBasicInfo" field.</summary>
    public const int GroupBasicInfoFieldNumber = 1;
    private global::AcFunDanmu.Im.Cloud.Message.GroupBasicInfo groupBasicInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.GroupBasicInfo GroupBasicInfo {
      get { return groupBasicInfo_; }
      set {
        groupBasicInfo_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::AcFunDanmu.Im.Cloud.Message.GroupJoinStatus status_ = global::AcFunDanmu.Im.Cloud.Message.GroupJoinStatus.InviteStatus;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.GroupJoinStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "groupHit" field.</summary>
    public const int GroupHitFieldNumber = 3;
    private global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit groupHit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit GroupHit {
      get { return groupHit_; }
      set {
        groupHit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PublicGroupSearchInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PublicGroupSearchInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GroupBasicInfo, other.GroupBasicInfo)) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(GroupHit, other.GroupHit)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (groupBasicInfo_ != null) hash ^= GroupBasicInfo.GetHashCode();
      if (Status != global::AcFunDanmu.Im.Cloud.Message.GroupJoinStatus.InviteStatus) hash ^= Status.GetHashCode();
      if (groupHit_ != null) hash ^= GroupHit.GetHashCode();
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
      if (groupBasicInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(GroupBasicInfo);
      }
      if (Status != global::AcFunDanmu.Im.Cloud.Message.GroupJoinStatus.InviteStatus) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (groupHit_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GroupHit);
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
      if (groupBasicInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(GroupBasicInfo);
      }
      if (Status != global::AcFunDanmu.Im.Cloud.Message.GroupJoinStatus.InviteStatus) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (groupHit_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GroupHit);
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
      if (groupBasicInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GroupBasicInfo);
      }
      if (Status != global::AcFunDanmu.Im.Cloud.Message.GroupJoinStatus.InviteStatus) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (groupHit_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GroupHit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PublicGroupSearchInfo other) {
      if (other == null) {
        return;
      }
      if (other.groupBasicInfo_ != null) {
        if (groupBasicInfo_ == null) {
          GroupBasicInfo = new global::AcFunDanmu.Im.Cloud.Message.GroupBasicInfo();
        }
        GroupBasicInfo.MergeFrom(other.GroupBasicInfo);
      }
      if (other.Status != global::AcFunDanmu.Im.Cloud.Message.GroupJoinStatus.InviteStatus) {
        Status = other.Status;
      }
      if (other.groupHit_ != null) {
        if (groupHit_ == null) {
          GroupHit = new global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit();
        }
        GroupHit.MergeFrom(other.GroupHit);
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
            if (groupBasicInfo_ == null) {
              GroupBasicInfo = new global::AcFunDanmu.Im.Cloud.Message.GroupBasicInfo();
            }
            input.ReadMessage(GroupBasicInfo);
            break;
          }
          case 16: {
            Status = (global::AcFunDanmu.Im.Cloud.Message.GroupJoinStatus) input.ReadEnum();
            break;
          }
          case 26: {
            if (groupHit_ == null) {
              GroupHit = new global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit();
            }
            input.ReadMessage(GroupHit);
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
            if (groupBasicInfo_ == null) {
              GroupBasicInfo = new global::AcFunDanmu.Im.Cloud.Message.GroupBasicInfo();
            }
            input.ReadMessage(GroupBasicInfo);
            break;
          }
          case 16: {
            Status = (global::AcFunDanmu.Im.Cloud.Message.GroupJoinStatus) input.ReadEnum();
            break;
          }
          case 26: {
            if (groupHit_ == null) {
              GroupHit = new global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit();
            }
            input.ReadMessage(GroupHit);
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
