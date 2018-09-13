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

    // TB_Supplier_Bank
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbSupplierBank : Entity<Guid>
    {
        public string SupplierBankId { get; set; } // SupplierBankID (Primary key) (length: 50)
        public string SupplierId { get; set; } // SupplierID (length: 50)
        public string BankName { get; set; } // BankName (length: 50)
        public string City { get; set; } // City (length: 50)
        public string BankBranch { get; set; } // BankBranch (length: 100)
        public string BankAccount { get; set; } // BankAccount (length: 50)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string ParameterId { get; set; } // ParameterID (length: 50)
        public string Creator { get; set; } // Creator (length: 50)

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Foreign keys

        /// <summary>
        /// Parent TbSupplierBasic pointed by [TB_Supplier_Bank].([SupplierId]) (RefTB_Supplier_Basic228)
        /// </summary>
        public virtual TbSupplierBasic TbSupplierBasic { get; set; } // RefTB_Supplier_Basic228
    }

}
// </auto-generated>