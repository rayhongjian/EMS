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

    // TB_Monthly_PayPlan_CostCenter_Draft
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbMonthlyPayPlanCostCenterDraft : Entity<Guid>
    {
        public string PayPlanCostCenterId { get; set; } // PayPlanCostCenterID (Primary key) (length: 50)
        public string PayPlanMainId { get; set; } // PayPlanMainID (length: 50)
        public string CostCenterId { get; set; } // CostCenterID (length: 50)
        public string CostCenterName { get; set; } // CostCenterName (length: 50)
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




        // Reverse navigation

        /// <summary>
        /// Child TbMonthlyPayPlanBudgetItemsDrafts where [TB_Monthly_PayPlan_BudgetItems_Draft].[PayPlanCostCenterID] point to this entity (RefTB_Monthly_PayPlan_CostCenter_Draft97)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbMonthlyPayPlanBudgetItemsDraft> TbMonthlyPayPlanBudgetItemsDrafts { get; set; } // TB_Monthly_PayPlan_BudgetItems_Draft.RefTB_Monthly_PayPlan_CostCenter_Draft97

        // Foreign keys

        /// <summary>
        /// Parent TbCostCenter pointed by [TB_Monthly_PayPlan_CostCenter_Draft].([CostCenterId]) (RefTB_CostCenter102)
        /// </summary>
        public virtual TbCostCenter TbCostCenter { get; set; } // RefTB_CostCenter102

        /// <summary>
        /// Parent TbMonthlyPayPlanMainDraft pointed by [TB_Monthly_PayPlan_CostCenter_Draft].([PayPlanMainId]) (RefTB_Monthly_PayPlan_Main_Draft96)
        /// </summary>
        public virtual TbMonthlyPayPlanMainDraft TbMonthlyPayPlanMainDraft { get; set; } // RefTB_Monthly_PayPlan_Main_Draft96

        public TbMonthlyPayPlanCostCenterDraft()
        {
            TbMonthlyPayPlanBudgetItemsDrafts = new System.Collections.Generic.List<TbMonthlyPayPlanBudgetItemsDraft>();
        }
    }

}
// </auto-generated>