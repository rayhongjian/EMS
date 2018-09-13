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

    // TB_CostCenter_BudgetSubType_Relate
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbCostCenterBudgetSubTypeRelate : Entity<Guid>
    {
        public string RelateId { get; set; } // RelateID (Primary key) (length: 50)
        public string BudgetSubTypeId { get; set; } // BudgetSubTypeID (length: 50)
        public string CostCenterId { get; set; } // CostCenterID (length: 50)
        public System.DateTime? CreateDate { get; set; } // CreateDate

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Foreign keys

        /// <summary>
        /// Parent TbBudgetSubType pointed by [TB_CostCenter_BudgetSubType_Relate].([BudgetSubTypeId]) (RefTB_BudgetSubType35)
        /// </summary>
        public virtual TbBudgetSubType TbBudgetSubType { get; set; } // RefTB_BudgetSubType35

        /// <summary>
        /// Parent TbCostCenter pointed by [TB_CostCenter_BudgetSubType_Relate].([CostCenterId]) (RefTB_CostCenter61)
        /// </summary>
        public virtual TbCostCenter TbCostCenter { get; set; } // RefTB_CostCenter61
    }

}
// </auto-generated>
