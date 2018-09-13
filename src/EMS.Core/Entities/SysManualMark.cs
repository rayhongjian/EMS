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

    // SYS_Manual_Mark
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SysManualMark : Entity<Guid>
    {
        public string MarkId { get; set; } // MarkID (Primary key) (length: 50)
        public string MarkContent { get; set; } // MarkContent (length: 50)
        public string Remark { get; set; } // Remark (length: 100)
        public System.DateTime? CreateDate { get; set; } // CreateDate

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