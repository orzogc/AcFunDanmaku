// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CallType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Voice.Call {

  /// <summary>Holder for reflection information generated from CallType.proto</summary>
  public static partial class CallTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for CallType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CallTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5DYWxsVHlwZS5wcm90bxIeQWNGdW5EYW5tdS5JbS5DbG91ZC5Wb2ljZS5D",
            "YWxsKjAKCENhbGxUeXBlEg4KCkNUX1VOS05PV04QABIJCgVWT0lDRRABEgkK",
            "BVZJREVPEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::AcFunDanmu.Im.Cloud.Voice.Call.CallType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CallType {
    [pbr::OriginalName("CT_UNKNOWN")] CtUnknown = 0,
    [pbr::OriginalName("VOICE")] Voice = 1,
    [pbr::OriginalName("VIDEO")] Video = 2,
  }

  #endregion

}

#endregion Designer generated code
