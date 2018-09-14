using System;
using Abp.Authorization.Users;
using Abp.Extensions;
using Microsoft.AspNet.Identity;

namespace EMS.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }
        public string UserLoginId { get; set; } // UserLoginID (length: 50)
        public string UserCode { get; set; } // UserCode (length: 50)
        public string UserType { get; set; } // UserType (length: 1)
        public string Email { get; set; } // Email (length: 200)
        public string MobilePhone { get; set; } // MobilePhone (length: 150)
        public string BusinessTelephone { get; set; } // BusinessTelephone (length: 50)
        public System.DateTime? BirthDay { get; set; } // BirthDay
        public string Gender { get; set; } // Gender (length: 50)
        public string Nationality { get; set; } // Nationality (length: 50)
        public string NativePlace { get; set; } // NativePlace (length: 50)
        public System.DateTime? JoinDate { get; set; } // JoinDate
        public System.DateTime? LeaveDate { get; set; } // LeaveDate
        public string Education { get; set; } // Education (length: 50)
        public string MaritalStatus { get; set; } // MaritalStatus (length: 50)
        public int? Status { get; set; } // Status
        public string Creator { get; set; } // Creator (length: 50)
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public string UpdateUser { get; set; } // UpdateUser (length: 50)
        public System.DateTime? UpdateDate { get; set; } // UpdateDate
      

        public static User CreateTenantAdminUser(int tenantId, string emailAddress, string password)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Password = new PasswordHasher().HashPassword(password)
            };

            return user;
        }
    }
}