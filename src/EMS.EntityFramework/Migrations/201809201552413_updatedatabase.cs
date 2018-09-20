namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AbpUsers", "UserLoginId");
            DropColumn("dbo.AbpUsers", "UserCode");
            DropColumn("dbo.AbpUsers", "UserType");
            DropColumn("dbo.AbpUsers", "Email");
            DropColumn("dbo.AbpUsers", "MobilePhone");
            DropColumn("dbo.AbpUsers", "BusinessTelephone");
            DropColumn("dbo.AbpUsers", "BirthDay");
            DropColumn("dbo.AbpUsers", "Gender");
            DropColumn("dbo.AbpUsers", "Nationality");
            DropColumn("dbo.AbpUsers", "NativePlace");
            DropColumn("dbo.AbpUsers", "JoinDate");
            DropColumn("dbo.AbpUsers", "LeaveDate");
            DropColumn("dbo.AbpUsers", "Education");
            DropColumn("dbo.AbpUsers", "MaritalStatus");
            DropColumn("dbo.AbpUsers", "Status");
            DropColumn("dbo.AbpUsers", "Creator");
            DropColumn("dbo.AbpUsers", "CreateDate");
            DropColumn("dbo.AbpUsers", "UpdateUser");
            DropColumn("dbo.AbpUsers", "UpdateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AbpUsers", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.AbpUsers", "UpdateUser", c => c.String());
            AddColumn("dbo.AbpUsers", "CreateDate", c => c.DateTime());
            AddColumn("dbo.AbpUsers", "Creator", c => c.String());
            AddColumn("dbo.AbpUsers", "Status", c => c.Int());
            AddColumn("dbo.AbpUsers", "MaritalStatus", c => c.String());
            AddColumn("dbo.AbpUsers", "Education", c => c.String());
            AddColumn("dbo.AbpUsers", "LeaveDate", c => c.DateTime());
            AddColumn("dbo.AbpUsers", "JoinDate", c => c.DateTime());
            AddColumn("dbo.AbpUsers", "NativePlace", c => c.String());
            AddColumn("dbo.AbpUsers", "Nationality", c => c.String());
            AddColumn("dbo.AbpUsers", "Gender", c => c.String());
            AddColumn("dbo.AbpUsers", "BirthDay", c => c.DateTime());
            AddColumn("dbo.AbpUsers", "BusinessTelephone", c => c.String());
            AddColumn("dbo.AbpUsers", "MobilePhone", c => c.String());
            AddColumn("dbo.AbpUsers", "Email", c => c.String());
            AddColumn("dbo.AbpUsers", "UserType", c => c.String());
            AddColumn("dbo.AbpUsers", "UserCode", c => c.String());
            AddColumn("dbo.AbpUsers", "UserLoginId", c => c.String());
        }
    }
}
