// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace EMS.Entities
{
    using Abp.Domain.Entities;
    using System;

    // TB_Attachment
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbAttachment : Entity<Guid>
    {
        public string AttachmentId { get; set; } // AttachmentID (Primary key) (length: 50)
        public string ForeignKey { get; set; } // ForeignKey (length: 50)
        public string AttachmentName { get; set; } // AttachmentName (length: 50)
        public string AttachmentSuffix { get; set; } // AttachmentSuffix (length: 10)
        public string AttachmentUrl { get; set; } // AttachmentUrl (length: 100)
        public System.DateTime UploadDate { get; set; } // UploadDate
        public string UploadUser { get; set; } // UploadUser (length: 50)
        public int AttachmenType { get; set; } // AttachmenType
        public int? AttachmenSmallType { get; set; } // AttachmenSmallType
        public int UploadAttachmenType { get; set; } // UploadAttachmenType

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }



    }

}
// </auto-generated>