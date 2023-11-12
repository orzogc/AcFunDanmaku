// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AudioAttachment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Message {

  /// <summary>Holder for reflection information generated from AudioAttachment.proto</summary>
  public static partial class AudioAttachmentReflection {

    #region Descriptor
    /// <summary>File descriptor for AudioAttachment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AudioAttachmentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVBdWRpb0F0dGFjaG1lbnQucHJvdG8SFUFjRnVuRGFubXUuSW0uTWVzc2Fn",
            "ZSJdCg9BdWRpb0F0dGFjaG1lbnQSEAoIbWltZVR5cGUYASABKAkSCwoDdXJs",
            "GAIgASgJEhQKDGR1cmF0aW9uSW5NUxgDIAEoAxIVCg1sZW5ndGhJbkJ5dGVz",
            "GAUgASgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Message.AudioAttachment), global::AcFunDanmu.Im.Message.AudioAttachment.Parser, new[]{ "MimeType", "Url", "DurationInMS", "LengthInBytes" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AudioAttachment : pb::IMessage<AudioAttachment>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AudioAttachment> _parser = new pb::MessageParser<AudioAttachment>(() => new AudioAttachment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AudioAttachment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Message.AudioAttachmentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AudioAttachment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AudioAttachment(AudioAttachment other) : this() {
      mimeType_ = other.mimeType_;
      url_ = other.url_;
      durationInMS_ = other.durationInMS_;
      lengthInBytes_ = other.lengthInBytes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AudioAttachment Clone() {
      return new AudioAttachment(this);
    }

    /// <summary>Field number for the "mimeType" field.</summary>
    public const int MimeTypeFieldNumber = 1;
    private string mimeType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MimeType {
      get { return mimeType_; }
      set {
        mimeType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 2;
    private string url_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "durationInMS" field.</summary>
    public const int DurationInMSFieldNumber = 3;
    private long durationInMS_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long DurationInMS {
      get { return durationInMS_; }
      set {
        durationInMS_ = value;
      }
    }

    /// <summary>Field number for the "lengthInBytes" field.</summary>
    public const int LengthInBytesFieldNumber = 5;
    private long lengthInBytes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long LengthInBytes {
      get { return lengthInBytes_; }
      set {
        lengthInBytes_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AudioAttachment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AudioAttachment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MimeType != other.MimeType) return false;
      if (Url != other.Url) return false;
      if (DurationInMS != other.DurationInMS) return false;
      if (LengthInBytes != other.LengthInBytes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MimeType.Length != 0) hash ^= MimeType.GetHashCode();
      if (Url.Length != 0) hash ^= Url.GetHashCode();
      if (DurationInMS != 0L) hash ^= DurationInMS.GetHashCode();
      if (LengthInBytes != 0L) hash ^= LengthInBytes.GetHashCode();
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
      if (MimeType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MimeType);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Url);
      }
      if (DurationInMS != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(DurationInMS);
      }
      if (LengthInBytes != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(LengthInBytes);
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
      if (MimeType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MimeType);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Url);
      }
      if (DurationInMS != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(DurationInMS);
      }
      if (LengthInBytes != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(LengthInBytes);
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
      if (MimeType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MimeType);
      }
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (DurationInMS != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DurationInMS);
      }
      if (LengthInBytes != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LengthInBytes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AudioAttachment other) {
      if (other == null) {
        return;
      }
      if (other.MimeType.Length != 0) {
        MimeType = other.MimeType;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
      }
      if (other.DurationInMS != 0L) {
        DurationInMS = other.DurationInMS;
      }
      if (other.LengthInBytes != 0L) {
        LengthInBytes = other.LengthInBytes;
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
            MimeType = input.ReadString();
            break;
          }
          case 18: {
            Url = input.ReadString();
            break;
          }
          case 24: {
            DurationInMS = input.ReadInt64();
            break;
          }
          case 40: {
            LengthInBytes = input.ReadInt64();
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
            MimeType = input.ReadString();
            break;
          }
          case 18: {
            Url = input.ReadString();
            break;
          }
          case 24: {
            DurationInMS = input.ReadInt64();
            break;
          }
          case 40: {
            LengthInBytes = input.ReadInt64();
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
