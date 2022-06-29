// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SessionReferenceUpdateItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.SessionFolder {

  /// <summary>Holder for reflection information generated from SessionReferenceUpdateItem.proto</summary>
  public static partial class SessionReferenceUpdateItemReflection {

    #region Descriptor
    /// <summary>File descriptor for SessionReferenceUpdateItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionReferenceUpdateItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBTZXNzaW9uUmVmZXJlbmNlVXBkYXRlSXRlbS5wcm90bxIhQWNGdW5EYW5t",
            "dS5JbS5DbG91ZC5TZXNzaW9uRm9sZGVyGhZTZXNzaW9uUmVmZXJlbmNlLnBy",
            "b3RvIoQBChpTZXNzaW9uUmVmZXJlbmNlVXBkYXRlSXRlbRJNChBzZXNzaW9u",
            "UmVmZXJlbmNlGAEgASgLMjMuQWNGdW5EYW5tdS5JbS5DbG91ZC5TZXNzaW9u",
            "Rm9sZGVyLlNlc3Npb25SZWZlcmVuY2USFwoPc2Vzc2lvbkZvbGRlcklkGAIg",
            "ASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReferenceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReferenceUpdateItem), global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReferenceUpdateItem.Parser, new[]{ "SessionReference", "SessionFolderId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SessionReferenceUpdateItem : pb::IMessage<SessionReferenceUpdateItem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SessionReferenceUpdateItem> _parser = new pb::MessageParser<SessionReferenceUpdateItem>(() => new SessionReferenceUpdateItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SessionReferenceUpdateItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReferenceUpdateItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionReferenceUpdateItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionReferenceUpdateItem(SessionReferenceUpdateItem other) : this() {
      sessionReference_ = other.sessionReference_ != null ? other.sessionReference_.Clone() : null;
      sessionFolderId_ = other.sessionFolderId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionReferenceUpdateItem Clone() {
      return new SessionReferenceUpdateItem(this);
    }

    /// <summary>Field number for the "sessionReference" field.</summary>
    public const int SessionReferenceFieldNumber = 1;
    private global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReference sessionReference_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReference SessionReference {
      get { return sessionReference_; }
      set {
        sessionReference_ = value;
      }
    }

    /// <summary>Field number for the "sessionFolderId" field.</summary>
    public const int SessionFolderIdFieldNumber = 2;
    private string sessionFolderId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SessionFolderId {
      get { return sessionFolderId_; }
      set {
        sessionFolderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SessionReferenceUpdateItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SessionReferenceUpdateItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SessionReference, other.SessionReference)) return false;
      if (SessionFolderId != other.SessionFolderId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (sessionReference_ != null) hash ^= SessionReference.GetHashCode();
      if (SessionFolderId.Length != 0) hash ^= SessionFolderId.GetHashCode();
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
      if (sessionReference_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SessionReference);
      }
      if (SessionFolderId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SessionFolderId);
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
      if (sessionReference_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SessionReference);
      }
      if (SessionFolderId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SessionFolderId);
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
      if (sessionReference_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SessionReference);
      }
      if (SessionFolderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SessionFolderId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SessionReferenceUpdateItem other) {
      if (other == null) {
        return;
      }
      if (other.sessionReference_ != null) {
        if (sessionReference_ == null) {
          SessionReference = new global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReference();
        }
        SessionReference.MergeFrom(other.SessionReference);
      }
      if (other.SessionFolderId.Length != 0) {
        SessionFolderId = other.SessionFolderId;
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
            if (sessionReference_ == null) {
              SessionReference = new global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReference();
            }
            input.ReadMessage(SessionReference);
            break;
          }
          case 18: {
            SessionFolderId = input.ReadString();
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
            if (sessionReference_ == null) {
              SessionReference = new global::AcFunDanmu.Im.Cloud.SessionFolder.SessionReference();
            }
            input.ReadMessage(SessionReference);
            break;
          }
          case 18: {
            SessionFolderId = input.ReadString();
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
