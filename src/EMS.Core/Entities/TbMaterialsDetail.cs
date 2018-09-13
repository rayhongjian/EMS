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

    // TB_Materials_Detail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbMaterialsDetail : Entity<Guid>
    {
        public string MaterialsDetailId { get; set; } // MaterialsDetailId (Primary key) (length: 50)
        public string BusinessExecutionId { get; set; } // BusinessExecutionID (length: 50)
        public System.DateTime? ServiceStartDate { get; set; } // ServiceStartDate
        public System.DateTime? ServiceEndDate { get; set; } // ServiceEndDate
        public string MaterialsDetailName { get; set; } // MaterialsDetailName (length: 100)
        public int? Quantity { get; set; } // Quantity
        public decimal? Price { get; set; } // Price
        public decimal? RemainingAmount { get; set; } // RemainingAmount
        public int? UnusedCount { get; set; } // UnusedCount
        public string Remark { get; set; } // Remark (length: 500)
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




        // Foreign keys

        /// <summary>
        /// Parent TbBusinessExecution pointed by [TB_Materials_Detail].([BusinessExecutionId]) (RefTB_BusinessExecution340)
        /// </summary>
        public virtual TbBusinessExecution TbBusinessExecution { get; set; } // RefTB_BusinessExecution340
    }

}
// </auto-generated>
