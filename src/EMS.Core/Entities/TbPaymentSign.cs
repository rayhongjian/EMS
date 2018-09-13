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

    // TB_Payment_Sign
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbPaymentSign : Entity<Guid>
    {
        public string PaymentSignId { get; set; } // PaymentSignID (Primary key) (length: 50)
        public string PaymentApplyId { get; set; } // PaymentApplyID (length: 50)
        public string OrgUnitGuid { get; set; } // OrgUnitGUID (length: 50)
        public string OrgUnitName { get; set; } // OrgUnitName (length: 50)
        public string CostCenterId { get; set; } // CostCenterID (length: 50)
        public string CostCenterName { get; set; } // CostCenterName (length: 50)
        public string BudgetItemId { get; set; } // BudgetItemID (length: 50)
        public string BudgetItemName { get; set; } // BudgetItemName (length: 50)
        public string PayBankName { get; set; } // PayBankName (length: 50)
        public string PayAccount { get; set; } // PayAccount (length: 50)
        public string Cbankaccountid { get; set; } // Cbankaccountid (length: 50)
        public decimal? PayAmount { get; set; } // PayAmount
        public string PayWay { get; set; } // PayWay (length: 50)
        public string PayWayName { get; set; } // PayWayName (length: 50)
        public System.DateTime? PayDate { get; set; } // PayDate
        public string PayDesc { get; set; } // PayDesc (length: 1000)
        public string Creator { get; set; } // Creator (length: 50)
        public string CreatorName { get; set; } // CreatorName (length: 50)
        public string CreatorDeptId { get; set; } // CreatorDeptID (length: 50)
        public string CreatorDeptName { get; set; } // CreatorDeptName (length: 50)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string F1 { get; set; } // F1 (length: 1000)
        public string F2 { get; set; } // F2 (length: 1000)
        public string F3 { get; set; } // F3 (length: 10)
        public int? IsGenerated { get; set; } // IsGenerated

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Foreign keys

        /// <summary>
        /// Parent TbOrganizationUnit pointed by [TB_Payment_Sign].([OrgUnitGuid]) (RefTB_OrganizationUnit82)
        /// </summary>
        public virtual TbOrganizationUnit TbOrganizationUnit { get; set; } // RefTB_OrganizationUnit82
    }

}
// </auto-generated>