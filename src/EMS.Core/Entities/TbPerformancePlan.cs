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

    // TB_PerformancePlan
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbPerformancePlan : Entity<Guid>
    {
        public string PerformancePlanId { get; set; } // PerformancePlanID (Primary key) (length: 50)
        public string ContractId { get; set; } // ContractID (length: 50)
        public int? RowNumber { get; set; } // RowNumber
        public string MoneyType { get; set; } // MoneyType (length: 10)
        public string MoneyTypeName { get; set; } // MoneyTypeName (length: 50)
        public string PaymentNode { get; set; } // PaymentNode (length: 10)
        public string PaymentNodeName { get; set; } // PaymentNodeName (length: 50)
        public string PaymentTerms1 { get; set; } // PaymentTerms1 (length: 100)
        public string PaymentTerms2 { get; set; } // PaymentTerms2 (length: 50)
        public string PaymentTerms3 { get; set; } // PaymentTerms3 (length: 50)
        public string PaymentCycle { get; set; } // PaymentCycle (length: 10)
        public string PaymentCycleName { get; set; } // PaymentCycleName (length: 50)
        public System.DateTime? FirstPayDate { get; set; } // FirstPayDate
        public System.DateTime? ServiceDateStart { get; set; } // ServiceDateStart
        public System.DateTime? ServiceDateEnd { get; set; } // ServiceDateEnd
        public int? PayTimes { get; set; } // PayTimes
        public int? ManDays { get; set; } // ManDays
        public decimal? Price { get; set; } // Price
        public decimal? SinglePaymentPercent { get; set; } // SinglePaymentPercent
        public decimal? TotalAmount { get; set; } // TotalAmount
        public decimal? TaxRate { get; set; } // TaxRate
        public decimal? Tax { get; set; } // Tax
        public decimal? ExcludingTax { get; set; } // ExcludingTax
        public string Remark { get; set; } // Remark (length: 500)
        public string SupplierCode { get; set; } // SupplierCode (length: 50)
        public string SupplierName { get; set; } // SupplierName (length: 100)
        public int? Status { get; set; } // Status
        public string CreateUser { get; set; } // CreateUser (length: 50)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string F1 { get; set; } // F1 (length: 1000)
        public string F2 { get; set; } // F2 (length: 1000)
        public string F3 { get; set; } // F3 (length: 1000)
        public string OriginalPerformancePlan { get; set; } // OriginalPerformancePlan (length: 50)
        public int? IsWarrantyGold { get; set; } // IsWarrantyGold

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