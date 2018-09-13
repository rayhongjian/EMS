using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using EMS.Authorization.Roles;
using EMS.Authorization.Users;
using EMS.Entities;
using EMS.MultiTenancy;

namespace EMS.EntityFramework
{
    public class EMSDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        public IDbSet<AppApplicationInfo> AppApplicationInfoes { get; set; } // App_ApplicationInfo
        public IDbSet<AppServiceInfo> AppServiceInfoes { get; set; } // App_ServiceInfo
        public IDbSet<AppServiceParameter> AppServiceParameters { get; set; } // App_ServiceParameter
        public IDbSet<CallInterface> CallInterfaces { get; set; } // CALL_Interface
        public IDbSet<LogCloseLog> LogCloseLogs { get; set; } // Log_CloseLog
        public IDbSet<LogExceptonLog> LogExceptonLogs { get; set; } // Log_ExceptonLog
        public IDbSet<LogLoginLog> LogLoginLogs { get; set; } // Log_LoginLog
        public IDbSet<LogUseroperationLogOem> LogUseroperationLogOems { get; set; } // Log_UseroperationLog_OEMS
        public IDbSet<LogXmlParm> LogXmlParms { get; set; } // Log_XmlParms
        public IDbSet<MdmSupplier> MdmSuppliers { get; set; } // MDM_Supplier
        public IDbSet<MdmSupplierContact> MdmSupplierContacts { get; set; } // MDM_Supplier_Contacts
        public IDbSet<OemsBudgetTypeT8Mapping> OemsBudgetTypeT8Mapping { get; set; } // OEMS_BudgetType_T8_Mapping
        public IDbSet<StGenerateid> StGenerateids { get; set; } // ST_GENERATEID
        public IDbSet<SysActionList> SysActionLists { get; set; } // SYS_ActionList
        public IDbSet<SysCity> SysCities { get; set; } // SYS_City
        public IDbSet<SysConfiguration> SysConfigurations { get; set; } // SYS_CONFIGURATION
        public IDbSet<SysDataRight> SysDataRights { get; set; } // SYS_DataRights
        public IDbSet<SysDataRightsRelate> SysDataRightsRelates { get; set; } // SYS_DataRights_Relate
        public IDbSet<SysGeneratesequenceid> SysGeneratesequenceids { get; set; } // SYS_GENERATESEQUENCEID
        public IDbSet<SysManualMark> SysManualMarks { get; set; } // SYS_Manual_Mark
        public IDbSet<SysModule> SysModules { get; set; } // SYS_Module
        public IDbSet<SysModuleDetailInfo> SysModuleDetailInfoes { get; set; } // SYS_ModuleDetailInfo
        public IDbSet<SysParameter> SysParameters { get; set; } // SYS_Parameter
        public IDbSet<SysProvince> SysProvinces { get; set; } // SYS_Province
        public IDbSet<SysRole> SysRoles { get; set; } // SYS_Role
        public IDbSet<SysRoleRight> SysRoleRights { get; set; } // SYS_RoleRights
        public IDbSet<SysUserRole> SysUserRoles { get; set; } // SYS_UserRole
        public IDbSet<TbAccountingItem> TbAccountingItems { get; set; } // TB_Accounting_Items
        public IDbSet<TbAccountingItemsBak> TbAccountingItemsBaks { get; set; } // TB_Accounting_Items_bak
        public IDbSet<TbAttachment> TbAttachments { get; set; } // TB_Attachment
        public IDbSet<TbBelongBorC> TbBelongBorCs { get; set; } // Tb_BelongBorC
        public IDbSet<TbBelongBorCCorporateRelate> TbBelongBorCCorporateRelates { get; set; } // TB_BelongBorC_Corporate_Relate
        public IDbSet<TbBlock> TbBlocks { get; set; } // TB_Block
        public IDbSet<TbBlockBelongBorCRelate> TbBlockBelongBorCRelates { get; set; } // TB_Block_BelongBorC_Relate
        public IDbSet<TbBlockClosingRecord> TbBlockClosingRecords { get; set; } // TB_Block_ClosingRecord
        public IDbSet<TbBudgetAccountingRelate> TbBudgetAccountingRelates { get; set; } // TB_Budget_Accounting_Relate
        public IDbSet<TbBudgetAccountingRelateBak> TbBudgetAccountingRelateBaks { get; set; } // TB_Budget_Accounting_Relate_bak
        public IDbSet<TbBudgetAdjustment> TbBudgetAdjustments { get; set; } // TB_Budget_Adjustment
        public IDbSet<TbBudgetAdjustmentDetail> TbBudgetAdjustmentDetails { get; set; } // TB_Budget_Adjustment_Detail
        public IDbSet<TbBudgetBaseInfoRelate> TbBudgetBaseInfoRelates { get; set; } // TB_BudgetBaseInfo_Relate
        public IDbSet<TbBudgetControl> TbBudgetControls { get; set; } // TB_Budget_Control
        public IDbSet<TbBudgetControlDetail> TbBudgetControlDetails { get; set; } // TB_Budget_Control_Detail
        public IDbSet<TbBudgetGenerate> TbBudgetGenerates { get; set; } // TB_Budget_Generate
        public IDbSet<TbBudgetGenerateBak> TbBudgetGenerateBaks { get; set; } // TB_Budget_Generate_bak
        public IDbSet<TbBudgetGenerateDetail> TbBudgetGenerateDetails { get; set; } // TB_Budget_GenerateDetail
        public IDbSet<TbBudgetGenerateDetailBak> TbBudgetGenerateDetailBaks { get; set; } // TB_Budget_GenerateDetail_bak
        public IDbSet<TbBudgetGroup> TbBudgetGroups { get; set; } // Tb_BudgetGroup
        public IDbSet<TbBudgetGroupMap> TbBudgetGroupMaps { get; set; } // Tb_BudgetGroup_Map
        public IDbSet<TbBudgetItem> TbBudgetItems { get; set; } // TB_Budget_Item
        public IDbSet<TbBudgetItemContractCategoryRelate> TbBudgetItemContractCategoryRelates { get; set; } // TB_BudgetItem_ContractCategory_Relate
        public IDbSet<TbBudgetItemControl> TbBudgetItemControls { get; set; } // TB_BudgetItem_Control
        public IDbSet<TbBudgetItemSubTypeRelate> TbBudgetItemSubTypeRelates { get; set; } // TB_Budget_Item_SubType_Relate
        public IDbSet<TbBudgetPlanAdjustment> TbBudgetPlanAdjustments { get; set; } // TB_Budget_Plan_Adjustment
        public IDbSet<TbBudgetPlanBudgetItem> TbBudgetPlanBudgetItems { get; set; } // TB_Budget_Plan_Budget_Item
        public IDbSet<TbBudgetPlanCostCenter> TbBudgetPlanCostCenters { get; set; } // TB_Budget_Plan_CostCenter
        public IDbSet<TbBudgetPlanCostCenterMonthDetailV1> TbBudgetPlanCostCenterMonthDetailV1 { get; set; } // TB_Budget_Plan_CostCenter_MonthDetail_V1
        public IDbSet<TbBudgetPlanCostCenterMonthDetailV2> TbBudgetPlanCostCenterMonthDetailV2 { get; set; } // TB_Budget_Plan_CostCenter_MonthDetail_V2
        public IDbSet<TbBudgetPlanCostCenterMonthDetailV3> TbBudgetPlanCostCenterMonthDetailV3 { get; set; } // TB_Budget_Plan_CostCenter_MonthDetail_V3
        public IDbSet<TbBudgetPlanCostCenterV1> TbBudgetPlanCostCenterV1 { get; set; } // TB_Budget_Plan_CostCenter_V1
        public IDbSet<TbBudgetPlanCostCenterV2> TbBudgetPlanCostCenterV2 { get; set; } // TB_Budget_Plan_CostCenter_V2
        public IDbSet<TbBudgetPlanCostCenterV3> TbBudgetPlanCostCenterV3 { get; set; } // TB_Budget_Plan_CostCenter_V3
        public IDbSet<TbBudgetPlanCostCenterYearDetailV1> TbBudgetPlanCostCenterYearDetailV1 { get; set; } // TB_Budget_Plan_CostCenter_YearDetail_V1
        public IDbSet<TbBudgetPlanCostCenterYearDetailV2> TbBudgetPlanCostCenterYearDetailV2 { get; set; } // TB_Budget_Plan_CostCenter_YearDetail_V2
        public IDbSet<TbBudgetPlanCostCenterYearDetailV3> TbBudgetPlanCostCenterYearDetailV3 { get; set; } // TB_Budget_Plan_CostCenter_YearDetail_V3
        public IDbSet<TbBudgetPlanFactAmount> TbBudgetPlanFactAmounts { get; set; } // TB_Budget_Plan_FactAmount
        public IDbSet<TbBudgetPlanVersion> TbBudgetPlanVersions { get; set; } // TB_Budget_Plan_Version
        public IDbSet<TbBudgetPlanVersionV1> TbBudgetPlanVersionV1 { get; set; } // TB_Budget_Plan_Version_V1
        public IDbSet<TbBudgetPlanVersionV2> TbBudgetPlanVersionV2 { get; set; } // TB_Budget_Plan_Version_V2
        public IDbSet<TbBudgetPlanVersionV3> TbBudgetPlanVersionV3 { get; set; } // TB_Budget_Plan_Version_V3
        public IDbSet<TbBudgetSubType> TbBudgetSubTypes { get; set; } // TB_BudgetSubType
        public IDbSet<TbBudgetType> TbBudgetTypes { get; set; } // TB_BudgetType
        public IDbSet<TbBudgetVersionType> TbBudgetVersionTypes { get; set; } // TB_BudgetVersionType
        public IDbSet<TbBusinessExecution> TbBusinessExecutions { get; set; } // TB_BusinessExecution
        public IDbSet<TbBusinessExecutionDetail> TbBusinessExecutionDetails { get; set; } // TB_BusinessExecution_Detail
        public IDbSet<TbContract> TbContracts { get; set; } // TB_Contract
        public IDbSet<TbContractApprove> TbContractApproves { get; set; } // TB_Contract_Approve
        public IDbSet<TbContractAttachment> TbContractAttachments { get; set; } // TB_Contract_Attachment
        public IDbSet<TbContractClosingRecord> TbContractClosingRecords { get; set; } // TB_Contract_ClosingRecord
        public IDbSet<TbContractDetail> TbContractDetails { get; set; } // TB_Contract_Detail
        public IDbSet<TbContractPayPlan> TbContractPayPlans { get; set; } // TB_Contract_PayPlan
        public IDbSet<TbContractRelatePlan> TbContractRelatePlans { get; set; } // TB_Contract_RelatePlan
        public IDbSet<TbContractSelect> TbContractSelects { get; set; } // TB_Contract_Select
        public IDbSet<TbContractStatistic> TbContractStatistics { get; set; } // TB_Contract_Statistics
        public IDbSet<TbContractTemplate> TbContractTemplates { get; set; } // TB_Contract_Template
        public IDbSet<TbCorporate> TbCorporates { get; set; } // TB_Corporate
        public IDbSet<TbCorporateBankAccount> TbCorporateBankAccounts { get; set; } // TB_Corporate_BankAccount
        public IDbSet<TbCostCenter> TbCostCenters { get; set; } // TB_CostCenter
        public IDbSet<TbCostCenterBudgetSubTypeRelate> TbCostCenterBudgetSubTypeRelates { get; set; } // TB_CostCenter_BudgetSubType_Relate
        public IDbSet<TbDeptCategory> TbDeptCategories { get; set; } // TB_Dept_Category
        public IDbSet<TbDeptCategoryRelate> TbDeptCategoryRelates { get; set; } // TB_Dept_Category_Relate
        public IDbSet<TbFeeStandard> TbFeeStandards { get; set; } // TB_FeeStandard
        public IDbSet<TbFinancialDesk> TbFinancialDesks { get; set; } // TB_FinancialDesk
        public IDbSet<TbFinancialDesk1220> TbFinancialDesk1220 { get; set; } // TB_FinancialDesk_1220
        public IDbSet<TbFinancialDeskBack> TbFinancialDeskBacks { get; set; } // TB_FinancialDesk_back
        public IDbSet<TbGroup> TbGroups { get; set; } // TB_Group
        public IDbSet<TbGroupDetail> TbGroupDetails { get; set; } // TB_Group_Detail
        public IDbSet<TbHotelExpense> TbHotelExpenses { get; set; } // TB_Hotel_Expense
        public IDbSet<TbInvoice> TbInvoices { get; set; } // TB_Invoice
        public IDbSet<TbInvoiceDetail> TbInvoiceDetails { get; set; } // TB_InvoiceDetail
        public IDbSet<TbLoanApply> TbLoanApplies { get; set; } // TB_Loan_Apply
        public IDbSet<TbLoanApplyReceivingInfo> TbLoanApplyReceivingInfoes { get; set; } // TB_Loan_Apply_ReceivingInfo
        public IDbSet<TbMainShowSetting> TbMainShowSettings { get; set; } // TB_MainShowSetting
        public IDbSet<TbMaterialsDetail> TbMaterialsDetails { get; set; } // TB_Materials_Detail
        public IDbSet<TbMaterialsRecipient> TbMaterialsRecipients { get; set; } // TB_Materials_Recipients
        public IDbSet<TbMonthlyPayPlanBudgetItem> TbMonthlyPayPlanBudgetItems { get; set; } // TB_Monthly_PayPlan_Budget_Item
        public IDbSet<TbMonthlyPayPlanBudgetItem1> TbMonthlyPayPlanBudgetItem1 { get; set; } // TB_Monthly_PayPlan_BudgetItems
        public IDbSet<TbMonthlyPayPlanBudgetItemsDraft> TbMonthlyPayPlanBudgetItemsDrafts { get; set; } // TB_Monthly_PayPlan_BudgetItems_Draft
        public IDbSet<TbMonthlyPayPlanCostCenter> TbMonthlyPayPlanCostCenters { get; set; } // TB_Monthly_PayPlan_CostCenter
        public IDbSet<TbMonthlyPayPlanCostCenterDraft> TbMonthlyPayPlanCostCenterDrafts { get; set; } // TB_Monthly_PayPlan_CostCenter_Draft
        public IDbSet<TbMonthlyPayPlanMain> TbMonthlyPayPlanMains { get; set; } // TB_Monthly_PayPlan_Main
        public IDbSet<TbMonthlyPayPlanMainDraft> TbMonthlyPayPlanMainDrafts { get; set; } // TB_Monthly_PayPlan_Main_Draft
        public IDbSet<TbNotice> TbNotices { get; set; } // TB_Notice
        public IDbSet<TbOperationRecord> TbOperationRecords { get; set; } // TB_OperationRecord
        public IDbSet<TbOrganizationUnit> TbOrganizationUnits { get; set; } // TB_OrganizationUnit
        public IDbSet<TbOrganizationUnitBak> TbOrganizationUnitBaks { get; set; } // TB_OrganizationUnit_bak
        public IDbSet<TbOrgUserRelate> TbOrgUserRelates { get; set; } // TB_Org_User_Relate
        public IDbSet<TbPaymentApply> TbPaymentApplies { get; set; } // TB_Payment_Apply
        public IDbSet<TbPaymentApplyAttachment> TbPaymentApplyAttachments { get; set; } // TB_Payment_Apply_Attachment
        public IDbSet<TbPaymentApplyDetail> TbPaymentApplyDetails { get; set; } // TB_Payment_Apply_Detail
        public IDbSet<TbPaymentApplyReceivingInfo> TbPaymentApplyReceivingInfoes { get; set; } // TB_Payment_Apply_ReceivingInfo
        public IDbSet<TbPaymentApplyRestaurant> TbPaymentApplyRestaurants { get; set; } // TB_Payment_Apply_Restaurant
        public IDbSet<TbPaymentApplyStatistic> TbPaymentApplyStatistics { get; set; } // TB_Payment_Apply_Statistics
        public IDbSet<TbPaymentBusinessMap> TbPaymentBusinessMaps { get; set; } // TB_Payment_BusinessMap
        public IDbSet<TbPaymentLoanMap> TbPaymentLoanMaps { get; set; } // Tb_Payment_LoanMap
        public IDbSet<TbPaymentNewsletter> TbPaymentNewsletters { get; set; } // TB_Payment_Newsletter
        public IDbSet<TbPaymentOther> TbPaymentOthers { get; set; } // TB_Payment_Other
        public IDbSet<TbPaymentSign> TbPaymentSigns { get; set; } // TB_Payment_Sign
        public IDbSet<TbPaymentStay> TbPaymentStays { get; set; } // TB_Payment_Stay
        public IDbSet<TbPaymentTraffic> TbPaymentTraffics { get; set; } // TB_Payment_Traffic
        public IDbSet<TbPaymentTravel> TbPaymentTravels { get; set; } // TB_Payment_Travel
        public IDbSet<TbPerformancePlan> TbPerformancePlans { get; set; } // TB_PerformancePlan
        public IDbSet<TbPlanApply> TbPlanApplies { get; set; } // TB_Plan_Apply
        public IDbSet<TbPlanApplyDetail> TbPlanApplyDetails { get; set; } // TB_Plan_Apply_Detail
        public IDbSet<TbPosition> TbPositions { get; set; } // TB_Position
        public IDbSet<TbProgressOutputValue> TbProgressOutputValues { get; set; } // TB_ProgressOutputValue
        public IDbSet<TbProgressOutputValue0328> TbProgressOutputValue0328 { get; set; } // TB_ProgressOutputValue_0328
        public IDbSet<TbProgressSheet> TbProgressSheets { get; set; } // TB_Progress_Sheet
        public IDbSet<TbProgressSheet0328> TbProgressSheet0328 { get; set; } // TB_Progress_Sheet_0328
        public IDbSet<TbProject> TbProjects { get; set; } // TB_Project
        public IDbSet<TbReimbursementStandard> TbReimbursementStandards { get; set; } // TB_Reimbursement_Standard
        public IDbSet<TbRemindContent> TbRemindContents { get; set; } // TB_Remind_Content
        public IDbSet<TbRemindQueue> TbRemindQueues { get; set; } // TB_Remind_Queue
        public IDbSet<TbRemindSetting> TbRemindSettings { get; set; } // TB_Remind_Setting
        public IDbSet<TbRepaymentsDetail> TbRepaymentsDetails { get; set; } // TB_Repayments_Detail
        public IDbSet<TbServiceOrder> TbServiceOrders { get; set; } // TB_ServiceOrders
        public IDbSet<TbServiceOrderDetail> TbServiceOrderDetails { get; set; } // TB_ServiceOrder_Detail
        public IDbSet<TbSpareMoneyRepaymentsDetail> TbSpareMoneyRepaymentsDetails { get; set; } // TB_SpareMoneyRepayments_Detail
        public IDbSet<TbStandardContractContent> TbStandardContractContents { get; set; } // TB_StandardContractContent
        public IDbSet<TbStandardContractContent1> TbStandardContractContent1 { get; set; } // TB_StandardContractContent_1
        public IDbSet<TbSubBudgetLItem> TbSubBudgetLItems { get; set; } // TB_Sub_Budget_lItem
        public IDbSet<TbSubBudgetLItemRelate> TbSubBudgetLItemRelates { get; set; } // TB_Sub_Budget_lItem_Relate
        public IDbSet<TbSupplierAssess> TbSupplierAssesses { get; set; } // TB_Supplier_Assess
        public IDbSet<TbSupplierBank> TbSupplierBanks { get; set; } // TB_Supplier_Bank
        public IDbSet<TbSupplierBasic> TbSupplierBasics { get; set; } // TB_Supplier_Basic
        public IDbSet<TbSupplierCategory> TbSupplierCategories { get; set; } // TB_Supplier_Category
        public IDbSet<TbSupplierContact> TbSupplierContacts { get; set; } // TB_Supplier_Contact
        public IDbSet<TbSupplierCooperationRecord> TbSupplierCooperationRecords { get; set; } // TB_Supplier_CooperationRecord
        public IDbSet<TbSupplierOrgUnitRelate> TbSupplierOrgUnitRelates { get; set; } // TB_Supplier_OrgUnit_Relate
        public IDbSet<TbTemplateBudgetRelate> TbTemplateBudgetRelates { get; set; } // TB_Template_Budget_Relate
        public IDbSet<TbTrafficStandard> TbTrafficStandards { get; set; } // TB_Traffic_Standard
        public IDbSet<TbUser> TbUsers { get; set; } // TB_User
        public IDbSet<TbUserCityRecent> TbUserCityRecents { get; set; } // TB_User_CityRecent
        public IDbSet<TbUserPositionRelate> TbUserPositionRelates { get; set; } // TB_User_Position_Relate
        public IDbSet<TbWeekdaysAndHoliday> TbWeekdaysAndHolidays { get; set; } // TB_WeekdaysAndHolidays
        public IDbSet<TbWorkFlowInProgress> TbWorkFlowInProgresses { get; set; } // TB_WorkFlowInProgress
        public IDbSet<TbWorkflowList> TbWorkflowLists { get; set; } // TB_WorkflowList
        public IDbSet<TbYear> TbYears { get; set; } // TB_Year

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public EMSDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in EMSDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of EMSDbContext since ABP automatically handles it.
         */
        public EMSDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public EMSDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public EMSDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
