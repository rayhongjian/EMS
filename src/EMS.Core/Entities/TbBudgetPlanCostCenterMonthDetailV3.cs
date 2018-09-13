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

    // TB_Budget_Plan_CostCenter_MonthDetail_V3
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbBudgetPlanCostCenterMonthDetailV3 : Entity<Guid>
    {
        public string MonthDetailId { get; set; } // MonthDetailID (Primary key) (length: 50)
        public string BudgetItemId { get; set; } // BudgetItemID (length: 50)
        public decimal? TotalAmount { get; set; } // TotalAmount
        public decimal? FirstQuarterAmount { get; set; } // FirstQuarterAmount
        public decimal? SecondQuarterAmount { get; set; } // SecondQuarterAmount
        public decimal? ThirdQuarterAmount { get; set; } // ThirdQuarterAmount
        public decimal? FourthQuarterAmount { get; set; } // FourthQuarterAmount
        public decimal? Month1 { get; set; } // Month1
        public decimal? Month2 { get; set; } // Month2
        public decimal? Month3 { get; set; } // Month3
        public decimal? Month4 { get; set; } // Month4
        public decimal? Month5 { get; set; } // Month5
        public decimal? Month6 { get; set; } // Month6
        public decimal? Month7 { get; set; } // Month7
        public decimal? Month8 { get; set; } // Month8
        public decimal? Month9 { get; set; } // Month9
        public decimal? Month10 { get; set; } // Month10
        public decimal? Month11 { get; set; } // Month11
        public decimal? Month12 { get; set; } // Month12
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
        /// Parent TbBudgetPlanCostCenterYearDetailV3 pointed by [TB_Budget_Plan_CostCenter_MonthDetail_V3].([BudgetItemId]) (RefTB_Budget_Plan_CostCenter_YearDetail_V32201)
        /// </summary>
        public virtual TbBudgetPlanCostCenterYearDetailV3 TbBudgetPlanCostCenterYearDetailV3 { get; set; } // RefTB_Budget_Plan_CostCenter_YearDetail_V32201
    }

}
// </auto-generated>