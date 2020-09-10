// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LiveFeatureState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from LiveFeatureState.proto</summary>
  public static partial class LiveFeatureStateReflection {

    #region Descriptor
    /// <summary>File descriptor for LiveFeatureState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LiveFeatureStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZMaXZlRmVhdHVyZVN0YXRlLnByb3RvEgpBY0Z1bkRhbm11Ip0CChBMaXZl",
            "RmVhdHVyZVN0YXRlEjYKBHR5cGUYASABKA4yKC5BY0Z1bkRhbm11LkxpdmVG",
            "ZWF0dXJlU3RhdGUuRmVhdHVyZVR5cGUSOAoFc3RhdGUYAiABKA4yKS5BY0Z1",
            "bkRhbm11LkxpdmVGZWF0dXJlU3RhdGUuRmVhdHVyZVN0YXRlIjkKC0ZlYXR1",
            "cmVUeXBlEhMKD0ZFQVRVUkVfVU5LTk9XThAAEhUKEUxBTkRTQ0FQRV9DT01N",
            "RU5UEAEiXAoMRmVhdHVyZVN0YXRlEhkKFUZFQVRVUkVfU1RBVEVfVU5LTk9X",
            "ThAAEhcKE0ZFQVRVUkVfU1RBVEVfT1BFTkQQARIYChRGRUFUVVJFX1NUQVRF",
            "X0NMT1NFRBACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.LiveFeatureState), global::AcFunDanmu.LiveFeatureState.Parser, new[]{ "Type", "State" }, null, new[]{ typeof(global::AcFunDanmu.LiveFeatureState.Types.FeatureType), typeof(global::AcFunDanmu.LiveFeatureState.Types.FeatureState) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LiveFeatureState : pb::IMessage<LiveFeatureState>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LiveFeatureState> _parser = new pb::MessageParser<LiveFeatureState>(() => new LiveFeatureState());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LiveFeatureState> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.LiveFeatureStateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LiveFeatureState() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LiveFeatureState(LiveFeatureState other) : this() {
      type_ = other.type_;
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LiveFeatureState Clone() {
      return new LiveFeatureState(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::AcFunDanmu.LiveFeatureState.Types.FeatureType type_ = global::AcFunDanmu.LiveFeatureState.Types.FeatureType.FeatureUnknown;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.LiveFeatureState.Types.FeatureType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 2;
    private global::AcFunDanmu.LiveFeatureState.Types.FeatureState state_ = global::AcFunDanmu.LiveFeatureState.Types.FeatureState.Unknown;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.LiveFeatureState.Types.FeatureState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LiveFeatureState);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LiveFeatureState other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::AcFunDanmu.LiveFeatureState.Types.FeatureType.FeatureUnknown) hash ^= Type.GetHashCode();
      if (State != global::AcFunDanmu.LiveFeatureState.Types.FeatureState.Unknown) hash ^= State.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Type != global::AcFunDanmu.LiveFeatureState.Types.FeatureType.FeatureUnknown) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (State != global::AcFunDanmu.LiveFeatureState.Types.FeatureState.Unknown) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Type != global::AcFunDanmu.LiveFeatureState.Types.FeatureType.FeatureUnknown) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (State != global::AcFunDanmu.LiveFeatureState.Types.FeatureState.Unknown) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != global::AcFunDanmu.LiveFeatureState.Types.FeatureType.FeatureUnknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (State != global::AcFunDanmu.LiveFeatureState.Types.FeatureState.Unknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LiveFeatureState other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::AcFunDanmu.LiveFeatureState.Types.FeatureType.FeatureUnknown) {
        Type = other.Type;
      }
      if (other.State != global::AcFunDanmu.LiveFeatureState.Types.FeatureState.Unknown) {
        State = other.State;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            Type = (global::AcFunDanmu.LiveFeatureState.Types.FeatureType) input.ReadEnum();
            break;
          }
          case 16: {
            State = (global::AcFunDanmu.LiveFeatureState.Types.FeatureState) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Type = (global::AcFunDanmu.LiveFeatureState.Types.FeatureType) input.ReadEnum();
            break;
          }
          case 16: {
            State = (global::AcFunDanmu.LiveFeatureState.Types.FeatureState) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the LiveFeatureState message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum FeatureType {
        [pbr::OriginalName("FEATURE_UNKNOWN")] FeatureUnknown = 0,
        [pbr::OriginalName("LANDSCAPE_COMMENT")] LandscapeComment = 1,
      }

      public enum FeatureState {
        [pbr::OriginalName("FEATURE_STATE_UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("FEATURE_STATE_OPEND")] Opend = 1,
        [pbr::OriginalName("FEATURE_STATE_CLOSED")] Closed = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code