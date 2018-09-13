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

    // TB_OrganizationUnit
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbOrganizationUnit : Entity<Guid>
    {
        public string OrgUnitGuid { get; set; } // OrgUnitGUID (Primary key) (length: 50)
        public string OrgUnitName { get; set; } // OrgUnitName (length: 50)
        public string UpperOrgUnitGuid { get; set; } // UpperOrgUnitGUID (length: 50)
        public string OrgUnitType { get; set; } // OrgUnitType (length: 50)
        public string OrgUnitLever { get; set; } // OrgUnitLever (length: 50)
        public int? OrderIndex { get; set; } // OrderIndex
        public string BelongDutyLine { get; set; } // BelongDutyLine (length: 50)
        public int? IsCostCenter { get; set; } // IsCostCenter
        public int? IsInvalid { get; set; } // IsInvalid
        public System.DateTime? JoinDate { get; set; } // JoinDate
        public System.DateTime? LeaveDate { get; set; } // LeaveDate
        public string Creator { get; set; } // Creator (length: 50)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string UpdateUser { get; set; } // UpdateUser (length: 50)
        public System.DateTime? UpdateDate { get; set; } // UpdateDate
        public string F1 { get; set; } // F1 (length: 1000)
        public string F2 { get; set; } // F2 (length: 1000)
        public string F3 { get; set; } // F3 (length: 1000)
        public string OrgUnitCode { get; set; } // OrgUnitCode (length: 50)
        public string ProjectId { get; set; } // ProjectID (length: 50)

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Reverse navigation

        /// <summary>
        /// Child TbBudgetPlanVersions where [TB_Budget_Plan_Version].[OrgUnitGUID] point to this entity (RefTB_OrganizationUnit31)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanVersion> TbBudgetPlanVersions { get; set; } // TB_Budget_Plan_Version.RefTB_OrganizationUnit31
        /// <summary>
        /// Child TbDeptCategoryRelates where [TB_Dept_Category_Relate].[OrgUnitGUID] point to this entity (RefTB_OrganizationUnit347)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbDeptCategoryRelate> TbDeptCategoryRelates { get; set; } // TB_Dept_Category_Relate.RefTB_OrganizationUnit347
        /// <summary>
        /// Child TbMonthlyPayPlanMains where [TB_Monthly_PayPlan_Main].[OrgUnitGUID] point to this entity (RefTB_OrganizationUnit65)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbMonthlyPayPlanMain> TbMonthlyPayPlanMains { get; set; } // TB_Monthly_PayPlan_Main.RefTB_OrganizationUnit65
        /// <summary>
        /// Child TbMonthlyPayPlanMainDrafts where [TB_Monthly_PayPlan_Main_Draft].[OrgUnitGUID] point to this entity (RefTB_OrganizationUnit100)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbMonthlyPayPlanMainDraft> TbMonthlyPayPlanMainDrafts { get; set; } // TB_Monthly_PayPlan_Main_Draft.RefTB_OrganizationUnit100
        /// <summary>
        /// Child TbOrgUserRelates where [TB_Org_User_Relate].[OrgUnitGUID] point to this entity (RefTB_OrganizationUnit4)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbOrgUserRelate> TbOrgUserRelates { get; set; } // TB_Org_User_Relate.RefTB_OrganizationUnit4
        /// <summary>
        /// Child TbPaymentSigns where [TB_Payment_Sign].[OrgUnitGUID] point to this entity (RefTB_OrganizationUnit82)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbPaymentSign> TbPaymentSigns { get; set; } // TB_Payment_Sign.RefTB_OrganizationUnit82

        public TbOrganizationUnit()
        {
            TbBudgetPlanVersions = new System.Collections.Generic.List<TbBudgetPlanVersion>();
            TbDeptCategoryRelates = new System.Collections.Generic.List<TbDeptCategoryRelate>();
            TbMonthlyPayPlanMains = new System.Collections.Generic.List<TbMonthlyPayPlanMain>();
            TbMonthlyPayPlanMainDrafts = new System.Collections.Generic.List<TbMonthlyPayPlanMainDraft>();
            TbOrgUserRelates = new System.Collections.Generic.List<TbOrgUserRelate>();
            TbPaymentSigns = new System.Collections.Generic.List<TbPaymentSign>();
        }
    }

}
// </auto-generated>
