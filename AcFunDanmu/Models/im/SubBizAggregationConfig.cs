// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SubBizAggregationConfig.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Config {

  /// <summary>Holder for reflection information generated from SubBizAggregationConfig.proto</summary>
  public static partial class SubBizAggregationConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for SubBizAggregationConfig.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SubBizAggregationConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1TdWJCaXpBZ2dyZWdhdGlvbkNvbmZpZy5wcm90bxIaQWNGdW5EYW5tdS5J",
            "bS5DbG91ZC5Db25maWciWgoXU3ViQml6QWdncmVnYXRpb25Db25maWcSFQoN",
            "bmVlZEFnZ3JlZ2F0ZRgBIAEoCBIUCgxtYXN0ZXJTdWJCaXoYAiABKAkSEgoK",
            "Y2F0ZWdvcnlJZBgDIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Config.SubBizAggregationConfig), global::AcFunDanmu.Im.Cloud.Config.SubBizAggregationConfig.Parser, new[]{ "NeedAggregate", "MasterSubBiz", "CategoryId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SubBizAggregationConfig : pb::IMessage<SubBizAggregationConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SubBizAggregationConfig> _parser = new pb::MessageParser<SubBizAggregationConfig>(() => new SubBizAggregationConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SubBizAggregationConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Config.SubBizAggregationConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubBizAggregationConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubBizAggregationConfig(SubBizAggregationConfig other) : this() {
      needAggregate_ = other.needAggregate_;
      masterSubBiz_ = other.masterSubBiz_;
      categoryId_ = other.categoryId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubBizAggregationConfig Clone() {
      return new SubBizAggregationConfig(this);
    }

    /// <summary>Field number for the "needAggregate" field.</summary>
    public const int NeedAggregateFieldNumber = 1;
    private bool needAggregate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NeedAggregate {
      get { return needAggregate_; }
      set {
        needAggregate_ = value;
      }
    }

    /// <summary>Field number for the "masterSubBiz" field.</summary>
    public const int MasterSubBizFieldNumber = 2;
    private string masterSubBiz_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MasterSubBiz {
      get { return masterSubBiz_; }
      set {
        masterSubBiz_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "categoryId" field.</summary>
    public const int CategoryIdFieldNumber = 3;
    private int categoryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CategoryId {
      get { return categoryId_; }
      set {
        categoryId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SubBizAggregationConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SubBizAggregationConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NeedAggregate != other.NeedAggregate) return false;
      if (MasterSubBiz != other.MasterSubBiz) return false;
      if (CategoryId != other.CategoryId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NeedAggregate != false) hash ^= NeedAggregate.GetHashCode();
      if (MasterSubBiz.Length != 0) hash ^= MasterSubBiz.GetHashCode();
      if (CategoryId != 0) hash ^= CategoryId.GetHashCode();
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
      if (NeedAggregate != false) {
        output.WriteRawTag(8);
        output.WriteBool(NeedAggregate);
      }
      if (MasterSubBiz.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MasterSubBiz);
      }
      if (CategoryId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(CategoryId);
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
      if (NeedAggregate != false) {
        output.WriteRawTag(8);
        output.WriteBool(NeedAggregate);
      }
      if (MasterSubBiz.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MasterSubBiz);
      }
      if (CategoryId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(CategoryId);
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
      if (NeedAggregate != false) {
        size += 1 + 1;
      }
      if (MasterSubBiz.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MasterSubBiz);
      }
      if (CategoryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CategoryId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SubBizAggregationConfig other) {
      if (other == null) {
        return;
      }
      if (other.NeedAggregate != false) {
        NeedAggregate = other.NeedAggregate;
      }
      if (other.MasterSubBiz.Length != 0) {
        MasterSubBiz = other.MasterSubBiz;
      }
      if (other.CategoryId != 0) {
        CategoryId = other.CategoryId;
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
            NeedAggregate = input.ReadBool();
            break;
          }
          case 18: {
            MasterSubBiz = input.ReadString();
            break;
          }
          case 24: {
            CategoryId = input.ReadInt32();
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
            NeedAggregate = input.ReadBool();
            break;
          }
          case 18: {
            MasterSubBiz = input.ReadString();
            break;
          }
          case 24: {
            CategoryId = input.ReadInt32();
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
