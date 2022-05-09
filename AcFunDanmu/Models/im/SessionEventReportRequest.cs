// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SessionEventReportRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Message {

  /// <summary>Holder for reflection information generated from SessionEventReportRequest.proto</summary>
  public static partial class SessionEventReportRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for SessionEventReportRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionEventReportRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9TZXNzaW9uRXZlbnRSZXBvcnRSZXF1ZXN0LnByb3RvEhVBY0Z1bkRhbm11",
            "LkltLk1lc3NhZ2UaEkVudGVyU2Vzc2lvbi5wcm90bxoSTGVhdmVTZXNzaW9u",
            "LnByb3RvIp4BChlTZXNzaW9uRXZlbnRSZXBvcnRSZXF1ZXN0EjsKDGVudGVy",
            "U2Vzc2lvbhgBIAEoCzIjLkFjRnVuRGFubXUuSW0uTWVzc2FnZS5FbnRlclNl",
            "c3Npb25IABI7CgxsZWF2ZVNlc3Npb24YAiABKAsyIy5BY0Z1bkRhbm11Lklt",
            "Lk1lc3NhZ2UuTGVhdmVTZXNzaW9uSABCBwoFZXZlbnRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.Im.Message.EnterSessionReflection.Descriptor, global::AcFunDanmu.Im.Message.LeaveSessionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.Im.Message.SessionEventReportRequest), global::AcFunDanmu.Im.Message.SessionEventReportRequest.Parser, new[]{ "EnterSession", "LeaveSession" }, new[]{ "Event" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SessionEventReportRequest : pb::IMessage<SessionEventReportRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SessionEventReportRequest> _parser = new pb::MessageParser<SessionEventReportRequest>(() => new SessionEventReportRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SessionEventReportRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.Im.Message.SessionEventReportRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionEventReportRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionEventReportRequest(SessionEventReportRequest other) : this() {
      switch (other.EventCase) {
        case EventOneofCase.EnterSession:
          EnterSession = other.EnterSession.Clone();
          break;
        case EventOneofCase.LeaveSession:
          LeaveSession = other.LeaveSession.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SessionEventReportRequest Clone() {
      return new SessionEventReportRequest(this);
    }

    /// <summary>Field number for the "enterSession" field.</summary>
    public const int EnterSessionFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Message.EnterSession EnterSession {
      get { return eventCase_ == EventOneofCase.EnterSession ? (global::AcFunDanmu.Im.Message.EnterSession) event_ : null; }
      set {
        event_ = value;
        eventCase_ = value == null ? EventOneofCase.None : EventOneofCase.EnterSession;
      }
    }

    /// <summary>Field number for the "leaveSession" field.</summary>
    public const int LeaveSessionFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AcFunDanmu.Im.Message.LeaveSession LeaveSession {
      get { return eventCase_ == EventOneofCase.LeaveSession ? (global::AcFunDanmu.Im.Message.LeaveSession) event_ : null; }
      set {
        event_ = value;
        eventCase_ = value == null ? EventOneofCase.None : EventOneofCase.LeaveSession;
      }
    }

    private object event_;
    /// <summary>Enum of possible cases for the "event" oneof.</summary>
    public enum EventOneofCase {
      None = 0,
      EnterSession = 1,
      LeaveSession = 2,
    }
    private EventOneofCase eventCase_ = EventOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventOneofCase EventCase {
      get { return eventCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEvent() {
      eventCase_ = EventOneofCase.None;
      event_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SessionEventReportRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SessionEventReportRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EnterSession, other.EnterSession)) return false;
      if (!object.Equals(LeaveSession, other.LeaveSession)) return false;
      if (EventCase != other.EventCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (eventCase_ == EventOneofCase.EnterSession) hash ^= EnterSession.GetHashCode();
      if (eventCase_ == EventOneofCase.LeaveSession) hash ^= LeaveSession.GetHashCode();
      hash ^= (int) eventCase_;
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
      if (eventCase_ == EventOneofCase.EnterSession) {
        output.WriteRawTag(10);
        output.WriteMessage(EnterSession);
      }
      if (eventCase_ == EventOneofCase.LeaveSession) {
        output.WriteRawTag(18);
        output.WriteMessage(LeaveSession);
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
      if (eventCase_ == EventOneofCase.EnterSession) {
        output.WriteRawTag(10);
        output.WriteMessage(EnterSession);
      }
      if (eventCase_ == EventOneofCase.LeaveSession) {
        output.WriteRawTag(18);
        output.WriteMessage(LeaveSession);
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
      if (eventCase_ == EventOneofCase.EnterSession) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnterSession);
      }
      if (eventCase_ == EventOneofCase.LeaveSession) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LeaveSession);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SessionEventReportRequest other) {
      if (other == null) {
        return;
      }
      switch (other.EventCase) {
        case EventOneofCase.EnterSession:
          if (EnterSession == null) {
            EnterSession = new global::AcFunDanmu.Im.Message.EnterSession();
          }
          EnterSession.MergeFrom(other.EnterSession);
          break;
        case EventOneofCase.LeaveSession:
          if (LeaveSession == null) {
            LeaveSession = new global::AcFunDanmu.Im.Message.LeaveSession();
          }
          LeaveSession.MergeFrom(other.LeaveSession);
          break;
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
            global::AcFunDanmu.Im.Message.EnterSession subBuilder = new global::AcFunDanmu.Im.Message.EnterSession();
            if (eventCase_ == EventOneofCase.EnterSession) {
              subBuilder.MergeFrom(EnterSession);
            }
            input.ReadMessage(subBuilder);
            EnterSession = subBuilder;
            break;
          }
          case 18: {
            global::AcFunDanmu.Im.Message.LeaveSession subBuilder = new global::AcFunDanmu.Im.Message.LeaveSession();
            if (eventCase_ == EventOneofCase.LeaveSession) {
              subBuilder.MergeFrom(LeaveSession);
            }
            input.ReadMessage(subBuilder);
            LeaveSession = subBuilder;
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
            global::AcFunDanmu.Im.Message.EnterSession subBuilder = new global::AcFunDanmu.Im.Message.EnterSession();
            if (eventCase_ == EventOneofCase.EnterSession) {
              subBuilder.MergeFrom(EnterSession);
            }
            input.ReadMessage(subBuilder);
            EnterSession = subBuilder;
            break;
          }
          case 18: {
            global::AcFunDanmu.Im.Message.LeaveSession subBuilder = new global::AcFunDanmu.Im.Message.LeaveSession();
            if (eventCase_ == EventOneofCase.LeaveSession) {
              subBuilder.MergeFrom(LeaveSession);
            }
            input.ReadMessage(subBuilder);
            LeaveSession = subBuilder;
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
