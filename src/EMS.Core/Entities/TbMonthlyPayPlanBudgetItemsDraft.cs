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

    // TB_Monthly_PayPlan_BudgetItems_Draft
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbMonthlyPayPlanBudgetItemsDraft : Entity<Guid>
    {
        public string PayPlanBudgetItemId { get; set; } // PayPlanBudgetItemID (Primary key) (length: 50)
        public string PayPlanCostCenterId { get; set; } // PayPlanCostCenterID (length: 50)
        public string BudgetItemId { get; set; } // BudgetItemID (length: 50)
        public string BudgetItemName { get; set; } // BudgetItemName (length: 50)
        public string ReimbursedName { get; set; } // ReimbursedName (length: 100)
        public decimal? PlanPayAmount { get; set; } // PlanPayAmount
        public System.DateTime? PlanPayDate { get; set; } // PlanPayDate
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
        /// Parent TbBudgetItem pointed by [TB_Monthly_PayPlan_BudgetItems_Draft].([BudgetItemId]) (RefTB_Budget_Item103)
        /// </summary>
        public virtual TbBudgetItem TbBudgetItem { get; set; } // RefTB_Budget_Item103

        /// <summary>
        /// Parent TbMonthlyPayPlanCostCenterDraft pointed by [TB_Monthly_PayPlan_BudgetItems_Draft].([PayPlanCostCenterId]) (RefTB_Monthly_PayPlan_CostCenter_Draft97)
        /// </summary>
        public virtual TbMonthlyPayPlanCostCenterDraft TbMonthlyPayPlanCostCenterDraft { get; set; } // RefTB_Monthly_PayPlan_CostCenter_Draft97
    }

}
// </auto-generated>
