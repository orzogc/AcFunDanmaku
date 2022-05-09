// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CsEvaluationMessageContent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from CsEvaluationMessageContent.proto</summary>
  public static partial class CsEvaluationMessageContentReflection {

    #region Descriptor
    /// <summary>File descriptor for CsEvaluationMessageContent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CsEvaluationMessageContentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBDc0V2YWx1YXRpb25NZXNzYWdlQ29udGVudC5wcm90bxIbQWNGdW5EYW5t",
            "dS5JbS5DbG91ZC5NZXNzYWdlIs0DChpDc0V2YWx1YXRpb25NZXNzYWdlQ29u",
            "dGVudBIQCgh0YXJnZXRJZBgBIAEoAxJiChBldmFsdWF0aW9uT3B0aW9uGAIg",
            "AygLMkguQWNGdW5EYW5tdS5JbS5DbG91ZC5NZXNzYWdlLkNzRXZhbHVhdGlv",
            "bk1lc3NhZ2VDb250ZW50LkV2YWx1YXRpb25PcHRpb24SDQoFdGl0bGUYAyAB",
            "KAka5wEKEEV2YWx1YXRpb25PcHRpb24SCwoDdXJsGAEgASgJEg8KB2dyYXlV",
            "cmwYAiABKAkSEQoJb3B0aW9uVHh0GAMgASgJEhIKCm9wdGlvblR5cGUYBCAB",
            "KAUSEAoIc2VsZWN0ZWQYBSABKAgSagoPc2Vjb25kYXJ5T3B0aW9uGAYgAygL",
            "MlEuQWNGdW5EYW5tdS5JbS5DbG91ZC5NZXNzYWdlLkNzRXZhbHVhdGlvbk1l",
            "c3NhZ2VDb250ZW50LkV2YWx1YXRpb25TZWNvbmRhcnlPcHRpb24SEAoIc3Vi",
            "VGl0bGUYByABKAkaQAoZRXZhbHVhdGlvblNlY29uZGFyeU9wdGlvbhIQCghz",
            "ZWxlY3RlZBgBIAEoCBIRCglvcHRpb25UeHQYAiABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent), global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Parser, new[]{ "TargetId", "EvaluationOption", "Title" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationOption), global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationOption.Parser, new[]{ "Url", "GrayUrl", "OptionTxt", "OptionType", "Selected", "SecondaryOption", "SubTitle" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationSecondaryOption), global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationSecondaryOption.Parser, new[]{ "Selected", "OptionTxt" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CsEvaluationMessageContent : pb::IMessage<CsEvaluationMessageContent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CsEvaluationMessageContent> _parser = new pb::MessageParser<CsEvaluationMessageContent>(() => new CsEvaluationMessageContent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CsEvaluationMessageContent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CsEvaluationMessageContent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CsEvaluationMessageContent(CsEvaluationMessageContent other) : this() {
      targetId_ = other.targetId_;
      evaluationOption_ = other.evaluationOption_.Clone();
      title_ = other.title_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CsEvaluationMessageContent Clone() {
      return new CsEvaluationMessageContent(this);
    }

    /// <summary>Field number for the "targetId" field.</summary>
    public const int TargetIdFieldNumber = 1;
    private long targetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long TargetId {
      get { return targetId_; }
      set {
        targetId_ = value;
      }
    }

    /// <summary>Field number for the "evaluationOption" field.</summary>
    public const int EvaluationOptionFieldNumber = 2;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationOption> _repeated_evaluationOption_codec
        = pb::FieldCodec.ForMessage(18, global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationOption.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationOption> evaluationOption_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationOption>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationOption> EvaluationOption {
      get { return evaluationOption_; }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 3;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CsEvaluationMessageContent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CsEvaluationMessageContent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TargetId != other.TargetId) return false;
      if(!evaluationOption_.Equals(other.evaluationOption_)) return false;
      if (Title != other.Title) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TargetId != 0L) hash ^= TargetId.GetHashCode();
      hash ^= evaluationOption_.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
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
      if (TargetId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(TargetId);
      }
      evaluationOption_.WriteTo(output, _repeated_evaluationOption_codec);
      if (Title.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Title);
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
      if (TargetId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(TargetId);
      }
      evaluationOption_.WriteTo(ref output, _repeated_evaluationOption_codec);
      if (Title.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Title);
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
      if (TargetId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TargetId);
      }
      size += evaluationOption_.CalculateSize(_repeated_evaluationOption_codec);
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CsEvaluationMessageContent other) {
      if (other == null) {
        return;
      }
      if (other.TargetId != 0L) {
        TargetId = other.TargetId;
      }
      evaluationOption_.Add(other.evaluationOption_);
      if (other.Title.Length != 0) {
        Title = other.Title;
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
            TargetId = input.ReadInt64();
            break;
          }
          case 18: {
            evaluationOption_.AddEntriesFrom(input, _repeated_evaluationOption_codec);
            break;
          }
          case 26: {
            Title = input.ReadString();
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
            TargetId = input.ReadInt64();
            break;
          }
          case 18: {
            evaluationOption_.AddEntriesFrom(ref input, _repeated_evaluationOption_codec);
            break;
          }
          case 26: {
            Title = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CsEvaluationMessageContent message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class EvaluationOption : pb::IMessage<EvaluationOption>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<EvaluationOption> _parser = new pb::MessageParser<EvaluationOption>(() => new EvaluationOption());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<EvaluationOption> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public EvaluationOption() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public EvaluationOption(EvaluationOption other) : this() {
          url_ = other.url_;
          grayUrl_ = other.grayUrl_;
          optionTxt_ = other.optionTxt_;
          optionType_ = other.optionType_;
          selected_ = other.selected_;
          secondaryOption_ = other.secondaryOption_.Clone();
          subTitle_ = other.subTitle_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public EvaluationOption Clone() {
          return new EvaluationOption(this);
        }

        /// <summary>Field number for the "url" field.</summary>
        public const int UrlFieldNumber = 1;
        private string url_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Url {
          get { return url_; }
          set {
            url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "grayUrl" field.</summary>
        public const int GrayUrlFieldNumber = 2;
        private string grayUrl_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string GrayUrl {
          get { return grayUrl_; }
          set {
            grayUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "optionTxt" field.</summary>
        public const int OptionTxtFieldNumber = 3;
        private string optionTxt_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string OptionTxt {
          get { return optionTxt_; }
          set {
            optionTxt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "optionType" field.</summary>
        public const int OptionTypeFieldNumber = 4;
        private int optionType_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int OptionType {
          get { return optionType_; }
          set {
            optionType_ = value;
          }
        }

        /// <summary>Field number for the "selected" field.</summary>
        public const int SelectedFieldNumber = 5;
        private bool selected_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Selected {
          get { return selected_; }
          set {
            selected_ = value;
          }
        }

        /// <summary>Field number for the "secondaryOption" field.</summary>
        public const int SecondaryOptionFieldNumber = 6;
        private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationSecondaryOption> _repeated_secondaryOption_codec
            = pb::FieldCodec.ForMessage(50, global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationSecondaryOption.Parser);
        private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationSecondaryOption> secondaryOption_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationSecondaryOption>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Types.EvaluationSecondaryOption> SecondaryOption {
          get { return secondaryOption_; }
        }

        /// <summary>Field number for the "subTitle" field.</summary>
        public const int SubTitleFieldNumber = 7;
        private string subTitle_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string SubTitle {
          get { return subTitle_; }
          set {
            subTitle_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as EvaluationOption);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(EvaluationOption other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Url != other.Url) return false;
          if (GrayUrl != other.GrayUrl) return false;
          if (OptionTxt != other.OptionTxt) return false;
          if (OptionType != other.OptionType) return false;
          if (Selected != other.Selected) return false;
          if(!secondaryOption_.Equals(other.secondaryOption_)) return false;
          if (SubTitle != other.SubTitle) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Url.Length != 0) hash ^= Url.GetHashCode();
          if (GrayUrl.Length != 0) hash ^= GrayUrl.GetHashCode();
          if (OptionTxt.Length != 0) hash ^= OptionTxt.GetHashCode();
          if (OptionType != 0) hash ^= OptionType.GetHashCode();
          if (Selected != false) hash ^= Selected.GetHashCode();
          hash ^= secondaryOption_.GetHashCode();
          if (SubTitle.Length != 0) hash ^= SubTitle.GetHashCode();
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
          if (Url.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Url);
          }
          if (GrayUrl.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(GrayUrl);
          }
          if (OptionTxt.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(OptionTxt);
          }
          if (OptionType != 0) {
            output.WriteRawTag(32);
            output.WriteInt32(OptionType);
          }
          if (Selected != false) {
            output.WriteRawTag(40);
            output.WriteBool(Selected);
          }
          secondaryOption_.WriteTo(output, _repeated_secondaryOption_codec);
          if (SubTitle.Length != 0) {
            output.WriteRawTag(58);
            output.WriteString(SubTitle);
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
          if (Url.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Url);
          }
          if (GrayUrl.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(GrayUrl);
          }
          if (OptionTxt.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(OptionTxt);
          }
          if (OptionType != 0) {
            output.WriteRawTag(32);
            output.WriteInt32(OptionType);
          }
          if (Selected != false) {
            output.WriteRawTag(40);
            output.WriteBool(Selected);
          }
          secondaryOption_.WriteTo(ref output, _repeated_secondaryOption_codec);
          if (SubTitle.Length != 0) {
            output.WriteRawTag(58);
            output.WriteString(SubTitle);
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
          if (Url.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
          }
          if (GrayUrl.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(GrayUrl);
          }
          if (OptionTxt.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(OptionTxt);
          }
          if (OptionType != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(OptionType);
          }
          if (Selected != false) {
            size += 1 + 1;
          }
          size += secondaryOption_.CalculateSize(_repeated_secondaryOption_codec);
          if (SubTitle.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(SubTitle);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(EvaluationOption other) {
          if (other == null) {
            return;
          }
          if (other.Url.Length != 0) {
            Url = other.Url;
          }
          if (other.GrayUrl.Length != 0) {
            GrayUrl = other.GrayUrl;
          }
          if (other.OptionTxt.Length != 0) {
            OptionTxt = other.OptionTxt;
          }
          if (other.OptionType != 0) {
            OptionType = other.OptionType;
          }
          if (other.Selected != false) {
            Selected = other.Selected;
          }
          secondaryOption_.Add(other.secondaryOption_);
          if (other.SubTitle.Length != 0) {
            SubTitle = other.SubTitle;
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
                Url = input.ReadString();
                break;
              }
              case 18: {
                GrayUrl = input.ReadString();
                break;
              }
              case 26: {
                OptionTxt = input.ReadString();
                break;
              }
              case 32: {
                OptionType = input.ReadInt32();
                break;
              }
              case 40: {
                Selected = input.ReadBool();
                break;
              }
              case 50: {
                secondaryOption_.AddEntriesFrom(input, _repeated_secondaryOption_codec);
                break;
              }
              case 58: {
                SubTitle = input.ReadString();
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
                Url = input.ReadString();
                break;
              }
              case 18: {
                GrayUrl = input.ReadString();
                break;
              }
              case 26: {
                OptionTxt = input.ReadString();
                break;
              }
              case 32: {
                OptionType = input.ReadInt32();
                break;
              }
              case 40: {
                Selected = input.ReadBool();
                break;
              }
              case 50: {
                secondaryOption_.AddEntriesFrom(ref input, _repeated_secondaryOption_codec);
                break;
              }
              case 58: {
                SubTitle = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

      public sealed partial class EvaluationSecondaryOption : pb::IMessage<EvaluationSecondaryOption>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<EvaluationSecondaryOption> _parser = new pb::MessageParser<EvaluationSecondaryOption>(() => new EvaluationSecondaryOption());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<EvaluationSecondaryOption> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::AcFunDanmu.Im.Cloud.Message.CsEvaluationMessageContent.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public EvaluationSecondaryOption() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public EvaluationSecondaryOption(EvaluationSecondaryOption other) : this() {
          selected_ = other.selected_;
          optionTxt_ = other.optionTxt_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public EvaluationSecondaryOption Clone() {
          return new EvaluationSecondaryOption(this);
        }

        /// <summary>Field number for the "selected" field.</summary>
        public const int SelectedFieldNumber = 1;
        private bool selected_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Selected {
          get { return selected_; }
          set {
            selected_ = value;
          }
        }

        /// <summary>Field number for the "optionTxt" field.</summary>
        public const int OptionTxtFieldNumber = 2;
        private string optionTxt_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string OptionTxt {
          get { return optionTxt_; }
          set {
            optionTxt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as EvaluationSecondaryOption);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(EvaluationSecondaryOption other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Selected != other.Selected) return false;
          if (OptionTxt != other.OptionTxt) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Selected != false) hash ^= Selected.GetHashCode();
          if (OptionTxt.Length != 0) hash ^= OptionTxt.GetHashCode();
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
          if (Selected != false) {
            output.WriteRawTag(8);
            output.WriteBool(Selected);
          }
          if (OptionTxt.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(OptionTxt);
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
          if (Selected != false) {
            output.WriteRawTag(8);
            output.WriteBool(Selected);
          }
          if (OptionTxt.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(OptionTxt);
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
          if (Selected != false) {
            size += 1 + 1;
          }
          if (OptionTxt.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(OptionTxt);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(EvaluationSecondaryOption other) {
          if (other == null) {
            return;
          }
          if (other.Selected != false) {
            Selected = other.Selected;
          }
          if (other.OptionTxt.Length != 0) {
            OptionTxt = other.OptionTxt;
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
                Selected = input.ReadBool();
                break;
              }
              case 18: {
                OptionTxt = input.ReadString();
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
                Selected = input.ReadBool();
                break;
              }
              case 18: {
                OptionTxt = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
