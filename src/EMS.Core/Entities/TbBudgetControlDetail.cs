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

    // TB_Budget_Control_Detail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbBudgetControlDetail : Entity<Guid>
    {
        public string BudgetControlDetailId { get; set; } // BudgetControlDetailID (Primary key) (length: 50)
        public string BudgetControlId { get; set; } // BudgetControlID (length: 50)
        public string BudgetItemId { get; set; } // BudgetItemID (length: 50)
        public string BudgetName { get; set; } // BudgetName (length: 50)
        public string BudgetCode { get; set; } // BudgetCode (length: 50)
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
        /// Parent TbBudgetControl pointed by [TB_Budget_Control_Detail].([BudgetControlId]) (RefTB_Budget_Control166)
        /// </summary>
        public virtual TbBudgetControl TbBudgetControl { get; set; } // RefTB_Budget_Control166

        /// <summary>
        /// Parent TbBudgetItem pointed by [TB_Budget_Control_Detail].([BudgetItemId]) (RefTB_Budget_Item167)
        /// </summary>
        public virtual TbBudgetItem TbBudgetItem { get; set; } // RefTB_Budget_Item167
    }

}
// </auto-generated>