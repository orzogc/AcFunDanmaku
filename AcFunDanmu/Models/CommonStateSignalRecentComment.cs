// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CommonStateSignalRecentComment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from CommonStateSignalRecentComment.proto</summary>
  public static partial class CommonStateSignalRecentCommentReflection {

    #region Descriptor
    /// <summary>File descriptor for CommonStateSignalRecentComment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonStateSignalRecentCommentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRDb21tb25TdGF0ZVNpZ25hbFJlY2VudENvbW1lbnQucHJvdG8SCkFjRnVu",
            "RGFubXUaH0NvbW1vbkFjdGlvblNpZ25hbENvbW1lbnQucHJvdG8iWAoeQ29t",
            "bW9uU3RhdGVTaWduYWxSZWNlbnRDb21tZW50EjYKB2NvbW1lbnQYASADKAsy",
            "JS5BY0Z1bkRhbm11LkNvbW1vbkFjdGlvblNpZ25hbENvbW1lbnRiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.CommonActionSignalCommentReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.CommonStateSignalRecentComment), global::AcFunDanmu.CommonStateSignalRecentComment.Parser, new[]{ "Comment" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CommonStateSignalRecentComment : pb::IMessage<CommonStateSignalRecentComment> {
    private static readonly pb::MessageParser<CommonStateSignalRecentComment> _parser = new pb::MessageParser<CommonStateSignalRecentComment>(() => new CommonStateSignalRecentComment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommonStateSignalRecentComment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.CommonStateSignalRecentCommentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonStateSignalRecentComment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonStateSignalRecentComment(CommonStateSignalRecentComment other) : this() {
      comment_ = other.comment_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonStateSignalRecentComment Clone() {
      return new CommonStateSignalRecentComment(this);
    }

    /// <summary>Field number for the "comment" field.</summary>
    public const int CommentFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AcFunDanmu.CommonActionSignalComment> _repeated_comment_codec
        = pb::FieldCodec.ForMessage(10, global::AcFunDanmu.CommonActionSignalComment.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.CommonActionSignalComment> comment_ = new pbc::RepeatedField<global::AcFunDanmu.CommonActionSignalComment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AcFunDanmu.CommonActionSignalComment> Comment {
      get { return comment_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommonStateSignalRecentComment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommonStateSignalRecentComment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!comment_.Equals(other.comment_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= comment_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      comment_.WriteTo(output, _repeated_comment_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += comment_.CalculateSize(_repeated_comment_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommonStateSignalRecentComment other) {
      if (other == null) {
        return;
      }
      comment_.Add(other.comment_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            comment_.AddEntriesFrom(input, _repeated_comment_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
