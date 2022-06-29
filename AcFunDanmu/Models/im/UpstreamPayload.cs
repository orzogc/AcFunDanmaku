// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpstreamPayload.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Basic {

  /// <summary>Holder for reflection information generated from UpstreamPayload.proto</summary>
  public static partial class UpstreamPayloadReflection {

    #region Descriptor
    /// <summary>File descriptor for UpstreamPayload.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpstreamPayloadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVVcHN0cmVhbVBheWxvYWQucHJvdG8SE0FjRnVuRGFubXUuSW0uQmFzaWMa",
            "EkZyb250ZW5kSW5mby5wcm90bxoWUmVxdXNldEJhc2ljSW5mby5wcm90bxoR",
            "U2V0dGluZ0luZm8ucHJvdG8aElVzZXJJbnN0YW5jZS5wcm90byKcAwoPVXBz",
            "dHJlYW1QYXlsb2FkEg8KB2NvbW1hbmQYASABKAkSDQoFc2VxSWQYAiABKAMS",
            "EgoKcmV0cnlDb3VudBgDIAEoDRITCgtwYXlsb2FkRGF0YRgEIAEoDBI3Cgx1",
            "c2VySW5zdGFuY2UYBSABKAsyIS5BY0Z1bkRhbm11LkltLkJhc2ljLlVzZXJJ",
            "bnN0YW5jZRIRCgllcnJvckNvZGUYBiABKAUSNQoLc2V0dGluZ0luZm8YByAB",
            "KAsyIC5BY0Z1bkRhbm11LkltLkJhc2ljLlNldHRpbmdJbmZvEj8KEHJlcXVl",
            "c3RCYXNpY0luZm8YCCABKAsyJS5BY0Z1bkRhbm11LkltLkJhc2ljLlJlcXVz",
            "ZXRCYXNpY0luZm8SDgoGc3ViQml6GAkgASgJEjcKDGZyb250ZW5kSW5mbxgK",
            "IAEoCzIhLkFjRnVuRGFubXUuSW0uQmFzaWMuRnJvbnRlbmRJbmZvEgsKA2tw",
            "bhgLIAEoCRIWCg5hbm9ueW1vdXNlVXNlchgMIAEoCBIOCgZsYW5lSWQYDSAB",
            "KAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Basic.FrontendInfoReflection.Descriptor, global::AcFunDanmu.Im.Basic.RequsetBasicInfoReflection.Descriptor, global::AcFunDanmu.Im.Basic.SettingInfoReflection.Descriptor, global::AcFunDanmu.Im.Basic.UserInstanceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Basic.UpstreamPayload), global::AcFunDanmu.Im.Basic.UpstreamPayload.Parser, new[]{ "Command", "SeqId", "RetryCount", "PayloadData", "UserInstance", "ErrorCode", "SettingInfo", "RequestBasicInfo", "SubBiz", "FrontendInfo", "Kpn", "AnonymouseUser", "LaneId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UpstreamPayload : pb::IMessage<UpstreamPayload>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpstreamPayload> _parser = new pb::MessageParser<UpstreamPayload>(() => new UpstreamPayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpstreamPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Basic.UpstreamPayloadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpstreamPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpstreamPayload(UpstreamPayload other) : this() {
      command_ = other.command_;
      seqId_ = other.seqId_;
      retryCount_ = other.retryCount_;
      payloadData_ = other.payloadData_;
      userInstance_ = other.userInstance_ != null ? other.userInstance_.Clone() : null;
      errorCode_ = other.errorCode_;
      settingInfo_ = other.settingInfo_ != null ? other.settingInfo_.Clone() : null;
      requestBasicInfo_ = other.requestBasicInfo_ != null ? other.requestBasicInfo_.Clone() : null;
      subBiz_ = other.subBiz_;
      frontendInfo_ = other.frontendInfo_ != null ? other.frontendInfo_.Clone() : null;
      kpn_ = other.kpn_;
      anonymouseUser_ = other.anonymouseUser_;
      laneId_ = other.laneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpstreamPayload Clone() {
      return new UpstreamPayload(this);
    }

    /// <summary>Field number for the "command" field.</summary>
    public const int CommandFieldNumber = 1;
    private string command_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Command {
      get { return command_; }
      set {
        command_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "seqId" field.</summary>
    public const int SeqIdFieldNumber = 2;
    private long seqId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SeqId {
      get { return seqId_; }
      set {
        seqId_ = value;
      }
    }

    /// <summary>Field number for the "retryCount" field.</summary>
    public const int RetryCountFieldNumber = 3;
    private uint retryCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RetryCount {
      get { return retryCount_; }
      set {
        retryCount_ = value;
      }
    }

    /// <summary>Field number for the "payloadData" field.</summary>
    public const int PayloadDataFieldNumber = 4;
    private pb::ByteString payloadData_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString PayloadData {
      get { return payloadData_; }
      set {
        payloadData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "userInstance" field.</summary>
    public const int UserInstanceFieldNumber = 5;
    private global::AcFunDanmu.Im.Basic.UserInstance userInstance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.UserInstance UserInstance {
      get { return userInstance_; }
      set {
        userInstance_ = value;
      }
    }

    /// <summary>Field number for the "errorCode" field.</summary>
    public const int ErrorCodeFieldNumber = 6;
    private int errorCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ErrorCode {
      get { return errorCode_; }
      set {
        errorCode_ = value;
      }
    }

    /// <summary>Field number for the "settingInfo" field.</summary>
    public const int SettingInfoFieldNumber = 7;
    private global::AcFunDanmu.Im.Basic.SettingInfo settingInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.SettingInfo SettingInfo {
      get { return settingInfo_; }
      set {
        settingInfo_ = value;
      }
    }

    /// <summary>Field number for the "requestBasicInfo" field.</summary>
    public const int RequestBasicInfoFieldNumber = 8;
    private global::AcFunDanmu.Im.Basic.RequsetBasicInfo requestBasicInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.RequsetBasicInfo RequestBasicInfo {
      get { return requestBasicInfo_; }
      set {
        requestBasicInfo_ = value;
      }
    }

    /// <summary>Field number for the "subBiz" field.</summary>
    public const int SubBizFieldNumber = 9;
    private string subBiz_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SubBiz {
      get { return subBiz_; }
      set {
        subBiz_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "frontendInfo" field.</summary>
    public const int FrontendInfoFieldNumber = 10;
    private global::AcFunDanmu.Im.Basic.FrontendInfo frontendInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.FrontendInfo FrontendInfo {
      get { return frontendInfo_; }
      set {
        frontendInfo_ = value;
      }
    }

    /// <summary>Field number for the "kpn" field.</summary>
    public const int KpnFieldNumber = 11;
    private string kpn_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Kpn {
      get { return kpn_; }
      set {
        kpn_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "anonymouseUser" field.</summary>
    public const int AnonymouseUserFieldNumber = 12;
    private bool anonymouseUser_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AnonymouseUser {
      get { return anonymouseUser_; }
      set {
        anonymouseUser_ = value;
      }
    }

    /// <summary>Field number for the "laneId" field.</summary>
    public const int LaneIdFieldNumber = 13;
    private string laneId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LaneId {
      get { return laneId_; }
      set {
        laneId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpstreamPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpstreamPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Command != other.Command) return false;
      if (SeqId != other.SeqId) return false;
      if (RetryCount != other.RetryCount) return false;
      if (PayloadData != other.PayloadData) return false;
      if (!object.Equals(UserInstance, other.UserInstance)) return false;
      if (ErrorCode != other.ErrorCode) return false;
      if (!object.Equals(SettingInfo, other.SettingInfo)) return false;
      if (!object.Equals(RequestBasicInfo, other.RequestBasicInfo)) return false;
      if (SubBiz != other.SubBiz) return false;
      if (!object.Equals(FrontendInfo, other.FrontendInfo)) return false;
      if (Kpn != other.Kpn) return false;
      if (AnonymouseUser != other.AnonymouseUser) return false;
      if (LaneId != other.LaneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Command.Length != 0) hash ^= Command.GetHashCode();
      if (SeqId != 0L) hash ^= SeqId.GetHashCode();
      if (RetryCount != 0) hash ^= RetryCount.GetHashCode();
      if (PayloadData.Length != 0) hash ^= PayloadData.GetHashCode();
      if (userInstance_ != null) hash ^= UserInstance.GetHashCode();
      if (ErrorCode != 0) hash ^= ErrorCode.GetHashCode();
      if (settingInfo_ != null) hash ^= SettingInfo.GetHashCode();
      if (requestBasicInfo_ != null) hash ^= RequestBasicInfo.GetHashCode();
      if (SubBiz.Length != 0) hash ^= SubBiz.GetHashCode();
      if (frontendInfo_ != null) hash ^= FrontendInfo.GetHashCode();
      if (Kpn.Length != 0) hash ^= Kpn.GetHashCode();
      if (AnonymouseUser != false) hash ^= AnonymouseUser.GetHashCode();
      if (LaneId.Length != 0) hash ^= LaneId.GetHashCode();
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
      if (Command.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Command);
      }
      if (SeqId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SeqId);
      }
      if (RetryCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RetryCount);
      }
      if (PayloadData.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(PayloadData);
      }
      if (userInstance_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UserInstance);
      }
      if (ErrorCode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(ErrorCode);
      }
      if (settingInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(SettingInfo);
      }
      if (requestBasicInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RequestBasicInfo);
      }
      if (SubBiz.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(SubBiz);
      }
      if (frontendInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(FrontendInfo);
      }
      if (Kpn.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Kpn);
      }
      if (AnonymouseUser != false) {
        output.WriteRawTag(96);
        output.WriteBool(AnonymouseUser);
      }
      if (LaneId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(LaneId);
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
      if (Command.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Command);
      }
      if (SeqId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SeqId);
      }
      if (RetryCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RetryCount);
      }
      if (PayloadData.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(PayloadData);
      }
      if (userInstance_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UserInstance);
      }
      if (ErrorCode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(ErrorCode);
      }
      if (settingInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(SettingInfo);
      }
      if (requestBasicInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RequestBasicInfo);
      }
      if (SubBiz.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(SubBiz);
      }
      if (frontendInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(FrontendInfo);
      }
      if (Kpn.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Kpn);
      }
      if (AnonymouseUser != false) {
        output.WriteRawTag(96);
        output.WriteBool(AnonymouseUser);
      }
      if (LaneId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(LaneId);
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
      if (Command.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Command);
      }
      if (SeqId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SeqId);
      }
      if (RetryCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RetryCount);
      }
      if (PayloadData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(PayloadData);
      }
      if (userInstance_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserInstance);
      }
      if (ErrorCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ErrorCode);
      }
      if (settingInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SettingInfo);
      }
      if (requestBasicInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RequestBasicInfo);
      }
      if (SubBiz.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SubBiz);
      }
      if (frontendInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FrontendInfo);
      }
      if (Kpn.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Kpn);
      }
      if (AnonymouseUser != false) {
        size += 1 + 1;
      }
      if (LaneId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LaneId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpstreamPayload other) {
      if (other == null) {
        return;
      }
      if (other.Command.Length != 0) {
        Command = other.Command;
      }
      if (other.SeqId != 0L) {
        SeqId = other.SeqId;
      }
      if (other.RetryCount != 0) {
        RetryCount = other.RetryCount;
      }
      if (other.PayloadData.Length != 0) {
        PayloadData = other.PayloadData;
      }
      if (other.userInstance_ != null) {
        if (userInstance_ == null) {
          UserInstance = new global::AcFunDanmu.Im.Basic.UserInstance();
        }
        UserInstance.MergeFrom(other.UserInstance);
      }
      if (other.ErrorCode != 0) {
        ErrorCode = other.ErrorCode;
      }
      if (other.settingInfo_ != null) {
        if (settingInfo_ == null) {
          SettingInfo = new global::AcFunDanmu.Im.Basic.SettingInfo();
        }
        SettingInfo.MergeFrom(other.SettingInfo);
      }
      if (other.requestBasicInfo_ != null) {
        if (requestBasicInfo_ == null) {
          RequestBasicInfo = new global::AcFunDanmu.Im.Basic.RequsetBasicInfo();
        }
        RequestBasicInfo.MergeFrom(other.RequestBasicInfo);
      }
      if (other.SubBiz.Length != 0) {
        SubBiz = other.SubBiz;
      }
      if (other.frontendInfo_ != null) {
        if (frontendInfo_ == null) {
          FrontendInfo = new global::AcFunDanmu.Im.Basic.FrontendInfo();
        }
        FrontendInfo.MergeFrom(other.FrontendInfo);
      }
      if (other.Kpn.Length != 0) {
        Kpn = other.Kpn;
      }
      if (other.AnonymouseUser != false) {
        AnonymouseUser = other.AnonymouseUser;
      }
      if (other.LaneId.Length != 0) {
        LaneId = other.LaneId;
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
            Command = input.ReadString();
            break;
          }
          case 16: {
            SeqId = input.ReadInt64();
            break;
          }
          case 24: {
            RetryCount = input.ReadUInt32();
            break;
          }
          case 34: {
            PayloadData = input.ReadBytes();
            break;
          }
          case 42: {
            if (userInstance_ == null) {
              UserInstance = new global::AcFunDanmu.Im.Basic.UserInstance();
            }
            input.ReadMessage(UserInstance);
            break;
          }
          case 48: {
            ErrorCode = input.ReadInt32();
            break;
          }
          case 58: {
            if (settingInfo_ == null) {
              SettingInfo = new global::AcFunDanmu.Im.Basic.SettingInfo();
            }
            input.ReadMessage(SettingInfo);
            break;
          }
          case 66: {
            if (requestBasicInfo_ == null) {
              RequestBasicInfo = new global::AcFunDanmu.Im.Basic.RequsetBasicInfo();
            }
            input.ReadMessage(RequestBasicInfo);
            break;
          }
          case 74: {
            SubBiz = input.ReadString();
            break;
          }
          case 82: {
            if (frontendInfo_ == null) {
              FrontendInfo = new global::AcFunDanmu.Im.Basic.FrontendInfo();
            }
            input.ReadMessage(FrontendInfo);
            break;
          }
          case 90: {
            Kpn = input.ReadString();
            break;
          }
          case 96: {
            AnonymouseUser = input.ReadBool();
            break;
          }
          case 106: {
            LaneId = input.ReadString();
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
            Command = input.ReadString();
            break;
          }
          case 16: {
            SeqId = input.ReadInt64();
            break;
          }
          case 24: {
            RetryCount = input.ReadUInt32();
            break;
          }
          case 34: {
            PayloadData = input.ReadBytes();
            break;
          }
          case 42: {
            if (userInstance_ == null) {
              UserInstance = new global::AcFunDanmu.Im.Basic.UserInstance();
            }
            input.ReadMessage(UserInstance);
            break;
          }
          case 48: {
            ErrorCode = input.ReadInt32();
            break;
          }
          case 58: {
            if (settingInfo_ == null) {
              SettingInfo = new global::AcFunDanmu.Im.Basic.SettingInfo();
            }
            input.ReadMessage(SettingInfo);
            break;
          }
          case 66: {
            if (requestBasicInfo_ == null) {
              RequestBasicInfo = new global::AcFunDanmu.Im.Basic.RequsetBasicInfo();
            }
            input.ReadMessage(RequestBasicInfo);
            break;
          }
          case 74: {
            SubBiz = input.ReadString();
            break;
          }
          case 82: {
            if (frontendInfo_ == null) {
              FrontendInfo = new global::AcFunDanmu.Im.Basic.FrontendInfo();
            }
            input.ReadMessage(FrontendInfo);
            break;
          }
          case 90: {
            Kpn = input.ReadString();
            break;
          }
          case 96: {
            AnonymouseUser = input.ReadBool();
            break;
          }
          case 106: {
            LaneId = input.ReadString();
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
