// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: B2CSessionListResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Message {

  /// <summary>Holder for reflection information generated from B2CSessionListResponse.proto</summary>
  public static partial class B2CSessionListResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for B2CSessionListResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static B2CSessionListResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxCMkNTZXNzaW9uTGlzdFJlc3BvbnNlLnByb3RvEhVBY0Z1bkRhbm11Lklt",
            "Lk1lc3NhZ2UaEUNoYXRTZXNzaW9uLnByb3RvGhBTeW5jQ29va2llLnByb3Rv",
            "IvMBChZCMkNTZXNzaW9uTGlzdFJlc3BvbnNlEjMKCnN5bmNDb29raWUYASAB",
            "KAsyHy5BY0Z1bkRhbm11LkltLkJhc2ljLlN5bmNDb29raWUSNAoIc2Vzc2lv",
            "bnMYAiADKAsyIi5BY0Z1bkRhbm11LkltLk1lc3NhZ2UuQ2hhdFNlc3Npb24S",
            "FAoMbm90RnVsbEZldGNoGAMgASgIEhIKCnNlcnZlclRpbWUYBCABKAMSFgoO",
            "Y2xlYXJMb2NhbERhdGEYBSABKAgSEgoKY2F0ZWdvcnlJZBgGIAEoBRIYChBj",
            "bGllbnREYXRhU3RhdHVzGAcgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Message.ChatSessionReflection.Descriptor, global::AcFunDanmu.Im.Basic.SyncCookieReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Message.B2CSessionListResponse), global::AcFunDanmu.Im.Message.B2CSessionListResponse.Parser, new[]{ "SyncCookie", "Sessions", "NotFullFetch", "ServerTime", "ClearLocalData", "CategoryId", "ClientDataStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class B2CSessionListResponse : pb::IMessage<B2CSessionListResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<B2CSessionListResponse> _parser = new pb::MessageParser<B2CSessionListResponse>(() => new B2CSessionListResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<B2CSessionListResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Message.B2CSessionListResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CSessionListResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CSessionListResponse(B2CSessionListResponse other) : this() {
      syncCookie_ = other.syncCookie_ != null ? other.syncCookie_.Clone() : null;
      sessions_ = other.sessions_.Clone();
      notFullFetch_ = other.notFullFetch_;
      serverTime_ = other.serverTime_;
      clearLocalData_ = other.clearLocalData_;
      categoryId_ = other.categoryId_;
      clientDataStatus_ = other.clientDataStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public B2CSessionListResponse Clone() {
      return new B2CSessionListResponse(this);
    }

    /// <summary>Field number for the "syncCookie" field.</summary>
    public const int SyncCookieFieldNumber = 1;
    private global::AcFunDanmu.Im.Basic.SyncCookie syncCookie_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Basic.SyncCookie SyncCookie {
      get { return syncCookie_; }
      set {
        syncCookie_ = value;
      }
    }

    /// <summary>Field number for the "sessions" field.</summary>
    public const int SessionsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::AcFunDanmu.Im.Message.ChatSession> _repeated_sessions_codec
        = pb::FieldCodec.ForMessage(18, global::AcFunDanmu.Im.Message.ChatSession.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.Im.Message.ChatSession> sessions_ = new pbc::RepeatedField<global::AcFunDanmu.Im.Message.ChatSession>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::AcFunDanmu.Im.Message.ChatSession> Sessions {
      get { return sessions_; }
    }

    /// <summary>Field number for the "notFullFetch" field.</summary>
    public const int NotFullFetchFieldNumber = 3;
    private bool notFullFetch_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NotFullFetch {
      get { return notFullFetch_; }
      set {
        notFullFetch_ = value;
      }
    }

    /// <summary>Field number for the "serverTime" field.</summary>
    public const int ServerTimeFieldNumber = 4;
    private long serverTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ServerTime {
      get { return serverTime_; }
      set {
        serverTime_ = value;
      }
    }

    /// <summary>Field number for the "clearLocalData" field.</summary>
    public const int ClearLocalDataFieldNumber = 5;
    private bool clearLocalData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ClearLocalData {
      get { return clearLocalData_; }
      set {
        clearLocalData_ = value;
      }
    }

    /// <summary>Field number for the "categoryId" field.</summary>
    public const int CategoryIdFieldNumber = 6;
    private int categoryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CategoryId {
      get { return categoryId_; }
      set {
        categoryId_ = value;
      }
    }

    /// <summary>Field number for the "clientDataStatus" field.</summary>
    public const int ClientDataStatusFieldNumber = 7;
    private int clientDataStatus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ClientDataStatus {
      get { return clientDataStatus_; }
      set {
        clientDataStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as B2CSessionListResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(B2CSessionListResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SyncCookie, other.SyncCookie)) return false;
      if(!sessions_.Equals(other.sessions_)) return false;
      if (NotFullFetch != other.NotFullFetch) return false;
      if (ServerTime != other.ServerTime) return false;
      if (ClearLocalData != other.ClearLocalData) return false;
      if (CategoryId != other.CategoryId) return false;
      if (ClientDataStatus != other.ClientDataStatus) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (syncCookie_ != null) hash ^= SyncCookie.GetHashCode();
      hash ^= sessions_.GetHashCode();
      if (NotFullFetch != false) hash ^= NotFullFetch.GetHashCode();
      if (ServerTime != 0L) hash ^= ServerTime.GetHashCode();
      if (ClearLocalData != false) hash ^= ClearLocalData.GetHashCode();
      if (CategoryId != 0) hash ^= CategoryId.GetHashCode();
      if (ClientDataStatus != 0) hash ^= ClientDataStatus.GetHashCode();
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
      if (syncCookie_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SyncCookie);
      }
      sessions_.WriteTo(output, _repeated_sessions_codec);
      if (NotFullFetch != false) {
        output.WriteRawTag(24);
        output.WriteBool(NotFullFetch);
      }
      if (ServerTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ServerTime);
      }
      if (ClearLocalData != false) {
        output.WriteRawTag(40);
        output.WriteBool(ClearLocalData);
      }
      if (CategoryId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(CategoryId);
      }
      if (ClientDataStatus != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(ClientDataStatus);
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
      if (syncCookie_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SyncCookie);
      }
      sessions_.WriteTo(ref output, _repeated_sessions_codec);
      if (NotFullFetch != false) {
        output.WriteRawTag(24);
        output.WriteBool(NotFullFetch);
      }
      if (ServerTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ServerTime);
      }
      if (ClearLocalData != false) {
        output.WriteRawTag(40);
        output.WriteBool(ClearLocalData);
      }
      if (CategoryId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(CategoryId);
      }
      if (ClientDataStatus != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(ClientDataStatus);
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
      if (syncCookie_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SyncCookie);
      }
      size += sessions_.CalculateSize(_repeated_sessions_codec);
      if (NotFullFetch != false) {
        size += 1 + 1;
      }
      if (ServerTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ServerTime);
      }
      if (ClearLocalData != false) {
        size += 1 + 1;
      }
      if (CategoryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CategoryId);
      }
      if (ClientDataStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ClientDataStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(B2CSessionListResponse other) {
      if (other == null) {
        return;
      }
      if (other.syncCookie_ != null) {
        if (syncCookie_ == null) {
          SyncCookie = new global::AcFunDanmu.Im.Basic.SyncCookie();
        }
        SyncCookie.MergeFrom(other.SyncCookie);
      }
      sessions_.Add(other.sessions_);
      if (other.NotFullFetch != false) {
        NotFullFetch = other.NotFullFetch;
      }
      if (other.ServerTime != 0L) {
        ServerTime = other.ServerTime;
      }
      if (other.ClearLocalData != false) {
        ClearLocalData = other.ClearLocalData;
      }
      if (other.CategoryId != 0) {
        CategoryId = other.CategoryId;
      }
      if (other.ClientDataStatus != 0) {
        ClientDataStatus = other.ClientDataStatus;
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
            if (syncCookie_ == null) {
              SyncCookie = new global::AcFunDanmu.Im.Basic.SyncCookie();
            }
            input.ReadMessage(SyncCookie);
            break;
          }
          case 18: {
            sessions_.AddEntriesFrom(input, _repeated_sessions_codec);
            break;
          }
          case 24: {
            NotFullFetch = input.ReadBool();
            break;
          }
          case 32: {
            ServerTime = input.ReadInt64();
            break;
          }
          case 40: {
            ClearLocalData = input.ReadBool();
            break;
          }
          case 48: {
            CategoryId = input.ReadInt32();
            break;
          }
          case 56: {
            ClientDataStatus = input.ReadInt32();
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
            if (syncCookie_ == null) {
              SyncCookie = new global::AcFunDanmu.Im.Basic.SyncCookie();
            }
            input.ReadMessage(SyncCookie);
            break;
          }
          case 18: {
            sessions_.AddEntriesFrom(ref input, _repeated_sessions_codec);
            break;
          }
          case 24: {
            NotFullFetch = input.ReadBool();
            break;
          }
          case 32: {
            ServerTime = input.ReadInt64();
            break;
          }
          case 40: {
            ClearLocalData = input.ReadBool();
            break;
          }
          case 48: {
            CategoryId = input.ReadInt32();
            break;
          }
          case 56: {
            ClientDataStatus = input.ReadInt32();
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
