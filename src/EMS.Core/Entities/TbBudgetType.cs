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

    // TB_BudgetType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbBudgetType : Entity<Guid>
    {
        public string BudgetTypeId { get; set; } // BudgetTypeID (Primary key) (length: 50)
        public string BudgetTypeCode { get; set; } // BudgetTypeCode (length: 20)
        public string BudgetTypeName { get; set; } // BudgetTypeName (length: 50)
        public string Description { get; set; } // Description (length: 1000)
        public int? IsInvalid { get; set; } // IsInvalid
        public System.DateTime? AvailabilityDate { get; set; } // AvailabilityDate
        public System.DateTime? ExpiryDate { get; set; } // ExpiryDate
        public int? IsPlan { get; set; } // IsPlan
        public string Creator { get; set; } // Creator (length: 50)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string UpdateUser { get; set; } // UpdateUser (length: 50)
        public System.DateTime? UpdateDate { get; set; } // UpdateDate
        public string F1 { get; set; } // F1 (length: 1000)
        public string F2 { get; set; } // F2 (length: 1000)
        public string F3 { get; set; } // F3 (length: 1000)
        public int? OrderIndex { get; set; } // OrderIndex
        public string ManageType { get; set; } // ManageType (length: 10)

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Reverse navigation

        /// <summary>
        /// Child TbBudgetPlanVersions where [TB_Budget_Plan_Version].[BudgetTypeID] point to this entity (RefTB_BudgetType32)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanVersion> TbBudgetPlanVersions { get; set; } // TB_Budget_Plan_Version.RefTB_BudgetType32
        /// <summary>
        /// Child TbBudgetPlanVersionV1 where [TB_Budget_Plan_Version_V1].[BudgetTypeID] point to this entity (RefTB_BudgetType301)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanVersionV1> TbBudgetPlanVersionV1 { get; set; } // TB_Budget_Plan_Version_V1.RefTB_BudgetType301
        /// <summary>
        /// Child TbBudgetPlanVersionV2 where [TB_Budget_Plan_Version_V2].[BudgetTypeID] point to this entity (RefTB_BudgetType321)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetPlanVersionV2> TbBudgetPlanVersionV2 { get; set; } // TB_Budget_Plan_Version_V2.RefTB_BudgetType321
        /// <summary>
        /// Child TbBudgetSubTypes where [TB_BudgetSubType].[BudgetTypeID] point to this entity (RefTB_BudgetType28)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<TbBudgetSubType> TbBudgetSubTypes { get; set; } // TB_BudgetSubType.RefTB_BudgetType28

        public TbBudgetType()
        {
            TbBudgetPlanVersions = new System.Collections.Generic.List<TbBudgetPlanVersion>();
            TbBudgetPlanVersionV1 = new System.Collections.Generic.List<TbBudgetPlanVersionV1>();
            TbBudgetPlanVersionV2 = new System.Collections.Generic.List<TbBudgetPlanVersionV2>();
            TbBudgetSubTypes = new System.Collections.Generic.List<TbBudgetSubType>();
        }
    }

}
// </auto-generated>