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

    // TB_Payment_Newsletter
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbPaymentNewsletter : Entity<Guid>
    {
        public string NewsletterId { get; set; } // NewsletterID (Primary key) (length: 50)
        public string PaymentApplyId { get; set; } // PaymentApplyID (length: 50)
        public int? Sort { get; set; } // Sort
        public string UserId { get; set; } // UserID (length: 50)
        public string UserName { get; set; } // UserName (length: 50)
        public string Overview { get; set; } // Overview (length: 1000)
        public int? MonthCount { get; set; } // MonthCount
        public decimal? Amount { get; set; } // Amount
        public decimal? AvgAmount { get; set; } // AvgAmount
        public string ReimbursementCriteria { get; set; } // ReimbursementCriteria (length: 1000)
        public string ExcessiveDesc { get; set; } // ExcessiveDesc (length: 1000)
        public decimal? Subtotal { get; set; } // Subtotal
        public string CreateUser { get; set; } // CreateUser (length: 50)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string UpdateUser { get; set; } // UpdateUser (length: 50)
        public System.DateTime? UpdateDate { get; set; } // UpdateDate

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