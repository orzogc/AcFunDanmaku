// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InvitePermissionType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu.Im.Cloud.Message {

  /// <summary>Holder for reflection information generated from InvitePermissionType.proto</summary>
  public static partial class InvitePermissionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for InvitePermissionType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InvitePermissionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpJbnZpdGVQZXJtaXNzaW9uVHlwZS5wcm90bxIbQWNGdW5EYW5tdS5JbS5D",
            "bG91ZC5NZXNzYWdlKlgKFEludml0ZVBlcm1pc3Npb25UeXBlEiIKHlVOS05P",
            "V05fSU5WSVRFX1BFUk1JU1NJT05fVFlQRRAAEgwKCEVWRVJZT05FEAESDgoK",
            "T05MWV9BRE1JThACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::AcFunDanmu.Im.Cloud.Message.InvitePermissionType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum InvitePermissionType {
    [pbr::OriginalName("UNKNOWN_INVITE_PERMISSION_TYPE")] UnknownInvitePermissionType = 0,
    [pbr::OriginalName("EVERYONE")] Everyone = 1,
    [pbr::OriginalName("ONLY_ADMIN")] OnlyAdmin = 2,
  }

  #endregion

}

#endregion Designer generated code