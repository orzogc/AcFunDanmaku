// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CommonActionSignalUserEnterRoom.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from CommonActionSignalUserEnterRoom.proto</summary>
  public static partial class CommonActionSignalUserEnterRoomReflection {

    #region Descriptor
    /// <summary>File descriptor for CommonActionSignalUserEnterRoom.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonActionSignalUserEnterRoomReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVDb21tb25BY3Rpb25TaWduYWxVc2VyRW50ZXJSb29tLnByb3RvEgpBY0Z1",
            "bkRhbm11GhRadExpdmVVc2VySW5mby5wcm90byJjCh9Db21tb25BY3Rpb25T",
            "aWduYWxVc2VyRW50ZXJSb29tEiwKCHVzZXJJbmZvGAEgASgLMhouQWNGdW5E",
            "YW5tdS5adExpdmVVc2VySW5mbxISCgpzZW5kVGltZU1zGAIgASgDYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.ZtLiveUserInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.CommonActionSignalUserEnterRoom), global::AcFunDanmu.CommonActionSignalUserEnterRoom.Parser, new[]{ "UserInfo", "SendTimeMs" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CommonActionSignalUserEnterRoom : pb::IMessage<CommonActionSignalUserEnterRoom> {
    private static readonly pb::MessageParser<CommonActionSignalUserEnterRoom> _parser = new pb::MessageParser<CommonActionSignalUserEnterRoom>(() => new CommonActionSignalUserEnterRoom());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommonActionSignalUserEnterRoom> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.CommonActionSignalUserEnterRoomReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonActionSignalUserEnterRoom() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonActionSignalUserEnterRoom(CommonActionSignalUserEnterRoom other) : this() {
      userInfo_ = other.userInfo_ != null ? other.userInfo_.Clone() : null;
      sendTimeMs_ = other.sendTimeMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonActionSignalUserEnterRoom Clone() {
      return new CommonActionSignalUserEnterRoom(this);
    }

    /// <summary>Field number for the "userInfo" field.</summary>
    public const int UserInfoFieldNumber = 1;
    private global::AcFunDanmu.ZtLiveUserInfo userInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public long SendTimeMs {
      get { return sendTimeMs_; }
      set {
        sendTimeMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommonActionSignalUserEnterRoom);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommonActionSignalUserEnterRoom other) {
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
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
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
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public void MergeFrom(CommonActionSignalUserEnterRoom other) {
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
    public void MergeFrom(pb::CodedInputStream input) {
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
    }

  }

  #endregion

}

#endregion Designer generated code
