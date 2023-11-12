// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CommonStateSignalAuthorChatReady.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from CommonStateSignalAuthorChatReady.proto</summary>
  public static partial class CommonStateSignalAuthorChatReadyReflection {

    #region Descriptor
    /// <summary>File descriptor for CommonStateSignalAuthorChatReady.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonStateSignalAuthorChatReadyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZDb21tb25TdGF0ZVNpZ25hbEF1dGhvckNoYXRSZWFkeS5wcm90bxIKQWNG",
            "dW5EYW5tdRoaQXV0aG9yQ2hhdFBsYXllckluZm8ucHJvdG8irgEKIENvbW1v",
            "blN0YXRlU2lnbmFsQXV0aG9yQ2hhdFJlYWR5EhQKDGF1dGhvckNoYXRJZBgB",
            "IAEoCRI5Cg9pbnZpdGVyVXNlckluZm8YAiABKAsyIC5BY0Z1bkRhbm11LkF1",
            "dGhvckNoYXRQbGF5ZXJJbmZvEjkKD2ludml0ZWVVc2VySW5mbxgDIAEoCzIg",
            "LkFjRnVuRGFubXUuQXV0aG9yQ2hhdFBsYXllckluZm9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.AuthorChatPlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.CommonStateSignalAuthorChatReady), global::AcFunDanmu.CommonStateSignalAuthorChatReady.Parser, new[]{ "AuthorChatId", "InviterUserInfo", "InviteeUserInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CommonStateSignalAuthorChatReady : pb::IMessage<CommonStateSignalAuthorChatReady>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CommonStateSignalAuthorChatReady> _parser = new pb::MessageParser<CommonStateSignalAuthorChatReady>(() => new CommonStateSignalAuthorChatReady());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CommonStateSignalAuthorChatReady> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.CommonStateSignalAuthorChatReadyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonStateSignalAuthorChatReady() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonStateSignalAuthorChatReady(CommonStateSignalAuthorChatReady other) : this() {
      authorChatId_ = other.authorChatId_;
      inviterUserInfo_ = other.inviterUserInfo_ != null ? other.inviterUserInfo_.Clone() : null;
      inviteeUserInfo_ = other.inviteeUserInfo_ != null ? other.inviteeUserInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonStateSignalAuthorChatReady Clone() {
      return new CommonStateSignalAuthorChatReady(this);
    }

    /// <summary>Field number for the "authorChatId" field.</summary>
    public const int AuthorChatIdFieldNumber = 1;
    private string authorChatId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AuthorChatId {
      get { return authorChatId_; }
      set {
        authorChatId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "inviterUserInfo" field.</summary>
    public const int InviterUserInfoFieldNumber = 2;
    private global::AcFunDanmu.AuthorChatPlayerInfo inviterUserInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.AuthorChatPlayerInfo InviterUserInfo {
      get { return inviterUserInfo_; }
      set {
        inviterUserInfo_ = value;
      }
    }

    /// <summary>Field number for the "inviteeUserInfo" field.</summary>
    public const int InviteeUserInfoFieldNumber = 3;
    private global::AcFunDanmu.AuthorChatPlayerInfo inviteeUserInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.AuthorChatPlayerInfo InviteeUserInfo {
      get { return inviteeUserInfo_; }
      set {
        inviteeUserInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CommonStateSignalAuthorChatReady);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CommonStateSignalAuthorChatReady other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AuthorChatId != other.AuthorChatId) return false;
      if (!object.Equals(InviterUserInfo, other.InviterUserInfo)) return false;
      if (!object.Equals(InviteeUserInfo, other.InviteeUserInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AuthorChatId.Length != 0) hash ^= AuthorChatId.GetHashCode();
      if (inviterUserInfo_ != null) hash ^= InviterUserInfo.GetHashCode();
      if (inviteeUserInfo_ != null) hash ^= InviteeUserInfo.GetHashCode();
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
      if (AuthorChatId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AuthorChatId);
      }
      if (inviterUserInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(InviterUserInfo);
      }
      if (inviteeUserInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(InviteeUserInfo);
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
      if (AuthorChatId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AuthorChatId);
      }
      if (inviterUserInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(InviterUserInfo);
      }
      if (inviteeUserInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(InviteeUserInfo);
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
      if (AuthorChatId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AuthorChatId);
      }
      if (inviterUserInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InviterUserInfo);
      }
      if (inviteeUserInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InviteeUserInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CommonStateSignalAuthorChatReady other) {
      if (other == null) {
        return;
      }
      if (other.AuthorChatId.Length != 0) {
        AuthorChatId = other.AuthorChatId;
      }
      if (other.inviterUserInfo_ != null) {
        if (inviterUserInfo_ == null) {
          InviterUserInfo = new global::AcFunDanmu.AuthorChatPlayerInfo();
        }
        InviterUserInfo.MergeFrom(other.InviterUserInfo);
      }
      if (other.inviteeUserInfo_ != null) {
        if (inviteeUserInfo_ == null) {
          InviteeUserInfo = new global::AcFunDanmu.AuthorChatPlayerInfo();
        }
        InviteeUserInfo.MergeFrom(other.InviteeUserInfo);
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
            AuthorChatId = input.ReadString();
            break;
          }
          case 18: {
            if (inviterUserInfo_ == null) {
              InviterUserInfo = new global::AcFunDanmu.AuthorChatPlayerInfo();
            }
            input.ReadMessage(InviterUserInfo);
            break;
          }
          case 26: {
            if (inviteeUserInfo_ == null) {
              InviteeUserInfo = new global::AcFunDanmu.AuthorChatPlayerInfo();
            }
            input.ReadMessage(InviteeUserInfo);
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
            AuthorChatId = input.ReadString();
            break;
          }
          case 18: {
            if (inviterUserInfo_ == null) {
              InviterUserInfo = new global::AcFunDanmu.AuthorChatPlayerInfo();
            }
            input.ReadMessage(InviterUserInfo);
            break;
          }
          case 26: {
            if (inviteeUserInfo_ == null) {
              InviteeUserInfo = new global::AcFunDanmu.AuthorChatPlayerInfo();
            }
            input.ReadMessage(InviteeUserInfo);
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
