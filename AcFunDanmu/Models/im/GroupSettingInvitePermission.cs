// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GroupSettingInvitePermission.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from GroupSettingInvitePermission.proto</summary>
  public static partial class GroupSettingInvitePermissionReflection {

    #region Descriptor
    /// <summary>File descriptor for GroupSettingInvitePermission.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupSettingInvitePermissionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJHcm91cFNldHRpbmdJbnZpdGVQZXJtaXNzaW9uLnByb3RvEhtBY0Z1bkRh",
            "bm11LkltLkNsb3VkLk1lc3NhZ2UaGkludml0ZVBlcm1pc3Npb25UeXBlLnBy",
            "b3RvIm8KHEdyb3VwU2V0dGluZ0ludml0ZVBlcm1pc3Npb24STwoUaW52aXRl",
            "UGVybWlzc2lvblR5cGUYASABKA4yMS5BY0Z1bkRhbm11LkltLkNsb3VkLk1l",
            "c3NhZ2UuSW52aXRlUGVybWlzc2lvblR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Cloud.Message.InvitePermissionTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.GroupSettingInvitePermission), global::AcFunDanmu.Im.Cloud.Message.GroupSettingInvitePermission.Parser, new[]{ "InvitePermissionType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GroupSettingInvitePermission : pb::IMessage<GroupSettingInvitePermission>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GroupSettingInvitePermission> _parser = new pb::MessageParser<GroupSettingInvitePermission>(() => new GroupSettingInvitePermission());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GroupSettingInvitePermission> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Message.GroupSettingInvitePermissionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupSettingInvitePermission() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupSettingInvitePermission(GroupSettingInvitePermission other) : this() {
      invitePermissionType_ = other.invitePermissionType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupSettingInvitePermission Clone() {
      return new GroupSettingInvitePermission(this);
    }

    /// <summary>Field number for the "invitePermissionType" field.</summary>
    public const int InvitePermissionTypeFieldNumber = 1;
    private global::AcFunDanmu.Im.Cloud.Message.InvitePermissionType invitePermissionType_ = global::AcFunDanmu.Im.Cloud.Message.InvitePermissionType.UnknownInvitePermissionType;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.InvitePermissionType InvitePermissionType {
      get { return invitePermissionType_; }
      set {
        invitePermissionType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GroupSettingInvitePermission);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GroupSettingInvitePermission other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InvitePermissionType != other.InvitePermissionType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (InvitePermissionType != global::AcFunDanmu.Im.Cloud.Message.InvitePermissionType.UnknownInvitePermissionType) hash ^= InvitePermissionType.GetHashCode();
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
      if (InvitePermissionType != global::AcFunDanmu.Im.Cloud.Message.InvitePermissionType.UnknownInvitePermissionType) {
        output.WriteRawTag(8);
        output.WriteEnum((int) InvitePermissionType);
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
      if (InvitePermissionType != global::AcFunDanmu.Im.Cloud.Message.InvitePermissionType.UnknownInvitePermissionType) {
        output.WriteRawTag(8);
        output.WriteEnum((int) InvitePermissionType);
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
      if (InvitePermissionType != global::AcFunDanmu.Im.Cloud.Message.InvitePermissionType.UnknownInvitePermissionType) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) InvitePermissionType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GroupSettingInvitePermission other) {
      if (other == null) {
        return;
      }
      if (other.InvitePermissionType != global::AcFunDanmu.Im.Cloud.Message.InvitePermissionType.UnknownInvitePermissionType) {
        InvitePermissionType = other.InvitePermissionType;
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
            InvitePermissionType = (global::AcFunDanmu.Im.Cloud.Message.InvitePermissionType) input.ReadEnum();
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
            InvitePermissionType = (global::AcFunDanmu.Im.Cloud.Message.InvitePermissionType) input.ReadEnum();
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
