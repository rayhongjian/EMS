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

    // TB_Budget_Accounting_Relate
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbBudgetAccountingRelate : Entity<Guid>
    {
        public string RelateId { get; set; } // RelateID (Primary key) (length: 50)
        public string BudgetItemId { get; set; } // BudgetItemID (length: 50)
        public string AccountingItemId { get; set; } // AccountingItemID (length: 50)

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Foreign keys

        /// <summary>
        /// Parent TbAccountingItem pointed by [TB_Budget_Accounting_Relate].([AccountingItemId]) (RefTB_Accounting_Items26)
        /// </summary>
        public virtual TbAccountingItem TbAccountingItem { get; set; } // RefTB_Accounting_Items26

        /// <summary>
        /// Parent TbBudgetItem pointed by [TB_Budget_Accounting_Relate].([BudgetItemId]) (RefTB_Budget_Item27)
        /// </summary>
        public virtual TbBudgetItem TbBudgetItem { get; set; } // RefTB_Budget_Item27
    }

}
// </auto-generated>