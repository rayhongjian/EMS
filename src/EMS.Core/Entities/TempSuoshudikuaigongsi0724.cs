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

    // The table 'temp_suoshudikuaigongsi_07_24' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // temp_suoshudikuaigongsi_07_24
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TempSuoshudikuaigongsi0724 : Entity<Guid>
    {
        public string ParenetName { get; set; } // ParenetName (length: 255)
        public string ObjectName { get; set; } // ObjectName (length: 255)
        public double? TotalCode { get; set; } // TotalCode
        public string ObjectId { get; set; } // ObjectId (length: 255)
        public string ParentId { get; set; } // ParentId (length: 255)
        public string ObjectCode { get; set; } // ObjectCode (length: 255)
        public double? Generation { get; set; } // Generation
        public double? Enabled { get; set; } // Enabled
        public double? HasChildren { get; set; } // HasChildren
        public double? ObjectPosition { get; set; } // ObjectPosition
        public System.DateTime? CreateTime { get; set; } // CreateTime
        public double? ObjectType { get; set; } // ObjectType
        public string Description { get; set; } // Description (length: 255)

 //public DateTime CreationTime { get; set; }
 //public DateTime CreatorUserId { get; set; }
 //public DateTime LastModificationTime { get; set; }
 //public DateTime LastModifierUserId { get; set; }
 //public DateTime IsDeleted { get; set; }
 //public DateTime DeletionTime { get; set; }
 //public DateTime DeleterUserId { get; set; }



    }

}
// </auto-generated>
