// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DeviceInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from DeviceInfo.proto</summary>
  public static partial class DeviceInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DeviceInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeviceInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBEZXZpY2VJbmZvLnByb3RvEgpBY0Z1bkRhbm11IpkDCgpEZXZpY2VJbmZv",
            "EjkKDHBsYXRmb3JtVHlwZRgBIAEoDjIjLkFjRnVuRGFubXUuRGV2aWNlSW5m",
            "by5QbGF0Zm9ybVR5cGUSEQoJb3NWZXJzaW9uGAIgASgJEhMKC2RldmljZU1v",
            "ZGVsGAMgASgJEg8KB2ltZWlNZDUYBCABKAwSEAoIZGV2aWNlSWQYBSABKAkS",
            "DwoHc29mdERpZBgGIAEoCRIPCgdrd2FpRGlkGAcgASgJEhQKDG1hbnVmYWN0",
            "dXJlchgIIAEoCRISCgpkZXZpY2VOYW1lGAkgASgJIrgBCgxQbGF0Zm9ybVR5",
            "cGUSDAoIa0ludmFsaWQQABIMCghrQW5kcm9pZBABEggKBGtpT1MQAhIMCghr",
            "V2luZG93cxADEhIKDldFQ0hBVF9BTkRST0lEEAQSDgoKV0VDSEFUX0lPUxAF",
            "EgYKAkg1EAYSDgoKSDVfQU5EUk9JRBAHEgoKBkg1X0lPUxAIEg4KCkg1X1dJ",
            "TkRPV1MQCRIKCgZINV9NQUMQChIQCgxrUGxhdGZvcm1OdW0QC2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.DeviceInfo), global::AcFunDanmu.DeviceInfo.Parser, new[]{ "PlatformType", "OsVersion", "DeviceModel", "ImeiMd5", "DeviceId", "SoftDid", "KwaiDid", "Manufacturer", "DeviceName" }, null, new[]{ typeof(global::AcFunDanmu.DeviceInfo.Types.PlatformType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DeviceInfo : pb::IMessage<DeviceInfo> {
    private static readonly pb::MessageParser<DeviceInfo> _parser = new pb::MessageParser<DeviceInfo>(() => new DeviceInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeviceInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.DeviceInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceInfo(DeviceInfo other) : this() {
      platformType_ = other.platformType_;
      osVersion_ = other.osVersion_;
      deviceModel_ = other.deviceModel_;
      imeiMd5_ = other.imeiMd5_;
      deviceId_ = other.deviceId_;
      softDid_ = other.softDid_;
      kwaiDid_ = other.kwaiDid_;
      manufacturer_ = other.manufacturer_;
      deviceName_ = other.deviceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceInfo Clone() {
      return new DeviceInfo(this);
    }

    /// <summary>Field number for the "platformType" field.</summary>
    public const int PlatformTypeFieldNumber = 1;
    private global::AcFunDanmu.DeviceInfo.Types.PlatformType platformType_ = global::AcFunDanmu.DeviceInfo.Types.PlatformType.KInvalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.DeviceInfo.Types.PlatformType PlatformType {
      get { return platformType_; }
      set {
        platformType_ = value;
      }
    }

    /// <summary>Field number for the "osVersion" field.</summary>
    public const int OsVersionFieldNumber = 2;
    private string osVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OsVersion {
      get { return osVersion_; }
      set {
        osVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deviceModel" field.</summary>
    public const int DeviceModelFieldNumber = 3;
    private string deviceModel_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceModel {
      get { return deviceModel_; }
      set {
        deviceModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "imeiMd5" field.</summary>
    public const int ImeiMd5FieldNumber = 4;
    private pb::ByteString imeiMd5_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ImeiMd5 {
      get { return imeiMd5_; }
      set {
        imeiMd5_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deviceId" field.</summary>
    public const int DeviceIdFieldNumber = 5;
    private string deviceId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceId {
      get { return deviceId_; }
      set {
        deviceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "softDid" field.</summary>
    public const int SoftDidFieldNumber = 6;
    private string softDid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SoftDid {
      get { return softDid_; }
      set {
        softDid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "kwaiDid" field.</summary>
    public const int KwaiDidFieldNumber = 7;
    private string kwaiDid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KwaiDid {
      get { return kwaiDid_; }
      set {
        kwaiDid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "manufacturer" field.</summary>
    public const int ManufacturerFieldNumber = 8;
    private string manufacturer_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Manufacturer {
      get { return manufacturer_; }
      set {
        manufacturer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deviceName" field.</summary>
    public const int DeviceNameFieldNumber = 9;
    private string deviceName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceName {
      get { return deviceName_; }
      set {
        deviceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeviceInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeviceInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlatformType != other.PlatformType) return false;
      if (OsVersion != other.OsVersion) return false;
      if (DeviceModel != other.DeviceModel) return false;
      if (ImeiMd5 != other.ImeiMd5) return false;
      if (DeviceId != other.DeviceId) return false;
      if (SoftDid != other.SoftDid) return false;
      if (KwaiDid != other.KwaiDid) return false;
      if (Manufacturer != other.Manufacturer) return false;
      if (DeviceName != other.DeviceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlatformType != global::AcFunDanmu.DeviceInfo.Types.PlatformType.KInvalid) hash ^= PlatformType.GetHashCode();
      if (OsVersion.Length != 0) hash ^= OsVersion.GetHashCode();
      if (DeviceModel.Length != 0) hash ^= DeviceModel.GetHashCode();
      if (ImeiMd5.Length != 0) hash ^= ImeiMd5.GetHashCode();
      if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
      if (SoftDid.Length != 0) hash ^= SoftDid.GetHashCode();
      if (KwaiDid.Length != 0) hash ^= KwaiDid.GetHashCode();
      if (Manufacturer.Length != 0) hash ^= Manufacturer.GetHashCode();
      if (DeviceName.Length != 0) hash ^= DeviceName.GetHashCode();
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
      if (PlatformType != global::AcFunDanmu.DeviceInfo.Types.PlatformType.KInvalid) {
        output.WriteRawTag(8);
        output.WriteEnum((int) PlatformType);
      }
      if (OsVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OsVersion);
      }
      if (DeviceModel.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DeviceModel);
      }
      if (ImeiMd5.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(ImeiMd5);
      }
      if (DeviceId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DeviceId);
      }
      if (SoftDid.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(SoftDid);
      }
      if (KwaiDid.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(KwaiDid);
      }
      if (Manufacturer.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Manufacturer);
      }
      if (DeviceName.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(DeviceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlatformType != global::AcFunDanmu.DeviceInfo.Types.PlatformType.KInvalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PlatformType);
      }
      if (OsVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OsVersion);
      }
      if (DeviceModel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceModel);
      }
      if (ImeiMd5.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ImeiMd5);
      }
      if (DeviceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceId);
      }
      if (SoftDid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SoftDid);
      }
      if (KwaiDid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KwaiDid);
      }
      if (Manufacturer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Manufacturer);
      }
      if (DeviceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeviceInfo other) {
      if (other == null) {
        return;
      }
      if (other.PlatformType != global::AcFunDanmu.DeviceInfo.Types.PlatformType.KInvalid) {
        PlatformType = other.PlatformType;
      }
      if (other.OsVersion.Length != 0) {
        OsVersion = other.OsVersion;
      }
      if (other.DeviceModel.Length != 0) {
        DeviceModel = other.DeviceModel;
      }
      if (other.ImeiMd5.Length != 0) {
        ImeiMd5 = other.ImeiMd5;
      }
      if (other.DeviceId.Length != 0) {
        DeviceId = other.DeviceId;
      }
      if (other.SoftDid.Length != 0) {
        SoftDid = other.SoftDid;
      }
      if (other.KwaiDid.Length != 0) {
        KwaiDid = other.KwaiDid;
      }
      if (other.Manufacturer.Length != 0) {
        Manufacturer = other.Manufacturer;
      }
      if (other.DeviceName.Length != 0) {
        DeviceName = other.DeviceName;
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
          case 8: {
            PlatformType = (global::AcFunDanmu.DeviceInfo.Types.PlatformType) input.ReadEnum();
            break;
          }
          case 18: {
            OsVersion = input.ReadString();
            break;
          }
          case 26: {
            DeviceModel = input.ReadString();
            break;
          }
          case 34: {
            ImeiMd5 = input.ReadBytes();
            break;
          }
          case 42: {
            DeviceId = input.ReadString();
            break;
          }
          case 50: {
            SoftDid = input.ReadString();
            break;
          }
          case 58: {
            KwaiDid = input.ReadString();
            break;
          }
          case 66: {
            Manufacturer = input.ReadString();
            break;
          }
          case 74: {
            DeviceName = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DeviceInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum PlatformType {
        [pbr::OriginalName("kInvalid")] KInvalid = 0,
        [pbr::OriginalName("kAndroid")] KAndroid = 1,
        [pbr::OriginalName("kiOS")] KiOs = 2,
        [pbr::OriginalName("kWindows")] KWindows = 3,
        [pbr::OriginalName("WECHAT_ANDROID")] WechatAndroid = 4,
        [pbr::OriginalName("WECHAT_IOS")] WechatIos = 5,
        [pbr::OriginalName("H5")] H5 = 6,
        [pbr::OriginalName("H5_ANDROID")] H5Android = 7,
        [pbr::OriginalName("H5_IOS")] H5Ios = 8,
        [pbr::OriginalName("H5_WINDOWS")] H5Windows = 9,
        [pbr::OriginalName("H5_MAC")] H5Mac = 10,
        [pbr::OriginalName("kPlatformNum")] KPlatformNum = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
