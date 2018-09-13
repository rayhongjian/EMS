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

    // TB_Year
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbYear : Entity<Guid>
    {
        public string YearId { get; set; } // YearID (Primary key) (length: 50)
        public int? Year { get; set; } // Year
        public int? IsInvalid { get; set; } // IsInvalid
        public System.DateTime? AvailabilityDate { get; set; } // AvailabilityDate
        public System.DateTime? ExpiryDate { get; set; } // ExpiryDate
        public string Desc { get; set; } // Desc (length: 1000)

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Reverse navigation

        /// <summary>
        /// Child TbBudgetPlanVersionV1 where [TB_Budget_Plan_Version_V1].[YearID] point to this entity (RefTB_Year299)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanVersionV1> TbBudgetPlanVersionV1 { get; set; } // TB_Budget_Plan_Version_V1.RefTB_Year299
        /// <summary>
        /// Child TbBudgetPlanVersionV2 where [TB_Budget_Plan_Version_V2].[YearID] point to this entity (RefTB_Year401)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanVersionV2> TbBudgetPlanVersionV2 { get; set; } // TB_Budget_Plan_Version_V2.RefTB_Year401
        /// <summary>
        /// Child TbMonthlyPayPlanMains where [TB_Monthly_PayPlan_Main].[YearID] point to this entity (RefTB_Year59)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbMonthlyPayPlanMain> TbMonthlyPayPlanMains { get; set; } // TB_Monthly_PayPlan_Main.RefTB_Year59
        /// <summary>
        /// Child TbMonthlyPayPlanMainDrafts where [TB_Monthly_PayPlan_Main_Draft].[YearID] point to this entity (RefTB_Year99)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbMonthlyPayPlanMainDraft> TbMonthlyPayPlanMainDrafts { get; set; } // TB_Monthly_PayPlan_Main_Draft.RefTB_Year99
        /// <summary>
        /// Child TbPlanApplyDetails where [TB_Plan_Apply_Detail].[YearID] point to this entity (RefTB_Year324)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbPlanApplyDetail> TbPlanApplyDetails { get; set; } // TB_Plan_Apply_Detail.RefTB_Year324

        public TbYear()
        {
            TbBudgetPlanVersionV1 = new System.Collections.Generic.List<TbBudgetPlanVersionV1>();
            TbBudgetPlanVersionV2 = new System.Collections.Generic.List<TbBudgetPlanVersionV2>();
            TbMonthlyPayPlanMains = new System.Collections.Generic.List<TbMonthlyPayPlanMain>();
            TbMonthlyPayPlanMainDrafts = new System.Collections.Generic.List<TbMonthlyPayPlanMainDraft>();
            TbPlanApplyDetails = new System.Collections.Generic.List<TbPlanApplyDetail>();
        }
    }

}
// </auto-generated>
