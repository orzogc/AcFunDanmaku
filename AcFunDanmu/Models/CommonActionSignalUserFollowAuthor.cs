// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CommonActionSignalUserFollowAuthor.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from CommonActionSignalUserFollowAuthor.proto</summary>
  public static partial class CommonActionSignalUserFollowAuthorReflection {

    #region Descriptor
    /// <summary>File descriptor for CommonActionSignalUserFollowAuthor.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonActionSignalUserFollowAuthorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihDb21tb25BY3Rpb25TaWduYWxVc2VyRm9sbG93QXV0aG9yLnByb3RvEgpB",
            "Y0Z1bkRhbm11GhRadExpdmVVc2VySW5mby5wcm90byJmCiJDb21tb25BY3Rp",
            "b25TaWduYWxVc2VyRm9sbG93QXV0aG9yEiwKCHVzZXJJbmZvGAEgASgLMhou",
            "QWNGdW5EYW5tdS5adExpdmVVc2VySW5mbxISCgpzZW5kVGltZU1zGAIgASgD",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.ZtLiveUserInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.CommonActionSignalUserFollowAuthor), global::AcFunDanmu.CommonActionSignalUserFollowAuthor.Parser, new[]{ "UserInfo", "SendTimeMs" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CommonActionSignalUserFollowAuthor : pb::IMessage<CommonActionSignalUserFollowAuthor>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CommonActionSignalUserFollowAuthor> _parser = new pb::MessageParser<CommonActionSignalUserFollowAuthor>(() => new CommonActionSignalUserFollowAuthor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CommonActionSignalUserFollowAuthor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.CommonActionSignalUserFollowAuthorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonActionSignalUserFollowAuthor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonActionSignalUserFollowAuthor(CommonActionSignalUserFollowAuthor other) : this() {
      userInfo_ = other.userInfo_ != null ? other.userInfo_.Clone() : null;
      sendTimeMs_ = other.sendTimeMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonActionSignalUserFollowAuthor Clone() {
      return new CommonActionSignalUserFollowAuthor(this);
    }

    /// <summary>Field number for the "userInfo" field.</summary>
    public const int UserInfoFieldNumber = 1;
    private global::AcFunDanmu.ZtLiveUserInfo userInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.ZtLiveUserInfo UserInfo {
      get { return userInfo_; }
      set {
        userInfo_ = value;
      }
    }

    /// <summary>Field number for the "sendTimeMs" field.</summary>
    public const int SendTimeMsFieldNumber = 2;
    private long sendTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SendTimeMs {
      get { return sendTimeMs_; }
      set {
        sendTimeMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CommonActionSignalUserFollowAuthor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CommonActionSignalUserFollowAuthor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UserInfo, other.UserInfo)) return false;
      if (SendTimeMs != other.SendTimeMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (userInfo_ != null) hash ^= UserInfo.GetHashCode();
      if (SendTimeMs != 0L) hash ^= SendTimeMs.GetHashCode();
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
      if (userInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UserInfo);
      }
      if (SendTimeMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SendTimeMs);
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
      if (userInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UserInfo);
      }
      if (SendTimeMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SendTimeMs);
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
      if (userInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserInfo);
      }
      if (SendTimeMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SendTimeMs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CommonActionSignalUserFollowAuthor other) {
      if (other == null) {
        return;
      }
      if (other.userInfo_ != null) {
        if (userInfo_ == null) {
          UserInfo = new global::AcFunDanmu.ZtLiveUserInfo();
        }
        UserInfo.MergeFrom(other.UserInfo);
      }
      if (other.SendTimeMs != 0L) {
        SendTimeMs = other.SendTimeMs;
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
            if (userInfo_ == null) {
              UserInfo = new global::AcFunDanmu.ZtLiveUserInfo();
            }
            input.ReadMessage(UserInfo);
            break;
          }
          case 16: {
            SendTimeMs = input.ReadInt64();
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
            if (userInfo_ == null) {
              UserInfo = new global::AcFunDanmu.ZtLiveUserInfo();
            }
            input.ReadMessage(UserInfo);
            break;
          }
          case 16: {
            SendTimeMs = input.ReadInt64();
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
