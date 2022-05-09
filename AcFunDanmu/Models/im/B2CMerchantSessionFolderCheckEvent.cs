// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: B2CMerchantSessionFolderCheckEvent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.SessionFolder {

  /// <summary>Holder for reflection information generated from B2CMerchantSessionFolderCheckEvent.proto</summary>
  public static partial class B2CMerchantSessionFolderCheckEventReflection {

    #region Descriptor
    /// <summary>File descriptor for B2CMerchantSessionFolderCheckEvent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static B2CMerchantSessionFolderCheckEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihCMkNNZXJjaGFudFNlc3Npb25Gb2xkZXJDaGVja0V2ZW50LnByb3RvEiFB",
            "Y0Z1bkRhbm11LkltLkNsb3VkLlNlc3Npb25Gb2xkZXIaClVzZXIucHJvdG8i",
            "iwEKIkIyQ01lcmNoYW50U2Vzc2lvbkZvbGRlckNoZWNrRXZlbnQSJwoEdXNl",
            "chgBIAEoCzIZLkFjRnVuRGFubXUuSW0uQmFzaWMuVXNlchIQCghzdWJCaXpJ",
            "ZBgCIAEoBRISCgpzeW5jT2Zmc2V0GAMgASgDEhYKDmxhc3RVcGRhdGVUaW1l",
            "GAQgASgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Basic.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.SessionFolder.B2CMerchantSessionFolderCheckEvent), global::AcFunDanmu.Im.Cloud.SessionFolder.B2CMerchantSessionFolderCheckEvent.Parser, new[]{ "User", "SubBizId", "SyncOffset", "LastUpdateTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class B2CMerchantSessionFolderCheckEvent : pb::IMessage<B2CMerchantSessionFolderCheckEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<B2CMerchantSessionFolderCheckEvent> _parser = new pb::MessageParser<B2CMerchantSessionFolderCheckEvent>(() => new B2CMerchantSessionFolderCheckEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<B2CMerchantSessionFolderCheckEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.SessionFolder.B2CMerchantSessionFolderCheckEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CMerchantSessionFolderCheckEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CMerchantSessionFolderCheckEvent(B2CMerchantSessionFolderCheckEvent other) : this() {
      user_ = other.user_ != null ? other.user_.Clone() : null;
      subBizId_ = other.subBizId_;
      syncOffset_ = other.syncOffset_;
      lastUpdateTime_ = other.lastUpdateTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CMerchantSessionFolderCheckEvent Clone() {
      return new B2CMerchantSessionFolderCheckEvent(this);
    }

    /// <summary>Field number for the "user" field.</summary>
    public const int UserFieldNumber = 1;
    private global::AcFunDanmu.Im.Basic.User user_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.User User {
      get { return user_; }
      set {
        user_ = value;
      }
    }

    /// <summary>Field number for the "subBizId" field.</summary>
    public const int SubBizIdFieldNumber = 2;
    private int subBizId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SubBizId {
      get { return subBizId_; }
      set {
        subBizId_ = value;
      }
    }

    /// <summary>Field number for the "syncOffset" field.</summary>
    public const int SyncOffsetFieldNumber = 3;
    private long syncOffset_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long SyncOffset {
      get { return syncOffset_; }
      set {
        syncOffset_ = value;
      }
    }

    /// <summary>Field number for the "lastUpdateTime" field.</summary>
    public const int LastUpdateTimeFieldNumber = 4;
    private long lastUpdateTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long LastUpdateTime {
      get { return lastUpdateTime_; }
      set {
        lastUpdateTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as B2CMerchantSessionFolderCheckEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(B2CMerchantSessionFolderCheckEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(User, other.User)) return false;
      if (SubBizId != other.SubBizId) return false;
      if (SyncOffset != other.SyncOffset) return false;
      if (LastUpdateTime != other.LastUpdateTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (user_ != null) hash ^= User.GetHashCode();
      if (SubBizId != 0) hash ^= SubBizId.GetHashCode();
      if (SyncOffset != 0L) hash ^= SyncOffset.GetHashCode();
      if (LastUpdateTime != 0L) hash ^= LastUpdateTime.GetHashCode();
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
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (SubBizId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(SubBizId);
      }
      if (SyncOffset != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(SyncOffset);
      }
      if (LastUpdateTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(LastUpdateTime);
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
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (SubBizId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(SubBizId);
      }
      if (SyncOffset != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(SyncOffset);
      }
      if (LastUpdateTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(LastUpdateTime);
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
      if (user_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(User);
      }
      if (SubBizId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SubBizId);
      }
      if (SyncOffset != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SyncOffset);
      }
      if (LastUpdateTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastUpdateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(B2CMerchantSessionFolderCheckEvent other) {
      if (other == null) {
        return;
      }
      if (other.user_ != null) {
        if (user_ == null) {
          User = new global::AcFunDanmu.Im.Basic.User();
        }
        User.MergeFrom(other.User);
      }
      if (other.SubBizId != 0) {
        SubBizId = other.SubBizId;
      }
      if (other.SyncOffset != 0L) {
        SyncOffset = other.SyncOffset;
      }
      if (other.LastUpdateTime != 0L) {
        LastUpdateTime = other.LastUpdateTime;
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
            if (user_ == null) {
              User = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 16: {
            SubBizId = input.ReadInt32();
            break;
          }
          case 24: {
            SyncOffset = input.ReadInt64();
            break;
          }
          case 32: {
            LastUpdateTime = input.ReadInt64();
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
            if (user_ == null) {
              User = new global::AcFunDanmu.Im.Basic.User();
            }
            input.ReadMessage(User);
            break;
          }
          case 16: {
            SubBizId = input.ReadInt32();
            break;
          }
          case 24: {
            SyncOffset = input.ReadInt64();
            break;
          }
          case 32: {
            LastUpdateTime = input.ReadInt64();
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
