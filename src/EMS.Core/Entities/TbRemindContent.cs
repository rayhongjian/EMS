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

    // TB_Remind_Content
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TbRemindContent : Entity<Guid>
    {
        public string RemindContentId { get; set; } // RemindContentID (Primary key) (length: 50)
        public string RemindQueueId { get; set; } // RemindQueueID (length: 50)
        public string PersonId { get; set; } // PersonID (length: 50)
        public string Contract { get; set; } // Contract
        public int? Status { get; set; } // Status
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string CreateUser { get; set; } // CreateUser (length: 50)
        public string CreateUserName { get; set; } // CreateUserName (length: 50)
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
        /// Parent TbRemindQueue pointed by [TB_Remind_Content].([RemindQueueId]) (RefTB_Remind_Queue350)
        /// </summary>
        public virtual TbRemindQueue TbRemindQueue { get; set; } // RefTB_Remind_Queue350
    }

}
// </auto-generated>
