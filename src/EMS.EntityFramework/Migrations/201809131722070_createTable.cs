namespace EMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppApplicationInfoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AppId = c.String(),
                        AppName = c.String(),
                        AppPwd = c.String(),
                        AppLocation = c.String(),
                        AppServiceHost = c.String(),
                        AppPortalUrl = c.String(),
                        AppAdminUrl = c.String(),
                        AppPortalName = c.String(),
                        AppAdminName = c.String(),
                        AppStatus = c.Int(),
                        OrderNum = c.Int(),
                        AppInternalServiceHost = c.String(),
                        LanguageCode = c.String(),
                        DebugServiceHost = c.String(),
                        FunctionAppId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AppServiceInfoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ServiceId = c.String(),
                        AppId = c.String(),
                        ServiceCode = c.String(),
                        ServiceUrl = c.String(),
                        FunctionName = c.String(),
                        ServiceType = c.String(),
                        ServiceName = c.String(),
                        NewVersionId = c.String(),
                        Description = c.String(),
                        Explain = c.String(),
                        Status = c.Int(),
                        CacheMinutes = c.Int(),
                        ClassName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AppServiceParameters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ParamId = c.String(),
                        ServiceId = c.String(),
                        ParameterName = c.String(),
                        OrderNum = c.Int(),
                        DataType = c.String(),
                        DefaultValue = c.String(),
                        Description = c.String(),
                        Status = c.Int(),
                        AppServiceInfo_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppServiceInfoes", t => t.AppServiceInfo_Id)
                .Index(t => t.AppServiceInfo_Id);
            
            CreateTable(
                "dbo.CallInterfaces",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CallId = c.Guid(nullable: false),
                        Data = c.String(),
                        CallDate = c.DateTime(),
                        LastCallDate = c.DateTime(),
                        CallNumber = c.Int(),
                        Status = c.Int(),
                        CreateTime = c.DateTime(),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LogCloseLogs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CloseLogId = c.String(),
                        RecordTime = c.DateTime(),
                        LogType = c.String(),
                        UserId = c.String(),
                        UserName = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LogExceptonLogs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ExceptionLogId = c.String(),
                        RecordTime = c.DateTime(),
                        ExceptionMessage = c.String(),
                        OrgStackTrace = c.String(),
                        ExceptionUrl = c.String(),
                        IpAddress = c.String(),
                        UserId = c.String(),
                        UserName = c.String(),
                        ActionType = c.String(),
                        ExceptionType = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        F4 = c.String(),
                        F5 = c.String(),
                        F6 = c.String(),
                        ModuleId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LogLoginLogs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LoginLogId = c.Int(nullable: false),
                        AppId = c.String(),
                        Token = c.String(),
                        UserId = c.String(),
                        UserName = c.String(),
                        InputPassword = c.String(),
                        Result = c.Int(),
                        LoginIp = c.String(),
                        LoginTime = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        F4 = c.String(),
                        F5 = c.String(),
                        F6 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LogUseroperationLogOems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserOperationLogId = c.String(),
                        AppId = c.String(),
                        Token = c.String(),
                        UserId = c.String(),
                        UserName = c.String(),
                        TheKey = c.String(),
                        Category = c.String(),
                        ActionType = c.String(),
                        ActionDescription = c.String(),
                        ActionResult = c.String(),
                        LogTime = c.DateTime(),
                        IpAddress = c.String(),
                        ErrorCode = c.String(),
                        ExceptionMsg = c.String(),
                        DataXml = c.String(),
                        ModuleId = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        F4 = c.String(),
                        F5 = c.String(),
                        F6 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LogXmlParms",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LogXmlGuid = c.String(),
                        OrgCode = c.String(),
                        XmlParms = c.String(),
                        XmlInfo = c.String(),
                        LogTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MdmSupplierContacts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SupplierContactsGuid = c.String(),
                        Name = c.String(),
                        ContactsType = c.Int(nullable: false),
                        PaperType = c.String(),
                        PaperNumber = c.String(),
                        MobilePhone = c.String(),
                        Email = c.String(),
                        BusinessAddress = c.String(),
                        BusinessTelephone = c.String(),
                        Status = c.Int(),
                        Remark = c.String(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyUser = c.String(),
                        ModifyDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        F4 = c.String(),
                        F5 = c.String(),
                        F6 = c.String(),
                        SupplierGuid = c.String(),
                        IsSystem = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MdmSuppliers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SupplierGuid = c.String(),
                        SupplierCode = c.String(),
                        FullName = c.String(),
                        Abbreviation = c.String(),
                        Address = c.String(),
                        OrgUnitGuid = c.String(),
                        RelateCompany = c.String(),
                        SupplierType = c.String(),
                        ProfessionType = c.String(),
                        Scope = c.String(),
                        SupplierDegree = c.String(),
                        BusinessSize = c.Decimal(precision: 18, scale: 2),
                        MemberNumber = c.Int(),
                        CorporateRepresentative = c.String(),
                        BusinessNature = c.String(),
                        InstitutionCode = c.String(),
                        BusinessVolume = c.String(),
                        TaxCode = c.String(),
                        RegisterAddress = c.String(),
                        RegisterCapital = c.Decimal(precision: 18, scale: 2),
                        QualifiedDegree = c.String(),
                        ProductService = c.String(),
                        Country = c.String(),
                        Province = c.String(),
                        City = c.String(),
                        ZipCode = c.String(),
                        Telephone = c.String(),
                        Fax = c.String(),
                        BankName = c.String(),
                        BankAddress = c.String(),
                        BankAccount = c.String(),
                        Status = c.Int(),
                        Remark = c.String(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifyUser = c.String(),
                        ModifyDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        F4 = c.String(),
                        F5 = c.String(),
                        F6 = c.String(),
                        IsSystem = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OemsBudgetTypeT8Mapping",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MappingId = c.String(),
                        BudgetTypeCode = c.String(),
                        BudgetItemCode = c.String(),
                        SCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StGenerateids",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Generateid = c.Int(nullable: false),
                        Taskformtypecode = c.String(),
                        Maxid = c.Int(),
                        Iddate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysActionLists",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ActionId = c.String(),
                        ActionNameCn = c.String(),
                        ActionNameEn = c.String(),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysCities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryId = c.Int(),
                        ProvinceId = c.Int(nullable: false),
                        ProvinceAbbr = c.String(),
                        DisplayOrder = c.Int(nullable: false),
                        Abbreviation = c.String(),
                        Published = c.Boolean(nullable: false),
                        Zip = c.String(),
                        Hot = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysConfigurations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        KeyName = c.String(),
                        KeyValue = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysDataRights",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DataRightsId = c.String(),
                        RoleId = c.Int(),
                        ModuleId = c.String(),
                        DataRightsType = c.String(),
                        ProjectId = c.String(),
                        CostCenterId = c.String(),
                        BlockId = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        SysModule_Id = c.Guid(),
                        SysRole_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SysModules", t => t.SysModule_Id)
                .ForeignKey("dbo.SysRoles", t => t.SysRole_Id)
                .Index(t => t.SysModule_Id)
                .Index(t => t.SysRole_Id);
            
            CreateTable(
                "dbo.SysModules",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ModuleId = c.String(),
                        ParentModuleId = c.String(),
                        PageType = c.String(),
                        Modulerights = c.String(),
                        AppId = c.String(),
                        OrderNo = c.Int(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysModuleDetailInfoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ModuleDetailId = c.String(),
                        ModuleId = c.String(),
                        FunctionUrl = c.String(),
                        ModuleName = c.String(),
                        LanguageCode = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        SysModule_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SysModules", t => t.SysModule_Id)
                .Index(t => t.SysModule_Id);
            
            CreateTable(
                "dbo.SysRoleRights",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoleRightsId = c.String(),
                        DataRights = c.String(),
                        RightsCode = c.String(),
                        ModuleId = c.String(),
                        RoleId = c.Int(nullable: false),
                        SysModule_Id = c.Guid(),
                        SysRole_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SysModules", t => t.SysModule_Id)
                .ForeignKey("dbo.SysRoles", t => t.SysRole_Id)
                .Index(t => t.SysModule_Id)
                .Index(t => t.SysRole_Id);
            
            CreateTable(
                "dbo.SysRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoleId = c.Int(nullable: false),
                        RoleType = c.String(),
                        RoleName = c.String(),
                        Description = c.String(),
                        Status = c.String(),
                        CreateUserId = c.String(),
                        CreateDate = c.DateTime(),
                        ModifyUserId = c.String(),
                        ModifyDate = c.DateTime(),
                        IsDistrictFinance = c.Int(),
                        ModifyPaymentSignEnable = c.Int(),
                        PayEnable = c.Int(),
                        BudgetTypeIDs = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysUserRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserRoleId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        UserId = c.String(),
                        SysRole_Id = c.Guid(),
                        TbUser_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SysRoles", t => t.SysRole_Id)
                .ForeignKey("dbo.TbUsers", t => t.TbUser_Id)
                .Index(t => t.SysRole_Id)
                .Index(t => t.TbUser_Id);
            
            CreateTable(
                "dbo.TbUsers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.String(),
                        UserLoginId = c.String(),
                        Password = c.String(),
                        UserCode = c.String(),
                        UserName = c.String(),
                        UserType = c.String(),
                        Email = c.String(),
                        MobilePhone = c.String(),
                        BusinessTelephone = c.String(),
                        BirthDay = c.DateTime(),
                        Gender = c.String(),
                        Nationality = c.String(),
                        NativePlace = c.String(),
                        PaperType = c.String(),
                        PaperNumber = c.String(),
                        JoinDate = c.DateTime(),
                        LeaveDate = c.DateTime(),
                        Education = c.String(),
                        MaritalStatus = c.String(),
                        Bank = c.String(),
                        BankAccount = c.String(),
                        Status = c.Int(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        EasUserCode = c.String(),
                        EasUserName = c.String(),
                        JobOrder = c.String(),
                        BusinessLeader = c.String(),
                        BeginWorkDate = c.DateTime(),
                        PositionTemp = c.String(),
                        RankId = c.String(),
                        RankCode = c.String(),
                        RankName = c.String(),
                        ReimbursementAmount = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbOrgUserRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        OrgUnitGuid = c.String(),
                        UserId = c.String(),
                        IsMain = c.Int(),
                        TbOrganizationUnit_Id = c.Guid(),
                        TbUser_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbOrganizationUnits", t => t.TbOrganizationUnit_Id)
                .ForeignKey("dbo.TbUsers", t => t.TbUser_Id)
                .Index(t => t.TbOrganizationUnit_Id)
                .Index(t => t.TbUser_Id);
            
            CreateTable(
                "dbo.TbOrganizationUnits",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        UpperOrgUnitGuid = c.String(),
                        OrgUnitType = c.String(),
                        OrgUnitLever = c.String(),
                        OrderIndex = c.Int(),
                        BelongDutyLine = c.String(),
                        IsCostCenter = c.Int(),
                        IsInvalid = c.Int(),
                        JoinDate = c.DateTime(),
                        LeaveDate = c.DateTime(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        OrgUnitCode = c.String(),
                        ProjectId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetPlanVersions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VersionId = c.String(),
                        VersionTypeId = c.String(),
                        VersionTypeName = c.String(),
                        YearId = c.String(),
                        Year = c.Int(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        BudgetTypeId = c.String(),
                        BudgetTypeName = c.String(),
                        VersionDesc = c.String(),
                        Status = c.Int(),
                        ProcInstId = c.Int(),
                        LatestApprover = c.String(),
                        LatestComment = c.String(),
                        LatestApproveTime = c.DateTime(),
                        Creator = c.String(),
                        CreatorName = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateUserName = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetType_Id = c.Guid(),
                        TbOrganizationUnit_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetTypes", t => t.TbBudgetType_Id)
                .ForeignKey("dbo.TbOrganizationUnits", t => t.TbOrganizationUnit_Id)
                .Index(t => t.TbBudgetType_Id)
                .Index(t => t.TbOrganizationUnit_Id);
            
            CreateTable(
                "dbo.TbBudgetPlanCostCenters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BpCostCenterId = c.String(),
                        VersionId = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetPlanVersion_Id = c.Guid(),
                        TbCostCenter_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetPlanVersions", t => t.TbBudgetPlanVersion_Id)
                .ForeignKey("dbo.TbCostCenters", t => t.TbCostCenter_Id)
                .Index(t => t.TbBudgetPlanVersion_Id)
                .Index(t => t.TbCostCenter_Id);
            
            CreateTable(
                "dbo.TbBudgetPlanBudgetItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BudgetItemId = c.String(),
                        UpperBudgetItemId = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        BpCostCenterId = c.String(),
                        TbBudgetPlanCostCenter_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetPlanCostCenters", t => t.TbBudgetPlanCostCenter_Id)
                .Index(t => t.TbBudgetPlanCostCenter_Id);
            
            CreateTable(
                "dbo.TbCostCenters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CostCenterId = c.String(),
                        UpperCostCenterId = c.String(),
                        OrgUnitGuid = c.String(),
                        CostCenterType = c.Int(),
                        CostCenterCode = c.String(),
                        CostCenterName = c.String(),
                        IsInvalid = c.Int(),
                        Remark = c.String(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        OrderIndex = c.Int(),
                        CostCenterAlias = c.String(),
                        ManageType = c.String(),
                        ManagerType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetBaseInfoRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        ProjetName = c.String(),
                        ProjectId = c.String(),
                        BlockId = c.String(),
                        BlockName = c.String(),
                        CostCenterId = c.String(),
                        CostCenterCode = c.String(),
                        CostCenterName = c.String(),
                        BudgetTypeId = c.String(),
                        BudgetTypeName = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemCode = c.String(),
                        ServiceEndDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        ServiceStartDate = c.DateTime(),
                        OrgUnitCode = c.String(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        BudgetItemName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBlock_Id = c.Guid(),
                        TbBudgetItem_Id = c.Guid(),
                        TbCostCenter_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBlocks", t => t.TbBlock_Id)
                .ForeignKey("dbo.TbBudgetItems", t => t.TbBudgetItem_Id)
                .ForeignKey("dbo.TbCostCenters", t => t.TbCostCenter_Id)
                .Index(t => t.TbBlock_Id)
                .Index(t => t.TbBudgetItem_Id)
                .Index(t => t.TbCostCenter_Id);
            
            CreateTable(
                "dbo.TbBlocks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BlockId = c.String(),
                        BlockCode = c.String(),
                        BlockName = c.String(),
                        Desc = c.String(),
                        IsInvalid = c.Int(),
                        AvailabilityDate = c.DateTime(),
                        ExpiryDate = c.DateTime(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        ProjectId = c.String(),
                        UpperId = c.String(),
                        BlockType = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetPlanVersionV1",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VersionId = c.String(),
                        VersionTypeId = c.String(),
                        VersionTypeName = c.String(),
                        YearId = c.String(),
                        Year = c.Int(),
                        BlockId = c.String(),
                        BlockName = c.String(),
                        BudgetTypeId = c.String(),
                        BudgetTypeName = c.String(),
                        VersionDesc = c.String(),
                        Status = c.Int(),
                        ProcInstId = c.Int(),
                        LatestApprover = c.String(),
                        LatestComment = c.String(),
                        LatestApproveTime = c.DateTime(),
                        Creator = c.String(),
                        CreatorName = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateUserName = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBlock_Id = c.Guid(),
                        TbBudgetType_Id = c.Guid(),
                        TbBudgetVersionType_Id = c.Guid(),
                        TbYear_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBlocks", t => t.TbBlock_Id)
                .ForeignKey("dbo.TbBudgetTypes", t => t.TbBudgetType_Id)
                .ForeignKey("dbo.TbBudgetVersionTypes", t => t.TbBudgetVersionType_Id)
                .ForeignKey("dbo.TbYears", t => t.TbYear_Id)
                .Index(t => t.TbBlock_Id)
                .Index(t => t.TbBudgetType_Id)
                .Index(t => t.TbBudgetVersionType_Id)
                .Index(t => t.TbYear_Id);
            
            CreateTable(
                "dbo.TbBudgetPlanCostCenterV1",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BpCostCenterId = c.String(),
                        VersionId = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetPlanVersionV1_Id = c.Guid(),
                        TbCostCenter_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetPlanVersionV1", t => t.TbBudgetPlanVersionV1_Id)
                .ForeignKey("dbo.TbCostCenters", t => t.TbCostCenter_Id)
                .Index(t => t.TbBudgetPlanVersionV1_Id)
                .Index(t => t.TbCostCenter_Id);
            
            CreateTable(
                "dbo.TbBudgetPlanCostCenterYearDetailV1",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        YearDetailId = c.String(),
                        BpCostCenterId = c.String(),
                        UpperBudgetItemCode = c.String(),
                        UpperBudgetItemName = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        BudgetItemId = c.String(),
                        UpperId = c.String(),
                        TbBudgetPlanCostCenterV1_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetPlanCostCenterV1", t => t.TbBudgetPlanCostCenterV1_Id)
                .Index(t => t.TbBudgetPlanCostCenterV1_Id);
            
            CreateTable(
                "dbo.TbBudgetPlanCostCenterMonthDetailV1",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MonthDetailId = c.String(),
                        YearDetailId = c.String(),
                        TotalAmount = c.Decimal(precision: 18, scale: 2),
                        FirstQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        SecondQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        ThirdQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        FourthQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetPlanCostCenterYearDetailV1_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetPlanCostCenterYearDetailV1", t => t.TbBudgetPlanCostCenterYearDetailV1_Id)
                .Index(t => t.TbBudgetPlanCostCenterYearDetailV1_Id);
            
            CreateTable(
                "dbo.TbBudgetTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BudgetTypeId = c.String(),
                        BudgetTypeCode = c.String(),
                        BudgetTypeName = c.String(),
                        Description = c.String(),
                        IsInvalid = c.Int(),
                        AvailabilityDate = c.DateTime(),
                        ExpiryDate = c.DateTime(),
                        IsPlan = c.Int(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        OrderIndex = c.Int(),
                        ManageType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetPlanVersionV2",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VersionId = c.String(),
                        VersionTypeId = c.String(),
                        VersionTypeName = c.String(),
                        YearId = c.String(),
                        Year = c.Int(),
                        BlockId = c.String(),
                        BlockName = c.String(),
                        BudgetTypeId = c.String(),
                        BudgetTypeName = c.String(),
                        VersionDesc = c.String(),
                        Status = c.Int(),
                        ProcInstId = c.Int(),
                        LatestApprover = c.String(),
                        LatestComment = c.String(),
                        LatestApproveTime = c.DateTime(),
                        Creator = c.String(),
                        CreatorName = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateUserName = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBlock_Id = c.Guid(),
                        TbBudgetType_Id = c.Guid(),
                        TbBudgetVersionType_Id = c.Guid(),
                        TbYear_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBlocks", t => t.TbBlock_Id)
                .ForeignKey("dbo.TbBudgetTypes", t => t.TbBudgetType_Id)
                .ForeignKey("dbo.TbBudgetVersionTypes", t => t.TbBudgetVersionType_Id)
                .ForeignKey("dbo.TbYears", t => t.TbYear_Id)
                .Index(t => t.TbBlock_Id)
                .Index(t => t.TbBudgetType_Id)
                .Index(t => t.TbBudgetVersionType_Id)
                .Index(t => t.TbYear_Id);
            
            CreateTable(
                "dbo.TbBudgetPlanCostCenterV2",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BpCostCenterId = c.String(),
                        VersionId = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetPlanVersionV2_Id = c.Guid(),
                        TbCostCenter_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetPlanVersionV2", t => t.TbBudgetPlanVersionV2_Id)
                .ForeignKey("dbo.TbCostCenters", t => t.TbCostCenter_Id)
                .Index(t => t.TbBudgetPlanVersionV2_Id)
                .Index(t => t.TbCostCenter_Id);
            
            CreateTable(
                "dbo.TbBudgetPlanCostCenterYearDetailV2",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        YearDetailId = c.String(),
                        BpCostCenterId = c.String(),
                        UpperBudgetItemCode = c.String(),
                        UpperBudgetItemName = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        BudgetItemId = c.String(),
                        UpperId = c.String(),
                        T1Code = c.String(),
                        T2Code = c.String(),
                        T3Code = c.String(),
                        T5Code = c.String(),
                        T6Code = c.String(),
                        AccountCode = c.String(),
                        TbBudgetPlanCostCenterV2_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetPlanCostCenterV2", t => t.TbBudgetPlanCostCenterV2_Id)
                .Index(t => t.TbBudgetPlanCostCenterV2_Id);
            
            CreateTable(
                "dbo.TbBudgetPlanCostCenterMonthDetailV2",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MonthDetailId = c.String(),
                        YearDetailId = c.String(),
                        AdjustmentId = c.String(),
                        TotalAmount = c.Decimal(precision: 18, scale: 2),
                        FirstQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        SecondQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        ThirdQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        FourthQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetAdjustment_Id = c.Guid(),
                        TbBudgetPlanCostCenterYearDetailV2_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetAdjustments", t => t.TbBudgetAdjustment_Id)
                .ForeignKey("dbo.TbBudgetPlanCostCenterYearDetailV2", t => t.TbBudgetPlanCostCenterYearDetailV2_Id)
                .Index(t => t.TbBudgetAdjustment_Id)
                .Index(t => t.TbBudgetPlanCostCenterYearDetailV2_Id);
            
            CreateTable(
                "dbo.TbBudgetAdjustments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AdjustmentId = c.String(),
                        AdjustmentCode = c.String(),
                        InBlockId = c.String(),
                        InBlockName = c.String(),
                        InCostCenterId = c.String(),
                        InCostCenterName = c.String(),
                        InTotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OutBlockId = c.String(),
                        OutBlockName = c.String(),
                        OutCostCenterId = c.String(),
                        OutCostCenterName = c.String(),
                        OutTotalAmount = c.Decimal(precision: 18, scale: 2),
                        AdjustmentType = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        ProcInstId = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        ModiftyDate = c.DateTime(),
                        ModiftyUser = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        InMonth = c.Int(),
                        OutMonth = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetAdjustmentDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AdjustmentDetailId = c.String(),
                        AdjustmentId = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        AdjustAmount = c.Decimal(precision: 18, scale: 2),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        AdjustmentDetailType = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        BlockId = c.String(),
                        BlockName = c.String(),
                        TbBudgetAdjustment_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetAdjustments", t => t.TbBudgetAdjustment_Id)
                .Index(t => t.TbBudgetAdjustment_Id);
            
            CreateTable(
                "dbo.TbBudgetGenerates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        GenerateId = c.String(),
                        MonthDetailId = c.String(),
                        YearTotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FormType = c.String(),
                        FormKeyWord = c.String(),
                        FromDetailId = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        ModfityDate = c.DateTime(),
                        ModfityUser = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetPlanCostCenterMonthDetailV2_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetPlanCostCenterMonthDetailV2", t => t.TbBudgetPlanCostCenterMonthDetailV2_Id)
                .Index(t => t.TbBudgetPlanCostCenterMonthDetailV2_Id);
            
            CreateTable(
                "dbo.TbBudgetGenerateDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        GenerateDetailId = c.String(),
                        GenerateId = c.String(),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        CreateDate = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        ModfityDate = c.DateTime(),
                        ModfityUser = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetGenerate_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetGenerates", t => t.TbBudgetGenerate_Id)
                .Index(t => t.TbBudgetGenerate_Id);
            
            CreateTable(
                "dbo.TbBudgetVersionTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VersionTypeId = c.String(),
                        VersionTypeCode = c.String(),
                        VersionTypeName = c.String(),
                        IsMappingVersion = c.Int(),
                        IsAllowAdjust = c.Int(),
                        Desc = c.String(),
                        Order = c.Int(),
                        IsInvalid = c.Int(),
                        AvailabilityDate = c.DateTime(),
                        ExpiryDate = c.DateTime(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbYears",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        YearId = c.String(),
                        Year = c.Int(),
                        IsInvalid = c.Int(),
                        AvailabilityDate = c.DateTime(),
                        ExpiryDate = c.DateTime(),
                        Desc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbMonthlyPayPlanMainDrafts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PayPlanMainId = c.String(),
                        YearId = c.String(),
                        Year = c.Int(),
                        Month = c.Int(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        Desc = c.String(),
                        Status = c.Int(),
                        ProcInstId = c.Int(),
                        LatestApprover = c.String(),
                        LatestComment = c.String(),
                        LatestApproveTime = c.DateTime(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        CreatorDeptName = c.String(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdateUserDeptName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbOrganizationUnit_Id = c.Guid(),
                        TbYear_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbOrganizationUnits", t => t.TbOrganizationUnit_Id)
                .ForeignKey("dbo.TbYears", t => t.TbYear_Id)
                .Index(t => t.TbOrganizationUnit_Id)
                .Index(t => t.TbYear_Id);
            
            CreateTable(
                "dbo.TbMonthlyPayPlanCostCenterDrafts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PayPlanCostCenterId = c.String(),
                        PayPlanMainId = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbCostCenter_Id = c.Guid(),
                        TbMonthlyPayPlanMainDraft_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbCostCenters", t => t.TbCostCenter_Id)
                .ForeignKey("dbo.TbMonthlyPayPlanMainDrafts", t => t.TbMonthlyPayPlanMainDraft_Id)
                .Index(t => t.TbCostCenter_Id)
                .Index(t => t.TbMonthlyPayPlanMainDraft_Id);
            
            CreateTable(
                "dbo.TbMonthlyPayPlanBudgetItemsDrafts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PayPlanBudgetItemId = c.String(),
                        PayPlanCostCenterId = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemName = c.String(),
                        ReimbursedName = c.String(),
                        PlanPayAmount = c.Decimal(precision: 18, scale: 2),
                        PlanPayDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetItem_Id = c.Guid(),
                        TbMonthlyPayPlanCostCenterDraft_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetItems", t => t.TbBudgetItem_Id)
                .ForeignKey("dbo.TbMonthlyPayPlanCostCenterDrafts", t => t.TbMonthlyPayPlanCostCenterDraft_Id)
                .Index(t => t.TbBudgetItem_Id)
                .Index(t => t.TbMonthlyPayPlanCostCenterDraft_Id);
            
            CreateTable(
                "dbo.TbBudgetItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BudgetItemId = c.String(),
                        UpperBudgetItemId = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        TaxRate = c.Decimal(precision: 18, scale: 2),
                        BudgetDesc = c.String(),
                        IsInvalid = c.Int(),
                        AvailabilityDate = c.DateTime(),
                        ExpiryDate = c.DateTime(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        OrderIndex = c.Int(),
                        PlanModify = c.Int(),
                        FactModify = c.Int(),
                        ManageType = c.String(),
                        BudgetTypeId = c.String(),
                        ItemType = c.Int(),
                        IsMaterial = c.Int(),
                        AccountCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetAccountingRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        BudgetItemId = c.String(),
                        AccountingItemId = c.String(),
                        TbAccountingItem_Id = c.Guid(),
                        TbBudgetItem_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbAccountingItems", t => t.TbAccountingItem_Id)
                .ForeignKey("dbo.TbBudgetItems", t => t.TbBudgetItem_Id)
                .Index(t => t.TbAccountingItem_Id)
                .Index(t => t.TbBudgetItem_Id);
            
            CreateTable(
                "dbo.TbAccountingItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AccountingItemId = c.String(),
                        ItemCode = c.String(),
                        ItemName = c.String(),
                        AccountingItemDesc = c.String(),
                        IsInvalid = c.Int(),
                        AvailabilityDate = c.DateTime(),
                        ExpiryDate = c.DateTime(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        UpperId = c.String(),
                        OrderIndex = c.Int(),
                        ManageType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetControlDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BudgetControlDetailId = c.String(),
                        BudgetControlId = c.String(),
                        BudgetItemId = c.String(),
                        BudgetName = c.String(),
                        BudgetCode = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetControl_Id = c.Guid(),
                        TbBudgetItem_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetControls", t => t.TbBudgetControl_Id)
                .ForeignKey("dbo.TbBudgetItems", t => t.TbBudgetItem_Id)
                .Index(t => t.TbBudgetControl_Id)
                .Index(t => t.TbBudgetItem_Id);
            
            CreateTable(
                "dbo.TbBudgetControls",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BudgetControlId = c.String(),
                        Version = c.Int(nullable: false),
                        Creator = c.String(),
                        CreatorName = c.String(),
                        CreatorDept = c.String(),
                        CreatorDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateUserName = c.String(),
                        UpdateUserDept = c.String(),
                        UpdateUserDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetItemSubTypeRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        BudgetItemId = c.String(),
                        BudgetSubTypeId = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetItem_Id = c.Guid(),
                        TbBudgetSubType_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetItems", t => t.TbBudgetItem_Id)
                .ForeignKey("dbo.TbBudgetSubTypes", t => t.TbBudgetSubType_Id)
                .Index(t => t.TbBudgetItem_Id)
                .Index(t => t.TbBudgetSubType_Id);
            
            CreateTable(
                "dbo.TbBudgetSubTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BudgetSubTypeId = c.String(),
                        BudgetTypeId = c.String(),
                        BudgetSubTypeCode = c.String(),
                        BudgetSubTypeName = c.String(),
                        BudgetsubtypeDesc = c.String(),
                        IsNeedContract = c.Int(),
                        IsNeedPay = c.Int(),
                        ContractAttachmentDesc = c.String(),
                        IsInvalid = c.Int(),
                        AvailabilityDate = c.DateTime(),
                        ExpiryDate = c.DateTime(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        OrderIndex = c.Int(),
                        FixedPayDate = c.Int(),
                        IsNeedAgreement = c.Int(),
                        ManagerType = c.String(),
                        TbBudgetType_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetTypes", t => t.TbBudgetType_Id)
                .Index(t => t.TbBudgetType_Id);
            
            CreateTable(
                "dbo.TbCostCenterBudgetSubTypeRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        BudgetSubTypeId = c.String(),
                        CostCenterId = c.String(),
                        CreateDate = c.DateTime(),
                        TbBudgetSubType_Id = c.Guid(),
                        TbCostCenter_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetSubTypes", t => t.TbBudgetSubType_Id)
                .ForeignKey("dbo.TbCostCenters", t => t.TbCostCenter_Id)
                .Index(t => t.TbBudgetSubType_Id)
                .Index(t => t.TbCostCenter_Id);
            
            CreateTable(
                "dbo.TbTemplateBudgetRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        ContractTemplateId = c.String(),
                        BudgetSubTypeId = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetSubType_Id = c.Guid(),
                        TbContractTemplate_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetSubTypes", t => t.TbBudgetSubType_Id)
                .ForeignKey("dbo.TbContractTemplates", t => t.TbContractTemplate_Id)
                .Index(t => t.TbBudgetSubType_Id)
                .Index(t => t.TbContractTemplate_Id);
            
            CreateTable(
                "dbo.TbContractTemplates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ContractTemplateId = c.String(),
                        ContractTemplateName = c.String(),
                        TemplateContent = c.String(),
                        IsInvalid = c.Int(),
                        AvailabilityDate = c.DateTime(),
                        ExpiryDate = c.DateTime(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        BudgetSubTypeId = c.String(),
                        OrgUnitGuid = c.String(),
                        CompliancePlanTableName = c.String(),
                        FilePath = c.String(),
                        TemplateType = c.String(),
                        OrderIndex = c.Int(),
                        AppId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbStandardContractContents",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ContentId = c.String(),
                        ContractTemplateId = c.String(),
                        OrderIndex = c.Int(),
                        PageIndex = c.Int(),
                        ParagraphContent = c.String(),
                        IsEdit = c.Int(),
                        IsMainPoints = c.Int(),
                        IsNeedAttach = c.Int(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        IsLvyue = c.Int(),
                        LvyueTableName = c.String(),
                        Vision = c.Int(),
                        TbContractTemplate_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbContractTemplates", t => t.TbContractTemplate_Id)
                .Index(t => t.TbContractTemplate_Id);
            
            CreateTable(
                "dbo.TbPlanApplies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PlanApplyId = c.String(),
                        MainApplyKeyWord = c.String(),
                        BlockId = c.String(),
                        CostCenterId = c.String(),
                        BudgetItemId = c.String(),
                        PlanApplyCode = c.String(),
                        PlanApplyName = c.String(),
                        EventId = c.String(),
                        TotalAmount = c.Decimal(precision: 18, scale: 2),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        ProjectIntroduction = c.String(),
                        Creator = c.String(),
                        CreateUser = c.String(),
                        CreateDepartment = c.String(),
                        DepartmentName = c.String(),
                        CreateDate = c.DateTime(),
                        Modifier = c.String(),
                        ModiftyName = c.String(),
                        ModiftyDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        BudgetTypeId = c.String(),
                        IsExtraBudget = c.Boolean(),
                        Status = c.Int(),
                        ProcInstId = c.String(),
                        LatestApprover = c.String(),
                        LatestComment = c.String(),
                        LatestApproveTime = c.DateTime(),
                        IsYearBudget = c.Boolean(),
                        TbBlock_Id = c.Guid(),
                        TbBudgetItem_Id = c.Guid(),
                        TbCostCenter_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBlocks", t => t.TbBlock_Id)
                .ForeignKey("dbo.TbBudgetItems", t => t.TbBudgetItem_Id)
                .ForeignKey("dbo.TbCostCenters", t => t.TbCostCenter_Id)
                .Index(t => t.TbBlock_Id)
                .Index(t => t.TbBudgetItem_Id)
                .Index(t => t.TbCostCenter_Id);
            
            CreateTable(
                "dbo.TbPlanApplyDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PlanApplyDetailId = c.String(),
                        MainPlanApplyDetailId = c.String(),
                        PlanApplyId = c.String(),
                        BelongId = c.String(),
                        TransactionDetails = c.String(),
                        YearId = c.String(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        TransactionAmount = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        PayWay = c.String(),
                        BillingCompany = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        BelongName = c.String(),
                        BillingcompanyName = c.String(),
                        TbPlanApply_Id = c.Guid(),
                        TbYear_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbPlanApplies", t => t.TbPlanApply_Id)
                .ForeignKey("dbo.TbYears", t => t.TbYear_Id)
                .Index(t => t.TbPlanApply_Id)
                .Index(t => t.TbYear_Id);
            
            CreateTable(
                "dbo.TbMonthlyPayPlanMains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PayPlanMainId = c.String(),
                        YearId = c.String(),
                        Year = c.Int(),
                        Month = c.Int(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        Amount = c.Decimal(precision: 18, scale: 2),
                        Desc = c.String(),
                        Status = c.Int(),
                        ProcInstId = c.Int(),
                        LatestApprover = c.String(),
                        LatestComment = c.String(),
                        LatestApproveTime = c.DateTime(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        CreatorDeptName = c.String(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdateUserDeptName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbOrganizationUnit_Id = c.Guid(),
                        TbYear_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbOrganizationUnits", t => t.TbOrganizationUnit_Id)
                .ForeignKey("dbo.TbYears", t => t.TbYear_Id)
                .Index(t => t.TbOrganizationUnit_Id)
                .Index(t => t.TbYear_Id);
            
            CreateTable(
                "dbo.TbMonthlyPayPlanBudgetItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BudgetItemId = c.String(),
                        UpperBudgetItemId = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        PayPlanMainId = c.String(),
                        TbMonthlyPayPlanMain_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbMonthlyPayPlanMains", t => t.TbMonthlyPayPlanMain_Id)
                .Index(t => t.TbMonthlyPayPlanMain_Id);
            
            CreateTable(
                "dbo.TbMonthlyPayPlanBudgetItem1",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PayPlanBudgetItemId = c.String(),
                        PayPlanCostCenterId = c.String(),
                        BudgetItemId = c.String(),
                        UpperBudgetItemId = c.String(),
                        UpperBudgetItemName = c.String(),
                        ContractId = c.String(),
                        ContractName = c.String(),
                        PlanPayAmount = c.Decimal(precision: 18, scale: 2),
                        BudgetItemContractAmount = c.Decimal(precision: 18, scale: 2),
                        PendingPayAmount = c.Decimal(precision: 18, scale: 2),
                        PlanPayDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbMonthlyPayPlanBudgetItem_Id = c.Guid(),
                        TbMonthlyPayPlanCostCenter_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbMonthlyPayPlanBudgetItems", t => t.TbMonthlyPayPlanBudgetItem_Id)
                .ForeignKey("dbo.TbMonthlyPayPlanCostCenters", t => t.TbMonthlyPayPlanCostCenter_Id)
                .Index(t => t.TbMonthlyPayPlanBudgetItem_Id)
                .Index(t => t.TbMonthlyPayPlanCostCenter_Id);
            
            CreateTable(
                "dbo.TbMonthlyPayPlanCostCenters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PayPlanCostCenterId = c.String(),
                        PayPlanMainId = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        Amount = c.Decimal(precision: 18, scale: 2),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbCostCenter_Id = c.Guid(),
                        TbMonthlyPayPlanMain_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbCostCenters", t => t.TbCostCenter_Id)
                .ForeignKey("dbo.TbMonthlyPayPlanMains", t => t.TbMonthlyPayPlanMain_Id)
                .Index(t => t.TbCostCenter_Id)
                .Index(t => t.TbMonthlyPayPlanMain_Id);
            
            CreateTable(
                "dbo.TbDeptCategoryRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        DeptCategoryId = c.String(),
                        OrgUnitGuid = c.String(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.String(),
                        TbDeptCategory_Id = c.Guid(),
                        TbOrganizationUnit_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbDeptCategories", t => t.TbDeptCategory_Id)
                .ForeignKey("dbo.TbOrganizationUnits", t => t.TbOrganizationUnit_Id)
                .Index(t => t.TbDeptCategory_Id)
                .Index(t => t.TbOrganizationUnit_Id);
            
            CreateTable(
                "dbo.TbDeptCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DeptCategoryId = c.String(),
                        DeptCategoryName = c.String(),
                        Status = c.Int(),
                        Creator = c.String(),
                        CreatorName = c.String(),
                        UpdateUser = c.String(),
                        UpdateUserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPaymentSigns",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PaymentSignId = c.String(),
                        PaymentApplyId = c.String(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemName = c.String(),
                        PayBankName = c.String(),
                        PayAccount = c.String(),
                        Cbankaccountid = c.String(),
                        PayAmount = c.Decimal(precision: 18, scale: 2),
                        PayWay = c.String(),
                        PayWayName = c.String(),
                        PayDate = c.DateTime(),
                        PayDesc = c.String(),
                        Creator = c.String(),
                        CreatorName = c.String(),
                        CreatorDeptId = c.String(),
                        CreatorDeptName = c.String(),
                        CreateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        IsGenerated = c.Int(),
                        TbOrganizationUnit_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbOrganizationUnits", t => t.TbOrganizationUnit_Id)
                .Index(t => t.TbOrganizationUnit_Id);
            
            CreateTable(
                "dbo.SysDataRightsRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        DataRightsId = c.String(),
                        Value = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysGeneratesequenceids",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SequenceName = c.String(),
                        MaxId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysManualMarks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MarkId = c.String(),
                        MarkContent = c.String(),
                        Remark = c.String(),
                        CreateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysParameters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ParameterId = c.String(),
                        Code = c.String(),
                        Name = c.String(),
                        Value = c.String(),
                        OrderNum = c.Int(),
                        Status = c.Int(),
                        Remark = c.String(),
                        UpperId = c.String(),
                        TypeCode = c.String(),
                        TypeName = c.String(),
                        CreateUserId = c.String(),
                        CreateDate = c.DateTime(),
                        ModifyUserId = c.String(),
                        ModifyDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysProvinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        Name = c.String(),
                        Abbreviation = c.String(),
                        Published = c.Boolean(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbAccountingItemsBaks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AccountingItemId = c.String(),
                        ItemCode = c.String(),
                        ItemName = c.String(),
                        AccountingItemDesc = c.String(),
                        IsInvalid = c.Int(),
                        AvailabilityDate = c.DateTime(),
                        ExpiryDate = c.DateTime(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        UpperId = c.String(),
                        OrderIndex = c.Int(),
                        ManageType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbAttachments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AttachmentId = c.String(),
                        ForeignKey = c.String(),
                        AttachmentName = c.String(),
                        AttachmentSuffix = c.String(),
                        AttachmentUrl = c.String(),
                        UploadDate = c.DateTime(nullable: false),
                        UploadUser = c.String(),
                        AttachmenType = c.Int(nullable: false),
                        AttachmenSmallType = c.Int(),
                        UploadAttachmenType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBelongBorCCorporateRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        BelongId = c.String(),
                        CorporateGuid = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBelongBorCs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BelongId = c.String(),
                        BelongCode = c.String(),
                        BelongName = c.String(),
                        IsInvalid = c.Int(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBlockBelongBorCRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        BlockId = c.String(),
                        BelongId = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBlockClosingRecords",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BlockClosingRecordId = c.String(),
                        BlockId = c.String(),
                        BlockName = c.String(),
                        ProjectId = c.String(),
                        ProjectName = c.String(),
                        OpenRecordBegionDate = c.String(),
                        OpenRecordEndDate = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdateUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetAccountingRelateBaks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        BudgetItemId = c.String(),
                        AccountingItemId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetGenerateBaks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        GenerateId = c.String(),
                        MonthDetailId = c.String(),
                        YearTotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FormType = c.String(),
                        FormKeyWord = c.String(),
                        FromDetailId = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        ModfityDate = c.DateTime(),
                        ModfityUser = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetGenerateDetailBaks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        GenerateDetailId = c.String(),
                        GenerateId = c.String(),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        CreateDate = c.DateTime(nullable: false),
                        CreateUser = c.String(),
                        ModfityDate = c.DateTime(),
                        ModfityUser = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetGroupMaps",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        GroupMapId = c.String(),
                        BudgetGroupId = c.String(),
                        BudgetItemId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetGroups",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BudgetGroupId = c.String(),
                        GroupName = c.String(),
                        StartDate = c.DateTime(),
                        EndData = c.DateTime(),
                        IsInvalid = c.Int(),
                        CreateUserId = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetItemContractCategoryRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        BudgetSubTypeId = c.String(),
                        ContractCategoryId = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetItemControls",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BudgetItemControlId = c.String(),
                        BudgetControlId = c.String(),
                        BudgetItemId = c.String(),
                        BudgetName = c.String(),
                        BudgetCode = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetPlanAdjustments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AdjustmentId = c.String(),
                        VersionId = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        BeforeAdjustmentAmount1 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount1 = c.Decimal(precision: 18, scale: 2),
                        BeforeAdjustmentAmount2 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount2 = c.Decimal(precision: 18, scale: 2),
                        BeforeAdjustmentAmount3 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount3 = c.Decimal(precision: 18, scale: 2),
                        BeforeAdjustmentAmount4 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount4 = c.Decimal(precision: 18, scale: 2),
                        BeforeAdjustmentAmount5 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount5 = c.Decimal(precision: 18, scale: 2),
                        BeforeAdjustmentAmount6 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount6 = c.Decimal(precision: 18, scale: 2),
                        BeforeAdjustmentAmount7 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount7 = c.Decimal(precision: 18, scale: 2),
                        BeforeAdjustmentAmount8 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount8 = c.Decimal(precision: 18, scale: 2),
                        BeforeAdjustmentAmount9 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount9 = c.Decimal(precision: 18, scale: 2),
                        BeforeAdjustmentAmount10 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount10 = c.Decimal(precision: 18, scale: 2),
                        BeforeAdjustmentAmount11 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount11 = c.Decimal(precision: 18, scale: 2),
                        BeforeAdjustmentAmount12 = c.Decimal(precision: 18, scale: 2),
                        AfterAdjustmentAmount12 = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        AdjustmentDate = c.DateTime(),
                        AdjustmentUser = c.String(),
                        AdjustmentUserName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetPlanCostCenterMonthDetailV3",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MonthDetailId = c.String(),
                        BudgetItemId = c.String(),
                        TotalAmount = c.Decimal(precision: 18, scale: 2),
                        FirstQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        SecondQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        ThirdQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        FourthQuarterAmount = c.Decimal(precision: 18, scale: 2),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetPlanCostCenterYearDetailV3_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetPlanCostCenterYearDetailV3", t => t.TbBudgetPlanCostCenterYearDetailV3_Id)
                .Index(t => t.TbBudgetPlanCostCenterYearDetailV3_Id);
            
            CreateTable(
                "dbo.TbBudgetPlanCostCenterYearDetailV3",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BudgetItemId = c.String(),
                        BpCostCenterId = c.String(),
                        UpperBudgetItemCode = c.String(),
                        UpperBudgetItemName = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBudgetPlanCostCenterV3_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBudgetPlanCostCenterV3", t => t.TbBudgetPlanCostCenterV3_Id)
                .Index(t => t.TbBudgetPlanCostCenterV3_Id);
            
            CreateTable(
                "dbo.TbBudgetPlanCostCenterV3",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BpCostCenterId = c.String(),
                        VersionId = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetPlanFactAmounts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FactAmountId = c.String(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        FactAmountYear = c.Int(),
                        BudgetItemId = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        UpperBudgetItemId = c.String(),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        UpdateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateUserName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBudgetPlanVersionV3",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VersionId = c.String(),
                        VersionTypeId = c.String(),
                        VersionTypeName = c.String(),
                        YearId = c.String(),
                        Year = c.Int(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        BudgetTypeId = c.String(),
                        BudgetTypeName = c.String(),
                        VersionDesc = c.String(),
                        Status = c.Int(),
                        ProcInstId = c.Int(),
                        LatestApprover = c.String(),
                        LatestComment = c.String(),
                        LatestApproveTime = c.DateTime(),
                        Creator = c.String(),
                        CreatorName = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateUserName = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbBusinessExecutionDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ExecutionDetailId = c.String(),
                        BusinessExecutionId = c.String(),
                        PerformancePlanId = c.String(),
                        ServiceStartDate = c.DateTime(),
                        ServiceEndDate = c.DateTime(),
                        ItemDetail = c.String(),
                        ConfirmationAmount = c.Decimal(precision: 18, scale: 2),
                        PeriodConfirmationAmount = c.Decimal(precision: 18, scale: 2),
                        ServiceAmount = c.Decimal(precision: 18, scale: 2),
                        Explain = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBusinessExecution_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBusinessExecutions", t => t.TbBusinessExecution_Id)
                .Index(t => t.TbBusinessExecution_Id);
            
            CreateTable(
                "dbo.TbBusinessExecutions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BusinessExecutionId = c.String(),
                        BusinessExecutionCode = c.String(),
                        BusinessExecutionName = c.String(),
                        PeriodConfirmationAmount = c.Decimal(precision: 18, scale: 2),
                        TotalAmount = c.Decimal(precision: 18, scale: 2),
                        ProjectId = c.String(),
                        ProjectName = c.String(),
                        BlockId = c.String(),
                        BlockName = c.String(),
                        SupplierId = c.String(),
                        CompanyName = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemName = c.String(),
                        BudgetDeptId = c.String(),
                        BudgetDept = c.String(),
                        PlanApplyId = c.String(),
                        PlanApplyName = c.String(),
                        ContractId = c.String(),
                        ContractName = c.String(),
                        IsVisible = c.Int(),
                        AttnId = c.String(),
                        AttnName = c.String(),
                        AttnDeptId = c.String(),
                        AttnDeptName = c.String(),
                        ExecutionDesc = c.String(),
                        Status = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        LatestApprover = c.String(),
                        LatestComment = c.String(),
                        LatestApproveTime = c.DateTime(),
                        Procinstid = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        FormType = c.Int(),
                        CorporateGuid = c.String(),
                        CorporateCode = c.String(),
                        CorporateName = c.String(),
                        OriginalBusinessExecutionCode = c.String(),
                        PostDateTime = c.DateTime(),
                        AssociatedConfirmationsSlipId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbMaterialsDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaterialsDetailId = c.String(),
                        BusinessExecutionId = c.String(),
                        ServiceStartDate = c.DateTime(),
                        ServiceEndDate = c.DateTime(),
                        MaterialsDetailName = c.String(),
                        Quantity = c.Int(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        RemainingAmount = c.Decimal(precision: 18, scale: 2),
                        UnusedCount = c.Int(),
                        Remark = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBusinessExecution_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBusinessExecutions", t => t.TbBusinessExecution_Id)
                .Index(t => t.TbBusinessExecution_Id);
            
            CreateTable(
                "dbo.TbMaterialsRecipients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RecipientsId = c.String(),
                        BusinessExecutionId = c.String(),
                        MaterialsDetailId = c.String(),
                        ServiceStartDate = c.DateTime(),
                        ServiceEndDate = c.DateTime(),
                        MaterialsDetailName = c.String(),
                        Quantity = c.Int(),
                        UnusedQuantity = c.Int(),
                        Remark = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbBusinessExecution_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbBusinessExecutions", t => t.TbBusinessExecution_Id)
                .Index(t => t.TbBusinessExecution_Id);
            
            CreateTable(
                "dbo.TbContractApproves",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ApproveId = c.String(),
                        ContractId = c.String(),
                        ContractName = c.String(),
                        Creator = c.String(),
                        CreatorLoginId = c.String(),
                        CreatorName = c.String(),
                        CreateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbContractAttachments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ContractAttachmentId = c.String(),
                        ContractId = c.String(),
                        AttachmentName = c.String(),
                        AttachmentSuffix = c.String(),
                        AttachmentUrl = c.String(),
                        UploadDate = c.DateTime(),
                        AttachmenType = c.Int(),
                        Content = c.String(),
                        StandardContractId = c.String(),
                        ControlId = c.String(),
                        VisionContent = c.String(),
                        SummaryContent = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbContractClosingRecords",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ClosingRecordId = c.String(),
                        ContractId = c.String(),
                        Year = c.Int(),
                        Month = c.Int(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbContractDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ContractDetailId = c.String(),
                        ContractId = c.String(),
                        MainContractDetailId = c.String(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        SupplierId = c.String(),
                        SupplierName = c.String(),
                        CostCenterId = c.String(),
                        CostCenterCode = c.String(),
                        CostCenterName = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemName = c.String(),
                        BlockId = c.String(),
                        BlockName = c.String(),
                        BudgetRangeStart = c.DateTime(),
                        BudgetRangeEnd = c.DateTime(),
                        ApplyAmount = c.Decimal(precision: 18, scale: 2),
                        MainApplyAmount = c.Decimal(precision: 18, scale: 2),
                        AvailableCredit = c.Decimal(precision: 18, scale: 2),
                        TaxRate = c.Decimal(precision: 18, scale: 2),
                        Tax = c.Decimal(precision: 18, scale: 2),
                        ExcludingTax = c.Decimal(precision: 18, scale: 2),
                        FinancialTax = c.Decimal(precision: 18, scale: 2),
                        InvoiceType = c.Int(),
                        InvoiceTypeName = c.String(),
                        RowNumber = c.Int(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        BudgetAmount = c.Decimal(precision: 18, scale: 2),
                        PaidAmount = c.Decimal(precision: 18, scale: 2),
                        ApprovedNoPaidAmount = c.Decimal(precision: 18, scale: 2),
                        ApprovingApplyAmount = c.Decimal(precision: 18, scale: 2),
                        WaittingSubmitAmount = c.Decimal(precision: 18, scale: 2),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbContract_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbContracts", t => t.TbContract_Id)
                .Index(t => t.TbContract_Id);
            
            CreateTable(
                "dbo.TbContracts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ContractId = c.String(),
                        BudgetSubTypeId = c.String(),
                        CorporateGuid = c.String(),
                        ContractCode = c.String(),
                        ContractName = c.String(),
                        ContractAmount = c.Decimal(precision: 18, scale: 2),
                        ContractTotalAmount = c.Decimal(precision: 18, scale: 2),
                        BlockId = c.String(),
                        BlockName = c.String(),
                        IsPagingSeal = c.Int(),
                        ContractType = c.String(),
                        ContractTypeName = c.String(),
                        PlanApplyId = c.String(),
                        PlanApplyName = c.String(),
                        RemainingAmount = c.Decimal(precision: 18, scale: 2),
                        ContractNature = c.String(),
                        ContractNatureName = c.String(),
                        SignDate = c.DateTime(),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        IsPrint = c.Int(),
                        BiddingMethod = c.Int(),
                        BiddingMethodName = c.String(),
                        TotalTax = c.Decimal(precision: 18, scale: 2),
                        TotalExcludingTax = c.Decimal(precision: 18, scale: 2),
                        PaidAmount = c.Decimal(precision: 18, scale: 2),
                        IsAmendTerms = c.Int(),
                        CorporateName = c.String(),
                        CorporateCode = c.String(),
                        SecondPartyName = c.String(),
                        SecondPartyCode = c.String(),
                        ThirdPartyName = c.String(),
                        ThirdPartyCode = c.String(),
                        FourthPartyName = c.String(),
                        FourthPartyCode = c.String(),
                        FifthPartyName = c.String(),
                        FifthPartyCode = c.String(),
                        ContractDesc = c.String(),
                        PriceExplanation = c.String(),
                        Status = c.Int(),
                        PayStatus = c.Int(),
                        ProcInstId = c.String(),
                        LatestApprover = c.String(),
                        LatestComment = c.String(),
                        LatestApproveTime = c.DateTime(),
                        Creator = c.String(),
                        CreatorLoginId = c.String(),
                        CreatorName = c.String(),
                        CreatorDeptId = c.String(),
                        CreatorDeptName = c.String(),
                        CreatorOrgUnitGuid = c.String(),
                        CreatorOrgUnitName = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateUserName = c.String(),
                        UpdateUserDeptId = c.String(),
                        UpdateUserDeptName = c.String(),
                        UpdateDate = c.DateTime(),
                        IsFrameworkContract = c.String(),
                        MainContractId = c.String(),
                        FullName = c.String(),
                        OrgUnitGuid = c.String(),
                        SecCompanyCode = c.String(),
                        IsStandardContract = c.String(),
                        Principal = c.String(),
                        CurrentContractAmount = c.Decimal(precision: 18, scale: 2),
                        TaxCurrentAmount = c.Decimal(precision: 18, scale: 2),
                        Islocked = c.String(),
                        ContractFlag = c.String(),
                        VatType = c.String(),
                        TotalTaxes = c.Decimal(precision: 18, scale: 2),
                        BudgetSubTypeName = c.String(),
                        Reason = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        IsFixed = c.Int(),
                        Fixed = c.String(),
                        OriginalContractCode = c.String(),
                        PayCompanyGuid = c.String(),
                        PayCompanyName = c.String(),
                        PayCompanyCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbContractPayPlans",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PayPlanId = c.String(),
                        ContractId = c.String(),
                        CostCenterName = c.String(),
                        BudgetItemName = c.String(),
                        PlanPayAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PlanPayDate = c.DateTime(),
                        PayType = c.String(),
                        Creator = c.String(),
                        CreatorName = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateUserName = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbContract_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbContracts", t => t.TbContract_Id)
                .Index(t => t.TbContract_Id);
            
            CreateTable(
                "dbo.TbContractRelatePlans",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ContractRelatePlanId = c.String(),
                        ContractId = c.String(),
                        BlockId = c.String(),
                        PlanApplyId = c.String(),
                        PlanApplyDetailId = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbContract_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbContracts", t => t.TbContract_Id)
                .Index(t => t.TbContract_Id);
            
            CreateTable(
                "dbo.TbContractSelects",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SelectId = c.String(),
                        ContractId = c.String(),
                        ContractType = c.String(),
                        ContractTypeName = c.String(),
                        ContractBigType = c.String(),
                        ContractBigTypeName = c.String(),
                        ContractSmallType = c.String(),
                        ContractSmallTypeName = c.String(),
                        IsStandardContract = c.String(),
                        IsStandardContractName = c.String(),
                        ContractTemplateId = c.String(),
                        NotStandardContractReason = c.String(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbContract_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbContracts", t => t.TbContract_Id)
                .Index(t => t.TbContract_Id);
            
            CreateTable(
                "dbo.TbContractStatistics",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ContractStatisticsId = c.String(),
                        ContractId = c.String(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        CostCenterCode = c.String(),
                        CostCenterName = c.String(),
                        ApplyAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BudgetAmount = c.Decimal(precision: 18, scale: 2),
                        PaidAmount = c.Decimal(precision: 18, scale: 2),
                        ApprovedNoPaidAmount = c.Decimal(precision: 18, scale: 2),
                        ApprovingApplyAmount = c.Decimal(precision: 18, scale: 2),
                        WaittingSubmitAmount = c.Decimal(precision: 18, scale: 2),
                        DimensionType = c.Int(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbContract_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbContracts", t => t.TbContract_Id)
                .Index(t => t.TbContract_Id);
            
            CreateTable(
                "dbo.TbCorporateBankAccounts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CBankAccountId = c.String(),
                        CorporateGuid = c.String(),
                        Bank = c.String(),
                        BankAccount = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbCorporate_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbCorporates", t => t.TbCorporate_Id)
                .Index(t => t.TbCorporate_Id);
            
            CreateTable(
                "dbo.TbCorporates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CorporateGuid = c.String(),
                        CorporateCode = c.String(),
                        CorporateName = c.String(),
                        CorporateDesc = c.String(),
                        IsInvalid = c.Int(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        OrderIndex = c.Int(),
                        VatType = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbFeeStandards",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Subject = c.String(),
                        Amount = c.Decimal(precision: 18, scale: 2),
                        UserName = c.String(),
                        BeginTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbFinancialDesk1220",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FinancialDeskId = c.String(),
                        Version = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CostTypeCode = c.String(),
                        CostTypeName = c.String(),
                        ProjectId = c.String(),
                        ProjectCode = c.String(),
                        ProjectName = c.String(),
                        BlockId = c.String(),
                        BlockCode = c.String(),
                        BlockName = c.String(),
                        CostCenterId = c.String(),
                        CostCenterCode = c.String(),
                        CostCenterName = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        CorporateGuid = c.String(),
                        CorporateCode = c.String(),
                        CorporateName = c.String(),
                        TotalTax = c.Decimal(precision: 18, scale: 2),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        AttachmentId = c.String(),
                        OrderNum = c.Int(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        Year = c.Int(),
                        BudgetTypeId = c.String(),
                        BudgetTypeCode = c.String(),
                        BudgetTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbFinancialDeskBacks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FinancialDeskId = c.String(),
                        Version = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CostTypeCode = c.String(),
                        CostTypeName = c.String(),
                        ProjectId = c.String(),
                        ProjectCode = c.String(),
                        ProjectName = c.String(),
                        BlockId = c.String(),
                        BlockCode = c.String(),
                        BlockName = c.String(),
                        CostCenterId = c.String(),
                        CostCenterCode = c.String(),
                        CostCenterName = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        CorporateGuid = c.String(),
                        CorporateCode = c.String(),
                        CorporateName = c.String(),
                        TotalTax = c.Decimal(precision: 18, scale: 2),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        AttachmentId = c.String(),
                        OrderNum = c.Int(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        Year = c.Int(),
                        BudgetTypeId = c.String(),
                        BudgetTypeCode = c.String(),
                        BudgetTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbFinancialDesks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FinancialDeskId = c.String(),
                        Version = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CostTypeCode = c.String(),
                        CostTypeName = c.String(),
                        ProjectId = c.String(),
                        ProjectCode = c.String(),
                        ProjectName = c.String(),
                        BlockId = c.String(),
                        BlockCode = c.String(),
                        BlockName = c.String(),
                        CostCenterId = c.String(),
                        CostCenterCode = c.String(),
                        CostCenterName = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        CorporateGuid = c.String(),
                        CorporateCode = c.String(),
                        CorporateName = c.String(),
                        TotalTax = c.Decimal(precision: 18, scale: 2),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        AttachmentId = c.String(),
                        OrderNum = c.Int(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        Year = c.Int(),
                        BudgetTypeId = c.String(),
                        BudgetTypeCode = c.String(),
                        BudgetTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbGroupDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        GroupDetailId = c.String(),
                        GroupId = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemCode = c.String(),
                        BudgetItemName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbGroup_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbGroups", t => t.TbGroup_Id)
                .Index(t => t.TbGroup_Id);
            
            CreateTable(
                "dbo.TbGroups",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        GroupId = c.String(),
                        GroupName = c.String(),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        Status = c.Int(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbHotelExpenses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        HotelExpenseId = c.String(),
                        RankId = c.String(),
                        RankCode = c.String(),
                        RankName = c.String(),
                        ProjectId = c.String(),
                        ProjectCode = c.String(),
                        ProjectName = c.String(),
                        ControlStandardIDs = c.String(),
                        ControlStandardName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbInvoiceDetails",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        InvoiceId = c.String(),
                        ServerName = c.String(),
                        Specification = c.String(),
                        Unit = c.String(),
                        Count = c.Int(),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                        TotalPrice = c.Decimal(precision: 18, scale: 2),
                        TaxRate = c.Decimal(precision: 18, scale: 2),
                        Tax = c.Decimal(precision: 18, scale: 2),
                        F1 = c.String(),
                        F2 = c.String(),
                        TbInvoice_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbInvoices", t => t.TbInvoice_Id)
                .Index(t => t.TbInvoice_Id);
            
            CreateTable(
                "dbo.TbInvoices",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        InvoiceId = c.String(),
                        PaymentApplyId = c.String(),
                        InvoiceCode = c.String(),
                        InvoiceNo = c.String(),
                        BillingDate = c.DateTime(),
                        PurchaserName = c.String(),
                        TaxpayerNo = c.String(),
                        AddressMobile = c.String(),
                        BankAndAccount = c.String(),
                        PwdArea = c.String(),
                        TotalPriceC = c.String(),
                        TotalPriceL = c.Decimal(precision: 18, scale: 2),
                        SellerName = c.String(),
                        SellerTaxPayerNo = c.String(),
                        SellerAddressMobile = c.String(),
                        SellerBankAndAccount = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        TbPaymentApply_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbPaymentApplies", t => t.TbPaymentApply_Id)
                .Index(t => t.TbPaymentApply_Id);
            
            CreateTable(
                "dbo.TbPaymentApplies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PaymentApplyId = c.String(),
                        PaymentApplyCode = c.String(),
                        PaymentSubject = c.String(),
                        PaymentWay = c.String(),
                        PaymentWayName = c.String(),
                        PlanApplyId = c.String(),
                        PaymentType = c.String(),
                        Status = c.Int(),
                        PayStatus = c.Int(),
                        PayTime = c.DateTime(),
                        IsWarrantyGold = c.Int(),
                        CurrentApplyAmount = c.Decimal(precision: 18, scale: 2),
                        NoTaxAmount = c.Decimal(precision: 18, scale: 2),
                        TotalTaxAmount = c.Decimal(precision: 18, scale: 2),
                        PaidAmountForApply = c.Decimal(precision: 18, scale: 2),
                        WaitingPayAmount = c.Decimal(precision: 18, scale: 2),
                        CorporateGuid = c.String(),
                        CorporateName = c.String(),
                        PaymentDesc = c.String(),
                        ProcInstId = c.String(),
                        LatestApprover = c.String(),
                        LatestComment = c.String(),
                        LatestApproveTime = c.DateTime(),
                        SubmitUser = c.String(),
                        SubmitUserLoginId = c.String(),
                        SubmitUserName = c.String(),
                        SubmitUserDeptId = c.String(),
                        SubmitUserDeptName = c.String(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        Creator = c.String(),
                        CreatorLoginId = c.String(),
                        CreatorName = c.String(),
                        CreatorDeptId = c.String(),
                        CreatorDeptName = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateUserName = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        JoinCount = c.Int(),
                        AvgCost = c.Decimal(precision: 18, scale: 2),
                        ReceivingName = c.String(),
                        ReceivingBank = c.String(),
                        ReceivingBranch = c.String(),
                        ReceivingAccount = c.String(),
                        BlockId = c.String(),
                        BlockName = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemName = c.String(),
                        ProjectId = c.String(),
                        ProjectName = c.String(),
                        PayFinishTime = c.DateTime(),
                        SpecialRemark = c.String(),
                        WarrantyGoldTaxAmount = c.Decimal(precision: 18, scale: 2),
                        WarrantyGoldPayTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPaymentApplyDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PaymentApplyDetailId = c.String(),
                        PaymentApplyId = c.String(),
                        ExecutionDetailId = c.String(),
                        BlockId = c.String(),
                        CostCenterId = c.String(),
                        BudgetItemId = c.String(),
                        AvailableBudget = c.Decimal(precision: 18, scale: 2),
                        TotalTaxAmount = c.Decimal(precision: 18, scale: 2),
                        TaxRate = c.Decimal(precision: 18, scale: 2),
                        TaxAmount = c.Decimal(precision: 18, scale: 2),
                        NoTaxAmount = c.Decimal(precision: 18, scale: 2),
                        ReceiptType = c.String(),
                        ReceiptTypeName = c.String(),
                        ThisApplyPaymentAmount = c.Decimal(precision: 18, scale: 2),
                        ThisApplyPayTaxAmount = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        PaidAmount = c.Decimal(precision: 18, scale: 2),
                        ApprovedNoPaidAmount = c.Decimal(precision: 18, scale: 2),
                        ApprovingApplyAmount = c.Decimal(precision: 18, scale: 2),
                        BudgetAmount = c.Decimal(precision: 18, scale: 2),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        PlanApplyDetailId = c.String(),
                        BudgetRangeStart = c.DateTime(),
                        BudgetRangeEnd = c.DateTime(),
                        OffsetAmount = c.Decimal(precision: 18, scale: 2),
                        BillingCompanyId = c.String(),
                        BillingcompanyName = c.String(),
                        BelongId = c.String(),
                        BelongName = c.String(),
                        JoinCount = c.Int(),
                        AvgCost = c.Decimal(precision: 18, scale: 2),
                        TbPaymentApply_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbPaymentApplies", t => t.TbPaymentApply_Id)
                .Index(t => t.TbPaymentApply_Id);
            
            CreateTable(
                "dbo.TbPaymentOthers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OtherId = c.String(),
                        PaymentApplyId = c.String(),
                        Sort = c.Int(),
                        Overview = c.String(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        ExcessiveDesc = c.String(),
                        Subtotal = c.Decimal(precision: 18, scale: 2),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        TbPaymentApply_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbPaymentApplies", t => t.TbPaymentApply_Id)
                .Index(t => t.TbPaymentApply_Id);
            
            CreateTable(
                "dbo.TbPaymentStays",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StayId = c.String(),
                        PaymentApplyId = c.String(),
                        Sort = c.Int(),
                        HotelName = c.String(),
                        Days = c.Int(),
                        Level = c.String(),
                        LevelName = c.String(),
                        TotalPrice = c.Decimal(precision: 18, scale: 2),
                        Subtotal = c.Decimal(precision: 18, scale: 2),
                        ExcessiveDesc = c.String(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        TbPaymentApply_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbPaymentApplies", t => t.TbPaymentApply_Id)
                .Index(t => t.TbPaymentApply_Id);
            
            CreateTable(
                "dbo.TbPaymentTraffics",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TrafficId = c.String(),
                        PaymentApplyId = c.String(),
                        Sort = c.Int(),
                        FromPlace = c.String(),
                        ToPlace = c.String(),
                        Cause = c.String(),
                        TrafficTool = c.String(),
                        TrafficToolName = c.String(),
                        TotalPrice = c.Decimal(precision: 18, scale: 2),
                        ExcessiveDesc = c.String(),
                        Subtotal = c.Decimal(precision: 18, scale: 2),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        TbPaymentApply_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbPaymentApplies", t => t.TbPaymentApply_Id)
                .Index(t => t.TbPaymentApply_Id);
            
            CreateTable(
                "dbo.TbSpareMoneyRepaymentsDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RepaymentDetailId = c.String(),
                        Amount = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        BelongId = c.String(),
                        BelongName = c.String(),
                        BudgetItemName = c.String(),
                        BudgetItemId = c.String(),
                        PaymentApplyId = c.String(),
                        TbPaymentApply_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbPaymentApplies", t => t.TbPaymentApply_Id)
                .Index(t => t.TbPaymentApply_Id);
            
            CreateTable(
                "dbo.TbLoanApplies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LoanId = c.String(),
                        LoanCode = c.String(),
                        LoanName = c.String(),
                        Status = c.Int(),
                        LoanStatus = c.Int(),
                        ApplyUserId = c.String(),
                        ApplyUserName = c.String(),
                        BlockId = c.String(),
                        BlockName = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        BudgetItemId = c.String(),
                        BudgetItemName = c.String(),
                        ProjectId = c.String(),
                        ProjectName = c.String(),
                        PayCorporateId = c.String(),
                        PayCorporateName = c.String(),
                        PlanApplyId = c.String(),
                        LoanAmount = c.Decimal(precision: 18, scale: 2),
                        NoSettledAmount = c.Decimal(precision: 18, scale: 2),
                        RepaymentTime = c.DateTime(),
                        Remark = c.String(),
                        CreateDate = c.DateTime(),
                        ReceivingName = c.String(),
                        ReceivingBank = c.String(),
                        ReceivingBranch = c.String(),
                        ReceivingAccount = c.String(),
                        CreatorUserId = c.String(),
                        CreatorName = c.String(),
                        CreatorDeptId = c.String(),
                        CreatorDeptName = c.String(),
                        ProcInstId = c.String(),
                        LatestApprover = c.String(),
                        LatestComment = c.String(),
                        LatestApproveTime = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        BelongId = c.String(),
                        BelongName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbLoanApplyReceivingInfoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RepaymentId = c.String(),
                        LoanId = c.String(),
                        RepaymentMoney = c.Decimal(precision: 18, scale: 2),
                        RepaymentTime = c.DateTime(),
                        OffsetMoney = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        ReceivingCompanyId = c.String(),
                        ReceivingCompany = c.String(),
                        ReceivingBankId = c.String(),
                        ReceivingBank = c.String(),
                        ReceivingBranchId = c.String(),
                        ReceivingBranch = c.String(),
                        ReceivingAccount = c.String(),
                        CreatorUserId = c.String(),
                        CreatorName = c.String(),
                        CreatorDeptId = c.String(),
                        CreatorDeptName = c.String(),
                        Createdate = c.DateTime(),
                        Status = c.Int(),
                        ProcInstId = c.String(),
                        Latestapprover = c.String(),
                        Latestcomment = c.String(),
                        Latestapprovetime = c.DateTime(),
                        TbLoanApply_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbLoanApplies", t => t.TbLoanApply_Id)
                .Index(t => t.TbLoanApply_Id);
            
            CreateTable(
                "dbo.TbRepaymentsDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RepaymentDetailId = c.String(),
                        RepaymentCode = c.String(),
                        Amount = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        CostCenterId = c.String(),
                        CostCenterName = c.String(),
                        BelongId = c.String(),
                        BelongName = c.String(),
                        BudgetItemName = c.String(),
                        BudgetItemId = c.String(),
                        RepaymentId = c.String(),
                        TbLoanApplyReceivingInfo_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbLoanApplyReceivingInfoes", t => t.TbLoanApplyReceivingInfo_Id)
                .Index(t => t.TbLoanApplyReceivingInfo_Id);
            
            CreateTable(
                "dbo.TbMainShowSettings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SettingId = c.String(),
                        Module = c.Int(),
                        IsShow = c.Int(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbNotices",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NoticeId = c.String(),
                        Subject = c.String(),
                        NoticeDesc = c.String(),
                        IsInvalid = c.Int(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbOperationRecords",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RecordId = c.String(),
                        UserId = c.String(),
                        AppoveTimeBx = c.DateTime(),
                        PaidTimeBx = c.DateTime(),
                        AppoveTimeHt = c.DateTime(),
                        AppoveTimeFk = c.DateTime(),
                        PaidTimeFk = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbOrganizationUnitBaks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        UpperOrgUnitGuid = c.String(),
                        OrgUnitType = c.String(),
                        OrgUnitLever = c.String(),
                        OrderIndex = c.Int(),
                        BelongDutyLine = c.String(),
                        IsCostCenter = c.Int(),
                        IsInvalid = c.Int(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPaymentApplyAttachments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PaymentApplyAttachmentId = c.String(),
                        PaymentApplyId = c.String(),
                        AttachmentName = c.String(),
                        AttachmentSuffix = c.String(),
                        AttachmentUrl = c.String(),
                        UploadDate = c.DateTime(),
                        AttachmenType = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPaymentApplyReceivingInfoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ReceivingId = c.String(),
                        PaymentApplyId = c.String(),
                        ReceivingCompanyId = c.String(),
                        ReceivingCompany = c.String(),
                        ReceivingBank = c.String(),
                        ReceivingAccount = c.String(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        ApplyAmount = c.Decimal(precision: 18, scale: 2),
                        ReceivingBankId = c.String(),
                        ReceivingSubBank = c.String(),
                        ReceivingSubBankId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPaymentApplyRestaurants",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RestaurantId = c.String(),
                        PaymentApplyId = c.String(),
                        TravelPersonnel = c.String(),
                        Position = c.String(),
                        DateFrom = c.DateTime(),
                        DateEnd = c.DateTime(),
                        Address = c.String(),
                        StandardCost = c.Decimal(precision: 18, scale: 2),
                        Days = c.Decimal(precision: 18, scale: 2),
                        PersionNumber = c.Int(),
                        ReceptionNumber = c.Decimal(precision: 18, scale: 2),
                        CutNumber = c.Decimal(precision: 18, scale: 2),
                        BoardNumber = c.Decimal(precision: 18, scale: 2),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        LunchAllowance = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPaymentApplyStatistics",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PaymentApplyStatisticsId = c.String(),
                        PaymentApplyId = c.String(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        CostCenterCode = c.String(),
                        CostCenterName = c.String(),
                        ApplyAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrentMonthPlanAmount = c.Decimal(precision: 18, scale: 2),
                        BudgetAmount = c.Decimal(precision: 18, scale: 2),
                        PaidAmount = c.Decimal(precision: 18, scale: 2),
                        ApprovedNoPaidAmount = c.Decimal(precision: 18, scale: 2),
                        ApprovingApplyAmount = c.Decimal(precision: 18, scale: 2),
                        WaittingSubmitAmount = c.Decimal(precision: 18, scale: 2),
                        DimensionType = c.Int(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        CostCenterAlias = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPaymentBusinessMaps",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MapId = c.String(),
                        PaymentApplyId = c.String(),
                        BusinessExecutionId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPaymentLoanMaps",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MapId = c.String(),
                        PaymentApplyDetailId = c.String(),
                        LoanId = c.String(),
                        OffsetAmount = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPaymentNewsletters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NewsletterId = c.String(),
                        PaymentApplyId = c.String(),
                        Sort = c.Int(),
                        UserId = c.String(),
                        UserName = c.String(),
                        Overview = c.String(),
                        MonthCount = c.Int(),
                        Amount = c.Decimal(precision: 18, scale: 2),
                        AvgAmount = c.Decimal(precision: 18, scale: 2),
                        ReimbursementCriteria = c.String(),
                        ExcessiveDesc = c.String(),
                        Subtotal = c.Decimal(precision: 18, scale: 2),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPaymentTravels",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TravelId = c.String(),
                        PaymentApplyId = c.String(),
                        Sort = c.Int(),
                        TravelArea = c.String(),
                        TravelAreaName = c.String(),
                        TravelDay = c.Int(),
                        TotalPrice = c.Decimal(precision: 18, scale: 2),
                        DayOfPrice = c.Decimal(precision: 18, scale: 2),
                        ReimbursementCriteria = c.String(),
                        ExcessiveDesc = c.String(),
                        Subtotal = c.Decimal(precision: 18, scale: 2),
                        F1 = c.String(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPerformancePlans",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PerformancePlanId = c.String(),
                        ContractId = c.String(),
                        RowNumber = c.Int(),
                        MoneyType = c.String(),
                        MoneyTypeName = c.String(),
                        PaymentNode = c.String(),
                        PaymentNodeName = c.String(),
                        PaymentTerms1 = c.String(),
                        PaymentTerms2 = c.String(),
                        PaymentTerms3 = c.String(),
                        PaymentCycle = c.String(),
                        PaymentCycleName = c.String(),
                        FirstPayDate = c.DateTime(),
                        ServiceDateStart = c.DateTime(),
                        ServiceDateEnd = c.DateTime(),
                        PayTimes = c.Int(),
                        ManDays = c.Int(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        SinglePaymentPercent = c.Decimal(precision: 18, scale: 2),
                        TotalAmount = c.Decimal(precision: 18, scale: 2),
                        TaxRate = c.Decimal(precision: 18, scale: 2),
                        Tax = c.Decimal(precision: 18, scale: 2),
                        ExcludingTax = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        SupplierCode = c.String(),
                        SupplierName = c.String(),
                        Status = c.Int(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        OriginalPerformancePlan = c.String(),
                        IsWarrantyGold = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbPositions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PositionId = c.Guid(nullable: false),
                        PositionCode = c.String(),
                        PositionName = c.String(),
                        OrgUnitCode = c.String(),
                        PositionLevel = c.String(),
                        Status = c.Int(),
                        InUsed = c.Int(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbProgressOutputValue0328",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProgressOutputValueId = c.String(),
                        ProgressSheetId = c.String(),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbProgressOutputValues",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProgressOutputValueId = c.String(),
                        ProgressSheetId = c.String(),
                        Month1 = c.Decimal(precision: 18, scale: 2),
                        Month2 = c.Decimal(precision: 18, scale: 2),
                        Month3 = c.Decimal(precision: 18, scale: 2),
                        Month4 = c.Decimal(precision: 18, scale: 2),
                        Month5 = c.Decimal(precision: 18, scale: 2),
                        Month6 = c.Decimal(precision: 18, scale: 2),
                        Month7 = c.Decimal(precision: 18, scale: 2),
                        Month8 = c.Decimal(precision: 18, scale: 2),
                        Month9 = c.Decimal(precision: 18, scale: 2),
                        Month10 = c.Decimal(precision: 18, scale: 2),
                        Month11 = c.Decimal(precision: 18, scale: 2),
                        Month12 = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbProgressSheet_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbProgressSheets", t => t.TbProgressSheet_Id)
                .Index(t => t.TbProgressSheet_Id);
            
            CreateTable(
                "dbo.TbProgressSheets",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProgressSheetId = c.String(),
                        ContractId = c.String(),
                        Year = c.Int(),
                        ContractName = c.String(),
                        Month1 = c.Double(),
                        Month2 = c.Double(),
                        Month3 = c.Double(),
                        Month4 = c.Double(),
                        Month5 = c.Double(),
                        Month6 = c.Double(),
                        Month7 = c.Double(),
                        Month8 = c.Double(),
                        Month9 = c.Double(),
                        Month10 = c.Double(),
                        Month11 = c.Double(),
                        Month12 = c.Double(),
                        Remark = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbProgressSheet0328",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProgressSheetId = c.String(),
                        ContractId = c.String(),
                        Year = c.Int(),
                        ContractName = c.String(),
                        Month1 = c.Double(),
                        Month2 = c.Double(),
                        Month3 = c.Double(),
                        Month4 = c.Double(),
                        Month5 = c.Double(),
                        Month6 = c.Double(),
                        Month7 = c.Double(),
                        Month8 = c.Double(),
                        Month9 = c.Double(),
                        Month10 = c.Double(),
                        Month11 = c.Double(),
                        Month12 = c.Double(),
                        Remark = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbProjects",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProjectId = c.String(),
                        ProjectCode = c.String(),
                        ProjectName = c.String(),
                        Desc = c.String(),
                        AvailabilityDate = c.DateTime(),
                        ExpiryDate = c.DateTime(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        ProjectLevel = c.String(),
                        ProjectCodeInSap = c.String(),
                        OrgUnitGuid = c.String(),
                        Status = c.Int(),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbReimbursementStandards",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ReimbursementStandardId = c.String(),
                        RankId = c.String(),
                        RankCode = c.String(),
                        RankName = c.String(),
                        TravelAreaId = c.String(),
                        TravelAreaCode = c.String(),
                        TravelAreaName = c.String(),
                        ProjectId = c.String(),
                        ProjectCode = c.String(),
                        ProjectName = c.String(),
                        ControlStandards = c.Decimal(precision: 18, scale: 2),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbRemindContents",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RemindContentId = c.String(),
                        RemindQueueId = c.String(),
                        PersonId = c.String(),
                        Contract = c.String(),
                        Status = c.Int(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.String(),
                        CreateUserName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbRemindQueue_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbRemindQueues", t => t.TbRemindQueue_Id)
                .Index(t => t.TbRemindQueue_Id);
            
            CreateTable(
                "dbo.TbRemindQueues",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RemindQueueId = c.String(),
                        ContentKey = c.String(),
                        Type = c.String(),
                        AlreadyRate = c.Int(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.String(),
                        UpdateUserName = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        CreateUserName = c.String(),
                        UpdateUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbRemindSettings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RemindSettingId = c.String(),
                        Type = c.String(),
                        Advance = c.Int(),
                        Rate = c.Int(),
                        UpdateUser = c.String(),
                        UpdateUserName = c.String(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbServiceOrderDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OrderDetailId = c.String(),
                        OrderId = c.String(),
                        ServiceDate = c.DateTime(),
                        ServiceMatters = c.String(),
                        ContractAmount = c.Decimal(precision: 18, scale: 2),
                        TotalConfirmAmount = c.Decimal(precision: 18, scale: 2),
                        ThisConfirmAmount = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        TbServiceOrder_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbServiceOrders", t => t.TbServiceOrder_Id)
                .Index(t => t.TbServiceOrder_Id);
            
            CreateTable(
                "dbo.TbServiceOrders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OrderId = c.String(),
                        BlockId = c.String(),
                        SupplierId = c.String(),
                        PlanApplyId = c.String(),
                        PlanApplyName = c.String(),
                        ContractId = c.String(),
                        ContractName = c.String(),
                        BudgetItemId = c.String(),
                        CostCenterId = c.String(),
                        CreatorDeptId = c.String(),
                        CreatorDeptName = c.String(),
                        IsSeeAmount = c.Boolean(),
                        Summary = c.String(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbStandardContractContent1",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ContractId = c.String(),
                        ContractTemplateId = c.String(),
                        ContentId = c.String(),
                        OrderIndex = c.Int(),
                        PageIndex = c.Int(),
                        ParagraphContent = c.String(),
                        IsEdit = c.Int(),
                        IsMainPoints = c.Int(),
                        IsNeedAttach = c.Int(),
                        Vision = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        IsLvyue = c.Int(),
                        LvyueTableName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbSubBudgetLItemRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        SubBudgetItemId = c.String(),
                        OrgUnitGuid = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbSubBudgetLItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SubBudgetItemId = c.String(),
                        BudgetSubTypeId = c.String(),
                        BudgettemCode = c.String(),
                        BudgetlItemName = c.String(),
                        Describe = c.String(),
                        OrderIndex = c.Int(),
                        Status = c.Int(),
                        Creator = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                        IsNeedContract = c.Int(),
                        IsNeedPay = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbSupplierAssesses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AssessId = c.String(),
                        CooperationRecordId = c.String(),
                        Score = c.String(),
                        IntegratedScore = c.Decimal(precision: 18, scale: 2),
                        ServiceAttitude = c.Int(),
                        OnTimeDelivery = c.Int(),
                        ReasonablePrice = c.Int(),
                        Quality = c.Int(),
                        Content = c.String(),
                        SupplierId = c.String(),
                        SupplierName = c.String(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.String(),
                        TbSupplierCooperationRecord_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbSupplierCooperationRecords", t => t.TbSupplierCooperationRecord_Id)
                .Index(t => t.TbSupplierCooperationRecord_Id);
            
            CreateTable(
                "dbo.TbSupplierCooperationRecords",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CooperationRecordId = c.String(),
                        SupplierId = c.String(),
                        ProjectId = c.String(),
                        ContractId = c.String(),
                        CreatorLoginId = c.String(),
                        CreatorName = c.String(),
                        Score = c.String(),
                        AvgScore = c.Decimal(precision: 18, scale: 2),
                        LowScore = c.Decimal(precision: 18, scale: 2),
                        Content = c.String(),
                        CreateDate = c.DateTime(),
                        TbSupplierBasic_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbSupplierBasics", t => t.TbSupplierBasic_Id)
                .Index(t => t.TbSupplierBasic_Id);
            
            CreateTable(
                "dbo.TbSupplierBasics",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SupplierId = c.String(),
                        SupplierNo = c.String(),
                        CompanyName = c.String(),
                        CompanyEnName = c.String(),
                        LegalRepresen = c.String(),
                        CompanyType = c.String(),
                        SocialCreditCode = c.String(),
                        LicenseNo = c.String(),
                        TaxRegisterNo = c.String(),
                        OrgNo = c.String(),
                        OrgUnitGuid = c.String(),
                        OrgUnitName = c.String(),
                        TaxRate = c.String(),
                        SupplierCategory = c.String(),
                        Status = c.String(),
                        Label = c.String(),
                        Creator = c.String(),
                        CreatorName = c.String(),
                        CreatorDeptId = c.String(),
                        CreatorDeptName = c.String(),
                        ModifyDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        Procinstid = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        ApproveStatus = c.String(),
                        ModifyId = c.String(),
                        ModifyName = c.String(),
                        ModifyOrgUnitGuid = c.String(),
                        ModifyOrgUnitName = c.String(),
                        OriginalSupplierNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbSupplierBanks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SupplierBankId = c.String(),
                        SupplierId = c.String(),
                        BankName = c.String(),
                        City = c.String(),
                        BankBranch = c.String(),
                        BankAccount = c.String(),
                        CreateDate = c.DateTime(),
                        ParameterId = c.String(),
                        Creator = c.String(),
                        TbSupplierBasic_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbSupplierBasics", t => t.TbSupplierBasic_Id)
                .Index(t => t.TbSupplierBasic_Id);
            
            CreateTable(
                "dbo.TbSupplierCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CategoryId = c.String(),
                        SupplierId = c.String(),
                        Code = c.String(),
                        Name = c.String(),
                        TbSupplierBasic_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbSupplierBasics", t => t.TbSupplierBasic_Id)
                .Index(t => t.TbSupplierBasic_Id);
            
            CreateTable(
                "dbo.TbSupplierContacts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SupplierContactId = c.String(),
                        SupplierId = c.String(),
                        City = c.String(),
                        CityName = c.String(),
                        Address = c.String(),
                        ContactName = c.String(),
                        Mobile = c.String(),
                        Tel = c.String(),
                        Email = c.String(),
                        Remark = c.String(),
                        CreateDate = c.DateTime(),
                        TbSupplierBasic_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TbSupplierBasics", t => t.TbSupplierBasic_Id)
                .Index(t => t.TbSupplierBasic_Id);
            
            CreateTable(
                "dbo.TbSupplierOrgUnitRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.String(),
                        SupplierId = c.String(),
                        OrgUnitGuid = c.String(),
                        OrgUnitGuidName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbTrafficStandards",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TrafficStandardId = c.String(),
                        RankId = c.String(),
                        RankCode = c.String(),
                        RankName = c.String(),
                        ProjectId = c.String(),
                        ProjectCode = c.String(),
                        ProjectName = c.String(),
                        ControlStandardIDs = c.String(),
                        ControlStandardName = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbUserCityRecents",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CityRecentId = c.String(),
                        UserId = c.String(),
                        CityId = c.Int(nullable: false),
                        CityName = c.String(),
                        Times = c.Int(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbUserPositionRelates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RelateId = c.Guid(nullable: false),
                        UserId = c.String(),
                        PositionId = c.Guid(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbWeekdaysAndHolidays",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DaysId = c.String(),
                        WhName = c.String(),
                        Dates = c.DateTime(),
                        DayType = c.String(),
                        Remark = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                        F3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbWorkFlowInProgresses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        InProgressId = c.String(),
                        KeyValue = c.String(),
                        KeyType = c.String(),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TbWorkflowLists",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        WorkFlowId = c.Int(nullable: false),
                        WorkflowCode = c.String(),
                        WorkflowName = c.String(),
                        Desc = c.String(),
                        F1 = c.String(),
                        F2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TbSupplierCooperationRecords", "TbSupplierBasic_Id", "dbo.TbSupplierBasics");
            DropForeignKey("dbo.TbSupplierContacts", "TbSupplierBasic_Id", "dbo.TbSupplierBasics");
            DropForeignKey("dbo.TbSupplierCategories", "TbSupplierBasic_Id", "dbo.TbSupplierBasics");
            DropForeignKey("dbo.TbSupplierBanks", "TbSupplierBasic_Id", "dbo.TbSupplierBasics");
            DropForeignKey("dbo.TbSupplierAssesses", "TbSupplierCooperationRecord_Id", "dbo.TbSupplierCooperationRecords");
            DropForeignKey("dbo.TbServiceOrderDetails", "TbServiceOrder_Id", "dbo.TbServiceOrders");
            DropForeignKey("dbo.TbRemindContents", "TbRemindQueue_Id", "dbo.TbRemindQueues");
            DropForeignKey("dbo.TbProgressOutputValues", "TbProgressSheet_Id", "dbo.TbProgressSheets");
            DropForeignKey("dbo.TbRepaymentsDetails", "TbLoanApplyReceivingInfo_Id", "dbo.TbLoanApplyReceivingInfoes");
            DropForeignKey("dbo.TbLoanApplyReceivingInfoes", "TbLoanApply_Id", "dbo.TbLoanApplies");
            DropForeignKey("dbo.TbSpareMoneyRepaymentsDetails", "TbPaymentApply_Id", "dbo.TbPaymentApplies");
            DropForeignKey("dbo.TbPaymentTraffics", "TbPaymentApply_Id", "dbo.TbPaymentApplies");
            DropForeignKey("dbo.TbPaymentStays", "TbPaymentApply_Id", "dbo.TbPaymentApplies");
            DropForeignKey("dbo.TbPaymentOthers", "TbPaymentApply_Id", "dbo.TbPaymentApplies");
            DropForeignKey("dbo.TbPaymentApplyDetails", "TbPaymentApply_Id", "dbo.TbPaymentApplies");
            DropForeignKey("dbo.TbInvoices", "TbPaymentApply_Id", "dbo.TbPaymentApplies");
            DropForeignKey("dbo.TbInvoiceDetails", "TbInvoice_Id", "dbo.TbInvoices");
            DropForeignKey("dbo.TbGroupDetails", "TbGroup_Id", "dbo.TbGroups");
            DropForeignKey("dbo.TbCorporateBankAccounts", "TbCorporate_Id", "dbo.TbCorporates");
            DropForeignKey("dbo.TbContractStatistics", "TbContract_Id", "dbo.TbContracts");
            DropForeignKey("dbo.TbContractSelects", "TbContract_Id", "dbo.TbContracts");
            DropForeignKey("dbo.TbContractRelatePlans", "TbContract_Id", "dbo.TbContracts");
            DropForeignKey("dbo.TbContractPayPlans", "TbContract_Id", "dbo.TbContracts");
            DropForeignKey("dbo.TbContractDetails", "TbContract_Id", "dbo.TbContracts");
            DropForeignKey("dbo.TbMaterialsRecipients", "TbBusinessExecution_Id", "dbo.TbBusinessExecutions");
            DropForeignKey("dbo.TbMaterialsDetails", "TbBusinessExecution_Id", "dbo.TbBusinessExecutions");
            DropForeignKey("dbo.TbBusinessExecutionDetails", "TbBusinessExecution_Id", "dbo.TbBusinessExecutions");
            DropForeignKey("dbo.TbBudgetPlanCostCenterYearDetailV3", "TbBudgetPlanCostCenterV3_Id", "dbo.TbBudgetPlanCostCenterV3");
            DropForeignKey("dbo.TbBudgetPlanCostCenterMonthDetailV3", "TbBudgetPlanCostCenterYearDetailV3_Id", "dbo.TbBudgetPlanCostCenterYearDetailV3");
            DropForeignKey("dbo.TbOrgUserRelates", "TbUser_Id", "dbo.TbUsers");
            DropForeignKey("dbo.TbPaymentSigns", "TbOrganizationUnit_Id", "dbo.TbOrganizationUnits");
            DropForeignKey("dbo.TbOrgUserRelates", "TbOrganizationUnit_Id", "dbo.TbOrganizationUnits");
            DropForeignKey("dbo.TbDeptCategoryRelates", "TbOrganizationUnit_Id", "dbo.TbOrganizationUnits");
            DropForeignKey("dbo.TbDeptCategoryRelates", "TbDeptCategory_Id", "dbo.TbDeptCategories");
            DropForeignKey("dbo.TbBudgetPlanVersions", "TbOrganizationUnit_Id", "dbo.TbOrganizationUnits");
            DropForeignKey("dbo.TbBudgetPlanCostCenters", "TbCostCenter_Id", "dbo.TbCostCenters");
            DropForeignKey("dbo.TbBudgetBaseInfoRelates", "TbCostCenter_Id", "dbo.TbCostCenters");
            DropForeignKey("dbo.TbMonthlyPayPlanMains", "TbYear_Id", "dbo.TbYears");
            DropForeignKey("dbo.TbMonthlyPayPlanMains", "TbOrganizationUnit_Id", "dbo.TbOrganizationUnits");
            DropForeignKey("dbo.TbMonthlyPayPlanBudgetItems", "TbMonthlyPayPlanMain_Id", "dbo.TbMonthlyPayPlanMains");
            DropForeignKey("dbo.TbMonthlyPayPlanCostCenters", "TbMonthlyPayPlanMain_Id", "dbo.TbMonthlyPayPlanMains");
            DropForeignKey("dbo.TbMonthlyPayPlanBudgetItem1", "TbMonthlyPayPlanCostCenter_Id", "dbo.TbMonthlyPayPlanCostCenters");
            DropForeignKey("dbo.TbMonthlyPayPlanCostCenters", "TbCostCenter_Id", "dbo.TbCostCenters");
            DropForeignKey("dbo.TbMonthlyPayPlanBudgetItem1", "TbMonthlyPayPlanBudgetItem_Id", "dbo.TbMonthlyPayPlanBudgetItems");
            DropForeignKey("dbo.TbMonthlyPayPlanMainDrafts", "TbYear_Id", "dbo.TbYears");
            DropForeignKey("dbo.TbMonthlyPayPlanMainDrafts", "TbOrganizationUnit_Id", "dbo.TbOrganizationUnits");
            DropForeignKey("dbo.TbMonthlyPayPlanCostCenterDrafts", "TbMonthlyPayPlanMainDraft_Id", "dbo.TbMonthlyPayPlanMainDrafts");
            DropForeignKey("dbo.TbMonthlyPayPlanBudgetItemsDrafts", "TbMonthlyPayPlanCostCenterDraft_Id", "dbo.TbMonthlyPayPlanCostCenterDrafts");
            DropForeignKey("dbo.TbPlanApplyDetails", "TbYear_Id", "dbo.TbYears");
            DropForeignKey("dbo.TbPlanApplyDetails", "TbPlanApply_Id", "dbo.TbPlanApplies");
            DropForeignKey("dbo.TbPlanApplies", "TbCostCenter_Id", "dbo.TbCostCenters");
            DropForeignKey("dbo.TbPlanApplies", "TbBudgetItem_Id", "dbo.TbBudgetItems");
            DropForeignKey("dbo.TbPlanApplies", "TbBlock_Id", "dbo.TbBlocks");
            DropForeignKey("dbo.TbMonthlyPayPlanBudgetItemsDrafts", "TbBudgetItem_Id", "dbo.TbBudgetItems");
            DropForeignKey("dbo.TbTemplateBudgetRelates", "TbContractTemplate_Id", "dbo.TbContractTemplates");
            DropForeignKey("dbo.TbStandardContractContents", "TbContractTemplate_Id", "dbo.TbContractTemplates");
            DropForeignKey("dbo.TbTemplateBudgetRelates", "TbBudgetSubType_Id", "dbo.TbBudgetSubTypes");
            DropForeignKey("dbo.TbCostCenterBudgetSubTypeRelates", "TbCostCenter_Id", "dbo.TbCostCenters");
            DropForeignKey("dbo.TbCostCenterBudgetSubTypeRelates", "TbBudgetSubType_Id", "dbo.TbBudgetSubTypes");
            DropForeignKey("dbo.TbBudgetSubTypes", "TbBudgetType_Id", "dbo.TbBudgetTypes");
            DropForeignKey("dbo.TbBudgetItemSubTypeRelates", "TbBudgetSubType_Id", "dbo.TbBudgetSubTypes");
            DropForeignKey("dbo.TbBudgetItemSubTypeRelates", "TbBudgetItem_Id", "dbo.TbBudgetItems");
            DropForeignKey("dbo.TbBudgetControlDetails", "TbBudgetItem_Id", "dbo.TbBudgetItems");
            DropForeignKey("dbo.TbBudgetControlDetails", "TbBudgetControl_Id", "dbo.TbBudgetControls");
            DropForeignKey("dbo.TbBudgetBaseInfoRelates", "TbBudgetItem_Id", "dbo.TbBudgetItems");
            DropForeignKey("dbo.TbBudgetAccountingRelates", "TbBudgetItem_Id", "dbo.TbBudgetItems");
            DropForeignKey("dbo.TbBudgetAccountingRelates", "TbAccountingItem_Id", "dbo.TbAccountingItems");
            DropForeignKey("dbo.TbMonthlyPayPlanCostCenterDrafts", "TbCostCenter_Id", "dbo.TbCostCenters");
            DropForeignKey("dbo.TbBudgetPlanVersionV2", "TbYear_Id", "dbo.TbYears");
            DropForeignKey("dbo.TbBudgetPlanVersionV1", "TbYear_Id", "dbo.TbYears");
            DropForeignKey("dbo.TbBudgetPlanVersionV2", "TbBudgetVersionType_Id", "dbo.TbBudgetVersionTypes");
            DropForeignKey("dbo.TbBudgetPlanVersionV1", "TbBudgetVersionType_Id", "dbo.TbBudgetVersionTypes");
            DropForeignKey("dbo.TbBudgetPlanVersionV2", "TbBudgetType_Id", "dbo.TbBudgetTypes");
            DropForeignKey("dbo.TbBudgetPlanCostCenterV2", "TbCostCenter_Id", "dbo.TbCostCenters");
            DropForeignKey("dbo.TbBudgetPlanCostCenterV2", "TbBudgetPlanVersionV2_Id", "dbo.TbBudgetPlanVersionV2");
            DropForeignKey("dbo.TbBudgetPlanCostCenterYearDetailV2", "TbBudgetPlanCostCenterV2_Id", "dbo.TbBudgetPlanCostCenterV2");
            DropForeignKey("dbo.TbBudgetPlanCostCenterMonthDetailV2", "TbBudgetPlanCostCenterYearDetailV2_Id", "dbo.TbBudgetPlanCostCenterYearDetailV2");
            DropForeignKey("dbo.TbBudgetGenerates", "TbBudgetPlanCostCenterMonthDetailV2_Id", "dbo.TbBudgetPlanCostCenterMonthDetailV2");
            DropForeignKey("dbo.TbBudgetGenerateDetails", "TbBudgetGenerate_Id", "dbo.TbBudgetGenerates");
            DropForeignKey("dbo.TbBudgetPlanCostCenterMonthDetailV2", "TbBudgetAdjustment_Id", "dbo.TbBudgetAdjustments");
            DropForeignKey("dbo.TbBudgetAdjustmentDetails", "TbBudgetAdjustment_Id", "dbo.TbBudgetAdjustments");
            DropForeignKey("dbo.TbBudgetPlanVersionV2", "TbBlock_Id", "dbo.TbBlocks");
            DropForeignKey("dbo.TbBudgetPlanVersionV1", "TbBudgetType_Id", "dbo.TbBudgetTypes");
            DropForeignKey("dbo.TbBudgetPlanVersions", "TbBudgetType_Id", "dbo.TbBudgetTypes");
            DropForeignKey("dbo.TbBudgetPlanCostCenterV1", "TbCostCenter_Id", "dbo.TbCostCenters");
            DropForeignKey("dbo.TbBudgetPlanCostCenterV1", "TbBudgetPlanVersionV1_Id", "dbo.TbBudgetPlanVersionV1");
            DropForeignKey("dbo.TbBudgetPlanCostCenterYearDetailV1", "TbBudgetPlanCostCenterV1_Id", "dbo.TbBudgetPlanCostCenterV1");
            DropForeignKey("dbo.TbBudgetPlanCostCenterMonthDetailV1", "TbBudgetPlanCostCenterYearDetailV1_Id", "dbo.TbBudgetPlanCostCenterYearDetailV1");
            DropForeignKey("dbo.TbBudgetPlanVersionV1", "TbBlock_Id", "dbo.TbBlocks");
            DropForeignKey("dbo.TbBudgetBaseInfoRelates", "TbBlock_Id", "dbo.TbBlocks");
            DropForeignKey("dbo.TbBudgetPlanCostCenters", "TbBudgetPlanVersion_Id", "dbo.TbBudgetPlanVersions");
            DropForeignKey("dbo.TbBudgetPlanBudgetItems", "TbBudgetPlanCostCenter_Id", "dbo.TbBudgetPlanCostCenters");
            DropForeignKey("dbo.SysUserRoles", "TbUser_Id", "dbo.TbUsers");
            DropForeignKey("dbo.SysUserRoles", "SysRole_Id", "dbo.SysRoles");
            DropForeignKey("dbo.SysRoleRights", "SysRole_Id", "dbo.SysRoles");
            DropForeignKey("dbo.SysDataRights", "SysRole_Id", "dbo.SysRoles");
            DropForeignKey("dbo.SysRoleRights", "SysModule_Id", "dbo.SysModules");
            DropForeignKey("dbo.SysModuleDetailInfoes", "SysModule_Id", "dbo.SysModules");
            DropForeignKey("dbo.SysDataRights", "SysModule_Id", "dbo.SysModules");
            DropForeignKey("dbo.AppServiceParameters", "AppServiceInfo_Id", "dbo.AppServiceInfoes");
            DropIndex("dbo.TbSupplierContacts", new[] { "TbSupplierBasic_Id" });
            DropIndex("dbo.TbSupplierCategories", new[] { "TbSupplierBasic_Id" });
            DropIndex("dbo.TbSupplierBanks", new[] { "TbSupplierBasic_Id" });
            DropIndex("dbo.TbSupplierCooperationRecords", new[] { "TbSupplierBasic_Id" });
            DropIndex("dbo.TbSupplierAssesses", new[] { "TbSupplierCooperationRecord_Id" });
            DropIndex("dbo.TbServiceOrderDetails", new[] { "TbServiceOrder_Id" });
            DropIndex("dbo.TbRemindContents", new[] { "TbRemindQueue_Id" });
            DropIndex("dbo.TbProgressOutputValues", new[] { "TbProgressSheet_Id" });
            DropIndex("dbo.TbRepaymentsDetails", new[] { "TbLoanApplyReceivingInfo_Id" });
            DropIndex("dbo.TbLoanApplyReceivingInfoes", new[] { "TbLoanApply_Id" });
            DropIndex("dbo.TbSpareMoneyRepaymentsDetails", new[] { "TbPaymentApply_Id" });
            DropIndex("dbo.TbPaymentTraffics", new[] { "TbPaymentApply_Id" });
            DropIndex("dbo.TbPaymentStays", new[] { "TbPaymentApply_Id" });
            DropIndex("dbo.TbPaymentOthers", new[] { "TbPaymentApply_Id" });
            DropIndex("dbo.TbPaymentApplyDetails", new[] { "TbPaymentApply_Id" });
            DropIndex("dbo.TbInvoices", new[] { "TbPaymentApply_Id" });
            DropIndex("dbo.TbInvoiceDetails", new[] { "TbInvoice_Id" });
            DropIndex("dbo.TbGroupDetails", new[] { "TbGroup_Id" });
            DropIndex("dbo.TbCorporateBankAccounts", new[] { "TbCorporate_Id" });
            DropIndex("dbo.TbContractStatistics", new[] { "TbContract_Id" });
            DropIndex("dbo.TbContractSelects", new[] { "TbContract_Id" });
            DropIndex("dbo.TbContractRelatePlans", new[] { "TbContract_Id" });
            DropIndex("dbo.TbContractPayPlans", new[] { "TbContract_Id" });
            DropIndex("dbo.TbContractDetails", new[] { "TbContract_Id" });
            DropIndex("dbo.TbMaterialsRecipients", new[] { "TbBusinessExecution_Id" });
            DropIndex("dbo.TbMaterialsDetails", new[] { "TbBusinessExecution_Id" });
            DropIndex("dbo.TbBusinessExecutionDetails", new[] { "TbBusinessExecution_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenterYearDetailV3", new[] { "TbBudgetPlanCostCenterV3_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenterMonthDetailV3", new[] { "TbBudgetPlanCostCenterYearDetailV3_Id" });
            DropIndex("dbo.TbPaymentSigns", new[] { "TbOrganizationUnit_Id" });
            DropIndex("dbo.TbDeptCategoryRelates", new[] { "TbOrganizationUnit_Id" });
            DropIndex("dbo.TbDeptCategoryRelates", new[] { "TbDeptCategory_Id" });
            DropIndex("dbo.TbMonthlyPayPlanCostCenters", new[] { "TbMonthlyPayPlanMain_Id" });
            DropIndex("dbo.TbMonthlyPayPlanCostCenters", new[] { "TbCostCenter_Id" });
            DropIndex("dbo.TbMonthlyPayPlanBudgetItem1", new[] { "TbMonthlyPayPlanCostCenter_Id" });
            DropIndex("dbo.TbMonthlyPayPlanBudgetItem1", new[] { "TbMonthlyPayPlanBudgetItem_Id" });
            DropIndex("dbo.TbMonthlyPayPlanBudgetItems", new[] { "TbMonthlyPayPlanMain_Id" });
            DropIndex("dbo.TbMonthlyPayPlanMains", new[] { "TbYear_Id" });
            DropIndex("dbo.TbMonthlyPayPlanMains", new[] { "TbOrganizationUnit_Id" });
            DropIndex("dbo.TbPlanApplyDetails", new[] { "TbYear_Id" });
            DropIndex("dbo.TbPlanApplyDetails", new[] { "TbPlanApply_Id" });
            DropIndex("dbo.TbPlanApplies", new[] { "TbCostCenter_Id" });
            DropIndex("dbo.TbPlanApplies", new[] { "TbBudgetItem_Id" });
            DropIndex("dbo.TbPlanApplies", new[] { "TbBlock_Id" });
            DropIndex("dbo.TbStandardContractContents", new[] { "TbContractTemplate_Id" });
            DropIndex("dbo.TbTemplateBudgetRelates", new[] { "TbContractTemplate_Id" });
            DropIndex("dbo.TbTemplateBudgetRelates", new[] { "TbBudgetSubType_Id" });
            DropIndex("dbo.TbCostCenterBudgetSubTypeRelates", new[] { "TbCostCenter_Id" });
            DropIndex("dbo.TbCostCenterBudgetSubTypeRelates", new[] { "TbBudgetSubType_Id" });
            DropIndex("dbo.TbBudgetSubTypes", new[] { "TbBudgetType_Id" });
            DropIndex("dbo.TbBudgetItemSubTypeRelates", new[] { "TbBudgetSubType_Id" });
            DropIndex("dbo.TbBudgetItemSubTypeRelates", new[] { "TbBudgetItem_Id" });
            DropIndex("dbo.TbBudgetControlDetails", new[] { "TbBudgetItem_Id" });
            DropIndex("dbo.TbBudgetControlDetails", new[] { "TbBudgetControl_Id" });
            DropIndex("dbo.TbBudgetAccountingRelates", new[] { "TbBudgetItem_Id" });
            DropIndex("dbo.TbBudgetAccountingRelates", new[] { "TbAccountingItem_Id" });
            DropIndex("dbo.TbMonthlyPayPlanBudgetItemsDrafts", new[] { "TbMonthlyPayPlanCostCenterDraft_Id" });
            DropIndex("dbo.TbMonthlyPayPlanBudgetItemsDrafts", new[] { "TbBudgetItem_Id" });
            DropIndex("dbo.TbMonthlyPayPlanCostCenterDrafts", new[] { "TbMonthlyPayPlanMainDraft_Id" });
            DropIndex("dbo.TbMonthlyPayPlanCostCenterDrafts", new[] { "TbCostCenter_Id" });
            DropIndex("dbo.TbMonthlyPayPlanMainDrafts", new[] { "TbYear_Id" });
            DropIndex("dbo.TbMonthlyPayPlanMainDrafts", new[] { "TbOrganizationUnit_Id" });
            DropIndex("dbo.TbBudgetGenerateDetails", new[] { "TbBudgetGenerate_Id" });
            DropIndex("dbo.TbBudgetGenerates", new[] { "TbBudgetPlanCostCenterMonthDetailV2_Id" });
            DropIndex("dbo.TbBudgetAdjustmentDetails", new[] { "TbBudgetAdjustment_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenterMonthDetailV2", new[] { "TbBudgetPlanCostCenterYearDetailV2_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenterMonthDetailV2", new[] { "TbBudgetAdjustment_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenterYearDetailV2", new[] { "TbBudgetPlanCostCenterV2_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenterV2", new[] { "TbCostCenter_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenterV2", new[] { "TbBudgetPlanVersionV2_Id" });
            DropIndex("dbo.TbBudgetPlanVersionV2", new[] { "TbYear_Id" });
            DropIndex("dbo.TbBudgetPlanVersionV2", new[] { "TbBudgetVersionType_Id" });
            DropIndex("dbo.TbBudgetPlanVersionV2", new[] { "TbBudgetType_Id" });
            DropIndex("dbo.TbBudgetPlanVersionV2", new[] { "TbBlock_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenterMonthDetailV1", new[] { "TbBudgetPlanCostCenterYearDetailV1_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenterYearDetailV1", new[] { "TbBudgetPlanCostCenterV1_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenterV1", new[] { "TbCostCenter_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenterV1", new[] { "TbBudgetPlanVersionV1_Id" });
            DropIndex("dbo.TbBudgetPlanVersionV1", new[] { "TbYear_Id" });
            DropIndex("dbo.TbBudgetPlanVersionV1", new[] { "TbBudgetVersionType_Id" });
            DropIndex("dbo.TbBudgetPlanVersionV1", new[] { "TbBudgetType_Id" });
            DropIndex("dbo.TbBudgetPlanVersionV1", new[] { "TbBlock_Id" });
            DropIndex("dbo.TbBudgetBaseInfoRelates", new[] { "TbCostCenter_Id" });
            DropIndex("dbo.TbBudgetBaseInfoRelates", new[] { "TbBudgetItem_Id" });
            DropIndex("dbo.TbBudgetBaseInfoRelates", new[] { "TbBlock_Id" });
            DropIndex("dbo.TbBudgetPlanBudgetItems", new[] { "TbBudgetPlanCostCenter_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenters", new[] { "TbCostCenter_Id" });
            DropIndex("dbo.TbBudgetPlanCostCenters", new[] { "TbBudgetPlanVersion_Id" });
            DropIndex("dbo.TbBudgetPlanVersions", new[] { "TbOrganizationUnit_Id" });
            DropIndex("dbo.TbBudgetPlanVersions", new[] { "TbBudgetType_Id" });
            DropIndex("dbo.TbOrgUserRelates", new[] { "TbUser_Id" });
            DropIndex("dbo.TbOrgUserRelates", new[] { "TbOrganizationUnit_Id" });
            DropIndex("dbo.SysUserRoles", new[] { "TbUser_Id" });
            DropIndex("dbo.SysUserRoles", new[] { "SysRole_Id" });
            DropIndex("dbo.SysRoleRights", new[] { "SysRole_Id" });
            DropIndex("dbo.SysRoleRights", new[] { "SysModule_Id" });
            DropIndex("dbo.SysModuleDetailInfoes", new[] { "SysModule_Id" });
            DropIndex("dbo.SysDataRights", new[] { "SysRole_Id" });
            DropIndex("dbo.SysDataRights", new[] { "SysModule_Id" });
            DropIndex("dbo.AppServiceParameters", new[] { "AppServiceInfo_Id" });
            DropTable("dbo.TbWorkflowLists");
            DropTable("dbo.TbWorkFlowInProgresses");
            DropTable("dbo.TbWeekdaysAndHolidays");
            DropTable("dbo.TbUserPositionRelates");
            DropTable("dbo.TbUserCityRecents");
            DropTable("dbo.TbTrafficStandards");
            DropTable("dbo.TbSupplierOrgUnitRelates");
            DropTable("dbo.TbSupplierContacts");
            DropTable("dbo.TbSupplierCategories");
            DropTable("dbo.TbSupplierBanks");
            DropTable("dbo.TbSupplierBasics");
            DropTable("dbo.TbSupplierCooperationRecords");
            DropTable("dbo.TbSupplierAssesses");
            DropTable("dbo.TbSubBudgetLItems");
            DropTable("dbo.TbSubBudgetLItemRelates");
            DropTable("dbo.TbStandardContractContent1");
            DropTable("dbo.TbServiceOrders");
            DropTable("dbo.TbServiceOrderDetails");
            DropTable("dbo.TbRemindSettings");
            DropTable("dbo.TbRemindQueues");
            DropTable("dbo.TbRemindContents");
            DropTable("dbo.TbReimbursementStandards");
            DropTable("dbo.TbProjects");
            DropTable("dbo.TbProgressSheet0328");
            DropTable("dbo.TbProgressSheets");
            DropTable("dbo.TbProgressOutputValues");
            DropTable("dbo.TbProgressOutputValue0328");
            DropTable("dbo.TbPositions");
            DropTable("dbo.TbPerformancePlans");
            DropTable("dbo.TbPaymentTravels");
            DropTable("dbo.TbPaymentNewsletters");
            DropTable("dbo.TbPaymentLoanMaps");
            DropTable("dbo.TbPaymentBusinessMaps");
            DropTable("dbo.TbPaymentApplyStatistics");
            DropTable("dbo.TbPaymentApplyRestaurants");
            DropTable("dbo.TbPaymentApplyReceivingInfoes");
            DropTable("dbo.TbPaymentApplyAttachments");
            DropTable("dbo.TbOrganizationUnitBaks");
            DropTable("dbo.TbOperationRecords");
            DropTable("dbo.TbNotices");
            DropTable("dbo.TbMainShowSettings");
            DropTable("dbo.TbRepaymentsDetails");
            DropTable("dbo.TbLoanApplyReceivingInfoes");
            DropTable("dbo.TbLoanApplies");
            DropTable("dbo.TbSpareMoneyRepaymentsDetails");
            DropTable("dbo.TbPaymentTraffics");
            DropTable("dbo.TbPaymentStays");
            DropTable("dbo.TbPaymentOthers");
            DropTable("dbo.TbPaymentApplyDetails");
            DropTable("dbo.TbPaymentApplies");
            DropTable("dbo.TbInvoices");
            DropTable("dbo.TbInvoiceDetails");
            DropTable("dbo.TbHotelExpenses");
            DropTable("dbo.TbGroups");
            DropTable("dbo.TbGroupDetails");
            DropTable("dbo.TbFinancialDesks");
            DropTable("dbo.TbFinancialDeskBacks");
            DropTable("dbo.TbFinancialDesk1220");
            DropTable("dbo.TbFeeStandards");
            DropTable("dbo.TbCorporates");
            DropTable("dbo.TbCorporateBankAccounts");
            DropTable("dbo.TbContractStatistics");
            DropTable("dbo.TbContractSelects");
            DropTable("dbo.TbContractRelatePlans");
            DropTable("dbo.TbContractPayPlans");
            DropTable("dbo.TbContracts");
            DropTable("dbo.TbContractDetails");
            DropTable("dbo.TbContractClosingRecords");
            DropTable("dbo.TbContractAttachments");
            DropTable("dbo.TbContractApproves");
            DropTable("dbo.TbMaterialsRecipients");
            DropTable("dbo.TbMaterialsDetails");
            DropTable("dbo.TbBusinessExecutions");
            DropTable("dbo.TbBusinessExecutionDetails");
            DropTable("dbo.TbBudgetPlanVersionV3");
            DropTable("dbo.TbBudgetPlanFactAmounts");
            DropTable("dbo.TbBudgetPlanCostCenterV3");
            DropTable("dbo.TbBudgetPlanCostCenterYearDetailV3");
            DropTable("dbo.TbBudgetPlanCostCenterMonthDetailV3");
            DropTable("dbo.TbBudgetPlanAdjustments");
            DropTable("dbo.TbBudgetItemControls");
            DropTable("dbo.TbBudgetItemContractCategoryRelates");
            DropTable("dbo.TbBudgetGroups");
            DropTable("dbo.TbBudgetGroupMaps");
            DropTable("dbo.TbBudgetGenerateDetailBaks");
            DropTable("dbo.TbBudgetGenerateBaks");
            DropTable("dbo.TbBudgetAccountingRelateBaks");
            DropTable("dbo.TbBlockClosingRecords");
            DropTable("dbo.TbBlockBelongBorCRelates");
            DropTable("dbo.TbBelongBorCs");
            DropTable("dbo.TbBelongBorCCorporateRelates");
            DropTable("dbo.TbAttachments");
            DropTable("dbo.TbAccountingItemsBaks");
            DropTable("dbo.SysProvinces");
            DropTable("dbo.SysParameters");
            DropTable("dbo.SysManualMarks");
            DropTable("dbo.SysGeneratesequenceids");
            DropTable("dbo.SysDataRightsRelates");
            DropTable("dbo.TbPaymentSigns");
            DropTable("dbo.TbDeptCategories");
            DropTable("dbo.TbDeptCategoryRelates");
            DropTable("dbo.TbMonthlyPayPlanCostCenters");
            DropTable("dbo.TbMonthlyPayPlanBudgetItem1");
            DropTable("dbo.TbMonthlyPayPlanBudgetItems");
            DropTable("dbo.TbMonthlyPayPlanMains");
            DropTable("dbo.TbPlanApplyDetails");
            DropTable("dbo.TbPlanApplies");
            DropTable("dbo.TbStandardContractContents");
            DropTable("dbo.TbContractTemplates");
            DropTable("dbo.TbTemplateBudgetRelates");
            DropTable("dbo.TbCostCenterBudgetSubTypeRelates");
            DropTable("dbo.TbBudgetSubTypes");
            DropTable("dbo.TbBudgetItemSubTypeRelates");
            DropTable("dbo.TbBudgetControls");
            DropTable("dbo.TbBudgetControlDetails");
            DropTable("dbo.TbAccountingItems");
            DropTable("dbo.TbBudgetAccountingRelates");
            DropTable("dbo.TbBudgetItems");
            DropTable("dbo.TbMonthlyPayPlanBudgetItemsDrafts");
            DropTable("dbo.TbMonthlyPayPlanCostCenterDrafts");
            DropTable("dbo.TbMonthlyPayPlanMainDrafts");
            DropTable("dbo.TbYears");
            DropTable("dbo.TbBudgetVersionTypes");
            DropTable("dbo.TbBudgetGenerateDetails");
            DropTable("dbo.TbBudgetGenerates");
            DropTable("dbo.TbBudgetAdjustmentDetails");
            DropTable("dbo.TbBudgetAdjustments");
            DropTable("dbo.TbBudgetPlanCostCenterMonthDetailV2");
            DropTable("dbo.TbBudgetPlanCostCenterYearDetailV2");
            DropTable("dbo.TbBudgetPlanCostCenterV2");
            DropTable("dbo.TbBudgetPlanVersionV2");
            DropTable("dbo.TbBudgetTypes");
            DropTable("dbo.TbBudgetPlanCostCenterMonthDetailV1");
            DropTable("dbo.TbBudgetPlanCostCenterYearDetailV1");
            DropTable("dbo.TbBudgetPlanCostCenterV1");
            DropTable("dbo.TbBudgetPlanVersionV1");
            DropTable("dbo.TbBlocks");
            DropTable("dbo.TbBudgetBaseInfoRelates");
            DropTable("dbo.TbCostCenters");
            DropTable("dbo.TbBudgetPlanBudgetItems");
            DropTable("dbo.TbBudgetPlanCostCenters");
            DropTable("dbo.TbBudgetPlanVersions");
            DropTable("dbo.TbOrganizationUnits");
            DropTable("dbo.TbOrgUserRelates");
            DropTable("dbo.TbUsers");
            DropTable("dbo.SysUserRoles");
            DropTable("dbo.SysRoles");
            DropTable("dbo.SysRoleRights");
            DropTable("dbo.SysModuleDetailInfoes");
            DropTable("dbo.SysModules");
            DropTable("dbo.SysDataRights");
            DropTable("dbo.SysConfigurations");
            DropTable("dbo.SysCities");
            DropTable("dbo.SysActionLists");
            DropTable("dbo.StGenerateids");
            DropTable("dbo.OemsBudgetTypeT8Mapping");
            DropTable("dbo.MdmSuppliers");
            DropTable("dbo.MdmSupplierContacts");
            DropTable("dbo.LogXmlParms");
            DropTable("dbo.LogUseroperationLogOems");
            DropTable("dbo.LogLoginLogs");
            DropTable("dbo.LogExceptonLogs");
            DropTable("dbo.LogCloseLogs");
            DropTable("dbo.CallInterfaces");
            DropTable("dbo.AppServiceParameters");
            DropTable("dbo.AppServiceInfoes");
            DropTable("dbo.AppApplicationInfoes");
        }
    }
}
