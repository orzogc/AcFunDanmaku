// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SessionFolderDeleteRefRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.SessionFolder {

  /// <summary>Holder for reflection information generated from SessionFolderDeleteRefRequest.proto</summary>
  public static partial class SessionFolderDeleteRefRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for SessionFolderDeleteRefRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionFolderDeleteRefRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNTZXNzaW9uRm9sZGVyRGVsZXRlUmVmUmVxdWVzdC5wcm90bxIhQWNGdW5E",
            "YW5tdS5JbS5DbG91ZC5TZXNzaW9uRm9sZGVyGhZTZXNzaW9uUmVmZXJlbmNl",
            "LnByb3RvIo0BCh1TZXNzaW9uRm9sZGVyRGVsZXRlUmVmUmVxdWVzdBJNChBz",
            "ZXNzaW9uUmVmZXJlbmNlGAEgAygLMjMuQWNGdW5EYW5tdS5JbS5DbG91ZC5T",
            "ZXNzaW9uRm9sZGVyLlNlc3Npb25SZWZlcmVuY2USHQoVdGFyZ2V0U2Vzc2lv",
            "bkZvbGRlcklkGAIgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReferenceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.SessionFolder.SessionFolderDeleteRefRequest), global::AcFunDanmu.Im.Cloud.SessionFolder.SessionFolderDeleteRefRequest.Parser, new[]{ "SessionReference", "TargetSessionFolderId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SessionFolderDeleteRefRequest : pb::IMessage<SessionFolderDeleteRefRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SessionFolderDeleteRefRequest> _parser = new pb::MessageParser<SessionFolderDeleteRefRequest>(() => new SessionFolderDeleteRefRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SessionFolderDeleteRefRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.SessionFolder.SessionFolderDeleteRefRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionFolderDeleteRefRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionFolderDeleteRefRequest(SessionFolderDeleteRefRequest other) : this() {
      sessionReference_ = other.sessionReference_.Clone();
      targetSessionFolderId_ = other.targetSessionFolderId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionFolderDeleteRefRequest Clone() {
      return new SessionFolderDeleteRefRequest(this);
    }

    /// <summary>Field number for the "sessionReference" field.</summary>
    public const int SessionReferenceFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReference> _repeated_sessionReference_codec
        = pb::FieldCodec.ForMessage(10, global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReference.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReference> sessionReference_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReference>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReference> SessionReference {
      get { return sessionReference_; }
    }

    /// <summary>Field number for the "targetSessionFolderId" field.</summary>
    public const int TargetSessionFolderIdFieldNumber = 2;
    private string targetSessionFolderId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TargetSessionFolderId {
      get { return targetSessionFolderId_; }
      set {
        targetSessionFolderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SessionFolderDeleteRefRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SessionFolderDeleteRefRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sessionReference_.Equals(other.sessionReference_)) return false;
      if (TargetSessionFolderId != other.TargetSessionFolderId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sessionReference_.GetHashCode();
      if (TargetSessionFolderId.Length != 0) hash ^= TargetSessionFolderId.GetHashCode();
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
      sessionReference_.WriteTo(output, _repeated_sessionReference_codec);
      if (TargetSessionFolderId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TargetSessionFolderId);
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
      sessionReference_.WriteTo(ref output, _repeated_sessionReference_codec);
      if (TargetSessionFolderId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TargetSessionFolderId);
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
      size += sessionReference_.CalculateSize(_repeated_sessionReference_codec);
      if (TargetSessionFolderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetSessionFolderId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SessionFolderDeleteRefRequest other) {
      if (other == null) {
        return;
      }
      sessionReference_.Add(other.sessionReference_);
      if (other.TargetSessionFolderId.Length != 0) {
        TargetSessionFolderId = other.TargetSessionFolderId;
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
            sessionReference_.AddEntriesFrom(input, _repeated_sessionReference_codec);
            break;
          }
          case 18: {
            TargetSessionFolderId = input.ReadString();
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
            sessionReference_.AddEntriesFrom(ref input, _repeated_sessionReference_codec);
            break;
          }
          case 18: {
            TargetSessionFolderId = input.ReadString();
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
