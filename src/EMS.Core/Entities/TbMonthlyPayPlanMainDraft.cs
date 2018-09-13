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

    // TB_Monthly_PayPlan_Main_Draft
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbMonthlyPayPlanMainDraft : Entity<Guid>
    {
        public string PayPlanMainId { get; set; } // PayPlanMainID (Primary key) (length: 50)
        public string YearId { get; set; } // YearID (length: 50)
        public int? Year { get; set; } // Year
        public int? Month { get; set; } // Month
        public string OrgUnitGuid { get; set; } // OrgUnitGUID (length: 50)
        public string OrgUnitName { get; set; } // OrgUnitName (length: 50)
        public string Desc { get; set; } // Desc (length: 1000)
        public int? Status { get; set; } // Status
        public int? ProcInstId { get; set; } // ProcInstID
        public string LatestApprover { get; set; } // LatestApprover (length: 50)
        public string LatestComment { get; set; } // LatestComment (length: 1000)
        public System.DateTime? LatestApproveTime { get; set; } // LatestApproveTime
        public string Creator { get; set; } // Creator (length: 50)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string CreatorDeptName { get; set; } // CreatorDeptName (length: 50)
        public string UpdateUser { get; set; } // UpdateUser (length: 50)
        public System.DateTime? UpdateDate { get; set; } // UpdateDate
        public string UpdateUserDeptName { get; set; } // UpdateUserDeptName (length: 50)
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
        /// Child TbMonthlyPayPlanCostCenterDrafts where [TB_Monthly_PayPlan_CostCenter_Draft].[PayPlanMainID] point to this entity (RefTB_Monthly_PayPlan_Main_Draft96)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbMonthlyPayPlanCostCenterDraft> TbMonthlyPayPlanCostCenterDrafts { get; set; } // TB_Monthly_PayPlan_CostCenter_Draft.RefTB_Monthly_PayPlan_Main_Draft96

        // Foreign keys

        /// <summary>
        /// Parent TbOrganizationUnit pointed by [TB_Monthly_PayPlan_Main_Draft].([OrgUnitGuid]) (RefTB_OrganizationUnit100)
        /// </summary>
        public virtual TbOrganizationUnit TbOrganizationUnit { get; set; } // RefTB_OrganizationUnit100

        /// <summary>
        /// Parent TbYear pointed by [TB_Monthly_PayPlan_Main_Draft].([YearId]) (RefTB_Year99)
        /// </summary>
        public virtual TbYear TbYear { get; set; } // RefTB_Year99

        public TbMonthlyPayPlanMainDraft()
        {
            TbMonthlyPayPlanCostCenterDrafts = new System.Collections.Generic.List<TbMonthlyPayPlanCostCenterDraft>();
        }
    }

}
// </auto-generated>