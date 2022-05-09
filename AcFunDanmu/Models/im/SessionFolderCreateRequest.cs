// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SessionFolderCreateRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.SessionFolder {

  /// <summary>Holder for reflection information generated from SessionFolderCreateRequest.proto</summary>
  public static partial class SessionFolderCreateRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for SessionFolderCreateRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionFolderCreateRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBTZXNzaW9uRm9sZGVyQ3JlYXRlUmVxdWVzdC5wcm90bxIhQWNGdW5EYW5t",
            "dS5JbS5DbG91ZC5TZXNzaW9uRm9sZGVyGhBDaGF0VGFyZ2V0LnByb3RvIoEB",
            "ChpTZXNzaW9uRm9sZGVyQ3JlYXRlUmVxdWVzdBIMCgRuYW1lGAEgASgJEg0K",
            "BWV4dHJhGAIgASgMEg8KB2ljb25VcmwYAyABKAkSNQoKY2hhdFRhcmdldBgE",
            "IAMoCzIhLkFjRnVuRGFubXUuSW0uTWVzc2FnZS5DaGF0VGFyZ2V0YgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Message.ChatTargetReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.SessionFolder.SessionFolderCreateRequest), global::AcFunDanmu.Im.Cloud.SessionFolder.SessionFolderCreateRequest.Parser, new[]{ "Name", "Extra", "IconUrl", "ChatTarget" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SessionFolderCreateRequest : pb::IMessage<SessionFolderCreateRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SessionFolderCreateRequest> _parser = new pb::MessageParser<SessionFolderCreateRequest>(() => new SessionFolderCreateRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SessionFolderCreateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.SessionFolder.SessionFolderCreateRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionFolderCreateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionFolderCreateRequest(SessionFolderCreateRequest other) : this() {
      name_ = other.name_;
      extra_ = other.extra_;
      iconUrl_ = other.iconUrl_;
      chatTarget_ = other.chatTarget_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionFolderCreateRequest Clone() {
      return new SessionFolderCreateRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "extra" field.</summary>
    public const int ExtraFieldNumber = 2;
    private pb::ByteString extra_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Extra {
      get { return extra_; }
      set {
        extra_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "iconUrl" field.</summary>
    public const int IconUrlFieldNumber = 3;
    private string iconUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IconUrl {
      get { return iconUrl_; }
      set {
        iconUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "chatTarget" field.</summary>
    public const int ChatTargetFieldNumber = 4;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Message.ChatTarget> _repeated_chatTarget_codec
        = pb::FieldCodec.ForMessage(34, global::AcFunDanmu.Im.Message.ChatTarget.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Message.ChatTarget> chatTarget_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Message.ChatTarget>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Message.ChatTarget> ChatTarget {
      get { return chatTarget_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SessionFolderCreateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SessionFolderCreateRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Extra != other.Extra) return false;
      if (IconUrl != other.IconUrl) return false;
      if(!chatTarget_.Equals(other.chatTarget_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Extra.Length != 0) hash ^= Extra.GetHashCode();
      if (IconUrl.Length != 0) hash ^= IconUrl.GetHashCode();
      hash ^= chatTarget_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Extra.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Extra);
      }
      if (IconUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(IconUrl);
      }
      chatTarget_.WriteTo(output, _repeated_chatTarget_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Extra.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Extra);
      }
      if (IconUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(IconUrl);
      }
      chatTarget_.WriteTo(ref output, _repeated_chatTarget_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Extra.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Extra);
      }
      if (IconUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IconUrl);
      }
      size += chatTarget_.CalculateSize(_repeated_chatTarget_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SessionFolderCreateRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Extra.Length != 0) {
        Extra = other.Extra;
      }
      if (other.IconUrl.Length != 0) {
        IconUrl = other.IconUrl;
      }
      chatTarget_.Add(other.chatTarget_);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Extra = input.ReadBytes();
            break;
          }
          case 26: {
            IconUrl = input.ReadString();
            break;
          }
          case 34: {
            chatTarget_.AddEntriesFrom(input, _repeated_chatTarget_codec);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Extra = input.ReadBytes();
            break;
          }
          case 26: {
            IconUrl = input.ReadString();
            break;
          }
          case 34: {
            chatTarget_.AddEntriesFrom(ref input, _repeated_chatTarget_codec);
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
