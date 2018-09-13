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

    // TB_Payment_Travel
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbPaymentTravel : Entity<Guid>
    {
        public string TravelId { get; set; } // TravelID (Primary key) (length: 50)
        public string PaymentApplyId { get; set; } // PaymentApplyID (length: 50)
        public int? Sort { get; set; } // Sort
        public string TravelArea { get; set; } // TravelArea (length: 100)
        public string TravelAreaName { get; set; } // TravelAreaName (length: 50)
        public int? TravelDay { get; set; } // TravelDay
        public decimal? TotalPrice { get; set; } // TotalPrice
        public decimal? DayOfPrice { get; set; } // DayOfPrice
        public string ReimbursementCriteria { get; set; } // ReimbursementCriteria (length: 100)
        public string ExcessiveDesc { get; set; } // ExcessiveDesc (length: 200)
        public decimal? Subtotal { get; set; } // Subtotal
        public string F1 { get; set; } // F1 (length: 1000)
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