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

    // TB_BelongBorC_Corporate_Relate
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbBelongBorCCorporateRelate : Entity<Guid>
    {
        public string RelateId { get; set; } // RelateID (Primary key) (length: 50)
        public string BelongId { get; set; } // BelongID (length: 50)
        public string CorporateGuid { get; set; } // CorporateGUID (length: 50)
        public string F1 { get; set; } // F1 (length: 50)
        public string F2 { get; set; } // F2 (length: 50)
        public string F3 { get; set; } // F3 (length: 50)

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
