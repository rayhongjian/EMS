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

    // TB_Contract_Statistics
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbContractStatistic : Entity<Guid>
    {
        public string ContractStatisticsId { get; set; } // ContractStatisticsID (Primary key) (length: 50)
        public string ContractId { get; set; } // ContractID (length: 50)
        public string OrgUnitGuid { get; set; } // OrgUnitGUID (length: 50)
        public string OrgUnitName { get; set; } // OrgUnitName (length: 50)
        public string CostCenterCode { get; set; } // CostCenterCode (length: 50)
        public string CostCenterName { get; set; } // CostCenterName (length: 50)
        public decimal ApplyAmount { get; set; } // ApplyAmount
        public decimal? BudgetAmount { get; set; } // BudgetAmount
        public decimal? PaidAmount { get; set; } // PaidAmount
        public decimal? ApprovedNoPaidAmount { get; set; } // ApprovedNoPaidAmount
        public decimal? ApprovingApplyAmount { get; set; } // ApprovingApplyAmount
        public decimal? WaittingSubmitAmount { get; set; } // WaittingSubmitAmount
        public int? DimensionType { get; set; } // DimensionType
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
        /// Parent TbContract pointed by [TB_Contract_Statistics].([ContractId]) (RefTB_Contract84)
        /// </summary>
        public virtual TbContract TbContract { get; set; } // RefTB_Contract84
    }

}
// </auto-generated>