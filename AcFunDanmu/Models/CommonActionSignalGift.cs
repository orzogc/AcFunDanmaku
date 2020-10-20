// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CommonActionSignalGift.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from CommonActionSignalGift.proto</summary>
  public static partial class CommonActionSignalGiftReflection {

    #region Descriptor
    /// <summary>File descriptor for CommonActionSignalGift.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonActionSignalGiftReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxDb21tb25BY3Rpb25TaWduYWxHaWZ0LnByb3RvEgpBY0Z1bkRhbm11GhRa",
            "dExpdmVVc2VySW5mby5wcm90bxoUWnREcmF3R2lmdEluZm8ucHJvdG8ijwIK",
            "FkNvbW1vbkFjdGlvblNpZ25hbEdpZnQSKAoEdXNlchgBIAEoCzIaLkFjRnVu",
            "RGFubXUuWnRMaXZlVXNlckluZm8SEgoKc2VuZFRpbWVNcxgCIAEoAxIOCgZn",
            "aWZ0SWQYAyABKAMSDQoFY291bnQYBCABKAUSDQoFY29tYm8YBSABKAUSDQoF",
            "dmFsdWUYBiABKAMSDwoHY29tYm9JZBgHIAEoCRIdChVzbG90RGlzcGxheUR1",
            "cmF0aW9uTXMYCCABKAMSGAoQZXhwaXJlRHVyYXRpb25NcxgJIAEoAxIwCgxk",
            "cmF3R2lmdEluZm8YCiABKAsyGi5BY0Z1bkRhbm11Llp0RHJhd0dpZnRJbmZv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.ZtLiveUserInfoReflection.Descriptor, global::AcFunDanmu.ZtDrawGiftInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.CommonActionSignalGift), global::AcFunDanmu.CommonActionSignalGift.Parser, new[]{ "User", "SendTimeMs", "GiftId", "Count", "Combo", "Value", "ComboId", "SlotDisplayDurationMs", "ExpireDurationMs", "DrawGiftInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CommonActionSignalGift : pb::IMessage<CommonActionSignalGift> {
    private static readonly pb::MessageParser<CommonActionSignalGift> _parser = new pb::MessageParser<CommonActionSignalGift>(() => new CommonActionSignalGift());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommonActionSignalGift> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.CommonActionSignalGiftReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonActionSignalGift() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonActionSignalGift(CommonActionSignalGift other) : this() {
      user_ = other.user_ != null ? other.user_.Clone() : null;
      sendTimeMs_ = other.sendTimeMs_;
      giftId_ = other.giftId_;
      count_ = other.count_;
      combo_ = other.combo_;
      value_ = other.value_;
      comboId_ = other.comboId_;
      slotDisplayDurationMs_ = other.slotDisplayDurationMs_;
      expireDurationMs_ = other.expireDurationMs_;
      drawGiftInfo_ = other.drawGiftInfo_ != null ? other.drawGiftInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonActionSignalGift Clone() {
      return new CommonActionSignalGift(this);
    }

    /// <summary>Field number for the "user" field.</summary>
    public const int UserFieldNumber = 1;
    private global::AcFunDanmu.ZtLiveUserInfo user_;
    /// <summary>
    ///userInfo
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.ZtLiveUserInfo User {
      get { return user_; }
      set {
        user_ = value;
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

    /// <summary>Field number for the "giftId" field.</summary>
    public const int GiftIdFieldNumber = 3;
    private long giftId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long GiftId {
      get { return giftId_; }
      set {
        giftId_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 4;
    private int count_;
    /// <summary>
    ///batchSize
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "combo" field.</summary>
    public const int ComboFieldNumber = 5;
    private int combo_;
    /// <summary>
    ///comboCount
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Combo {
      get { return combo_; }
      set {
        combo_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 6;
    private long value_;
    /// <summary>
    ///rank
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    /// <summary>Field number for the "comboId" field.</summary>
    public const int ComboIdFieldNumber = 7;
    private string comboId_ = "";
    /// <summary>
    ///comboKey
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ComboId {
      get { return comboId_; }
      set {
        comboId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "slotDisplayDurationMs" field.</summary>
    public const int SlotDisplayDurationMsFieldNumber = 8;
    private long slotDisplayDurationMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long SlotDisplayDurationMs {
      get { return slotDisplayDurationMs_; }
      set {
        slotDisplayDurationMs_ = value;
      }
    }

    /// <summary>Field number for the "expireDurationMs" field.</summary>
    public const int ExpireDurationMsFieldNumber = 9;
    private long expireDurationMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExpireDurationMs {
      get { return expireDurationMs_; }
      set {
        expireDurationMs_ = value;
      }
    }

    /// <summary>Field number for the "drawGiftInfo" field.</summary>
    public const int DrawGiftInfoFieldNumber = 10;
    private global::AcFunDanmu.ZtDrawGiftInfo drawGiftInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.ZtDrawGiftInfo DrawGiftInfo {
      get { return drawGiftInfo_; }
      set {
        drawGiftInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommonActionSignalGift);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommonActionSignalGift other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(User, other.User)) return false;
      if (SendTimeMs != other.SendTimeMs) return false;
      if (GiftId != other.GiftId) return false;
      if (Count != other.Count) return false;
      if (Combo != other.Combo) return false;
      if (Value != other.Value) return false;
      if (ComboId != other.ComboId) return false;
      if (SlotDisplayDurationMs != other.SlotDisplayDurationMs) return false;
      if (ExpireDurationMs != other.ExpireDurationMs) return false;
      if (!object.Equals(DrawGiftInfo, other.DrawGiftInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (user_ != null) hash ^= User.GetHashCode();
      if (SendTimeMs != 0L) hash ^= SendTimeMs.GetHashCode();
      if (GiftId != 0L) hash ^= GiftId.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
      if (Combo != 0) hash ^= Combo.GetHashCode();
      if (Value != 0L) hash ^= Value.GetHashCode();
      if (ComboId.Length != 0) hash ^= ComboId.GetHashCode();
      if (SlotDisplayDurationMs != 0L) hash ^= SlotDisplayDurationMs.GetHashCode();
      if (ExpireDurationMs != 0L) hash ^= ExpireDurationMs.GetHashCode();
      if (drawGiftInfo_ != null) hash ^= DrawGiftInfo.GetHashCode();
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
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (SendTimeMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SendTimeMs);
      }
      if (GiftId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(GiftId);
      }
      if (Count != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Count);
      }
      if (Combo != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Combo);
      }
      if (Value != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Value);
      }
      if (ComboId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ComboId);
      }
      if (SlotDisplayDurationMs != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(SlotDisplayDurationMs);
      }
      if (ExpireDurationMs != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(ExpireDurationMs);
      }
      if (drawGiftInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(DrawGiftInfo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (user_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(User);
      }
      if (SendTimeMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SendTimeMs);
      }
      if (GiftId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(GiftId);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
      }
      if (Combo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Combo);
      }
      if (Value != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Value);
      }
      if (ComboId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ComboId);
      }
      if (SlotDisplayDurationMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SlotDisplayDurationMs);
      }
      if (ExpireDurationMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpireDurationMs);
      }
      if (drawGiftInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DrawGiftInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommonActionSignalGift other) {
      if (other == null) {
        return;
      }
      if (other.user_ != null) {
        if (user_ == null) {
          User = new global::AcFunDanmu.ZtLiveUserInfo();
        }
        User.MergeFrom(other.User);
      }
      if (other.SendTimeMs != 0L) {
        SendTimeMs = other.SendTimeMs;
      }
      if (other.GiftId != 0L) {
        GiftId = other.GiftId;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.Combo != 0) {
        Combo = other.Combo;
      }
      if (other.Value != 0L) {
        Value = other.Value;
      }
      if (other.ComboId.Length != 0) {
        ComboId = other.ComboId;
      }
      if (other.SlotDisplayDurationMs != 0L) {
        SlotDisplayDurationMs = other.SlotDisplayDurationMs;
      }
      if (other.ExpireDurationMs != 0L) {
        ExpireDurationMs = other.ExpireDurationMs;
      }
      if (other.drawGiftInfo_ != null) {
        if (drawGiftInfo_ == null) {
          DrawGiftInfo = new global::AcFunDanmu.ZtDrawGiftInfo();
        }
        DrawGiftInfo.MergeFrom(other.DrawGiftInfo);
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
            if (user_ == null) {
              User = new global::AcFunDanmu.ZtLiveUserInfo();
            }
            input.ReadMessage(User);
            break;
          }
          case 16: {
            SendTimeMs = input.ReadInt64();
            break;
          }
          case 24: {
            GiftId = input.ReadInt64();
            break;
          }
          case 32: {
            Count = input.ReadInt32();
            break;
          }
          case 40: {
            Combo = input.ReadInt32();
            break;
          }
          case 48: {
            Value = input.ReadInt64();
            break;
          }
          case 58: {
            ComboId = input.ReadString();
            break;
          }
          case 64: {
            SlotDisplayDurationMs = input.ReadInt64();
            break;
          }
          case 72: {
            ExpireDurationMs = input.ReadInt64();
            break;
          }
          case 82: {
            if (drawGiftInfo_ == null) {
              DrawGiftInfo = new global::AcFunDanmu.ZtDrawGiftInfo();
            }
            input.ReadMessage(DrawGiftInfo);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
