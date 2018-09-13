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

    // TB_Budget_Generate_bak
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbBudgetGenerateBak : Entity<Guid>
    {
        public string GenerateId { get; set; } // GenerateID (Primary key) (length: 50)
        public string MonthDetailId { get; set; } // MonthDetailID (Primary key) (length: 50)
        public decimal YearTotalAmount { get; set; } // YearTotalAmount (Primary key)
        public string FormType { get; set; } // FormType (length: 50)
        public string FormKeyWord { get; set; } // FormKeyWord (length: 50)
        public string FromDetailId { get; set; } // FromDetailID (length: 50)
        public System.DateTime CreateDate { get; set; } // CreateDate (Primary key)
        public string CreateUser { get; set; } // CreateUser (Primary key) (length: 50)
        public System.DateTime? ModfityDate { get; set; } // ModfityDate
        public string ModfityUser { get; set; } // ModfityUser (length: 50)
        public string F1 { get; set; } // F1 (length: 1000)
        public string F2 { get; set; } // F2 (length: 1000)
        public string F3 { get; set; } // F3 (length: 1000)

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