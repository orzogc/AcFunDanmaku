// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Media.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from Media.proto</summary>
  public static partial class MediaReflection {

    #region Descriptor
    /// <summary>File descriptor for Media.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MediaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtNZWRpYS5wcm90bxIbQWNGdW5EYW5tdS5JbS5DbG91ZC5NZXNzYWdlGgtB",
            "dWRpby5wcm90bxoORW1vdGljb24ucHJvdG8aCkZpbGUucHJvdG8aC0ltYWdl",
            "LnByb3RvGgtWaWRlby5wcm90byK7AgoFTWVkaWESMwoFaW1hZ2UYASABKAsy",
            "Ii5BY0Z1bkRhbm11LkltLkNsb3VkLk1lc3NhZ2UuSW1hZ2VIABIzCgVhdWRp",
            "bxgCIAEoCzIiLkFjRnVuRGFubXUuSW0uQ2xvdWQuTWVzc2FnZS5BdWRpb0gA",
            "EjMKBXZpZGVvGAMgASgLMiIuQWNGdW5EYW5tdS5JbS5DbG91ZC5NZXNzYWdl",
            "LlZpZGVvSAASMQoEZmlsZRgEIAEoCzIhLkFjRnVuRGFubXUuSW0uQ2xvdWQu",
            "TWVzc2FnZS5GaWxlSAASOQoIZW1vdGljb24YBSABKAsyJS5BY0Z1bkRhbm11",
            "LkltLkNsb3VkLk1lc3NhZ2UuRW1vdGljb25IABILCgNwb3MYFCABKAUSDAoE",
            "bmFtZRgVIAEoCUIKCghyZXNvdXJjZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Cloud.Message.AudioReflection.Descriptor, global::AcFunDanmu.Im.Cloud.Message.EmoticonReflection.Descriptor, global::AcFunDanmu.Im.Cloud.Message.FileReflection.Descriptor, global::AcFunDanmu.Im.Cloud.Message.ImageReflection.Descriptor, global::AcFunDanmu.Im.Cloud.Message.VideoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.Media), global::AcFunDanmu.Im.Cloud.Message.Media.Parser, new[]{ "Image", "Audio", "Video", "File", "Emoticon", "Pos", "Name" }, new[]{ "Resource" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Media : pb::IMessage<Media>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Media> _parser = new pb::MessageParser<Media>(() => new Media());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Media> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Message.MediaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Media() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Media(Media other) : this() {
      pos_ = other.pos_;
      name_ = other.name_;
      switch (other.ResourceCase) {
        case ResourceOneofCase.Image:
          Image = other.Image.Clone();
          break;
        case ResourceOneofCase.Audio:
          Audio = other.Audio.Clone();
          break;
        case ResourceOneofCase.Video:
          Video = other.Video.Clone();
          break;
        case ResourceOneofCase.File:
          File = other.File.Clone();
          break;
        case ResourceOneofCase.Emoticon:
          Emoticon = other.Emoticon.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Media Clone() {
      return new Media(this);
    }

    /// <summary>Field number for the "image" field.</summary>
    public const int ImageFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.Image Image {
      get { return resourceCase_ == ResourceOneofCase.Image ? (global::AcFunDanmu.Im.Cloud.Message.Image) resource_ : null; }
      set {
        resource_ = value;
        resourceCase_ = value == null ? ResourceOneofCase.None : ResourceOneofCase.Image;
      }
    }

    /// <summary>Field number for the "audio" field.</summary>
    public const int AudioFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.Audio Audio {
      get { return resourceCase_ == ResourceOneofCase.Audio ? (global::AcFunDanmu.Im.Cloud.Message.Audio) resource_ : null; }
      set {
        resource_ = value;
        resourceCase_ = value == null ? ResourceOneofCase.None : ResourceOneofCase.Audio;
      }
    }

    /// <summary>Field number for the "video" field.</summary>
    public const int VideoFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.Video Video {
      get { return resourceCase_ == ResourceOneofCase.Video ? (global::AcFunDanmu.Im.Cloud.Message.Video) resource_ : null; }
      set {
        resource_ = value;
        resourceCase_ = value == null ? ResourceOneofCase.None : ResourceOneofCase.Video;
      }
    }

    /// <summary>Field number for the "file" field.</summary>
    public const int FileFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.File File {
      get { return resourceCase_ == ResourceOneofCase.File ? (global::AcFunDanmu.Im.Cloud.Message.File) resource_ : null; }
      set {
        resource_ = value;
        resourceCase_ = value == null ? ResourceOneofCase.None : ResourceOneofCase.File;
      }
    }

    /// <summary>Field number for the "emoticon" field.</summary>
    public const int EmoticonFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Message.Emoticon Emoticon {
      get { return resourceCase_ == ResourceOneofCase.Emoticon ? (global::AcFunDanmu.Im.Cloud.Message.Emoticon) resource_ : null; }
      set {
        resource_ = value;
        resourceCase_ = value == null ? ResourceOneofCase.None : ResourceOneofCase.Emoticon;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 20;
    private int pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 21;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private object resource_;
    /// <summary>Enum of possible cases for the "resource" oneof.</summary>
    public enum ResourceOneofCase {
      None = 0,
      Image = 1,
      Audio = 2,
      Video = 3,
      File = 4,
      Emoticon = 5,
    }
    private ResourceOneofCase resourceCase_ = ResourceOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResourceOneofCase ResourceCase {
      get { return resourceCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearResource() {
      resourceCase_ = ResourceOneofCase.None;
      resource_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Media);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Media other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Image, other.Image)) return false;
      if (!object.Equals(Audio, other.Audio)) return false;
      if (!object.Equals(Video, other.Video)) return false;
      if (!object.Equals(File, other.File)) return false;
      if (!object.Equals(Emoticon, other.Emoticon)) return false;
      if (Pos != other.Pos) return false;
      if (Name != other.Name) return false;
      if (ResourceCase != other.ResourceCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (resourceCase_ == ResourceOneofCase.Image) hash ^= Image.GetHashCode();
      if (resourceCase_ == ResourceOneofCase.Audio) hash ^= Audio.GetHashCode();
      if (resourceCase_ == ResourceOneofCase.Video) hash ^= Video.GetHashCode();
      if (resourceCase_ == ResourceOneofCase.File) hash ^= File.GetHashCode();
      if (resourceCase_ == ResourceOneofCase.Emoticon) hash ^= Emoticon.GetHashCode();
      if (Pos != 0) hash ^= Pos.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= (int) resourceCase_;
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
      if (resourceCase_ == ResourceOneofCase.Image) {
        output.WriteRawTag(10);
        output.WriteMessage(Image);
      }
      if (resourceCase_ == ResourceOneofCase.Audio) {
        output.WriteRawTag(18);
        output.WriteMessage(Audio);
      }
      if (resourceCase_ == ResourceOneofCase.Video) {
        output.WriteRawTag(26);
        output.WriteMessage(Video);
      }
      if (resourceCase_ == ResourceOneofCase.File) {
        output.WriteRawTag(34);
        output.WriteMessage(File);
      }
      if (resourceCase_ == ResourceOneofCase.Emoticon) {
        output.WriteRawTag(42);
        output.WriteMessage(Emoticon);
      }
      if (Pos != 0) {
        output.WriteRawTag(160, 1);
        output.WriteInt32(Pos);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(170, 1);
        output.WriteString(Name);
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
      if (resourceCase_ == ResourceOneofCase.Image) {
        output.WriteRawTag(10);
        output.WriteMessage(Image);
      }
      if (resourceCase_ == ResourceOneofCase.Audio) {
        output.WriteRawTag(18);
        output.WriteMessage(Audio);
      }
      if (resourceCase_ == ResourceOneofCase.Video) {
        output.WriteRawTag(26);
        output.WriteMessage(Video);
      }
      if (resourceCase_ == ResourceOneofCase.File) {
        output.WriteRawTag(34);
        output.WriteMessage(File);
      }
      if (resourceCase_ == ResourceOneofCase.Emoticon) {
        output.WriteRawTag(42);
        output.WriteMessage(Emoticon);
      }
      if (Pos != 0) {
        output.WriteRawTag(160, 1);
        output.WriteInt32(Pos);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(170, 1);
        output.WriteString(Name);
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
      if (resourceCase_ == ResourceOneofCase.Image) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Image);
      }
      if (resourceCase_ == ResourceOneofCase.Audio) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Audio);
      }
      if (resourceCase_ == ResourceOneofCase.Video) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Video);
      }
      if (resourceCase_ == ResourceOneofCase.File) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(File);
      }
      if (resourceCase_ == ResourceOneofCase.Emoticon) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Emoticon);
      }
      if (Pos != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Pos);
      }
      if (Name.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Media other) {
      if (other == null) {
        return;
      }
      if (other.Pos != 0) {
        Pos = other.Pos;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      switch (other.ResourceCase) {
        case ResourceOneofCase.Image:
          if (Image == null) {
            Image = new global::AcFunDanmu.Im.Cloud.Message.Image();
          }
          Image.MergeFrom(other.Image);
          break;
        case ResourceOneofCase.Audio:
          if (Audio == null) {
            Audio = new global::AcFunDanmu.Im.Cloud.Message.Audio();
          }
          Audio.MergeFrom(other.Audio);
          break;
        case ResourceOneofCase.Video:
          if (Video == null) {
            Video = new global::AcFunDanmu.Im.Cloud.Message.Video();
          }
          Video.MergeFrom(other.Video);
          break;
        case ResourceOneofCase.File:
          if (File == null) {
            File = new global::AcFunDanmu.Im.Cloud.Message.File();
          }
          File.MergeFrom(other.File);
          break;
        case ResourceOneofCase.Emoticon:
          if (Emoticon == null) {
            Emoticon = new global::AcFunDanmu.Im.Cloud.Message.Emoticon();
          }
          Emoticon.MergeFrom(other.Emoticon);
          break;
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
            global::AcFunDanmu.Im.Cloud.Message.Image subBuilder = new global::AcFunDanmu.Im.Cloud.Message.Image();
            if (resourceCase_ == ResourceOneofCase.Image) {
              subBuilder.MergeFrom(Image);
            }
            input.ReadMessage(subBuilder);
            Image = subBuilder;
            break;
          }
          case 18: {
            global::AcFunDanmu.Im.Cloud.Message.Audio subBuilder = new global::AcFunDanmu.Im.Cloud.Message.Audio();
            if (resourceCase_ == ResourceOneofCase.Audio) {
              subBuilder.MergeFrom(Audio);
            }
            input.ReadMessage(subBuilder);
            Audio = subBuilder;
            break;
          }
          case 26: {
            global::AcFunDanmu.Im.Cloud.Message.Video subBuilder = new global::AcFunDanmu.Im.Cloud.Message.Video();
            if (resourceCase_ == ResourceOneofCase.Video) {
              subBuilder.MergeFrom(Video);
            }
            input.ReadMessage(subBuilder);
            Video = subBuilder;
            break;
          }
          case 34: {
            global::AcFunDanmu.Im.Cloud.Message.File subBuilder = new global::AcFunDanmu.Im.Cloud.Message.File();
            if (resourceCase_ == ResourceOneofCase.File) {
              subBuilder.MergeFrom(File);
            }
            input.ReadMessage(subBuilder);
            File = subBuilder;
            break;
          }
          case 42: {
            global::AcFunDanmu.Im.Cloud.Message.Emoticon subBuilder = new global::AcFunDanmu.Im.Cloud.Message.Emoticon();
            if (resourceCase_ == ResourceOneofCase.Emoticon) {
              subBuilder.MergeFrom(Emoticon);
            }
            input.ReadMessage(subBuilder);
            Emoticon = subBuilder;
            break;
          }
          case 160: {
            Pos = input.ReadInt32();
            break;
          }
          case 170: {
            Name = input.ReadString();
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
            global::AcFunDanmu.Im.Cloud.Message.Image subBuilder = new global::AcFunDanmu.Im.Cloud.Message.Image();
            if (resourceCase_ == ResourceOneofCase.Image) {
              subBuilder.MergeFrom(Image);
            }
            input.ReadMessage(subBuilder);
            Image = subBuilder;
            break;
          }
          case 18: {
            global::AcFunDanmu.Im.Cloud.Message.Audio subBuilder = new global::AcFunDanmu.Im.Cloud.Message.Audio();
            if (resourceCase_ == ResourceOneofCase.Audio) {
              subBuilder.MergeFrom(Audio);
            }
            input.ReadMessage(subBuilder);
            Audio = subBuilder;
            break;
          }
          case 26: {
            global::AcFunDanmu.Im.Cloud.Message.Video subBuilder = new global::AcFunDanmu.Im.Cloud.Message.Video();
            if (resourceCase_ == ResourceOneofCase.Video) {
              subBuilder.MergeFrom(Video);
            }
            input.ReadMessage(subBuilder);
            Video = subBuilder;
            break;
          }
          case 34: {
            global::AcFunDanmu.Im.Cloud.Message.File subBuilder = new global::AcFunDanmu.Im.Cloud.Message.File();
            if (resourceCase_ == ResourceOneofCase.File) {
              subBuilder.MergeFrom(File);
            }
            input.ReadMessage(subBuilder);
            File = subBuilder;
            break;
          }
          case 42: {
            global::AcFunDanmu.Im.Cloud.Message.Emoticon subBuilder = new global::AcFunDanmu.Im.Cloud.Message.Emoticon();
            if (resourceCase_ == ResourceOneofCase.Emoticon) {
              subBuilder.MergeFrom(Emoticon);
            }
            input.ReadMessage(subBuilder);
            Emoticon = subBuilder;
            break;
          }
          case 160: {
            Pos = input.ReadInt32();
            break;
          }
          case 170: {
            Name = input.ReadString();
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
