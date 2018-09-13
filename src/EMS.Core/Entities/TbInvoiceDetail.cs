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

    // TB_InvoiceDetail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbInvoiceDetail : Entity<Guid>
    {
        public string Id { get; set; } // ID (Primary key) (length: 50)
        public string InvoiceId { get; set; } // InvoiceID (length: 10)
        public string ServerName { get; set; } // ServerName (length: 10)
        public string Specification { get; set; } // Specification (length: 100)
        public string Unit { get; set; } // Unit (length: 50)
        public int? Count { get; set; } // Count
        public decimal? UnitPrice { get; set; } // UnitPrice
        public decimal? TotalPrice { get; set; } // TotalPrice
        public decimal? TaxRate { get; set; } // TaxRate
        public decimal? Tax { get; set; } // Tax
        public string F1 { get; set; } // F1 (length: 1000)
        public string F2 { get; set; } // F2 (length: 1000)

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Foreign keys

        /// <summary>
        /// Parent TbInvoice pointed by [TB_InvoiceDetail].([InvoiceId]) (RefTB_Invoice243)
        /// </summary>
        public virtual TbInvoice TbInvoice { get; set; } // RefTB_Invoice243
    }

}
// </auto-generated>