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

    // TB_Budget_Plan_CostCenter_YearDetail_V1
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbBudgetPlanCostCenterYearDetailV1 : Entity<Guid>
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

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Reverse navigation

        /// <summary>
        /// Child TbBudgetPlanCostCenterMonthDetailV1 where [TB_Budget_Plan_CostCenter_MonthDetail_V1].[YearDetailID] point to this entity (RefTB_Budget_Plan_CostCenter_YearDetail_V11081)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanCostCenterMonthDetailV1> TbBudgetPlanCostCenterMonthDetailV1 { get; set; } // TB_Budget_Plan_CostCenter_MonthDetail_V1.RefTB_Budget_Plan_CostCenter_YearDetail_V11081

        // Foreign keys

        /// <summary>
        /// Parent TbBudgetPlanCostCenterV1 pointed by [TB_Budget_Plan_CostCenter_YearDetail_V1].([BpCostCenterId]) (RefTB_Budget_Plan_CostCenter_V11071)
        /// </summary>
        public virtual TbBudgetPlanCostCenterV1 TbBudgetPlanCostCenterV1 { get; set; } // RefTB_Budget_Plan_CostCenter_V11071

        public TbBudgetPlanCostCenterYearDetailV1()
        {
            TbBudgetPlanCostCenterMonthDetailV1 = new System.Collections.Generic.List<TbBudgetPlanCostCenterMonthDetailV1>();
        }
    }

}
// </auto-generated>
