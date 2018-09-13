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

    // TB_Block
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbBlock : Entity<Guid>
    {
        public string BlockId { get; set; } // BlockID (Primary key) (length: 50)
        public string BlockCode { get; set; } // BlockCode (length: 80)
        public string BlockName { get; set; } // BlockName (length: 50)
        public string Desc { get; set; } // Desc (length: 1000)
        public int? IsInvalid { get; set; } // IsInvalid
        public System.DateTime? AvailabilityDate { get; set; } // AvailabilityDate
        public System.DateTime? ExpiryDate { get; set; } // ExpiryDate
        public string Creator { get; set; } // Creator (length: 50)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string UpdateUser { get; set; } // UpdateUser (length: 50)
        public System.DateTime? UpdateDate { get; set; } // UpdateDate
        public string F1 { get; set; } // F1 (length: 1000)
        public string F2 { get; set; } // F2 (length: 1000)
        public string F3 { get; set; } // F3 (length: 1000)
        public string ProjectId { get; set; } // ProjectID (length: 50)
        public string UpperId { get; set; } // UpperID (length: 50)
        public int? BlockType { get; set; } // BlockType

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Reverse navigation

        /// <summary>
        /// Child TbBudgetBaseInfoRelates where [TB_BudgetBaseInfo_Relate].[BlockID] point to this entity (RefTB_Block342)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetBaseInfoRelate> TbBudgetBaseInfoRelates { get; set; } // TB_BudgetBaseInfo_Relate.RefTB_Block342
        /// <summary>
        /// Child TbBudgetPlanVersionV1 where [TB_Budget_Plan_Version_V1].[BlockID] point to this entity (RefTB_Block334)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanVersionV1> TbBudgetPlanVersionV1 { get; set; } // TB_Budget_Plan_Version_V1.RefTB_Block334
        /// <summary>
        /// Child TbBudgetPlanVersionV2 where [TB_Budget_Plan_Version_V2].[BlockID] point to this entity (RefTB_Block335)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanVersionV2> TbBudgetPlanVersionV2 { get; set; } // TB_Budget_Plan_Version_V2.RefTB_Block335
        /// <summary>
        /// Child TbPlanApplies where [TB_Plan_Apply].[BlockID] point to this entity (RefTB_Block238)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbPlanApply> TbPlanApplies { get; set; } // TB_Plan_Apply.RefTB_Block238

        public TbBlock()
        {
            TbBudgetPlanVersionV1 = new System.Collections.Generic.List<TbBudgetPlanVersionV1>();
            TbBudgetPlanVersionV2 = new System.Collections.Generic.List<TbBudgetPlanVersionV2>();
            TbBudgetBaseInfoRelates = new System.Collections.Generic.List<TbBudgetBaseInfoRelate>();
            TbPlanApplies = new System.Collections.Generic.List<TbPlanApply>();
        }
    }

}
// </auto-generated>
