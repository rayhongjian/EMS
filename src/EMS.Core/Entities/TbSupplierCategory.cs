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

    // TB_Supplier_Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbSupplierCategory : Entity<Guid>
    {
        public string CategoryId { get; set; } // CategoryID (Primary key) (length: 50)
        public string SupplierId { get; set; } // SupplierID (length: 50)
        public string Code { get; set; } // Code (length: 50)
        public string Name { get; set; } // Name (length: 50)

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }




        // Foreign keys

        /// <summary>
        /// Parent TbSupplierBasic pointed by [TB_Supplier_Category].([SupplierId]) (RefTB_Supplier_Basic252)
        /// </summary>
        public virtual TbSupplierBasic TbSupplierBasic { get; set; } // RefTB_Supplier_Basic252
    }

}
// </auto-generated>
