// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GroupSettingJoinNeedPermission.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from GroupSettingJoinNeedPermission.proto</summary>
  public static partial class GroupSettingJoinNeedPermissionReflection {

    #region Descriptor
    /// <summary>File descriptor for GroupSettingJoinNeedPermission.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupSettingJoinNeedPermissionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRHcm91cFNldHRpbmdKb2luTmVlZFBlcm1pc3Npb24ucHJvdG8SG0FjRnVu",
            "RGFubXUuSW0uQ2xvdWQuTWVzc2FnZRocSm9pbk5lZWRQZXJtaXNzaW9uVHlw",
            "ZS5wcm90byJxCh5Hcm91cFNldHRpbmdKb2luTmVlZFBlcm1pc3Npb24STwoS",
            "am9pbk5lZWRQZXJtaXNzaW9uGAEgASgOMjMuQWNGdW5EYW5tdS5JbS5DbG91",
            "ZC5NZXNzYWdlLkpvaW5OZWVkUGVybWlzc2lvblR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Cloud.Message.JoinNeedPermissionTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.GroupSettingJoinNeedPermission), global::AcFunDanmu.Im.Cloud.Message.GroupSettingJoinNeedPermission.Parser, new[]{ "JoinNeedPermission" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GroupSettingJoinNeedPermission : pb::IMessage<GroupSettingJoinNeedPermission>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GroupSettingJoinNeedPermission> _parser = new pb::MessageParser<GroupSettingJoinNeedPermission>(() => new GroupSettingJoinNeedPermission());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GroupSettingJoinNeedPermission> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Message.GroupSettingJoinNeedPermissionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupSettingJoinNeedPermission() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupSettingJoinNeedPermission(GroupSettingJoinNeedPermission other) : this() {
      joinNeedPermission_ = other.joinNeedPermission_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupSettingJoinNeedPermission Clone() {
      return new GroupSettingJoinNeedPermission(this);
    }

    /// <summary>Field number for the "joinNeedPermission" field.</summary>
    public const int JoinNeedPermissionFieldNumber = 1;
    private global::AcFunDanmu.Im.Cloud.Message.JoinNeedPermissionType joinNeedPermission_ = global::AcFunDanmu.Im.Cloud.Message.JoinNeedPermissionType.UnknownJoinNeedPermissionType;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.JoinNeedPermissionType JoinNeedPermission {
      get { return joinNeedPermission_; }
      set {
        joinNeedPermission_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GroupSettingJoinNeedPermission);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GroupSettingJoinNeedPermission other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JoinNeedPermission != other.JoinNeedPermission) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JoinNeedPermission != global::AcFunDanmu.Im.Cloud.Message.JoinNeedPermissionType.UnknownJoinNeedPermissionType) hash ^= JoinNeedPermission.GetHashCode();
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
      if (JoinNeedPermission != global::AcFunDanmu.Im.Cloud.Message.JoinNeedPermissionType.UnknownJoinNeedPermissionType) {
        output.WriteRawTag(8);
        output.WriteEnum((int) JoinNeedPermission);
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
      if (JoinNeedPermission != global::AcFunDanmu.Im.Cloud.Message.JoinNeedPermissionType.UnknownJoinNeedPermissionType) {
        output.WriteRawTag(8);
        output.WriteEnum((int) JoinNeedPermission);
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
      if (JoinNeedPermission != global::AcFunDanmu.Im.Cloud.Message.JoinNeedPermissionType.UnknownJoinNeedPermissionType) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) JoinNeedPermission);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GroupSettingJoinNeedPermission other) {
      if (other == null) {
        return;
      }
      if (other.JoinNeedPermission != global::AcFunDanmu.Im.Cloud.Message.JoinNeedPermissionType.UnknownJoinNeedPermissionType) {
        JoinNeedPermission = other.JoinNeedPermission;
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
            JoinNeedPermission = (global::AcFunDanmu.Im.Cloud.Message.JoinNeedPermissionType) input.ReadEnum();
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
            JoinNeedPermission = (global::AcFunDanmu.Im.Cloud.Message.JoinNeedPermissionType) input.ReadEnum();
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
