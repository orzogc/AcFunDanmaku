// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ManagerSettingRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from ManagerSettingRequest.proto</summary>
  public static partial class ManagerSettingRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for ManagerSettingRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ManagerSettingRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtNYW5hZ2VyU2V0dGluZ1JlcXVlc3QucHJvdG8SG0FjRnVuRGFubXUuSW0u",
            "Q2xvdWQuTWVzc2FnZRoKVXNlci5wcm90byLbAQoVTWFuYWdlclNldHRpbmdS",
            "ZXF1ZXN0EioKB21hbmFnZXIYASADKAsyGS5BY0Z1bkRhbm11LkltLkJhc2lj",
            "LlVzZXISTwoJb3BlcmF0aW9uGAIgASgOMjwuQWNGdW5EYW5tdS5JbS5DbG91",
            "ZC5NZXNzYWdlLk1hbmFnZXJTZXR0aW5nUmVxdWVzdC5PcGVyYXRpb24SDwoH",
            "Z3JvdXBJZBgDIAEoCSI0CglPcGVyYXRpb24SFQoRVU5LTk9XTl9PUEVSQVRJ",
            "T04QABIHCgNBREQQARIHCgNERUwQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Basic.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest), global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Parser, new[]{ "Manager", "Operation", "GroupId" }, null, new[]{ typeof(global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Types.Operation) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ManagerSettingRequest : pb::IMessage<ManagerSettingRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ManagerSettingRequest> _parser = new pb::MessageParser<ManagerSettingRequest>(() => new ManagerSettingRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ManagerSettingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ManagerSettingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ManagerSettingRequest(ManagerSettingRequest other) : this() {
      manager_ = other.manager_.Clone();
      operation_ = other.operation_;
      groupId_ = other.groupId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ManagerSettingRequest Clone() {
      return new ManagerSettingRequest(this);
    }

    /// <summary>Field number for the "manager" field.</summary>
    public const int ManagerFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Basic.User> _repeated_manager_codec
        = pb::FieldCodec.ForMessage(10, global::AcFunDanmu.Im.Basic.User.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User> manager_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Basic.User> Manager {
      get { return manager_; }
    }

    /// <summary>Field number for the "operation" field.</summary>
    public const int OperationFieldNumber = 2;
    private global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Types.Operation operation_ = global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Types.Operation.UnknownOperation;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Types.Operation Operation {
      get { return operation_; }
      set {
        operation_ = value;
      }
    }

    /// <summary>Field number for the "groupId" field.</summary>
    public const int GroupIdFieldNumber = 3;
    private string groupId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GroupId {
      get { return groupId_; }
      set {
        groupId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ManagerSettingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ManagerSettingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!manager_.Equals(other.manager_)) return false;
      if (Operation != other.Operation) return false;
      if (GroupId != other.GroupId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= manager_.GetHashCode();
      if (Operation != global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Types.Operation.UnknownOperation) hash ^= Operation.GetHashCode();
      if (GroupId.Length != 0) hash ^= GroupId.GetHashCode();
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
      manager_.WriteTo(output, _repeated_manager_codec);
      if (Operation != global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Types.Operation.UnknownOperation) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Operation);
      }
      if (GroupId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GroupId);
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
      manager_.WriteTo(ref output, _repeated_manager_codec);
      if (Operation != global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Types.Operation.UnknownOperation) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Operation);
      }
      if (GroupId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(GroupId);
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
      size += manager_.CalculateSize(_repeated_manager_codec);
      if (Operation != global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Types.Operation.UnknownOperation) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Operation);
      }
      if (GroupId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GroupId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ManagerSettingRequest other) {
      if (other == null) {
        return;
      }
      manager_.Add(other.manager_);
      if (other.Operation != global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Types.Operation.UnknownOperation) {
        Operation = other.Operation;
      }
      if (other.GroupId.Length != 0) {
        GroupId = other.GroupId;
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
            manager_.AddEntriesFrom(input, _repeated_manager_codec);
            break;
          }
          case 16: {
            Operation = (global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Types.Operation) input.ReadEnum();
            break;
          }
          case 26: {
            GroupId = input.ReadString();
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
            manager_.AddEntriesFrom(ref input, _repeated_manager_codec);
            break;
          }
          case 16: {
            Operation = (global::AcFunDanmu.Im.Cloud.Message.ManagerSettingRequest.Types.Operation) input.ReadEnum();
            break;
          }
          case 26: {
            GroupId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ManagerSettingRequest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum Operation {
        [pbr::OriginalName("UNKNOWN_OPERATION")] UnknownOperation = 0,
        [pbr::OriginalName("ADD")] Add = 1,
        [pbr::OriginalName("DEL")] Del = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
