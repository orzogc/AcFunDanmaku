// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SessionAggregationType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Message {

  /// <summary>Holder for reflection information generated from SessionAggregationType.proto</summary>
  public static partial class SessionAggregationTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for SessionAggregationType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionAggregationTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTZXNzaW9uQWdncmVnYXRpb25UeXBlLnByb3RvEhVBY0Z1bkRhbm11Lklt",
            "Lk1lc3NhZ2UqXQoWU2Vzc2lvbkFnZ3JlZ2F0aW9uVHlwZRIcChhVTktOT1dO",
            "X0FHR1JFR0FUSU9OX1RZUEUQABINCglBR0dSRUdBVEUQARIWChJDQU5DRUxf",
            "QUdHUkVHQVRJT04QAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::AcFunDanmu.Im.Message.SessionAggregationType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum SessionAggregationType {
    [pbr::OriginalName("UNKNOWN_AGGREGATION_TYPE")] UnknownAggregationType = 0,
    [pbr::OriginalName("AGGREGATE")] Aggregate = 1,
    [pbr::OriginalName("CANCEL_AGGREGATION")] CancelAggregation = 2,
  }

  #endregion

}

#endregion Designer generated code
