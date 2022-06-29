// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PublicGroupHit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Search {

  /// <summary>Holder for reflection information generated from PublicGroupHit.proto</summary>
  public static partial class PublicGroupHitReflection {

    #region Descriptor
    /// <summary>File descriptor for PublicGroupHit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PublicGroupHitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQdWJsaWNHcm91cEhpdC5wcm90bxIaQWNGdW5EYW5tdS5JbS5DbG91ZC5T",
            "ZWFyY2givgEKDlB1YmxpY0dyb3VwSGl0ElIKCW1hdGNoVHlwZRgBIAEoDjI/",
            "LkFjRnVuRGFubXUuSW0uQ2xvdWQuU2VhcmNoLlB1YmxpY0dyb3VwSGl0LlB1",
            "YmxpY0dyb3VwTWF0Y2hUeXBlIlgKFFB1YmxpY0dyb3VwTWF0Y2hUeXBlEhAK",
            "DFVOS05PV05fUEdNVBAAEg4KCkdST1VQX05BTUUQARIMCghHUk9VUF9JRBAC",
            "EhAKDEdST1VQX05VTUJFUhADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit), global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Parser, new[]{ "MatchType" }, null, new[]{ typeof(global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Types.PublicGroupMatchType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PublicGroupHit : pb::IMessage<PublicGroupHit>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PublicGroupHit> _parser = new pb::MessageParser<PublicGroupHit>(() => new PublicGroupHit());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PublicGroupHit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Search.PublicGroupHitReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PublicGroupHit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PublicGroupHit(PublicGroupHit other) : this() {
      matchType_ = other.matchType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PublicGroupHit Clone() {
      return new PublicGroupHit(this);
    }

    /// <summary>Field number for the "matchType" field.</summary>
    public const int MatchTypeFieldNumber = 1;
    private global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Types.PublicGroupMatchType matchType_ = global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Types.PublicGroupMatchType.UnknownPgmt;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Types.PublicGroupMatchType MatchType {
      get { return matchType_; }
      set {
        matchType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PublicGroupHit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PublicGroupHit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MatchType != other.MatchType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MatchType != global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Types.PublicGroupMatchType.UnknownPgmt) hash ^= MatchType.GetHashCode();
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
      if (MatchType != global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Types.PublicGroupMatchType.UnknownPgmt) {
        output.WriteRawTag(8);
        output.WriteEnum((int) MatchType);
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
      if (MatchType != global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Types.PublicGroupMatchType.UnknownPgmt) {
        output.WriteRawTag(8);
        output.WriteEnum((int) MatchType);
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
      if (MatchType != global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Types.PublicGroupMatchType.UnknownPgmt) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MatchType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PublicGroupHit other) {
      if (other == null) {
        return;
      }
      if (other.MatchType != global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Types.PublicGroupMatchType.UnknownPgmt) {
        MatchType = other.MatchType;
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
            MatchType = (global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Types.PublicGroupMatchType) input.ReadEnum();
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
            MatchType = (global::AcFunDanmu.Im.Cloud.Search.PublicGroupHit.Types.PublicGroupMatchType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PublicGroupHit message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum PublicGroupMatchType {
        [pbr::OriginalName("UNKNOWN_PGMT")] UnknownPgmt = 0,
        [pbr::OriginalName("GROUP_NAME")] GroupName = 1,
        [pbr::OriginalName("GROUP_ID")] GroupId = 2,
        [pbr::OriginalName("GROUP_NUMBER")] GroupNumber = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
