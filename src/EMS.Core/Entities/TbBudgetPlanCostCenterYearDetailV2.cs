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

    // TB_Budget_Plan_CostCenter_YearDetail_V2
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbBudgetPlanCostCenterYearDetailV2 : Entity<Guid>
    {
        public string YearDetailId { get; set; } // YearDetailID (Primary key) (length: 50)
        public string BpCostCenterId { get; set; } // BP_CostCenterID (length: 50)
        public string UpperBudgetItemCode { get; set; } // UpperBudgetItemCode (length: 50)
        public string UpperBudgetItemName { get; set; } // UpperBudgetItemName (length: 50)
        public string BudgetItemCode { get; set; } // BudgetItemCode (length: 50)
        public string BudgetItemName { get; set; } // BudgetItemName (length: 50)
        public string F1 { get; set; } // F1 (length: 1000)
        public string F2 { get; set; } // F2 (length: 1000)
        public string F3 { get; set; } // F3 (length: 1000)
        public string BudgetItemId { get; set; } // BudgetItemID (length: 50)
        public string UpperId { get; set; } // UpperID (length: 50)
        public string T1Code { get; set; } // T1_Code (length: 50)
        public string T2Code { get; set; } // T2_Code (length: 50)
        public string T3Code { get; set; } // T3_Code (length: 50)
        public string T5Code { get; set; } // T5_Code (length: 50)
        public string T6Code { get; set; } // T6_Code (length: 50)
        public string AccountCode { get; set; } // AccountCode (length: 50)

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Reverse navigation

        /// <summary>
        /// Child TbBudgetPlanCostCenterMonthDetailV2 where [TB_Budget_Plan_CostCenter_MonthDetail_V2].[YearDetailID] point to this entity (RefTB_Budget_Plan_CostCenter_YearDetail_V22191)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanCostCenterMonthDetailV2> TbBudgetPlanCostCenterMonthDetailV2 { get; set; } // TB_Budget_Plan_CostCenter_MonthDetail_V2.RefTB_Budget_Plan_CostCenter_YearDetail_V22191

        // Foreign keys

        /// <summary>
        /// Parent TbBudgetPlanCostCenterV2 pointed by [TB_Budget_Plan_CostCenter_YearDetail_V2].([BpCostCenterId]) (RefTB_Budget_Plan_CostCenter_V21171)
        /// </summary>
        public virtual TbBudgetPlanCostCenterV2 TbBudgetPlanCostCenterV2 { get; set; } // RefTB_Budget_Plan_CostCenter_V21171

        public TbBudgetPlanCostCenterYearDetailV2()
        {
            TbBudgetPlanCostCenterMonthDetailV2 = new System.Collections.Generic.List<TbBudgetPlanCostCenterMonthDetailV2>();
        }
    }

}
// </auto-generated>