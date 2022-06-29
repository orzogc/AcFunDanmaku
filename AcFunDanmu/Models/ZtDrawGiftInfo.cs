// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ZtDrawGiftInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from ZtDrawGiftInfo.proto</summary>
  public static partial class ZtDrawGiftInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ZtDrawGiftInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ZtDrawGiftInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRadERyYXdHaWZ0SW5mby5wcm90bxIKQWNGdW5EYW5tdSL6AQoOWnREcmF3",
            "R2lmdEluZm8SEwoLc2NyZWVuV2lkdGgYASABKAMSFAoMc2NyZWVuSGVpZ2h0",
            "GAIgASgDEjkKCWRyYXdQb2ludBgDIAMoCzImLkFjRnVuRGFubXUuWnREcmF3",
            "R2lmdEluZm8uWnREcmF3UG9pbnQagQEKC1p0RHJhd1BvaW50EhIKCm1hcmdp",
            "bkxlZnQYASABKAMSEQoJbWFyZ2luVG9wGAIgASgDEhIKCnNjYWxlUmF0aW8Y",
            "AyABKAESDgoGaGFuZHVwGAQgASgIEhIKCnBvaW50V2lkdGgYBSABKAMSEwoL",
            "cG9pbnRIZWlnaHQYBiABKANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.ZtDrawGiftInfo), global::AcFunDanmu.ZtDrawGiftInfo.Parser, new[]{ "ScreenWidth", "ScreenHeight", "DrawPoint" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.ZtDrawGiftInfo.Types.ZtDrawPoint), global::AcFunDanmu.ZtDrawGiftInfo.Types.ZtDrawPoint.Parser, new[]{ "MarginLeft", "MarginTop", "ScaleRatio", "Handup", "PointWidth", "PointHeight" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ZtDrawGiftInfo : pb::IMessage<ZtDrawGiftInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ZtDrawGiftInfo> _parser = new pb::MessageParser<ZtDrawGiftInfo>(() => new ZtDrawGiftInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ZtDrawGiftInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.ZtDrawGiftInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ZtDrawGiftInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ZtDrawGiftInfo(ZtDrawGiftInfo other) : this() {
      screenWidth_ = other.screenWidth_;
      screenHeight_ = other.screenHeight_;
      drawPoint_ = other.drawPoint_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ZtDrawGiftInfo Clone() {
      return new ZtDrawGiftInfo(this);
    }

    /// <summary>Field number for the "screenWidth" field.</summary>
    public const int ScreenWidthFieldNumber = 1;
    private long screenWidth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ScreenWidth {
      get { return screenWidth_; }
      set {
        screenWidth_ = value;
      }
    }

    /// <summary>Field number for the "screenHeight" field.</summary>
    public const int ScreenHeightFieldNumber = 2;
    private long screenHeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ScreenHeight {
      get { return screenHeight_; }
      set {
        screenHeight_ = value;
      }
    }

    /// <summary>Field number for the "drawPoint" field.</summary>
    public const int DrawPointFieldNumber = 3;
    private static readonly pb::FieldCodec<global::AcFunDanmu.ZtDrawGiftInfo.Types.ZtDrawPoint> _repeated_drawPoint_codec
        = pb::FieldCodec.ForMessage(26, global::AcFunDanmu.ZtDrawGiftInfo.Types.ZtDrawPoint.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.ZtDrawGiftInfo.Types.ZtDrawPoint> drawPoint_ = new pbc::RepeatedField<global::AcFunDanmu.ZtDrawGiftInfo.Types.ZtDrawPoint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.ZtDrawGiftInfo.Types.ZtDrawPoint> DrawPoint {
      get { return drawPoint_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ZtDrawGiftInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ZtDrawGiftInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ScreenWidth != other.ScreenWidth) return false;
      if (ScreenHeight != other.ScreenHeight) return false;
      if(!drawPoint_.Equals(other.drawPoint_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ScreenWidth != 0L) hash ^= ScreenWidth.GetHashCode();
      if (ScreenHeight != 0L) hash ^= ScreenHeight.GetHashCode();
      hash ^= drawPoint_.GetHashCode();
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
      if (ScreenWidth != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ScreenWidth);
      }
      if (ScreenHeight != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ScreenHeight);
      }
      drawPoint_.WriteTo(output, _repeated_drawPoint_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ScreenWidth != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ScreenWidth);
      }
      if (ScreenHeight != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ScreenHeight);
      }
      drawPoint_.WriteTo(ref output, _repeated_drawPoint_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ScreenWidth != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ScreenWidth);
      }
      if (ScreenHeight != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ScreenHeight);
      }
      size += drawPoint_.CalculateSize(_repeated_drawPoint_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ZtDrawGiftInfo other) {
      if (other == null) {
        return;
      }
      if (other.ScreenWidth != 0L) {
        ScreenWidth = other.ScreenWidth;
      }
      if (other.ScreenHeight != 0L) {
        ScreenHeight = other.ScreenHeight;
      }
      drawPoint_.Add(other.drawPoint_);
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
            ScreenWidth = input.ReadInt64();
            break;
          }
          case 16: {
            ScreenHeight = input.ReadInt64();
            break;
          }
          case 26: {
            drawPoint_.AddEntriesFrom(input, _repeated_drawPoint_codec);
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
            ScreenWidth = input.ReadInt64();
            break;
          }
          case 16: {
            ScreenHeight = input.ReadInt64();
            break;
          }
          case 26: {
            drawPoint_.AddEntriesFrom(ref input, _repeated_drawPoint_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ZtDrawGiftInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class ZtDrawPoint : pb::IMessage<ZtDrawPoint>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<ZtDrawPoint> _parser = new pb::MessageParser<ZtDrawPoint>(() => new ZtDrawPoint());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<ZtDrawPoint> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::AcFunDanmu.ZtDrawGiftInfo.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ZtDrawPoint() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ZtDrawPoint(ZtDrawPoint other) : this() {
          marginLeft_ = other.marginLeft_;
          marginTop_ = other.marginTop_;
          scaleRatio_ = other.scaleRatio_;
          handup_ = other.handup_;
          pointWidth_ = other.pointWidth_;
          pointHeight_ = other.pointHeight_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ZtDrawPoint Clone() {
          return new ZtDrawPoint(this);
        }

        /// <summary>Field number for the "marginLeft" field.</summary>
        public const int MarginLeftFieldNumber = 1;
        private long marginLeft_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long MarginLeft {
          get { return marginLeft_; }
          set {
            marginLeft_ = value;
          }
        }

        /// <summary>Field number for the "marginTop" field.</summary>
        public const int MarginTopFieldNumber = 2;
        private long marginTop_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long MarginTop {
          get { return marginTop_; }
          set {
            marginTop_ = value;
          }
        }

        /// <summary>Field number for the "scaleRatio" field.</summary>
        public const int ScaleRatioFieldNumber = 3;
        private double scaleRatio_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public double ScaleRatio {
          get { return scaleRatio_; }
          set {
            scaleRatio_ = value;
          }
        }

        /// <summary>Field number for the "handup" field.</summary>
        public const int HandupFieldNumber = 4;
        private bool handup_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Handup {
          get { return handup_; }
          set {
            handup_ = value;
          }
        }

        /// <summary>Field number for the "pointWidth" field.</summary>
        public const int PointWidthFieldNumber = 5;
        private long pointWidth_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long PointWidth {
          get { return pointWidth_; }
          set {
            pointWidth_ = value;
          }
        }

        /// <summary>Field number for the "pointHeight" field.</summary>
        public const int PointHeightFieldNumber = 6;
        private long pointHeight_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long PointHeight {
          get { return pointHeight_; }
          set {
            pointHeight_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as ZtDrawPoint);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(ZtDrawPoint other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (MarginLeft != other.MarginLeft) return false;
          if (MarginTop != other.MarginTop) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ScaleRatio, other.ScaleRatio)) return false;
          if (Handup != other.Handup) return false;
          if (PointWidth != other.PointWidth) return false;
          if (PointHeight != other.PointHeight) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (MarginLeft != 0L) hash ^= MarginLeft.GetHashCode();
          if (MarginTop != 0L) hash ^= MarginTop.GetHashCode();
          if (ScaleRatio != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ScaleRatio);
          if (Handup != false) hash ^= Handup.GetHashCode();
          if (PointWidth != 0L) hash ^= PointWidth.GetHashCode();
          if (PointHeight != 0L) hash ^= PointHeight.GetHashCode();
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
          if (MarginLeft != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(MarginLeft);
          }
          if (MarginTop != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(MarginTop);
          }
          if (ScaleRatio != 0D) {
            output.WriteRawTag(25);
            output.WriteDouble(ScaleRatio);
          }
          if (Handup != false) {
            output.WriteRawTag(32);
            output.WriteBool(Handup);
          }
          if (PointWidth != 0L) {
            output.WriteRawTag(40);
            output.WriteInt64(PointWidth);
          }
          if (PointHeight != 0L) {
            output.WriteRawTag(48);
            output.WriteInt64(PointHeight);
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
          if (MarginLeft != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(MarginLeft);
          }
          if (MarginTop != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(MarginTop);
          }
          if (ScaleRatio != 0D) {
            output.WriteRawTag(25);
            output.WriteDouble(ScaleRatio);
          }
          if (Handup != false) {
            output.WriteRawTag(32);
            output.WriteBool(Handup);
          }
          if (PointWidth != 0L) {
            output.WriteRawTag(40);
            output.WriteInt64(PointWidth);
          }
          if (PointHeight != 0L) {
            output.WriteRawTag(48);
            output.WriteInt64(PointHeight);
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
          if (MarginLeft != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(MarginLeft);
          }
          if (MarginTop != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(MarginTop);
          }
          if (ScaleRatio != 0D) {
            size += 1 + 8;
          }
          if (Handup != false) {
            size += 1 + 1;
          }
          if (PointWidth != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(PointWidth);
          }
          if (PointHeight != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(PointHeight);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(ZtDrawPoint other) {
          if (other == null) {
            return;
          }
          if (other.MarginLeft != 0L) {
            MarginLeft = other.MarginLeft;
          }
          if (other.MarginTop != 0L) {
            MarginTop = other.MarginTop;
          }
          if (other.ScaleRatio != 0D) {
            ScaleRatio = other.ScaleRatio;
          }
          if (other.Handup != false) {
            Handup = other.Handup;
          }
          if (other.PointWidth != 0L) {
            PointWidth = other.PointWidth;
          }
          if (other.PointHeight != 0L) {
            PointHeight = other.PointHeight;
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
                MarginLeft = input.ReadInt64();
                break;
              }
              case 16: {
                MarginTop = input.ReadInt64();
                break;
              }
              case 25: {
                ScaleRatio = input.ReadDouble();
                break;
              }
              case 32: {
                Handup = input.ReadBool();
                break;
              }
              case 40: {
                PointWidth = input.ReadInt64();
                break;
              }
              case 48: {
                PointHeight = input.ReadInt64();
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
                MarginLeft = input.ReadInt64();
                break;
              }
              case 16: {
                MarginTop = input.ReadInt64();
                break;
              }
              case 25: {
                ScaleRatio = input.ReadDouble();
                break;
              }
              case 32: {
                Handup = input.ReadBool();
                break;
              }
              case 40: {
                PointWidth = input.ReadInt64();
                break;
              }
              case 48: {
                PointHeight = input.ReadInt64();
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
