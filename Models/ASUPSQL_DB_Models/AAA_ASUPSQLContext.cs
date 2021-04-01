using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ASUPSQLContext : DbContext
    {
        public ASUPSQLContext()
        {
        }

        public ASUPSQLContext(DbContextOptions<ASUPSQLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountTypes> AccountTypes { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AndFact> AndFact { get; set; }
        public virtual DbSet<AndPlaning> AndPlaning { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<ArtArt1cToDelete> ArtArt1cToDelete { get; set; }
        public virtual DbSet<ArtArticD> ArtArticD { get; set; }
        public virtual DbSet<ArtArticDArhive> ArtArticDArhive { get; set; }
        public virtual DbSet<ArtArticModel> ArtArticModel { get; set; }
        public virtual DbSet<ArtArticNm1> ArtArticNm1 { get; set; }
        public virtual DbSet<ArtArticNm3> ArtArticNm3 { get; set; }
        public virtual DbSet<ArtArticPr> ArtArticPr { get; set; }
        public virtual DbSet<ArtArticPrArchive> ArtArticPrArchive { get; set; }
        public virtual DbSet<ArtArticPrHistory> ArtArticPrHistory { get; set; }
        public virtual DbSet<ArtArticPrLog> ArtArticPrLog { get; set; }
        public virtual DbSet<ArtArticPrNov2015> ArtArticPrNov2015 { get; set; }
        public virtual DbSet<ArtArticPrOld> ArtArticPrOld { get; set; }
        public virtual DbSet<ArtArticSh1> ArtArticSh1 { get; set; }
        public virtual DbSet<ArtArticul> ArtArticul { get; set; }
        public virtual DbSet<ArtArticulArhive> ArtArticulArhive { get; set; }
        public virtual DbSet<ArtArticulExt> ArtArticulExt { get; set; }
        public virtual DbSet<ArtDetLabArt> ArtDetLabArt { get; set; }
        public virtual DbSet<ArtDetLabe> ArtDetLabe { get; set; }
        public virtual DbSet<ArtDetLabr> ArtDetLabr { get; set; }
        public virtual DbSet<ArtKodizgot> ArtKodizgot { get; set; }
        public virtual DbSet<ArtLogBox1> ArtLogBox1 { get; set; }
        public virtual DbSet<ArtPrGroup> ArtPrGroup { get; set; }
        public virtual DbSet<ArtPrGroupSections> ArtPrGroupSections { get; set; }
        public virtual DbSet<ArtPrType> ArtPrType { get; set; }
        public virtual DbSet<ArticulComplectation> ArticulComplectation { get; set; }
        public virtual DbSet<ArticulModelCost> ArticulModelCost { get; set; }
        public virtual DbSet<ArticulModelCost1> ArticulModelCost1 { get; set; }
        public virtual DbSet<ArticulModelMatching> ArticulModelMatching { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }
        public virtual DbSet<AspnetPaths> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfile { get; set; }
        public virtual DbSet<AspnetRoles> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; }
        public virtual DbSet<AsupLog> AsupLog { get; set; }
        public virtual DbSet<AttHch> AttHch { get; set; }
        public virtual DbSet<AttHid> AttHid { get; set; }
        public virtual DbSet<AttMain> AttMain { get; set; }
        public virtual DbSet<AttQa> AttQa { get; set; }
        public virtual DbSet<AttSprQ> AttSprQ { get; set; }
        public virtual DbSet<AttSprQgr> AttSprQgr { get; set; }
        public virtual DbSet<AttSprQq> AttSprQq { get; set; }
        public virtual DbSet<BrakReasonList> BrakReasonList { get; set; }
        public virtual DbSet<BrigadeOptions> BrigadeOptions { get; set; }
        public virtual DbSet<BscTarget> BscTarget { get; set; }
        public virtual DbSet<BscValue> BscValue { get; set; }
        public virtual DbSet<CartonExecution> CartonExecution { get; set; }
        public virtual DbSet<CartonPack> CartonPack { get; set; }
        public virtual DbSet<CartonSheets> CartonSheets { get; set; }
        public virtual DbSet<CartonTasks> CartonTasks { get; set; }
        public virtual DbSet<CatCatGr> CatCatGr { get; set; }
        public virtual DbSet<CatCatMashPrice> CatCatMashPrice { get; set; }
        public virtual DbSet<CatCatgr1> CatCatgr1 { get; set; }
        public virtual DbSet<CatCatid> CatCatid { get; set; }
        public virtual DbSet<CatCatВ> CatCatВ { get; set; }
        public virtual DbSet<CatCatЗ> CatCatЗ { get; set; }
        public virtual DbSet<CatDoc> CatDoc { get; set; }
        public virtual DbSet<CatDocFile> CatDocFile { get; set; }
        public virtual DbSet<CatEdIzm> CatEdIzm { get; set; }
        public virtual DbSet<CatLskRulon> CatLskRulon { get; set; }
        public virtual DbSet<CatMash> CatMash { get; set; }
        public virtual DbSet<CatMashObj> CatMashObj { get; set; }
        public virtual DbSet<CatSetup> CatSetup { get; set; }
        public virtual DbSet<CatValue> CatValue { get; set; }
        public virtual DbSet<CatalogueBulgary> CatalogueBulgary { get; set; }
        public virtual DbSet<CatalogueMatchRussiaBulgary> CatalogueMatchRussiaBulgary { get; set; }
        public virtual DbSet<CatalogueResourses> CatalogueResourses { get; set; }
        public virtual DbSet<CataloguesGroups> CataloguesGroups { get; set; }
        public virtual DbSet<ConfDbfCdx> ConfDbfCdx { get; set; }
        public virtual DbSet<ConfDbfSql> ConfDbfSql { get; set; }
        public virtual DbSet<ConfDbfsql1> ConfDbfsql1 { get; set; }
        public virtual DbSet<ConfDisableMenuAsup> ConfDisableMenuAsup { get; set; }
        public virtual DbSet<ConfFiles> ConfFiles { get; set; }
        public virtual DbSet<ConfFormState> ConfFormState { get; set; }
        public virtual DbSet<ConfIplist> ConfIplist { get; set; }
        public virtual DbSet<ConfIzgot> ConfIzgot { get; set; }
        public virtual DbSet<ConstrNotices> ConstrNotices { get; set; }
        public virtual DbSet<ConstrSpecifications> ConstrSpecifications { get; set; }
        public virtual DbSet<CostsForImport> CostsForImport { get; set; }
        public virtual DbSet<CoverallsAssignments> CoverallsAssignments { get; set; }
        public virtual DbSet<CoverallsNorm> CoverallsNorm { get; set; }
        public virtual DbSet<CoverallsPositions> CoverallsPositions { get; set; }
        public virtual DbSet<CoverallsWorkflow> CoverallsWorkflow { get; set; }
        public virtual DbSet<DaysSpecialBulgary> DaysSpecialBulgary { get; set; }
        public virtual DbSet<Det1> Det1 { get; set; }
        public virtual DbSet<Det1archive> Det1archive { get; set; }
        public virtual DbSet<DetailOperationsLog> DetailOperationsLog { get; set; }
        public virtual DbSet<DlaZakaczki> DlaZakaczki { get; set; }
        public virtual DbSet<DokDet> DokDet { get; set; }
        public virtual DbSet<DraftListDetails> DraftListDetails { get; set; }
        public virtual DbSet<DraftListHeader> DraftListHeader { get; set; }
        public virtual DbSet<DraftListZoneList> DraftListZoneList { get; set; }
        public virtual DbSet<EanТо> EanТо { get; set; }
        public virtual DbSet<EconomInitialCalculationComponentCatalog> EconomInitialCalculationComponentCatalog { get; set; }
        public virtual DbSet<EconomInitialCalculationItems> EconomInitialCalculationItems { get; set; }
        public virtual DbSet<EconomInitialCalculationOwnItems> EconomInitialCalculationOwnItems { get; set; }
        public virtual DbSet<EconomInitialCalculationProduction> EconomInitialCalculationProduction { get; set; }
        public virtual DbSet<EduCat> EduCat { get; set; }
        public virtual DbSet<EduGame1> EduGame1 { get; set; }
        public virtual DbSet<EduGame2> EduGame2 { get; set; }
        public virtual DbSet<EduGame3> EduGame3 { get; set; }
        public virtual DbSet<EduGame4> EduGame4 { get; set; }
        public virtual DbSet<EduGame5> EduGame5 { get; set; }
        public virtual DbSet<EduGame6> EduGame6 { get; set; }
        public virtual DbSet<EduPrez> EduPrez { get; set; }
        public virtual DbSet<EduRole> EduRole { get; set; }
        public virtual DbSet<EduSkl> EduSkl { get; set; }
        public virtual DbSet<EkTrud> EkTrud { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentConsumables> EquipmentConsumables { get; set; }
        public virtual DbSet<EquipmentEvents> EquipmentEvents { get; set; }
        public virtual DbSet<EquipmentInformTable> EquipmentInformTable { get; set; }
        public virtual DbSet<EquipmentModels> EquipmentModels { get; set; }
        public virtual DbSet<EquipmentServiceList> EquipmentServiceList { get; set; }
        public virtual DbSet<EquipmentServicePlan> EquipmentServicePlan { get; set; }
        public virtual DbSet<ExperimentalStates> ExperimentalStates { get; set; }
        public virtual DbSet<Functionality> Functionality { get; set; }
        public virtual DbSet<GoodFile> GoodFile { get; set; }
        public virtual DbSet<GoodFin> GoodFin { get; set; }
        public virtual DbSet<GoodList> GoodList { get; set; }
        public virtual DbSet<GoodProp> GoodProp { get; set; }
        public virtual DbSet<GoodSpec> GoodSpec { get; set; }
        public virtual DbSet<GraidGroup> GraidGroup { get; set; }
        public virtual DbSet<GraidInd> GraidInd { get; set; }
        public virtual DbSet<GraidLim> GraidLim { get; set; }
        public virtual DbSet<GraidPodr> GraidPodr { get; set; }
        public virtual DbSet<GraidProff> GraidProff { get; set; }
        public virtual DbSet<GraidTab> GraidTab { get; set; }
        public virtual DbSet<GraidZp> GraidZp { get; set; }
        public virtual DbSet<GraidZpHid> GraidZpHid { get; set; }
        public virtual DbSet<HisFrg> HisFrg { get; set; }
        public virtual DbSet<HistHisTech> HistHisTech { get; set; }
        public virtual DbSet<HistKem> HistKem { get; set; }
        public virtual DbSet<HistSoglIzg> HistSoglIzg { get; set; }
        public virtual DbSet<HistSoglUp> HistSoglUp { get; set; }
        public virtual DbSet<HistSps> HistSps { get; set; }
        public virtual DbSet<HistStHist> HistStHist { get; set; }
        public virtual DbSet<HornStart> HornStart { get; set; }
        public virtual DbSet<HrIndKart> HrIndKart { get; set; }
        public virtual DbSet<HrIndKartTest> HrIndKartTest { get; set; }
        public virtual DbSet<HrIndKval> HrIndKval { get; set; }
        public virtual DbSet<HrIndTab> HrIndTab { get; set; }
        public virtual DbSet<HrKval> HrKval { get; set; }
        public virtual DbSet<HrOtpusk> HrOtpusk { get; set; }
        public virtual DbSet<HrOtpuskNew> HrOtpuskNew { get; set; }
        public virtual DbSet<HrPrFio> HrPrFio { get; set; }
        public virtual DbSet<HrSelection> HrSelection { get; set; }
        public virtual DbSet<HrSmTable> HrSmTable { get; set; }
        public virtual DbSet<HrSmena> HrSmena { get; set; }
        public virtual DbSet<HrStTabel> HrStTabel { get; set; }
        public virtual DbSet<HrStaj> HrStaj { get; set; }
        public virtual DbSet<HrZpYear> HrZpYear { get; set; }
        public virtual DbSet<HronDayTime> HronDayTime { get; set; }
        public virtual DbSet<HronSetup> HronSetup { get; set; }
        public virtual DbSet<IndKartproc> IndKartproc { get; set; }
        public virtual DbSet<KachKartDef> KachKartDef { get; set; }
        public virtual DbSet<KachKartDefCatalogue> KachKartDefCatalogue { get; set; }
        public virtual DbSet<KachKartDet> KachKartDet { get; set; }
        public virtual DbSet<KachKartFiles> KachKartFiles { get; set; }
        public virtual DbSet<KachKartMat> KachKartMat { get; set; }
        public virtual DbSet<KachKartOperCatalogue> KachKartOperCatalogue { get; set; }
        public virtual DbSet<KachKartOtv> KachKartOtv { get; set; }
        public virtual DbSet<KachKartOtv1> KachKartOtv1 { get; set; }
        public virtual DbSet<KachKartR> KachKartR { get; set; }
        public virtual DbSet<KachKartReason> KachKartReason { get; set; }
        public virtual DbSet<KachKartReasonCatalogue> KachKartReasonCatalogue { get; set; }
        public virtual DbSet<KachParProst> KachParProst { get; set; }
        public virtual DbSet<KatEdMat> KatEdMat { get; set; }
        public virtual DbSet<KonBzBau> KonBzBau { get; set; }
        public virtual DbSet<KonDetKodZ> KonDetKodZ { get; set; }
        public virtual DbSet<KonDetToDelete> KonDetToDelete { get; set; }
        public virtual DbSet<KonDetVes> KonDetVes { get; set; }
        public virtual DbSet<KonHisSps> KonHisSps { get; set; }
        public virtual DbSet<KonPassport> KonPassport { get; set; }
        public virtual DbSet<KonPassportDoc> KonPassportDoc { get; set; }
        public virtual DbSet<KonPassportTable> KonPassportTable { get; set; }
        public virtual DbSet<KonPassportTableSign> KonPassportTableSign { get; set; }
        public virtual DbSet<KonSmCh> KonSmCh { get; set; }
        public virtual DbSet<Labels> Labels { get; set; }
        public virtual DbSet<LabelsExtCatalogue> LabelsExtCatalogue { get; set; }
        public virtual DbSet<LocksЗамки> LocksЗамки { get; set; }
        public virtual DbSet<LocksРаспечатанныеЭтикетки> LocksРаспечатанныеЭтикетки { get; set; }
        public virtual DbSet<MaterialInNonStdProduction> MaterialInNonStdProduction { get; set; }
        public virtual DbSet<MetAccountingObjects> MetAccountingObjects { get; set; }
        public virtual DbSet<MetMetalMoving> MetMetalMoving { get; set; }
        public virtual DbSet<MetStockflow> MetStockflow { get; set; }
        public virtual DbSet<MetStockflowLog> MetStockflowLog { get; set; }
        public virtual DbSet<MobCalcPay> MobCalcPay { get; set; }
        public virtual DbSet<MobHistory> MobHistory { get; set; }
        public virtual DbSet<MobOrg> MobOrg { get; set; }
        public virtual DbSet<MobPerView> MobPerView { get; set; }
        public virtual DbSet<MobPers> MobPers { get; set; }
        public virtual DbSet<MobTel> MobTel { get; set; }
        public virtual DbSet<MobTelPers> MobTelPers { get; set; }
        public virtual DbSet<MobTelView> MobTelView { get; set; }
        public virtual DbSet<NaklFirmList> NaklFirmList { get; set; }
        public virtual DbSet<NewPrcs> NewPrcs { get; set; }
        public virtual DbSet<ObjectPositionRules> ObjectPositionRules { get; set; }
        public virtual DbSet<OlSecMhid> OlSecMhid { get; set; }
        public virtual DbSet<OlSecMpos> OlSecMpos { get; set; }
        public virtual DbSet<OpCatCorrection> OpCatCorrection { get; set; }
        public virtual DbSet<OpCatCorrection1> OpCatCorrection1 { get; set; }
        public virtual DbSet<OutlabelBindingTemplates> OutlabelBindingTemplates { get; set; }
        public virtual DbSet<OutlabelImageLists> OutlabelImageLists { get; set; }
        public virtual DbSet<OutlabelImageListsDetails> OutlabelImageListsDetails { get; set; }
        public virtual DbSet<OutlabelImages> OutlabelImages { get; set; }
        public virtual DbSet<OutlabelLanguages> OutlabelLanguages { get; set; }
        public virtual DbSet<OutlabelParamConstant> OutlabelParamConstant { get; set; }
        public virtual DbSet<OutlabelParamFormat> OutlabelParamFormat { get; set; }
        public virtual DbSet<OutlabelParams> OutlabelParams { get; set; }
        public virtual DbSet<OutlabelTemplates> OutlabelTemplates { get; set; }
        public virtual DbSet<OutlabelValueTypes> OutlabelValueTypes { get; set; }
        public virtual DbSet<PaintAjurarticleCode> PaintAjurarticleCode { get; set; }
        public virtual DbSet<PaintLabourIntensity> PaintLabourIntensity { get; set; }
        public virtual DbSet<PaintLabourIntensityByDetails> PaintLabourIntensityByDetails { get; set; }
        public virtual DbSet<PaintLineSpeed> PaintLineSpeed { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        public virtual DbSet<PersonsConnections> PersonsConnections { get; set; }
        public virtual DbSet<PlanClose> PlanClose { get; set; }
        public virtual DbSet<PlanDetailsBySections> PlanDetailsBySections { get; set; }
        public virtual DbSet<PlanNew> PlanNew { get; set; }
        public virtual DbSet<PlanPlHoliday> PlanPlHoliday { get; set; }
        public virtual DbSet<PlanPlansogl> PlanPlansogl { get; set; }
        public virtual DbSet<PlanProductionTurnTask> PlanProductionTurnTask { get; set; }
        public virtual DbSet<PlanPullCom> PlanPullCom { get; set; }
        public virtual DbSet<PlanPullFD> PlanPullFD { get; set; }
        public virtual DbSet<PlanPullFact> PlanPullFact { get; set; }
        public virtual DbSet<PlanPullPD> PlanPullPD { get; set; }
        public virtual DbSet<PlanPullPD1> PlanPullPD1 { get; set; }
        public virtual DbSet<PlanPullPl> PlanPullPl { get; set; }
        public virtual DbSet<PlanPullPlan> PlanPullPlan { get; set; }
        public virtual DbSet<PlanPullUp> PlanPullUp { get; set; }
        public virtual DbSet<PlanTaskMskSection> PlanTaskMskSection { get; set; }
        public virtual DbSet<PlanTaskMskSectionProduction> PlanTaskMskSectionProduction { get; set; }
        public virtual DbSet<PlanTaskMskSectionProductionSet> PlanTaskMskSectionProductionSet { get; set; }
        public virtual DbSet<PlanTaskMskSectionWork> PlanTaskMskSectionWork { get; set; }
        public virtual DbSet<PlanTaskPaintSection> PlanTaskPaintSection { get; set; }
        public virtual DbSet<PlanTaskPaintSectionWork> PlanTaskPaintSectionWork { get; set; }
        public virtual DbSet<PlanTaskSection> PlanTaskSection { get; set; }
        public virtual DbSet<PlanTaskSectionOrders> PlanTaskSectionOrders { get; set; }
        public virtual DbSet<PlanTaskSectionWork> PlanTaskSectionWork { get; set; }
        public virtual DbSet<PlantMachine> PlantMachine { get; set; }
        public virtual DbSet<PlantMaterial> PlantMaterial { get; set; }
        public virtual DbSet<PlantMetalMachine> PlantMetalMachine { get; set; }
        public virtual DbSet<PlantSalaryPaintProduction> PlantSalaryPaintProduction { get; set; }
        public virtual DbSet<PlantSalaryParameters> PlantSalaryParameters { get; set; }
        public virtual DbSet<PlantTypes> PlantTypes { get; set; }
        public virtual DbSet<PlantTypesSection> PlantTypesSection { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<PrProjectSt> PrProjectSt { get; set; }
        public virtual DbSet<Prices39> Prices39 { get; set; }
        public virtual DbSet<Prices44> Prices44 { get; set; }
        public virtual DbSet<PrjProjectId> PrjProjectId { get; set; }
        public virtual DbSet<PrnArticulLabel> PrnArticulLabel { get; set; }
        public virtual DbSet<PrnLabelParams> PrnLabelParams { get; set; }
        public virtual DbSet<PrnLabelTextParamsArticulValue> PrnLabelTextParamsArticulValue { get; set; }
        public virtual DbSet<PrnLabelTextParamsGlobalValue> PrnLabelTextParamsGlobalValue { get; set; }
        public virtual DbSet<ProductionAreas> ProductionAreas { get; set; }
        public virtual DbSet<ProductionCalendar> ProductionCalendar { get; set; }
        public virtual DbSet<ProductionOrderPositions> ProductionOrderPositions { get; set; }
        public virtual DbSet<ProductionOrders> ProductionOrders { get; set; }
        public virtual DbSet<ProductionSetup> ProductionSetup { get; set; }
        public virtual DbSet<ProductionSetupCache> ProductionSetupCache { get; set; }
        public virtual DbSet<ProductionVolume> ProductionVolume { get; set; }
        public virtual DbSet<RedBzBau> RedBzBau { get; set; }
        public virtual DbSet<RedData> RedData { get; set; }
        public virtual DbSet<RedDet1> RedDet1 { get; set; }
        public virtual DbSet<RedDet11> RedDet11 { get; set; }
        public virtual DbSet<RedSpecHist> RedSpecHist { get; set; }
        public virtual DbSet<RedSpecHist1> RedSpecHist1 { get; set; }
        public virtual DbSet<RedSpecHistArchive> RedSpecHistArchive { get; set; }
        public virtual DbSet<RedSpecHistDop> RedSpecHistDop { get; set; }
        public virtual DbSet<RedSpecHistSogl> RedSpecHistSogl { get; set; }
        public virtual DbSet<RedSpecReestr> RedSpecReestr { get; set; }
        public virtual DbSet<RedSpecSource> RedSpecSource { get; set; }
        public virtual DbSet<RedSpecSourceList> RedSpecSourceList { get; set; }
        public virtual DbSet<RepReportEmails> RepReportEmails { get; set; }
        public virtual DbSet<RepReportParams> RepReportParams { get; set; }
        public virtual DbSet<RepReportQueries> RepReportQueries { get; set; }
        public virtual DbSet<RepReports> RepReports { get; set; }
        public virtual DbSet<ResourseExpense> ResourseExpense { get; set; }
        public virtual DbSet<ScanFactory> ScanFactory { get; set; }
        public virtual DbSet<ScanProduction> ScanProduction { get; set; }
        public virtual DbSet<ScanScaners> ScanScaners { get; set; }
        public virtual DbSet<ScanVersion> ScanVersion { get; set; }
        public virtual DbSet<ScanerError> ScanerError { get; set; }
        public virtual DbSet<SecDopusk> SecDopusk { get; set; }
        public virtual DbSet<SecUser> SecUser { get; set; }
        public virtual DbSet<SecUserPas> SecUserPas { get; set; }
        public virtual DbSet<SecUserPasCopy> SecUserPasCopy { get; set; }
        public virtual DbSet<SecUserPass> SecUserPass { get; set; }
        public virtual DbSet<SecUserRights> SecUserRights { get; set; }
        public virtual DbSet<SecUserserv> SecUserserv { get; set; }
        public virtual DbSet<ServiceUseAction> ServiceUseAction { get; set; }
        public virtual DbSet<ServiceUseJournal> ServiceUseJournal { get; set; }
        public virtual DbSet<ServiceUsePersonRight> ServiceUsePersonRight { get; set; }
        public virtual DbSet<ServiceUseProduction> ServiceUseProduction { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<SkladSklHist> SkladSklHist { get; set; }
        public virtual DbSet<SkladSklHist11> SkladSklHist11 { get; set; }
        public virtual DbSet<SkladSklad> SkladSklad { get; set; }
        public virtual DbSet<SkladSklad1> SkladSklad1 { get; set; }
        public virtual DbSet<SpecialRights> SpecialRights { get; set; }
        public virtual DbSet<SpecificationCompleteTmp> SpecificationCompleteTmp { get; set; }
        public virtual DbSet<SpecificationNotice> SpecificationNotice { get; set; }
        public virtual DbSet<SpecificationNoticeComments> SpecificationNoticeComments { get; set; }
        public virtual DbSet<SpecificationNoticeEmailMissing> SpecificationNoticeEmailMissing { get; set; }
        public virtual DbSet<SpecificationOperationsLog> SpecificationOperationsLog { get; set; }
        public virtual DbSet<SpecificationReplacement> SpecificationReplacement { get; set; }
        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<TabloCfg> TabloCfg { get; set; }
        public virtual DbSet<TaskList> TaskList { get; set; }
        public virtual DbSet<TasksAndMessages> TasksAndMessages { get; set; }
        public virtual DbSet<TechCells> TechCells { get; set; }
        public virtual DbSet<TechComplD> TechComplD { get; set; }
        public virtual DbSet<TechComplect> TechComplect { get; set; }
        public virtual DbSet<TechCompon> TechCompon { get; set; }
        public virtual DbSet<TechComponSections> TechComponSections { get; set; }
        public virtual DbSet<TechComponTechproc> TechComponTechproc { get; set; }
        public virtual DbSet<TechDetAp> TechDetAp { get; set; }
        public virtual DbSet<TechDetAp1> TechDetAp1 { get; set; }
        public virtual DbSet<TechDetApAdd> TechDetApAdd { get; set; }
        public virtual DbSet<TechDetApAs> TechDetApAs { get; set; }
        public virtual DbSet<TechDetApdata> TechDetApdata { get; set; }
        public virtual DbSet<TechDetIzm> TechDetIzm { get; set; }
        public virtual DbSet<TechDetOsn> TechDetOsn { get; set; }
        public virtual DbSet<TechDetOsnb> TechDetOsnb { get; set; }
        public virtual DbSet<TechDocExp> TechDocExp { get; set; }
        public virtual DbSet<TechDocExpIzg> TechDocExpIzg { get; set; }
        public virtual DbSet<TechDocExpSegment> TechDocExpSegment { get; set; }
        public virtual DbSet<TechEkDet> TechEkDet { get; set; }
        public virtual DbSet<TechInstructionTechProcess> TechInstructionTechProcess { get; set; }
        public virtual DbSet<TechInstructions> TechInstructions { get; set; }
        public virtual DbSet<TechInstructionsArticles> TechInstructionsArticles { get; set; }
        public virtual DbSet<TechInstructionsDetails> TechInstructionsDetails { get; set; }
        public virtual DbSet<TechInstructionsNotices> TechInstructionsNotices { get; set; }
        public virtual DbSet<TechInstrumentTechProcess> TechInstrumentTechProcess { get; set; }
        public virtual DbSet<TechInstruments> TechInstruments { get; set; }
        public virtual DbSet<TechItemTechProcess> TechItemTechProcess { get; set; }
        public virtual DbSet<TechItems> TechItems { get; set; }
        public virtual DbSet<TechMach> TechMach { get; set; }
        public virtual DbSet<TechMashNn> TechMashNn { get; set; }
        public virtual DbSet<TechMashNnAlt> TechMashNnAlt { get; set; }
        public virtual DbSet<TechMashOp> TechMashOp { get; set; }
        public virtual DbSet<TechMashStop> TechMashStop { get; set; }
        public virtual DbSet<TechMaterialArticle> TechMaterialArticle { get; set; }
        public virtual DbSet<TechOsnastkaAccessLevels> TechOsnastkaAccessLevels { get; set; }
        public virtual DbSet<TechOsnastkaCheckActs> TechOsnastkaCheckActs { get; set; }
        public virtual DbSet<TechOsnastkaKatCategOsn> TechOsnastkaKatCategOsn { get; set; }
        public virtual DbSet<TechOsnastkaKatOsn> TechOsnastkaKatOsn { get; set; }
        public virtual DbSet<TechOsnastkaKatOsnDetails> TechOsnastkaKatOsnDetails { get; set; }
        public virtual DbSet<TechOsnastkaKatOsnItems> TechOsnastkaKatOsnItems { get; set; }
        public virtual DbSet<TechOsnastkaKatOsnItemsDiscard> TechOsnastkaKatOsnItemsDiscard { get; set; }
        public virtual DbSet<TechOsnastkaKd> TechOsnastkaKd { get; set; }
        public virtual DbSet<TechOsnastkaOs> TechOsnastkaOs { get; set; }
        public virtual DbSet<TechOsnastkaOsnPeriods> TechOsnastkaOsnPeriods { get; set; }
        public virtual DbSet<TechOsnastkaOsnStatus> TechOsnastkaOsnStatus { get; set; }
        public virtual DbSet<TechOsnastkaPhotos> TechOsnastkaPhotos { get; set; }
        public virtual DbSet<TechOsnastkaRoles> TechOsnastkaRoles { get; set; }
        public virtual DbSet<TechOsnastkaSpisZakOsn> TechOsnastkaSpisZakOsn { get; set; }
        public virtual DbSet<TechPaint> TechPaint { get; set; }
        public virtual DbSet<TechPaintDet> TechPaintDet { get; set; }
        public virtual DbSet<TechStIzg> TechStIzg { get; set; }
        public virtual DbSet<TechStOper> TechStOper { get; set; }
        public virtual DbSet<TechStizg1> TechStizg1 { get; set; }
        public virtual DbSet<TechTDetAp> TechTDetAp { get; set; }
        public virtual DbSet<TechTDetOsn> TechTDetOsn { get; set; }
        public virtual DbSet<TechTVmtBaza> TechTVmtBaza { get; set; }
        public virtual DbSet<TechTechProcessTypes> TechTechProcessTypes { get; set; }
        public virtual DbSet<TechTo> TechTo { get; set; }
        public virtual DbSet<TechToChecklist> TechToChecklist { get; set; }
        public virtual DbSet<TechToHrlist> TechToHrlist { get; set; }
        public virtual DbSet<TechToMarks> TechToMarks { get; set; }
        public virtual DbSet<TechToolCatalogue> TechToolCatalogue { get; set; }
        public virtual DbSet<TechToolDetailsCatalogue> TechToolDetailsCatalogue { get; set; }
        public virtual DbSet<TechToolDocCatalogue> TechToolDocCatalogue { get; set; }
        public virtual DbSet<TechToolRequests> TechToolRequests { get; set; }
        public virtual DbSet<TechToolsPy> TechToolsPy { get; set; }
        public virtual DbSet<TechTu> TechTu { get; set; }
        public virtual DbSet<TechTudata> TechTudata { get; set; }
        public virtual DbSet<TechTureestr> TechTureestr { get; set; }
        public virtual DbSet<TechTusetup> TechTusetup { get; set; }
        public virtual DbSet<TechTuupdata> TechTuupdata { get; set; }
        public virtual DbSet<TechUpDet> TechUpDet { get; set; }
        public virtual DbSet<TechUpLog> TechUpLog { get; set; }
        public virtual DbSet<TechUpSt> TechUpSt { get; set; }
        public virtual DbSet<TechVmtBaza> TechVmtBaza { get; set; }
        public virtual DbSet<TimeRatePrices> TimeRatePrices { get; set; }
        public virtual DbSet<TmpConfig> TmpConfig { get; set; }
        public virtual DbSet<TmpFiltr> TmpFiltr { get; set; }
        public virtual DbSet<TmpLog> TmpLog { get; set; }
        public virtual DbSet<TmpMed> TmpMed { get; set; }
        public virtual DbSet<TmpUpSt> TmpUpSt { get; set; }
        public virtual DbSet<ToCustomerAppointment> ToCustomerAppointment { get; set; }
        public virtual DbSet<ToCustomerContact> ToCustomerContact { get; set; }
        public virtual DbSet<ToolsPy> ToolsPy { get; set; }
        public virtual DbSet<ToolsPyDevelopers> ToolsPyDevelopers { get; set; }
        public virtual DbSet<ToolsPyDocuments> ToolsPyDocuments { get; set; }
        public virtual DbSet<ToolsPyProduction> ToolsPyProduction { get; set; }
        public virtual DbSet<UpData> UpData { get; set; }
        public virtual DbSet<UpDataArchive> UpDataArchive { get; set; }
        public virtual DbSet<UpKondet> UpKondet { get; set; }
        public virtual DbSet<UpKonzak> UpKonzak { get; set; }
        public virtual DbSet<UpTech> UpTech { get; set; }
        public virtual DbSet<VArticD> VArticD { get; set; }
        public virtual DbSet<VArticDNew> VArticDNew { get; set; }
        public virtual DbSet<VArticSh1> VArticSh1 { get; set; }
        public virtual DbSet<VArticul> VArticul { get; set; }
        public virtual DbSet<VArticulNew> VArticulNew { get; set; }
        public virtual DbSet<VIndKart> VIndKart { get; set; }
        public virtual DbSet<VNakArtic> VNakArtic { get; set; }
        public virtual DbSet<VPlantTypes> VPlantTypes { get; set; }
        public virtual DbSet<VSkladHRkForDeleting> VSkladHRkForDeleting { get; set; }
        public virtual DbSet<VSmTable> VSmTable { get; set; }
        public virtual DbSet<VStIzg> VStIzg { get; set; }
        public virtual DbSet<VZakArtic> VZakArtic { get; set; }
        public virtual DbSet<VZakSt> VZakSt { get; set; }
        public virtual DbSet<Vehicles> Vehicles { get; set; }
        public virtual DbSet<View1> View1 { get; set; }
        public virtual DbSet<View11> View11 { get; set; }
        public virtual DbSet<ViewCompon> ViewCompon { get; set; }
        public virtual DbSet<ViewCurator> ViewCurator { get; set; }
        public virtual DbSet<ViewDetap> ViewDetap { get; set; }
        public virtual DbSet<ViewDopStor> ViewDopStor { get; set; }
        public virtual DbSet<ViewKodIzgot> ViewKodIzgot { get; set; }
        public virtual DbSet<ViewSchIzg> ViewSchIzg { get; set; }
        public virtual DbSet<ViewSmTable> ViewSmTable { get; set; }
        public virtual DbSet<ViewSotr> ViewSotr { get; set; }
        public virtual DbSet<ViewTest1> ViewTest1 { get; set; }
        public virtual DbSet<ViewTmpIzg> ViewTmpIzg { get; set; }
        public virtual DbSet<ViewZpSotr> ViewZpSotr { get; set; }
        public virtual DbSet<VwAspnetApplications> VwAspnetApplications { get; set; }
        public virtual DbSet<VwAspnetMembershipUsers> VwAspnetMembershipUsers { get; set; }
        public virtual DbSet<VwAspnetProfiles> VwAspnetProfiles { get; set; }
        public virtual DbSet<VwAspnetRoles> VwAspnetRoles { get; set; }
        public virtual DbSet<VwAspnetUsers> VwAspnetUsers { get; set; }
        public virtual DbSet<VwAspnetUsersInRoles> VwAspnetUsersInRoles { get; set; }
        public virtual DbSet<VwAspnetWebPartStatePaths> VwAspnetWebPartStatePaths { get; set; }
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShared { get; set; }
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUser { get; set; }
        public virtual DbSet<WageTotalsdaily> WageTotalsdaily { get; set; }
        public virtual DbSet<WarehouseBalance> WarehouseBalance { get; set; }
        public virtual DbSet<WarehouseFilter> WarehouseFilter { get; set; }
        public virtual DbSet<WarehouseList> WarehouseList { get; set; }
        public virtual DbSet<WarehouseTotals> WarehouseTotals { get; set; }
        public virtual DbSet<WebZoneConfig> WebZoneConfig { get; set; }
        public virtual DbSet<WebZoneSetup> WebZoneSetup { get; set; }
        public virtual DbSet<WshopIzgBrak> WshopIzgBrak { get; set; }
        public virtual DbSet<WshopIzgBrakArhive> WshopIzgBrakArhive { get; set; }
        public virtual DbSet<WshopIzgDay> WshopIzgDay { get; set; }
        public virtual DbSet<WshopIzgDayCopy> WshopIzgDayCopy { get; set; }
        public virtual DbSet<WshopIzgDayOutsideWorks> WshopIzgDayOutsideWorks { get; set; }
        public virtual DbSet<WshopIzgDaySpec> WshopIzgDaySpec { get; set; }
        public virtual DbSet<WshopIzgDayf> WshopIzgDayf { get; set; }
        public virtual DbSet<WshopIzgLskm> WshopIzgLskm { get; set; }
        public virtual DbSet<WshopIzgLskmArhive> WshopIzgLskmArhive { get; set; }
        public virtual DbSet<WshopIzgOkr> WshopIzgOkr { get; set; }
        public virtual DbSet<WshopIzgWhouse> WshopIzgWhouse { get; set; }
        public virtual DbSet<WshopKodIzgotTarif> WshopKodIzgotTarif { get; set; }
        public virtual DbSet<WshopModArt> WshopModArt { get; set; }
        public virtual DbSet<WshopModels> WshopModels { get; set; }
        public virtual DbSet<WshopNorm> WshopNorm { get; set; }
        public virtual DbSet<WshopNormAdd> WshopNormAdd { get; set; }
        public virtual DbSet<WshopPlanIzg> WshopPlanIzg { get; set; }
        public virtual DbSet<WshopSpATech> WshopSpATech { get; set; }
        public virtual DbSet<WshopSpTech> WshopSpTech { get; set; }
        public virtual DbSet<WshopSpTechACell> WshopSpTechACell { get; set; }
        public virtual DbSet<WshopSpTechAOper> WshopSpTechAOper { get; set; }
        public virtual DbSet<WshopSpTechCell> WshopSpTechCell { get; set; }
        public virtual DbSet<WshopSpTechOper> WshopSpTechOper { get; set; }
        public virtual DbSet<WshopSpart> WshopSpart { get; set; }
        public virtual DbSet<WshopSpcom> WshopSpcom { get; set; }
        public virtual DbSet<WshopSpec> WshopSpec { get; set; }
        public virtual DbSet<WshopSpoper> WshopSpoper { get; set; }
        public virtual DbSet<WshpSpTechAOper> WshpSpTechAOper { get; set; }
        public virtual DbSet<ZakArticMgr> ZakArticMgr { get; set; }
        public virtual DbSet<ZakDetLabe> ZakDetLabe { get; set; }
        public virtual DbSet<ZakDetLabr> ZakDetLabr { get; set; }
        public virtual DbSet<ZakHisSvSp> ZakHisSvSp { get; set; }
        public virtual DbSet<ZakKodIzgot> ZakKodIzgot { get; set; }
        public virtual DbSet<ZakLink> ZakLink { get; set; }
        public virtual DbSet<ZakMatMet> ZakMatMet { get; set; }
        public virtual DbSet<ZakNakArtDs> ZakNakArtDs { get; set; }
        public virtual DbSet<ZakNakArtic> ZakNakArtic { get; set; }
        public virtual DbSet<ZakNaklSt> ZakNaklSt { get; set; }
        public virtual DbSet<ZakReklamacArhive> ZakReklamacArhive { get; set; }
        public virtual DbSet<ZakSpec> ZakSpec { get; set; }
        public virtual DbSet<ZakSpecArt> ZakSpecArt { get; set; }
        public virtual DbSet<ZakSpecFile> ZakSpecFile { get; set; }
        public virtual DbSet<ZakStKom> ZakStKom { get; set; }
        public virtual DbSet<ZakStMat> ZakStMat { get; set; }
        public virtual DbSet<ZakStNorm> ZakStNorm { get; set; }
        public virtual DbSet<ZakSvSp> ZakSvSp { get; set; }
        public virtual DbSet<ZakSvSpArt> ZakSvSpArt { get; set; }
        public virtual DbSet<ZakZakArtic> ZakZakArtic { get; set; }
        public virtual DbSet<ZakZakArticLabels> ZakZakArticLabels { get; set; }
        public virtual DbSet<ZakZakAudit> ZakZakAudit { get; set; }
        public virtual DbSet<ZakZakHis> ZakZakHis { get; set; }
        public virtual DbSet<ZakZakK3> ZakZakK3 { get; set; }
        public virtual DbSet<ZakZakSt> ZakZakSt { get; set; }
        public virtual DbSet<ZakПереносСроковЗаказа> ZakПереносСроковЗаказа { get; set; }
        public virtual DbSet<Zmkbg> Zmkbg { get; set; }
        public virtual DbSet<ZnEdTab> ZnEdTab { get; set; }
        public virtual DbSet<ZnEdTabNorm> ZnEdTabNorm { get; set; }
        public virtual DbSet<ZnHead> ZnHead { get; set; }
        public virtual DbSet<ZnTabel> ZnTabel { get; set; }
        public virtual DbSet<ZnZn> ZnZn { get; set; }
        public virtual DbSet<ZnZnDet> ZnZnDet { get; set; }
        public virtual DbSet<ZpAll> ZpAll { get; set; }
        public virtual DbSet<ZpAllCopy2020> ZpAllCopy2020 { get; set; }
        public virtual DbSet<ZpCalc> ZpCalc { get; set; }
        public virtual DbSet<ZpCalcBg> ZpCalcBg { get; set; }
        public virtual DbSet<ZpCat> ZpCat { get; set; }
        public virtual DbSet<ZpConfig> ZpConfig { get; set; }
        public virtual DbSet<ZpConfigizg> ZpConfigizg { get; set; }
        public virtual DbSet<ZpConfigpers> ZpConfigpers { get; set; }
        public virtual DbSet<ZpCurIzgot> ZpCurIzgot { get; set; }
        public virtual DbSet<ZpDistribution> ZpDistribution { get; set; }
        public virtual DbSet<ZpDocFiles> ZpDocFiles { get; set; }
        public virtual DbSet<ZpDocMonth> ZpDocMonth { get; set; }
        public virtual DbSet<ZpDocXlsx> ZpDocXlsx { get; set; }
        public virtual DbSet<ZpEbit> ZpEbit { get; set; }
        public virtual DbSet<ZpEbitSetup> ZpEbitSetup { get; set; }
        public virtual DbSet<ZpEkCostImd> ZpEkCostImd { get; set; }
        public virtual DbSet<ZpHhProf> ZpHhProf { get; set; }
        public virtual DbSet<ZpHhProm> ZpHhProm { get; set; }
        public virtual DbSet<ZpHhSalary> ZpHhSalary { get; set; }
        public virtual DbSet<ZpHhSpec> ZpHhSpec { get; set; }
        public virtual DbSet<ZpHhUr> ZpHhUr { get; set; }
        public virtual DbSet<ZpIndivid> ZpIndivid { get; set; }
        public virtual DbSet<ZpItog> ZpItog { get; set; }
        public virtual DbSet<ZpIzgsetup> ZpIzgsetup { get; set; }
        public virtual DbSet<ZpKateg> ZpKateg { get; set; }
        public virtual DbSet<ZpParam> ZpParam { get; set; }
        public virtual DbSet<ZpPers> ZpPers { get; set; }
        public virtual DbSet<ZpPersonal> ZpPersonal { get; set; }
        public virtual DbSet<ZpPolKoeff> ZpPolKoeff { get; set; }
        public virtual DbSet<ZpPolog> ZpPolog { get; set; }
        public virtual DbSet<ZpSec> ZpSec { get; set; }
        public virtual DbSet<ZpSecCard> ZpSecCard { get; set; }
        public virtual DbSet<ZpSecNew> ZpSecNew { get; set; }
        public virtual DbSet<ZpSecObj> ZpSecObj { get; set; }
        public virtual DbSet<ZpStruc> ZpStruc { get; set; }
        public virtual DbSet<ZpSvod> ZpSvod { get; set; }
        public virtual DbSet<ZpVed> ZpVed { get; set; }
        public virtual DbSet<ZpVypArtic> ZpVypArtic { get; set; }
        public virtual DbSet<ZpVypSetup> ZpVypSetup { get; set; }
        public virtual DbSet<ZpVypusk> ZpVypusk { get; set; }
        public virtual DbSet<Детали> Детали { get; set; }
        public virtual DbSet<ДляПечатиПрайса> ДляПечатиПрайса { get; set; }
        public virtual DbSet<Заголовки> Заголовки { get; set; }
        public virtual DbSet<ЗаказПринят> ЗаказПринят { get; set; }
        public virtual DbSet<КоличествоСданоПоЗаказам> КоличествоСданоПоЗаказам { get; set; }
        public virtual DbSet<КоличествоСданоПоЗаказамIdТов> КоличествоСданоПоЗаказамIdТов { get; set; }
        public virtual DbSet<МаксимальныйЧертеж> МаксимальныйЧертеж { get; set; }
        public virtual DbSet<МатериалыLifo> МатериалыLifo { get; set; }
        public virtual DbSet<ПрайсОсновной> ПрайсОсновной { get; set; }
        public virtual DbSet<ПрайсОсновнойNew> ПрайсОсновнойNew { get; set; }
        public virtual DbSet<ПрайсСравнительный> ПрайсСравнительный { get; set; }
        public virtual DbSet<ПрасСравнение> ПрасСравнение { get; set; }
        public virtual DbSet<Расчет> Расчет { get; set; }
        public virtual DbSet<РасчетСс> РасчетСс { get; set; }
        public virtual DbSet<РасчетСсАрхив> РасчетСсАрхив { get; set; }
        public virtual DbSet<РасчетСсКраскаПрошковая> РасчетСсКраскаПрошковая { get; set; }
        public virtual DbSet<РасчетСсНом> РасчетСсНом { get; set; }
        public virtual DbSet<РасчетСсТовар> РасчетСсТовар { get; set; }
        public virtual DbSet<ТоварВЗаказеРегион> ТоварВЗаказеРегион { get; set; }
        public virtual DbSet<Чертеж> Чертеж { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=prosrvna.prometad.ru;Initial Catalog=ASUPSQL;Persist Security Info=True;User ID=datasa;Password=KoSt55RoMa;Connection Timeout=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountTypes>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasComment("ИД начисления")
                    .ValueGeneratedNever();

                entity.Property(e => e.Calculated).HasComment("Флаг, означающий что начисление расчитывается программно (в редакторе начислений нельзя менять сумму)");

                entity.Property(e => e.Code1C)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComment("Код начисления 1С");

                entity.Property(e => e.DependOnWorkTime).HasComment(@"Вид зависимости от рабочего времени:
0 - не зависит, 1 - пропорционально с ограничением, 2 - пропорционально без ограничений");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ExtCode1C)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComment("Код доп.начисления 1С");

                entity.Property(e => e.IsRegular).HasComment(@"0 - начисляется разово в периоде
1 - начисляется каждый период");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasComment("Наименование");

                entity.Property(e => e.OrderType1)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Тип приказа, связанный с этим начислением");

                entity.Property(e => e.OrderType2)
                    .IsRequired()
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("Accounts_pk");

                entity.HasComment("Таблица служит для хранения начислений заработной платы по сотрудникам");

                entity.HasIndex(e => e.Tab)
                    .HasDatabaseName("Accounts_IX3");

                entity.HasIndex(e => new { e.IdIzgot, e.Period })
                    .HasDatabaseName("Accounts_IX1");

                entity.HasIndex(e => new { e.Account, e.OrgId, e.Days, e.Hours, e.Value, e.IdIzgot, e.KodIzgot, e.Period, e.Tab })
                    .HasDatabaseName("Accounts_IX2");

                entity.Property(e => e.Account).HasComment("Вид начисления из таблицы AccountTypes");

                entity.Property(e => e.Comments).HasMaxLength(60);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.Days).HasComment("Дней");

                entity.Property(e => e.Hours)
                    .HasColumnType("numeric(7, 3)")
                    .HasComment("Часов");

                entity.Property(e => e.IdIzgot).HasComment("ИД завода");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("Код участка");

                entity.Property(e => e.OrgId)
                    .HasColumnName("OrgID")
                    .HasComment("ID организации (из базы \"Кадры\")");

                entity.Property(e => e.Param1)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Произвольный числовой параметр начисления №1");

                entity.Property(e => e.Param2)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Произвольный числовой параметр начисления №2");

                entity.Property(e => e.Period)
                    .HasColumnType("date")
                    .HasComment("Период");

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .HasComment("источник данных");

                entity.Property(e => e.Status).HasComment("Статус записи (0 - первичная)");

                entity.Property(e => e.Tab).HasComment("Единый табельный номер");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasComment("Дата обновления");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("ИД пользователя, создавшего запись");

                entity.Property(e => e.Value)
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("Сумма начисления");
            });

            modelBuilder.Entity<AndFact>(entity =>
            {
                entity.HasKey(e => new { e.Shift, e.Kodizgot, e.Idizgot, e.Date })
                    .HasName("PK__AND.FACT__6824630360FD2D21");

                entity.ToTable("AND.FACT");

                entity.HasIndex(e => e.Idrec)
                    .HasDatabaseName("UQ__AND.FACT__A68686DC63D999CC")
                    .IsUnique();

                entity.Property(e => e.Shift).HasColumnName("SHIFT");

                entity.Property(e => e.Kodizgot)
                    .HasColumnName("KODIZGOT")
                    .HasMaxLength(20);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProdCount).HasColumnName("PROD_COUNT");
            });

            modelBuilder.Entity<AndPlaning>(entity =>
            {
                entity.HasKey(e => new { e.Idizgot, e.Kodizgot, e.Year, e.Month })
                    .HasName("PK__AND.PLAN__136B09A07ABCFF24");

                entity.ToTable("AND.PLANING");

                entity.HasIndex(e => e.Idrec)
                    .HasDatabaseName("UQ__AND.PLAN__A68686DC7D996BCF")
                    .IsUnique();

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kodizgot)
                    .HasColumnName("KODIZGOT")
                    .HasMaxLength(20);

                entity.Property(e => e.Year).HasColumnName("YEAR");

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MonthPlan).HasColumnName("MONTH_PLAN");

                entity.Property(e => e.ShiftCount).HasColumnName("SHIFT_COUNT");
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.ToTable("Applications", "service");

                entity.HasIndex(e => e.Name)
                    .HasDatabaseName("UQ__Applicat__737584F6C425C4F2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ИД приложения");

                entity.Property(e => e.CurrentVersion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1.0.0.0')")
                    .HasComment("Версия приложения");

                entity.Property(e => e.InstallTo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')")
                    .HasComment("Путь, куда инсталлировать");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата последнего обновления");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("Наименование приложения");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("Путь исходника установки");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Строковый идентификатор типа приложения: (WINFORMS, ANDROID, IOS)");
            });

            modelBuilder.Entity<ArtArt1cToDelete>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ART_1C_PK");

                entity.ToTable("ART.ART_1C_To_Delete");

                entity.HasIndex(e => e.Art1c)
                    .HasDatabaseName("ART_1C_IX1");

                entity.HasIndex(e => e.ArtNew)
                    .HasDatabaseName("ART_1C_IX2");

                entity.HasIndex(e => e.ArtTo)
                    .HasDatabaseName("ART_1C_IX3");

                entity.HasIndex(e => new { e.Articul, e.Art1c })
                    .HasDatabaseName("ART_1C_IX5");

                entity.HasIndex(e => new { e.Articul, e.ArtNew })
                    .HasDatabaseName("ART_1C_IX4");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Art1c)
                    .HasColumnName("ART_1C")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ArtNew)
                    .HasColumnName("ART_NEW")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ArtTo)
                    .HasColumnName("ART_TO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.EdIzm1c)
                    .HasColumnName("ED_IZM1C")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Koeff)
                    .HasColumnName("KOEFF")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Logpr).HasColumnName("LOGPR");

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nds).HasColumnName("NDS");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<ArtArticD>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ARTIC_D_PK");

                entity.ToTable("ART.ARTIC_D");

                entity.HasIndex(e => e.Articulext1)
                    .HasDatabaseName("ARTIC_D_IX3");

                entity.HasIndex(e => e.IdArticul)
                    .HasDatabaseName("ID_ARTICUL");

                entity.HasIndex(e => new { e.Det, e.Articul, e.DopCod })
                    .HasDatabaseName("ARTIC_D_IX2");

                entity.HasIndex(e => new { e.Articul, e.DopCod, e.Nam, e.Idizgot, e.Delrecord, e.Det })
                    .HasDatabaseName("IDIZGOT_DELRECORD_DET");

                entity.HasIndex(e => new { e.Articulext1, e.Idizgot, e.Nam, e.Articul, e.DopCod, e.Delrecord })
                    .HasDatabaseName("ARTIC_D_IX1");

                entity.HasIndex(e => new { e.Datsavesql, e.Def, e.Det, e.ArticulExt, e.Articulext1, e.EanCode, e.Ros, e.NamB, e.NamK, e.DopCod, e.Idizgot, e.NamKk, e.Rostyp, e.Idrec, e.Price, e.Price1, e.Price2, e.KrNam, e.Prim, e.Delrecord, e.Articul, e.Nam })
                    .HasDatabaseName("IND_AUTO_BY_EXECUTE_PLAN_ARTIC_D");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(50);

                entity.Property(e => e.ArticulExt)
                    .HasColumnName("ARTICUL_EXT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Articulext1)
                    .HasColumnName("ARTICULEXT")
                    .HasMaxLength(50);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Def).HasColumnName("DEF");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.IdArticul).HasColumnName("ID_ARTICUL");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KrNam)
                    .HasColumnName("KR_NAM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamB).HasColumnName("NAM_B");

                entity.Property(e => e.NamK)
                    .HasColumnName("NAM_K")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NamKk)
                    .HasColumnName("NAM_KK")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ros)
                    .HasColumnName("ROS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Rostyp)
                    .HasColumnName("ROSTYP")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtArticDArhive>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ARTIC_D_ARHIVE_PK");

                entity.ToTable("ART.ARTIC_D_ARHIVE");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedNever();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(50);

                entity.Property(e => e.ArticulExt)
                    .HasColumnName("ARTICUL_EXT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Articulext1)
                    .HasColumnName("ARTICULEXT")
                    .HasMaxLength(50);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Def).HasColumnName("DEF");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.IdArticul).HasColumnName("ID_ARTICUL");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KrNam)
                    .HasColumnName("KR_NAM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamB).HasColumnName("NAM_B");

                entity.Property(e => e.NamK)
                    .HasColumnName("NAM_K")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NamKk)
                    .HasColumnName("NAM_KK")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ros)
                    .HasColumnName("ROS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Rostyp)
                    .HasColumnName("ROSTYP")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtArticModel>(entity =>
            {
                entity.ToTable("ART.ARTIC_MODEL");

                entity.HasIndex(e => new { e.Articul, e.DopCod })
                    .HasDatabaseName("IX_ART.ARTIC_MODEL_Column")
                    .IsUnique();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DopCod)
                    .IsRequired()
                    .HasColumnName("Dop_cod")
                    .HasMaxLength(2);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ArtArticNm1>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ARTIC_NM1_PK");

                entity.ToTable("ART.ARTIC_NM1");

                entity.HasIndex(e => new { e.Articul, e.DopCod })
                    .HasDatabaseName("ARTIC_NM1_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Articulnew)
                    .HasColumnName("ARTICULNEW")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Del).HasColumnName("DEL");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Namnew)
                    .HasColumnName("NAMNEW")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtArticNm3>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ARTIC_NM3_PK");

                entity.ToTable("ART.ARTIC_NM3");

                entity.HasIndex(e => new { e.Articul, e.DopCod })
                    .HasDatabaseName("ARTIC_NM3_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtArticPr>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ARTIC_PR_PK");

                entity.ToTable("ART.ARTIC_PR");

                entity.HasIndex(e => new { e.Articul, e.DopCod })
                    .HasDatabaseName("ARTIC_PR_IX2");

                entity.HasIndex(e => new { e.Price, e.Idizgot, e.Articul, e.DopCod, e.Delrecord })
                    .HasDatabaseName("ARTICUL_PRICE_BY_IZGOT");

                entity.HasIndex(e => new { e.Articul, e.DopCod, e.Price, e.Price1, e.Price2, e.PriceM })
                    .HasDatabaseName("ARTIC_PR_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Form)
                    .HasColumnName("FORM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Idhost)
                    .HasColumnName("IDHOST")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceM)
                    .HasColumnName("PRICE_M")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<ArtArticPrArchive>(entity =>
            {
                entity.ToTable("ART.ARTIC_PR_ARCHIVE");

                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("ART.ARTIC_PR_ARCHIVE_uq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Article)
                    .IsRequired()
                    .HasColumnName("ARTICLE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DateArchive)
                    .HasColumnName("DATE_ARCHIVE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtraCode)
                    .IsRequired()
                    .HasColumnName("EXTRA_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<ArtArticPrHistory>(entity =>
            {
                entity.HasKey(e => new { e.Idizgot, e.Articul, e.DopCod, e.Datecomp })
                    .HasName("ARTIC_PR_HISTORY_PK_ART.ARTIC_PR_HISTORY");

                entity.ToTable("ART.ARTIC_PR_HISTORY");

                entity.HasIndex(e => e.Idrec)
                    .HasDatabaseName("ART.ARTIC_PR_HISTORY_UQ")
                    .IsUnique();

                entity.HasIndex(e => new { e.Articul, e.DopCod, e.Price, e.Idrec, e.Articulext, e.Idizgot, e.Year, e.Month })
                    .HasDatabaseName("IDIZGOT_YEAR_MONTH");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DopCod).HasColumnName("DOP_COD");

                entity.Property(e => e.Datecomp)
                    .HasColumnName("DATECOMP")
                    .HasComputedColumnSql("([YEAR]*(12)+[MONTH])");

                entity.Property(e => e.Articulext)
                    .HasColumnName("ARTICULEXT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("CREATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<ArtArticPrLog>(entity =>
            {
                entity.ToTable("ART.ARTIC_PR_LOG");

                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("ART.ARTIC_PR_LOG_uq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Article)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DateChange).HasColumnType("datetime");

                entity.Property(e => e.ExtraCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Iduser).HasColumnName("IDUser");

                entity.Property(e => e.PriceIs).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceWas).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<ArtArticPrNov2015>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ARTIC_PR_PK_ART.ARTIC_PR_nov2015");

                entity.ToTable("ART.ARTIC_PR_nov2015");

                entity.HasIndex(e => new { e.Articul, e.DopCod })
                    .HasDatabaseName("ARTIC_PR_IX2");

                entity.HasIndex(e => new { e.Price, e.Idizgot, e.Articul, e.DopCod, e.Delrecord })
                    .HasDatabaseName("ARTICUL_PRICE_BY_IZGOT");

                entity.HasIndex(e => new { e.Articul, e.DopCod, e.Price, e.Price1, e.Price2, e.PriceM })
                    .HasDatabaseName("ARTIC_PR_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Form)
                    .HasColumnName("FORM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Idhost)
                    .HasColumnName("IDHOST")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceM)
                    .HasColumnName("PRICE_M")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<ArtArticPrOld>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ARTIC_PR_OLD_PK");

                entity.ToTable("ART.ARTIC_PR_OLD");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Form)
                    .HasColumnName("FORM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Idhost)
                    .HasColumnName("IDHOST")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceM)
                    .HasColumnName("PRICE_M")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<ArtArticSh1>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ARTIC_SH1_PK");

                entity.ToTable("ART.ARTIC_SH1");

                entity.HasIndex(e => e.Articul)
                    .HasDatabaseName("ARTIC_SH1_IX1");

                entity.HasIndex(e => new { e.FrmType, e.Articul })
                    .HasDatabaseName("ARTIC_SH1_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Del).HasColumnName("DEL");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.FrmType)
                    .HasColumnName("FRM_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");
            });

            modelBuilder.Entity<ArtArticul>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .IsClustered(false);

                entity.ToTable("ART.ARTICUL");

                entity.HasIndex(e => e.Articul)
                    .HasDatabaseName("ART.ARTICUL_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(50);

                entity.Property(e => e.ArticulAlt)
                    .HasColumnName("ARTICUL_ALT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ArticulTo)
                    .IsRequired()
                    .HasColumnName("ARTICUL_TO")
                    .HasMaxLength(50);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.EditUp)
                    .HasColumnName("EDIT_UP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.En).HasColumnName("EN");

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Group)
                    .HasColumnName("GROUP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdPlantType39)
                    .HasColumnName("ID_PLANT_TYPE_39")
                    .HasComment("[PlantTypes].ID - тип производства в Москве");

                entity.Property(e => e.IdPlantType42)
                    .HasColumnName("ID_PLANT_TYPE_42")
                    .HasComment("[PlantTypes].ID - тип производства на болгарском заводе");

                entity.Property(e => e.IdPlantType44)
                    .HasColumnName("ID_PLANT_TYPE_44")
                    .HasComment("[PlantTypes].ID - тип производства на УЗМК");

                entity.Property(e => e.IdPrGroup)
                    .HasColumnName("ID_PR_GROUP")
                    .HasComment("[ART.PR_GROUP].ID");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KolM)
                    .HasColumnName("KOL_M")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.KolUp)
                    .HasColumnName("KOL_UP")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Locnum)
                    .HasColumnName("LOCNUM")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.LogNum).HasColumnName("LOG_NUM");

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mod)
                    .HasColumnName("MOD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Net)
                    .HasColumnName("NET")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Netto)
                    .HasColumnName("NETTO")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.New).HasColumnName("NEW");

                entity.Property(e => e.Ob)
                    .HasColumnName("OB")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.PrType)
                    .HasColumnName("PR_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceOpt)
                    .HasColumnName("PRICE_OPT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Print).HasColumnName("PRINT");

                entity.Property(e => e.ProdDepth).HasColumnName("PROD_DEPTH");

                entity.Property(e => e.ProdHeight).HasColumnName("PROD_HEIGHT");

                entity.Property(e => e.ProdWidth).HasColumnName("PROD_WIDTH");

                entity.Property(e => e.Ros)
                    .HasColumnName("ROS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Rostyp)
                    .HasColumnName("ROSTYP")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TypSer)
                    .HasColumnName("TYP_SER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Upac)
                    .HasColumnName("UPAC")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtArticulArhive>(entity =>
            {
                entity.HasKey(e => e.Idrec);

                entity.ToTable("ART.ARTICUL_ARHIVE");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedNever();

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ArticulAlt)
                    .HasColumnName("ARTICUL_ALT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord)
                    .HasColumnName("DELRECORD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.EditUp)
                    .HasColumnName("EDIT_UP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.En).HasColumnName("EN");

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Group)
                    .HasColumnName("GROUP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdPlantType39).HasColumnName("ID_PLANT_TYPE_39");

                entity.Property(e => e.IdPlantType42).HasColumnName("ID_PLANT_TYPE_42");

                entity.Property(e => e.IdPlantType44).HasColumnName("ID_PLANT_TYPE_44");

                entity.Property(e => e.IdPrGroup).HasColumnName("ID_PR_GROUP");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KolM)
                    .HasColumnName("KOL_M")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.KolUp)
                    .HasColumnName("KOL_UP")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Locnum)
                    .HasColumnName("LOCNUM")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.LogNum).HasColumnName("LOG_NUM");

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mod)
                    .HasColumnName("MOD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Net)
                    .HasColumnName("NET")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Netto)
                    .HasColumnName("NETTO")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.New).HasColumnName("NEW");

                entity.Property(e => e.Ob)
                    .HasColumnName("OB")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.PrType)
                    .HasColumnName("PR_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceOpt)
                    .HasColumnName("PRICE_OPT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Print).HasColumnName("PRINT");

                entity.Property(e => e.Ros)
                    .HasColumnName("ROS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Rostyp)
                    .HasColumnName("ROSTYP")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TypSer)
                    .HasColumnName("TYP_SER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Upac)
                    .HasColumnName("UPAC")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtArticulExt>(entity =>
            {
                entity.HasKey(e => new { e.Articul, e.DopCod, e.Idizgot });

                entity.ToTable("ART.ARTICUL_EXT");

                entity.HasComment("Дополнительная информация о артикуле");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12);

                entity.Property(e => e.DopCod).HasColumnName("DOP_COD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("CREATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Labor)
                    .HasColumnName("LABOR")
                    .HasColumnType("numeric(10, 4)")
                    .HasComment("Трудоемкость");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("numeric(10, 3)")
                    .HasComment("Чистый вес");
            });

            modelBuilder.Entity<ArtDetLabArt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ART.DET_LAB_ART");

                entity.HasIndex(e => e.Datsavesql)
                    .HasDatabaseName("DET_LAB_ART_IX2");

                entity.HasIndex(e => e.Idizgot)
                    .HasDatabaseName("DET_LAB_ART_IX3");

                entity.HasIndex(e => e.Idrec)
                    .HasDatabaseName("DET_LAB_ART_IX4");

                entity.HasIndex(e => new { e.Articul, e.DopCod })
                    .HasDatabaseName("DET_LAB_ART_IX1");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CharN)
                    .HasColumnName("CHAR_N")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Madein)
                    .HasColumnName("MADEIN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Pole1)
                    .HasColumnName("POLE1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole10)
                    .HasColumnName("POLE10")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole2)
                    .HasColumnName("POLE2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole3)
                    .HasColumnName("POLE3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole4)
                    .HasColumnName("POLE4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole5)
                    .HasColumnName("POLE5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole6)
                    .HasColumnName("POLE6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole7)
                    .HasColumnName("POLE7")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole8)
                    .HasColumnName("POLE8")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole9)
                    .HasColumnName("POLE9")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Prom)
                    .HasColumnName("PROM")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtDetLabe>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("DET_LABE_PK");

                entity.ToTable("ART.DET_LABE");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("DET_LABE_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.CharN)
                    .HasColumnName("CHAR_N")
                    .HasMaxLength(20);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Madein)
                    .HasColumnName("MADEIN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Pole1)
                    .HasColumnName("POLE1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole2)
                    .HasColumnName("POLE2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole3)
                    .HasColumnName("POLE3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole4)
                    .HasColumnName("POLE4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole5)
                    .HasColumnName("POLE5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole6)
                    .HasColumnName("POLE6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole7)
                    .HasColumnName("POLE7")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole8)
                    .HasColumnName("POLE8")
                    .HasMaxLength(30);

                entity.Property(e => e.Pole9)
                    .HasColumnName("POLE9")
                    .HasMaxLength(50);

                entity.Property(e => e.Prom)
                    .HasColumnName("PROM")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtDetLabr>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("DET_LABR_PK");

                entity.ToTable("ART.DET_LABR");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("DET_LABR_IX1");

                entity.HasIndex(e => new { e.Det, e.Idizgot })
                    .HasDatabaseName("IX_ART.DET_LABR")
                    .IsUnique();

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.CharN)
                    .HasColumnName("CHAR_N")
                    .HasMaxLength(20);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Madein)
                    .HasColumnName("MADEIN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Pole1)
                    .HasColumnName("POLE1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole2)
                    .HasColumnName("POLE2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole3)
                    .HasColumnName("POLE3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole4)
                    .HasColumnName("POLE4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole5)
                    .HasColumnName("POLE5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole6)
                    .HasColumnName("POLE6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole7)
                    .HasColumnName("POLE7")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole8)
                    .HasColumnName("POLE8")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole9)
                    .HasColumnName("POLE9")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prom)
                    .HasColumnName("PROM")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtKodizgot>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("KODIZGOT_PK_ART.KODIZGOT1");

                entity.ToTable("ART.KODIZGOT");

                entity.HasComment("Сколько ЗП приходится на каждый выпущенный артикул (в разрезе участков)");

                entity.HasIndex(e => new { e.IdIzgot, e.KodIzgot })
                    .HasDatabaseName("ART.KODIZGOT1_ОтборПоПлощадке");

                entity.HasIndex(e => new { e.IdIzgot, e.Articul, e.DopCod })
                    .HasDatabaseName("ARTICUL_DOP_COD_IDIZGOT");

                entity.HasIndex(e => new { e.IdIzgot, e.KodIzgot, e.Articul, e.DopCod, e.Operation })
                    .HasDatabaseName("ART.KODIZGOT_UI")
                    .IsUnique();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Артикул (производимое изделие)");

                entity.Property(e => e.ChangeDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ChangeUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DopCod)
                    .HasColumnName("Dop_Cod")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Доп.код");

                entity.Property(e => e.IdIzgot).HasComment("ID изготовителя (завод)");

                entity.Property(e => e.IsSummary)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("Флаг, указывающий итоговое значение. Все записи без этого флага - это состав этого артикула по операциям");

                entity.Property(e => e.KodIzgot).HasComment("Ссылка на код участка");

                entity.Property(e => e.Norm)
                    .HasColumnType("decimal(10, 5)")
                    .HasComment("Норматив для операции");

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Итого')")
                    .HasComment(@"Название операции (для итоговых значений ""Итого"")
Операции берутся из таблицы TECH.ST_OPER");

                entity.Property(e => e.PrType)
                    .HasColumnName("Pr_Type")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasComment("Тип производства");

                entity.Property(e => e.Tarif)
                    .HasColumnType("decimal(10, 2)")
                    .HasComment("Тариф для операции");

                entity.Property(e => e.Zp)
                    .HasColumnName("ZP")
                    .HasColumnType("decimal(10, 2)")
                    .HasComment("ФОТ для артикула или операции");
            });

            modelBuilder.Entity<ArtLogBox1>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("LOG_BOX1_PK");

                entity.ToTable("ART.LOG_BOX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasColumnName("GROUP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");
            });

            modelBuilder.Entity<ArtPrGroup>(entity =>
            {
                entity.ToTable("ART.PR_GROUP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HoursInDay).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Idsection)
                    .HasColumnName("IDSection")
                    .HasComment("[ART.PR_GROUP_SECTIONS].ID");

                entity.Property(e => e.Idsection39)
                    .HasColumnName("IDSection_39")
                    .HasComment("[ART.PR_GROUP_SECTIONS].ID");

                entity.Property(e => e.Idsection44)
                    .HasColumnName("IDSection_44")
                    .HasComment("[ART.PR_GROUP_SECTIONS].ID");

                entity.Property(e => e.PlanDays2100)
                    .HasColumnType("decimal(4, 1)")
                    .HasComment("Плановое количество дней на заготовку");

                entity.Property(e => e.PlanDays2200)
                    .HasColumnType("decimal(4, 1)")
                    .HasComment("Плановое количество дней на гибку");

                entity.Property(e => e.PlanDays2300)
                    .HasColumnType("decimal(4, 1)")
                    .HasComment("Плановое количество дней на сварку");

                entity.Property(e => e.PlanDays2400)
                    .HasColumnType("decimal(4, 1)")
                    .HasComment("Плановое количество дней на покраску");

                entity.Property(e => e.PlanDays2500)
                    .HasColumnType("decimal(4, 1)")
                    .HasComment("Плановое количество дней на заливку бетоном");

                entity.Property(e => e.PlanDays2700)
                    .HasColumnType("decimal(4, 1)")
                    .HasComment("Плановое количество дней на сборку");

                entity.Property(e => e.PlanDays2800)
                    .HasColumnType("decimal(4, 1)")
                    .HasComment("Плановое количество дней на жидкую покраску");

                entity.Property(e => e.PlanDays2821)
                    .HasColumnType("decimal(4, 1)")
                    .HasComment("Плановое количество дней на подготовку");

                entity.Property(e => e.PlanDays2823)
                    .HasColumnType("decimal(4, 1)")
                    .HasComment("Плановое количество дней на герметизацию");

                entity.Property(e => e.PrGroup)
                    .IsRequired()
                    .HasColumnName("PR_GROUP")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityProducedDay).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.QuantityProducedDay39)
                    .HasColumnName("QuantityProducedDay_39")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.QuantityProducedDay44)
                    .HasColumnName("QuantityProducedDay_44")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.QuantityProducedHour)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SizeGroup)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WorkersQuantity).HasColumnType("decimal(4, 1)");
            });

            modelBuilder.Entity<ArtPrGroupSections>(entity =>
            {
                entity.ToTable("ART.PR_GROUP_SECTIONS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InReport).HasComment("Признак включения участка в отчет");

                entity.Property(e => e.ScheduleType).HasComment("0 - график 5/2; 1 - график 7/7");

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SectionTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Название участка для отчета");

                entity.Property(e => e.Unit).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ArtPrType>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PR_TYPE_PK");

                entity.ToTable("ART.PR_TYPE");

                entity.HasIndex(e => e.Litera)
                    .HasDatabaseName("PR_TYPE_IX1");

                entity.HasIndex(e => e.PrType)
                    .HasDatabaseName("PR_TYPE_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Litera)
                    .HasColumnName("LITERA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrType)
                    .HasColumnName("PR_TYPE")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArticulComplectation>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.GoodId)
                    .HasDatabaseName("ArticulComplectation_IX_GoodID");

                entity.HasIndex(e => new { e.GoodId, e.Detail })
                    .HasDatabaseName("ArticulComplectation_IX_Det")
                    .IsUnique();

                entity.Property(e => e.CustomName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Наименование детали, если оно отличается от справочных данных");

                entity.Property(e => e.CustomNameEn)
                    .HasColumnName("CustomName_EN")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Наименование на англ. языке");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Код детали в комплекте");

                entity.Property(e => e.GoodId)
                    .HasColumnName("GoodID")
                    .HasComment("ИД товара");

                entity.Property(e => e.MeasureUnit)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('шт.')");

                entity.Property(e => e.Quantity).HasComment("Количество");
            });

            modelBuilder.Entity<ArticulModelCost>(entity =>
            {
                entity.HasKey(e => new { e.IdIzgot, e.Model, e.Operation })
                    .HasName("ArticulModelCost_PK");

                entity.HasComment("Операции и расценки для каждой модели артикула");

                entity.HasIndex(e => e.KodIzgot)
                    .HasDatabaseName("ArticulModelCost_idx1");

                entity.Property(e => e.IdIzgot)
                    .HasDefaultValueSql("((44))")
                    .HasComment("ИД завода");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .HasComment("Модель артикула");

                entity.Property(e => e.Operation)
                    .HasMaxLength(20)
                    .HasComment("Операция");

                entity.Property(e => e.ChangeDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата/время последней правки");

                entity.Property(e => e.ChangeUser)
                    .HasMaxLength(20)
                    .HasComment("Пользователь");

                entity.Property(e => e.Delrecord).HasComment("Признак удаления");

                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Товарное направление");

                entity.Property(e => e.IdRec).ValueGeneratedOnAdd();

                entity.Property(e => e.KodIzgot)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Затратная зона");

                entity.Property(e => e.Norm)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Норма операции (в часах)");

                entity.Property(e => e.Tarif)
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Тариф операции (за 1 нормочас)");
            });

            modelBuilder.Entity<ArticulModelCost1>(entity =>
            {
                entity.HasKey(e => new { e.IdIzgot, e.Model, e.Operation })
                    .HasName("ArticulModelCost_PK_ArticulModelCost");

                entity.ToTable("ArticulModelCost", "fortests");

                entity.HasComment("Операции и расценки для каждой модели артикула");

                entity.HasIndex(e => e.KodIzgot)
                    .HasDatabaseName("ArticulModelCost_idx1");

                entity.Property(e => e.IdIzgot)
                    .HasDefaultValueSql("((44))")
                    .HasComment("ИД завода");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .HasComment("Модель артикула");

                entity.Property(e => e.Operation)
                    .HasMaxLength(20)
                    .HasComment("Операция");

                entity.Property(e => e.ChangeDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата/время последней правки");

                entity.Property(e => e.ChangeUser)
                    .HasMaxLength(20)
                    .HasComment("Пользователь");

                entity.Property(e => e.Delrecord).HasComment("Признак удаления");

                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Товарное направление");

                entity.Property(e => e.IdRec).ValueGeneratedOnAdd();

                entity.Property(e => e.KodIzgot)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Затратная зона");

                entity.Property(e => e.Norm)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Норма операции (в часах)");

                entity.Property(e => e.Tarif)
                    .HasColumnType("numeric(12, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Тариф операции (за 1 нормочас)");
            });

            modelBuilder.Entity<ArticulModelMatching>(entity =>
            {
                entity.HasKey(e => new { e.Articul, e.DopCode })
                    .HasName("ArticulModelMatching_PK");

                entity.Property(e => e.Articul)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C98255C790F")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasDatabaseName("UQ__aspnet_A__309103312B155265")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasDatabaseName("aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D43E1002F")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail })
                    .HasDatabaseName("aspnet_Membership_index")
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMembership)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__45C948A1");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__46BD6CDA");
            });

            modelBuilder.Entity<AspnetPaths>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC587D197D8B")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath })
                    .HasDatabaseName("aspnet_Paths_index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__7F01C5FD");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUsers>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5904BA9F53");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUsers)
                    .HasForeignKey<AspnetPersonalizationAllUsers>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__06A2E7C5");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC06097F5470")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.HasIndex(e => new { e.PathId, e.UserId })
                    .HasDatabaseName("aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId })
                    .HasDatabaseName("aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__0C5BC11B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__0D4FE554");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C5AC46587");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__5CACADF9");
            });

            modelBuilder.Entity<AspnetRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1B66361833")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName })
                    .HasDatabaseName("aspnet_Roles_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__681E60A5");
            });

            modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC1377B294A");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D2FDA0782")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
                    .HasDatabaseName("aspnet_Users_Index2");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
                    .HasDatabaseName("aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__31C24FF4");
            });

            modelBuilder.Entity<AspnetUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_U__AF2760AD6BEEF189");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasDatabaseName("aspnet_UsersInRoles_index");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__6ECB5E34");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__6DD739FB");
            });

            modelBuilder.Entity<AspnetWebEventEvents>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C8101D864D1D");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<AsupLog>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ERROR')");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("ID пользователя ASUP");
            });

            modelBuilder.Entity<AttHch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Att.HCh");

                entity.HasIndex(e => new { e.IdAtt, e.HidCh })
                    .HasDatabaseName("IX_Att.HCh")
                    .IsUnique();

                entity.Property(e => e.HidCh).HasColumnName("HID_CH");
            });

            modelBuilder.Entity<AttHid>(entity =>
            {
                entity.ToTable("Att_Hid");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.Comp).HasDefaultValueSql("((6))");

                entity.Property(e => e.DateS).HasColumnType("datetime");

                entity.Property(e => e.Des)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'А')");

                entity.Property(e => e.NorDoc).HasDefaultValueSql("((6))");

                entity.Property(e => e.Prof).HasDefaultValueSql("((6))");
            });

            modelBuilder.Entity<AttMain>(entity =>
            {
                entity.HasKey(e => e.IdAtt);

                entity.ToTable("Att.Main");

                entity.Property(e => e.DateAtt).HasColumnType("datetime");
            });

            modelBuilder.Entity<AttQa>(entity =>
            {
                entity.HasKey(e => e.IdQ);

                entity.ToTable("Att.QA");

                entity.Property(e => e.Ans).IsRequired();

                entity.Property(e => e.Bai)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DateS).HasColumnType("datetime");

                entity.Property(e => e.Pic).HasColumnType("image");

                entity.Property(e => e.Qwes).IsRequired();
            });

            modelBuilder.Entity<AttSprQ>(entity =>
            {
                entity.HasKey(e => e.SprId);

                entity.ToTable("Att.SprQ");

                entity.Property(e => e.Bai)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DateS).HasColumnType("datetime");

                entity.Property(e => e.SprNam)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<AttSprQgr>(entity =>
            {
                entity.HasKey(e => e.SprIdGr);

                entity.ToTable("Att.SprQGr");

                entity.Property(e => e.Bai)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DateS).HasColumnType("datetime");

                entity.Property(e => e.SprNamGr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<AttSprQq>(entity =>
            {
                entity.HasKey(e => e.IdQq);

                entity.ToTable("Att.SprQQ");

                entity.Property(e => e.IdQq).HasColumnName("IdQQ");

                entity.Property(e => e.Kol).HasDefaultValueSql("((1))");

                entity.Property(e => e.Wes).HasDefaultValueSql("((10))");
            });

            modelBuilder.Entity<BrakReasonList>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.ToTable("BRAK.ReasonList");

                entity.Property(e => e.ReasonId)
                    .HasColumnName("ReasonID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BrigadeOptions>(entity =>
            {
                entity.HasKey(e => new { e.IdIzgot, e.Brigade })
                    .HasName("BrigadeOptions_pk");

                entity.HasComment("Опции бригады");

                entity.Property(e => e.Brigade).HasComment("Номер бригады");

                entity.Property(e => e.Operations)
                    .HasMaxLength(200)
                    .HasComment("Список выполняемых операций");
            });

            modelBuilder.Entity<BscTarget>(entity =>
            {
                entity.ToTable("BSC.Target");

                entity.HasIndex(e => e.IdWork)
                    .HasDatabaseName("IX_BSC.Target_Column");

                entity.Property(e => e.NamTarget).IsRequired();

                entity.Property(e => e.TypeTarget)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UserInput).HasColumnName("User_Input");

                entity.Property(e => e.Value).HasMaxLength(50);

                entity.Property(e => e.ValueD).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.ValueData).HasColumnType("datetime");
            });

            modelBuilder.Entity<BscValue>(entity =>
            {
                entity.ToTable("BSC.Value");

                entity.HasIndex(e => new { e.IdTarget, e.Month, e.Year })
                    .HasDatabaseName("IX_BSC.Value_Column");

                entity.Property(e => e.UserInput).HasColumnName("User_Input");

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<CartonExecution>(entity =>
            {
                entity.ToTable("CartonExecution", "fortests");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ИД транзакции");

                entity.Property(e => e.Count).HasComment("Количество исп. листов");

                entity.Property(e => e.FinishDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Когда были сделаны изменения");

                entity.Property(e => e.IsReuse).HasComment("Является ли перерезкой (втор. исп.)");

                entity.Property(e => e.IsUnformat).HasComment("Является ли неформатом");

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Оператор");

                entity.Property(e => e.Produced).HasComment("Произведено деталей");

                entity.Property(e => e.Sheet).HasComment("ID листа, из которого резали");

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasComment("ИД задачи");
            });

            modelBuilder.Entity<CartonPack>(entity =>
            {
                entity.ToTable("CartonPack", "fortests");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ИД");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Артикул (если есть)");

                entity.Property(e => e.DefaultSheet)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Лист по умолчанию");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Группа");

                entity.Property(e => e.Height).HasComment("Высота упаковки в мм");

                entity.Property(e => e.Length).HasComment("Длина упаковки в мм");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Наименование");

                entity.Property(e => e.Type).HasComment("Вид упаковки (0 - крыша, 1 - дно)");

                entity.Property(e => e.Width).HasComment("Ширина упаковки в мм");
            });

            modelBuilder.Entity<CartonSheets>(entity =>
            {
                entity.ToTable("CartonSheets", "fortests");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ИД листа");

                entity.Property(e => e.Layers).HasComment("Число слоев");

                entity.Property(e => e.Length).HasComment("Длина листа в мм");

                entity.Property(e => e.Width).HasComment("Ширина листа в мм");
            });

            modelBuilder.Entity<CartonTasks>(entity =>
            {
                entity.ToTable("CartonTasks", "fortests");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("ИД задачи");

                entity.Property(e => e.AtTime)
                    .HasColumnType("datetime")
                    .HasComment("К какому времени");

                entity.Property(e => e.Count).HasComment("Затребованное кол-во");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Заказчик");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasComment("Дата");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasComment("ИД упаковки");

                entity.Property(e => e.Smena)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Смена");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("ИД пользователя");
            });

            modelBuilder.Entity<CatCatGr>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("CAT_GR_PK");

                entity.ToTable("CAT.CAT_GR");

                entity.HasIndex(e => e.Cat)
                    .HasDatabaseName("CAT_GR_IX1");

                entity.HasIndex(e => e.CatGr)
                    .HasDatabaseName("CAT_GR");

                entity.HasIndex(e => new { e.Idrec, e.Nam, e.Delrecord })
                    .HasDatabaseName("DELRECORD");

                entity.HasIndex(e => new { e.Contr, e.Idizgot, e.Delrecord, e.AsVyvod })
                    .HasDatabaseName("CompoundOne");

                entity.HasIndex(e => new { e.CatGr, e.Idizgot, e.Nam, e.AsVyvod, e.Delrecord })
                    .HasDatabaseName("CAT_GR_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Cat)
                    .HasColumnName("CAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CatGr)
                    .HasColumnName("CAT_GR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Contr).HasColumnName("CONTR");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rec)
                    .HasColumnName("REC")
                    .HasColumnType("decimal(6, 0)");
            });

            modelBuilder.Entity<CatCatMashPrice>(entity =>
            {
                entity.HasKey(e => e.IdPrice);

                entity.ToTable("Cat.CatMashPrice");

                entity.HasIndex(e => e.IdMash)
                    .HasDatabaseName("IX_Cat.CatMashPrice");

                entity.Property(e => e.IdPrice).ValueGeneratedNever();

                entity.Property(e => e.Bai)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DataIzm).HasColumnType("datetime");

                entity.Property(e => e.IdStat).HasDefaultValueSql("(99999)");

                entity.Property(e => e.Persent).HasDefaultValueSql("(100)");

                entity.Property(e => e.Price)
                    .HasColumnType("numeric(10, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Prim).HasMaxLength(50);
            });

            modelBuilder.Entity<CatCatgr1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cat.catgr");

                entity.HasIndex(e => e.Articul)
                    .HasDatabaseName("IX_Cat.catgr_2");

                entity.HasIndex(e => new { e.Idcat, e.Idsubcat })
                    .HasDatabaseName("IX_Cat.catgr");

                entity.HasIndex(e => new { e.Idsubcat, e.Idcat })
                    .HasDatabaseName("IX_Cat.catgr_1");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Idcat).HasColumnName("IDcat");

                entity.Property(e => e.Iddet).HasColumnName("IDdet");

                entity.Property(e => e.Idsubcat).HasColumnName("IDsubcat");

                entity.Property(e => e.Lit)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatCatid>(entity =>
            {
                entity.HasKey(e => e.Idcat);

                entity.ToTable("Cat.catid");

                entity.Property(e => e.Idcat)
                    .HasColumnName("IDcat")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.LustArticul).HasDefaultValueSql("(0)");

                entity.Property(e => e.Nam)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Root)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UserUr).HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<CatCatВ>(entity =>
            {
                entity.HasKey(e => e.IdDet)
                    .HasName("PK_Cat.CatД");

                entity.ToTable("Cat.CatВ");

                entity.Property(e => e.IdDet).ValueGeneratedNever();

                entity.Property(e => e.Articul).HasMaxLength(20);

                entity.Property(e => e.Bai)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DataIzm).HasColumnType("datetime");

                entity.Property(e => e.Dostup)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.EdIzm).HasMaxLength(6);

                entity.Property(e => e.Nam)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<CatCatЗ>(entity =>
            {
                entity.HasKey(e => e.Iddet);

                entity.ToTable("Cat.CatЗ");

                entity.HasIndex(e => e.Articul)
                    .HasDatabaseName("IX_Cat.CatЗ_1");

                entity.HasIndex(e => e.Idmain)
                    .HasDatabaseName("IX_Cat.CatЗ");

                entity.Property(e => e.Iddet)
                    .HasColumnName("IDDet")
                    .ValueGeneratedNever();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Bai)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DataIzm).HasColumnType("datetime");

                entity.Property(e => e.Dostup)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Idmain).HasColumnName("IDMain");

                entity.Property(e => e.IsZ)
                    .HasColumnName("Is_z")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Lider)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LogMol)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nam)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatDoc>(entity =>
            {
                entity.HasKey(e => e.IdDoc);

                entity.ToTable("Cat.Doc");

                entity.Property(e => e.Bai)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DataDoc).HasColumnType("image");

                entity.Property(e => e.DateDoc).HasColumnType("datetime");

                entity.Property(e => e.ExtDoc)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.NamDoc).HasMaxLength(100);
            });

            modelBuilder.Entity<CatDocFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cat.DocFile");

                entity.HasIndex(e => new { e.IdDoc, e.IdAs })
                    .HasDatabaseName("IX_Cat.DocFile")
                    .IsUnique();

                entity.Property(e => e.DataMail).HasColumnType("datetime");

                entity.Property(e => e.Doc).HasColumnType("image");

                entity.Property(e => e.EnDoc).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExtDoc).HasMaxLength(6);

                entity.Property(e => e.IdSoglEn).HasDefaultValueSql("(0)");

                entity.Property(e => e.LogMail)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Prim).HasMaxLength(200);
            });

            modelBuilder.Entity<CatEdIzm>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ED_IZM_PK");

                entity.ToTable("CAT.ED_IZM");

                entity.HasIndex(e => e.EdIzm)
                    .HasDatabaseName("ED_IZM_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.EdIzm)
                    .HasColumnName("ED_IZM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");
            });

            modelBuilder.Entity<CatLskRulon>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("LSK_RULON_PK");

                entity.ToTable("CAT.LSK_RULON");

                entity.HasIndex(e => e.Idrul)
                    .HasDatabaseName("LSK_RULON_IX2");

                entity.HasIndex(e => e.Nam)
                    .HasDatabaseName("LSK_RULON_IX3");

                entity.HasIndex(e => new { e.Idrul, e.Nam })
                    .HasDatabaseName("LSK_RULON_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrul).HasColumnName("IDRUL");

                entity.Property(e => e.Koef)
                    .HasColumnName("KOEF")
                    .HasColumnType("decimal(5, 3)");

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatMash>(entity =>
            {
                entity.HasKey(e => e.Idmash);

                entity.ToTable("Cat.Mash");

                entity.HasIndex(e => e.Idob)
                    .HasDatabaseName("IX_Cat.Mash");

                entity.Property(e => e.Idmash)
                    .HasColumnName("IDmash")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bai)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DataIzm).HasColumnType("datetime");

                entity.Property(e => e.Datavv).HasColumnType("datetime");

                entity.Property(e => e.Datavyv).HasColumnType("datetime");

                entity.Property(e => e.Idizgot).HasColumnName("IDIzgot");

                entity.Property(e => e.Idob).HasColumnName("IDob");

                entity.Property(e => e.Nam)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Prim).HasMaxLength(150);

                entity.Property(e => e.ZavNom)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatMashObj>(entity =>
            {
                entity.HasKey(e => e.Idobj);

                entity.ToTable("Cat.MashObj");

                entity.Property(e => e.Idobj)
                    .HasColumnName("IDObj")
                    .ValueGeneratedNever();

                entity.Property(e => e.Datavv).HasColumnType("datetime");

                entity.Property(e => e.Datavyv).HasColumnType("datetime");

                entity.Property(e => e.Ideq).HasColumnName("IDEq");

                entity.Property(e => e.Idizgot).HasColumnName("IDIzgot");

                entity.Property(e => e.IdmainIzgot).HasColumnName("IDMainIzgot");

                entity.Property(e => e.Nam)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<CatSetup>(entity =>
            {
                entity.ToTable("Cat.Setup");

                entity.Property(e => e.Nam).IsRequired();
            });

            modelBuilder.Entity<CatValue>(entity =>
            {
                entity.ToTable("Cat.Value");

                entity.HasIndex(e => new { e.IdCat, e.Value })
                    .HasDatabaseName("IX_Cat.Value_Column_1");

                entity.Property(e => e.Nam).IsRequired();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CatalogueBulgary>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Article)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdmeasureUnit).HasColumnName("IDMeasureUnit");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type).HasComment("1 - материалы; 2 - комплектующие; 3 - нормали; 4 - упаковка");
            });

            modelBuilder.Entity<CatalogueMatchRussiaBulgary>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArticleAjur)
                    .IsRequired()
                    .HasColumnName("ArticleAJUR")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Артикул товара в базе данных программы AJUR");

                entity.Property(e => e.IdgoodRus)
                    .HasColumnName("IDGoodRus")
                    .HasComment("DATA.dbo.[Номенклатура товаров поставки].[ID товара]");
            });

            modelBuilder.Entity<CatalogueResourses>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InDailyReport).HasComment("Вывод в ежедневный отчет о сдаче продукции");

                entity.Property(e => e.ResourseName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CataloguesGroups>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatalogueType).HasComment("1 - оборудование; 2 - инструмент; 3 - материалы");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Idparent).HasColumnName("IDParent");
            });

            modelBuilder.Entity<ConfDbfCdx>(entity =>
            {
                entity.HasKey(e => new { e.DbfName, e.CdxName })
                    .HasName("PK_Con.DbfCdx");

                entity.ToTable("Conf.DbfCdx");

                entity.Property(e => e.DbfName).HasMaxLength(50);

                entity.Property(e => e.CdxName).HasMaxLength(50);

                entity.Property(e => e.CdxSort)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.CdxTyp)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.CdxVal)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ConfDbfSql>(entity =>
            {
                entity.HasKey(e => e.DbfName)
                    .HasName("PK_Con.DbfSQL");

                entity.ToTable("Conf.DbfSQL");

                entity.HasIndex(e => e.Sqlname)
                    .HasDatabaseName("IX_Con.DbfSQL")
                    .IsUnique();

                entity.Property(e => e.DbfName).HasMaxLength(50);

                entity.Property(e => e.CommonTable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DataChange).HasColumnType("datetime");

                entity.Property(e => e.IdIzgotName).HasMaxLength(50);

                entity.Property(e => e.IdName).HasMaxLength(50);

                entity.Property(e => e.MainIndex)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Sqlname)
                    .IsRequired()
                    .HasColumnName("SQLName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConfDbfsql1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Conf_Dbfsql");

                entity.Property(e => e.DataChange).HasColumnType("datetime");

                entity.Property(e => e.DbfName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdIzgotName).HasMaxLength(50);

                entity.Property(e => e.IdName).HasMaxLength(50);

                entity.Property(e => e.MainIndex)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Sqlname)
                    .IsRequired()
                    .HasColumnName("SQLName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConfDisableMenuAsup>(entity =>
            {
                entity.HasKey(e => new { e.Idizgot, e.FormName, e.Action });

                entity.ToTable("Conf.Disable_Menu_ASUP");

                entity.Property(e => e.Idizgot)
                    .HasColumnName("IDIZGOT")
                    .HasDefaultValueSql("((39))");

                entity.Property(e => e.FormName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Action)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Off).HasColumnName("off");

                entity.Property(e => e.RecId)
                    .HasColumnName("RecID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ConfFiles>(entity =>
            {
                entity.ToTable("Conf.Files");

                entity.HasIndex(e => e.NamFile)
                    .HasDatabaseName("IX_Conf.Files_Column")
                    .IsUnique();

                entity.Property(e => e.DocBin)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Ext)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.NamFile)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConfFormState>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("FormState_PK");

                entity.ToTable("Conf.FormState");

                entity.HasComment(@"Состояние форм для каждого расчетного периода или даты
Применение: WebARKAsup
Автор: Сергеев А.В.");

                entity.HasIndex(e => new { e.FormState, e.Bai, e.IdIzgot, e.Period, e.Range, e.FormName })
                    .HasDatabaseName("FormState_UQ")
                    .IsUnique();

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Имя пользователя ASUP");

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasComment("Имя формы или объекта");

                entity.Property(e => e.FormState).HasComment("Состояние формы или объекта на заданную дату (период)");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата/время внесения изменений");

                entity.Property(e => e.Period).HasColumnType("date");

                entity.Property(e => e.Range).HasComment(@"Диапазон периода
0 - месяц
1 - первая половина
2 - вторая половина");
            });

            modelBuilder.Entity<ConfIplist>(entity =>
            {
                entity.HasKey(e => new { e.Ip, e.Mask })
                    .HasName("PK_Con.IPList");

                entity.ToTable("Conf.IPList");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(16);

                entity.Property(e => e.Mask).HasMaxLength(16);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FacroryId).HasColumnName("FacroryID");
            });

            modelBuilder.Entity<ConfIzgot>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Conf.Izgot");

                entity.HasIndex(e => new { e.Flag, e.Nam, e.Path, e.IdIzgot, e.Priznak, e.Logica })
                    .HasDatabaseName("IX_Conf.Izgot");

                entity.Property(e => e.Flag).HasMaxLength(1);

                entity.Property(e => e.IdIzgot).HasDefaultValueSql("((39))");

                entity.Property(e => e.Logica)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nam).HasMaxLength(12);

                entity.Property(e => e.Path).HasMaxLength(60);

                entity.Property(e => e.Priznak)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<ConstrNotices>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idgood).HasColumnName("IDGood");

                entity.Property(e => e.MainNode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stage).HasComment("0 - разработка; 1 - согласование; 2 - техподготовка; 3 - производство");
            });

            modelBuilder.Entity<ConstrSpecifications>(entity =>
            {
                entity.HasIndex(e => e.Deleted)
                    .HasDatabaseName("NonClusteredIndex-20160728-163939");

                entity.HasIndex(e => e.Detail)
                    .HasDatabaseName("NonClusteredIndex-20160728-163850");

                entity.HasIndex(e => e.Node)
                    .HasDatabaseName("NonClusteredIndex-20160728-163841");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("");

                entity.Property(e => e.Deleted).HasComment("ID извещения, которым позиция удалена, или 0, если не удалена");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idnotice).HasColumnName("IDNotice");

                entity.Property(e => e.ItemType).HasComment("1 - деталь; 2 - комплектующий; 3 - нормаль; 4 -  комплектующий AJUR; 5 - нормаль AJUR");

                entity.Property(e => e.Node)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CostsForImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CostsForImport", "fortests");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<CoverallsAssignments>(entity =>
            {
                entity.HasKey(e => new { e.NormId, e.ItemId })
                    .HasName("CoverallsAssignments_pk");

                entity.Property(e => e.NormId)
                    .HasColumnName("NormID")
                    .HasComment("ИД норматива");

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("ИД номенклатуры 1С");
            });

            modelBuilder.Entity<CoverallsNorm>(entity =>
            {
                entity.HasComment("Перечень наименований нормативов выдачи спецодежды");

                entity.HasIndex(e => e.Name)
                    .HasDatabaseName("CoverallsNorm_uq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Наименование норматива");
            });

            modelBuilder.Entity<CoverallsPositions>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("CoverallsPositions_pk");

                entity.HasComment("Списка нормативов для должности");

                entity.HasIndex(e => new { e.PositionId, e.NormId1 })
                    .HasDatabaseName("CoverallsPositions_uq")
                    .IsUnique();

                entity.Property(e => e.Count).HasComment("Количество для выдачи");

                entity.Property(e => e.NormId1)
                    .HasColumnName("NormID1")
                    .HasComment("ИД норматива 1 или");

                entity.Property(e => e.NormId2)
                    .HasColumnName("NormID2")
                    .HasComment("ИД норматива 2 или");

                entity.Property(e => e.NormId3)
                    .HasColumnName("NormID3")
                    .HasComment("ИД норматива 3");

                entity.Property(e => e.PositionId)
                    .HasColumnName("PositionID")
                    .HasComment("ИД должности");

                entity.Property(e => e.UsefulPeriod).HasComment("Срок полезного использования в месяцах");
            });

            modelBuilder.Entity<CoverallsWorkflow>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("CoverallsWorkflow_pk");

                entity.HasComment("Движения номенклатуры в эксплуатации");

                entity.HasIndex(e => e.DocId)
                    .HasDatabaseName("CoverallsWorkflow_idx");

                entity.HasIndex(e => new { e.ItemName, e.ItemId })
                    .HasDatabaseName("CoverallsWorkflow_ItemName");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("Дата ввода в эксплуатацию или списания");

                entity.Property(e => e.DocId)
                    .IsRequired()
                    .HasColumnName("DocID")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("ИД документа 1С");

                entity.Property(e => e.DocType).HasComment("Вид движения (1 - «Ввод в эксплуатацию», 2 - «Списание из эксплуатации»)");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasColumnName("ItemID")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasComment("Уникальный идентификатор номенклатуры в 1С");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Наименование номенклатуры");

                entity.Property(e => e.Tab).HasComment("Табельный номер сотрудника");

                entity.Property(e => e.UsefulPeriod).HasComment("Срок использования в месяцах");
            });

            modelBuilder.Entity<DaysSpecialBulgary>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DaySpecial).HasColumnType("date");

                entity.Property(e => e.Unit).HasComment("Код площадки: 39 ЗМК; 44 УЗМК; 42 Болгарский завод");
            });

            modelBuilder.Entity<Det1>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("DET_1_pk");

                entity.ToTable("DET_1");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("Det_1_ByDet");

                entity.HasIndex(e => new { e.Dbenennung, e.AsVyvod, e.Delrecord, e.Det })
                    .HasDatabaseName("DET_1_IX1");

                entity.HasIndex(e => new { e.Det, e.Dbenennung, e.Idizgot, e.AsVyvod, e.Delrecord })
                    .HasDatabaseName("DET_1_DetailListByIzgot");

                entity.HasIndex(e => new { e.Dbenennung, e.Price, e.Mat, e.Ob, e.Det, e.AsVyvod, e.Delrecord })
                    .HasDatabaseName("DET_MAIN");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AsCh)
                    .HasColumnName("AS_CH")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DNam)
                    .HasColumnName("D_NAM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DatFirst)
                    .HasColumnName("DAT_FIRST")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatLast)
                    .HasColumnName("DAT_LAST")
                    .HasColumnType("datetime");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDel)
                    .HasColumnName("DATA_DEL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dbenennung)
                    .HasColumnName("DBENENNUNG")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Del).HasColumnName("DEL");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.En).HasColumnName("EN");

                entity.Property(e => e.Flagview)
                    .HasColumnName("FLAGVIEW")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Form)
                    .HasColumnName("FORM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idspec).HasColumnName("IDSpec");

                entity.Property(e => e.KolGib)
                    .HasColumnName("KOL_GIB")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.KolOnePodv)
                    .HasColumnName("KOL_ONE_PODV")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.KolPodv)
                    .HasColumnName("KOL_PODV")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.KolSv)
                    .HasColumnName("KOL_SV")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.KolUp)
                    .HasColumnName("KOL_UP")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.LenSv)
                    .HasColumnName("LEN_SV")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.LenSvZ)
                    .HasColumnName("LEN_SV_Z")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.LitD)
                    .HasColumnName("LIT_D")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Locnum)
                    .HasColumnName("LOCNUM")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.LustZon)
                    .HasColumnName("LUST_ZON")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialAjur)
                    .HasColumnName("MaterialAJUR")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Артикул материала в базе данных программы АЖУР");

                entity.Property(e => e.Me)
                    .HasColumnName("ME")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Net)
                    .HasColumnName("NET")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Ob)
                    .HasColumnName("OB")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(12, 5)");

                entity.Property(e => e.PrjName)
                    .HasColumnName("PRJ_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PullPlanMethod).HasColumnName("PULL_PLAN_METHOD");

                entity.Property(e => e.Rbenennung)
                    .HasColumnName("RBENENNUNG")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SSvZ)
                    .HasColumnName("S_SV_Z")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.Smch)
                    .HasColumnName("SMCH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supermarket).HasColumnName("SUPERMARKET");

                entity.Property(e => e.TimeLine)
                    .HasColumnName("TIME_LINE")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Unit39)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Изготавливается на ЗМК, Москва");

                entity.Property(e => e.Unit44)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Изготавливается на УЗМК, Узловая");

                entity.Property(e => e.Zag).HasColumnName("ZAG");
            });

            modelBuilder.Entity<Det1archive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DET_1Archive");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AsCh)
                    .HasColumnName("AS_CH")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DNam)
                    .HasColumnName("D_NAM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DatFirst)
                    .HasColumnName("DAT_FIRST")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatLast)
                    .HasColumnName("DAT_LAST")
                    .HasColumnType("datetime");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataDel)
                    .HasColumnName("DATA_DEL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dbenennung)
                    .HasColumnName("DBENENNUNG")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Del).HasColumnName("DEL");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.En).HasColumnName("EN");

                entity.Property(e => e.Flagview)
                    .HasColumnName("FLAGVIEW")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Form)
                    .HasColumnName("FORM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Idspec).HasColumnName("IDSpec");

                entity.Property(e => e.KolGib)
                    .HasColumnName("KOL_GIB")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.KolOnePodv)
                    .HasColumnName("KOL_ONE_PODV")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.KolPodv)
                    .HasColumnName("KOL_PODV")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.KolSv)
                    .HasColumnName("KOL_SV")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.KolUp)
                    .HasColumnName("KOL_UP")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.LenSv)
                    .HasColumnName("LEN_SV")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.LenSvZ)
                    .HasColumnName("LEN_SV_Z")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.LitD)
                    .HasColumnName("LIT_D")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Locnum)
                    .HasColumnName("LOCNUM")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.LustZon)
                    .HasColumnName("LUST_ZON")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Me)
                    .HasColumnName("ME")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Net)
                    .HasColumnName("NET")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Ob)
                    .HasColumnName("OB")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.PrjName)
                    .HasColumnName("PRJ_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PullPlanMethod).HasColumnName("PULL_PLAN_METHOD");

                entity.Property(e => e.Rbenennung)
                    .HasColumnName("RBENENNUNG")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SSvZ)
                    .HasColumnName("S_SV_Z")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.Smch)
                    .HasColumnName("SMCH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Supermarket).HasColumnName("SUPERMARKET");

                entity.Property(e => e.TimeLine)
                    .HasColumnName("TIME_LINE")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Zag).HasColumnName("ZAG");
            });

            modelBuilder.Entity<DetailOperationsLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOperation).HasColumnType("datetime");

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idspec).HasColumnName("IDSpec");

                entity.Property(e => e.ParameterValueIs)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterValueWas)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");
            });

            modelBuilder.Entity<DlaZakaczki>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("dla_zakaczki");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KodSb)
                    .HasColumnName("KOD_SB")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.KodSt)
                    .HasColumnName("KOD_ST")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.KolZb)
                    .HasColumnName("KOL_ZB")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NamDoc)
                    .HasColumnName("NAM_DOC")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PosSb)
                    .HasColumnName("POS_SB")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Rec)
                    .HasColumnName("REC")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Uzel)
                    .HasColumnName("UZEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DokDet>(entity =>
            {
                entity.ToTable("Dok.Det");

                entity.HasIndex(e => new { e.Det, e.NamDoc })
                    .HasDatabaseName("IX_Dok.Det");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.DataFile).HasColumnType("image");

                entity.Property(e => e.DateChange).HasColumnType("datetime");

                entity.Property(e => e.Det).HasMaxLength(50);

                entity.Property(e => e.ExtFile).HasMaxLength(6);

                entity.Property(e => e.NamDoc).HasMaxLength(60);
            });

            modelBuilder.Entity<DraftListDetails>(entity =>
            {
                entity.ToTable("Draft_List_Details");

                entity.HasIndex(e => new { e.HeaderId, e.Articul, e.DopCod })
                    .HasDatabaseName("IX_Draft_List_Details")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DopCod)
                    .IsRequired()
                    .HasColumnName("Dop_Cod")
                    .HasMaxLength(10);

                entity.Property(e => e.HeaderId).HasColumnName("HeaderID");

                entity.Property(e => e.OstCount).HasColumnName("Ost_Count");

                entity.Property(e => e.PlanCount).HasColumnName("Plan_Count");

                entity.HasOne(d => d.Header)
                    .WithMany(p => p.DraftListDetails)
                    .HasForeignKey(d => d.HeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Draft_List_Details_Draft_List_Header");
            });

            modelBuilder.Entity<DraftListHeader>(entity =>
            {
                entity.ToTable("Draft_List_Header");

                entity.HasIndex(e => new { e.Date, e.Cell, e.Smena, e.FactoryId })
                    .HasDatabaseName("IX_Draft_List_Header")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cell)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DraftListZoneList>(entity =>
            {
                entity.ToTable("Draft_List_ZoneList");

                entity.HasIndex(e => new { e.FactoryId, e.Zone })
                    .HasDatabaseName("IX_Draft_List_ZoneList")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Zone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EanТо>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EAN_ТО");

                entity.Property(e => e.ArticulTo)
                    .IsRequired()
                    .HasColumnName("ARTICUL_TO")
                    .HasMaxLength(50);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasColumnType("decimal(13, 0)");
            });

            modelBuilder.Entity<EconomInitialCalculationComponentCatalog>(entity =>
            {
                entity.ToTable("Econom.InitialCalculationComponentCatalog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemType).HasComment("1 - материал; 2 - комплектующий; 3 - станд. изделие; 4 - упаковка");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<EconomInitialCalculationItems>(entity =>
            {
                entity.ToTable("Econom.InitialCalculationItems");

                entity.HasIndex(e => e.Idarticle)
                    .HasDatabaseName("IDArticle");

                entity.HasIndex(e => e.Iditem)
                    .HasDatabaseName("IDItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idarticle)
                    .HasColumnName("IDArticle")
                    .HasComment("Data.dbo.[Номенклатура товаров].[ID товара]");

                entity.Property(e => e.Idclient).HasColumnName("IDClient");

                entity.Property(e => e.Idcompany).HasColumnName("IDCompany");

                entity.Property(e => e.Iditem)
                    .HasColumnName("IDItem")
                    .HasComment("Data.dbo.[Номенклатура товаров поставки].[ID товара]");

                entity.Property(e => e.IdpriceList).HasColumnName("IDPriceList");

                entity.Property(e => e.ItemType).HasComment("1 - материал; 2 - комплектующий; 3 - станд. изделие; 4 - упаковка");

                entity.Property(e => e.Price).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.Property(e => e.SetType).HasComment("0 - основной расчет; 1 - расчет упаковки");

                entity.Property(e => e.Weight).HasColumnType("decimal(12, 5)");

                entity.Property(e => e.WeightPrevious).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<EconomInitialCalculationOwnItems>(entity =>
            {
                entity.ToTable("Econom.InitialCalculationOwnItems");

                entity.HasIndex(e => e.Idarticle)
                    .HasDatabaseName("IDArticle");

                entity.HasIndex(e => e.Iditem)
                    .HasDatabaseName("IDItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idarticle).HasColumnName("IDArticle");

                entity.Property(e => e.Iditem).HasColumnName("IDItem");

                entity.Property(e => e.Weight).HasColumnType("decimal(12, 5)");

                entity.Property(e => e.WeightPrevious).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<EconomInitialCalculationProduction>(entity =>
            {
                entity.ToTable("Econom.InitialCalculationProduction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LabourCoefficient).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasComment("Доп. информация об изделии");

                entity.Property(e => e.PaintExpense).HasComment("расход краски в граммах");

                entity.Property(e => e.PaintPrice)
                    .HasColumnType("money")
                    .HasComment("цена краски");

                entity.Property(e => e.PaintPrice2).HasColumnType("money");

                entity.Property(e => e.PaintedSpace)
                    .HasColumnType("decimal(10, 2)")
                    .HasComment("площадь окрашиваемой поверхности");

                entity.Property(e => e.PaintedSpace2).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WrapsPrice)
                    .HasColumnType("money")
                    .HasComment("цена упаковки");
            });

            modelBuilder.Entity<EduCat>(entity =>
            {
                entity.HasKey(e => e.Articul);

                entity.ToTable("Edu.Cat");

                entity.Property(e => e.Articul)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Ext)
                    .HasColumnName("ext")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Pic).HasColumnType("image");
            });

            modelBuilder.Entity<EduGame1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Edu.Game1");

                entity.HasIndex(e => new { e.IdTr, e.Comp, e.Smena, e.Nam })
                    .HasDatabaseName("IX_Edu.Game1")
                    .IsUnique();

                entity.Property(e => e.DateSave).HasColumnType("datetime");

                entity.Property(e => e.Nam)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Price).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.Smena).HasDefaultValueSql("((1))");

                entity.Property(e => e.Summ).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<EduGame2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Edu.Game2");

                entity.HasIndex(e => new { e.IdTr, e.Comp, e.Smena, e.Articul })
                    .HasDatabaseName("IX_Edu.Game2")
                    .IsUnique();

                entity.Property(e => e.Articul)
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EduGame3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Edu.Game3");

                entity.HasIndex(e => new { e.Articul, e.ArtKom })
                    .HasDatabaseName("IX_Edu.Game3")
                    .IsUnique();

                entity.Property(e => e.ArtKom)
                    .IsRequired()
                    .HasColumnName("Art_kom")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EduGame4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Edu.Game4");

                entity.HasIndex(e => new { e.Articul, e.ArtKom, e.Operaciya })
                    .HasDatabaseName("IX_Edu.Game4")
                    .IsUnique();

                entity.Property(e => e.ArtKom)
                    .IsRequired()
                    .HasColumnName("Art_kom")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Operaciya)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EduGame5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Edu.Game5");

                entity.HasIndex(e => new { e.IdTr, e.Comp, e.Cikl, e.ArtKom })
                    .HasDatabaseName("IX_Edu.Game5")
                    .IsUnique();

                entity.Property(e => e.ArtKom)
                    .IsRequired()
                    .HasColumnName("Art_kom")
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EduGame6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Edu.Game6");

                entity.HasIndex(e => new { e.IdTr, e.Comp, e.Cikl, e.Operaciya, e.ArtKom })
                    .HasDatabaseName("IX_Edu.Game6")
                    .IsUnique();

                entity.Property(e => e.ArtKom)
                    .IsRequired()
                    .HasColumnName("Art_kom")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Operaciya)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EduPrez>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Edu.Prez");

                entity.HasIndex(e => new { e.IdTr, e.Pos })
                    .HasDatabaseName("IX_Edu.Prez")
                    .IsUnique();

                entity.Property(e => e.Ext)
                    .HasColumnName("ext")
                    .HasMaxLength(6);

                entity.Property(e => e.Slaide).HasColumnType("image");
            });

            modelBuilder.Entity<EduRole>(entity =>
            {
                entity.HasKey(e => new { e.IdTr, e.Hid });

                entity.ToTable("Edu.Role");

                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("IX_Edu.Role");

                entity.Property(e => e.Ball).HasDefaultValueSql("((5))");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Role1).HasMaxLength(30);

                entity.Property(e => e.Role2).HasMaxLength(30);
            });

            modelBuilder.Entity<EduSkl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Edu.Skl");

                entity.HasIndex(e => e.Articul)
                    .HasDatabaseName("IX_Edu.Skl")
                    .IsUnique();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EkTrud>(entity =>
            {
                entity.ToTable("EK.TRUD");

                entity.HasIndex(e => new { e.Articul, e.KodIzgot })
                    .HasDatabaseName("IX_EK.TRUD_Column")
                    .IsUnique();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasColumnName("Kod_Izgot")
                    .HasMaxLength(4);

                entity.Property(e => e.Tim).HasColumnType("numeric(8, 5)");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("Equipment_uq_Equipment");

                entity.HasIndex(e => e.InvNumber)
                    .HasDatabaseName("Equipment_uq_inv")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdIzgot, e.KodIzgot })
                    .HasDatabaseName("Equipment_ByStruc");

                entity.Property(e => e.IdRec).HasComment("ИД записи");

                entity.Property(e => e.AccNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Инвентарный номер по данным бухгалтерии");

                entity.Property(e => e.EndActNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Номер документа о списании");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasComment("Дата списания");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Группа оборудования");

                entity.Property(e => e.HasCounter)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("Имеет ли оборудование счетчик");

                entity.Property(e => e.IdIzgot)
                    .HasDefaultValueSql("((39))")
                    .HasComment("ИД завода, где установлено оборудование");

                entity.Property(e => e.InUse)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("В эксплуатации");

                entity.Property(e => e.InvNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Инвентарный номер");

                entity.Property(e => e.KodIzgot)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("Код затратной зоны, где установлено оборудование");

                entity.Property(e => e.Lifetime).HasComment("Срок эксплуатации (мес.)");

                entity.Property(e => e.ModelId)
                    .HasColumnName("ModelID")
                    .HasComment("ИД модели оборудования");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasComment("Наименование");

                entity.Property(e => e.Placement)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Расположение");

                entity.Property(e => e.ProductionNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Заводской номер");

                entity.Property(e => e.PurchaseCost).HasComment("Цена покупки");

                entity.Property(e => e.ServiceByCounter).HasComment("Проводить ТО по счетчику");

                entity.Property(e => e.StartActNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Номер акта ввода в эксплуатацию");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasComment("Дата ввода в эксплуатацию");

                entity.Property(e => e.To2)
                    .HasColumnName("TO2")
                    .HasComment("Время выполнения ТО2");

                entity.Property(e => e.To2counter)
                    .HasColumnName("TO2Counter")
                    .HasComment("ТО2 по счетчику");

                entity.Property(e => e.To3)
                    .HasColumnName("TO3")
                    .HasComment("Время выполнения ТО3 (мин)");

                entity.Property(e => e.To3counter).HasColumnName("TO3Counter");

                entity.Property(e => e.To4)
                    .HasColumnName("TO4")
                    .HasComment("Время выполнения ТО4");

                entity.Property(e => e.To4counter).HasColumnName("TO4Counter");

                entity.Property(e => e.UseServicePlan)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("Вести учет ППР");
            });

            modelBuilder.Entity<EquipmentConsumables>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("PK__Equipmen__2A4A4C144E35DEED");

                entity.HasComment("Расходники на ТО по оборудованию");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Вид события (ТО2, ТО3, ТО4)");

                entity.Property(e => e.GoodId)
                    .HasColumnName("GoodID")
                    .HasComment("ID товара из \"Номеклатура товаров поставки\"");

                entity.Property(e => e.InvNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Инвентарный номер");

                entity.Property(e => e.Quantity).HasComment("Количество");

                entity.Property(e => e.UnitCode)
                    .HasDefaultValueSql("((796))")
                    .HasComment("Код ед. изм.");
            });

            modelBuilder.Entity<EquipmentEvents>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("EquipmentEvents_pk_EquipmentEvents");

                entity.HasIndex(e => e.InvNumber)
                    .HasDatabaseName("EquipmentEvents_idx");

                entity.HasIndex(e => new { e.InvNumber, e.DateStart })
                    .HasDatabaseName("EquipmentEvents_idx2");

                entity.Property(e => e.Counter).HasComment("Счетчик оборудования");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("datetime")
                    .HasComment("Дата окончания события");

                entity.Property(e => e.DateStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата начала события");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasComment("Описание проблемы/поломки/события");

                entity.Property(e => e.Engeneer)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Наладчик (инженер)");

                entity.Property(e => e.InvNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Solution)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Принятые меры, решение проблемы");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WorkType).HasMaxLength(20);
            });

            modelBuilder.Entity<EquipmentInformTable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdIzgot)
                    .HasDefaultValueSql("((39))")
                    .HasComment("Код завода");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Код затратной зоны");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Наименование рассылки");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Телефон или телефоны через \";\"");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Все')")
                    .HasComment("Наименование причины поломки");
            });

            modelBuilder.Entity<EquipmentModels>(entity =>
            {
                entity.HasComment("Справочник моделей оборудования");

                entity.HasIndex(e => e.Name)
                    .HasDatabaseName("EquipmentModels_uq")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Ид модели");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Наименование модели");
            });

            modelBuilder.Entity<EquipmentServiceList>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasComment("Описание действий");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("ИД события (ТО1, ТО2, ТО3, ТО4 и т.д.)");

                entity.Property(e => e.ModelId)
                    .HasColumnName("ModelID")
                    .HasComment("ИД модели оборудования");
            });

            modelBuilder.Entity<EquipmentServicePlan>(entity =>
            {
                entity.HasKey(e => new { e.InvNumber, e.Date })
                    .HasName("EquipmentServicePlan_pk_EquipmentServicePlan");

                entity.HasComment("ППР оборудования");

                entity.Property(e => e.InvNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Инвентарный номер");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("Дата проведения события");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Событие");
            });

            modelBuilder.Entity<ExperimentalStates>(entity =>
            {
                entity.HasComment("Статьи затрат (разрез экспериментальных работ)");

                entity.HasIndex(e => e.Name)
                    .HasDatabaseName("UQ_ExperimentalStatesNames")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasComment("Описание");

                entity.Property(e => e.IsHidden).HasComment("Скрывать этот вид работ в редакторе");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Наименование работ");

                entity.Property(e => e.PeriodEnd)
                    .HasColumnType("date")
                    .HasComment("Дата окончания");

                entity.Property(e => e.PeriodStart)
                    .HasColumnType("date")
                    .HasComment("Дата начала");
            });

            modelBuilder.Entity<Functionality>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_dbo.TECH.Functionality");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Idsegment).HasColumnName("IDSegment");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Segment)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoodFile>(entity =>
            {
                entity.HasKey(e => e.IdPrj);

                entity.ToTable("Good.File");

                entity.Property(e => e.IdPrj).ValueGeneratedNever();

                entity.Property(e => e.DataBil).HasColumnType("datetime");

                entity.Property(e => e.DataGsu)
                    .HasColumnName("DataGSU")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataImpGsu)
                    .HasColumnName("DataImpGSU")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataKp)
                    .HasColumnName("DataKP")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataZak).HasColumnType("datetime");

                entity.Property(e => e.ExpPicGsu)
                    .HasColumnName("ExpPicGSU")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.FileBil).HasColumnType("image");

                entity.Property(e => e.FileGsu)
                    .HasColumnName("FileGSU")
                    .HasColumnType("image");

                entity.Property(e => e.FileImpGsu)
                    .HasColumnName("FileImpGSU")
                    .HasColumnType("image");

                entity.Property(e => e.FileKp)
                    .HasColumnName("FileKP")
                    .HasColumnType("image");

                entity.Property(e => e.FileZak).HasColumnType("image");

                entity.Property(e => e.PicGsu)
                    .HasColumnName("PicGSU")
                    .HasColumnType("image");

                entity.Property(e => e.StatusBil).HasDefaultValueSql("(0)");

                entity.Property(e => e.StatusGsu)
                    .HasColumnName("StatusGSU")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StatusImpGsu)
                    .HasColumnName("StatusImpGSU")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StatusKp)
                    .HasColumnName("StatusKP")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StatusZak).HasDefaultValueSql("(0)");

                entity.Property(e => e.UserBil).HasDefaultValueSql("(0)");

                entity.Property(e => e.UserGsu)
                    .HasColumnName("UserGSU")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UserImpGsu)
                    .HasColumnName("UserImpGSU")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UserKp).HasDefaultValueSql("(0)");

                entity.Property(e => e.UserZak).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<GoodFin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Good.Fin");

                entity.Property(e => e.DataChange).HasColumnType("datetime");

                entity.Property(e => e.IdGood).ValueGeneratedOnAdd();

                entity.Property(e => e.NamGood)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsFixedLength();
            });

            modelBuilder.Entity<GoodList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Good.List");

                entity.HasIndex(e => new { e.IdParent, e.IdVparent, e.IdGood, e.IdVgood })
                    .HasDatabaseName("IX_Good.List")
                    .IsUnique();

                entity.Property(e => e.IdVparent).HasColumnName("IdVParent");

                entity.Property(e => e.Kol).HasDefaultValueSql("(1)");

                entity.Property(e => e.LogCh)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<GoodProp>(entity =>
            {
                entity.HasKey(e => e.IdProp);

                entity.ToTable("Good.Prop");

                entity.HasIndex(e => e.NamProp)
                    .HasDatabaseName("IX_Good.Prop");

                entity.Property(e => e.LogCh).HasDefaultValueSql("(0)");

                entity.Property(e => e.NamProp).HasMaxLength(30);
            });

            modelBuilder.Entity<GoodSpec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Good.Spec");

                entity.HasIndex(e => new { e.IdPrj, e.IdGood, e.IdVgood })
                    .HasDatabaseName("IX_Good.Spec")
                    .IsUnique();

                entity.Property(e => e.IdVgood).HasColumnName("IdVGood");

                entity.Property(e => e.Kol).HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<GraidGroup>(entity =>
            {
                entity.HasKey(e => e.IdGrGroup);

                entity.ToTable("Graid.Group");

                entity.HasIndex(e => e.KrNam)
                    .HasDatabaseName("IX_Graid.Group")
                    .IsUnique();

                entity.Property(e => e.FullNam).HasMaxLength(250);

                entity.Property(e => e.KrNam).HasMaxLength(6);
            });

            modelBuilder.Entity<GraidInd>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Graid.Ind");

                entity.HasIndex(e => new { e.IdProff, e.Hid })
                    .HasDatabaseName("IX_Graid.Ind")
                    .IsUnique();
            });

            modelBuilder.Entity<GraidLim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Graid.Lim");

                entity.HasIndex(e => e.IdGraid)
                    .HasDatabaseName("IX_Graid.Lim");

                entity.Property(e => e.BallF).HasColumnName("Ball_f");

                entity.Property(e => e.BallS).HasColumnName("Ball_s");
            });

            modelBuilder.Entity<GraidPodr>(entity =>
            {
                entity.ToTable("Graid.Podr");

                entity.Property(e => e.TypPodr).HasMaxLength(1);
            });

            modelBuilder.Entity<GraidProff>(entity =>
            {
                entity.HasKey(e => e.IdProff);

                entity.ToTable("Graid.Proff");

                entity.HasIndex(e => new { e.KrNam, e.KodProff })
                    .HasDatabaseName("IX_Graid.Proff")
                    .IsUnique();

                entity.Property(e => e.Ball1).HasColumnName("Ball_1");

                entity.Property(e => e.Ball2).HasColumnName("Ball_2");

                entity.Property(e => e.Ball3).HasColumnName("Ball_3");

                entity.Property(e => e.Ball4).HasColumnName("Ball_4");

                entity.Property(e => e.Ball5).HasColumnName("Ball_5");

                entity.Property(e => e.Ball6).HasColumnName("Ball_6");

                entity.Property(e => e.KodProff).HasMaxLength(3);

                entity.Property(e => e.KrNam).HasMaxLength(6);

                entity.Property(e => e.Obzor).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ProffNam).HasMaxLength(100);

                entity.Property(e => e.ZpMax).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ZpMed).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ZpMin).HasColumnType("numeric(9, 2)");
            });

            modelBuilder.Entity<GraidTab>(entity =>
            {
                entity.HasKey(e => e.IdGr);

                entity.ToTable("Graid.Tab");

                entity.Property(e => e.NamGrKr).HasMaxLength(100);
            });

            modelBuilder.Entity<GraidZp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Graid.Zp");

                entity.HasIndex(e => new { e.IdProff, e.IdIzgot })
                    .HasDatabaseName("IX_Graid.Zp");

                entity.Property(e => e.Obzor).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ZpMax).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ZpMed).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ZpMin).HasColumnType("numeric(9, 2)");
            });

            modelBuilder.Entity<GraidZpHid>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Graid.ZpHid");

                entity.HasIndex(e => new { e.Year, e.Month, e.Hid })
                    .HasDatabaseName("IX_Graid.ZpHid")
                    .IsUnique();

                entity.Property(e => e.Hid).HasColumnName("HID");

                entity.Property(e => e.SummAll).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SummBonus).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SummDol).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SummOff).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SummPer).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdNoff).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdOff).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<HisFrg>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("HIS_FRG_PK");

                entity.ToTable("HIS_FRG");

                entity.HasIndex(e => e.As)
                    .HasDatabaseName("HIS_FRG_IX1");

                entity.HasIndex(e => new { e.Det, e.As })
                    .HasDatabaseName("HIS_FRG_IX2");

                entity.HasIndex(e => new { e.Kem, e.Det })
                    .HasDatabaseName("HIS_FRG_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.As)
                    .HasColumnName("AS")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kem)
                    .HasColumnName("KEM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.MKem)
                    .HasColumnName("M_KEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistHisTech>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("HIS_TECH_PK");

                entity.ToTable("HIST.HIS_TECH");

                entity.HasIndex(e => new { e.Det, e.As })
                    .HasDatabaseName("HIS_TECH_IX1");

                entity.HasIndex(e => new { e.Kem, e.Det })
                    .HasDatabaseName("HIS_TECH_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.As)
                    .HasColumnName("AS")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kem)
                    .HasColumnName("KEM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.MKem)
                    .HasColumnName("M_KEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistKem>(entity =>
            {
                entity.HasKey(e => e.IdHist);

                entity.ToTable("Hist.Kem");

                entity.HasIndex(e => e.Kem)
                    .HasDatabaseName("IX_Hist.Kem");

                entity.HasIndex(e => new { e.IdIzgot, e.DataSt })
                    .HasDatabaseName("IX_Hist.Kem_1");

                entity.HasIndex(e => new { e.IdIzgot, e.Kem })
                    .HasDatabaseName("IX_Hist.Kem_2");

                entity.Property(e => e.DataFin).HasColumnType("datetime");

                entity.Property(e => e.DataSogl).HasColumnType("datetime");

                entity.Property(e => e.DataSt).HasColumnType("datetime");

                entity.Property(e => e.IdKartRaz).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdUtv).HasDefaultValueSql("(0)");

                entity.Property(e => e.Kem)
                    .IsRequired()
                    .HasMaxLength(21);

                entity.Property(e => e.Krug).HasDefaultValueSql("(0)");

                entity.Property(e => e.Osnov).HasMaxLength(100);

                entity.Property(e => e.Post).HasMaxLength(100);

                entity.Property(e => e.Sogl).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ukazanie).HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<HistSoglIzg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Hist.SoglIzg");

                entity.HasIndex(e => new { e.IdKem, e.IdSoglIzgot })
                    .HasDatabaseName("IX_Hist.SoglIzg");

                entity.Property(e => e.DataSogl).HasColumnType("datetime");

                entity.Property(e => e.TypSogl).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<HistSoglUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Hist.SoglUp");

                entity.HasIndex(e => new { e.UpCod, e.IdIzgot })
                    .HasDatabaseName("IX_Hist.SoglUp")
                    .IsUnique();

                entity.Property(e => e.DateMen).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.DateTech).HasColumnType("datetime");

                entity.Property(e => e.GlTech).HasMaxLength(10);

                entity.Property(e => e.IdIzgot).HasDefaultValueSql("((39))");

                entity.Property(e => e.PrMen).HasMaxLength(10);

                entity.Property(e => e.UpCod)
                    .IsRequired()
                    .HasColumnName("Up_cod")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<HistSps>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Hist.Sps");

                entity.HasIndex(e => new { e.IdDet, e.AsSps })
                    .HasDatabaseName("IX_Hist.Sps");

                entity.Property(e => e.DataChange).HasColumnType("datetime");

                entity.Property(e => e.IdBai).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<HistStHist>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ST_HIST_PK");

                entity.ToTable("HIST.ST_HIST");

                entity.HasIndex(e => e.Kem)
                    .HasDatabaseName("ST_HIST_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DatSogl)
                    .HasColumnName("DAT_SOGL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFin)
                    .HasColumnName("DATA_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSt)
                    .HasColumnName("DATA_ST")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.En).HasColumnName("EN");

                entity.Property(e => e.FioSogl)
                    .HasColumnName("FIO_SOGL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Is).HasColumnName("IS");

                entity.Property(e => e.KartR)
                    .HasColumnName("KART_R")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Kem)
                    .HasColumnName("KEM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Krug)
                    .HasColumnName("KRUG")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .HasColumnName("POST")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Red).HasColumnName("RED");

                entity.Property(e => e.Sogl)
                    .HasColumnName("SOGL")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Ukazanie)
                    .HasColumnName("UKAZANIE")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Zadel)
                    .HasColumnName("ZADEL")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HornStart>(entity =>
            {
                entity.HasKey(e => e.IdHron)
                    .HasName("PK__tmp_ms_x__5E28D44B396615E7");

                entity.Property(e => e.DateSave).HasColumnType("datetime");

                entity.Property(e => e.Dolg)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<HrIndKart>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("IND_KART_PK");

                entity.ToTable("HR.IND_KART");

                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("IND_KART_IX2");

                entity.HasIndex(e => e.Propusk)
                    .HasDatabaseName("Propusk");

                entity.HasIndex(e => new { e.Brigada, e.Idizgot })
                    .HasDatabaseName("IND_KART_IX5");

                entity.HasIndex(e => new { e.Idizgot, e.Bai })
                    .HasDatabaseName("ActualUsers");

                entity.HasIndex(e => new { e.TabN, e.Delrecord })
                    .HasDatabaseName("IND_KART_IX1");

                entity.HasIndex(e => new { e.Dateu, e.Idizgot, e.KodIzgot, e.Delrecord })
                    .HasDatabaseName("IND_KART_IX3");

                entity.HasIndex(e => new { e.Idizgot, e.Datep, e.Dateu, e.Delrecord })
                    .HasDatabaseName("IND_KART_IX4");

                entity.HasIndex(e => new { e.KodIzgot, e.Delrecord, e.Idrec, e.Fio })
                    .HasDatabaseName("Unique_FIO_IND_KART")
                    .IsUnique();

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Adress)
                    .HasColumnName("ADRESS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Box)
                    .HasColumnName("BOX")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Brigada)
                    .HasColumnName("BRIGADA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Brigadir)
                    .HasColumnName("BRIGADIR")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Dateb)
                    .HasColumnName("DATEB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datep)
                    .HasColumnName("DATEP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateu)
                    .HasColumnName("DATEU")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.EconomR).HasColumnName("ECONOM_R");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Esn).HasColumnName("ESN");

                entity.Property(e => e.ExcludeInCardPermission).HasColumnName("EXCLUDE_IN_CARD_PERMISSION");

                entity.Property(e => e.Fam)
                    .HasColumnName("FAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.GrafId).HasColumnName("GrafID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idapax).HasColumnName("IDAPAX");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Inn)
                    .HasColumnName("INN")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.KartR)
                    .HasColumnName("KART_R")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Kleimo).HasColumnName("KLEIMO");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Koeff)
                    .HasColumnName("KOEFF")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.KoeffPrem)
                    .HasColumnName("KOEFF_PREM")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Индивидуальная премия %");

                entity.Property(e => e.KoeffSd)
                    .HasColumnName("KOEFF_SD")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.KoeffShipments)
                    .HasColumnName("KOEFF_SHIPMENTS")
                    .HasComment("Коэф. премии от отгрузок завода");

                entity.Property(e => e.KoeffVol)
                    .HasColumnName("KOEFF_VOL")
                    .HasComment("Коэф. премии от выпуска завода за расч. период");

                entity.Property(e => e.Kps)
                    .HasColumnName("KPS")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamShb)
                    .HasColumnName("NAM_SHB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nikname)
                    .HasColumnName("NIKNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oklad)
                    .HasColumnName("OKLAD")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.OldPropusk)
                    .HasColumnName("OLD_PROPUSK")
                    .HasMaxLength(20);

                entity.Property(e => e.OsnR)
                    .HasColumnName("OSN_R")
                    .HasComment("Роль пользователя в блоке \"Оснастка\"");

                entity.Property(e => e.Otch)
                    .HasColumnName("OTCH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaspKem)
                    .HasColumnName("PASP_KEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaspNom)
                    .HasColumnName("PASP_NOM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaspSer)
                    .HasColumnName("PASP_SER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pic)
                    .HasColumnName("PIC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlanR)
                    .HasColumnName("PLAN_R")
                    .HasComment("Роль пользователя в блоке \"Планирование\"");

                entity.Property(e => e.Pol)
                    .HasColumnName("POL")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PrZpn)
                    .HasColumnName("PR_ZPN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Proff)
                    .HasColumnName("PROFF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Propusk)
                    .HasColumnName("PROPUSK")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RazGol)
                    .HasColumnName("RAZ_GOL")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RazOb)
                    .HasColumnName("RAZ_OB")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RazOd)
                    .HasColumnName("RAZ_OD")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.ReduceKoeff)
                    .HasColumnName("REDUCE_KOEFF")
                    .HasColumnType("numeric(5, 3)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Коэфф. корректирования выработки за смену");

                entity.Property(e => e.ReduceNorm)
                    .HasColumnName("REDUCE_NORM")
                    .HasColumnType("numeric(5, 1)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Если задан: корректировать выработку сотрудника при превышении им указанных нормочасов в REDUCE_KOEFF раз");

                entity.Property(e => e.RostOd)
                    .HasColumnName("ROST_OD")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Sdelka).HasColumnName("SDELKA");

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.SmenaOld)
                    .HasColumnName("SMENA_OLD")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.TabN)
                    .HasColumnName("TAB_N")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.TimeSm)
                    .HasColumnName("TIME_SM")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.TpR)
                    .HasColumnName("TP_R")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Typ)
                    .HasColumnName("TYP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Val)
                    .HasColumnName("VAL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Visa)
                    .HasColumnName("VISA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zp)
                    .HasColumnName("ZP")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Zpn)
                    .HasColumnName("ZPN")
                    .HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<HrIndKartTest>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("IND_KART_PK_HR.IND_KART_test");

                entity.ToTable("HR.IND_KART_test");

                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("IND_KART_IX2");

                entity.HasIndex(e => new { e.Delrecord, e.Fio })
                    .HasDatabaseName("ActualPeople");

                entity.HasIndex(e => new { e.Delrecord, e.Propusk })
                    .HasDatabaseName("Propusk");

                entity.HasIndex(e => new { e.Idizgot, e.Bai })
                    .HasDatabaseName("ActualUsers");

                entity.HasIndex(e => new { e.Idizgot, e.Delrecord })
                    .HasDatabaseName("IND_KART_ByIzgot");

                entity.HasIndex(e => new { e.TabN, e.Delrecord })
                    .HasDatabaseName("IND_KART_IX1");

                entity.HasIndex(e => new { e.Idizgot, e.KodIzgot, e.Delrecord })
                    .HasDatabaseName("IND_KART_IX3");

                entity.HasIndex(e => new { e.Idizgot, e.Datep, e.Dateu, e.Delrecord })
                    .HasDatabaseName("IND_KART_IX4");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Adress)
                    .HasColumnName("ADRESS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Box)
                    .HasColumnName("BOX")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Brigada)
                    .HasColumnName("BRIGADA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Brigadir)
                    .HasColumnName("BRIGADIR")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Dateb)
                    .HasColumnName("DATEB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datep)
                    .HasColumnName("DATEP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateu)
                    .HasColumnName("DATEU")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.EconomR).HasColumnName("ECONOM_R");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Esn).HasColumnName("ESN");

                entity.Property(e => e.ExcludeInCardPermission).HasColumnName("EXCLUDE_IN_CARD_PERMISSION");

                entity.Property(e => e.Fam)
                    .HasColumnName("FAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idapax).HasColumnName("IDAPAX");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Inn)
                    .HasColumnName("INN")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.KartR)
                    .HasColumnName("KART_R")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Kleimo).HasColumnName("KLEIMO");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Koeff)
                    .HasColumnName("KOEFF")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.KoeffPrem)
                    .HasColumnName("KOEFF_PREM")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Индивидуальная премия %");

                entity.Property(e => e.KoeffSd)
                    .HasColumnName("KOEFF_SD")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Kps)
                    .HasColumnName("KPS")
                    .HasColumnType("decimal(11, 0)");

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamShb)
                    .HasColumnName("NAM_SHB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nikname)
                    .HasColumnName("NIKNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oklad)
                    .HasColumnName("OKLAD")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.OsnR)
                    .HasColumnName("OSN_R")
                    .HasComment("Роль пользователя в блоке \"Оснастка\"");

                entity.Property(e => e.Otch)
                    .HasColumnName("OTCH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaspKem)
                    .HasColumnName("PASP_KEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaspNom)
                    .HasColumnName("PASP_NOM")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.PaspSer)
                    .HasColumnName("PASP_SER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pic)
                    .HasColumnName("PIC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlanR)
                    .HasColumnName("PLAN_R")
                    .HasComment("Роль пользователя в блоке \"Планирование\"");

                entity.Property(e => e.Pol)
                    .HasColumnName("POL")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PrZpn)
                    .HasColumnName("PR_ZPN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Proff)
                    .HasColumnName("PROFF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Propusk)
                    .HasColumnName("PROPUSK")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RazGol)
                    .HasColumnName("RAZ_GOL")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RazOb)
                    .HasColumnName("RAZ_OB")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RazOd)
                    .HasColumnName("RAZ_OD")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RostOd)
                    .HasColumnName("ROST_OD")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Sdelka).HasColumnName("SDELKA");

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.SmenaOld)
                    .HasColumnName("SMENA_OLD")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.TabN)
                    .HasColumnName("TAB_N")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.TimeSm)
                    .HasColumnName("TIME_SM")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.TpR)
                    .HasColumnName("TP_R")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Typ)
                    .HasColumnName("TYP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Val)
                    .HasColumnName("VAL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Visa)
                    .HasColumnName("VISA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zp)
                    .HasColumnName("ZP")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Zpn)
                    .HasColumnName("ZPN")
                    .HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<HrIndKval>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("IND_KVAL_PK");

                entity.ToTable("HR.IND_KVAL");

                entity.HasIndex(e => new { e.Fam, e.Name, e.Otch, e.KodIzgot })
                    .HasDatabaseName("IND_KVAL_IX1");

                entity.HasIndex(e => new { e.Kval, e.Idizgot, e.KodIzgot, e.Fio, e.Delrecord })
                    .HasDatabaseName("IND_KVAL_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataPr)
                    .HasColumnName("DATA_PR")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fam)
                    .HasColumnName("FAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Kval)
                    .HasColumnName("KVAL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Otch)
                    .HasColumnName("OTCH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrIndTab>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("IND_TAB_PK");

                entity.ToTable("HR.IND_TAB");

                entity.HasIndex(e => e.Fio)
                    .HasDatabaseName("IND_TAB_IX2");

                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("IND_TAB_IX3");

                entity.HasIndex(e => e.TabNom)
                    .HasDatabaseName("IND_TAB_IX6");

                entity.HasIndex(e => new { e.Id, e.Idapax })
                    .HasDatabaseName("IND_TAB_IX4");

                entity.HasIndex(e => new { e.Id, e.Idrec, e.IdrecIndk })
                    .HasDatabaseName("IND_TAB_IX5");

                entity.HasIndex(e => new { e.Fio, e.TabNom, e.TabNoms, e.Id, e.Idapax, e.Idrec, e.IdrecIndk })
                    .HasDatabaseName("IND_TAB_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idapax).HasColumnName("IDAPAX");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.IdrecIndk).HasColumnName("IDREC_INDK");

                entity.Property(e => e.TabNom).HasColumnName("TAB_NOM");

                entity.Property(e => e.TabNoms)
                    .HasColumnName("TAB_NOMS")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrKval>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("KVAL_PK");

                entity.ToTable("HR.KVAL");

                entity.HasIndex(e => new { e.KodIzgot, e.Tarif })
                    .HasDatabaseName("KVAL_IX2");

                entity.HasIndex(e => new { e.Tarif, e.Idizgot, e.KodIzgot, e.Kval, e.Delrecord })
                    .HasDatabaseName("KVAL_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot)
                    .HasColumnName("IDIZGOT")
                    .HasDefaultValueSql("((44))");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Kval)
                    .HasColumnName("KVAL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Log)
                    .HasColumnName("LOG")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tarif)
                    .HasColumnName("TARIF")
                    .HasColumnType("decimal(6, 2)");
            });

            modelBuilder.Entity<HrOtpusk>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("OTPUSK_PK");

                entity.ToTable("HR.OTPUSK");

                entity.HasIndex(e => new { e.Fio, e.DateSt })
                    .HasDatabaseName("OTPUSK_IX2");

                entity.HasIndex(e => new { e.Fam, e.Nam, e.Otch, e.DateSt })
                    .HasDatabaseName("OTPUSK_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.DateFin)
                    .HasColumnName("DATE_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateSt)
                    .HasColumnName("DATE_ST")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fam)
                    .HasColumnName("FAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Flaghrm).HasColumnName("FLAGHRM");

                entity.Property(e => e.Iddoc)
                    .HasColumnName("IDDOC")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KadryId).HasColumnName("KadryID");

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Otch)
                    .HasColumnName("OTCH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Prich)
                    .HasColumnName("PRICH")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<HrOtpuskNew>(entity =>
            {
                entity.ToTable("HR.OtpuskNew");

                entity.HasIndex(e => new { e.EdTab, e.Dbeg })
                    .HasDatabaseName("IX_HR.OtpuskNew_Column")
                    .IsUnique();

                entity.Property(e => e.Dbeg)
                    .HasColumnName("DBeg")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dend)
                    .HasColumnName("DEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.Kol).HasDefaultValueSql("((1))");

                entity.Property(e => e.Prich).HasMaxLength(50);
            });

            modelBuilder.Entity<HrPrFio>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PR_FIO_PK");

                entity.ToTable("HR.PR_FIO");

                entity.HasIndex(e => new { e.DataPr, e.Summa, e.Typ, e.Prikaz, e.Fio, e.Delrecord })
                    .HasDatabaseName("PR_FIO_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.DataFin)
                    .HasColumnName("DATA_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataIsp)
                    .HasColumnName("DATA_ISP")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataPr)
                    .HasColumnName("DATA_PR")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Log)
                    .HasColumnName("LOG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Prikaz)
                    .HasColumnName("PRIKAZ")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Summa)
                    .HasColumnName("SUMMA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Typ)
                    .HasColumnName("TYP")
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrSelection>(entity =>
            {
                entity.ToTable("HR.Selection");

                entity.HasIndex(e => new { e.IdIzgot, e.Status, e.DateOpen })
                    .HasDatabaseName("IX_HR.Selection_Column");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DateClose).HasColumnType("datetime");

                entity.Property(e => e.DateOpen).HasColumnType("datetime");

                entity.Property(e => e.DateReg).HasColumnType("datetime");

                entity.Property(e => e.Dolg).IsRequired();

                entity.Property(e => e.ExcelDoc)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Kol).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HrSmTable>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("SM_TABLE_PK");

                entity.ToTable("HR.SM_TABLE");

                entity.HasIndex(e => new { e.Idrec, e.DocId })
                    .HasDatabaseName("SM_TABLE_DOCID");

                entity.HasIndex(e => new { e.Time, e.Data, e.Fio, e.Delrecord })
                    .HasDatabaseName("SM_TABLE_IX2");

                entity.HasIndex(e => new { e.Fio, e.Time, e.Delrecord, e.Idizgot, e.KodIzgot, e.Data, e.Smena })
                    .HasDatabaseName("SM_TABLE_IX3");

                entity.HasIndex(e => new { e.KodIzgot, e.Time, e.Delrecord, e.TimeN, e.Idizgot, e.Idrec, e.Data, e.Smena, e.Fio })
                    .HasDatabaseName("SM_TABLE_IX1");

                entity.HasIndex(e => new { e.Smena, e.KodIzgot, e.Koeff, e.Prim, e.Time, e.Idizgot, e.Data, e.Fio, e.Delrecord })
                    .HasDatabaseName("SM_TABLE_IX5");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Кто внес изменения");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime")
                    .HasComment("Дата");

                entity.Property(e => e.DataReg)
                    .HasColumnName("DATA_REG")
                    .HasColumnType("datetime")
                    .HasComment("Дата внесения изменений");

                entity.Property(e => e.Dateenter)
                    .HasColumnName("DATEENTER")
                    .HasColumnType("datetime")
                    .HasComment("Дата(время) входа на предприятие - не ведется");

                entity.Property(e => e.Dateexit)
                    .HasColumnName("DATEEXIT")
                    .HasColumnType("datetime")
                    .HasComment("Дата(время) ухода с предприятия - не ведется");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord)
                    .HasColumnName("DELRECORD")
                    .HasComment("Пометка удаления");

                entity.Property(e => e.DocId)
                    .HasColumnName("DocID")
                    .HasComment("ИД документа из таблицы \"Приказы по статусам сотрудников\"");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("ФИО сотрудника согласно HR.IND_KART");

                entity.Property(e => e.Idizgot)
                    .HasColumnName("IDIZGOT")
                    .HasComment("ИД завода");

                entity.Property(e => e.InitiateShortenedTurn)
                    .HasColumnName("Initiate_Shortened_Turn")
                    .HasComment("Начало процедуры оформления сокращенной смены: заявление оформлено, время смены не посчитано");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("Код участка");

                entity.Property(e => e.Koeff)
                    .HasColumnName("KOEFF")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(1)
                    .HasComment("Примечание (Р - работал, Б - больничный и т.д.)");

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(1, 0)")
                    .HasComment("Номер смены (1, 2)");

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasColumnType("decimal(4, 1)")
                    .HasComment("Отработанное время");

                entity.Property(e => e.TimeN)
                    .HasColumnName("TIME_N")
                    .HasColumnType("decimal(4, 1)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("В том числе ночных часов");
            });

            modelBuilder.Entity<HrSmena>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("SMENA__PK");

                entity.ToTable("HR.SMENA");

                entity.HasIndex(e => new { e.Data, e.Smena })
                    .HasDatabaseName("Date_Turn");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Master)
                    .HasColumnName("MASTER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sk)
                    .HasColumnName("SK")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sm)
                    .HasColumnName("SM")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<HrStTabel>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ST_TABEL__PK");

                entity.ToTable("HR.ST_TABEL");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.DataSt)
                    .HasColumnName("DATA_ST")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Period)
                    .HasColumnName("PERIOD")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Tabel)
                    .HasColumnName("TABEL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeF1)
                    .HasColumnName("TIME_F1")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TimeF2)
                    .HasColumnName("TIME_F2")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TimeF3)
                    .HasColumnName("TIME_F3")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TimeS1)
                    .HasColumnName("TIME_S1")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TimeS2)
                    .HasColumnName("TIME_S2")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TimeS3)
                    .HasColumnName("TIME_S3")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrStaj>(entity =>
            {
                entity.HasKey(e => new { e.IdIzgot, e.Year })
                    .HasName("HR.STAJ_idx");

                entity.ToTable("HR.STAJ");

                entity.HasComment(@"Таблица надбавки за стаж

Выбираем все записи по ИД завода, где стаж меньше или равен Year и считаем сумму надавки");

                entity.Property(e => e.IdIzgot).HasComment("ИД завода");

                entity.Property(e => e.Year).HasComment("Год стажа по порядку");

                entity.Property(e => e.Nadbavka)
                    .HasColumnType("numeric(7, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Сумма надбавки");
            });

            modelBuilder.Entity<HrZpYear>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ZP_YEAR_PK");

                entity.ToTable("HR.ZP_YEAR");

                entity.HasIndex(e => new { e.Fio, e.Year, e.Month })
                    .HasDatabaseName("ZP_YEAR_IX1");

                entity.HasIndex(e => new { e.Year, e.Month, e.Fio })
                    .HasDatabaseName("ZP_YEAR_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Aliment)
                    .HasColumnName("ALIMENT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Avans)
                    .HasColumnName("AVANS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Balance)
                    .HasColumnName("BALANCE")
                    .HasColumnType("decimal(14, 2)");

                entity.Property(e => e.Bol)
                    .HasColumnName("BOL")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Esn)
                    .HasColumnName("ESN")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ExpHours)
                    .HasColumnName("EXP_HOURS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ExpSumm)
                    .HasColumnName("EXP_SUMM")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ExtraPayments)
                    .HasColumnName("EXTRA_PAYMENTS")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Колонка \"Различные доплаты\"");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayDays).HasColumnName("HOLIDAY_DAYS");

                entity.Property(e => e.HolidaySumm)
                    .HasColumnName("HOLIDAY_SUMM")
                    .HasColumnType("decimal(10, 2)")
                    .HasComment("Сумма отпускных");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Inov)
                    .HasColumnName("INOV")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Kl)
                    .HasColumnName("KL")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Klass)
                    .HasColumnName("KLASS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.KoeffBol)
                    .HasColumnName("KOEFF_BOL")
                    .HasColumnType("decimal(3, 1)");

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Nal)
                    .HasColumnName("NAL")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ndfl)
                    .HasColumnName("NDFL")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Norma)
                    .HasColumnName("NORMA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Obed)
                    .HasColumnName("OBED")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OffZp)
                    .HasColumnName("OFF_ZP")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PaymentA)
                    .HasColumnName("PAYMENT_A")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Столбец \"Начислено по 1С, итого\"");

                entity.Property(e => e.PaymentB)
                    .HasColumnName("PAYMENT_B")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Столбец \"Больничные листы за счет ФСС\"");

                entity.Property(e => e.PaymentC)
                    .HasColumnName("PAYMENT_C")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Столбец \"Оклад в других наших компаниях\"");

                entity.Property(e => e.Pr1)
                    .HasColumnName("PR1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pr2)
                    .HasColumnName("PR2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Pr3)
                    .HasColumnName("PR3")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Section)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SickListSumm)
                    .HasColumnName("SICK_LIST_SUMM")
                    .HasColumnType("decimal(10, 2)")
                    .HasComment("Сумма больничных");

                entity.Property(e => e.Stag)
                    .HasColumnName("STAG")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TabNumber).HasColumnName("TAB_NUMBER");

                entity.Property(e => e.Tabel)
                    .HasColumnName("TABEL")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.Tarif)
                    .HasColumnName("TARIF")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Zp)
                    .HasColumnName("ZP")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ZpAll)
                    .HasColumnName("ZP_ALL")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ZpAllArchive)
                    .HasColumnName("ZP_ALL_ARCHIVE")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Zpn)
                    .HasColumnName("ZPN")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<HronDayTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Hron.DayTime");

                entity.Property(e => e.Dolg)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Dtime)
                    .HasColumnName("DTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.TypeWork)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<HronSetup>(entity =>
            {
                entity.HasKey(e => e.IdWork)
                    .HasName("PK__tmp_ms_x__2E9FC6D54BEACE99");

                entity.ToTable("Hron.Setup");

                entity.HasIndex(e => new { e.Dolg, e.TypeWork })
                    .HasDatabaseName("IX_Hron.Setup_Column")
                    .IsUnique();

                entity.Property(e => e.Dolg)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TypeWork)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<IndKartproc>(entity =>
            {
                entity.HasKey(e => e.Idrec);

                entity.ToTable("IND_KARTPROC");

                entity.HasIndex(e => e.Fio)
                    .HasDatabaseName("IND_KARTPROC_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Koeff)
                    .HasColumnName("KOEFF")
                    .HasColumnType("decimal(3, 0)");
            });

            modelBuilder.Entity<KachKartDef>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("KART_DEF_PK");

                entity.ToTable("KACH.KART_DEF");

                entity.HasIndex(e => new { e.NomKartPrv, e.Fio })
                    .HasDatabaseName("KART_DEF_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IdPerson)
                    .HasColumnName("ID_Person")
                    .HasComment("ID_Person");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.NomKart)
                    .HasColumnName("NOM_KART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomKartPrv)
                    .HasColumnName("NOM_KART_Prv")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KachKartDefCatalogue>(entity =>
            {
                entity.ToTable("KACH.KART_DEF_CATALOGUE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 сейфы, 2 мебель, 3 двери");
            });

            modelBuilder.Entity<KachKartDet>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("KART_DET_PK");

                entity.ToTable("KACH.KART_DET");

                entity.HasIndex(e => new { e.NomKartPrv, e.Det, e.NppOper })
                    .HasDatabaseName("KART_DET_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NomKart)
                    .HasColumnName("NOM_KART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomKartPrv)
                    .HasColumnName("NOM_KART_Prv")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.ProductionNumber)
                    .HasColumnName("PRODUCTION_NUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("шифр изделия - для каждой детали в карточке");

                entity.Property(e => e.RProd)
                    .HasColumnName("R_PROD")
                    .HasColumnType("decimal(1, 0)")
                    .HasComment("Решение по несоответствующей продукции - свое для каждой детали в карточке");
            });

            modelBuilder.Entity<KachKartFiles>(entity =>
            {
                entity.ToTable("KACH.KART_FILES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocumentFile)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.FileDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idcard).HasColumnName("IDCard");
            });

            modelBuilder.Entity<KachKartMat>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("KART_MAT_PK");

                entity.ToTable("KACH.KART_MAT");

                entity.HasIndex(e => e.DetailListId)
                    .HasDatabaseName("DETAIL_LIST_ID");

                entity.HasIndex(e => e.NomKart)
                    .HasDatabaseName("Nom_Kart");

                entity.HasIndex(e => e.NomKartPrv)
                    .HasDatabaseName("KART_MAT_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DetailListId)
                    .HasColumnName("DETAIL_LIST_ID")
                    .HasComment("KART_DET.IDREC - если расчет отдельно по деталям в карточке; 0 - если по всей карточке (по всем деталям карточки)");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KolMat)
                    .HasColumnName("KOL_MAT")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomKart)
                    .HasColumnName("NOM_KART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomKartPrv)
                    .HasColumnName("NOM_KART_Prv")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PriceMat)
                    .HasColumnName("PRICE_MAT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceTim)
                    .HasColumnName("PRICE_TIM")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(10, 5)");
            });

            modelBuilder.Entity<KachKartOperCatalogue>(entity =>
            {
                entity.ToTable("KACH.KART_OPER_CATALOGUE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KachKartOtv>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("KART_OTV_PK");

                entity.ToTable("KACH.KART_OTV");

                entity.HasIndex(e => e.Fio)
                    .HasDatabaseName("FIO");

                entity.HasIndex(e => e.IdPerson)
                    .HasDatabaseName("IDPerson");

                entity.HasIndex(e => new { e.DataSt, e.DataFin, e.Delrecord })
                    .HasDatabaseName("Dates");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFin)
                    .HasColumnName("DATA_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSt)
                    .HasColumnName("DATA_ST")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IdPerson)
                    .HasColumnName("ID_Person")
                    .HasComment("[HR.Ind_Kart].IDREC");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.NomKart)
                    .HasColumnName("NOM_KART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomKartPrv)
                    .HasColumnName("NOM_KART_Prv")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KachKartOtv1>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("KART_OTV1_PK");

                entity.ToTable("KACH.KART_OTV1");

                entity.HasIndex(e => e.Fio)
                    .HasDatabaseName("FIO");

                entity.HasIndex(e => e.IdPerson)
                    .HasDatabaseName("IDPerson");

                entity.HasIndex(e => new { e.DataSt, e.DataFin, e.NomKartPrv })
                    .HasDatabaseName("Dates");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFin)
                    .HasColumnName("DATA_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSt)
                    .HasColumnName("DATA_ST")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IdPerson)
                    .HasColumnName("ID_Person")
                    .HasComment("[HR.Ind_Kart].IDREC");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kem)
                    .HasColumnName("KEM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.NomKart)
                    .HasColumnName("NOM_KART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomKartPrv)
                    .HasColumnName("NOM_KART_Prv")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KachKartR>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("KART_R_PK");

                entity.ToTable("KACH.KART_R");

                entity.HasIndex(e => e.NomKart)
                    .HasDatabaseName("Nom_Kart");

                entity.HasIndex(e => e.NomKartPrv)
                    .HasDatabaseName("KART_R_IX2");

                entity.HasIndex(e => new { e.DataDef, e.SmDef })
                    .HasDatabaseName("KART_R_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.BaiPror)
                    .HasColumnName("BAI_PROR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaiRas)
                    .HasColumnName("BAI_RAS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaiRazr)
                    .HasColumnName("BAI_RAZR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaiUtv)
                    .HasColumnName("BAI_UTV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaiVyp)
                    .HasColumnName("BAI_VYP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DataDef)
                    .HasColumnName("DATA_DEF")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("DATE_CREATION")
                    .HasColumnType("date");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Estimation)
                    .HasColumnName("ESTIMATION")
                    .HasComment("Оценка результата корректирующих действий, проставляется инженером Службы качества");

                entity.Property(e => e.FaultPaintSection).HasColumnName("FAULT_PAINT_SECTION");

                entity.Property(e => e.IdDefect).HasColumnName("ID_DEFECT");

                entity.Property(e => e.IdOperationFact).HasColumnName("ID_OPERATION_FACT");

                entity.Property(e => e.IdOperationFind).HasColumnName("ID_OPERATION_FIND");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodDef)
                    .HasColumnName("KOD_DEF")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.KodDet)
                    .HasColumnName("KOD_DET")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.KontrZ).HasColumnName("KONTR_Z");

                entity.Property(e => e.MemDet)
                    .HasColumnName("MEM_DET")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MemDoc)
                    .HasColumnName("MEM_DOC")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MemPrich)
                    .HasColumnName("MEM_PRICH")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MemProd)
                    .HasColumnName("MEM_PROD")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomKart)
                    .HasColumnName("NOM_KART")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Номер карточки-разрешения");

                entity.Property(e => e.NomKartPrv)
                    .HasColumnName("NOM_KART_Prv")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasComment("Предыдущий номер карточки-разрешения");

                entity.Property(e => e.Prich).HasColumnName("PRICH");

                entity.Property(e => e.Priznak)
                    .HasColumnName("PRIZNAK")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.ProductionNumber)
                    .HasColumnName("PRODUCTION_NUMBER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.QserviceRemark)
                    .HasColumnName("QSERVICE_REMARK")
                    .HasComment("Отметка о том, что руководитель Службы качества внес замечания, после чего замечания не вносятся другими");

                entity.Property(e => e.RDoc)
                    .HasColumnName("R_DOC")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.RProd)
                    .HasColumnName("R_PROD")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Ras).HasColumnName("RAS");

                entity.Property(e => e.Recipients)
                    .HasColumnName("RECIPIENTS")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("Список сотрудников, которым отправлено уведомление о создании карточки");

                entity.Property(e => e.SmDef)
                    .HasColumnName("SM_DEF")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Sogl)
                    .HasColumnName("SOGL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Utv)
                    .HasColumnName("UTV")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KachKartReason>(entity =>
            {
                entity.ToTable("KACH.KART_REASON");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idcard).HasColumnName("IDCard");

                entity.Property(e => e.Idreason).HasColumnName("IDReason");
            });

            modelBuilder.Entity<KachKartReasonCatalogue>(entity =>
            {
                entity.ToTable("KACH.KART_REASON_CATALOGUE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KachParProst>(entity =>
            {
                entity.HasKey(e => e.Idrec);

                entity.ToTable("KACH.PAR_PROST");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("NOM")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Prostoy)
                    .IsRequired()
                    .HasColumnName("PROSTOY")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KatEdMat>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ED_MAT_PK");

                entity.ToTable("KAT.ED_MAT");

                entity.HasIndex(e => new { e.EdIzm, e.Koeff, e.Mat, e.Delrecord, e.Idizgot })
                    .HasDatabaseName("ED_MAT_IX2");

                entity.HasIndex(e => new { e.Koeff, e.Mat, e.EdIzm, e.Idizgot, e.Delrecord })
                    .HasDatabaseName("ED_MAT_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.EdIzm)
                    .HasColumnName("ED_IZM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Koeff)
                    .HasColumnName("KOEFF")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KonBzBau>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("BZ_BAU__PK");

                entity.ToTable("KON.BZ_BAU_");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("DET");

                entity.HasIndex(e => e.Uzel)
                    .HasDatabaseName("UZEL");

                entity.HasIndex(e => new { e.Det, e.Uzel })
                    .HasDatabaseName("BZ_BAU__IX2");

                entity.HasIndex(e => new { e.Uzel, e.Det })
                    .HasDatabaseName("BZ_BAU__IX5");

                entity.HasIndex(e => new { e.Uzel, e.PosSb })
                    .HasDatabaseName("BZ_BAU__IX3");

                entity.HasIndex(e => new { e.Uzel, e.Det, e.AsVyvod })
                    .HasDatabaseName("BZ_BAU__IX1");

                entity.HasIndex(e => new { e.Uzel, e.Rec, e.Det })
                    .HasDatabaseName("BZ_BAU__IX4");

                entity.HasIndex(e => new { e.Uzel, e.Lit, e.AsVyvod, e.Delrecord })
                    .HasDatabaseName("Node_Output_NotDeleted");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idspec).HasColumnName("IDSpec");

                entity.Property(e => e.KodSb)
                    .HasColumnName("KOD_SB")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.KodSt)
                    .HasColumnName("KOD_ST")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.KolZb)
                    .HasColumnName("KOL_ZB")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NamDoc)
                    .HasColumnName("NAM_DOC")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PosSb)
                    .HasColumnName("POS_SB")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Rec)
                    .HasColumnName("REC")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Uzel)
                    .HasColumnName("UZEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KonDetKodZ>(entity =>
            {
                entity.ToTable("Kon.Det_kodZ");

                entity.HasIndex(e => new { e.Date, e.Det, e.FactoryId, e.Num })
                    .HasDatabaseName("IX_Kon.Det_kodZ")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CharN)
                    .IsRequired()
                    .HasColumnName("Char_n")
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FactoryId)
                    .HasColumnName("FactoryID")
                    .HasDefaultValueSql("((39))");

                entity.Property(e => e.KeyNumber).HasMaxLength(50);

                entity.Property(e => e.Nakl).HasMaxLength(50);

                entity.Property(e => e.Num).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PerfomerBrand).HasMaxLength(50);
            });

            modelBuilder.Entity<KonDetToDelete>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("PK_Kon.Det");

                entity.ToTable("Kon.Det_To_Delete");

                entity.HasIndex(e => e.SmCh)
                    .HasDatabaseName("IX_Kon.Det_1");

                entity.HasIndex(e => new { e.Det, e.IdAs })
                    .HasDatabaseName("IX_Kon.Det");

                entity.Property(e => e.DataChange).HasColumnType("datetime");

                entity.Property(e => e.Del)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Det).HasMaxLength(20);

                entity.Property(e => e.IdAs).HasDefaultValueSql("(1)");

                entity.Property(e => e.IdIzgot).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdKem).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdMat)
                    .HasColumnName("idMat")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IdSmCh).HasDefaultValueSql("(0)");

                entity.Property(e => e.KolGib).HasDefaultValueSql("(0)");

                entity.Property(e => e.KolSv).HasDefaultValueSql("(0)");

                entity.Property(e => e.LenSv)
                    .HasColumnType("numeric(6, 3)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LenSvZ)
                    .HasColumnType("numeric(6, 3)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nam)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.NamEng).HasMaxLength(40);

                entity.Property(e => e.Net)
                    .HasColumnType("numeric(10, 3)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ob)
                    .HasColumnType("numeric(10, 6)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SmCh).HasMaxLength(20);

                entity.Property(e => e.SsvZ)
                    .HasColumnName("SSvZ")
                    .HasColumnType("numeric(6, 4)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Zag).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<KonDetVes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Kon.DetVes");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("IX_Kon.DetVes")
                    .IsUnique();

                entity.Property(e => e.BaiVes)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DateVes).HasColumnType("datetime");

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Mat)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Ves).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<KonHisSps>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("HIS_SPS_PK");

                entity.ToTable("KON.HIS_SPS");

                entity.HasIndex(e => new { e.Det, e.As })
                    .HasDatabaseName("HIS_SPS_IX1");

                entity.HasIndex(e => new { e.Kem, e.Det })
                    .HasDatabaseName("HIS_SPS_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.As)
                    .HasColumnName("AS")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kem)
                    .HasColumnName("KEM")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.MKem)
                    .HasColumnName("M_KEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KonPassport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Kon.Passport");

                entity.Property(e => e.Det).HasMaxLength(140);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nom).HasMaxLength(10);

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.Type).HasMaxLength(10);
            });

            modelBuilder.Entity<KonPassportDoc>(entity =>
            {
                entity.ToTable("Kon.Passport_doc");

                entity.Property(e => e.Det).HasMaxLength(140);

                entity.Property(e => e.Doc).HasColumnType("image");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(140);
            });

            modelBuilder.Entity<KonPassportTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Kon.Passport_Table");

                entity.Property(e => e.Articul).HasMaxLength(15);

                entity.Property(e => e.Det).HasMaxLength(140);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nom).HasColumnName("nom");

                entity.Property(e => e.TGabKorPrG)
                    .HasColumnName("T_Gab_KorPr_G")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabKorPrSh)
                    .HasColumnName("T_Gab_KorPr_Sh")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabKorPrV)
                    .HasColumnName("T_Gab_KorPr_V")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVhPrG)
                    .HasColumnName("T_Gab_VhPr_G")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVhPrSh)
                    .HasColumnName("T_Gab_VhPr_Sh")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVhPrV)
                    .HasColumnName("T_Gab_VhPr_V")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnG)
                    .HasColumnName("T_Gab_Vn_G")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnSh)
                    .HasColumnName("T_Gab_Vn_Sh")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnV)
                    .HasColumnName("T_Gab_Vn_V")
                    .HasMaxLength(15);

                entity.Property(e => e.TGabVnV2)
                    .HasColumnName("T_Gab_Vn_V2")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnV3)
                    .HasColumnName("T_Gab_Vn_V3")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutDopG)
                    .HasColumnName("T_Gab_Vnut_dop_G")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutDopSh)
                    .HasColumnName("T_Gab_Vnut_dop_Sh")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutDopV)
                    .HasColumnName("T_Gab_Vnut_dop_V")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutG)
                    .HasColumnName("T_Gab_Vnut_G")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutG2)
                    .HasColumnName("T_Gab_Vnut_G2")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutG3)
                    .HasColumnName("T_Gab_Vnut_G3")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutSh)
                    .HasColumnName("T_Gab_Vnut_Sh")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutSh2)
                    .HasColumnName("T_Gab_Vnut_Sh2")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutSh3)
                    .HasColumnName("T_Gab_Vnut_Sh3")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutV)
                    .HasColumnName("T_Gab_Vnut_V")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutV2)
                    .HasColumnName("T_Gab_Vnut_V2")
                    .HasMaxLength(10);

                entity.Property(e => e.TGabVnutV3)
                    .HasColumnName("T_Gab_Vnut_V3")
                    .HasMaxLength(10);

                entity.Property(e => e.TKolBox)
                    .HasColumnName("T_Kol_box")
                    .HasMaxLength(10);

                entity.Property(e => e.TKolBox2)
                    .HasColumnName("T_Kol_box2")
                    .HasMaxLength(10);

                entity.Property(e => e.TKolBox3)
                    .HasColumnName("T_Kol_box3")
                    .HasMaxLength(10);

                entity.Property(e => e.TKolOtdel)
                    .HasColumnName("T_Kol_otdel")
                    .HasMaxLength(10);

                entity.Property(e => e.TKolPapok)
                    .HasColumnName("T_Kol_papok")
                    .HasMaxLength(10);

                entity.Property(e => e.TKolPodfile)
                    .HasColumnName("T_Kol_podfile")
                    .HasMaxLength(10);

                entity.Property(e => e.TKolPol)
                    .HasColumnName("T_Kol_pol")
                    .HasMaxLength(10);

                entity.Property(e => e.TKolRazdPoper)
                    .HasColumnName("T_Kol_razd_poper")
                    .HasMaxLength(10);

                entity.Property(e => e.TKolRazdProd)
                    .HasColumnName("T_Kol_razd_prod")
                    .HasMaxLength(10);

                entity.Property(e => e.TKolZam)
                    .HasColumnName("T_Kol_Zam")
                    .HasMaxLength(10);

                entity.Property(e => e.TModel)
                    .HasColumnName("T_Model")
                    .HasMaxLength(40);

                entity.Property(e => e.TNagrPol)
                    .HasColumnName("T_Nagr_pol")
                    .HasMaxLength(10);

                entity.Property(e => e.TObem)
                    .HasColumnName("T_Obem")
                    .HasMaxLength(10);

                entity.Property(e => e.TObem2)
                    .HasColumnName("T_Obem2")
                    .HasMaxLength(10);

                entity.Property(e => e.TObem3)
                    .HasColumnName("T_Obem3")
                    .HasMaxLength(10);

                entity.Property(e => e.TObemDop)
                    .HasColumnName("T_Obem_dop")
                    .HasMaxLength(10);

                entity.Property(e => e.TOpen)
                    .HasColumnName("T_Open")
                    .HasMaxLength(10);

                entity.Property(e => e.TSeif)
                    .HasColumnName("T_seif")
                    .HasMaxLength(10);

                entity.Property(e => e.TSeif2)
                    .HasColumnName("T_seif2")
                    .HasMaxLength(10);

                entity.Property(e => e.TVnutDop)
                    .HasColumnName("T_Vnut_dop")
                    .HasMaxLength(10);

                entity.Property(e => e.TWes)
                    .HasColumnName("T_Wes")
                    .HasMaxLength(20);

                entity.Property(e => e.TWes2)
                    .HasColumnName("T_Wes2")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<KonPassportTableSign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Kon.Passport_Table_Sign");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TableColumn).HasMaxLength(300);

                entity.Property(e => e.TableType).HasMaxLength(254);
            });

            modelBuilder.Entity<KonSmCh>(entity =>
            {
                entity.HasKey(e => e.IdSmCh);

                entity.ToTable("Kon.SmCh");

                entity.Property(e => e.DateChange).HasColumnType("datetime");

                entity.Property(e => e.DocDxf).HasColumnType("image");

                entity.Property(e => e.DocKon).HasColumnType("image");

                entity.Property(e => e.DocPr).HasColumnType("image");

                entity.Property(e => e.Form)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'А4')");

                entity.Property(e => e.IdAs).HasDefaultValueSql("(1)");

                entity.Property(e => e.NamIsh).HasMaxLength(28);

                entity.Property(e => e.Portret)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.SmCh)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Labels>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Article)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraCode).HasColumnName("Extra_Code");

                entity.Property(e => e.Line1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Line2)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabelsExtCatalogue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Article).HasMaxLength(50);

                entity.Property(e => e.ClientCode).HasMaxLength(20);

                entity.Property(e => e.DateSave)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeclarationNumber).HasMaxLength(100);

                entity.Property(e => e.DeliverySet).HasMaxLength(100);

                entity.Property(e => e.DeliverySetKz)
                    .HasColumnName("DeliverySetKZ")
                    .HasMaxLength(100);

                entity.Property(e => e.LabelTemplate).HasColumnType("image");

                entity.Property(e => e.LabelTemplateB).HasColumnType("image");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.NameKz)
                    .HasColumnName("NameKZ")
                    .HasMaxLength(200);

                entity.Property(e => e.QuantityPacks).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ral)
                    .HasColumnName("RAL")
                    .HasMaxLength(70);

                entity.Property(e => e.Volume).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.VolumeB).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Weight).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.WeightB).HasColumnType("decimal(8, 3)");
            });

            modelBuilder.Entity<LocksЗамки>(entity =>
            {
                entity.HasKey(e => new { e.LockId, e.FactoryId });

                entity.ToTable("LOCKS.Замки");

                entity.Property(e => e.LockId)
                    .HasColumnName("LockID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.ArticulTo)
                    .IsRequired()
                    .HasColumnName("ArticulTO")
                    .HasMaxLength(50);

                entity.Property(e => e.LockName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<LocksРаспечатанныеЭтикетки>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("LOCKS.Распечатанные_этикетки");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.ArticulTo)
                    .HasColumnName("ArticulTO")
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LockId).HasColumnName("LockID");

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.User).HasMaxLength(50);
            });

            modelBuilder.Entity<MaterialInNonStdProduction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdarticleInOrder).HasColumnName("IDArticleInOrder");

                entity.Property(e => e.Material)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaterialType).HasComment("1-краска;2-замки;3-металл;4-упаковка");

                entity.Property(e => e.Quantity).HasColumnType("decimal(10, 6)");
            });

            modelBuilder.Entity<MetAccountingObjects>(entity =>
            {
                entity.HasKey(e => e.ObjectId);

                entity.ToTable("MET.ACCOUNTING_OBJECTS");

                entity.HasComment("Объекты, используемые в учете металла: листы, штрипсы, контейнеры с отходами");

                entity.HasIndex(e => e.ObjectId)
                    .HasDatabaseName("IX_MET.ACCOUNTING_OBJECTS")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjectType, e.Width, e.Length, e.Thickness })
                    .HasDatabaseName("AK_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasComment("ИДЕН");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Length)
                    .HasColumnName("LENGTH")
                    .HasColumnType("decimal(14, 3)")
                    .HasComment("Длинна");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .HasComment("Наименование объекта");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(10)
                    .HasComment("Тип объекта");

                entity.Property(e => e.Thickness)
                    .HasColumnName("THICKNESS")
                    .HasColumnType("decimal(14, 4)")
                    .HasComment("Толщина");

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasComment("Вес единицы объекта");

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasColumnType("decimal(14, 3)")
                    .HasComment("Ширина");
            });

            modelBuilder.Entity<MetMetalMoving>(entity =>
            {
                entity.HasKey(e => e.Idrec);

                entity.ToTable("MET.METAL_MOVING");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(255)
                    .HasComment("Комментарий к операции");

                entity.Property(e => e.Count)
                    .HasColumnName("COUNT")
                    .HasComment("Количество использованных материалов");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date")
                    .HasComment("Дата записи");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.MachKodizgot)
                    .HasColumnName("MACH_KODIZGOT")
                    .HasComment("Участок станка");

                entity.Property(e => e.MachNn)
                    .HasColumnName("MACH_NN")
                    .HasComment("Инвертарный номер станка");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasComment("Идентификатор используемого материала (MET.PRODUCTION_OBJECTS)");

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasColumnName("OPERATION")
                    .HasMaxLength(10)
                    .HasComment("Тип выполняемой операции");

                entity.Property(e => e.Shift)
                    .HasColumnName("SHIFT")
                    .HasComment("Смена, в которую была создана запись");

                entity.Property(e => e.TabN)
                    .HasColumnName("TAB_N")
                    .HasComment("Табельный номер сотрудника");

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasComment("Вес металла");
            });

            modelBuilder.Entity<MetStockflow>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PK__MET.STOC__A68686DD8CEA72E5");

                entity.ToTable("MET.STOCKFLOW");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .HasComment("ID операции");

                entity.Property(e => e.Birk)
                    .HasColumnName("BIRK")
                    .HasComment("Номер бирки");

                entity.Property(e => e.Count)
                    .HasColumnName("COUNT")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Количество");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime")
                    .HasComment("Дата/время операции");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot)
                    .HasColumnName("IDIZGOT")
                    .HasComment("Площадка");

                entity.Property(e => e.ObjectFormat)
                    .HasColumnName("OBJECT_FORMAT")
                    .HasComment("ID формата из MET.ACCOUNTING_OBJECTS");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasComment("ID предмета на производстве");

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasColumnName("OPERATION")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasComment("Операция");

                entity.Property(e => e.Tab)
                    .HasColumnName("TAB")
                    .HasComment("Таб. номер сотрудника");

                entity.Property(e => e.TargetKodizgot)
                    .HasColumnName("TARGET_KODIZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("Код затратной зоны назначения");

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("numeric(10, 1)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Вес");
            });

            modelBuilder.Entity<MetStockflowLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MET.STOCKFLOW_LOG");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("COMMENT");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlowId).HasColumnName("FLOW_ID");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasColumnName("OPERATION")
                    .HasMaxLength(50);

                entity.Property(e => e.Tab).HasColumnName("TAB");
            });

            modelBuilder.Entity<MobCalcPay>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Mob.CalcPay");

                entity.HasIndex(e => new { e.Year, e.Month, e.IdReg })
                    .HasDatabaseName("IX_Mob.CalcPay")
                    .IsUnique();

                entity.Property(e => e.SummNds).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UsP).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UsR).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UsTel).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<MobHistory>(entity =>
            {
                entity.HasKey(e => new { e.Phone, e.Period, e.Idizgot });

                entity.ToTable("Mob.History");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(50);

                entity.Property(e => e.Period)
                    .HasColumnName("PERIOD")
                    .HasColumnType("date");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.Amount)
                    .HasColumnName("AMOUNT")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("CREATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Limit)
                    .HasColumnName("LIMIT")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Organization)
                    .IsRequired()
                    .HasColumnName("ORGANIZATION")
                    .HasMaxLength(100);

                entity.Property(e => e.Post)
                    .HasColumnName("POST")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MobOrg>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Mob.Org");

                entity.HasIndex(e => new { e.IdIzgot, e.IdRec })
                    .HasDatabaseName("IX_Mob.Org")
                    .IsUnique();

                entity.Property(e => e.NamOrg).HasMaxLength(50);
            });

            modelBuilder.Entity<MobPerView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Mob_PerView", "db_owner");

                entity.Property(e => e.Fio).HasMaxLength(157);
            });

            modelBuilder.Entity<MobPers>(entity =>
            {
                entity.HasKey(e => e.IdPers);

                entity.ToTable("Mob.Pers");

                entity.HasComment("Таблица пользователей мобильной связи");

                entity.Property(e => e.IdPers)
                    .HasComment("Личный номер сотрудника  из DATA.dbo.[Сотрудники]")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dolg).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.IdOrg).HasComment("Id организации из dbo.[Mob.Org]");

                entity.Property(e => e.WorkPlace).HasMaxLength(100);
            });

            modelBuilder.Entity<MobTel>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Mob.Tel");

                entity.HasIndex(e => e.Tnum)
                    .HasDatabaseName("IX_Mob.Tel")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdIzgot, e.IdOrg, e.Tnum })
                    .HasDatabaseName("IX_Mob.Tel_1");

                entity.Property(e => e.IdOrg).HasComment("Id оргазинации из dbo.[Mob.Tel]");

                entity.Property(e => e.Operator).HasMaxLength(10);

                entity.Property(e => e.Tnum)
                    .HasColumnName("TNum")
                    .HasMaxLength(16);

                entity.Property(e => e.Tpin)
                    .HasColumnName("TPIN")
                    .HasMaxLength(40);

                entity.Property(e => e.Tpuk)
                    .HasColumnName("TPUK")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Tsim)
                    .HasColumnName("TSim")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<MobTelPers>(entity =>
            {
                entity.HasKey(e => e.IdReg);

                entity.ToTable("Mob.TelPers");

                entity.Property(e => e.LimitAbon).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.LimitTalk).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<MobTelView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Mob.TelView", "db_owner");

                entity.Property(e => e.NamOrg).HasMaxLength(50);

                entity.Property(e => e.Operator).HasMaxLength(10);

                entity.Property(e => e.Tnum)
                    .HasColumnName("TNum")
                    .HasMaxLength(16);

                entity.Property(e => e.Tpin)
                    .HasColumnName("TPIN")
                    .HasMaxLength(40);

                entity.Property(e => e.Tpuk)
                    .HasColumnName("TPUK")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Tsim)
                    .HasColumnName("TSim")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<NaklFirmList>(entity =>
            {
                entity.HasKey(e => new { e.FactoryId, e.Sign })
                    .HasName("PK_NAKL.FirmList_1");

                entity.ToTable("NAKL.FirmList");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Sign)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NewPrcs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NewPrcs", "fortests");

                entity.Property(e => e.Amort).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Articul).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<ObjectPositionRules>(entity =>
            {
                entity.ToTable("ObjectPositionRules", "cargo");

                entity.HasIndex(e => e.Name)
                    .HasDatabaseName("ObjectPositionRules_UQ")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowedPositions)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Разрешенные расположения объекта через запятую");

                entity.Property(e => e.MaxLiftHeight).HasComment("Максимальная высота подъема");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Наименование правила");

                entity.Property(e => e.ObjectNameFilter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Фильтр наименования объекта");

                entity.Property(e => e.PlaceOrder).HasComment("Чем выше - тем больше приоритет при распределении очередности");
            });

            modelBuilder.Entity<OlSecMhid>(entity =>
            {
                entity.ToTable("Ol.secMhid");

                entity.HasIndex(e => new { e.Hid, e.RibbonId, e.TabId, e.GroupId, e.ItemId })
                    .HasDatabaseName("IX_Ol.secMhid_Column")
                    .IsUnique();

                entity.Property(e => e.Dostup).HasDefaultValueSql("((1))");

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RibbonId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TabId)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OlSecMpos>(entity =>
            {
                entity.ToTable("Ol.secMpos");

                entity.HasIndex(e => new { e.IdPos, e.RibbonId, e.TabId, e.GroupId, e.ItemId })
                    .HasDatabaseName("IX_Ol.secMpos_Column")
                    .IsUnique();

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RibbonId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TabId)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OpCatCorrection>(entity =>
            {
                entity.HasNoKey();

                entity.HasComment("Коэф. к операциям по спецзаказам разных категорий и производств");

                entity.HasIndex(e => new { e.Koeff, e.IdIzgot, e.KodIzgot, e.Category, e.Operation })
                    .HasDatabaseName("UQ_OpCatCorrection")
                    .IsUnique();

                entity.Property(e => e.Category)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Категория спецзаказа");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Koeff)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Коэфф.");

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Операция");
            });

            modelBuilder.Entity<OpCatCorrection1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OpCatCorrection", "fortests");

                entity.HasIndex(e => new { e.Koeff, e.IdIzgot, e.KodIzgot, e.Category, e.Operation })
                    .HasDatabaseName("UQ_OpCatCorrection")
                    .IsUnique();

                entity.Property(e => e.Category)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Категория спецзаказа");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Koeff)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Коэфф.");

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Операция");
            });

            modelBuilder.Entity<OutlabelBindingTemplates>(entity =>
            {
                entity.ToTable("outlabel.BindingTemplates");

                entity.HasIndex(e => new { e.FactoryId, e.Articul, e.Zakaz })
                    .HasDatabaseName("IX_outlabel.BindingTemplates");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Articul).HasMaxLength(50);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.Zakaz).HasMaxLength(50);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.OutlabelBindingTemplates)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_outlabel.BindingTemplates_outlabel.Templates");
            });

            modelBuilder.Entity<OutlabelImageLists>(entity =>
            {
                entity.HasKey(e => e.ImageListId);

                entity.ToTable("outlabel.ImageLists");

                entity.Property(e => e.ImageListId).HasColumnName("ImageListID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ParamId)
                    .IsRequired()
                    .HasColumnName("ParamID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Param)
                    .WithMany(p => p.OutlabelImageLists)
                    .HasForeignKey(d => d.ParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_outlabel.ImageLists_outlabel.Params");
            });

            modelBuilder.Entity<OutlabelImageListsDetails>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.ToTable("outlabel.ImageListsDetails");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.ImageListId).HasColumnName("ImageListID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ParamValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SignLinkPropertyId)
                    .HasColumnName("SignLinkPropertyID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ImageList)
                    .WithMany(p => p.OutlabelImageListsDetails)
                    .HasForeignKey(d => d.ImageListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_outlabel.ImageListsDetails_outlabel.ImageLists");
            });

            modelBuilder.Entity<OutlabelImages>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.ToTable("outlabel.Images");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.IsLocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<OutlabelLanguages>(entity =>
            {
                entity.HasKey(e => e.LangId);

                entity.ToTable("outlabel.Languages");

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<OutlabelParamConstant>(entity =>
            {
                entity.HasKey(e => new { e.ParamId, e.FactoryId, e.LangId });

                entity.ToTable("outlabel.ParamConstant");

                entity.Property(e => e.ParamId)
                    .HasColumnName("ParamID")
                    .HasMaxLength(50);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.ParamName).HasMaxLength(255);

                entity.Property(e => e.ParamValue).HasMaxLength(1000);
            });

            modelBuilder.Entity<OutlabelParamFormat>(entity =>
            {
                entity.HasKey(e => new { e.ParamId, e.LangId });

                entity.ToTable("outlabel.ParamFormat");

                entity.Property(e => e.ParamId)
                    .HasColumnName("ParamID")
                    .HasMaxLength(50);

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.FormatString).HasMaxLength(255);
            });

            modelBuilder.Entity<OutlabelParams>(entity =>
            {
                entity.HasKey(e => e.ParamId)
                    .HasName("PK_outlabel.Params_1");

                entity.ToTable("outlabel.Params");

                entity.Property(e => e.ParamId)
                    .HasColumnName("ParamID")
                    .HasMaxLength(50);

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasColumnName("isVisible")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.ValueTypeId).HasColumnName("ValueTypeID");

                entity.HasOne(d => d.ValueType)
                    .WithMany(p => p.OutlabelParams)
                    .HasForeignKey(d => d.ValueTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_outlabel.Params_outlabel.ValueTypes");
            });

            modelBuilder.Entity<OutlabelTemplates>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("outlabel.Templates");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedHid).HasColumnName("CreatedHID");

                entity.Property(e => e.Edited).HasColumnType("datetime");

                entity.Property(e => e.EditedHid)
                    .HasColumnName("EditedHID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TemplateData).HasColumnType("xml");
            });

            modelBuilder.Entity<OutlabelValueTypes>(entity =>
            {
                entity.HasKey(e => e.ValueTypeId);

                entity.ToTable("outlabel.ValueTypes");

                entity.Property(e => e.ValueTypeId)
                    .HasColumnName("ValueTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PaintAjurarticleCode>(entity =>
            {
                entity.ToTable("PaintAJURArticleCode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArticleAjur)
                    .IsRequired()
                    .HasColumnName("ArticleAJUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleRalcode)
                    .IsRequired()
                    .HasColumnName("ArticleRALCode")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PaintType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 - порошковая краска; 2 - жидкая краска");
            });

            modelBuilder.Entity<PaintLabourIntensity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LabourIntensity).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaintLabourIntensityByDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdlabourIntensity).HasColumnName("IDLabourIntensity");
            });

            modelBuilder.Entity<PaintLineSpeed>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsQuantPerHanger).HasColumnType("decimal(7, 1)");

                entity.Property(e => e.LineSpeed)
                    .HasColumnType("decimal(4, 2)")
                    .HasComment("Скорость окрасочной линии");

                entity.Property(e => e.LineType).HasComment("1 - сейфы, 2 - мебель");
            });

            modelBuilder.Entity<Parameters>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterValue)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonsConnections>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idchief)
                    .HasColumnName("IDChief")
                    .HasComment("начальник HR.IND_KART.IDREC");

                entity.Property(e => e.Idgroup)
                    .HasColumnName("IDGroup")
                    .HasComment(@"для конструкторов: 1-сейфы; 2-мебель; 3-двери
4 - конструкторская группа в Узловой
5 - конструкторская группа в Болгарии");

                entity.Property(e => e.Idperson)
                    .HasColumnName("IDPerson")
                    .HasComment("HR.IND_KART.IDREC");

                entity.Property(e => e.Idpost)
                    .HasColumnName("IDPost")
                    .HasComment("Posts.ID");

                entity.Property(e => e.PathForDraftEnter)
                    .HasMaxLength(1000)
                    .HasComment("Папка, из которой вводится чертеж");

                entity.Property(e => e.PathForDrafts)
                    .HasMaxLength(700)
                    .IsUnicode(false)
                    .HasComment("Папка для чертежей для пакетного добавления их в конструкторские извещения");

                entity.Property(e => e.SendCardPermission).HasComment("признак рассылки уведомлений о карточках-разрешениях");

                entity.Property(e => e.SendNote).HasComment("признак рассылки уведомлений о согласовании конструкторских извещений");

                entity.Property(e => e.SendNoteTechNotice).HasComment("признак рассылки уведомлений о согласовании технологических извещений: 1 - ЗМК; 2 - УЗМК; 3 - Болгария; 12 - ЗМК и УЗМК; 123 - ЗМК, УЗМК и Болгария и т.д.");

                entity.Property(e => e.Unit).HasDefaultValueSql("((39))");
            });

            modelBuilder.Entity<PlanClose>(entity =>
            {
                entity.ToTable("PLAN.Close");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Closed).HasComment("План закрыт/открыт в данный момент");

                entity.Property(e => e.ClosedPlanWas).HasComment("1, если план на неделю по дням был закрыт");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.Idperson).HasColumnName("IDPerson");

                entity.Property(e => e.IdplantType).HasColumnName("IDPlantType");
            });

            modelBuilder.Entity<PlanDetailsBySections>(entity =>
            {
                entity.ToTable("PLAN.DetailsBySections");

                entity.HasIndex(e => new { e.Unit, e.Section, e.Detail })
                    .HasDatabaseName("Detail")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItIsDetail)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlanNew>(entity =>
            {
                entity.ToTable("PLAN.NEW");

                entity.HasIndex(e => new { e.Articul, e.DeadLine, e.IdSpec, e.Flag })
                    .HasDatabaseName("IX_PLAN.NEW_Column")
                    .IsUnique();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DateP).HasColumnType("datetime");

                entity.Property(e => e.DeadLine).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlanPlHoliday>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PL_HOLIDAY_PK");

                entity.ToTable("PLAN.PL_HOLIDAY");

                entity.HasIndex(e => e.Data)
                    .HasDatabaseName("PL_HOLIDAY_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Pr)
                    .HasColumnName("PR")
                    .HasColumnType("decimal(2, 0)");
            });

            modelBuilder.Entity<PlanPlansogl>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PLANSOGL_PK");

                entity.ToTable("PLAN.PLANSOGL");

                entity.HasIndex(e => new { e.Year, e.Month, e.Typ })
                    .HasDatabaseName("PLANSOGL_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Plan)
                    .HasColumnName("PLAN")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Plan1)
                    .HasColumnName("PLAN1")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Plan2)
                    .HasColumnName("PLAN2")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Typ)
                    .HasColumnName("TYP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<PlanProductionTurnTask>(entity =>
            {
                entity.ToTable("PLAN.ProductionTurnTask");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlanPullCom>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PULL_COM_PK");

                entity.ToTable("PLAN.PULL_COM");

                entity.HasIndex(e => new { e.Det, e.KodIzgot, e.Mash, e.Nn })
                    .HasDatabaseName("PULL_COM_IX1");

                entity.HasIndex(e => new { e.Nam, e.Idrec, e.Idizgot, e.KodIzgot, e.Det, e.Delrecord })
                    .HasDatabaseName("PLAN.PULL_COM_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodUp)
                    .HasColumnName("COD_UP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NamPrv)
                    .HasColumnName("NAM_PRV")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nn)
                    .HasColumnName("NN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Operaciya)
                    .HasColumnName("OPERACIYA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Zad)
                    .HasColumnName("ZAD")
                    .HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<PlanPullFD>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PULL_F_D_PK");

                entity.ToTable("PLAN.PULL_F_D");

                entity.HasIndex(e => new { e.Year, e.Month, e.Day, e.Sm, e.KodIzgot, e.Complect, e.Det })
                    .HasDatabaseName("PULL_F_D_IX1");

                entity.HasIndex(e => new { e.Det, e.KodIzgot, e.Mash, e.Nn, e.Year, e.Month, e.Day, e.Sm })
                    .HasDatabaseName("PULL_F_D_IX2");

                entity.HasIndex(e => new { e.Year, e.Month, e.Day, e.Sm, e.Det, e.KodIzgot, e.Mash, e.Nn })
                    .HasDatabaseName("PULL_F_D_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Complect)
                    .HasColumnName("COMPLECT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Day)
                    .HasColumnName("DAY")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Nn)
                    .HasColumnName("NN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sm)
                    .HasColumnName("SM")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<PlanPullFact>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PULL_FACT_PK");

                entity.ToTable("PLAN.PULL_FACT");

                entity.HasIndex(e => new { e.IdPullPl, e.SectionNumber })
                    .HasDatabaseName("ID_Pull_Pl");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.DateFact)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdPullPl).HasColumnName("ID_PULL_PL");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.SectionNumber).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PlanPullPD>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PULL_P_D_PK");

                entity.ToTable("PLAN.PULL_P_D");

                entity.HasComment(@"Old data
No refs");

                entity.HasIndex(e => new { e.Idizgot, e.Delrecord, e.Year, e.Month, e.Day, e.Sm, e.KodIzgot, e.Det })
                    .HasDatabaseName("PULL_P_D_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Complect)
                    .HasColumnName("COMPLECT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Day)
                    .HasColumnName("DAY")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcustomer).HasColumnName("IDCustomer");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.IdproductionInOrder).HasColumnName("IDProductionInOrder");

                entity.Property(e => e.Idral).HasColumnName("IDRAL");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Nn)
                    .HasColumnName("NN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sm)
                    .HasColumnName("SM")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<PlanPullPD1>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PULL1_P_D_PK");

                entity.ToTable("PLAN_PULL_P_D");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Complect)
                    .HasColumnName("COMPLECT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Day)
                    .HasColumnName("DAY")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Nn)
                    .HasColumnName("NN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sm)
                    .HasColumnName("SM")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<PlanPullPl>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PULL_PL_PK");

                entity.ToTable("PLAN.PULL_PL");

                entity.HasIndex(e => new { e.Articul, e.Dop, e.Year, e.Month, e.Day })
                    .HasDatabaseName("PULL_PL_IX1");

                entity.HasIndex(e => new { e.Delrecord, e.Idizgot, e.Year, e.Month, e.Day })
                    .HasDatabaseName("PULL_PL_IX3");

                entity.HasIndex(e => new { e.Year, e.Month, e.Day, e.Articul, e.Dop })
                    .HasDatabaseName("PULL_PL_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Day)
                    .HasColumnName("DAY")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Dop)
                    .HasColumnName("DOP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Iduser).HasColumnName("IDUser");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(50);

                entity.Property(e => e.SectionNumber).HasComment("№ участка, на который планируется выпуск: 1 заготовка; 2 гибка; 3 сварка; 4 покраска; 5 бетон; 6 подготовка и покраска; 7 сборка");

                entity.Property(e => e.TorecId)
                    .HasColumnName("TORecID")
                    .HasComment(" DATA.dbo.[Товар в заказе регион].[Record ID]");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<PlanPullPlan>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PULL_PLAN_PK");

                entity.ToTable("PLAN.PULL_PLAN");

                entity.HasIndex(e => new { e.Articul, e.DopCod, e.Year, e.Week })
                    .HasDatabaseName("PULL_PLAN_IX2");

                entity.HasIndex(e => new { e.Year, e.Week, e.Articul, e.DopCod })
                    .HasDatabaseName("PULL_PLAN_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ArticulAlt)
                    .HasColumnName("ARTICUL_ALT")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Week)
                    .HasColumnName("WEEK")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<PlanPullUp>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PULL_UP_PK");

                entity.ToTable("PLAN.PULL_UP");

                entity.HasIndex(e => new { e.DataPlan, e.Sm, e.Nn, e.UpCod })
                    .HasDatabaseName("PULL_UP_IX1");

                entity.HasIndex(e => new { e.Nn, e.DataPlan, e.Sm, e.UpCod })
                    .HasDatabaseName("PULL_UP_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DataPlan)
                    .HasColumnName("DATA_PLAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datech)
                    .HasColumnName("DATECH")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.ExNam)
                    .HasColumnName("EX_NAM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExTime)
                    .HasColumnName("EX_TIME")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.FullPath)
                    .HasColumnName("FULL_PATH")
                    .HasMaxLength(250);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nn)
                    .HasColumnName("NN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Prior).HasColumnName("PRIOR");

                entity.Property(e => e.Sm)
                    .HasColumnName("SM")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.UpCod)
                    .HasColumnName("UP_COD")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlanTaskMskSection>(entity =>
            {
                entity.ToTable("PLAN.TaskMskSection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateTask).HasColumnType("date");

                entity.Property(e => e.Idsection).HasColumnName("IDSection");

                entity.Property(e => e.Idset).HasColumnName("IDSet");
            });

            modelBuilder.Entity<PlanTaskMskSectionProduction>(entity =>
            {
                entity.ToTable("PLAN.TaskMskSectionProduction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreation).HasColumnType("date");

                entity.Property(e => e.NameProductionSet)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Unit).HasDefaultValueSql("((39))");
            });

            modelBuilder.Entity<PlanTaskMskSectionProductionSet>(entity =>
            {
                entity.ToTable("PLAN.TaskMskSectionProductionSet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idproduction).HasColumnName("IDProduction");

                entity.Property(e => e.Idset).HasColumnName("IDSet");
            });

            modelBuilder.Entity<PlanTaskMskSectionWork>(entity =>
            {
                entity.ToTable("PLAN.TaskMskSectionWork");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cprogramme)
                    .HasColumnName("CProgramme")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idtask).HasColumnName("IDTask");
            });

            modelBuilder.Entity<PlanTaskPaintSection>(entity =>
            {
                entity.ToTable("PLAN.TaskPaintSection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateTask).HasColumnType("date");

                entity.Property(e => e.TimeChange).HasColumnType("decimal(10, 4)");
            });

            modelBuilder.Entity<PlanTaskPaintSectionWork>(entity =>
            {
                entity.ToTable("PLAN.TaskPaintSectionWork");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idplant).HasColumnName("IDPlant");

                entity.Property(e => e.Idtask).HasColumnName("IDTask");

                entity.Property(e => e.Iduser).HasColumnName("IDUser");

                entity.Property(e => e.PaintCode).HasMaxLength(50);

                entity.Property(e => e.ProductionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeRate).HasColumnType("decimal(10, 4)");
            });

            modelBuilder.Entity<PlanTaskSection>(entity =>
            {
                entity.ToTable("PLAN.TaskSection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateTask).HasColumnType("date");

                entity.Property(e => e.Idsection).HasColumnName("IDSection");

                entity.Property(e => e.IdtaskType).HasColumnName("IDTaskType");

                entity.Property(e => e.IdtaskWeld).HasColumnName("IDTaskWeld");

                entity.Property(e => e.Sorting).HasComment("Порядок следования изделий в задании");
            });

            modelBuilder.Entity<PlanTaskSectionOrders>(entity =>
            {
                entity.ToTable("PLAN.TaskSectionOrders");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdorderSp).HasColumnName("IDOrderSp");

                entity.Property(e => e.Idtask).HasColumnName("IDTask");

                entity.Property(e => e.OrderNumberTo).HasColumnName("OrderNumberTO");
            });

            modelBuilder.Entity<PlanTaskSectionWork>(entity =>
            {
                entity.ToTable("PLAN.TaskSectionWork");

                entity.HasIndex(e => e.Idtask)
                    .HasDatabaseName("IDTask");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.Idproduction).HasColumnName("IDProduction");

                entity.Property(e => e.IdproductionPair).HasColumnName("IDProductionPair");

                entity.Property(e => e.Idtask).HasColumnName("IDTask");

                entity.Property(e => e.OrderNumberTo).HasColumnName("OrderNumberTO");
            });

            modelBuilder.Entity<PlantMachine>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<PlantMaterial>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gauge).HasColumnType("decimal(7, 1)");

                entity.Property(e => e.Lenght).HasColumnType("decimal(7, 1)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Width).HasColumnType("decimal(7, 1)");
            });

            modelBuilder.Entity<PlantMetalMachine>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idmachine).HasColumnName("IDMachine");

                entity.Property(e => e.Idmaterial).HasColumnName("IDMaterial");

                entity.Property(e => e.Idperson).HasColumnName("IDPerson");

                entity.Property(e => e.MeasureUnit).HasComment("1 - шт; 2 - кг");

                entity.Property(e => e.Quantity).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.TransactionType).HasComment("1 - приход; 0 - инвентаризация");

                entity.Property(e => e.TurnDate).HasColumnType("date");
            });

            modelBuilder.Entity<PlantSalaryPaintProduction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Article)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Coef).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<PlantSalaryParameters>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParameterIndex).HasComment("1 - общий выпуск; 2 - время профилактики; 3 - время других работ; 4 - стоимость нормочаса; 5 - выпуск тупиковой окрасочной линии");

                entity.Property(e => e.ParameterValue).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<PlantTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idchief).HasColumnName("IDChief");

                entity.Property(e => e.InDailyReport).HasComment("Вывод в ежедневный отчет о выпуске продукции");

                entity.Property(e => e.Kfam)
                    .HasColumnName("KFam")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.PlantType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sort1).HasComment("Порядок сортировки производств для отчетов");
            });

            modelBuilder.Entity<PlantTypesSection>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdplantTypeA).HasColumnName("IDPlantTypeA");

                entity.Property(e => e.IdplantTypeB).HasColumnName("IDPlantTypeB");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DurationOfAgreementDays).HasComment("Кол-во дней, отведенное на согласование конструкторских извещений");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameShort)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProjectSt>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PROJECT_ST_PK");

                entity.ToTable("PR.PROJECT_ST");

                entity.HasIndex(e => e.ProjName)
                    .HasDatabaseName("PROJECT_ST_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.ProjFinish)
                    .HasColumnName("PROJ_FINISH")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjKrit)
                    .HasColumnName("PROJ_KRIT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProjLider)
                    .HasColumnName("PROJ_LIDER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProjMem)
                    .HasColumnName("PROJ_MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProjName)
                    .HasColumnName("PROJ_NAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProjShut)
                    .HasColumnName("PROJ_SHUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjStart)
                    .HasColumnName("PROJ_START")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjType)
                    .HasColumnName("PROJ_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prices39>(entity =>
            {
                entity.HasKey(e => e.Iditem)
                    .HasName("PK__Prices39__C9778A1031852710");

                entity.Property(e => e.Iditem)
                    .HasColumnName("IDItem")
                    .ValueGeneratedNever();

                entity.Property(e => e.Currency).HasMaxLength(10);

                entity.Property(e => e.DateLastUpdate).HasColumnType("date");

                entity.Property(e => e.FifoNds)
                    .HasColumnName("FIFO_NDS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FifoPrice)
                    .HasColumnName("FIFO_Price")
                    .HasColumnType("money");

                entity.Property(e => e.LifoNds)
                    .HasColumnName("LIFO_NDS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LifoPrice)
                    .HasColumnName("LIFO_Price")
                    .HasColumnType("money");

                entity.Property(e => e.MiddleNds)
                    .HasColumnName("Middle_NDS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MiddlePrice)
                    .HasColumnName("Middle_Price")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Prices44>(entity =>
            {
                entity.HasKey(e => e.Iditem)
                    .HasName("PK__Prices44__C9778A107646FC78");

                entity.Property(e => e.Iditem)
                    .HasColumnName("IDItem")
                    .ValueGeneratedNever();

                entity.Property(e => e.Currency).HasMaxLength(10);

                entity.Property(e => e.DateLastUpdate).HasColumnType("date");

                entity.Property(e => e.FifoNds)
                    .HasColumnName("FIFO_NDS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FifoPrice)
                    .HasColumnName("FIFO_Price")
                    .HasColumnType("money");

                entity.Property(e => e.LifoNds)
                    .HasColumnName("LIFO_NDS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LifoPrice)
                    .HasColumnName("LIFO_Price")
                    .HasColumnType("money");

                entity.Property(e => e.MiddleNds)
                    .HasColumnName("Middle_NDS")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MiddlePrice)
                    .HasColumnName("Middle_Price")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<PrjProjectId>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PROJECT_ID_PK");

                entity.ToTable("PRJ.PROJECT_ID");

                entity.HasIndex(e => new { e.PrLPNam, e.PrLPId })
                    .HasDatabaseName("PROJECT_ID_IX2");

                entity.HasIndex(e => new { e.PrUPNam, e.PrUPId })
                    .HasDatabaseName("PROJECT_ID_IX3");

                entity.HasIndex(e => new { e.ProjName, e.ParentId, e.ProjNom })
                    .HasDatabaseName("PROJECT_ID_IX1");

                entity.HasIndex(e => new { e.ProjName, e.ProjId, e.ParentId })
                    .HasDatabaseName("PROJECT_ID_IX4");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.FlagSave).HasColumnName("FLAG_SAVE");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kontr).HasColumnName("KONTR");

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.PrLPId)
                    .HasColumnName("PR_L_P_ID")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.PrLPNam)
                    .HasColumnName("PR_L_P_NAM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PrUPId)
                    .HasColumnName("PR_U_P_ID")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.PrUPNam)
                    .HasColumnName("PR_U_P_NAM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProjContr)
                    .HasColumnName("PROJ_CONTR")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ProjFin)
                    .HasColumnName("PROJ_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjId)
                    .HasColumnName("PROJ_ID")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.ProjMem)
                    .HasColumnName("PROJ_MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProjName)
                    .HasColumnName("PROJ_NAME")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProjNom)
                    .HasColumnName("PROJ_NOM")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.ProjShut)
                    .HasColumnName("PROJ_SHUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjStart)
                    .HasColumnName("PROJ_START")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjSumm)
                    .HasColumnName("PROJ_SUMM")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProjTime)
                    .HasColumnName("PROJ_TIME")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.ProjUsl)
                    .HasColumnName("PROJ_USL")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Ur)
                    .HasColumnName("UR")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Znak)
                    .HasColumnName("ZNAK")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrnArticulLabel>(entity =>
            {
                entity.HasKey(e => e.Lid);

                entity.ToTable("PRN.ARTICUL_LABEL");

                entity.Property(e => e.Lid).HasColumnName("LID");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DopCode).HasColumnName("Dop_Code");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Lang).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PrnLabelParams>(entity =>
            {
                entity.HasKey(e => e.ParamName);

                entity.ToTable("PRN.LABEL_Params");

                entity.Property(e => e.ParamName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<PrnLabelTextParamsArticulValue>(entity =>
            {
                entity.HasKey(e => new { e.Lid, e.ParamName })
                    .HasName("PK_PRN.LABEL_Text_Params_Articul_Value_1");

                entity.ToTable("PRN.LABEL_Text_Params_Articul_Value");

                entity.Property(e => e.Lid).HasColumnName("LID");

                entity.Property(e => e.ParamName).HasMaxLength(50);

                entity.Property(e => e.ParamValue).HasMaxLength(50);
            });

            modelBuilder.Entity<PrnLabelTextParamsGlobalValue>(entity =>
            {
                entity.HasKey(e => new { e.ParamName, e.Lang });

                entity.ToTable("PRN.LABEL_Text_Params_Global_Value");

                entity.Property(e => e.ParamName).HasMaxLength(50);

                entity.Property(e => e.ParamValue).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductionAreas>(entity =>
            {
                entity.HasKey(e => new { e.Kodizgot, e.Idizgot });

                entity.ToTable("PRODUCTION_AREAS");

                entity.Property(e => e.Kodizgot).HasColumnName("KODIZGOT");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasColumnName("AREA_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.PrType)
                    .IsRequired()
                    .HasColumnName("PR_TYPE")
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProductionCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.IdIzgot, e.Smena, e.Date })
                    .HasDatabaseName("ProductionCalendar_PK")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("Дата");

                entity.Property(e => e.Holiday).HasComment("Флаг государственного праздника");

                entity.Property(e => e.Hours)
                    .HasColumnType("decimal(4, 1)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Кол-во рабочих часов (0 - выходной)");

                entity.Property(e => e.IdIzgot).HasComment("ИД завода");

                entity.Property(e => e.Smena).HasComment("ИД смены, если NULL - то применяется для всех смен завода");
            });

            modelBuilder.Entity<ProductionOrderPositions>(entity =>
            {
                entity.HasNoKey();

                entity.HasComment("Позиции производственного заказа");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Артикул");

                entity.Property(e => e.Count)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Кол-во");

                entity.Property(e => e.DopCod).HasComment("Доп. код");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("ИД заказа");
            });

            modelBuilder.Entity<ProductionOrders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Producti__C3905BAFB5D0DFD2");

                entity.HasComment("Заказы на производство");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasComment("ИД заказа");

                entity.Property(e => e.CreatedByUserId)
                    .HasColumnName("CreatedByUserID")
                    .HasComment("Создан пользователем");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasComment("На какую дату заказ");

                entity.Property(e => e.IdIzgot)
                    .HasDefaultValueSql("((39))")
                    .HasComment("ИД площадки");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Целевая затратная зона");

                entity.Property(e => e.ModifiedByUserId)
                    .HasColumnName("ModifiedByUserID")
                    .HasComment("Изменен пользователем");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата изменения");
            });

            modelBuilder.Entity<ProductionSetup>(entity =>
            {
                entity.HasKey(e => new { e.IdIzgot, e.KodIzgot })
                    .HasName("ProductionSetup_PK");

                entity.Property(e => e.IdIzgot).HasComment("ИД завода");

                entity.Property(e => e.KodIzgot)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("Код участка");

                entity.Property(e => e.BonusMax)
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("Максимальная премия");

                entity.Property(e => e.BonusMin)
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("Минимальная премия (соотв. нижней границе выпуска)");

                entity.Property(e => e.Brigades)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Состав бригад");

                entity.Property(e => e.Compound)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Список затратных зон, из которых будет складываться сумма выпуска. Если пусто, то значит выпуск складывается из собственной сдачи");

                entity.Property(e => e.CuratorTo1)
                    .HasColumnName("CuratorTO1")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Куратор ТО1");

                entity.Property(e => e.CuratorZp)
                    .HasColumnName("CuratorZP")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Куратор расчета ЗП");

                entity.Property(e => e.IsProduction).HasComment("Является ли производством");

                entity.Property(e => e.Method).HasComment("Метод расчета: 0 - стандартный, 1 - от выпуска продукции, 2 - экспер. от выпуска");

                entity.Property(e => e.NoRestrictTabel).HasComment("Не ограничивать табель (сводобное табелирование)");

                entity.Property(e => e.OneInitPerShift).HasComment("Операции \"наладка\" и \"контрольная на партию\" вычисляются только один раз за смену");

                entity.Property(e => e.Operations)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Список выполняемых операций");

                entity.Property(e => e.OrgId)
                    .HasColumnName("OrgID")
                    .HasDefaultValueSql("((40))")
                    .HasComment("ИД Организации по кадрам (по умолчанию НПО Промет)");

                entity.Property(e => e.Salary)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("Оклад начальника участка");

                entity.Property(e => e.SpecialOrdersKoeff)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Коэф. стоимости спецзаказов в ФОТ продукции");

                entity.Property(e => e.TabelCloseDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('01.01.2020')")
                    .HasComment("Дата запрета редактирования табеля (включительно)");

                entity.Property(e => e.UsePremium)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Надбавки и доплаты в расчете зарплаты");

                entity.Property(e => e.UseShiftSplit).HasComment("Учитывать разделение смены при переходе из одного месяца в другой");

                entity.Property(e => e.ValueMax)
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("Объем выпуска (верхняя граница)");

                entity.Property(e => e.ValueMin)
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("Объем выпуска (нижняя граница)");
            });

            modelBuilder.Entity<ProductionSetupCache>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.IdIzgot, e.KodIzgot })
                    .HasDatabaseName("ProductionSetupCache_IX1");

                entity.HasIndex(e => new { e.Method, e.Source, e.UsePremium, e.OrgId, e.IdIzgot, e.KodIzgot, e.Brigada })
                    .HasDatabaseName("ProductionSetupCache_PK")
                    .IsUnique();

                entity.Property(e => e.CuratorTo1)
                    .HasColumnName("CuratorTO1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CuratorZp)
                    .HasColumnName("CuratorZP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrgId)
                    .HasColumnName("OrgID")
                    .HasComment("ИД Организации");

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Источник ФОТ");

                entity.Property(e => e.TabelCloseDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('01.01.2020')");

                entity.Property(e => e.UseShiftSplit).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ProductionVolume>(entity =>
            {
                entity.HasNoKey();

                entity.HasComment("Выпуск производственной площадки по месяцам");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Period).HasColumnType("date");

                entity.Property(e => e.Shipments)
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("Объем отгрузок");

                entity.Property(e => e.Volume)
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("Объем выпуска");
            });

            modelBuilder.Entity<RedBzBau>(entity =>
            {
                entity.ToTable("Red.Bz_bau_");

                entity.HasIndex(e => e.IdRec)
                    .HasDatabaseName("IX_Red.Bz_bau__2");

                entity.HasIndex(e => new { e.Det, e.Uzel, e.AsVyvod })
                    .HasDatabaseName("IX_Red.Bz_bau__1");

                entity.HasIndex(e => new { e.Uzel, e.Det, e.AsVyvod })
                    .HasDatabaseName("IX_Red.Bz_bau_");

                entity.HasIndex(e => new { e.Uzel, e.Lit, e.AsVyvod, e.DelRecord })
                    .HasDatabaseName("NodeLitNumberOutputDelrecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("As_vvod")
                    .HasColumnType("decimal(3, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("As_vyvod")
                    .HasColumnType("decimal(3, 0)")
                    .HasDefaultValueSql("((999))");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.DataSaveSql).HasColumnType("datetime");

                entity.Property(e => e.Det)
                    .HasColumnName("det")
                    .HasMaxLength(50);

                entity.Property(e => e.KodSb)
                    .HasColumnName("Kod_sb")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.KodSt)
                    .HasColumnName("Kod_st")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.KolZb)
                    .HasColumnName("Kol_zb")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Lit).HasMaxLength(1);

                entity.Property(e => e.Locked).HasComment("= [Red.SpecHist].IdSpec - если деталь заблокирована другим извещением (деталь входит в сборку, входящую в изделие по другому извещению); 0 или NULL - если нет.");

                entity.Property(e => e.NamDoc)
                    .HasColumnName("Nam_doc")
                    .HasMaxLength(60);

                entity.Property(e => e.PosSb)
                    .HasColumnName("Pos_sb")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Rec).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Uzel).HasMaxLength(50);
            });

            modelBuilder.Entity<RedData>(entity =>
            {
                entity.HasKey(e => e.SmCh);

                entity.ToTable("Red.Data");

                entity.Property(e => e.SmCh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.DateChange).HasColumnType("datetime");

                entity.Property(e => e.DocDxf).HasColumnType("image");

                entity.Property(e => e.DocKon).HasColumnType("image");

                entity.Property(e => e.DocPr).HasColumnType("image");
            });

            modelBuilder.Entity<RedDet1>(entity =>
            {
                entity.ToTable("Red.Det_1");

                entity.HasIndex(e => e.IdRec)
                    .HasDatabaseName("IDRec");

                entity.HasIndex(e => e.Mat)
                    .HasDatabaseName("Material");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Articul).HasMaxLength(12);

                entity.Property(e => e.AsCh)
                    .HasColumnName("As_ch")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("As_vvod")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("As_vyvod")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.DNam)
                    .HasColumnName("D_nam")
                    .HasMaxLength(200);

                entity.Property(e => e.DatFirst)
                    .HasColumnName("Dat_first")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatLast)
                    .HasColumnName("Dat_last")
                    .HasColumnType("datetime");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.DataDel)
                    .HasColumnName("Data_del")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSaveSql).HasColumnType("datetime");

                entity.Property(e => e.Dbenennung)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Det)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("Ean_code")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.FlagView).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Form).HasMaxLength(3);

                entity.Property(e => e.KolGib)
                    .HasColumnName("Kol_gib")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.KolOnePodv)
                    .HasColumnName("kol_one_podv")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.KolPodv)
                    .HasColumnName("kol_podv")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.LenSv)
                    .HasColumnName("Len_sv")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.LenSv2)
                    .HasColumnName("Len_sv_2")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.LitD)
                    .HasColumnName("Lit_d")
                    .HasMaxLength(3);

                entity.Property(e => e.LocNum).HasColumnType("decimal(13, 0)");

                entity.Property(e => e.LustZon)
                    .HasColumnName("Lust_zon")
                    .HasMaxLength(4);

                entity.Property(e => e.Mat).HasMaxLength(20);

                entity.Property(e => e.MaterialAjur)
                    .HasColumnName("MaterialAJUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Me).HasMaxLength(4);

                entity.Property(e => e.Net).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Num).HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Ob).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.PosName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(12, 5)");

                entity.Property(e => e.PricePrv)
                    .HasColumnName("Price_Prv")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.PrjName)
                    .HasColumnName("Prj_name")
                    .HasMaxLength(20);

                entity.Property(e => e.Rbenennung)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SSvZ)
                    .HasColumnName("S_sv_z")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.Smch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeLine)
                    .HasColumnName("Time_line")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Unit39)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Изготавливается на ЗМК, Москва");

                entity.Property(e => e.Unit44)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Изготавливается на УЗМК, Узловая");
            });

            modelBuilder.Entity<RedDet11>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Red_Det_1");

                entity.Property(e => e.Det)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Наименование)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RedSpecHist>(entity =>
            {
                entity.HasKey(e => e.IdSpec);

                entity.ToTable("Red.SpecHist");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("IX_Red.SpecHist");

                entity.HasIndex(e => e.IdGood)
                    .HasDatabaseName("IDGood");

                entity.Property(e => e.BaiEcbs)
                    .HasColumnName("Bai_Ecbs")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiEk)
                    .HasColumnName("Bai_ek")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiEk2)
                    .HasColumnName("Bai_ek2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaiEn)
                    .HasColumnName("Bai_en")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiKon)
                    .HasColumnName("Bai_kon")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiNorm)
                    .HasColumnName("Bai_norm")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiPlant)
                    .HasColumnName("Bai_plant")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiRsbs)
                    .HasColumnName("Bai_RSBS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaiSk)
                    .HasColumnName("Bai_sk")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiTech)
                    .HasColumnName("Bai_tech")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiTechWeld)
                    .HasColumnName("Bai_tech_weld")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Признаки согласования технолога по сварке для новых изделий");

                entity.Property(e => e.BaiVkon)
                    .HasColumnName("Bai_vkon")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiZak)
                    .HasColumnName("Bai_zak")
                    .HasMaxLength(10);

                entity.Property(e => e.Category).HasDefaultValueSql("((1))");

                entity.Property(e => e.DataEk)
                    .HasColumnName("Data_ek")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEk2)
                    .HasColumnName("Data_ek2")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEn)
                    .HasColumnName("Data_en")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFin)
                    .HasColumnName("Data_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFint)
                    .HasColumnName("Data_fint")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFintp)
                    .HasColumnName("Data_fintp")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataKon)
                    .HasColumnName("Data_kon")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataNorm)
                    .HasColumnName("Data_norm")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataPlant)
                    .HasColumnName("Data_plant")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataResiveEcbs)
                    .HasColumnName("Data_resiveEcbs")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataRsbs)
                    .HasColumnName("Data_RSBS")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSendEcbs)
                    .HasColumnName("Data_sendEcbs")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSk)
                    .HasColumnName("Data_sk")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSt)
                    .HasColumnName("Data_st")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataTech)
                    .HasColumnName("Data_tech")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataTechWeld)
                    .HasColumnName("Data_tech_weld")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataVkon)
                    .HasColumnName("Data_vkon")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataZak)
                    .HasColumnName("Data_zak")
                    .HasColumnType("datetime");

                entity.Property(e => e.Det).HasMaxLength(50);

                entity.Property(e => e.FlagVes).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdnoticePack)
                    .HasColumnName("IDNoticePack")
                    .HasComment("[HIST.ST_HIST].IDREC связь с извещением на упаковку");

                entity.Property(e => e.NewIzd).HasDefaultValueSql("((1))");

                entity.Property(e => e.Prim).HasMaxLength(250);

                entity.Property(e => e.Stage).HasComment("1 - извещение в работе; 2 - согласование; 3 - техподготовка; 4 - производство");

                entity.Property(e => e.TextVes).HasMaxLength(50);

                entity.Property(e => e.UtvEk).HasColumnName("Utv_ek");

                entity.Property(e => e.UtvEk2).HasColumnName("Utv_ek2");

                entity.Property(e => e.UtvEn).HasColumnName("Utv_en");

                entity.Property(e => e.UtvKon).HasColumnName("Utv_kon");

                entity.Property(e => e.UtvNorm)
                    .HasColumnName("Utv_norm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UtvPlant).HasColumnName("Utv_plant");

                entity.Property(e => e.UtvRsbs)
                    .HasColumnName("Utv_RSBS")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Согласование ответственного за сертификацию РСБ-С");

                entity.Property(e => e.UtvSk).HasColumnName("Utv_sk");

                entity.Property(e => e.UtvTech).HasColumnName("Utv_tech");

                entity.Property(e => e.UtvTechWeld)
                    .HasColumnName("Utv_tech_weld")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UtvVkon).HasColumnName("Utv_vkon");

                entity.Property(e => e.UtvZak).HasColumnName("Utv_zak");

                entity.Property(e => e.Zamech).HasColumnType("ntext");

                entity.Property(e => e.ZamechId).HasColumnName("Zamech_id");
            });

            modelBuilder.Entity<RedSpecHist1>(entity =>
            {
                entity.HasKey(e => e.IdSpec);

                entity.ToTable("Red.SpecHist_");

                entity.HasIndex(e => new { e.Det, e.Stage })
                    .HasDatabaseName("NonClusteredIndex-20160728-163651");

                entity.Property(e => e.BaiEcbs)
                    .HasColumnName("Bai_Ecbs")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiEk)
                    .HasColumnName("Bai_ek")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiEk2)
                    .HasColumnName("Bai_ek2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaiEn)
                    .HasColumnName("Bai_en")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiKon)
                    .HasColumnName("Bai_kon")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiNorm)
                    .HasColumnName("Bai_norm")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiPlant)
                    .HasColumnName("Bai_plant")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiRsbs)
                    .HasColumnName("Bai_RSBS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BaiSk)
                    .HasColumnName("Bai_sk")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiTech)
                    .HasColumnName("Bai_tech")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiTechWeld)
                    .HasColumnName("Bai_tech_weld")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Признаки согласования технолога по сварке для новых изделий");

                entity.Property(e => e.BaiVkon)
                    .HasColumnName("Bai_vkon")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiZak)
                    .HasColumnName("Bai_zak")
                    .HasMaxLength(10);

                entity.Property(e => e.Category).HasDefaultValueSql("((1))");

                entity.Property(e => e.DataEk)
                    .HasColumnName("Data_ek")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEk2)
                    .HasColumnName("Data_ek2")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEn)
                    .HasColumnName("Data_en")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFin)
                    .HasColumnName("Data_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFint)
                    .HasColumnName("Data_fint")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFintp)
                    .HasColumnName("Data_fintp")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataKon)
                    .HasColumnName("Data_kon")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataNorm)
                    .HasColumnName("Data_norm")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataPlant)
                    .HasColumnName("Data_plant")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataResiveEcbs)
                    .HasColumnName("Data_resiveEcbs")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataRsbs)
                    .HasColumnName("Data_RSBS")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSendEcbs)
                    .HasColumnName("Data_sendEcbs")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSk)
                    .HasColumnName("Data_sk")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSt)
                    .HasColumnName("Data_st")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataTech)
                    .HasColumnName("Data_tech")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataTechWeld)
                    .HasColumnName("Data_tech_weld")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataVkon)
                    .HasColumnName("Data_vkon")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataZak)
                    .HasColumnName("Data_zak")
                    .HasColumnType("datetime");

                entity.Property(e => e.Det).HasMaxLength(50);

                entity.Property(e => e.FlagVes).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdnoticePack)
                    .HasColumnName("IDNoticePack")
                    .HasComment("[HIST.ST_HIST].IDREC связь с извещением на упаковку");

                entity.Property(e => e.NewIzd).HasDefaultValueSql("((1))");

                entity.Property(e => e.Prim).HasMaxLength(250);

                entity.Property(e => e.Stage).HasComment("1 - извещение в работе; 2 - согласование; 3 - техподготовка; 4 - производство");

                entity.Property(e => e.TextVes).HasMaxLength(50);

                entity.Property(e => e.UtvEk).HasColumnName("Utv_ek");

                entity.Property(e => e.UtvEk2)
                    .HasColumnName("Utv_ek2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UtvEn).HasColumnName("Utv_en");

                entity.Property(e => e.UtvKon).HasColumnName("Utv_kon");

                entity.Property(e => e.UtvNorm)
                    .HasColumnName("Utv_norm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UtvPlant).HasColumnName("Utv_plant");

                entity.Property(e => e.UtvRsbs).HasColumnName("Utv_RSBS");

                entity.Property(e => e.UtvSk).HasColumnName("Utv_sk");

                entity.Property(e => e.UtvTech).HasColumnName("Utv_tech");

                entity.Property(e => e.UtvTechWeld)
                    .HasColumnName("Utv_tech_weld")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UtvVkon).HasColumnName("Utv_vkon");

                entity.Property(e => e.UtvZak).HasColumnName("Utv_zak");

                entity.Property(e => e.Zamech).HasColumnType("ntext");

                entity.Property(e => e.ZamechId).HasColumnName("Zamech_id");
            });

            modelBuilder.Entity<RedSpecHistArchive>(entity =>
            {
                entity.HasKey(e => e.IdSpec);

                entity.ToTable("Red.SpecHistArchive");

                entity.Property(e => e.IdSpec).ValueGeneratedNever();

                entity.Property(e => e.BaiEcbs)
                    .HasColumnName("Bai_Ecbs")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiEk)
                    .HasColumnName("Bai_ek")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiEn)
                    .HasColumnName("Bai_en")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiKon)
                    .HasColumnName("Bai_kon")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiNorm)
                    .HasColumnName("Bai_norm")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiPlant)
                    .HasColumnName("Bai_plant")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiSk)
                    .HasColumnName("Bai_sk")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiTech)
                    .HasColumnName("Bai_tech")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiVkon)
                    .HasColumnName("Bai_vkon")
                    .HasMaxLength(10);

                entity.Property(e => e.BaiZak)
                    .HasColumnName("Bai_zak")
                    .HasMaxLength(10);

                entity.Property(e => e.Category).HasDefaultValueSql("((1))");

                entity.Property(e => e.DataEk)
                    .HasColumnName("Data_ek")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEn)
                    .HasColumnName("Data_en")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFin)
                    .HasColumnName("Data_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFint)
                    .HasColumnName("Data_fint")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFintp)
                    .HasColumnName("Data_fintp")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataKon)
                    .HasColumnName("Data_kon")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataNorm)
                    .HasColumnName("Data_norm")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataPlant)
                    .HasColumnName("Data_plant")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataResiveEcbs)
                    .HasColumnName("Data_resiveEcbs")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSendEcbs)
                    .HasColumnName("Data_sendEcbs")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSk)
                    .HasColumnName("Data_sk")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSt)
                    .HasColumnName("Data_st")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataTech)
                    .HasColumnName("Data_tech")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataVkon)
                    .HasColumnName("Data_vkon")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataZak)
                    .HasColumnName("Data_zak")
                    .HasColumnType("datetime");

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.FlagVes).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewIzd).HasDefaultValueSql("((1))");

                entity.Property(e => e.Prim).HasMaxLength(250);

                entity.Property(e => e.TextVes).HasMaxLength(50);

                entity.Property(e => e.UtvEk).HasColumnName("Utv_ek");

                entity.Property(e => e.UtvEn).HasColumnName("Utv_en");

                entity.Property(e => e.UtvKon).HasColumnName("Utv_kon");

                entity.Property(e => e.UtvNorm)
                    .HasColumnName("Utv_norm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UtvPlant).HasColumnName("Utv_plant");

                entity.Property(e => e.UtvSk).HasColumnName("Utv_sk");

                entity.Property(e => e.UtvTech).HasColumnName("Utv_tech");

                entity.Property(e => e.UtvVkon).HasColumnName("Utv_vkon");

                entity.Property(e => e.UtvZak).HasColumnName("Utv_zak");

                entity.Property(e => e.Zamech).HasColumnType("ntext");

                entity.Property(e => e.ZamechId).HasColumnName("Zamech_id");
            });

            modelBuilder.Entity<RedSpecHistDop>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Red.SpecHistDop");

                entity.HasIndex(e => new { e.IdSpec, e.IdGood })
                    .HasDatabaseName("IX_Red.SpecHistDop")
                    .IsUnique();
            });

            modelBuilder.Entity<RedSpecHistSogl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Red.SpecHistSogl");

                entity.HasIndex(e => new { e.IdSpec, e.IdIzgot })
                    .HasDatabaseName("IX_Red.SpecHistSogl")
                    .IsUnique();

                entity.Property(e => e.DataFint)
                    .HasColumnName("Data_fint")
                    .HasColumnType("datetime")
                    .HasComment("Дата передачи изв. на производство на др. площадке");

                entity.Property(e => e.DataPlant)
                    .HasColumnName("Data_plant")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSk)
                    .HasColumnName("Data_sk")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataTech)
                    .HasColumnName("Data_tech")
                    .HasColumnType("datetime");

                entity.Property(e => e.UtvPlant).HasColumnName("Utv_plant");

                entity.Property(e => e.UtvSk).HasColumnName("Utv_sk");

                entity.Property(e => e.UtvTech).HasColumnName("Utv_tech");
            });

            modelBuilder.Entity<RedSpecReestr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Red.SpecReestr");

                entity.HasIndex(e => new { e.IdSpec, e.Det, e.TypCh })
                    .HasDatabaseName("IX_Red.SpecReestr")
                    .IsUnique();

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ExtEng)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ExtOn)
                    .HasColumnName("ExtON")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ExtPr)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FileEng).HasColumnType("image");

                entity.Property(e => e.FileOn)
                    .HasColumnName("FileON")
                    .HasColumnType("image");

                entity.Property(e => e.FilePr).HasColumnType("image");

                entity.Property(e => e.TypCh)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'Ч')");
            });

            modelBuilder.Entity<RedSpecSource>(entity =>
            {
                entity.ToTable("Red.SpecSource");

                entity.HasIndex(e => new { e.IdSource, e.IdSpec })
                    .HasDatabaseName("IX_Red.SpecSource_Column")
                    .IsUnique();
            });

            modelBuilder.Entity<RedSpecSourceList>(entity =>
            {
                entity.HasKey(e => e.IdSource)
                    .HasName("PK__Red.Spec__AE5E01B915A5B037");

                entity.ToTable("Red.SpecSourceList");

                entity.Property(e => e.Descr).HasMaxLength(50);
            });

            modelBuilder.Entity<RepReportEmails>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.FactoryId })
                    .HasName("PK_rep_ReportEMails_1");

                entity.ToTable("rep_ReportEMails");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.SendToList)
                    .IsRequired()
                    .HasColumnName("SendTo_List");
            });

            modelBuilder.Entity<RepReportParams>(entity =>
            {
                entity.HasKey(e => new { e.ParamName, e.ReportId })
                    .HasName("PK_rep_ReportParams_1");

                entity.ToTable("rep_ReportParams");

                entity.Property(e => e.ParamName).HasMaxLength(50);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<RepReportQueries>(entity =>
            {
                entity.HasKey(e => new { e.QueryId, e.ReportId });

                entity.ToTable("rep_ReportQueries");

                entity.Property(e => e.QueryId)
                    .HasColumnName("QueryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.DetailQueryId).HasColumnName("DetailQueryID");

                entity.Property(e => e.ExcelRange).HasMaxLength(50);

                entity.Property(e => e.KeyId)
                    .HasColumnName("KeyID")
                    .HasMaxLength(255);

                entity.Property(e => e.QueryName).HasMaxLength(50);
            });

            modelBuilder.Entity<RepReports>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("rep_Reports");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ReportName).HasMaxLength(50);

                entity.Property(e => e.ReportPath).HasMaxLength(150);
            });

            modelBuilder.Entity<ResourseExpense>(entity =>
            {
                entity.HasIndex(e => e.Idresourse)
                    .HasDatabaseName("IDResourse");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateExpense).HasColumnType("date");

                entity.Property(e => e.Idresourse).HasColumnName("IDResourse");
            });

            modelBuilder.Entity<ScanFactory>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("scan.Factory");

                entity.Property(e => e.UserName).HasMaxLength(150);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");
            });

            modelBuilder.Entity<ScanProduction>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.Id });

                entity.ToTable("scan.Production");

                entity.Property(e => e.UserName).HasMaxLength(150);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Articul).HasMaxLength(50);

                entity.Property(e => e.Count).HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DopCode)
                    .HasColumnName("Dop_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.ZPos)
                    .HasColumnName("zPos")
                    .HasMaxLength(50);

                entity.Property(e => e.Zakaz).HasMaxLength(50);

                entity.Property(e => e.Zone).HasMaxLength(50);
            });

            modelBuilder.Entity<ScanScaners>(entity =>
            {
                entity.ToTable("scan.Scaners");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FactoryId)
                    .HasColumnName("FactoryID")
                    .HasDefaultValueSql("((39))");

                entity.Property(e => e.Login).HasMaxLength(250);

                entity.Property(e => e.Password).HasMaxLength(250);
            });

            modelBuilder.Entity<ScanVersion>(entity =>
            {
                entity.HasKey(e => e.AppName);

                entity.ToTable("scan.Version");

                entity.HasIndex(e => e.AppName)
                    .HasDatabaseName("IX_scan.Version")
                    .IsUnique();

                entity.Property(e => e.AppName)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ScanerError>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("Scaner_Error");

                entity.Property(e => e.RecId).HasColumnName("RecID");

                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Err).HasMaxLength(1000);

                entity.Property(e => e.FactoryId)
                    .HasColumnName("FactoryID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Params).HasMaxLength(2000);
            });

            modelBuilder.Entity<SecDopusk>(entity =>
            {
                entity.HasKey(e => e.Kod);

                entity.ToTable("Sec.Dopusk");

                entity.Property(e => e.Kod).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SecUser>(entity =>
            {
                entity.ToTable("SEC.USER");

                entity.HasIndex(e => e.UserPrim)
                    .HasDatabaseName("SEC.USER_UQ1")
                    .IsUnique();

                entity.Property(e => e.IdIzgot).HasComment("код площадки");

                entity.Property(e => e.LastLoggedIn).HasColumnType("datetime");

                entity.Property(e => e.Tab).HasComment("Единый табельный номер сотрудника");

                entity.Property(e => e.UserAsup)
                    .IsRequired()
                    .HasColumnName("User_asup")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .HasComment("имя пользователя в системе АРКАСУП");

                entity.Property(e => e.UserGroup)
                    .HasColumnName("User_group")
                    .HasDefaultValueSql("((99))")
                    .HasComment("id группы пользователя из Sec.Dopusk");

                entity.Property(e => e.UserPrim)
                    .IsRequired()
                    .HasColumnName("User_prim")
                    .HasMaxLength(100)
                    .HasComment("имя пользователя в системе asp.net");
            });

            modelBuilder.Entity<SecUserPas>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("USER_PAS_PK");

                entity.ToTable("SEC.USER_PAS");

                entity.HasIndex(e => e.Hid)
                    .HasDatabaseName("IX_SEC.USER_PAS_1")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasDatabaseName("USER_PAS_IX1");

                entity.HasIndex(e => e.User)
                    .HasDatabaseName("USER_PAS_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Dopusk)
                    .HasColumnName("DOPUSK")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraAccess).HasColumnName("EXTRA_ACCESS");

                entity.Property(e => e.Hid).HasColumnName("HID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kod)
                    .HasColumnName("KOD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.KodZon)
                    .HasColumnName("KOD_ZON")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Lang)
                    .HasColumnName("LANG")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ObjName)
                    .HasColumnName("OBJ_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Otv)
                    .HasColumnName("OTV")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Qut).HasColumnName("QUT");

                entity.Property(e => e.Red).HasColumnName("RED");

                entity.Property(e => e.TimeActive)
                    .HasColumnName("TIME_ACTIVE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeIn)
                    .HasColumnName("TIME_IN")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut)
                    .HasColumnName("TIME_OUT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ur)
                    .HasColumnName("UR")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecUserPasCopy>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("USER_PAS_PK_Copy");

                entity.ToTable("SEC.USER_PAS_Copy");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedNever();

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Dopusk)
                    .HasColumnName("DOPUSK")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraAccess).HasColumnName("EXTRA_ACCESS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kod)
                    .HasColumnName("KOD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.KodZon)
                    .HasColumnName("KOD_ZON")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Lang).HasColumnName("LANG");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ObjName)
                    .HasColumnName("OBJ_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Otv)
                    .HasColumnName("OTV")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Qut).HasColumnName("QUT");

                entity.Property(e => e.Red).HasColumnName("RED");

                entity.Property(e => e.TimeActive)
                    .HasColumnName("TIME_ACTIVE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeIn)
                    .HasColumnName("TIME_IN")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut)
                    .HasColumnName("TIME_OUT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ur)
                    .HasColumnName("UR")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SecUserPass>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("Sec.UserPass");

                entity.HasIndex(e => e.User)
                    .HasDatabaseName("IX_Sec.UserPass");

                entity.Property(e => e.Dopusk)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.IdMainIzgot).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsAllowId).HasDefaultValueSql("(0)");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.KodPass).HasMaxLength(40);

                entity.Property(e => e.LogDir)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NLang)
                    .HasColumnName("nLang")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Otv)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.TimeActive)
                    .HasColumnName("Time_active")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ur).HasDefaultValueSql("(11)");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SecUserRights>(entity =>
            {
                entity.HasKey(e => new { e.ObjectName, e.IdGroup })
                    .HasName("SEC.USER_RIGHT_PK");

                entity.ToTable("SEC.USER_RIGHTS");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("OBJECT_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.IdGroup).HasColumnName("ID_GROUP");

                entity.Property(e => e.AccessFlags).HasColumnName("ACCESS_FLAGS");
            });

            modelBuilder.Entity<SecUserserv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SEC.USERSERV");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.PathMain)
                    .HasColumnName("path_main")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Userdnsdomain)
                    .HasColumnName("USERDNSDOMAIN")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ServiceUseAction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ActionNameBrief)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ServiceUseJournal>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateTimeAction).HasColumnType("datetime");

                entity.Property(e => e.Idaction).HasColumnName("IDAction");

                entity.Property(e => e.Idperson).HasColumnName("IDPerson");

                entity.Property(e => e.IdtableRight).HasColumnName("IDTableRight");
            });

            modelBuilder.Entity<ServiceUsePersonRight>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idperson).HasColumnName("IDPerson");
            });

            modelBuilder.Entity<ServiceUseProduction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sessions>(entity =>
            {
                entity.HasKey(e => e.Token)
                    .HasName("Sessions_PK");

                entity.ToTable("Sessions", "webcmd");

                entity.Property(e => e.Token)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Hid).HasColumnName("HID");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Roles)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SkladSklHist>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("SKL_HIST_PK");

                entity.ToTable("SKLAD.SKL_HIST");

                entity.HasIndex(e => new { e.Articul, e.DopCod })
                    .HasDatabaseName("SKL_HIST_IX1");

                entity.HasIndex(e => new { e.Start, e.Tara })
                    .HasDatabaseName("SKL_HIST_IX4");

                entity.HasIndex(e => new { e.Tara, e.Articul, e.DopCod })
                    .HasDatabaseName("SKL_HIST_IX5");

                entity.HasIndex(e => new { e.NSub, e.Articul, e.DopCod, e.OrderNo })
                    .HasDatabaseName("SKL_HIST_IX2");

                entity.HasIndex(e => new { e.NSub, e.Num, e.NRekl, e.Kodizgot, e.Idizgot, e.Articul, e.DopCod, e.Delrecord })
                    .HasDatabaseName("SKL_HIST_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(40);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kodizgot)
                    .HasColumnName("KODIZGOT")
                    .HasMaxLength(4);

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.NPr)
                    .HasColumnName("N_PR")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.NRekl)
                    .HasColumnName("N_REKL")
                    .HasMaxLength(40);

                entity.Property(e => e.NSdal)
                    .HasColumnName("N_SDAL")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.OrderNo).HasMaxLength(50);

                entity.Property(e => e.Prn)
                    .HasColumnName("PRN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Start)
                    .HasColumnName("START")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tara)
                    .HasColumnName("TARA")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SkladSklHist11>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("SKL_HIST_1_PK");

                entity.ToTable("SKLAD.SKL_HIST_11");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.NPr)
                    .HasColumnName("N_PR")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.NSdal)
                    .HasColumnName("N_SDAL")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Prn).HasColumnName("PRN");

                entity.Property(e => e.Start)
                    .HasColumnName("START")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tara)
                    .HasColumnName("TARA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Usr)
                    .HasColumnName("USR")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SkladSklad>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("SKLAD_PK");

                entity.ToTable("SKLAD.SKLAD");

                entity.HasIndex(e => new { e.Articul, e.DopCod, e.Tara })
                    .HasDatabaseName("SKLAD_IX1");

                entity.HasIndex(e => new { e.NSub, e.Articul, e.DopCod })
                    .HasDatabaseName("SKLAD_IX2");

                entity.HasIndex(e => new { e.Tara, e.Articul, e.DopCod })
                    .HasDatabaseName("SKLAD_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Tara)
                    .HasColumnName("TARA")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SkladSklad1>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("SKLAD__PK");

                entity.ToTable("SKLAD.SKLAD_");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("NUM")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Tara)
                    .HasColumnName("TARA")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpecialRights>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idfunction)
                    .HasColumnName("IDFunction")
                    .HasComment("Functionality.IDREC");

                entity.Property(e => e.Idperson)
                    .HasColumnName("IDPerson")
                    .HasComment("[HR.IND_KART].IDREC");
            });

            modelBuilder.Entity<SpecificationCompleteTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SpecificationComplete_tmp");

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Lit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PositionQuantity).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<SpecificationNotice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeInfo)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasComment("");

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idspec).HasColumnName("IDSpec");

                entity.Property(e => e.NoticePositionType).HasComment("1 - спецификация; 2 - чертеж");
            });

            modelBuilder.Entity<SpecificationNoticeComments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Idspec).HasColumnName("IDSpec");
            });

            modelBuilder.Entity<SpecificationNoticeEmailMissing>(entity =>
            {
                entity.ToTable("SpecificationNoticeEMailMissing");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addresses).HasMaxLength(3500);

                entity.Property(e => e.Idperson).HasColumnName("IDPerson");

                entity.Property(e => e.MessageText).HasMaxLength(2000);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<SpecificationOperationsLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOperation).HasColumnType("datetime");

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idspec).HasColumnName("IDSpec");

                entity.Property(e => e.Node)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperationType).HasComment("1 - добавление; 2 - изменение; 3 - удаление");

                entity.Property(e => e.ParameterType).HasComment("1 - порядковый № позиции в спецификации; 2 - количество позиции в узле");

                entity.Property(e => e.ParameterValueIs)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterValueWas)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpecificationReplacement>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailAlt)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("table1", "fortests");

                entity.Property(e => e.Group)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InvNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TabloCfg>(entity =>
            {
                entity.ToTable("Tablo.Cfg");

                entity.HasIndex(e => e.IdTablo)
                    .HasDatabaseName("IX_Tablo.Cfg_Column")
                    .IsUnique();

                entity.Property(e => e.FontSize).HasDefaultValueSql("((3))");

                entity.Property(e => e.IdGroupTablo).HasMaxLength(50);

                entity.Property(e => e.IdTablo).HasMaxLength(50);

                entity.Property(e => e.Interval).HasDefaultValueSql("((10))");

                entity.Property(e => e.KodIzgot).HasMaxLength(4);

                entity.Property(e => e.KolStr).HasDefaultValueSql("((19))");

                entity.Property(e => e.Pole1).HasDefaultValueSql("((1))");

                entity.Property(e => e.Pole2).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TaskList>(entity =>
            {
                entity.HasKey(e => e.ProcedureName)
                    .HasName("PK__TaskList__3950E7D5C32E58AF");

                entity.ToTable("TaskList", "service");

                entity.Property(e => e.ProcedureName)
                    .HasMaxLength(100)
                    .HasComment("Имя процедуры");

                entity.Property(e => e.Active).HasComment("Признак того, что задачу нужно выполнять");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasComment("Описание");

                entity.Property(e => e.EveryMinute)
                    .HasDefaultValueSql("((60))")
                    .HasComment("Выполнять каждые N минут");

                entity.Property(e => e.ExecTime)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Время выполнения");

                entity.Property(e => e.IsRunning).HasComment("Признак того, что задача выполняется в данный момент");

                entity.Property(e => e.LastError)
                    .HasMaxLength(100)
                    .HasComment("Описание последней ошибки");

                entity.Property(e => e.LastRun)
                    .HasColumnType("datetime")
                    .HasComment("Дата/время последнего запуска");
            });

            modelBuilder.Entity<TasksAndMessages>(entity =>
            {
                entity.HasComment("Сообщения и задачи для пользователей и групп");

                entity.HasIndex(e => new { e.ToUserId, e.Type, e.UntilDate, e.Done })
                    .HasDatabaseName("TasksAndMessages_Done");

                entity.Property(e => e.Author).HasComment("Автор задания/сообщения");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.Done)
                    .HasColumnType("datetime")
                    .HasComment("Дата выполнения");

                entity.Property(e => e.Message)
                    .IsUnicode(false)
                    .HasComment("Сообщение");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Статус: 0 - не прочитано, 1 - прочитано");

                entity.Property(e => e.ToUserGroup)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Адресат (группа или список групп через запятую). Если не указана, значит всем");

                entity.Property(e => e.ToUserId)
                    .HasColumnName("ToUserID")
                    .HasComment("Адресат (пользователь). Если не указан, то значит адресат - группа.");

                entity.Property(e => e.Type)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Тип: 2 - новость, 1 - задача, 0 - сообщение");

                entity.Property(e => e.UntilDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Срок действия (дата исчезания сообщения)");
            });

            modelBuilder.Entity<TechCells>(entity =>
            {
                entity.ToTable("TECH.Cells");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<TechComplD>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("COMPL_D_PK");

                entity.ToTable("TECH.COMPL_D");

                entity.HasIndex(e => new { e.Kol, e.Complect, e.Det, e.Delrecord })
                    .HasDatabaseName("COMPL_D_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Complect)
                    .HasColumnName("COMPLECT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datachange)
                    .HasColumnName("DATACHANGE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.LastOper)
                    .HasColumnName("LAST_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(7, 4)");
            });

            modelBuilder.Entity<TechComplect>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("COMPLECT_PK");

                entity.ToTable("TECH.COMPLECT");

                entity.HasIndex(e => e.Complect)
                    .HasDatabaseName("COMPLECT_IX1");

                entity.HasIndex(e => new { e.Tim, e.Idizgot, e.KodIzgot, e.Complect, e.Delrecord })
                    .HasDatabaseName("COMPLECT_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Complect)
                    .HasColumnName("COMPLECT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datachange)
                    .HasColumnName("DATACHANGE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialType).HasColumnName("MATERIAL_TYPE");

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityMaterial)
                    .HasColumnName("QUANTITY_MATERIAL")
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Норма расхода материала на 1 комплект");

                entity.Property(e => e.SquareComplect)
                    .HasColumnName("SQUARE_COMPLECT")
                    .HasColumnType("decimal(10, 6)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Площадь комплекта");

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(7, 4)");
            });

            modelBuilder.Entity<TechCompon>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("COMPON_PK_TECH.COMPON_0103");

                entity.ToTable("TECH.COMPON");

                entity.HasIndex(e => e.Component)
                    .HasDatabaseName("COMPON_IX1");

                entity.HasIndex(e => new { e.Component, e.Idrec, e.Idizgot, e.KodIzgot, e.Delrecord })
                    .HasDatabaseName("ActualComponentsByStructure");

                entity.HasIndex(e => new { e.Tim, e.Log, e.Idizgot, e.KodIzgot, e.Component, e.Delrecord, e.Oper })
                    .HasDatabaseName("COMPON_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Component)
                    .HasColumnName("COMPONENT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.HidePosition)
                    .HasColumnName("HIDE_POSITION")
                    .HasComment("Скрыть в списке деталей для участка = 1");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.KolCom)
                    .HasColumnName("KOL_COM")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.KolK)
                    .HasColumnName("KOL_K")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Log).HasColumnName("LOG");

                entity.Property(e => e.MaterialType).HasColumnName("MATERIAL_TYPE");

                entity.Property(e => e.Oper)
                    .HasColumnName("OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.QuantityMaterial)
                    .HasColumnName("QUANTITY_MATERIAL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SquareComponent)
                    .HasColumnName("SQUARE_COMPONENT")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Takt)
                    .HasColumnName("TAKT")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.UpCod)
                    .HasColumnName("UP_COD")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechComponSections>(entity =>
            {
                entity.HasKey(e => e.Idrec);

                entity.ToTable("TECH.COMPON_SECTIONS");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Idcomponent)
                    .HasColumnName("IDComponent")
                    .HasComment("IDREC in TECH.COMPON");

                entity.Property(e => e.Idsection)
                    .HasColumnName("IDSection")
                    .HasComment("IDREC in TECH.ST_IZG");
            });

            modelBuilder.Entity<TechComponTechproc>(entity =>
            {
                entity.HasKey(e => e.Idrec);

                entity.ToTable("TECH.COMPON_TECHPROC");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Idcompon)
                    .HasColumnName("IDCompon")
                    .HasComment("[TECH.COMPON].IDREC");

                entity.Property(e => e.IdtechProc)
                    .HasColumnName("IDTechProc")
                    .HasComment("[TECH.DET_AP].IDREC");
            });

            modelBuilder.Entity<TechDetAp>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("DET_AP__PK");

                entity.ToTable("TECH.DET_AP");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("Detail");

                entity.HasIndex(e => e.Operaciya)
                    .HasDatabaseName("Operation");

                entity.HasIndex(e => new { e.AsVyvod, e.Idizgot, e.Delrecord })
                    .HasDatabaseName("ActualTPByUnit");

                entity.HasIndex(e => new { e.AsVvod, e.AsVyvod, e.Det, e.Idizgot })
                    .HasDatabaseName("det_ap1");

                entity.HasIndex(e => new { e.AsVyvod, e.Idizgot, e.KodIzgot, e.Delrecord })
                    .HasDatabaseName("ActualTPByStructure");

                entity.HasIndex(e => new { e.AsVyvod, e.Det, e.Idizgot, e.Delrecord, e.Operaciya })
                    .HasDatabaseName("DET_AP");

                entity.HasIndex(e => new { e.Datsavesql, e.Operaciya, e.Idizgot, e.Det, e.NppOper, e.AsVyvod, e.Delrecord })
                    .HasDatabaseName("DET_AP_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Advance)
                    .HasColumnName("ADVANCE")
                    .HasComment("Упреждение в днях относительно планируемой даты изготовления изделия");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.DataRaz)
                    .HasColumnName("DATA_RAZ")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdVr)
                    .HasColumnName("ED_VR")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Flagokr).HasColumnName("FLAGOKR");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.KodOb)
                    .HasColumnName("KOD_OB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Koid)
                    .HasColumnName("KOID")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Label)
                    .HasColumnName("LABEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Operaciya)
                    .HasColumnName("OPERACIYA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlOkr)
                    .HasColumnName("PL_OKR")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Prizn)
                    .HasColumnName("PRIZN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Prof)
                    .HasColumnName("PROF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Razr)
                    .HasColumnName("RAZR")
                    .HasColumnType("decimal(5, 3)");

                entity.Property(e => e.Sod)
                    .HasColumnName("SOD")
                    .IsUnicode(false);

                entity.Property(e => e.Sod1)
                    .HasColumnName("SOD_1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Typework)
                    .HasColumnName("TYPEWORK")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechDetAp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TECH.DET_AP_1");

                entity.Property(e => e.Advance)
                    .HasColumnName("ADVANCE")
                    .HasComment("Упреждение в днях относительно планируемой даты изготовления изделия");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.DataRaz)
                    .HasColumnName("DATA_RAZ")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EdVr)
                    .HasColumnName("ED_VR")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Flagokr).HasColumnName("FLAGOKR");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.KodOb)
                    .HasColumnName("KOD_OB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Koid)
                    .HasColumnName("KOID")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Label)
                    .HasColumnName("LABEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Operaciya)
                    .HasColumnName("OPERACIYA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlOkr)
                    .HasColumnName("PL_OKR")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Prizn)
                    .HasColumnName("PRIZN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Prof)
                    .HasColumnName("PROF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Razr)
                    .HasColumnName("RAZR")
                    .HasColumnType("decimal(5, 3)");

                entity.Property(e => e.Sod)
                    .HasColumnName("SOD")
                    .IsUnicode(false);

                entity.Property(e => e.Sod1)
                    .HasColumnName("SOD_1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Typework)
                    .HasColumnName("TYPEWORK")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechDetApAdd>(entity =>
            {
                entity.ToTable("TECH.DET_AP_ADD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idcell)
                    .HasColumnName("IDCell")
                    .HasComment("[TECH.ST_IZG].IDREC");

                entity.Property(e => e.Iddetail)
                    .HasColumnName("IDDetail")
                    .HasComment("[TECH.ST_IZG].IDREC");

                entity.Property(e => e.Idequipment)
                    .HasColumnName("IDEquipment")
                    .HasComment("[TECH.MACH].IDREC");

                entity.Property(e => e.Idoperation)
                    .HasColumnName("IDOperation")
                    .HasComment("[TECH.ST_OPER].IDREC");

                entity.Property(e => e.Idunit)
                    .HasColumnName("IDUnit")
                    .HasDefaultValueSql("((39))")
                    .HasComment("Код площадки: 39 - Сосенки; 44 - Тула; 42 - Болгария");

                entity.Property(e => e.OperationNumber).HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Timing).HasColumnType("decimal(10, 4)");
            });

            modelBuilder.Entity<TechDetApAs>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("DET_AP_AS1_PK");

                entity.ToTable("TECH.DET_AP_AS");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("DET_AP_AS1_IX1");

                entity.HasIndex(e => new { e.Det, e.DetAs })
                    .HasDatabaseName("DET_AP_AS1_IX2");

                entity.HasIndex(e => new { e.Det, e.DetAs, e.Row })
                    .HasDatabaseName("DET_AP_AS1_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DetAs)
                    .HasColumnName("DET_AS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Izd)
                    .HasColumnName("IZD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IzdNam)
                    .HasColumnName("IZD_NAM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Row).HasColumnName("ROW");
            });

            modelBuilder.Entity<TechDetApdata>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TECH.DET_APDATA");

                entity.HasIndex(e => new { e.Det, e.As, e.IdIzgot })
                    .HasDatabaseName("IX_TECH.DET_APDATA")
                    .IsUnique();

                entity.Property(e => e.As).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.DateChange).HasColumnType("datetime");

                entity.Property(e => e.Det)
                    .HasMaxLength(50)
                    .HasComment("Признак того, что Poka-Yoke отображается в развертке");

                entity.Property(e => e.Ext).HasMaxLength(6);

                entity.Property(e => e.IdIzgot).HasDefaultValueSql("((39))");

                entity.Property(e => e.Pytool).HasColumnName("PYTool");

                entity.Property(e => e.RazData).HasColumnType("image");
            });

            modelBuilder.Entity<TechDetIzm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TECH.DET_IZM");

                entity.Property(e => e.As)
                    .HasColumnName("AS")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsMaxNew)
                    .HasColumnName("as_max_new")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsMaxOld)
                    .HasColumnName("as_max_old")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsSmchMax)
                    .HasColumnName("as_smch_max")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsSmchMaxNew)
                    .HasColumnName("as_smch_max_new")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsSmchMaxOld)
                    .HasColumnName("as_smch_max_old")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Dbenennung)
                    .HasColumnName("DBENENNUNG")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsDocDxf)
                    .HasColumnName("isDocDxf")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Kem)
                    .HasColumnName("kem")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.KemDataFin)
                    .HasColumnName("kemData_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.KemDataSt)
                    .HasColumnName("kemData_st")
                    .HasColumnType("datetime");

                entity.Property(e => e.KemDet)
                    .HasColumnName("kemDET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KemIdGood).HasColumnName("kemIdGood");

                entity.Property(e => e.KemIdIzgot).HasColumnName("kemIdIzgot");

                entity.Property(e => e.KemIdSpec).HasColumnName("kemIdSpec");

                entity.Property(e => e.KemNewIzd).HasColumnName("kemNewIzd");

                entity.Property(e => e.Kemart)
                    .HasColumnName("kemart")
                    .HasMaxLength(15);

                entity.Property(e => e.Kemnam)
                    .HasColumnName("kemnam")
                    .HasMaxLength(100);

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ob)
                    .HasColumnName("OB")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.RazData)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Smch)
                    .HasColumnName("SMCH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Typeizm)
                    .HasColumnName("typeizm")
                    .HasMaxLength(15);

                entity.Property(e => e.Typework)
                    .HasColumnName("TYPEWORK")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechDetOsn>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("DET_OSN_PK");

                entity.ToTable("TECH.DET_OSN_");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("DET");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Keyosn)
                    .HasColumnName("KEYOSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nomosn)
                    .HasColumnName("NOMOSN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NormRash)
                    .HasColumnName("NORM_RASH")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Osn)
                    .HasColumnName("OSN")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechDetOsnb>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("DET_OSNB_PK");

                entity.ToTable("TECH.DET_OSNB_");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Keyosn)
                    .HasColumnName("KEYOSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nomosn)
                    .HasColumnName("NOMOSN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NormRash)
                    .HasColumnName("NORM_RASH")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Osn)
                    .HasColumnName("OSN")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechDocExp>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("DOC_EXP_PK");

                entity.ToTable("TECH.DOC_EXP");

                entity.HasIndex(e => e.Doc)
                    .HasDatabaseName("DOC_EXP_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateB)
                    .HasColumnName("DATE_B")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Doc)
                    .HasColumnName("DOC")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idsegment).HasColumnName("IDSegment");
            });

            modelBuilder.Entity<TechDocExpIzg>(entity =>
            {
                entity.ToTable("TECH.DOC_EXP_IZG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdexpWork).HasColumnName("IDExpWork");

                entity.Property(e => e.IdizgDay).HasColumnName("IDIzgDay");
            });

            modelBuilder.Entity<TechDocExpSegment>(entity =>
            {
                entity.ToTable("TECH.DOC_EXP_SEGMENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idparent).HasColumnName("IDParent");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Unit).HasDefaultValueSql("((39))");
            });

            modelBuilder.Entity<TechEkDet>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("EK_DET_PK");

                entity.ToTable("TECH.EK_DET");

                entity.HasIndex(e => new { e.Det, e.KodIzgot })
                    .HasDatabaseName("EK_DET_IX1");

                entity.HasIndex(e => new { e.KodIzgot, e.Mash })
                    .HasDatabaseName("EK_DET_IX2");

                entity.HasIndex(e => new { e.Det, e.KodIzgot, e.Mash, e.Brigada, e.Data })
                    .HasDatabaseName("EK_DET_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Brigada)
                    .HasColumnName("BRIGADA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DopTim)
                    .HasColumnName("DOP_TIM")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MashTim)
                    .HasColumnName("MASH_TIM")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(10, 5)");
            });

            modelBuilder.Entity<TechInstructionTechProcess>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("InstructionTechProcess_PK");

                entity.ToTable("TECH.InstructionTechProcess");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdInstr).HasColumnName("ID_Instr");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");
            });

            modelBuilder.Entity<TechInstructions>(entity =>
            {
                entity.ToTable("TECH.Instructions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TechInstructionsArticles>(entity =>
            {
                entity.ToTable("TECH.InstructionsArticles");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Article)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Idnotice).HasColumnName("IDNotice");
            });

            modelBuilder.Entity<TechInstructionsDetails>(entity =>
            {
                entity.ToTable("TECH.InstructionsDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Idnotice).HasColumnName("IDNotice");
            });

            modelBuilder.Entity<TechInstructionsNotices>(entity =>
            {
                entity.ToTable("TECH.InstructionsNotices");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateAgreement1).HasColumnType("date");

                entity.Property(e => e.DateAgreement2).HasColumnType("date");

                entity.Property(e => e.DateAgreement3).HasColumnType("date");

                entity.Property(e => e.DateAgreement4).HasColumnType("date");

                entity.Property(e => e.DateAgreement5).HasColumnType("date");

                entity.Property(e => e.DateDevelopmentFinish).HasColumnType("date");

                entity.Property(e => e.DateDevelopmentStart).HasColumnType("date");

                entity.Property(e => e.DateLaunch).HasColumnType("date");

                entity.Property(e => e.FileInstr).HasColumnType("image");

                entity.Property(e => e.FileInstrExtension)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Idinstr).HasColumnName("IDInstr");

                entity.Property(e => e.IdpersonAgreement1).HasColumnName("IDPersonAgreement1");

                entity.Property(e => e.IdpersonAgreement2).HasColumnName("IDPersonAgreement2");

                entity.Property(e => e.IdpersonAgreement3).HasColumnName("IDPersonAgreement3");

                entity.Property(e => e.IdpersonAgreement4).HasColumnName("IDPersonAgreement4");

                entity.Property(e => e.IdpersonAgreement5).HasColumnName("IDPersonAgreement5");

                entity.Property(e => e.NameInstr)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.NoticeDescription)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.NoticeReason).HasMaxLength(1000);

                entity.Property(e => e.NumberNotice)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductionNames).HasMaxLength(2000);
            });

            modelBuilder.Entity<TechInstrumentTechProcess>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("InstrumentTechProcess_PK");

                entity.ToTable("TECH.InstrumentTechProcess");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdInstrument).HasColumnName("ID_Instrument");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");
            });

            modelBuilder.Entity<TechInstruments>(entity =>
            {
                entity.ToTable("TECH.Instruments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idgroup).HasColumnName("IDGroup");

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<TechItemTechProcess>(entity =>
            {
                entity.ToTable("TECH.ItemTechProcess");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iditem).HasColumnName("IDItem");

                entity.Property(e => e.IdtechProc).HasColumnName("IDTechProc");
            });

            modelBuilder.Entity<TechItems>(entity =>
            {
                entity.ToTable("TECH.Items");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TechMach>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("MASH_PK");

                entity.ToTable("TECH.MACH");

                entity.HasIndex(e => e.Mash)
                    .HasDatabaseName("MASH_IX1");

                entity.HasIndex(e => new { e.Cpu, e.Mash, e.Idizgot, e.Delrecord })
                    .HasDatabaseName("MASH_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.EdVr)
                    .HasColumnName("ED_VR")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ExcludeThis)
                    .HasColumnName("EXCLUDE_THIS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ext)
                    .HasColumnName("EXT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.LaterUp)
                    .HasColumnName("LATER_UP")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Metod)
                    .HasColumnName("METOD")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechMashNn>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("MASH_NN_PK");

                entity.ToTable("TECH.MASH_NN");

                entity.HasIndex(e => e.Nn)
                    .HasDatabaseName("MASH_NN_IX4");

                entity.HasIndex(e => new { e.Mash, e.KodIzgot })
                    .HasDatabaseName("MASH_NN_IX2");

                entity.HasIndex(e => new { e.Mash, e.Nn })
                    .HasDatabaseName("MASH_NN_IX3");

                entity.HasIndex(e => new { e.KodIzgot, e.Mash, e.Nn })
                    .HasDatabaseName("MASH_NN_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Cost)
                    .HasColumnName("COST")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DataVvod)
                    .HasColumnName("DATA_VVOD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.InvNumber)
                    .HasColumnName("INV_NUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nn)
                    .HasColumnName("NN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Ressurs)
                    .HasColumnName("RESSURS")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.ZavNumber)
                    .HasColumnName("ZAV_NUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechMashNnAlt>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("MASH_NN_alt_PK");

                entity.ToTable("TECH.MASH_NN_alt");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Cost)
                    .HasColumnName("COST")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DataVvod)
                    .HasColumnName("DATA_VVOD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nn)
                    .HasColumnName("NN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Ressurs)
                    .HasColumnName("RESSURS")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.ZavNumber)
                    .HasColumnName("ZAV_NUMBER")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechMashOp>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("MASH_OP_PK");

                entity.ToTable("TECH.MASH_OP");

                entity.HasIndex(e => new { e.Mash, e.Operaciya })
                    .HasDatabaseName("MASH_OP_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Operaciya)
                    .HasColumnName("OPERACIYA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrTime).HasColumnName("PR_TIME");

                entity.Property(e => e.Priz).HasColumnName("PRIZ");

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Tool).HasColumnName("TOOL");
            });

            modelBuilder.Entity<TechMashStop>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("MASH_STOP_PK");

                entity.ToTable("TECH.MASH_STOP");

                entity.HasIndex(e => new { e.Data, e.Smena })
                    .HasDatabaseName("MASH_STOP_IX1");

                entity.HasIndex(e => new { e.Nn, e.Data, e.Smena })
                    .HasDatabaseName("MASH_STOP_IX3");

                entity.HasIndex(e => new { e.Mash, e.Nn, e.Data, e.Smena })
                    .HasDatabaseName("MASH_STOP_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kom)
                    .HasColumnName("KOM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Log).HasColumnName("LOG");

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nn)
                    .HasColumnName("NN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Priznak)
                    .HasColumnName("PRIZNAK")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TimeStop)
                    .HasColumnName("TIME_STOP")
                    .HasColumnType("decimal(10, 0)");
            });

            modelBuilder.Entity<TechMaterialArticle>(entity =>
            {
                entity.ToTable("TECH.MATERIAL_ARTICLE");

                entity.HasIndex(e => e.Idmaterial)
                    .HasDatabaseName("IDMaterial");

                entity.HasIndex(e => e.Idproduction)
                    .HasDatabaseName("IDProduction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idmaterial).HasColumnName("IDMaterial");

                entity.Property(e => e.Idproduction).HasColumnName("IDProduction");

                entity.Property(e => e.PositionType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1- материал DATA.dbo.[Номенклатура товаров поставки].[ID товара] ; 2 - операция техпроцесса [TECH.DET_AP].IDREC");
            });

            modelBuilder.Entity<TechOsnastkaAccessLevels>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("TECH.Osnastka.AccessLevels");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Accesslevel)
                    .HasColumnName("accesslevel")
                    .HasComment("0 - нет доступа; 1 - просмотр; 2 - добавление, редактирование, удаление");

                entity.Property(e => e.Functionality).HasColumnName("functionality");

                entity.Property(e => e.Role).HasColumnName("role");
            });

            modelBuilder.Entity<TechOsnastkaCheckActs>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("TECH.Osnastka.CheckActs");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Act)
                    .HasColumnName("act")
                    .HasColumnType("image");

                entity.Property(e => e.Actdate)
                    .HasColumnName("actdate")
                    .HasColumnType("date");

                entity.Property(e => e.Actnumber)
                    .HasColumnName("actnumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Acttype)
                    .IsRequired()
                    .HasColumnName("acttype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("П - поверка; Р - приемка; С - списание; (все литеры русские)");

                entity.Property(e => e.Keyitem).HasColumnName("keyitem");

                entity.Property(e => e.Keyosn).HasColumnName("keyosn");

                entity.Property(e => e.Snom)
                    .IsRequired()
                    .HasColumnName("snom")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TechOsnastkaKatCategOsn>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("TECH.Osnastka.KatCategOsn");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.TemplateForToolName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<TechOsnastkaKatOsn>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("TECH.Osnastka.KatOsn");

                entity.HasIndex(e => e.Snom)
                    .HasDatabaseName("snom")
                    .IsUnique();

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Archive)
                    .HasDefaultValueSql("((0))")
                    .HasComment("1 - оснастка в архиве.");

                entity.Property(e => e.CheckType).HasComment("0 - поверка через период; 1 - эксплуатация до износа; 2 - аттестация по эталону");

                entity.Property(e => e.Checkperiod)
                    .HasColumnName("checkperiod")
                    .HasComment("период поверки в месяцах");

                entity.Property(e => e.Composite).HasColumnName("composite");

                entity.Property(e => e.DeletedOs)
                    .HasColumnName("deletedOS")
                    .HasComment("Признак \"Удалено в программе Основные средства\"");

                entity.Property(e => e.Draftnumber1)
                    .HasColumnName("draftnumber1")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Чертежный номер детали, к-рая изготавливается с помощью сей оснастки");

                entity.Property(e => e.Draftnumber2)
                    .HasColumnName("draftnumber2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Maintool).HasColumnName("maintool");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Nom).HasColumnName("nom");

                entity.Property(e => e.Ownproduction).HasColumnName("ownproduction");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.ProductionType)
                    .HasColumnName("production_type")
                    .HasComment("1 - сейфы; 2 - мебель; 3 - двери");

                entity.Property(e => e.Snom)
                    .IsRequired()
                    .HasColumnName("snom")
                    .HasMaxLength(255);

                entity.Property(e => e.SnomAsup)
                    .HasColumnName("snom_asup")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Withoutcheck).HasColumnName("withoutcheck");
            });

            modelBuilder.Entity<TechOsnastkaKatOsnDetails>(entity =>
            {
                entity.ToTable("TECH.Osnastka.KatOsnDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DetailNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idtool)
                    .HasColumnName("IDTool")
                    .HasComment("[ASUPSQL].[dbo].[TECH.Osnastka.KatOsn].key - ID оснастки в ее каталоге");
            });

            modelBuilder.Entity<TechOsnastkaKatOsnItems>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("TECH.Osnastka.KatOsnItems");

                entity.HasIndex(e => e.Keyorder)
                    .HasDatabaseName("KeyOrder");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Checkdate)
                    .HasColumnName("checkdate")
                    .HasColumnType("date");

                entity.Property(e => e.Datediscard)
                    .HasColumnName("datediscard")
                    .HasColumnType("date");

                entity.Property(e => e.Discard).HasColumnName("discard");

                entity.Property(e => e.Fio).HasColumnName("FIO");

                entity.Property(e => e.Inventorynumber)
                    .IsRequired()
                    .HasColumnName("inventorynumber")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemIdizgot).HasColumnName("item_idizgot");

                entity.Property(e => e.Keyorder).HasColumnName("keyorder");

                entity.Property(e => e.Keyosn).HasColumnName("keyosn");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("kod_izgot")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Notified)
                    .HasColumnName("notified")
                    .HasComment("было отправлено уведомление о необходимости проведения очередной поверки");

                entity.Property(e => e.Proddate)
                    .HasColumnName("proddate")
                    .HasColumnType("date");

                entity.Property(e => e.Snom)
                    .IsRequired()
                    .HasColumnName("snom")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<TechOsnastkaKatOsnItemsDiscard>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("TECH.Osnastka.KatOsnItemsDiscard");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Fio).HasColumnName("FIO");

                entity.Property(e => e.ItemIdizgot).HasColumnName("item_idizgot");

                entity.Property(e => e.Keyitem).HasColumnName("keyitem");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasColumnName("kod_izgot")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechOsnastkaKd>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("TECH.Osnastka.KD");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.As)
                    .HasColumnName("as")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("bai")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateKd)
                    .HasColumnName("dateKD")
                    .HasColumnType("date");

                entity.Property(e => e.DocumentType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1 - конструкторские документы; 2 - технологические документы");

                entity.Property(e => e.FilenameKd)
                    .IsRequired()
                    .HasColumnName("filenameKD")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Kd)
                    .IsRequired()
                    .HasColumnName("KD")
                    .HasColumnType("image");

                entity.Property(e => e.Keyosn).HasColumnName("keyosn");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechOsnastkaOs>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("TECH.Osnastka.OS");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Cell).HasColumnName("cell");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DateAcceptance)
                    .HasColumnName("date_acceptance")
                    .HasColumnType("date");

                entity.Property(e => e.FlagDiscard).HasColumnName("flag_discard");

                entity.Property(e => e.Inventorynumber)
                    .HasColumnName("inventorynumber")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("инвентарный номер экземпляра оснастки");

                entity.Property(e => e.Keyorder).HasColumnName("keyorder");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberName)
                    .IsRequired()
                    .HasColumnName("number_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ownproduction).HasColumnName("ownproduction");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.PriceOc)
                    .HasColumnName("price_OC")
                    .HasColumnType("money")
                    .HasComment("Уточненная цена из программы \"Осн. средства\"");
            });

            modelBuilder.Entity<TechOsnastkaOsnPeriods>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TECH.Osnastka.OsnPeriods");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Datebeginfact)
                    .HasColumnName("datebeginfact")
                    .HasColumnType("date");

                entity.Property(e => e.Dateperformfact)
                    .HasColumnName("dateperformfact")
                    .HasColumnType("date");

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Keyobject)
                    .HasColumnName("keyobject")
                    .HasComment("для stage=1 SpisZakOsn.key; для stage=2 KatOsnItems.key");

                entity.Property(e => e.Keyuser).HasColumnName("keyuser");

                entity.Property(e => e.Perioddays).HasColumnName("perioddays");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.Stage)
                    .HasColumnName("stage")
                    .HasComment("1 - изготовление группы оснасток по заказу; 2 - поверка экземпляра оснастки");

                entity.Property(e => e.Statuskod)
                    .HasColumnName("statuskod")
                    .HasComment("OsnStatus.statuskod");
            });

            modelBuilder.Entity<TechOsnastkaOsnStatus>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("TECH.Osnastka.OsnStatus");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.Perioddays)
                    .HasColumnName("perioddays")
                    .HasComment("Планируемый период выполнения работ на данном этапе (в днях)");

                entity.Property(e => e.Redo)
                    .HasColumnName("redo")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.Status2)
                    .HasColumnName("status2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Statuskod).HasColumnName("statuskod");

                entity.Property(e => e.To).HasColumnName("to");

                entity.Property(e => e.To2).HasColumnName("to2");

                entity.Property(e => e.Todo)
                    .HasColumnName("todo")
                    .HasMaxLength(255);

                entity.Property(e => e.Todo2)
                    .HasColumnName("todo2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Todotxt)
                    .HasColumnName("todotxt")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TechOsnastkaPhotos>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("TECH.Osnastka.Photos");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('jpg')");

                entity.Property(e => e.Keyosn).HasColumnName("keyosn");

                entity.Property(e => e.Mainphoto).HasColumnName("mainphoto");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<TechOsnastkaRoles>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_TECH.Osnastka.Roles_");

                entity.ToTable("TECH.Osnastka.Roles");

                entity.Property(e => e.NamOsnFull).HasMaxLength(60);

                entity.Property(e => e.NamOsnShort).HasMaxLength(60);
            });

            modelBuilder.Entity<TechOsnastkaSpisZakOsn>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("TECH.Osnastka.SpisZakOsn");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Alternatesstatus).HasColumnName("alternatesstatus");

                entity.Property(e => e.Bai)
                    .HasColumnName("bai")
                    .HasMaxLength(255);

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Constructor).HasColumnName("constructor");

                entity.Property(e => e.Creator).HasColumnName("creator");

                entity.Property(e => e.Datecompletion)
                    .HasColumnName("datecompletion")
                    .HasColumnType("date");

                entity.Property(e => e.Datesdat)
                    .HasColumnName("datesdat")
                    .HasMaxLength(255);

                entity.Property(e => e.Datezak)
                    .HasColumnName("datezak")
                    .HasMaxLength(255);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Keyosn)
                    .HasColumnName("keyosn")
                    .HasComment("ID оснастки из каталога оснасток");

                entity.Property(e => e.Kol).HasColumnName("kol");

                entity.Property(e => e.Nomosn)
                    .IsRequired()
                    .HasColumnName("nomosn")
                    .HasMaxLength(255);

                entity.Property(e => e.Nomzak).HasColumnName("nomzak");

                entity.Property(e => e.Performerstep8).HasColumnName("performerstep8");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<TechPaint>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PAINT_PK");

                entity.ToTable("TECH.PAINT");

                entity.HasIndex(e => new { e.Data, e.Smena })
                    .HasDatabaseName("PAINT_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<TechPaintDet>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("PAINT_DET_PK");

                entity.ToTable("TECH.PAINT_DET");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("Detail");

                entity.HasIndex(e => new { e.Data, e.Smena, e.Det })
                    .HasDatabaseName("PAINT_DET_IX1");

                entity.HasIndex(e => new { e.Data, e.Smena, e.Idizgot, e.Delrecord })
                    .HasDatabaseName("DateTurn");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Birka40)
                    .HasColumnName("BIRKA_40")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Birka50)
                    .HasColumnName("BIRKA_50")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateB)
                    .HasColumnName("DATE_B")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTmcPaint).HasColumnName("ID_TMC_Paint");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Izdelie)
                    .HasColumnName("IZDELIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KolB)
                    .HasColumnName("KOL_B")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KolI)
                    .HasColumnName("KOL_I")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.KolZ)
                    .HasColumnName("KOL_Z")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Nn)
                    .HasColumnName("NN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Priznak)
                    .HasColumnName("PRIZNAK")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Repaint).HasColumnName("REPAINT");

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<TechStIzg>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ST_IZG_PK");

                entity.ToTable("TECH.ST_IZG");

                entity.HasIndex(e => new { e.Cell, e.Nam, e.Idrec, e.Lider, e.Vis, e.SectorType, e.Idizgot, e.Izg, e.Delrecord })
                    .HasDatabaseName("ST_IZG_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Amort)
                    .HasColumnName("AMORT")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cell)
                    .HasColumnName("CELL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Equip)
                    .HasColumnName("EQUIP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExcludeThis)
                    .HasColumnName("EXCLUDE_THIS")
                    .HasComment("Исключено из списков в техпроцессах, карточках-разрешениях");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idsql)
                    .HasColumnName("IDSQL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsZ)
                    .HasColumnName("IS_Z")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Izg)
                    .HasColumnName("IZG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KolRab)
                    .HasColumnName("KOL_RAB")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Lider)
                    .HasColumnName("LIDER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Log)
                    .HasColumnName("LOG")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nam)
                    .IsRequired()
                    .HasColumnName("NAM")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlanFilter)
                    .HasColumnName("PLAN_FILTER")
                    .HasComment("Фильтр для выборки участков - вкладок для окна Оперативное планирование производства: 1 - сейфы; 2 - мебель; 3 - двери; 12 - с+м; 13 - с+д; 23 - м+д; 123 - с+м+д");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prizn)
                    .HasColumnName("PRIZN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Proizv).HasColumnName("PROIZV");

                entity.Property(e => e.Resurs)
                    .HasColumnName("RESURS")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SectorType)
                    .HasColumnName("SECTOR_TYPE")
                    .HasComment("5 - сборка; 6 - зачистка");

                entity.Property(e => e.Ts)
                    .HasColumnName("TS")
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vis)
                    .HasColumnName("VIS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Visek).HasColumnName("VISEK");

                entity.Property(e => e.Xdzp)
                    .HasColumnName("XDZP")
                    .HasColumnType("decimal(5, 3)");
            });

            modelBuilder.Entity<TechStOper>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ST_OPER_PK");

                entity.ToTable("TECH.ST_OPER");

                entity.HasIndex(e => new { e.Priznak, e.Operaciya, e.Idizgot, e.Delrecord })
                    .HasDatabaseName("ST_OPER_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Exclude)
                    .HasColumnName("EXCLUDE")
                    .HasDefaultValueSql("((0))")
                    .HasComment("1, если не учитывается в расчете зарплаты для некоторых участков");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kontrol).HasColumnName("KONTROL");

                entity.Property(e => e.Operaciya)
                    .HasColumnName("OPERACIYA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Priznak)
                    .HasColumnName("PRIZNAK")
                    .HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<TechStizg1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Tech_STIZG");

                entity.Property(e => e.Amort)
                    .HasColumnName("AMORT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cell).HasColumnName("CELL");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Equip).HasColumnName("EQUIP");

                entity.Property(e => e.ExcludeThis).HasColumnName("EXCLUDE_THIS");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idsql).HasColumnName("IDSQL");

                entity.Property(e => e.IsZ)
                    .HasColumnName("IS_Z")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Izg)
                    .HasColumnName("IZG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KolRab)
                    .HasColumnName("KOL_RAB")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Lider)
                    .HasColumnName("LIDER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Log).HasColumnName("LOG");

                entity.Property(e => e.Nam)
                    .IsRequired()
                    .HasColumnName("NAM")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlanFilter).HasColumnName("PLAN_FILTER");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prizn)
                    .HasColumnName("PRIZN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Proizv).HasColumnName("PROIZV");

                entity.Property(e => e.Resurs)
                    .HasColumnName("RESURS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ts)
                    .HasColumnName("TS")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Vis).HasColumnName("VIS");

                entity.Property(e => e.Visek).HasColumnName("VISEK");

                entity.Property(e => e.Xdzp)
                    .HasColumnName("XDZP")
                    .HasColumnType("decimal(5, 3)");
            });

            modelBuilder.Entity<TechTDetAp>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("T_DET_AP_PK");

                entity.ToTable("TECH.T_DET_AP");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.EdVr)
                    .HasColumnName("ED_VR")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Flagokr).HasColumnName("FLAGOKR");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.KodOb)
                    .HasColumnName("KOD_OB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Koid)
                    .HasColumnName("KOID")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Label)
                    .HasColumnName("LABEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Operaciya)
                    .HasColumnName("OPERACIYA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlOkr)
                    .HasColumnName("PL_OKR")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.Prizn)
                    .HasColumnName("PRIZN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Prof)
                    .HasColumnName("PROF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Razr)
                    .HasColumnName("RAZR")
                    .HasColumnType("decimal(3, 1)");

                entity.Property(e => e.Sod)
                    .HasColumnName("SOD")
                    .IsUnicode(false);

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Typework)
                    .HasColumnName("TYPEWORK")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechTDetOsn>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("T_DET_OSN_PK");

                entity.ToTable("TECH.T_DET_OSN_");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Keyosn)
                    .HasColumnName("KEYOSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.KodOb)
                    .HasColumnName("KOD_OB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nomosn)
                    .HasColumnName("NOMOSN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NormRash)
                    .HasColumnName("NORM_RASH")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Osn)
                    .HasColumnName("OSN")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechTVmtBaza>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("T_VMT_BAZA_PK");

                entity.ToTable("TECH.T_VMT_BAZA");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.EdIzm)
                    .HasColumnName("ED_IZM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.KodOb)
                    .HasColumnName("KOD_OB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NormRash)
                    .HasColumnName("NORM_RASH")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");
            });

            modelBuilder.Entity<TechTechProcessTypes>(entity =>
            {
                entity.ToTable("Tech.TechProcessTypes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TechProcessTypeName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<TechTo>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("TECH.TO_PK");

                entity.ToTable("TECH.TO");

                entity.HasComment(@"Таблица предназначена для хранения оценок в разрезе:
* Завод
* Участок
* ФИО
по задаче ""Аудит ТО1""");

                entity.HasIndex(e => new { e.Data, e.Smena, e.IdIzgot, e.KodIzgot, e.Fio })
                    .HasDatabaseName("TECH.TO_UQ1")
                    .IsUnique();

                entity.HasIndex(e => new { e.Mark, e.IdIzgot, e.Data, e.Smena, e.Fio })
                    .HasDatabaseName("TECH.TO_IDX1");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("FIO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Mark)
                    .HasColumnType("numeric(3, 1)")
                    .HasComment("Оценка (-1, 0.5, 1)");
            });

            modelBuilder.Entity<TechToChecklist>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("TECH.TO_CHECKLIST_pk_TECH.TO_CHECKLIST");

                entity.ToTable("TECH.TO_CHECKLIST");

                entity.HasIndex(e => new { e.IdIzgot, e.Equipment, e.Responsible })
                    .HasDatabaseName("TECH.TO_CHECKLIST_UniqueEquipment_TECH.TO_CHECKLIST")
                    .IsUnique();

                entity.Property(e => e.Cell)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Director).HasComment("Табельный номер руководителя");

                entity.Property(e => e.Equipment).HasComment("Инв. номер оборудования");

                entity.Property(e => e.IdIzgot).HasComment("ИД завода");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Код затратной зоны");

                entity.Property(e => e.Number).HasComment("Условный номер");

                entity.Property(e => e.NumberAlt).HasColumnType("decimal(10, 1)");

                entity.Property(e => e.Responsible).HasComment("Табельный номер ответственного");
            });

            modelBuilder.Entity<TechToHrlist>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("TO_HRLIST_PK");

                entity.ToTable("TECH.TO_HRLIST");

                entity.HasComment("Предназначена для хранения списков депремированных сотрудников после того, как заполнение карточек завершено");

                entity.HasIndex(e => new { e.IdIzgot, e.Period, e.Fio })
                    .HasDatabaseName("TO_HRLIST_UQ")
                    .IsUnique();

                entity.Property(e => e.AvgMark)
                    .HasColumnType("numeric(10, 3)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Средний балл");

                entity.Property(e => e.Checked)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("Выбран ли для передачи в приказ по депремированию");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("FIO")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("ФИО");

                entity.Property(e => e.GreenCount)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Кол-во зеленых карточек");

                entity.Property(e => e.IdIzgot).HasComment("ИД завода");

                entity.Property(e => e.IsOtv).HasComment("Ответственный?");

                entity.Property(e => e.Period)
                    .HasColumnType("date")
                    .HasComment("Период ТО1");

                entity.Property(e => e.RedCount)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Кол-во красных карточек");

                entity.Property(e => e.YellowCount)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Кол-во желтых карточек");
            });

            modelBuilder.Entity<TechToMarks>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TECH.TO_MARKS");

                entity.HasIndex(e => new { e.IdIzgot, e.Data, e.Smena, e.Equipment })
                    .HasDatabaseName("TECH.TO_MARKS_UQ_TECH.TO_MARKS")
                    .IsUnique();

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasComment("Дата");

                entity.Property(e => e.Director).HasComment("Руководитель");

                entity.Property(e => e.Equipment).HasComment("Инв. номер оборудования");

                entity.Property(e => e.IdIzgot)
                    .HasDefaultValueSql("((39))")
                    .HasComment("ID Завода");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("Код участка");

                entity.Property(e => e.Mark)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Оценка ТО1");

                entity.Property(e => e.Responsible).HasComment("Ответственный (подотчетный)");

                entity.Property(e => e.Smena)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Смена");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("ID пользователя, который внес изменения");
            });

            modelBuilder.Entity<TechToolCatalogue>(entity =>
            {
                entity.ToTable("TECH.ToolCatalogue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateBegin).HasColumnType("date");

                entity.Property(e => e.DateCheckLast).HasColumnType("date");

                entity.Property(e => e.DateCheckNext).HasColumnType("date");

                entity.Property(e => e.DateFact)
                    .HasColumnType("date")
                    .HasComment("Фактическая дата выполнения заказа на изготовление оснастки");

                entity.Property(e => e.DatePlan)
                    .HasColumnType("date")
                    .HasComment("Плановая дата выполнения заказа на изготовление оснастки");

                entity.Property(e => e.IdpersonResponsible).HasColumnName("IDPersonResponsible");

                entity.Property(e => e.Idplant).HasColumnName("IDPlant");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NumberInventory).HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductionTypes)
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechToolDetailsCatalogue>(entity =>
            {
                entity.ToTable("TECH.ToolDetailsCatalogue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idtool).HasColumnName("IDTool");
            });

            modelBuilder.Entity<TechToolDocCatalogue>(entity =>
            {
                entity.ToTable("TECH.ToolDocCatalogue");

                entity.HasIndex(e => e.Idtool)
                    .HasDatabaseName("IDTool");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("поле ID таблицы dbo.TECH.ToolCatalog");

                entity.Property(e => e.DateAddDoc).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Doc)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.DocFileExtention)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DocType).HasComment("0 - КД; 1 - Фотография; 2 - Акт приемки; 3 - Акт поверки");

                entity.Property(e => e.Idtool).HasColumnName("IDTool");

                entity.Property(e => e.Iduser).HasColumnName("IDUser");
            });

            modelBuilder.Entity<TechToolRequests>(entity =>
            {
                entity.ToTable("TECH.ToolRequests");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatePlan).HasColumnType("date");

                entity.Property(e => e.DatePlanCompletion).HasColumnType("date");

                entity.Property(e => e.DateRequest).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionTypes)
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechToolsPy>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("TOOLS_PY_PK");

                entity.ToTable("TECH.TOOLS_PY");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.CodeToolPy)
                    .IsRequired()
                    .HasColumnName("CODE_TOOL_PY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdToolPy).HasColumnName("ID_TOOL_PY");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");
            });

            modelBuilder.Entity<TechTu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tech.TU");

                entity.HasIndex(e => new { e.IdRtu, e.Izgot, e.TypeWork, e.TuType, e.Operaciya, e.AsVvod, e.AsVyvod })
                    .HasDatabaseName("IX_Tech.TU2");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.BaiOwn).HasMaxLength(10);

                entity.Property(e => e.BaiSave).HasMaxLength(10);

                entity.Property(e => e.DateSave).HasColumnType("datetime");

                entity.Property(e => e.IdRtu).HasColumnName("IdRTu");

                entity.Property(e => e.InvNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Izgot).HasMaxLength(4);

                entity.Property(e => e.KodUp).HasMaxLength(20);

                entity.Property(e => e.Operaciya)
                    .HasColumnName("OPERACIYA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TuType).HasMaxLength(20);

                entity.Property(e => e.TypeWork).HasMaxLength(20);
            });

            modelBuilder.Entity<TechTudata>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Tech.TUData");

                entity.HasIndex(e => new { e.IdRtu, e.Izgot, e.TypeWork, e.TypeDoc })
                    .HasDatabaseName("IX_Tech.TUData");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.DataSave).HasColumnType("datetime");

                entity.Property(e => e.Det).HasMaxLength(20);

                entity.Property(e => e.ExtData).HasMaxLength(6);

                entity.Property(e => e.FileData).HasColumnType("image");

                entity.Property(e => e.IdRtu).HasColumnName("IdRTu");

                entity.Property(e => e.Izgot)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.NamDet).HasMaxLength(60);

                entity.Property(e => e.Noneed).HasColumnName("noneed");

                entity.Property(e => e.TypeWork)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpCod)
                    .HasColumnName("UP_COD")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechTureestr>(entity =>
            {
                entity.HasKey(e => e.IdRtu);

                entity.ToTable("Tech.TUReestr");

                entity.Property(e => e.IdRtu).HasColumnName("IdRTu");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.DataSave).HasColumnType("datetime");

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IdIzgot).HasDefaultValueSql("((39))");

                entity.Property(e => e.Kem).HasMaxLength(21);

                entity.Property(e => e.TuType).HasMaxLength(20);
            });

            modelBuilder.Entity<TechTusetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TECH.TUSetup");

                entity.Property(e => e.Done).HasMaxLength(30);

                entity.Property(e => e.Mayclose).HasColumnName("mayclose");

                entity.Property(e => e.Mayclose1).HasColumnName("mayclose1");

                entity.Property(e => e.Role).HasMaxLength(30);

                entity.Property(e => e.ToDo).HasMaxLength(30);
            });

            modelBuilder.Entity<TechTuupdata>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Tech.TUUPData");

                entity.Property(e => e.Raz).HasColumnType("image");
            });

            modelBuilder.Entity<TechUpDet>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("UP_DET_PK");

                entity.ToTable("TECH.UP_DET");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("UP_DET_IX1");

                entity.HasIndex(e => new { e.UpCod, e.Det, e.NppOper })
                    .HasDatabaseName("UP_DET_IX2");

                entity.HasIndex(e => new { e.Kol, e.Det, e.Idizgot, e.UpCod, e.Delrecord })
                    .HasDatabaseName("UP_DET_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.AsCon)
                    .HasColumnName("AS_CON")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.UpCod)
                    .HasColumnName("UP_COD")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechUpLog>(entity =>
            {
                entity.ToTable("TECH.UP_LOG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cpcode)
                    .IsRequired()
                    .HasColumnName("CPCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cpname)
                    .HasColumnName("CPName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateChange).HasColumnType("datetime");

                entity.Property(e => e.DetailsSquare)
                    .HasColumnType("decimal(10, 6)")
                    .HasComment("Общая площадь всех деталей на листе");

                entity.Property(e => e.Iduser).HasColumnName("IDUser");

                entity.Property(e => e.MaterialArticle).HasMaxLength(25);

                entity.Property(e => e.TimeMash).HasColumnType("decimal(10, 4)");
            });

            modelBuilder.Entity<TechUpSt>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("UP_ST_PK");

                entity.ToTable("TECH.UP_ST");

                entity.HasIndex(e => e.UpCod)
                    .HasDatabaseName("UP_ST_IX1");

                entity.HasIndex(e => new { e.EdVr, e.Tmash, e.UpNam, e.Wid, e.Heig, e.KolR, e.Mat, e.UpCod, e.Idizgot, e.Delrecord })
                    .HasDatabaseName("UP_ST_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.ArchiveDate)
                    .HasColumnName("ARCHIVE_DATE")
                    .HasColumnType("date")
                    .HasComment("Дата перемещения из архива");

                entity.Property(e => e.ArchiveTerm)
                    .HasColumnName("ARCHIVE_TERM")
                    .HasComment("Кол-во дней, на которое УП возвращается из архива");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Brigada)
                    .HasColumnName("BRIGADA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Del).HasColumnName("DEL");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.EdVr)
                    .HasColumnName("ED_VR")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EdVrOld)
                    .HasColumnName("ED_VR_OLD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FileExt)
                    .HasColumnName("FILE_EXT")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Gauge)
                    .HasColumnName("GAUGE")
                    .HasColumnType("decimal(6, 2)")
                    .HasComment("Толщина листа материала");

                entity.Property(e => e.Heig)
                    .HasColumnName("HEIG")
                    .HasColumnType("decimal(6, 0)")
                    .HasComment("Ширина листа материала");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.KodOb)
                    .HasColumnName("KOD_OB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KolR)
                    .HasColumnName("KOL_R")
                    .HasColumnType("decimal(3, 1)");

                entity.Property(e => e.MainUp)
                    .HasColumnName("MAIN_UP")
                    .HasComment("Если для одной детали есть несколько УП, то отмечается основная (базовая) УП");

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PLog)
                    .HasColumnName("P_LOG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Perimetr)
                    .HasColumnName("PERIMETR")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prioritet)
                    .HasColumnName("PRIORITET")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Priznak).HasColumnName("PRIZNAK");

                entity.Property(e => e.ReasonForArchive)
                    .HasColumnName("REASON_FOR_ARCHIVE")
                    .HasMaxLength(300);

                entity.Property(e => e.ShortTerm)
                    .HasColumnName("SHORT_TERM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShortTermDate)
                    .HasColumnName("SHORT_TERM_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Skor)
                    .HasColumnName("SKOR")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Tmash)
                    .HasColumnName("TMASH")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.TmashOld)
                    .HasColumnName("TMASH_OLD")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.UpCod)
                    .HasColumnName("UP_COD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpNam)
                    .HasColumnName("UP_NAM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wid)
                    .HasColumnName("WID")
                    .HasColumnType("decimal(6, 0)")
                    .HasComment("Длина листа материала");
            });

            modelBuilder.Entity<TechVmtBaza>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("VMT_BAZA_PK");

                entity.ToTable("TECH.VMT_BAZA");

                entity.HasIndex(e => new { e.Det, e.NppOper })
                    .HasDatabaseName("VMT_BAZA_IX1");

                entity.HasIndex(e => new { e.Mat, e.Det })
                    .HasDatabaseName("VMT_BAZA_IX3");

                entity.HasIndex(e => new { e.Det, e.NppOper, e.Mat })
                    .HasDatabaseName("VMT_BAZA_IX2");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdIzm)
                    .HasColumnName("ED_IZM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NormRash)
                    .HasColumnName("NORM_RASH")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");
            });

            modelBuilder.Entity<TimeRatePrices>(entity =>
            {
                entity.HasIndex(e => e.Section)
                    .HasDatabaseName("Section")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TimeRatePrice).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<TmpConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp.Config");

                entity.HasIndex(e => new { e.IdIzgot, e.Priznak })
                    .HasDatabaseName("IX_Tmp.Config");

                entity.Property(e => e.DataChange).HasColumnType("datetime");

                entity.Property(e => e.IdIzgot).HasDefaultValueSql("((39))");

                entity.Property(e => e.Path).HasMaxLength(100);

                entity.Property(e => e.Priznak).HasMaxLength(50);
            });

            modelBuilder.Entity<TmpFiltr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp.Filtr");

                entity.Property(e => e.Krit).HasMaxLength(200);

                entity.Property(e => e.Pole).HasMaxLength(50);
            });

            modelBuilder.Entity<TmpLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp_log");

                entity.Property(e => e.Computername)
                    .HasColumnName("COMPUTERNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Dat)
                    .HasColumnName("dat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Login).HasMaxLength(10);

                entity.Property(e => e.Logonserver)
                    .HasColumnName("LOGONSERVER")
                    .HasMaxLength(100);

                entity.Property(e => e.Userdnsdomain)
                    .HasColumnName("USERDNSDOMAIN")
                    .HasMaxLength(100);

                entity.Property(e => e.Userdomain)
                    .HasColumnName("USERDOMAIN")
                    .HasMaxLength(100);

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Ver).HasMaxLength(10);
            });

            modelBuilder.Entity<TmpMed>(entity =>
            {
                entity.HasIndex(e => new { e.Article, e.Mark })
                    .HasDatabaseName("IX_TmpMed")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Article)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaptionA).HasMaxLength(50);

                entity.Property(e => e.CaptionB).HasMaxLength(50);

                entity.Property(e => e.MarkMaxStacking).HasComment("Признак наличия на этикетке надписи \"Максимальная укладка друг на друга не более n штук\"");
            });

            modelBuilder.Entity<TmpUpSt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp.Up_st");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.FileExt)
                    .HasColumnName("File_ext")
                    .HasMaxLength(3);

                entity.Property(e => e.UpCod)
                    .HasColumnName("UP_COD")
                    .HasMaxLength(20);

                entity.Property(e => e.UpNam)
                    .HasColumnName("UP_Nam")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ToCustomerAppointment>(entity =>
            {
                entity.ToTable("TO.CustomerAppointment");

                entity.HasIndex(e => new { e.IdBranch, e.Hid })
                    .HasDatabaseName("IX_TO.CustomerAppointment_Column");

                entity.Property(e => e.CreationTime).HasColumnType("datetime");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.EntryId)
                    .HasColumnName("EntryID")
                    .HasMaxLength(50);

                entity.Property(e => e.Hid).HasColumnName("HID");

                entity.Property(e => e.Location).HasMaxLength(150);

                entity.Property(e => e.Organizer).HasMaxLength(150);

                entity.Property(e => e.Start).HasColumnType("datetime");
            });

            modelBuilder.Entity<ToCustomerContact>(entity =>
            {
                entity.ToTable("TO.CustomerContact");

                entity.HasIndex(e => new { e.IdBranch, e.FullName })
                    .HasDatabaseName("IX_TO.CustomerContact_Column")
                    .IsUnique();

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.BusinessTelephoneNumber).HasMaxLength(20);

                entity.Property(e => e.Companies).HasMaxLength(150);

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.Email1Address).HasMaxLength(100);

                entity.Property(e => e.Email1AddressType).HasMaxLength(20);

                entity.Property(e => e.Email2Address).HasMaxLength(100);

                entity.Property(e => e.Email2AddressType).HasMaxLength(20);

                entity.Property(e => e.Email3Address).HasMaxLength(100);

                entity.Property(e => e.Email3AddressType).HasMaxLength(20);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.Hid).HasColumnName("HID");

                entity.Property(e => e.HomeTelephoneNumber).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MobileTelephoneNumber).HasMaxLength(20);

                entity.Property(e => e.OtherTelephoneNumber).HasMaxLength(20);

                entity.Property(e => e.WebPage).HasMaxLength(100);
            });

            modelBuilder.Entity<ToolsPy>(entity =>
            {
                entity.ToTable("ToolsPY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cell)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DateChange).HasColumnType("datetime");

                entity.Property(e => e.DateDevelopment).HasColumnType("date");

                entity.Property(e => e.DateLaunch).HasColumnType("date");

                entity.Property(e => e.DevelopedView).HasComment("Признак того, что данная РУ отображается в развертке и в чертеже");

                entity.Property(e => e.DocumentFile).HasColumnType("image");

                entity.Property(e => e.DocumentFileExtention)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MethodOrCase).HasComment("0 - метод; 1 - частный случай");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("1 - сейфы; 2 - мебель; 3 - двери");

                entity.Property(e => e.ScanStudy)
                    .HasColumnType("image")
                    .HasComment("Скан листа обучения персонала участка действия P-Y");

                entity.Property(e => e.ScanStudyFileExtention)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasComment("1 - актуально; 2 - неактуально; 3 - передано на др. площадку; 4 - в разработке; 5 - в доработке");

                entity.Property(e => e.Unit).HasComment("Площадка, на которой создан РУ");

                entity.Property(e => e.UnitNow).HasComment("Площадка, на которой сейчас находится РУ");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("[HR.IND_KART].IDREC - тот, кто сделал последнее изменение данной записи");
            });

            modelBuilder.Entity<ToolsPyDevelopers>(entity =>
            {
                entity.ToTable("ToolsPY_Developers");

                entity.HasIndex(e => e.Idperson)
                    .HasDatabaseName("IDPerson");

                entity.HasIndex(e => e.IdtoolPy)
                    .HasDatabaseName("IDToolPY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idperson).HasColumnName("IDPerson");

                entity.Property(e => e.IdtoolPy).HasColumnName("IDToolPY");
            });

            modelBuilder.Entity<ToolsPyDocuments>(entity =>
            {
                entity.ToTable("ToolsPY_Documents");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocumentFile).HasColumnType("image");

                entity.Property(e => e.DocumentFileName).HasMaxLength(150);

                entity.Property(e => e.IdtoolPy).HasColumnName("IDToolPY");
            });

            modelBuilder.Entity<ToolsPyProduction>(entity =>
            {
                entity.ToTable("ToolsPY_Production");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdtoolPy).HasColumnName("IDToolPY");

                entity.Property(e => e.ProductionCode)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpData>(entity =>
            {
                entity.ToTable("UP.DATA");

                entity.HasIndex(e => new { e.UpCod, e.IdIzgot })
                    .HasDatabaseName("IX_UP.DATA")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.BaiUpdated)
                    .HasColumnName("Bai_Updated")
                    .HasMaxLength(10);

                entity.Property(e => e.DataChange).HasColumnType("datetime");

                entity.Property(e => e.UpCod)
                    .HasColumnName("Up_cod")
                    .HasMaxLength(20);

                entity.Property(e => e.UpExt)
                    .HasColumnName("Up_ext")
                    .HasMaxLength(3);

                entity.Property(e => e.UpExtd)
                    .HasColumnName("Up_extd")
                    .HasMaxLength(3);

                entity.Property(e => e.UpSod)
                    .HasColumnName("Up_sod")
                    .HasColumnType("image");

                entity.Property(e => e.UpSodd)
                    .HasColumnName("Up_sodd")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<UpDataArchive>(entity =>
            {
                entity.ToTable("UP.DATA_ARCHIVE");

                entity.HasIndex(e => new { e.UpCod, e.IdIzgot })
                    .HasDatabaseName("IX_UP.DATA_ARCHIVE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.BaiUpdated)
                    .HasColumnName("Bai_Updated")
                    .HasMaxLength(10);

                entity.Property(e => e.DataChange).HasColumnType("datetime");

                entity.Property(e => e.UpCod)
                    .HasColumnName("Up_cod")
                    .HasMaxLength(20);

                entity.Property(e => e.UpExt)
                    .HasColumnName("Up_ext")
                    .HasMaxLength(3);

                entity.Property(e => e.UpExtd)
                    .HasColumnName("Up_extd")
                    .HasMaxLength(3);

                entity.Property(e => e.UpSod)
                    .HasColumnName("Up_sod")
                    .HasColumnType("image");

                entity.Property(e => e.UpSodd)
                    .HasColumnName("Up_sodd")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<UpKondet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UP.KONDET");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.DataChange).HasColumnType("datetime");

                entity.Property(e => e.Det).HasMaxLength(20);

                entity.Property(e => e.Kol).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<UpKonzak>(entity =>
            {
                entity.HasKey(e => e.IdZak);

                entity.ToTable("UP.KONZAK");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.DataChange).HasColumnType("datetime");

                entity.Property(e => e.DataOpen).HasColumnType("datetime");

                entity.Property(e => e.NameId).HasMaxLength(20);
            });

            modelBuilder.Entity<UpTech>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UP.TECH");

                entity.Property(e => e.Bai).HasMaxLength(10);

                entity.Property(e => e.DataChange).HasColumnType("datetime");

                entity.Property(e => e.Kol).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpCod)
                    .HasColumnName("Up_cod")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VArticD>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vArtic_D");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(50);

                entity.Property(e => e.ArticulExt)
                    .HasColumnName("ARTICUL_EXT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Articulext1)
                    .HasColumnName("ARTICULEXT")
                    .HasMaxLength(50);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Def).HasColumnName("DEF");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.IdArticul).HasColumnName("ID_ARTICUL");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KrNam)
                    .HasColumnName("KR_NAM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamB).HasColumnName("NAM_B");

                entity.Property(e => e.NamK)
                    .HasColumnName("NAM_K")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NamKk)
                    .HasColumnName("NAM_KK")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ros)
                    .HasColumnName("ROS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Rostyp)
                    .HasColumnName("ROSTYP")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VArticDNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vArtic_D_NEW");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(50);

                entity.Property(e => e.ArticulExt)
                    .HasColumnName("ARTICUL_EXT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Articulext1)
                    .HasColumnName("ARTICULEXT")
                    .HasMaxLength(50);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Def).HasColumnName("DEF");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.IdArticul).HasColumnName("ID_ARTICUL");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KrNam)
                    .HasColumnName("KR_NAM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamB).HasColumnName("NAM_B");

                entity.Property(e => e.NamK)
                    .HasColumnName("NAM_K")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NamKk)
                    .HasColumnName("NAM_KK")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ros)
                    .HasColumnName("ROS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Rostyp)
                    .HasColumnName("ROSTYP")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VArticSh1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vArtic_SH1");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VArticul>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vArticul");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(50);

                entity.Property(e => e.ArticulAlt)
                    .HasColumnName("ARTICUL_ALT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ArticulTo)
                    .IsRequired()
                    .HasColumnName("ARTICUL_TO")
                    .HasMaxLength(50);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.EditUp)
                    .HasColumnName("EDIT_UP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.En).HasColumnName("EN");

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Group)
                    .HasColumnName("GROUP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdPlantType39).HasColumnName("ID_PLANT_TYPE_39");

                entity.Property(e => e.IdPlantType42).HasColumnName("ID_PLANT_TYPE_42");

                entity.Property(e => e.IdPlantType44).HasColumnName("ID_PLANT_TYPE_44");

                entity.Property(e => e.IdPrGroup).HasColumnName("ID_PR_GROUP");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KolM)
                    .HasColumnName("KOL_M")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.KolUp)
                    .HasColumnName("KOL_UP")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Locnum)
                    .HasColumnName("LOCNUM")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.LogNum).HasColumnName("LOG_NUM");

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mod)
                    .HasColumnName("MOD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Net)
                    .HasColumnName("NET")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Netto)
                    .HasColumnName("NETTO")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.New).HasColumnName("NEW");

                entity.Property(e => e.Ob)
                    .HasColumnName("OB")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.PrType)
                    .HasColumnName("PR_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceOpt)
                    .HasColumnName("PRICE_OPT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Print).HasColumnName("PRINT");

                entity.Property(e => e.Ros)
                    .HasColumnName("ROS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Rostyp)
                    .HasColumnName("ROSTYP")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TypSer)
                    .HasColumnName("TYP_SER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Upac)
                    .HasColumnName("UPAC")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VArticulNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vARTICUL_NEW");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(50);

                entity.Property(e => e.ArticulTo)
                    .IsRequired()
                    .HasColumnName("ARTICUL_TO")
                    .HasMaxLength(50);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EanCode)
                    .HasColumnName("EAN_CODE")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.EditUp)
                    .HasColumnName("EDIT_UP")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.En).HasColumnName("EN");

                entity.Property(e => e.Flag).HasColumnName("FLAG");

                entity.Property(e => e.Group)
                    .HasColumnName("GROUP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdPlantType39).HasColumnName("ID_PLANT_TYPE_39");

                entity.Property(e => e.IdPlantType42).HasColumnName("ID_PLANT_TYPE_42");

                entity.Property(e => e.IdPlantType44).HasColumnName("ID_PLANT_TYPE_44");

                entity.Property(e => e.IdPrGroup).HasColumnName("ID_PR_GROUP");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KolM)
                    .HasColumnName("KOL_M")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.KolUp)
                    .HasColumnName("KOL_UP")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Locnum)
                    .HasColumnName("LOCNUM")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.LogNum).HasColumnName("LOG_NUM");

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mod)
                    .HasColumnName("MOD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Net)
                    .HasColumnName("NET")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Netto)
                    .HasColumnName("NETTO")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.New).HasColumnName("NEW");

                entity.Property(e => e.Ob)
                    .HasColumnName("OB")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.PrType)
                    .HasColumnName("PR_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceOpt)
                    .HasColumnName("PRICE_OPT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Print).HasColumnName("PRINT");

                entity.Property(e => e.Ros)
                    .HasColumnName("ROS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Rostyp)
                    .HasColumnName("ROSTYP")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TypSer)
                    .HasColumnName("TYP_SER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Upac)
                    .HasColumnName("UPAC")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VIndKart>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vIND_KART");

                entity.Property(e => e.Adress)
                    .HasColumnName("ADRESS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Box)
                    .HasColumnName("BOX")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Brigada)
                    .HasColumnName("BRIGADA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Brigadir)
                    .HasColumnName("BRIGADIR")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Dateb)
                    .HasColumnName("DATEB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datep)
                    .HasColumnName("DATEP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateu)
                    .HasColumnName("DATEU")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.EconomR).HasColumnName("ECONOM_R");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Esn).HasColumnName("ESN");

                entity.Property(e => e.ExcludeInCardPermission).HasColumnName("EXCLUDE_IN_CARD_PERMISSION");

                entity.Property(e => e.Fam)
                    .HasColumnName("FAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idapax).HasColumnName("IDAPAX");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Inn)
                    .HasColumnName("INN")
                    .HasColumnType("decimal(12, 0)");

                entity.Property(e => e.KartR)
                    .HasColumnName("KART_R")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Kleimo).HasColumnName("KLEIMO");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Koeff)
                    .HasColumnName("KOEFF")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.KoeffPrem)
                    .HasColumnName("KOEFF_PREM")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.KoeffSd)
                    .HasColumnName("KOEFF_SD")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Kps)
                    .HasColumnName("KPS")
                    .HasColumnType("decimal(11, 0)");

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamShb)
                    .HasColumnName("NAM_SHB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nikname)
                    .HasColumnName("NIKNAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oklad)
                    .HasColumnName("OKLAD")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.OsnR).HasColumnName("OSN_R");

                entity.Property(e => e.Otch)
                    .HasColumnName("OTCH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaspKem)
                    .HasColumnName("PASP_KEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaspNom)
                    .HasColumnName("PASP_NOM")
                    .HasColumnType("decimal(10, 0)");

                entity.Property(e => e.PaspSer)
                    .HasColumnName("PASP_SER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pic)
                    .HasColumnName("PIC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlanR).HasColumnName("PLAN_R");

                entity.Property(e => e.Pol)
                    .HasColumnName("POL")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PrZpn)
                    .HasColumnName("PR_ZPN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Proff)
                    .HasColumnName("PROFF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Propusk)
                    .HasColumnName("PROPUSK")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RazGol)
                    .HasColumnName("RAZ_GOL")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RazOb)
                    .HasColumnName("RAZ_OB")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RazOd)
                    .HasColumnName("RAZ_OD")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RostOd)
                    .HasColumnName("ROST_OD")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Sdelka).HasColumnName("SDELKA");

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.SmenaOld)
                    .HasColumnName("SMENA_OLD")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.TabN)
                    .HasColumnName("TAB_N")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.TimeSm)
                    .HasColumnName("TIME_SM")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.TpR)
                    .HasColumnName("TP_R")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Typ)
                    .HasColumnName("TYP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasColumnName("USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Val)
                    .HasColumnName("VAL")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Visa)
                    .HasColumnName("VISA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Zp)
                    .HasColumnName("ZP")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Zpn)
                    .HasColumnName("ZPN")
                    .HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<VNakArtic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vNAK_ARTIC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Group)
                    .HasColumnName("GROUP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Nakl)
                    .HasColumnName("NAKL")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Net)
                    .HasColumnName("NET")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Pos)
                    .HasColumnName("POS")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prn)
                    .HasColumnName("PRN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Spisanie).HasColumnName("SPISANIE");
            });

            modelBuilder.Entity<VPlantTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPlantTypes");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idchief).HasColumnName("IDChief");

                entity.Property(e => e.Kfam)
                    .HasColumnName("KFam")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.PlantType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSkladHRkForDeleting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSKLAD_H_RK_For_Deleting");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Kol)
                    .HasColumnName("kol")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.NRekl)
                    .HasColumnName("N_REKL")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Start)
                    .HasColumnName("START")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VSmTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSM_TABLE");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataReg)
                    .HasColumnName("DATA_REG")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateenter)
                    .HasColumnName("DATEENTER")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateexit)
                    .HasColumnName("DATEEXIT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InitiateShortenedTurn).HasColumnName("Initiate_Shortened_Turn");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Koeff)
                    .HasColumnName("KOEFF")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasColumnType("decimal(4, 1)");

                entity.Property(e => e.TimeN)
                    .HasColumnName("TIME_N")
                    .HasColumnType("decimal(4, 1)");
            });

            modelBuilder.Entity<VStIzg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vST_IZG");

                entity.Property(e => e.Amort)
                    .HasColumnName("AMORT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cell).HasColumnName("CELL");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Equip).HasColumnName("EQUIP");

                entity.Property(e => e.ExcludeThis).HasColumnName("EXCLUDE_THIS");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idsql).HasColumnName("IDSQL");

                entity.Property(e => e.IsZ)
                    .HasColumnName("IS_Z")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Izg)
                    .HasColumnName("IZG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KolRab)
                    .HasColumnName("KOL_RAB")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Lider)
                    .HasColumnName("LIDER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Log).HasColumnName("LOG");

                entity.Property(e => e.Nam)
                    .IsRequired()
                    .HasColumnName("NAM")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlanFilter).HasColumnName("PLAN_FILTER");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prizn)
                    .HasColumnName("PRIZN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Proizv).HasColumnName("PROIZV");

                entity.Property(e => e.Resurs)
                    .HasColumnName("RESURS")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SectorType).HasColumnName("SECTOR_TYPE");

                entity.Property(e => e.Ts)
                    .HasColumnName("TS")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Vis).HasColumnName("VIS");

                entity.Property(e => e.Visek).HasColumnName("VISEK");

                entity.Property(e => e.Xdzp)
                    .HasColumnName("XDZP")
                    .HasColumnType("decimal(5, 3)");
            });

            modelBuilder.Entity<VZakArtic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vZAK_Artic");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.Dat)
                    .HasColumnName("DAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateNewPlan).HasColumnType("date");

                entity.Property(e => e.DatePlan).HasColumnType("date");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KolIzg)
                    .HasColumnName("KOL_IZG")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KolSub)
                    .HasColumnName("KOL_SUB")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NRekl)
                    .HasColumnName("N_Rekl")
                    .HasMaxLength(40);

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasColumnName("Order No")
                    .HasMaxLength(50);

                entity.Property(e => e.PlLog).HasColumnName("PL_LOG");

                entity.Property(e => e.Pos)
                    .HasColumnName("POS")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceOpt)
                    .HasColumnName("PRICE_OPT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prizn).HasColumnName("PRIZN");

                entity.Property(e => e.Priznak).HasColumnName("PRIZNAK");

                entity.Property(e => e.TorecId).HasColumnName("TORecID");

                entity.Property(e => e.ZakIdrec).HasColumnName("ZakIDRec");

                entity.Property(e => e.ПерерасходNSub)
                    .HasColumnName("Перерасход_N_Sub")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VZakSt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vZak_ST");

                entity.Property(e => e.BaseIdrec).HasColumnName("BaseIDRec");

                entity.Property(e => e.ClientCode).HasMaxLength(10);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Data1)
                    .HasColumnName("DATA1")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataCh)
                    .HasColumnName("DATA_CH")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSend)
                    .HasColumnName("DATA_SEND")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ist)
                    .HasColumnName("IST")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Kod)
                    .HasColumnName("KOD")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Log).HasColumnName("LOG");

                entity.Property(e => e.Mail)
                    .HasColumnName("MAIL")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.NBase)
                    .HasColumnName("N_Base")
                    .HasMaxLength(50);

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(50);

                entity.Property(e => e.Nak).HasColumnName("NAK");

                entity.Property(e => e.NamZak)
                    .HasColumnName("NAM_ZAK")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Order)
                    .HasColumnName("ORDER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Prizn)
                    .HasColumnName("PRIZN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.Spec).HasColumnName("SPEC");

                entity.Property(e => e.Stor).HasColumnName("STOR");

                entity.Property(e => e.User).HasMaxLength(50);

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<Vehicles>(entity =>
            {
                entity.HasKey(e => e.PlateNumber)
                    .HasName("PK__Vehicles__036926250606A664");

                entity.ToTable("Vehicles", "cargo");

                entity.Property(e => e.PlateNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Госномер");

                entity.Property(e => e.Axis1Group)
                    .HasColumnName("Axis1_Group")
                    .HasComment("Группа оси 1");

                entity.Property(e => e.Axis1MaxLoad)
                    .HasColumnName("Axis1_MaxLoad")
                    .HasComment("Макс.нагрузка на ось 1");

                entity.Property(e => e.Axis1Offset)
                    .HasColumnName("Axis1_Offset")
                    .HasComment("Смещение оси 1");

                entity.Property(e => e.Axis2Group)
                    .HasColumnName("Axis2_Group")
                    .HasComment("Группа оси 2");

                entity.Property(e => e.Axis2MaxLoad)
                    .HasColumnName("Axis2_MaxLoad")
                    .HasComment("Макс.нагрузка на ось 2");

                entity.Property(e => e.Axis2Offset)
                    .HasColumnName("Axis2_Offset")
                    .HasComment("Смещение оси 2");

                entity.Property(e => e.Axis3Group)
                    .HasColumnName("Axis3_Group")
                    .HasComment("Группа оси 3");

                entity.Property(e => e.Axis3MaxLoad)
                    .HasColumnName("Axis3_MaxLoad")
                    .HasComment("Макс.нагрузка на ось 3");

                entity.Property(e => e.Axis3Offset)
                    .HasColumnName("Axis3_Offset")
                    .HasComment("Смещение оси 3");

                entity.Property(e => e.Axis4Group)
                    .HasColumnName("Axis4_Group")
                    .HasComment("Группа оси 4");

                entity.Property(e => e.Axis4MaxLoad)
                    .HasColumnName("Axis4_MaxLoad")
                    .HasComment("Макс.нагрузка на ось 4");

                entity.Property(e => e.Axis4Offset)
                    .HasColumnName("Axis4_Offset")
                    .HasComment("Смещение оси 4");

                entity.Property(e => e.Height).HasComment("Высота в метрах");

                entity.Property(e => e.Length).HasComment("Длина в метрах");

                entity.Property(e => e.Mass).HasComment("Масса");

                entity.Property(e => e.MassX).HasComment("Смещение центра масс по Х");

                entity.Property(e => e.MassY).HasComment("Смещение центра масс по Y");

                entity.Property(e => e.MountX).HasComment("Точка монтирования X");

                entity.Property(e => e.MountY).HasComment("Точка монтирования Y");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Наименование");

                entity.Property(e => e.VehicleType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Тип ТС из справочника");

                entity.Property(e => e.VolumeHeight).HasComment("Высота полезного объема");

                entity.Property(e => e.VolumeLength).HasComment("Длина полезного объема");

                entity.Property(e => e.VolumeWidth).HasComment("Ширина полезного объема");

                entity.Property(e => e.Width).HasComment("Ширина в метрах");
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1", "db_owner");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<View11>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.Ким)
                    .HasColumnName("КИМ")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Ким2)
                    .HasColumnName("КИМ2")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ким3)
                    .HasColumnName("КИМ3")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ViewCompon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Compon", "db_owner");

                entity.Property(e => e.Component)
                    .HasColumnName("COMPONENT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewCurator>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCurator", "db_owner");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ViewDetap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_DETAP", "db_owner");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Operaciya)
                    .HasColumnName("OPERACIYA")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDopStor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewDopSTor", "db_owner");

                entity.Property(e => e.Avans).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.BolPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Bonus1).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Bonus2).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Bonus3).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dkach)
                    .HasColumnName("DKach")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dkval)
                    .HasColumnName("DKval")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dstag)
                    .HasColumnName("DStag")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dvoz)
                    .HasColumnName("DVoz")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.F).HasMaxLength(100);

                entity.Property(e => e.Fio).HasMaxLength(200);

                entity.Property(e => e.I).HasMaxLength(100);

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("Kod_izgot")
                    .HasMaxLength(10);

                entity.Property(e => e.Nach).HasColumnType("numeric(30, 4)");

                entity.Property(e => e.NamOrg).HasMaxLength(50);

                entity.Property(e => e.NdflB).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NdflPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.O).HasMaxLength(100);

                entity.Property(e => e.OtpPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Pr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Tarif).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TimExp).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TimNorm).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TimTab).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdAll).HasColumnType("numeric(14, 2)");

                entity.Property(e => e.UdMob).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdStol).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Vypl).HasColumnType("numeric(12, 2)");

                entity.Property(e => e.ZpB).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<ViewKodIzgot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_KodIzgot", "db_owner");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Izgot)
                    .HasColumnName("IZGOT")
                    .HasMaxLength(288)
                    .IsUnicode(false);

                entity.Property(e => e.Kodizgot)
                    .HasColumnName("KODIZGOT")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewSchIzg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewSchIzg", "db_owner");

                entity.Property(e => e.Bonus1).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Bonus2).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Bonus3).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dkach)
                    .HasColumnName("DKach")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dkval)
                    .HasColumnName("DKval")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dstag)
                    .HasColumnName("DStag")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.F).HasMaxLength(100);

                entity.Property(e => e.Fio).HasMaxLength(200);

                entity.Property(e => e.I).HasMaxLength(100);

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("Kod_izgot")
                    .HasMaxLength(10);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.O).HasMaxLength(100);

                entity.Property(e => e.Tarif).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TimExp).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TimNorm).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TimTab).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<ViewSmTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SmTable", "db_owner");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<ViewSotr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Sotr", "db_owner");

                entity.Property(e => e.Avans).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.BolPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Bonus1).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Bonus2).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Bonus3).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dkach)
                    .HasColumnName("DKach")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dkval)
                    .HasColumnName("DKval")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dstag)
                    .HasColumnName("DStag")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dvoz)
                    .HasColumnName("DVoz")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.F).HasMaxLength(150);

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.Fio).HasMaxLength(200);

                entity.Property(e => e.Firma).HasMaxLength(20);

                entity.Property(e => e.I).HasMaxLength(100);

                entity.Property(e => e.Kat)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("Kod_izgot")
                    .HasMaxLength(10);

                entity.Property(e => e.KodIzgot1)
                    .HasColumnName("KodIzgot")
                    .HasMaxLength(4);

                entity.Property(e => e.Nach).HasColumnType("numeric(30, 4)");

                entity.Property(e => e.NdflB).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NdflPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.O).HasMaxLength(100);

                entity.Property(e => e.Ost).HasColumnType("numeric(33, 4)");

                entity.Property(e => e.OtpPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Pr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Tarif).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TimExp).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TimNorm).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TimTab).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdAll).HasColumnType("numeric(14, 2)");

                entity.Property(e => e.UdMob).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdStol).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UserAsup)
                    .HasColumnName("User_asup")
                    .HasMaxLength(10);

                entity.Property(e => e.Vypl).HasColumnType("numeric(12, 2)");

                entity.Property(e => e.ZpB).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ZpTar).HasColumnType("numeric(23, 4)");
            });

            modelBuilder.Entity<ViewTest1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Test1");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(38, 3)");
            });

            modelBuilder.Entity<ViewTmpIzg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_TmpIzg", "db_owner");

                entity.Property(e => e._1Опер)
                    .HasColumnName("1 опер.")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e._2Опер)
                    .HasColumnName("2 опер.")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Бирка).HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Время).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Деталь)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Изготовитель)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Коэфф)
                    .HasColumnName("Коэфф.")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Уп)
                    .HasColumnName("УП")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewZpSotr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewZpSotr", "db_owner");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.Dolg).HasMaxLength(150);

                entity.Property(e => e.F).HasMaxLength(150);

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.Firma).HasMaxLength(20);

                entity.Property(e => e.I).HasMaxLength(100);

                entity.Property(e => e.IdФирмы).HasColumnName("ID фирмы");

                entity.Property(e => e.Kat)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.KodIzgot1)
                    .HasColumnName("KodIzgot")
                    .HasMaxLength(4);

                entity.Property(e => e.O).HasMaxLength(100);

                entity.Property(e => e.Typ)
                    .HasColumnName("TYP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Фирма).HasMaxLength(4);
            });

            modelBuilder.Entity<VwAspnetApplications>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfiles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePaths>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WageTotalsdaily>(entity =>
            {
                entity.HasKey(e => new { e.Data, e.Idizgot, e.Kodizgot });

                entity.ToTable("WAGE.TOTALSDAILY");

                entity.HasComment("Таблица с ФОТ участков на день");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("date")
                    .HasComment("Дата рассчитанного ФОТ");

                entity.Property(e => e.Idizgot)
                    .HasColumnName("IDIZGOT")
                    .HasComment("Площадка");

                entity.Property(e => e.Kodizgot)
                    .HasColumnName("KODIZGOT")
                    .HasComment("Код участка");

                entity.Property(e => e.Fot)
                    .HasColumnName("FOT")
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("ФОТ участка");
            });

            modelBuilder.Entity<WarehouseBalance>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseFilter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilterIndex).HasComment("1 - для итогового отчета для аудитора; 2 - для прихода комплектующих со склада закупок");
            });

            modelBuilder.Entity<WarehouseList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idrelated)
                    .HasColumnName("IDRelated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionType).HasComment("0 - приход, расход; 1 - брак; 2 - расход с общего склада на участок; 3 - продажа внутри компании; 4 - приход без накладных");

                entity.Property(e => e.WarehouseIndex).HasComment("если WarehouseIndex=1 - это ID этой таблицы с записью о замке, который состоит из данных позиций; WarehouseIndex=2 - это IDREC таблицы WSHOP.IZG_DAY - ссылка на изготовленный замок");
            });

            modelBuilder.Entity<WarehouseTotals>(entity =>
            {
                entity.HasKey(e => new { e.KodIzgot, e.Tab, e.Date, e.Tabel, e.CargoVolume })
                    .HasName("WarehouseTotals_pk");

                entity.ToTable("WarehouseTotals", "wage");

                entity.HasComment("Итоги работы склада по датам");

                entity.Property(e => e.KodIzgot)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("Затратная зона");

                entity.Property(e => e.Tab).HasComment("Табельный номер");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("Дата");

                entity.Property(e => e.Tabel)
                    .HasColumnType("numeric(10, 2)")
                    .HasComment("Табельное время");

                entity.Property(e => e.CargoVolume).HasComment("Объем загрузок");
            });

            modelBuilder.Entity<WebZoneConfig>(entity =>
            {
                entity.HasKey(e => new { e.Zone, e.FactoryId });

                entity.ToTable("web.Zone_Config");

                entity.Property(e => e.Zone)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");
            });

            modelBuilder.Entity<WebZoneSetup>(entity =>
            {
                entity.HasKey(e => new { e.Zone, e.FactoryId });

                entity.ToTable("web.Zone_Setup");

                entity.Property(e => e.Zone).HasMaxLength(10);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.DisableCellLock).HasComment("Снять блокировку с переключателя деталь уп комплект");
            });

            modelBuilder.Entity<WshopIzgBrak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSHOP.IZG_Brak");

                entity.HasIndex(e => e.RecId)
                    .HasDatabaseName("IX_WSHOP_IZG_Brak_RecID");

                entity.Property(e => e.Count).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.RecId).HasColumnName("RecID");
            });

            modelBuilder.Entity<WshopIzgBrakArhive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WSHOP.IZG_Brak_ARHIVE");

                entity.Property(e => e.Count).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.RecId).HasColumnName("RecID");
            });

            modelBuilder.Entity<WshopIzgDay>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("IZG_DAY_PK");

                entity.ToTable("WSHOP.IZG_DAY");

                entity.HasIndex(e => new { e.CodUp, e.Data, e.Sm })
                    .HasDatabaseName("IZG_DAY_IX2");

                entity.HasIndex(e => new { e.Data, e.Sm, e.NomBirk })
                    .HasDatabaseName("IZG_DAY_IX5");

                entity.HasIndex(e => new { e.Det, e.Data, e.Sm })
                    .HasDatabaseName("IZG_DAY_IX4");

                entity.HasIndex(e => new { e.KolPr, e.CodUp, e.Det, e.Idizgot, e.Delrecord })
                    .HasDatabaseName("IZG_DAY_IX8");

                entity.HasIndex(e => new { e.IzgMem, e.Idrec, e.Date, e.KolPr, e.Idizgot, e.KodIzgot, e.Data, e.Sm, e.CodUp, e.Delrecord })
                    .HasDatabaseName("IZG_DAY_FAST_UP");

                entity.HasIndex(e => new { e.Sm, e.NppOper, e.LustOper, e.Idrec, e.KolPr, e.Idizgot, e.KodIzgot, e.Data, e.Det, e.Delrecord })
                    .HasDatabaseName("IZG_DAY_IX9");

                entity.HasIndex(e => new { e.Det, e.Idrec, e.KodIzgot, e.KolPr, e.Dest, e.LustOper, e.NppOper, e.Sm, e.Idizgot, e.Delrecord, e.Data })
                    .HasDatabaseName("IZG_DAY_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodUp)
                    .HasColumnName("COD_UP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Dest)
                    .HasColumnName("DEST")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Inv).HasColumnName("INV");

                entity.Property(e => e.IzgMem)
                    .HasColumnName("IZG_MEM")
                    .HasColumnType("varchar(max)")
                    .HasComment("Список изготовителей через ;");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Koeff)
                    .HasColumnName("KOEFF")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.KolIzg)
                    .HasColumnName("KOL_IZG")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.KolPr)
                    .HasColumnName("KOL_PR")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Kontrol)
                    .HasColumnName("KONTROL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Log).HasColumnName("LOG");

                entity.Property(e => e.LustOper)
                    .HasColumnName("LUST_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nn)
                    .HasColumnName("NN")
                    .HasColumnType("decimal(6, 0)")
                    .HasComment("Инвентарный номер оборудования, выбранного при отчете");

                entity.Property(e => e.NomBirk)
                    .HasColumnName("NOM_BIRK")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Priznak)
                    .HasColumnName("PRIZNAK")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Sm)
                    .HasColumnName("SM")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.TimeFin)
                    .HasColumnName("TIME_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeSetup)
                    .HasColumnName("TIME_SETUP")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeSt)
                    .HasColumnName("TIME_ST")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<WshopIzgDayCopy>(entity =>
            {
                entity.HasKey(e => e.Idrec);

                entity.ToTable("WSHOP_IZG_DAY_copy");

                entity.HasIndex(e => e.Idrec)
                    .HasDatabaseName("IX_WSHOP_IZG_DAY_copy_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.Data, e.Sm, e.CodUp, e.Fio })
                    .HasDatabaseName("IX_WSHOP_IZG_DAY_copy");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodUp)
                    .HasColumnName("COD_UP")
                    .HasMaxLength(50);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Inv).HasColumnName("INV");

                entity.Property(e => e.IzgMem)
                    .HasColumnName("IZG_MEM")
                    .IsUnicode(false);

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Koeff)
                    .HasColumnName("KOEFF")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.KolIzg)
                    .HasColumnName("KOL_IZG")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.KolPr)
                    .HasColumnName("KOL_PR")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Kontrol)
                    .HasColumnName("KONTROL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Log).HasColumnName("LOG");

                entity.Property(e => e.LustOper)
                    .HasColumnName("LUST_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Mash)
                    .HasColumnName("MASH")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nn)
                    .HasColumnName("NN")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.NomBirk).HasColumnName("NOM_BIRK");

                entity.Property(e => e.NppOper)
                    .HasColumnName("NPP_OPER")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Priznak)
                    .HasColumnName("PRIZNAK")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Sm)
                    .HasColumnName("SM")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.TimeFin)
                    .HasColumnName("TIME_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeSetup)
                    .HasColumnName("TIME_SETUP")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeSt)
                    .HasColumnName("TIME_ST")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<WshopIzgDayOutsideWorks>(entity =>
            {
                entity.HasKey(e => new { e.Idrec, e.Fio });

                entity.ToTable("WSHOP.IZG_DAY_OUTSIDE_WORKS");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .IsRequired()
                    .HasColumnName("BAI")
                    .HasMaxLength(10);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");
            });

            modelBuilder.Entity<WshopIzgDaySpec>(entity =>
            {
                entity.ToTable("WSHOP.IZG_DAY_Spec");

                entity.HasIndex(e => new { e.IdRep, e.IdSpec, e.FlagSpec, e.IdPlan })
                    .HasDatabaseName("IX_WSHOP.IZG_DAY_Spec_Column")
                    .IsUnique();

                entity.Property(e => e.IdPlan)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<WshopIzgDayf>(entity =>
            {
                entity.HasKey(e => new { e.Fio, e.Idrec })
                    .HasName("PK_FIO_IDREC");

                entity.ToTable("WSHOP.IZG_DAYF");

                entity.HasIndex(e => e.Idrec)
                    .HasDatabaseName("IZG_DAYF_IX3");

                entity.HasIndex(e => new { e.Data, e.Sm, e.Idrec, e.Idizgot, e.Fio })
                    .HasDatabaseName("IZG_DAYF_IX2");

                entity.HasIndex(e => new { e.Idrec, e.Idizgot, e.Data, e.Sm, e.Fio })
                    .HasDatabaseName("IZG_DAYF_IX1");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("date");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Sm)
                    .HasColumnName("SM")
                    .HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<WshopIzgLskm>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("IZG_LSK_M_PK");

                entity.ToTable("WSHOP.IZG_LSKM");

                entity.HasIndex(e => new { e.Data, e.Sm, e.NomBirk })
                    .HasDatabaseName("IZG_LSK_M_IX4");

                entity.HasIndex(e => new { e.Det, e.Data, e.Sm })
                    .HasDatabaseName("IZG_LSK_M_IX2");

                entity.HasIndex(e => new { e.Data, e.Sm, e.Fio, e.Det })
                    .HasDatabaseName("IZG_LSK_M_IX1");

                entity.HasIndex(e => new { e.Data, e.Sm, e.NomBirk, e.Fio })
                    .HasDatabaseName("IZG_LSK_M_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrul).HasColumnName("IDRUL");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Massa)
                    .HasColumnName("MASSA")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.NomBirk)
                    .HasColumnName("NOM_BIRK")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sm)
                    .HasColumnName("SM")
                    .HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<WshopIzgLskmArhive>(entity =>
            {
                entity.HasKey(e => e.Idrec);

                entity.ToTable("WSHOP.IZG_LSKM_ARHIVE");

                entity.Property(e => e.Idrec)
                    .HasColumnName("IDREC")
                    .ValueGeneratedNever();

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Idrul).HasColumnName("IDRUL");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Massa)
                    .HasColumnName("MASSA")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.NomBirk)
                    .HasColumnName("NOM_BIRK")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Sm)
                    .HasColumnName("SM")
                    .HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<WshopIzgOkr>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("IZG_OKR_PK");

                entity.ToTable("WSHOP.IZG_OKR");

                entity.HasIndex(e => new { e.Data, e.Sm, e.NomBirk })
                    .HasDatabaseName("IZG_OKR_IX4");

                entity.HasIndex(e => new { e.Det, e.Izd, e.Data, e.Sm })
                    .HasDatabaseName("IZG_OKR_IX2");

                entity.HasIndex(e => new { e.Data, e.Sm, e.Fio, e.Det, e.Izd })
                    .HasDatabaseName("IZG_OKR_IX1");

                entity.HasIndex(e => new { e.Data, e.Sm, e.NomBirk, e.Fio, e.Det, e.Izd })
                    .HasDatabaseName("IZG_OKR_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Izd)
                    .HasColumnName("IZD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IzgMem)
                    .HasColumnName("IZG_MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("KOD_IZGOT")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Koeff)
                    .HasColumnName("KOEFF")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.KolIzg)
                    .HasColumnName("KOL_IZG")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.KolPr)
                    .HasColumnName("KOL_PR")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomBirk)
                    .HasColumnName("NOM_BIRK")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Sm)
                    .HasColumnName("SM")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Tim)
                    .HasColumnName("TIM")
                    .HasColumnType("decimal(10, 4)");
            });

            modelBuilder.Entity<WshopIzgWhouse>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("PK__WSHOP.IZ__2A4A4C1424E5E911");

                entity.ToTable("WSHOP.IZG_WHOUSE");

                entity.HasComment("Таблица, которая хранит данные работы склада");

                entity.Property(e => e.IdRec)
                    .HasComment("ИД записи из WSHOP.IZG_DAY")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComplexityClass).HasComment("Класс сложности");

                entity.Property(e => e.ComplexityKoeff).HasComment("Коэф. сложности");

                entity.Property(e => e.ItemCount).HasComment("Кол-во наименований (артикулов)");

                entity.Property(e => e.LoadVolume).HasComment("Объем загрузки (м3)");

                entity.Property(e => e.LoadWeight).HasComment("Вес загрузки (кг)");
            });

            modelBuilder.Entity<WshopKodIzgotTarif>(entity =>
            {
                entity.ToTable("WSHOP.KodIzgot_Tarif");

                entity.HasIndex(e => new { e.IdIzgot, e.KodIzgot })
                    .HasDatabaseName("IX_WSHOP.KodIzgot_Tarif_Column")
                    .IsUnique();

                entity.Property(e => e.DateCh).HasColumnType("date");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Tarif).HasColumnType("numeric(7, 2)");
            });

            modelBuilder.Entity<WshopModArt>(entity =>
            {
                entity.ToTable("WSHOP.MOD_ART");

                entity.HasIndex(e => new { e.Articul, e.DopCod })
                    .HasDatabaseName("IX_WSHOP.MOD_ART_Column")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdMod, e.Articul, e.DopCod })
                    .HasDatabaseName("IX_WSHOP.MOD_ART_Column_2");

                entity.HasIndex(e => new { e.IdMod, e.IdIzgot, e.KodIzgot, e.Articul, e.DopCod })
                    .HasDatabaseName("IX_WSHOP.MOD_ART_Column_1");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DopCod)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<WshopModels>(entity =>
            {
                entity.ToTable("WSHOP_MODELS");

                entity.HasIndex(e => e.Model)
                    .HasDatabaseName("IX_WSHOP_MODELS_Column");

                entity.Property(e => e.Lit)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.NamModel).HasColumnName("Nam_model");
            });

            modelBuilder.Entity<WshopNorm>(entity =>
            {
                entity.ToTable("WSHOP.NORM");

                entity.HasIndex(e => new { e.IdPar, e.Det, e.NppOper })
                    .HasDatabaseName("IX_WSHOP.NORM_Column")
                    .IsUnique();

                entity.HasIndex(e => new { e.Carent, e.KodIzgot, e.Det, e.NppOper, e.IdIzgot })
                    .HasDatabaseName("IX_WSHOP.NORM_Column_1")
                    .IsUnique();

                entity.Property(e => e.Carent).HasMaxLength(20);

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("Kod_izgot")
                    .HasMaxLength(4);

                entity.Property(e => e.Norm)
                    .HasColumnType("decimal(8, 4)")
                    .HasDefaultValueSql("((0.0000))");

                entity.Property(e => e.NppOper).HasColumnName("Npp_oper");
            });

            modelBuilder.Entity<WshopNormAdd>(entity =>
            {
                entity.ToTable("WSHOP.NORM_ADD");

                entity.HasIndex(e => new { e.Articul, e.New, e.IdPar, e.Det, e.NppOper })
                    .HasDatabaseName("IX_WSHOP.NORM_ADD_Column")
                    .IsUnique();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Norm).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.NppOper).HasColumnName("Npp_oper");
            });

            modelBuilder.Entity<WshopPlanIzg>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("WSHOP.PLAN_IZG");

                entity.HasIndex(e => new { e.IdIzgot, e.NDate, e.Smena, e.Det, e.KodIzgot, e.TypeWork })
                    .HasDatabaseName("IX_WSHOP.PLAN_IZG")
                    .IsUnique();

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.KolS)
                    .HasColumnName("Kol_s")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.KolZ)
                    .HasColumnName("Kol_z")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NDate).HasColumnName("nDate");

                entity.Property(e => e.TypeWork)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<WshopSpATech>(entity =>
            {
                entity.ToTable("WSHOP.SP_A_TECH");

                entity.HasIndex(e => new { e.IdArt, e.IdWp })
                    .HasDatabaseName("IX_WSHOP.SP_A_TECH_Column")
                    .IsUnique();

                entity.Property(e => e.IdWp).HasColumnName("IdWP");
            });

            modelBuilder.Entity<WshopSpTech>(entity =>
            {
                entity.ToTable("WSHOP.SP_TECH");

                entity.HasIndex(e => new { e.IdMod, e.IdArt, e.IdPar, e.Id })
                    .HasDatabaseName("IX_WSHOP.SP_TECH_Column")
                    .IsUnique();

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Kol).HasDefaultValueSql("((1))");

                entity.Property(e => e.KolPart).HasDefaultValueSql("((100))");

                entity.Property(e => e.NamWp)
                    .IsRequired()
                    .HasColumnName("NamWP")
                    .HasMaxLength(50);

                entity.Property(e => e.NomWp).HasColumnName("NomWP");
            });

            modelBuilder.Entity<WshopSpTechACell>(entity =>
            {
                entity.ToTable("WSHOP.SP_TECH_A_CELL");

                entity.HasIndex(e => e.IdCell)
                    .HasDatabaseName("IX_WSHOP.SP_TECH_A_CELL_Column")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TimCorr).HasColumnType("numeric(8, 4)");
            });

            modelBuilder.Entity<WshopSpTechAOper>(entity =>
            {
                entity.ToTable("WSHOP.SP_TECH_A_OPER");

                entity.HasIndex(e => e.IdOper)
                    .HasDatabaseName("IX_WSHOP.SP_TECH_A_OPER_Column")
                    .IsUnique();

                entity.Property(e => e.TimCorr).HasColumnType("numeric(8, 4)");
            });

            modelBuilder.Entity<WshopSpTechCell>(entity =>
            {
                entity.ToTable("WSHOP.SP_TECH_CELL");

                entity.HasIndex(e => new { e.IdWp, e.IdArt, e.IdIzgot, e.Component, e.KodIzgot })
                    .HasDatabaseName("IX_WSHOP.SP_TECH_CELL_Column")
                    .IsUnique();

                entity.Property(e => e.Component)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IdWp).HasColumnName("IdWP");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<WshopSpTechOper>(entity =>
            {
                entity.ToTable("WSHOP.SP_TECH_OPER");

                entity.HasIndex(e => new { e.IdWp, e.IdArt, e.Det, e.NppOper, e.IdIzgot })
                    .HasDatabaseName("IX_WSHOP.SP_TECH_OPER_Column")
                    .IsUnique();

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IdWp).HasColumnName("IdWP");

                entity.Property(e => e.TimNorm).HasColumnType("numeric(10, 4)");
            });

            modelBuilder.Entity<WshopSpart>(entity =>
            {
                entity.ToTable("WSHOP.SPART");

                entity.HasIndex(e => new { e.IdMod, e.Articul })
                    .HasDatabaseName("IX_WSHOP.SPART_Column");

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Corr).HasMaxLength(1);

                entity.Property(e => e.Det).HasMaxLength(20);
            });

            modelBuilder.Entity<WshopSpcom>(entity =>
            {
                entity.ToTable("WSHOP.SPCOM");

                entity.HasIndex(e => new { e.Articul, e.IdPar, e.Corr, e.Det, e.KodIzgot })
                    .HasDatabaseName("IX_WSHOP.SPCOM_Column")
                    .IsUnique();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Corr)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasColumnName("Kod_Izgot")
                    .HasMaxLength(4);

                entity.Property(e => e.NewPar).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tim).HasColumnType("decimal(8, 6)");
            });

            modelBuilder.Entity<WshopSpec>(entity =>
            {
                entity.ToTable("WSHOP.SPEC");

                entity.HasIndex(e => new { e.IdIzgot, e.LitPar, e.Parent, e.KodPar, e.LitCar, e.Carent, e.KodIzgot, e.NppOper })
                    .HasDatabaseName("IX_WSHOP.SPEC_Column")
                    .IsUnique();

                entity.Property(e => e.Carent).HasMaxLength(20);

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("Kod_izgot")
                    .HasMaxLength(4);

                entity.Property(e => e.KodPar)
                    .HasColumnName("Kod_par")
                    .HasMaxLength(4);

                entity.Property(e => e.Kol).HasDefaultValueSql("((1))");

                entity.Property(e => e.KolPart).HasDefaultValueSql("((1))");

                entity.Property(e => e.LitCar).HasMaxLength(1);

                entity.Property(e => e.LitPar).HasMaxLength(1);

                entity.Property(e => e.NppOper).HasColumnName("Npp_oper");

                entity.Property(e => e.Parent).HasMaxLength(20);
            });

            modelBuilder.Entity<WshopSpoper>(entity =>
            {
                entity.ToTable("WSHOP.SPOPER");

                entity.HasIndex(e => new { e.Articul, e.IdModOper })
                    .HasDatabaseName("IX_WSHOP.SPOPER_Column")
                    .IsUnique();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Corr)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Norm).HasColumnType("decimal(8, 6)");

                entity.Property(e => e.Tim).HasColumnType("decimal(8, 6)");
            });

            modelBuilder.Entity<WshpSpTechAOper>(entity =>
            {
                entity.ToTable("WSHP.SP_TECH_A_OPER");

                entity.HasIndex(e => new { e.IdArt, e.IdWp, e.IdOper })
                    .HasDatabaseName("IX_WSHP.SP_TECH_A_OPER_Column")
                    .IsUnique();

                entity.Property(e => e.IdWp).HasColumnName("IdWP");

                entity.Property(e => e.TimCorr).HasColumnType("numeric(8, 4)");
            });

            modelBuilder.Entity<ZakArticMgr>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ARTIC_MGR_PK_ZAK.ARTIC_MGR1");

                entity.ToTable("ZAK.ARTIC_MGR");

                entity.HasIndex(e => new { e.Articul, e.DopCod })
                    .HasDatabaseName("ARTIC_MGR_IX1");

                entity.HasIndex(e => new { e.Articul, e.DopCod, e.Groupnew })
                    .HasDatabaseName("ARTIC_MGR_IX2");

                entity.HasIndex(e => new { e.Articul, e.DopCod, e.Idizgot, e.Delrecord })
                    .HasDatabaseName("IX_ZAK.ARTIC_MGR1")
                    .IsUnique();

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Groupnew)
                    .HasColumnName("GROUPNEW")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.PrType)
                    .HasColumnName("PR_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZakDetLabe>(entity =>
            {
                entity.HasKey(e => e.Idrec);

                entity.ToTable("ZAK.DET_LABE");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.DatSaveSql)
                    .HasColumnName("DatSaveSQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Det)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MadeIn)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole3)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole4)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole5)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole6)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole7)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Prom)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZakDetLabr>(entity =>
            {
                entity.HasKey(e => e.Idrec);

                entity.ToTable("ZAK.DET_LABR");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("Det");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.CharN)
                    .HasColumnName("Char_n")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DatSaveSql)
                    .HasColumnName("DatSaveSQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Det)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MadeIn)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Num).HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Pole1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole3)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole4)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole5)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole6)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pole7)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Prom)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZakHisSvSp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zak.HisSvSp");

                entity.HasIndex(e => e.IdGood)
                    .HasDatabaseName("IX_Zak.HisSvSp")
                    .IsUnique();

                entity.Property(e => e.DataSave).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZakKodIzgot>(entity =>
            {
                entity.ToTable("ZAK.KodIzgot");

                entity.HasIndex(e => new { e.IdIzgot, e.NSub, e.Articul, e.DopCod })
                    .HasDatabaseName("IX_Table_Column")
                    .IsUnique();

                entity.Property(e => e.Articul)
                    .IsRequired()
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(30);

                entity.Property(e => e.DopCod)
                    .IsRequired()
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(3);

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.NSub)
                    .IsRequired()
                    .HasColumnName("N_SUB")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ZakLink>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("PK__Zak.Link__2A4A4C1466F31881");

                entity.ToTable("Zak.Link");

                entity.HasIndex(e => new { e.NSub, e.IdIzgot })
                    .HasDatabaseName("IX_Zak.Link_Column")
                    .IsUnique();

                entity.Property(e => e.DateFin).HasColumnType("datetime");

                entity.Property(e => e.DateSet).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Lit)
                    .IsRequired()
                    .HasColumnName("LIT")
                    .HasMaxLength(1);

                entity.Property(e => e.NSub)
                    .IsRequired()
                    .HasColumnName("N_SUB")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ZakMatMet>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("MAT_MET_PK");

                entity.ToTable("ZAK.MAT_MET");

                entity.HasIndex(e => e.Mat)
                    .HasDatabaseName("MAT_MET_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZakNakArtDs>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("NAK_ARTIC_DS_PK");

                entity.ToTable("ZAK.NAK_ART_DS");

                entity.HasIndex(e => new { e.Nakl, e.Articul, e.DopCod })
                    .HasDatabaseName("NAK_ARTIC_DS_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datat)
                    .HasColumnName("DATAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Nakl)
                    .HasColumnName("NAKL")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(1, 0)");
            });

            modelBuilder.Entity<ZakNakArtic>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("NAK_ARTIC_PK");

                entity.ToTable("ZAK.NAK_ARTIC");

                entity.HasIndex(e => e.OrderNo)
                    .HasDatabaseName("OrderNo");

                entity.HasIndex(e => new { e.Articul, e.DopCod })
                    .HasDatabaseName("NAK_ARTIC_IX1");

                entity.HasIndex(e => new { e.NSub, e.Number, e.Delrecord })
                    .HasDatabaseName("IX_ZAK.NAK_ARTIC");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(40);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Group)
                    .HasColumnName("GROUP")
                    .HasMaxLength(50);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kodizgot)
                    .HasColumnName("KODIZGOT")
                    .HasMaxLength(4);

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NRekl)
                    .HasColumnName("N_REKL")
                    .HasMaxLength(40);

                entity.Property(e => e.NSub)
                    .IsRequired()
                    .HasColumnName("N_SUB")
                    .HasMaxLength(50);

                entity.Property(e => e.Nakl)
                    .HasColumnName("NAKL")
                    .HasMaxLength(50);

                entity.Property(e => e.Net)
                    .HasColumnName("NET")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("Order No")
                    .HasMaxLength(50);

                entity.Property(e => e.Pos)
                    .HasColumnName("POS")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prn)
                    .HasColumnName("PRN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RecIdArticD).HasColumnName("RecID_Artic_D");

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Spisanie).HasColumnName("SPISANIE");

                entity.Property(e => e.TorecId).HasColumnName("TORecID");

                entity.Property(e => e.ПерерасходNSub)
                    .HasColumnName("Перерасход_N_SUB")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZakNaklSt>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("NAKL_ST_PK");

                entity.ToTable("ZAK.NAKL_ST");

                entity.HasIndex(e => new { e.Log, e.Nakl })
                    .HasDatabaseName("ZAK.NAKL_ST_IX2");

                entity.HasIndex(e => new { e.NSub, e.Number })
                    .HasDatabaseName("IX_ZAK.NAKL_ST");

                entity.HasIndex(e => new { e.NSub, e.Number, e.Idizgot, e.Delrecord, e.Data })
                    .HasDatabaseName("ZAK.NAKL_ST_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Пользователь");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("date");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Komu)
                    .HasColumnName("KOMU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Kto)
                    .HasColumnName("KTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Log)
                    .HasColumnName("LOG")
                    .HasComment("Логика заказа (сторонний = 1)");

                entity.Property(e => e.NSub)
                    .IsRequired()
                    .HasColumnName("N_Sub")
                    .HasMaxLength(50);

                entity.Property(e => e.Nakl)
                    .HasColumnName("NAKL")
                    .HasMaxLength(50);

                entity.Property(e => e.Prin)
                    .HasColumnName("PRIN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sdal)
                    .HasColumnName("SDAL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Smena)
                    .HasColumnName("SMENA")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Spis).HasColumnName("SPIS");
            });

            modelBuilder.Entity<ZakReklamacArhive>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("REKLAMAC_PK");

                entity.ToTable("ZAK.REKLAMAC_Arhive");

                entity.HasIndex(e => e.Rekl)
                    .HasDatabaseName("REKLAMAC_IX3");

                entity.HasIndex(e => new { e.Articul, e.DopCod })
                    .HasDatabaseName("REKLAMAC_IX2");

                entity.HasIndex(e => new { e.Rekl, e.Articul, e.DopCod, e.Kol })
                    .HasDatabaseName("REKLAMAC_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Articulext)
                    .HasColumnName("ARTICULEXT")
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datab)
                    .HasColumnName("DATAB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datad)
                    .HasColumnName("DATAD")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Defekt)
                    .HasColumnName("DEFEKT")
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Done)
                    .HasColumnName("DONE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rekl).HasColumnName("REKL");

                entity.Property(e => e.Zakazch)
                    .HasColumnName("ZAKAZCH")
                    .HasMaxLength(254)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZakSpec>(entity =>
            {
                entity.HasKey(e => e.IdZak);

                entity.ToTable("Zak.Spec");

                entity.HasIndex(e => new { e.IdIzgot, e.Priznak, e.IdZak })
                    .HasDatabaseName("IX_Zak.Spec");

                entity.Property(e => e.Bai)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.Property(e => e.DataFinish).HasColumnType("datetime");

                entity.Property(e => e.DataOpen).HasColumnType("datetime");

                entity.Property(e => e.DataPlan).HasColumnType("datetime");

                entity.Property(e => e.IdIzgot).HasDefaultValueSql("((39))");

                entity.Property(e => e.NsubAsup)
                    .HasColumnName("NSubAsup")
                    .HasMaxLength(20);

                entity.Property(e => e.Order).HasMaxLength(15);
            });

            modelBuilder.Entity<ZakSpecArt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zak.SpecArt");

                entity.HasIndex(e => new { e.IdZak, e.IdGood })
                    .HasDatabaseName("IX_Zak.SpecArt")
                    .IsUnique();

                entity.Property(e => e.DataR).HasColumnType("datetime");

                entity.Property(e => e.KolP).HasDefaultValueSql("((0))");

                entity.Property(e => e.KolZ).HasDefaultValueSql("((1))");

                entity.Property(e => e.Litera)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZakSpecFile>(entity =>
            {
                entity.HasKey(e => e.IdFile);

                entity.ToTable("Zak.SpecFile");

                entity.Property(e => e.Ext)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.FileData)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.FileTmp).HasMaxLength(10);

                entity.Property(e => e.NameFile).HasMaxLength(50);
            });

            modelBuilder.Entity<ZakStKom>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ST_KOM_PK");

                entity.ToTable("ZAK.ST_KOM");

                entity.HasIndex(e => e.Articul)
                    .HasDatabaseName("ST_KOM_IX1");

                entity.HasIndex(e => e.Kom)
                    .HasDatabaseName("ST_KOM_IX2");

                entity.HasIndex(e => e.Nam)
                    .HasDatabaseName("ST_KOM_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.EdIzm)
                    .HasColumnName("ED_IZM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KolNal)
                    .HasColumnName("KOL_NAL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KolPotr)
                    .HasColumnName("KOL_POTR")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KolZak)
                    .HasColumnName("KOL_ZAK")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Kom)
                    .HasColumnName("KOM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZakStMat>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ST_MAT_PK");

                entity.ToTable("ZAK.ST_MAT");

                entity.HasIndex(e => e.Articul)
                    .HasDatabaseName("ST_MAT_IX1");

                entity.HasIndex(e => e.Mat)
                    .HasDatabaseName("ST_MAT_IX2");

                entity.HasIndex(e => e.NamR)
                    .HasDatabaseName("ST_MAT_IX3");

                entity.HasIndex(e => new { e.NamR, e.Mat, e.Delrecord, e.Idizgot })
                    .HasDatabaseName("ST_MAT_IX4");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Dos).HasColumnName("DOS");

                entity.Property(e => e.EdIzm)
                    .HasColumnName("ED_IZM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Formula)
                    .HasColumnName("FORMULA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KoeffFor)
                    .HasColumnName("KOEFF_FOR")
                    .HasColumnType("decimal(10, 5)");

                entity.Property(e => e.KolIzg)
                    .HasColumnName("KOL_IZG")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KolNal)
                    .HasColumnName("KOL_NAL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KolPotr)
                    .HasColumnName("KOL_POTR")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KolZak)
                    .HasColumnName("KOL_ZAK")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NamR)
                    .HasColumnName("NAM_R")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Osn).HasColumnName("OSN");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Raz)
                    .HasColumnName("RAZ")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZakStNorm>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ST_NORM_PK");

                entity.ToTable("ZAK.ST_NORM");

                entity.HasIndex(e => e.Articul)
                    .HasDatabaseName("ST_NORM_IX1");

                entity.HasIndex(e => e.Nam)
                    .HasDatabaseName("ST_NORM_IX2");

                entity.HasIndex(e => e.Norm)
                    .HasDatabaseName("ST_NORM_IX3");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.EdIzm)
                    .HasColumnName("ED_IZM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.KolNal)
                    .HasColumnName("KOL_NAL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KolPotr)
                    .HasColumnName("KOL_POTR")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KolZak)
                    .HasColumnName("KOL_ZAK")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Lit)
                    .HasColumnName("LIT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasColumnName("NAM")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Norm)
                    .HasColumnName("NORM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZakSvSp>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Zak.SvSp");

                entity.HasIndex(e => new { e.IdGood, e.IdMat, e.IdIzgot, e.Tp })
                    .HasDatabaseName("IX_Zak.SvSp")
                    .IsUnique();

                entity.Property(e => e.IdIzgot).HasDefaultValueSql("((39))");

                entity.Property(e => e.Kol)
                    .HasColumnType("numeric(10, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tp)
                    .HasColumnName("TP")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ZakSvSpArt>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Zak.SvSpArt");

                entity.HasIndex(e => new { e.IdGood, e.IdMat })
                    .HasDatabaseName("IX_Zak.SvSpArt");

                entity.Property(e => e.DatPost)
                    .HasColumnName("DAT_POST")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdGood).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdIzgot).HasDefaultValueSql("((39))");

                entity.Property(e => e.IdMat).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kol)
                    .HasColumnType("numeric(10, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mat)
                    .HasColumnName("MAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tp)
                    .HasColumnName("TP")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ZakZakArtic>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ZAK_ARTIC_PK");

                entity.ToTable("ZAK.ZAK_ARTIC");

                entity.HasIndex(e => e.NSub)
                    .HasDatabaseName("N_SUB");

                entity.HasIndex(e => e.OrderNo)
                    .HasDatabaseName("OrderNo");

                entity.HasIndex(e => e.TorecId)
                    .HasDatabaseName("IX_ZAK.ZAK_ARTIC_2");

                entity.HasIndex(e => e.ZakIdrec)
                    .HasDatabaseName("IX_ZAK.ZAK_ARTIC_1");

                entity.HasIndex(e => new { e.NSub, e.Articul, e.DopCod })
                    .HasDatabaseName("ZAK_ARTIC_IX2");

                entity.HasIndex(e => new { e.NSub, e.Articul, e.DopCod, e.Idizgot, e.Delrecord })
                    .HasDatabaseName("IX_ZAK.ZAK_ARTIC");

                entity.HasIndex(e => new { e.Articul, e.DopCod, e.Idrec, e.TorecId, e.DatePlan, e.DateNewPlan, e.ZakIdrec, e.Kol, e.NSub, e.Price, e.OrderNo, e.Idizgot, e.Delrecord, e.Dat })
                    .HasDatabaseName("INDEX_ZAK_ARTIC_11");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AsVvod)
                    .HasColumnName("AS_VVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.AsVyvod)
                    .HasColumnName("AS_VYVOD")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(50);

                entity.Property(e => e.BufferQuant).HasDefaultValueSql("((0))");

                entity.Property(e => e.City).HasMaxLength(40);

                entity.Property(e => e.Dat)
                    .HasColumnName("DAT")
                    .HasColumnType("date");

                entity.Property(e => e.DateNewPlan).HasColumnType("date");

                entity.Property(e => e.DatePlan).HasColumnType("date");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KolIzg)
                    .HasColumnName("KOL_IZG")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.KolSub)
                    .HasColumnName("KOL_SUB")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NRekl)
                    .HasColumnName("N_Rekl")
                    .HasMaxLength(40);

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasColumnName("Order No")
                    .HasMaxLength(50);

                entity.Property(e => e.PlLog).HasColumnName("PL_LOG");

                entity.Property(e => e.Pos)
                    .HasColumnName("POS")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE_1")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("PRICE_2")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceOpt)
                    .HasColumnName("PRICE_OPT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Prim)
                    .HasColumnName("PRIM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prizn).HasColumnName("PRIZN");

                entity.Property(e => e.Priznak).HasColumnName("PRIZNAK");

                entity.Property(e => e.RecIdArticD).HasColumnName("RecID_Artic_D");

                entity.Property(e => e.TorecId).HasColumnName("TORecID");

                entity.Property(e => e.ZakIdrec).HasColumnName("ZakIDRec");

                entity.Property(e => e.ПерерасходNSub)
                    .HasColumnName("Перерасход_N_Sub")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ZakIdrecNavigation)
                    .WithMany(p => p.ZakZakArtic)
                    .HasForeignKey(d => d.ZakIdrec)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ZAK.ZAK_ARTIC_ZAK.ZAK_ST");
            });

            modelBuilder.Entity<ZakZakArticLabels>(entity =>
            {
                entity.ToTable("ZAK.Zak_Artic_Labels");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdzakArtic).HasColumnName("IDZakArtic");

                entity.Property(e => e.LabelTemplate)
                    .HasColumnType("image")
                    .HasComment("Шаблон в экселе внешней этикетки");
            });

            modelBuilder.Entity<ZakZakAudit>(entity =>
            {
                entity.ToTable("ZAK.ZAK_AUDIT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bai)
                    .IsRequired()
                    .HasColumnName("BAI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Prizn).HasColumnName("PRIZN");

                entity.Property(e => e.ZakrecId)
                    .IsRequired()
                    .HasColumnName("ZAKRecID")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZakZakHis>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ZAK_HIS_PK");

                entity.ToTable("ZAK.ZAK_HIS");

                entity.HasIndex(e => new { e.NSub, e.As })
                    .HasDatabaseName("ZAK_HIS_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.As)
                    .HasColumnName("AS")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.Bai)
                    .HasColumnName("BAI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MemPre)
                    .HasColumnName("MEM_PRE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZakZakK3>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ZAK_K3_PK");

                entity.ToTable("ZAK.ZAK_K3");

                entity.HasIndex(e => e.NSub)
                    .HasDatabaseName("ZAK_K3_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Korp3).HasColumnName("KORP3");

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZakZakSt>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("ZAK_ST_PK");

                entity.ToTable("ZAK.ZAK_ST");

                entity.HasIndex(e => new { e.NSub, e.Idizgot, e.Delrecord })
                    .HasDatabaseName("ZAK_ST_IX1");

                entity.HasIndex(e => new { e.Idrec, e.NSub, e.Prizn, e.NBase, e.Idizgot, e.Month, e.Year, e.Delrecord })
                    .HasDatabaseName("ZAK_ST_Full_Index");

                entity.HasIndex(e => new { e.Data, e.DataCh, e.DataSend, e.Data1, e.Datsavesql, e.Idrec, e.Ist, e.Kod, e.Log, e.Mail, e.Month, e.NSub, e.Nak, e.NamZak, e.Order, e.Fio, e.Spec, e.Stor, e.Year, e.Delrecord, e.User, e.Mem, e.NBase, e.ClientCode, e.WeekNumber, e.BaseIdrec, e.SourceId, e.Prizn, e.Idizgot })
                    .HasDatabaseName("XX_IDIZGOT");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.BaseIdrec).HasColumnName("BaseIDRec");

                entity.Property(e => e.ClientCode).HasMaxLength(10);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Data1)
                    .HasColumnName("DATA1")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataCh)
                    .HasColumnName("DATA_CH")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataSend)
                    .HasColumnName("DATA_SEND")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Ist)
                    .HasColumnName("IST")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Kod)
                    .HasColumnName("KOD")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.LabelLang).HasDefaultValueSql("((0))");

                entity.Property(e => e.Log).HasColumnName("LOG");

                entity.Property(e => e.Mail)
                    .HasColumnName("MAIL")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Mem)
                    .HasColumnName("MEM")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.NBase)
                    .HasColumnName("N_Base")
                    .HasMaxLength(50);

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(50);

                entity.Property(e => e.Nak).HasColumnName("NAK");

                entity.Property(e => e.NamZak)
                    .HasColumnName("NAM_ZAK")
                    .HasMaxLength(150);

                entity.Property(e => e.Order)
                    .HasColumnName("ORDER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Prizn)
                    .HasColumnName("PRIZN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.Spec).HasColumnName("SPEC");

                entity.Property(e => e.Stor).HasColumnName("STOR");

                entity.Property(e => e.User).HasMaxLength(50);

                entity.Property(e => e.WeekNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<ZakПереносСроковЗаказа>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zak.Перенос сроков Заказа");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NBase)
                    .IsRequired()
                    .HasColumnName("N_BASE")
                    .HasMaxLength(50);

                entity.Property(e => e.NSub)
                    .IsRequired()
                    .HasColumnName("N_Sub")
                    .HasMaxLength(50);

                entity.Property(e => e.Reason).HasMaxLength(500);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Zmkbg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zmkbg");

                entity.HasIndex(e => new { e.Fid, e.Rtime })
                    .HasDatabaseName("zmkbg_clustered")
                    .IsClustered();

                entity.Property(e => e.BgrId).HasColumnName("bgrID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.GateId).HasColumnName("GateID");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Rtime)
                    .HasColumnName("RTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ZnEdTab>(entity =>
            {
                entity.ToTable("ZN.EdTab");

                entity.HasIndex(e => new { e.IdZn, e.EdTab, e.DatR })
                    .HasDatabaseName("IX_ZN.EdTab_Column")
                    .IsUnique();

                entity.Property(e => e.DatR).HasColumnType("datetime");

                entity.Property(e => e.IdZn).HasColumnName("IdZN");

                entity.Property(e => e.TimTab).HasColumnType("numeric(4, 1)");
            });

            modelBuilder.Entity<ZnEdTabNorm>(entity =>
            {
                entity.ToTable("ZN.EdTabNorm");

                entity.HasIndex(e => new { e.IdZn, e.EdTab })
                    .HasDatabaseName("IX_ZN.EdTabNorm_Column")
                    .IsUnique();

                entity.Property(e => e.IdZn).HasColumnName("IdZN");

                entity.Property(e => e.Ktu).HasColumnType("numeric(8, 4)");

                entity.Property(e => e.Prem).HasColumnType("numeric(5, 3)");

                entity.Property(e => e.Tarif).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.TimNorm).HasColumnType("numeric(6, 2)");
            });

            modelBuilder.Entity<ZnHead>(entity =>
            {
                entity.HasKey(e => e.IdHead)
                    .HasName("PK__ZN.Head__51E939FD0AE7C412");

                entity.ToTable("ZN.Head");

                entity.HasIndex(e => new { e.Izd, e.Zakaz, e.Year, e.Month, e.IdIzgot, e.DatSt, e.DatFin })
                    .HasDatabaseName("IX_ZN.Head_Column")
                    .IsUnique();

                entity.Property(e => e.DatFin).HasColumnType("date");

                entity.Property(e => e.DatSt).HasColumnType("date");

                entity.Property(e => e.Izd)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Zakaz)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ZnTabel>(entity =>
            {
                entity.ToTable("ZN.Tabel");

                entity.HasIndex(e => new { e.EdTab, e.DatR })
                    .HasDatabaseName("IX_ZN.Tabel_Column");

                entity.Property(e => e.DatR).HasColumnType("date");

                entity.Property(e => e.TimR).HasColumnType("numeric(4, 1)");
            });

            modelBuilder.Entity<ZnZn>(entity =>
            {
                entity.HasKey(e => e.IdZn)
                    .HasName("PK__Zn.Zn__B7706C091AEB3859");

                entity.ToTable("Zn.Zn");

                entity.HasIndex(e => new { e.IdHead, e.KodIzgot, e.IdZn })
                    .HasDatabaseName("IX_Zn.Zn_Column");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<ZnZnDet>(entity =>
            {
                entity.ToTable("ZN.ZnDet");

                entity.HasIndex(e => new { e.IdZn, e.Det, e.KodRkm })
                    .HasDatabaseName("IX_ZN.ZnDet_Column")
                    .IsUnique();

                entity.Property(e => e.Det)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KodRkm)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Proc).HasColumnType("numeric(8, 4)");

                entity.Property(e => e.Tarif).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.TimNorm).HasColumnType("numeric(8, 4)");
            });

            modelBuilder.Entity<ZpAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zp.All");

                entity.HasIndex(e => new { e.EdTab, e.IdIzgot, e.Year, e.Month })
                    .HasDatabaseName("IX_Zp.All")
                    .IsUnique();

                entity.Property(e => e.Avans)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Аванс");

                entity.Property(e => e.BolD)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Больничные (дней)");

                entity.Property(e => e.BolPr)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Больничные (сумма)");

                entity.Property(e => e.Bonus1)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("ежемесячные доплаты (за бригадирство и пр.)");

                entity.Property(e => e.Bonus2)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("разовая доплата руководителя (заносится вручную)");

                entity.Property(e => e.Bonus3)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Премиальная часть (%)");

                entity.Property(e => e.Br).HasComment("Бригада");

                entity.Property(e => e.Dkach)
                    .HasColumnName("DKach")
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("доплата за наставничество");

                entity.Property(e => e.Dkval)
                    .HasColumnName("DKval")
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Доплата за квалификацию");

                entity.Property(e => e.Dstag)
                    .HasColumnName("DStag")
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Доплата за стаж");

                entity.Property(e => e.Dvoz)
                    .HasColumnName("DVoz")
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Доплаты (социальные) которые добавляются к общей ЗП");

                entity.Property(e => e.EdTab).HasComment("Единый табельный номер");

                entity.Property(e => e.F)
                    .HasMaxLength(100)
                    .HasComment("Фамилия");

                entity.Property(e => e.Fio)
                    .HasMaxLength(200)
                    .HasComment("ФИО из Асуп");

                entity.Property(e => e.I)
                    .HasMaxLength(100)
                    .HasComment("Имя");

                entity.Property(e => e.IdIzgot).HasComment("ID организации из таблицы Mob.Org");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("Kod_izgot")
                    .HasMaxLength(10)
                    .HasComment("Затратная зона");

                entity.Property(e => e.KodPar)
                    .HasColumnName("Kod_par")
                    .HasMaxLength(10);

                entity.Property(e => e.Month).HasComment("Месяц");

                entity.Property(e => e.NdflB)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Удержано НДФЛ по 1С");

                entity.Property(e => e.NdflPr)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Ставка НДФЛ");

                entity.Property(e => e.NdflProc)
                    .HasColumnType("numeric(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.O)
                    .HasMaxLength(100)
                    .HasComment("Отчество");

                entity.Property(e => e.OtpComp)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Компенсация неисп. отпуска");

                entity.Property(e => e.OtpD)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Отпускные (дней)");

                entity.Property(e => e.OtpPr)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Отпускные (сумма)");

                entity.Property(e => e.Pr)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Smena).HasComment("Смена");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Статус записи (0 - первичная)");

                entity.Property(e => e.Tarif)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Тариф (руб./час)");

                entity.Property(e => e.TimExp)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Эксперементальные часы");

                entity.Property(e => e.TimNorm)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Нормочасы");

                entity.Property(e => e.TimTab)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Фактически отработаное время по табелю");

                entity.Property(e => e.UdMob)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Удержано за мобильную связь");

                entity.Property(e => e.UdPr)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UdStol)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Удержано за столовую");

                entity.Property(e => e.Year).HasComment("Год");

                entity.Property(e => e.Zp1C)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZpB)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Начислено по 1С");

                entity.Property(e => e.ZpBv)
                    .HasColumnName("ZpBV")
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Премия предыдущего месяца");
            });

            modelBuilder.Entity<ZpAllCopy2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zp.All_copy2020");

                entity.HasIndex(e => new { e.EdTab, e.IdIzgot, e.Year, e.Month })
                    .HasDatabaseName("IX_Zp.All_copy")
                    .IsUnique();

                entity.Property(e => e.Avans)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Аванс");

                entity.Property(e => e.BolD)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Больничные (дней)");

                entity.Property(e => e.BolPr)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Больничные (сумма)");

                entity.Property(e => e.Bonus1)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("ежемесячные доплаты (за бригадирство и пр.)");

                entity.Property(e => e.Bonus2)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("разовая доплата руководителя (заносится вручную)");

                entity.Property(e => e.Bonus3)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Премиальная часть (%)");

                entity.Property(e => e.Br).HasComment("Бригада");

                entity.Property(e => e.Dkach)
                    .HasColumnName("DKach")
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("доплата за наставничество");

                entity.Property(e => e.Dkval)
                    .HasColumnName("DKval")
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Доплата за квалификацию");

                entity.Property(e => e.Dstag)
                    .HasColumnName("DStag")
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Доплата за стаж");

                entity.Property(e => e.Dvoz)
                    .HasColumnName("DVoz")
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Доплаты (социальные) которые добавляются к общей ЗП");

                entity.Property(e => e.EdTab).HasComment("Единый табельный номер");

                entity.Property(e => e.F)
                    .HasMaxLength(100)
                    .HasComment("Фамилия");

                entity.Property(e => e.Fio)
                    .HasMaxLength(200)
                    .HasComment("ФИО из Асуп");

                entity.Property(e => e.I)
                    .HasMaxLength(100)
                    .HasComment("Имя");

                entity.Property(e => e.IdIzgot).HasComment("ID организации из таблицы Mob.Org");

                entity.Property(e => e.KodIzgot)
                    .HasColumnName("Kod_izgot")
                    .HasMaxLength(10)
                    .HasComment("Затратная зона");

                entity.Property(e => e.KodPar)
                    .HasColumnName("Kod_par")
                    .HasMaxLength(10);

                entity.Property(e => e.Month).HasComment("Месяц");

                entity.Property(e => e.NdflB)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Удержано НДФЛ по 1С");

                entity.Property(e => e.NdflPr)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Ставка НДФЛ");

                entity.Property(e => e.NdflProc)
                    .HasColumnType("numeric(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.O)
                    .HasMaxLength(100)
                    .HasComment("Отчество");

                entity.Property(e => e.OtpComp)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Компенсация неисп. отпуска");

                entity.Property(e => e.OtpD)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Отпускные (дней)");

                entity.Property(e => e.OtpPr)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Отпускные (сумма)");

                entity.Property(e => e.Pr)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Smena).HasComment("Смена");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Статус записи (0 - первичная)");

                entity.Property(e => e.Tarif)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Тариф (руб./час)");

                entity.Property(e => e.TimExp)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Эксперементальные часы");

                entity.Property(e => e.TimNorm)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Нормочасы");

                entity.Property(e => e.TimTab)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Фактически отработаное время по табелю");

                entity.Property(e => e.UdMob)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Удержано за мобильную связь");

                entity.Property(e => e.UdPr)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UdStol)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Удержано за столовую");

                entity.Property(e => e.Year).HasComment("Год");

                entity.Property(e => e.Zp1C)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZpB)
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Начислено по 1С");

                entity.Property(e => e.ZpBv)
                    .HasColumnName("ZpBV")
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Премия предыдущего месяца");
            });

            modelBuilder.Entity<ZpCalc>(entity =>
            {
                entity.ToTable("ZP.Calc");

                entity.HasIndex(e => new { e.EdTab, e.Month, e.Year })
                    .HasDatabaseName("IX_ZP.Calc_Column")
                    .IsUnique();

                entity.Property(e => e.BolS).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dprem1).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dprem2).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dprem3).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dstag)
                    .HasColumnName("DStag")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.F).HasMaxLength(30);

                entity.Property(e => e.I).HasMaxLength(30);

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Koeff1)
                    .HasColumnType("numeric(10, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Koeff2)
                    .HasColumnType("numeric(10, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Koeff3)
                    .HasColumnType("numeric(10, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.O).HasMaxLength(30);

                entity.Property(e => e.Oklad).HasColumnType("numeric(8, 0)");

                entity.Property(e => e.OtpS).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PrcPrem).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Tarif).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.TimExp).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.TimNorm).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.TimTab).HasColumnType("numeric(5, 1)");
            });

            modelBuilder.Entity<ZpCalcBg>(entity =>
            {
                entity.ToTable("ZP.CalcBG");

                entity.HasIndex(e => new { e.IdIzgot, e.Year, e.Month, e.EdTab })
                    .HasDatabaseName("IX_ZP.CalcBG_Column")
                    .IsUnique();

                entity.Property(e => e.BolS).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Dprem1).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Dprem2).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Dprem3).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Dstag).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.F).HasMaxLength(20);

                entity.Property(e => e.I).HasMaxLength(20);

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Koeff1)
                    .HasColumnType("decimal(6, 3)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Koeff2)
                    .HasColumnType("decimal(6, 3)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Koeff3)
                    .HasColumnType("decimal(6, 3)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.O).HasMaxLength(20);

                entity.Property(e => e.OtpS).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TimTab).HasColumnType("decimal(5, 1)");
            });

            modelBuilder.Entity<ZpCat>(entity =>
            {
                entity.ToTable("ZP.Cat");

                entity.HasIndex(e => new { e.IdIzgot, e.CatGr, e.Cat })
                    .HasDatabaseName("IX_Table_Column")
                    .IsUnique();

                entity.Property(e => e.Cat)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CatGr)
                    .HasColumnName("Cat_gr")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ZpConfig>(entity =>
            {
                entity.ToTable("ZP.CONFIG");

                entity.HasIndex(e => e.Nam)
                    .HasDatabaseName("IX_ZP.CONFIG_Column")
                    .IsUnique();

                entity.Property(e => e.DataCh).HasColumnType("datetime");

                entity.Property(e => e.Nam)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Udfname).HasColumnName("UDFname");

                entity.Property(e => e.UserCh)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ZpConfigizg>(entity =>
            {
                entity.ToTable("ZP.CONFIGIZG");

                entity.HasIndex(e => new { e.IdIzgot, e.KodIzgot, e.FieldNam })
                    .HasDatabaseName("IX_ZP.CONFIGIZG_Column_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdIzgot, e.KodIzgot, e.IdConfig })
                    .HasDatabaseName("IX_ZP.CONFIGIZG_Column")
                    .IsUnique();

                entity.Property(e => e.DataCh).HasColumnType("datetime");

                entity.Property(e => e.FieldNam)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KodIzgot).HasColumnName("KOD_IZGOT");

                entity.Property(e => e.UserCh)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ZpConfigpers>(entity =>
            {
                entity.ToTable("ZP.CONFIGPERS");

                entity.HasIndex(e => new { e.EdTab, e.IdConfig })
                    .HasDatabaseName("IX_ZP.CONFIGPERS_Column")
                    .IsUnique();

                entity.Property(e => e.DateCh).HasColumnType("datetime");

                entity.Property(e => e.UserCh)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ZpCurIzgot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zp.CurIzgot");

                entity.HasIndex(e => new { e.IdCur, e.IdIzgot })
                    .HasDatabaseName("IX_Zp.CurIzgot")
                    .IsUnique();

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<ZpDistribution>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zp.Distribution");

                entity.HasComment("Служит для распределения зарплаты по сотрудникам в разрезе периодов, объектов и бригад");

                entity.HasIndex(e => new { e.Year, e.Month, e.IdIzgot, e.KodIzgot, e.Tab })
                    .HasDatabaseName("Zp.Distribution_PK")
                    .IsUnique();

                entity.Property(e => e.IdIzgot).HasComment("Ид завода");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasColumnName("Kod_Izgot")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComment("Ид участка");

                entity.Property(e => e.Ktu)
                    .HasColumnName("KTU")
                    .HasColumnType("decimal(5, 3)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Коэф. трудового участия");

                entity.Property(e => e.Month).HasComment("Месяц");

                entity.Property(e => e.Summ).HasComment("Премирование суммой");

                entity.Property(e => e.Tab).HasComment("Единый табельный номер сотрудника");

                entity.Property(e => e.Year).HasComment("Год");
            });

            modelBuilder.Entity<ZpDocFiles>(entity =>
            {
                entity.ToTable("ZP.DocFiles");

                entity.HasIndex(e => new { e.Year, e.Month, e.Id })
                    .HasDatabaseName("IX_ZP.DocFiles_Column");

                entity.Property(e => e.Doc)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Ext)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ZpDocMonth>(entity =>
            {
                entity.ToTable("ZP.DocMonth");

                entity.HasIndex(e => new { e.EdTab, e.Year, e.Month, e.IdDoc })
                    .HasDatabaseName("IX_ZP.DocMonth_Column")
                    .IsUnique();
            });

            modelBuilder.Entity<ZpDocXlsx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZP.DocXLSx");

                entity.HasIndex(e => e.EdTab)
                    .HasDatabaseName("IX_ZP.DocXLSx_Column")
                    .IsUnique();

                entity.Property(e => e.DateChange).HasColumnType("datetime");

                entity.Property(e => e.DateCurator).HasColumnType("datetime");

                entity.Property(e => e.DateDirector).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.Doc).HasColumnType("image");

                entity.Property(e => e.Ext).HasMaxLength(10);

                entity.Property(e => e.NamDoc).IsRequired();
            });

            modelBuilder.Entity<ZpEbit>(entity =>
            {
                entity.ToTable("Zp.Ebit");

                entity.HasIndex(e => new { e.Year, e.Month, e.IdProj })
                    .HasDatabaseName("IX_Table_Column")
                    .IsUnique();
            });

            modelBuilder.Entity<ZpEbitSetup>(entity =>
            {
                entity.HasKey(e => e.IdProj)
                    .HasName("PK__Zp.EbitS__E40D97179BF8722B");

                entity.ToTable("Zp.EbitSetup");

                entity.Property(e => e.Nam).IsRequired();
            });

            modelBuilder.Entity<ZpEkCostImd>(entity =>
            {
                entity.HasKey(e => e.Idrec)
                    .HasName("EK_COST_IMDET_PK");

                entity.ToTable("ZP.EK_COST_IMD");

                entity.HasIndex(e => e.Articul)
                    .HasDatabaseName("EK_COST_IMDET_IX2");

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("EK_COST_IMDET_IX3");

                entity.HasIndex(e => new { e.Det, e.Articul })
                    .HasDatabaseName("EK_COST_IMDET_IX1");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Articul)
                    .HasColumnName("ARTICUL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Datsavesql)
                    .HasColumnName("DATSAVESQL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Delrecord).HasColumnName("DELRECORD");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");
            });

            modelBuilder.Entity<ZpHhProf>(entity =>
            {
                entity.ToTable("ZP.hh_Prof");

                entity.Property(e => e.NamProf).IsRequired();
            });

            modelBuilder.Entity<ZpHhProm>(entity =>
            {
                entity.ToTable("ZP.hh_Prom");

                entity.HasIndex(e => e.IdDolg)
                    .HasDatabaseName("IX_ZP.hh_Prom_Column")
                    .IsUnique();
            });

            modelBuilder.Entity<ZpHhSalary>(entity =>
            {
                entity.ToTable("ZP.hh_Salary");

                entity.HasIndex(e => new { e.IdProf, e.IdSpec, e.IdUr, e.Place, e.DateSave })
                    .HasDatabaseName("IX_ZP.hh_Salary_Column")
                    .IsUnique();

                entity.Property(e => e.DateSave).HasColumnType("datetime");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Salary).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<ZpHhSpec>(entity =>
            {
                entity.ToTable("ZP.hh_Spec");

                entity.Property(e => e.NamSpec).IsRequired();
            });

            modelBuilder.Entity<ZpHhUr>(entity =>
            {
                entity.ToTable("ZP.hh_Ur");

                entity.Property(e => e.NamUr).IsRequired();
            });

            modelBuilder.Entity<ZpIndivid>(entity =>
            {
                entity.ToTable("Zp.Individ");

                entity.HasIndex(e => new { e.EdTab, e.IdSt, e.DatSt })
                    .HasDatabaseName("IX_Zp.Individ_Column")
                    .IsUnique();

                entity.Property(e => e.DatFin).HasColumnType("datetime");

                entity.Property(e => e.DatSt).HasColumnType("datetime");

                entity.Property(e => e.Db)
                    .HasColumnName("DB")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Field)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Priznak).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ZpItog>(entity =>
            {
                entity.ToTable("Zp.Itog");

                entity.HasIndex(e => new { e.EdTab, e.Year, e.Month })
                    .HasDatabaseName("IX_Zp.Itog")
                    .IsUnique();

                entity.Property(e => e.CatRab).HasMaxLength(7);

                entity.Property(e => e.Dbol)
                    .HasColumnName("DBol")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dolg).HasMaxLength(250);

                entity.Property(e => e.DopOtp).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dotp)
                    .HasColumnName("DOtp")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dsoc)
                    .HasColumnName("DSoc")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.F).HasMaxLength(50);

                entity.Property(e => e.I).HasMaxLength(50);

                entity.Property(e => e.KodIzgot).HasMaxLength(4);

                entity.Property(e => e.Kompens).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Nach1C).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NachAsup)
                    .HasColumnName("NachASUP")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.O).HasMaxLength(50);

                entity.Property(e => e.OppAup).HasMaxLength(30);

                entity.Property(e => e.PrDop).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdMs)
                    .HasColumnName("UdMS")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdNdfl).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdStol).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<ZpIzgsetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZP.IZGSETUP");

                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("IX_ZP.IZGSETUP_Column_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdIzgot, e.KodIzgot, e.Priznak })
                    .HasDatabaseName("IX_ZP.IZGSETUP_Column")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Priznak).HasMaxLength(50);

                entity.Property(e => e.Znach).HasMaxLength(200);
            });

            modelBuilder.Entity<ZpKateg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zp.Kateg");

                entity.HasIndex(e => e.IdKat)
                    .HasDatabaseName("IX_Zp.Kateg")
                    .IsUnique();

                entity.Property(e => e.NamKat).HasMaxLength(150);
            });

            modelBuilder.Entity<ZpParam>(entity =>
            {
                entity.ToTable("ZP.Param");

                entity.HasIndex(e => new { e.EdTab, e.PageParam, e.RowParam, e.ColParam })
                    .HasDatabaseName("IX_ZP.Param_Column")
                    .IsUnique();

                entity.Property(e => e.IdBsc).HasColumnName("IdBSC");

                entity.Property(e => e.Kpr).HasDefaultValueSql("((1))");

                entity.Property(e => e.NamParam)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PageParam)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZpPers>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Zp.Pers");

                entity.HasIndex(e => e.EdTab)
                    .HasDatabaseName("IX_Zp.Pers")
                    .IsUnique();

                entity.Property(e => e.DateUv).HasColumnType("datetime");

                entity.Property(e => e.Firma).HasMaxLength(20);

                entity.Property(e => e.Kat)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.KodIzgot).HasMaxLength(4);

                entity.Property(e => e.LogItr).HasDefaultValueSql("((0))");

                entity.Property(e => e.Place).HasMaxLength(250);

                entity.Property(e => e.Summa).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TypZp).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ZpPersonal>(entity =>
            {
                entity.ToTable("ZP.Personal");

                entity.HasIndex(e => new { e.EdTab, e.IdIzgot })
                    .HasDatabaseName("IX_ZP.Personal_Column")
                    .IsUnique();

                entity.Property(e => e.Kind)
                    .HasColumnType("decimal(6, 3)")
                    .HasComment("1");

                entity.Property(e => e.Kkval)
                    .HasColumnType("decimal(6, 3)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasColumnName("Kod_izgot")
                    .HasMaxLength(4);

                entity.Property(e => e.Typ).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ZpPolKoeff>(entity =>
            {
                entity.ToTable("ZP.PolKoeff");

                entity.HasIndex(e => new { e.IdPolog, e.Vmin })
                    .HasDatabaseName("IX_ZP.PolKoeff_Column");

                entity.Property(e => e.Kpr).HasColumnType("decimal(10, 8)");

                entity.Property(e => e.Smax).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Smin).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TypGood).IsRequired();
            });

            modelBuilder.Entity<ZpPolog>(entity =>
            {
                entity.ToTable("ZP.Polog");

                entity.Property(e => e.DateCh).HasColumnType("datetime");

                entity.Property(e => e.NamPolog).IsRequired();

                entity.Property(e => e.PathPolog)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UserCh)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ZpSec>(entity =>
            {
                entity.ToTable("ZP.Sec");

                entity.HasIndex(e => new { e.Hid, e.IdObj })
                    .HasDatabaseName("IX_ZP.Sec_Column")
                    .IsUnique();

                entity.Property(e => e.Hid).HasColumnName("HID");

                entity.Property(e => e.ReadOnly).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ZpSecCard>(entity =>
            {
                entity.ToTable("Zp.SecCard");

                entity.HasIndex(e => new { e.EdTab, e.EdTabClient })
                    .HasDatabaseName("IX_Zp.SecCard_Column")
                    .IsUnique();
            });

            modelBuilder.Entity<ZpSecNew>(entity =>
            {
                entity.ToTable("Zp.SecNew");

                entity.HasIndex(e => new { e.Hid, e.IdObj })
                    .HasDatabaseName("IX_Zp.SecNew_Column")
                    .IsUnique();

                entity.Property(e => e.Hid).HasColumnName("HID");

                entity.Property(e => e.IdObj)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZpSecObj>(entity =>
            {
                entity.ToTable("ZP.Sec_Obj");

                entity.HasIndex(e => e.NamObj)
                    .HasDatabaseName("IX_ZP.Sec_Obj_Column")
                    .IsUnique();

                entity.Property(e => e.Nam).IsRequired();

                entity.Property(e => e.NamObj)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZpStruc>(entity =>
            {
                entity.ToTable("Zp.Struc");

                entity.HasIndex(e => new { e.IdIzgot, e.KodPar, e.KodIzgot, e.Year, e.Month })
                    .HasDatabaseName("IX_Zp.Struc_Column")
                    .IsUnique();

                entity.Property(e => e.KodIzgot)
                    .IsRequired()
                    .HasColumnName("Kod_izgot")
                    .HasMaxLength(4);

                entity.Property(e => e.KodPar)
                    .HasColumnName("Kod_par")
                    .HasMaxLength(4);

                entity.Property(e => e.Proc).HasColumnType("numeric(7, 4)");
            });

            modelBuilder.Entity<ZpSvod>(entity =>
            {
                entity.ToTable("Zp.Svod");

                entity.HasIndex(e => new { e.Idizgot, e.Faktor, e.Podr })
                    .HasDatabaseName("IX_Zp.Svod");

                entity.Property(e => e.Calc)
                    .HasColumnName("calc")
                    .HasMaxLength(200);

                entity.Property(e => e.Const)
                    .HasColumnName("const")
                    .HasColumnType("numeric(18, 5)");

                entity.Property(e => e.EdIzm)
                    .HasColumnName("edIzm")
                    .HasMaxLength(10);

                entity.Property(e => e.FKr)
                    .HasColumnName("f_kr")
                    .HasMaxLength(10);

                entity.Property(e => e.Faktor)
                    .HasColumnName("faktor")
                    .HasMaxLength(100);

                entity.Property(e => e.Format)
                    .HasColumnName("format")
                    .HasMaxLength(10);

                entity.Property(e => e.Idizgot).HasColumnName("idizgot");

                entity.Property(e => e.Podr)
                    .HasColumnName("podr")
                    .HasMaxLength(15);

                entity.Property(e => e.Priznak).HasColumnName("priznak");
            });

            modelBuilder.Entity<ZpVed>(entity =>
            {
                entity.HasKey(e => e.IdRec);

                entity.ToTable("Zp.Ved");

                entity.HasIndex(e => new { e.IdIzgot, e.Year, e.Month, e.EdTab })
                    .HasDatabaseName("IX_Zp.Ved")
                    .IsUnique();

                entity.Property(e => e.BolPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dotp)
                    .HasColumnName("DOtp")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Dvoz)
                    .HasColumnName("DVoz")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Kateg)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Nach1C).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.NachAsup)
                    .HasColumnName("NachASUP")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Ndfl).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.OtpPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdMob).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdPr).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UdStol).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<ZpVypArtic>(entity =>
            {
                entity.ToTable("Zp.VypArtic");

                entity.HasIndex(e => new { e.IdIzgot, e.Year, e.Month, e.Articul })
                    .HasDatabaseName("IX_Zp.VypArtic_Column");

                entity.HasIndex(e => new { e.Price, e.Kol, e.Year, e.Month, e.Group })
                    .HasDatabaseName("IX_YEAR_MONTH_GROUP");

                entity.HasIndex(e => new { e.IdIzgot, e.Year, e.Month, e.Lit, e.Group, e.Articul })
                    .HasDatabaseName("IX_Zp.VypArtic_Column_1");

                entity.Property(e => e.Articul).HasMaxLength(50);

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Lit)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceNew).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PriceOld).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Zp).HasMaxLength(1);
            });

            modelBuilder.Entity<ZpVypSetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zp.VypSetup");

                entity.HasIndex(e => new { e.IdIzgot, e.KodIzgot, e.IdUl })
                    .HasDatabaseName("IX_Zp.VypSetup")
                    .IsUnique();

                entity.Property(e => e.IdUl).HasColumnName("IdUL");

                entity.Property(e => e.KodIzgot).HasMaxLength(4);

                entity.Property(e => e.ProcIzg).HasColumnType("numeric(8, 6)");
            });

            modelBuilder.Entity<ZpVypusk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Zp.Vypusk");

                entity.HasIndex(e => new { e.IdIzgot, e.KodIzgot, e.Year, e.Month })
                    .HasDatabaseName("IX_Zp.Vypusk")
                    .IsUnique();

                entity.Property(e => e.KodIzgot).HasMaxLength(4);

                entity.Property(e => e.Vypusk).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<Детали>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Det)
                    .HasDatabaseName("IX_Детали")
                    .IsUnique();

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50);

                entity.Property(e => e.Dl).HasColumnName("DL");
            });

            modelBuilder.Entity<ДляПечатиПрайса>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Для печати Прайса");

                entity.HasIndex(e => new { e.ДатаФормирования, e.ДатаФормированияСравнить, e.ТипРасчета, e.ТипРасчетаСравнить, e.UserId })
                    .HasDatabaseName("IX_Для печати Прайса")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ДатаФормирования)
                    .HasColumnName("Дата формирования")
                    .HasColumnType("datetime");

                entity.Property(e => e.ДатаФормированияСравнить)
                    .HasColumnName("Дата формирования_сравнить")
                    .HasColumnType("datetime");

                entity.Property(e => e.ТипРасчета).HasColumnName("Тип расчета");

                entity.Property(e => e.ТипРасчетаСравнить).HasColumnName("Тип расчета_сравнить");
            });

            modelBuilder.Entity<Заголовки>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Заголовки");

                entity.Property(e => e.ДатаФормирования)
                    .HasColumnName("Дата формирования")
                    .HasColumnType("datetime");

                entity.Property(e => e.Завод)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Кдр)
                    .HasColumnName("КДР")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.КурсEuro)
                    .HasColumnName("Курс_EURO")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.КурсUsd)
                    .HasColumnName("Курс_USD")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.Метод)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Ндс)
                    .HasColumnName("НДС")
                    .HasMaxLength(7)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ЗаказПринят>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Заказ принят");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Idizgot).HasColumnName("IDIZGOT");

                entity.Property(e => e.Kol)
                    .HasColumnName("KOL")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NamZak)
                    .HasColumnName("NAM_ZAK")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Pos)
                    .HasColumnName("POS")
                    .HasColumnType("decimal(3, 0)");

                entity.Property(e => e.ДатаОжидаемая)
                    .HasColumnName("Дата ожидаемая")
                    .HasColumnType("datetime");

                entity.Property(e => e.Наименование)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.НомерЗаказа)
                    .HasColumnName("Номер заказа")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<КоличествоСданоПоЗаказам>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Количество сдано по заказам");

                entity.Property(e => e.Articul).HasMaxLength(44);

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.KolIzg)
                    .HasColumnName("Kol_izg")
                    .HasColumnType("decimal(38, 3)");

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<КоличествоСданоПоЗаказамIdТов>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Количество сдано по заказам_id_тов");

                entity.Property(e => e.Articul).HasMaxLength(44);

                entity.Property(e => e.DopCod)
                    .HasColumnName("DOP_COD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdТовара).HasColumnName("ID товара");

                entity.Property(e => e.KolIzg)
                    .HasColumnName("Kol_izg")
                    .HasColumnType("decimal(38, 3)");

                entity.Property(e => e.NSub)
                    .HasColumnName("N_SUB")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<МаксимальныйЧертеж>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Максимальный чертеж");

                entity.Property(e => e.Maks).HasColumnName("maks");

                entity.Property(e => e.SmCh)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<МатериалыLifo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Материалы_LIFO");

                entity.Property(e => e.EdIzm)
                    .HasColumnName("ED_IZM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdСтатьиЗатрат).HasColumnName("ID статьи затрат");

                entity.Property(e => e.IdТовара).HasColumnName("ID товара");

                entity.Property(e => e.АртикулНовый)
                    .HasColumnName("Артикул Новый")
                    .HasMaxLength(50);

                entity.Property(e => e.Наименование).HasMaxLength(1000);

                entity.Property(e => e.ТипГруппы).HasColumnName("Тип группы");

                entity.Property(e => e.ЦенаРуб)
                    .HasColumnName("Цена_руб")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ПрайсОсновной>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Прайс_основной");

                entity.Property(e => e.Expr1).HasMaxLength(2);

                entity.Property(e => e.IdИзделия).HasColumnName("ID изделия");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Артикул).HasMaxLength(30);

                entity.Property(e => e.ГруппаТовара)
                    .HasColumnName("Группа_товара")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ДатаФормирования)
                    .HasColumnName("Дата формирования")
                    .HasColumnType("datetime");

                entity.Property(e => e.Кдр)
                    .HasColumnName("КДР")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Кто).HasMaxLength(100);

                entity.Property(e => e.КурсEuro)
                    .HasColumnName("Курс_EURO")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.КурсUsd)
                    .HasColumnName("Курс_USD")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.МетодLifo)
                    .HasColumnName("Метод_LIFO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.МетодКосвенных)
                    .HasColumnName("Метод_Косвенных")
                    .HasMaxLength(4);

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Площадка).HasMaxLength(50);

                entity.Property(e => e.СНдс)
                    .HasColumnName("С_НДС")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Статус)
                    .IsRequired()
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Трудозатраты).HasColumnType("decimal(38, 10)");

                entity.Property(e => e.Участок).HasMaxLength(80);

                entity.Property(e => e.ЦенаБезНдс)
                    .HasColumnName("Цена_без_НДС")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ЦенаСНдс)
                    .HasColumnName("Цена_с_НДС")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ЧистыйВес)
                    .HasColumnName("Чистый_вес")
                    .HasColumnType("decimal(38, 10)");
            });

            modelBuilder.Entity<ПрайсОсновнойNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Прайс_основной_new");

                entity.Property(e => e.Expr1).HasMaxLength(2);

                entity.Property(e => e.IdИзделия).HasColumnName("ID изделия");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Амортизация).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Артикул).HasMaxLength(30);

                entity.Property(e => e.ВесИт)
                    .HasColumnName("вес_ит")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ГруппаТовара)
                    .HasColumnName("Группа_товара")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ДатаФормирования)
                    .HasColumnName("Дата формирования")
                    .HasColumnType("datetime");

                entity.Property(e => e.Замки).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ЗпНалоги)
                    .HasColumnName("ЗП_налоги")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ЗпПрямая)
                    .HasColumnName("ЗП_прямая")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Ит)
                    .HasColumnName("ит")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Картон).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Кдр)
                    .HasColumnName("КДР")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ким)
                    .HasColumnName("КИМ")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Комплектующие).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.КомплектующиеИмп)
                    .HasColumnName("Комплектующие_имп")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.КраскаЖидк)
                    .HasColumnName("Краска_жидк")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.КраскаПорошковая)
                    .HasColumnName("Краска_порошковая")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Крепеж).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Кто).HasMaxLength(100);

                entity.Property(e => e.КурсEuro)
                    .HasColumnName("Курс_EURO")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.КурсUsd)
                    .HasColumnName("Курс_USD")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.Материалы).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.МатериалыEuro)
                    .HasColumnName("Материалы_EURO")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.МатериалыUsd)
                    .HasColumnName("Материалы_USD")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.МетодLifo)
                    .HasColumnName("Метод_LIFO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.МетодКосвенных)
                    .HasColumnName("Метод_Косвенных")
                    .HasMaxLength(4);

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Наполнители).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.НормИт)
                    .HasColumnName("норм_ит")
                    .HasColumnType("decimal(38, 6)");

                entity.Property(e => e.Панели).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Пенопласт).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Площадка).HasMaxLength(50);

                entity.Property(e => e.СНдс)
                    .HasColumnName("С_НДС")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Статус)
                    .IsRequired()
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Сырье).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ТипРасчета).HasColumnName("Тип расчета");

                entity.Property(e => e.Трудозатраты).HasColumnType("decimal(38, 10)");

                entity.Property(e => e.Упаковка).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Участок).HasMaxLength(80);

                entity.Property(e => e.ЦенаБезНдс)
                    .HasColumnName("Цена_без_НДС")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ЦенаСНдс)
                    .HasColumnName("Цена_с_НДС")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ЧистыйВес)
                    .HasColumnName("Чистый_вес")
                    .HasColumnType("decimal(38, 10)");
            });

            modelBuilder.Entity<ПрайсСравнительный>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Прайс_сравнительный");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Артикул).HasMaxLength(30);

                entity.Property(e => e.ГруппаТовара)
                    .HasColumnName("Группа_товара")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ДатаФормирования)
                    .HasColumnName("Дата формирования")
                    .HasColumnType("datetime");

                entity.Property(e => e.ДатаФормированияСрав)
                    .HasColumnName("Дата формирования_срав")
                    .HasColumnType("datetime");

                entity.Property(e => e.ИзмЦБезНдс)
                    .HasColumnName("% изм Ц_без_НДС")
                    .HasColumnType("decimal(38, 19)");

                entity.Property(e => e.ИзмЦСНдс)
                    .HasColumnName("% изм Ц_с_НДС")
                    .HasColumnType("decimal(38, 19)");

                entity.Property(e => e.Кто).HasMaxLength(100);

                entity.Property(e => e.КурсEuro)
                    .HasColumnName("Курс_EURO")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.КурсEuroСрав)
                    .HasColumnName("Курс_EURO_срав")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.КурсUsd)
                    .HasColumnName("Курс_USD")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.КурсUsdСрав)
                    .HasColumnName("Курс_USD_срав")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.МетодLifo)
                    .HasColumnName("Метод_LIFO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.МетодLifoСрав)
                    .HasColumnName("Метод_LIFO_срав")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.МетодКос)
                    .HasColumnName("Метод_кос")
                    .HasMaxLength(4);

                entity.Property(e => e.МетодКосСрав)
                    .HasColumnName("Метод_кос_срав")
                    .HasMaxLength(4);

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Площадка).HasMaxLength(50);

                entity.Property(e => e.ПлощадкаСрав)
                    .HasColumnName("Площадка_срав")
                    .HasMaxLength(50);

                entity.Property(e => e.СНдс)
                    .HasColumnName("С_НДС")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.СНдсСрав)
                    .HasColumnName("С_НДС_срав")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Согласовал1).HasMaxLength(50);

                entity.Property(e => e.Согласовал2).HasMaxLength(50);

                entity.Property(e => e.Согласовал3).HasMaxLength(50);

                entity.Property(e => e.Согласовал4).HasMaxLength(50);

                entity.Property(e => e.Статус)
                    .IsRequired()
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Трудозатраты).HasColumnType("decimal(38, 10)");

                entity.Property(e => e.Участок).HasMaxLength(80);

                entity.Property(e => e.ЦенаБезНдс)
                    .HasColumnName("Цена_без_НДС")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ЦенаБезНдсСрав)
                    .HasColumnName("Цена_без_НДС_срав")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ЦенаСНдс)
                    .HasColumnName("Цена_с_НДС")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ЦенаСНдсСрав)
                    .HasColumnName("Цена_с_НДС_срав")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ЧистыйВес)
                    .HasColumnName("Чистый_вес")
                    .HasColumnType("decimal(38, 10)");
            });

            modelBuilder.Entity<ПрасСравнение>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Прас_сравнение");

                entity.Property(e => e.IdИзделия).HasColumnName("ID изделия");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ДатаФормирования)
                    .HasColumnName("Дата формирования")
                    .HasColumnType("datetime");

                entity.Property(e => e.Кдр)
                    .HasColumnName("КДР")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.КурсEuro)
                    .HasColumnName("Курс_EURO")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.КурсUsd)
                    .HasColumnName("Курс_USD")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.МетодLifo)
                    .HasColumnName("Метод_LIFO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.МетодКосвенных)
                    .HasColumnName("Метод_Косвенных")
                    .HasMaxLength(4);

                entity.Property(e => e.Площадка).HasMaxLength(50);

                entity.Property(e => e.СНдс)
                    .HasColumnName("С_НДС")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ЦенаБезНдс)
                    .HasColumnName("Цена_без_НДС")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ЦенаСНдс)
                    .HasColumnName("Цена_с_НДС")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Расчет>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Расчет");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdВалюты).HasColumnName("ID валюты");

                entity.Property(e => e.IdМатериала).HasColumnName("ID материала");

                entity.Property(e => e.IdПозиции).HasColumnName("ID позиции");

                entity.Property(e => e.IdПозицииСебестоимости).HasColumnName("ID позиции себестоимости");

                entity.Property(e => e.IdСтатьиЗатрат).HasColumnName("ID статьи затрат");

                entity.Property(e => e.IdТовара).HasColumnName("ID товара");

                entity.Property(e => e.Вес).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ДатаФормирования)
                    .HasColumnName("Дата формирования")
                    .HasColumnType("datetime");

                entity.Property(e => e.Деталь).HasMaxLength(202);

                entity.Property(e => e.ЕдИзм)
                    .HasColumnName("Ед_изм")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ЗаголовокРаздела)
                    .HasColumnName("Заголовок раздела")
                    .HasMaxLength(100);

                entity.Property(e => e.ИтогоРуб)
                    .HasColumnName("Итого_руб")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Кдр)
                    .HasColumnName("КДР")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ким)
                    .HasColumnName("КИМ")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ким2)
                    .HasColumnName("КИМ2")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ким3)
                    .HasColumnName("КИМ3")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Количество).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.КурсEuro)
                    .HasColumnName("Курс_EURO")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.КурсUsd)
                    .HasColumnName("Курс_USD")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.МетодLifo)
                    .HasColumnName("Метод_LIFO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.МетодКосвенных)
                    .HasColumnName("Метод_Косвенных")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.НормаВыработкиПоCell)
                    .HasColumnName("Норма выработки по CELL")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.НормаРасхода)
                    .HasColumnName("Норма расхода")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.СНдс)
                    .HasColumnName("С_НДС")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.Статья).HasColumnName("статья");

                entity.Property(e => e.ТипРасчета).HasColumnName("Тип расчета");

                entity.Property(e => e.Цена).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ЦенаСправочник)
                    .HasColumnName("Цена справочник")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<РасчетСс>(entity =>
            {
                entity.ToTable("Расчет_СС");

                entity.HasIndex(e => e.ДатаФормирования)
                    .HasDatabaseName("IX_Расчет_СС_1");

                entity.HasIndex(e => new { e.IdИзделия, e.ТипРасчета })
                    .HasDatabaseName("Расчет_СС_IX1");

                entity.HasIndex(e => new { e.ДатаФормирования, e.IdИзделия, e.Площадка, e.IdТовара })
                    .HasDatabaseName("IX_Расчет_СС");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdВалюты)
                    .HasColumnName("ID валюты")
                    .HasDefaultValueSql("((11))");

                entity.Property(e => e.IdИзделия).HasColumnName("ID изделия");

                entity.Property(e => e.IdТовара).HasColumnName("ID товара");

                entity.Property(e => e.Вес).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ДатаФормирования)
                    .HasColumnName("Дата формирования")
                    .HasColumnType("datetime");

                entity.Property(e => e.Деталь).HasMaxLength(100);

                entity.Property(e => e.ЕдИзм)
                    .HasColumnName("Ед_изм")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ЗаголовокРаздела)
                    .HasColumnName("Заголовок раздела")
                    .HasMaxLength(100);

                entity.Property(e => e.ИтогоРуб)
                    .HasColumnName("Итого_руб")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Кдр)
                    .HasColumnName("КДР")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ким)
                    .HasColumnName("КИМ")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Количество).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Кто).HasMaxLength(100);

                entity.Property(e => e.КурсEuro)
                    .HasColumnName("Курс_EURO")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.КурсUsd)
                    .HasColumnName("Курс_USD")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.МетодLifo)
                    .HasColumnName("Метод_LIFO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.МетодЗп)
                    .HasColumnName("Метод_ЗП")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.МетодКосвенных)
                    .HasColumnName("Метод_Косвенных")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Ндс)
                    .HasColumnName("НДС")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.НормаВыработкиПоCell)
                    .HasColumnName("Норма выработки по CELL")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.НормаРасхода)
                    .HasColumnName("Норма расхода")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Площадка).HasDefaultValueSql("((39))");

                entity.Property(e => e.Примечание)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ПримечаниеКПрайсу)
                    .HasColumnName("Примечание к Прайсу")
                    .HasMaxLength(255);

                entity.Property(e => e.СНдс)
                    .HasColumnName("С_НДС")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ТипРасчета).HasColumnName("Тип расчета");

                entity.Property(e => e.Цена).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ЦенаСправочник)
                    .HasColumnName("Цена справочник")
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Норма зарплаты по участку по справочнику норм");
            });

            modelBuilder.Entity<РасчетСсАрхив>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Расчет_СС_архив");

                entity.HasIndex(e => e.Id)
                    .HasDatabaseName("IX_Расчет_СС_архив")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdВалюты)
                    .HasColumnName("ID валюты")
                    .HasDefaultValueSql("((11))");

                entity.Property(e => e.IdИзделия).HasColumnName("ID изделия");

                entity.Property(e => e.IdТовара).HasColumnName("ID товара");

                entity.Property(e => e.Вес).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ДатаФормирования)
                    .HasColumnName("Дата формирования")
                    .HasColumnType("datetime");

                entity.Property(e => e.Деталь).HasMaxLength(100);

                entity.Property(e => e.ЕдИзм)
                    .HasColumnName("Ед_изм")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ЗаголовокРаздела)
                    .HasColumnName("Заголовок раздела")
                    .HasMaxLength(100);

                entity.Property(e => e.ИтогоРуб)
                    .HasColumnName("Итого_руб")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Кдр)
                    .HasColumnName("КДР")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Ким)
                    .HasColumnName("КИМ")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Количество).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Кто).HasMaxLength(100);

                entity.Property(e => e.КурсEuro)
                    .HasColumnName("Курс_EURO")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.КурсUsd)
                    .HasColumnName("Курс_USD")
                    .HasColumnType("decimal(7, 3)");

                entity.Property(e => e.МетодLifo)
                    .HasColumnName("Метод_LIFO")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.МетодЗп)
                    .HasColumnName("Метод_ЗП")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.МетодКосвенных)
                    .HasColumnName("Метод_Косвенных")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Ндс)
                    .HasColumnName("НДС")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.НормаВыработкиПоCell)
                    .HasColumnName("Норма выработки по CELL")
                    .HasColumnType("decimal(8, 4)");

                entity.Property(e => e.НормаРасхода)
                    .HasColumnName("Норма расхода")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Площадка).HasDefaultValueSql("((39))");

                entity.Property(e => e.Примечание)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ПримечаниеКПрайсу)
                    .HasColumnName("Примечание к Прайсу")
                    .HasMaxLength(255);

                entity.Property(e => e.СНдс)
                    .HasColumnName("С_НДС")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.ТипРасчета).HasColumnName("Тип расчета");

                entity.Property(e => e.Цена).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ЦенаСправочник)
                    .HasColumnName("Цена справочник")
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Норма зарплаты по участку по справочнику норм");
            });

            modelBuilder.Entity<РасчетСсКраскаПрошковая>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Расчет_СС_краска_прошковая");

                entity.Property(e => e.IdИзделия).HasColumnName("ID изделия");

                entity.Property(e => e.ДатаФормирования)
                    .HasColumnName("Дата формирования")
                    .HasColumnType("datetime");

                entity.Property(e => e.Замки).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ЗпНалоги)
                    .HasColumnName("ЗП_налоги")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ЗпПрямая)
                    .HasColumnName("ЗП_прямая")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Ит)
                    .HasColumnName("ит")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Картон).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Комплектующие).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.КомплектующиеИмп)
                    .HasColumnName("Комплектующие_имп")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Краска).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.КраскаЖидкая)
                    .HasColumnName("Краска_жидкая")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.КраскаПорошковая)
                    .HasColumnName("Краска_порошковая")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Крепеж).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Материалы).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.МатериалыEuro)
                    .HasColumnName("Материалы_EURO")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.МатериалыUsd)
                    .HasColumnName("Материалы_USD")
                    .HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Наполнители).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Панели).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Пенопласт).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Сырье).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.ТипРасчета).HasColumnName("Тип расчета");

                entity.Property(e => e.Упаковка).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<РасчетСсНом>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("расчет_сс_ном");

                entity.HasIndex(e => e.IdТовара)
                    .HasDatabaseName("IX_расчет_сс_ном")
                    .IsUnique();

                entity.Property(e => e.Abc)
                    .HasColumnName("ABC")
                    .HasMaxLength(5);

                entity.Property(e => e.CalcKoef).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreaterId).HasColumnName("CreaterID");

                entity.Property(e => e.Density).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Ecbs)
                    .HasColumnName("ECBS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupOfGoods).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdCalcЕдИзм)
                    .HasColumnName("ID Calc_Ед_изм")
                    .HasMaxLength(10);

                entity.Property(e => e.IdЕдИзм)
                    .HasColumnName("ID Ед_изм")
                    .HasMaxLength(10);

                entity.Property(e => e.IdКатегории).HasColumnName("ID категории");

                entity.Property(e => e.IdПодгруппы).HasColumnName("ID подгруппы");

                entity.Property(e => e.IdТовара).HasColumnName("ID товара");

                entity.Property(e => e.LastEditDate).HasColumnType("datetime");

                entity.Property(e => e.LastEditId).HasColumnName("LastEditID");

                entity.Property(e => e.Obor).HasMaxLength(50);

                entity.Property(e => e.Place).HasMaxLength(50);

                entity.Property(e => e.Thickness).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.UseInAsup).HasColumnName("UseInASUP");

                entity.Property(e => e.Zapas).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ZapasUzmk)
                    .HasColumnName("ZapasUZMK")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Артикул).HasMaxLength(25);

                entity.Property(e => e.АртикулНовый)
                    .HasColumnName("Артикул Новый")
                    .HasMaxLength(25);

                entity.Property(e => e.Буфер).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Вес).HasDefaultValueSql("((0))");

                entity.Property(e => e.Грузоотправитель).HasDefaultValueSql("((9))");

                entity.Property(e => e.Грузополучатель).HasDefaultValueSql("((11))");

                entity.Property(e => e.ЕдИзм)
                    .HasColumnName("Ед_изм")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Категория).HasMaxLength(20);

                entity.Property(e => e.КодВ1с)
                    .HasColumnName("Код в 1С")
                    .HasMaxLength(25);

                entity.Property(e => e.КодВ1сПоставщика)
                    .HasColumnName("Код в 1С поставщика")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.КодТовара)
                    .IsRequired()
                    .HasColumnName("Код товара")
                    .HasMaxLength(25);

                entity.Property(e => e.КоличествоВУпаковке)
                    .HasColumnName("Количество в упаковке")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Контроль)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'Склад')");

                entity.Property(e => e.КоэфИсп)
                    .HasColumnName("Коэф_исп")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Кф).HasDefaultValueSql("((1))");

                entity.Property(e => e.Модель).HasMaxLength(20);

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.НаименованиеBlg)
                    .HasColumnName("Наименование_BLG")
                    .HasMaxLength(150);

                entity.Property(e => e.НомерГтд)
                    .HasColumnName("Номер ГТД")
                    .HasMaxLength(30);

                entity.Property(e => e.Объем).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ответственный).HasMaxLength(250);

                entity.Property(e => e.ОтрицательноеКолВо)
                    .HasColumnName("Отрицательное кол-во")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Примечание).HasMaxLength(150);

                entity.Property(e => e.Скл).HasDefaultValueSql("((1))");

                entity.Property(e => e.СтранаПроисхождения)
                    .HasColumnName("Страна происхождения")
                    .HasMaxLength(50);

                entity.Property(e => e.ТипГруппы)
                    .HasColumnName("Тип группы")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ШифрАсуп)
                    .HasColumnName("Шифр АСУП")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<РасчетСсТовар>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Расчет СС_товар");

                entity.HasIndex(e => new { e.IdТовара, e.UserId })
                    .HasDatabaseName("IX_Расчет СС_товар")
                    .IsUnique();

                entity.Property(e => e.IdТовара).HasColumnName("ID товара");

                entity.Property(e => e.UserId).HasColumnName("User ID");
            });

            modelBuilder.Entity<ТоварВЗаказеРегион>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Товар в заказе регион");

                entity.Property(e => e.AddedBy).HasMaxLength(256);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Idrec).HasColumnName("IDREC");

                entity.Property(e => e.Idzak).HasColumnName("IDZAK");

                entity.Property(e => e.IdТовара).HasColumnName("ID товара");

                entity.Property(e => e.Nds)
                    .HasColumnName("NDS")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RecordId).HasColumnName("Record ID");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(256);

                entity.Property(e => e.Title).HasMaxLength(256);

                entity.Property(e => e.UserId).HasColumnName("User ID");

                entity.Property(e => e.АртикулБазовый)
                    .HasColumnName("Артикул базовый")
                    .HasMaxLength(12);

                entity.Property(e => e.АртикулКлиента)
                    .HasColumnName("Артикул клиента")
                    .HasMaxLength(50);

                entity.Property(e => e.ДатаВывоза)
                    .HasColumnName("Дата вывоза")
                    .HasColumnType("datetime");

                entity.Property(e => e.НаименованиеКлиента)
                    .HasColumnName("Наименование клиента")
                    .HasMaxLength(150);

                entity.Property(e => e.НомерПокупателя).HasColumnName("Номер покупателя");

                entity.Property(e => e.Описание).HasMaxLength(250);

                entity.Property(e => e.Цена).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Цр)
                    .HasColumnName("ЦР")
                    .HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<Чертеж>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Чертеж");

                entity.Property(e => e.DocKon).HasColumnType("image");

                entity.Property(e => e.IdДетали)
                    .HasColumnName("ID детали")
                    .ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
