// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ForbiddenState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from ForbiddenState.proto</summary>
  public static partial class ForbiddenStateReflection {

    #region Descriptor
    /// <summary>File descriptor for ForbiddenState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForbiddenStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRGb3JiaWRkZW5TdGF0ZS5wcm90bxIbQWNGdW5EYW5tdS5JbS5DbG91ZC5N",
            "ZXNzYWdlKlMKDkZvcmJpZGRlblN0YXRlEhsKF1VOS05PV05fRk9SQklEREVO",
            "X1NUQVRFEAASEAoMVU5fRk9SQklEREVOEAESEgoORk9SQklEX01FU1NBR0UQ",
            "AmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::AcFunDanmu.Im.Cloud.Message.ForbiddenState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ForbiddenState {
    [pbr::OriginalName("UNKNOWN_FORBIDDEN_STATE")] UnknownForbiddenState = 0,
    [pbr::OriginalName("UN_FORBIDDEN")] UnForbidden = 1,
    [pbr::OriginalName("FORBID_MESSAGE")] ForbidMessage = 2,
  }

  #endregion

}

#endregion Designer generated code