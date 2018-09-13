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

    // TB_Budget_Plan_CostCenter_V3
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbBudgetPlanCostCenterV3 : Entity<Guid>
    {
        public string BpCostCenterId { get; set; } // BP_CostCenterID (Primary key) (length: 50)
        public string VersionId { get; set; } // VersionID (length: 50)
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
        /// Child TbBudgetPlanCostCenterYearDetailV3 where [TB_Budget_Plan_CostCenter_YearDetail_V3].[BP_CostCenterID] point to this entity (RefTB_Budget_Plan_CostCenter_V32161)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanCostCenterYearDetailV3> TbBudgetPlanCostCenterYearDetailV3 { get; set; } // TB_Budget_Plan_CostCenter_YearDetail_V3.RefTB_Budget_Plan_CostCenter_V32161

        public TbBudgetPlanCostCenterV3()
        {
            TbBudgetPlanCostCenterYearDetailV3 = new System.Collections.Generic.List<TbBudgetPlanCostCenterYearDetailV3>();
        }
    }

}
// </auto-generated>
