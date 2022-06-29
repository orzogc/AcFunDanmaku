// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AuthorChatPlayerInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from AuthorChatPlayerInfo.proto</summary>
  public static partial class AuthorChatPlayerInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AuthorChatPlayerInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuthorChatPlayerInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpBdXRob3JDaGF0UGxheWVySW5mby5wcm90bxIKQWNGdW5EYW5tdRoUWnRM",
            "aXZlVXNlckluZm8ucHJvdG8icgoUQXV0aG9yQ2hhdFBsYXllckluZm8SKgoG",
            "cGxheWVyGAEgASgLMhouQWNGdW5EYW5tdS5adExpdmVVc2VySW5mbxIOCgZs",
            "aXZlSWQYAiABKAkSHgoWZW5hYmxlSnVtcFBlZXJMaXZlUm9vbRgDIAEoCGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.ZtLiveUserInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.AuthorChatPlayerInfo), global::AcFunDanmu.AuthorChatPlayerInfo.Parser, new[]{ "Player", "LiveId", "EnableJumpPeerLiveRoom" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AuthorChatPlayerInfo : pb::IMessage<AuthorChatPlayerInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AuthorChatPlayerInfo> _parser = new pb::MessageParser<AuthorChatPlayerInfo>(() => new AuthorChatPlayerInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AuthorChatPlayerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.AuthorChatPlayerInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthorChatPlayerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthorChatPlayerInfo(AuthorChatPlayerInfo other) : this() {
      player_ = other.player_ != null ? other.player_.Clone() : null;
      liveId_ = other.liveId_;
      enableJumpPeerLiveRoom_ = other.enableJumpPeerLiveRoom_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AuthorChatPlayerInfo Clone() {
      return new AuthorChatPlayerInfo(this);
    }

    /// <summary>Field number for the "player" field.</summary>
    public const int PlayerFieldNumber = 1;
    private global::AcFunDanmu.ZtLiveUserInfo player_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.ZtLiveUserInfo Player {
      get { return player_; }
      set {
        player_ = value;
      }
    }

    /// <summary>Field number for the "liveId" field.</summary>
    public const int LiveIdFieldNumber = 2;
    private string liveId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LiveId {
      get { return liveId_; }
      set {
        liveId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "enableJumpPeerLiveRoom" field.</summary>
    public const int EnableJumpPeerLiveRoomFieldNumber = 3;
    private bool enableJumpPeerLiveRoom_;
    /// <summary>
    /// enableVisit
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EnableJumpPeerLiveRoom {
      get { return enableJumpPeerLiveRoom_; }
      set {
        enableJumpPeerLiveRoom_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AuthorChatPlayerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AuthorChatPlayerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Player, other.Player)) return false;
      if (LiveId != other.LiveId) return false;
      if (EnableJumpPeerLiveRoom != other.EnableJumpPeerLiveRoom) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (player_ != null) hash ^= Player.GetHashCode();
      if (LiveId.Length != 0) hash ^= LiveId.GetHashCode();
      if (EnableJumpPeerLiveRoom != false) hash ^= EnableJumpPeerLiveRoom.GetHashCode();
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
      if (player_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Player);
      }
      if (LiveId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LiveId);
      }
      if (EnableJumpPeerLiveRoom != false) {
        output.WriteRawTag(24);
        output.WriteBool(EnableJumpPeerLiveRoom);
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
      if (player_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Player);
      }
      if (LiveId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LiveId);
      }
      if (EnableJumpPeerLiveRoom != false) {
        output.WriteRawTag(24);
        output.WriteBool(EnableJumpPeerLiveRoom);
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
      if (player_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Player);
      }
      if (LiveId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LiveId);
      }
      if (EnableJumpPeerLiveRoom != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AuthorChatPlayerInfo other) {
      if (other == null) {
        return;
      }
      if (other.player_ != null) {
        if (player_ == null) {
          Player = new global::AcFunDanmu.ZtLiveUserInfo();
        }
        Player.MergeFrom(other.Player);
      }
      if (other.LiveId.Length != 0) {
        LiveId = other.LiveId;
      }
      if (other.EnableJumpPeerLiveRoom != false) {
        EnableJumpPeerLiveRoom = other.EnableJumpPeerLiveRoom;
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
            if (player_ == null) {
              Player = new global::AcFunDanmu.ZtLiveUserInfo();
            }
            input.ReadMessage(Player);
            break;
          }
          case 18: {
            LiveId = input.ReadString();
            break;
          }
          case 24: {
            EnableJumpPeerLiveRoom = input.ReadBool();
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
            if (player_ == null) {
              Player = new global::AcFunDanmu.ZtLiveUserInfo();
            }
            input.ReadMessage(Player);
            break;
          }
          case 18: {
            LiveId = input.ReadString();
            break;
          }
          case 24: {
            EnableJumpPeerLiveRoom = input.ReadBool();
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
