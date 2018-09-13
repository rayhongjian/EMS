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

    // TB_Budget_Plan_Version
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbBudgetPlanVersion : Entity<Guid>
    {
        public string VersionId { get; set; } // VersionID (Primary key) (length: 50)
        public string VersionTypeId { get; set; } // VersionTypeID (length: 50)
        public string VersionTypeName { get; set; } // VersionTypeName (length: 50)
        public string YearId { get; set; } // YearID (length: 50)
        public int? Year { get; set; } // Year
        public string OrgUnitGuid { get; set; } // OrgUnitGUID (length: 50)
        public string OrgUnitName { get; set; } // OrgUnitName (length: 50)
        public string BudgetTypeId { get; set; } // BudgetTypeID (length: 50)
        public string BudgetTypeName { get; set; } // BudgetTypeName (length: 50)
        public string VersionDesc { get; set; } // VersionDesc (length: 1000)
        public int? Status { get; set; } // Status
        public int? ProcInstId { get; set; } // ProcInstID
        public string LatestApprover { get; set; } // LatestApprover (length: 50)
        public string LatestComment { get; set; } // LatestComment (length: 1000)
        public System.DateTime? LatestApproveTime { get; set; } // LatestApproveTime
        public string Creator { get; set; } // Creator (length: 50)
        public string CreatorName { get; set; } // CreatorName (length: 50)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string UpdateUser { get; set; } // UpdateUser (length: 50)
        public string UpdateUserName { get; set; } // UpdateUserName (length: 50)
        public System.DateTime? UpdateDate { get; set; } // UpdateDate
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
        /// Child TbBudgetPlanCostCenters where [TB_Budget_Plan_CostCenter].[VersionID] point to this entity (RefTB_Budget_Plan_Version41)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanCostCenter> TbBudgetPlanCostCenters { get; set; } // TB_Budget_Plan_CostCenter.RefTB_Budget_Plan_Version41

        // Foreign keys

        /// <summary>
        /// Parent TbBudgetType pointed by [TB_Budget_Plan_Version].([BudgetTypeId]) (RefTB_BudgetType32)
        /// </summary>
        public virtual TbBudgetType TbBudgetType { get; set; } // RefTB_BudgetType32

        /// <summary>
        /// Parent TbOrganizationUnit pointed by [TB_Budget_Plan_Version].([OrgUnitGuid]) (RefTB_OrganizationUnit31)
        /// </summary>
        public virtual TbOrganizationUnit TbOrganizationUnit { get; set; } // RefTB_OrganizationUnit31

        public TbBudgetPlanVersion()
        {
            TbBudgetPlanCostCenters = new System.Collections.Generic.List<TbBudgetPlanCostCenter>();
        }
    }

}
// </auto-generated>
