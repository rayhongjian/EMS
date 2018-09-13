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

    // TB_Monthly_PayPlan_Budget_Item
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbMonthlyPayPlanBudgetItem : Entity<Guid>
    {
        public string BudgetItemId { get; set; } // BudgetItemID (Primary key) (length: 50)
        public string UpperBudgetItemId { get; set; } // UpperBudgetItemID (length: 50)
        public string BudgetItemCode { get; set; } // BudgetItemCode (length: 20)
        public string BudgetItemName { get; set; } // BudgetItemName (length: 50)
        public string F1 { get; set; } // F1 (length: 1000)
        public string F2 { get; set; } // F2 (length: 1000)
        public string F3 { get; set; } // F3 (length: 1000)
        public string PayPlanMainId { get; set; } // PayPlanMainID (length: 50)

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Reverse navigation

        /// <summary>
        /// Child TbMonthlyPayPlanBudgetItem1 where [TB_Monthly_PayPlan_BudgetItems].[BudgetItemID] point to this entity (RefTB_Monthly_PayPlan_Budget_Item115)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbMonthlyPayPlanBudgetItem1> TbMonthlyPayPlanBudgetItem1 { get; set; } // TB_Monthly_PayPlan_BudgetItems.RefTB_Monthly_PayPlan_Budget_Item115

        // Foreign keys

        /// <summary>
        /// Parent TbMonthlyPayPlanMain pointed by [TB_Monthly_PayPlan_Budget_Item].([PayPlanMainId]) (RefTB_Monthly_PayPlan_Main116)
        /// </summary>
        public virtual TbMonthlyPayPlanMain TbMonthlyPayPlanMain { get; set; } // RefTB_Monthly_PayPlan_Main116

        public TbMonthlyPayPlanBudgetItem()
        {
            TbMonthlyPayPlanBudgetItem1 = new System.Collections.Generic.List<TbMonthlyPayPlanBudgetItem1>();
        }
    }

}
// </auto-generated>
