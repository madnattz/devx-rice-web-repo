Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Linq
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports System.Collections.Generic
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Model.Core
Imports DevExpress.ExpressApp.Model.DomainLogics
Imports DevExpress.ExpressApp.Model.NodeGenerators
Imports DevExpress.ExpressApp.ReportsV2

' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppModuleBasetopic.
Public NotInheritable Class [RSMSWEBModule]
    Inherits ModuleBase
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
        Dim updater As ModuleUpdater = New Updater(objectSpace, versionFromDB)
        '//Reports 
        Dim predefinedReportsUpdater As New PredefinedReportsUpdater(Application, objectSpace, versionFromDB)

        predefinedReportsUpdater.AddPredefinedReport(Of CenterKP2Report)("1. ��ª����ɵá�Ṻ��͵�ŧ��èѴ���ŧ���¾ѹ���ת (��.2)", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterKP3Report)("2. ��ª����ɵáü��Ѵ���ŧ���¾ѹ��� (��.3)", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterKP5Report)("3. ����ҳ��üż�Ե���͡�èѴ�������紾ѹ���׹�ҡ�ŧ���¾ѹ��� (��.5)", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterActivityReport)("4. Ἱ��мš�èѴ���ŧ���¾ѹ��� (��� 20103)", GetType(String), True)

        predefinedReportsUpdater.AddPredefinedReport(Of CheckQualityBeforeGrowReport)("1. ��§ҹ�š�÷��ͺ�س�Ҿ���紾ѹ��������׹�ѹ�س�Ҿ/��͹�Ѵ���ŧ", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterCheckFarmReport)("2. Ẻ�ѹ�֡��õ�Ǩ�Ѵ�Թ�ŧ���¾ѹ���������ҧ�繷ҧ���", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterCheckFarmSummaryReport)("3. ��§ҹ�š�õ�Ǩ�Ѵ�Թ�س�Ҿ�ŧ���¾ѹ���", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterCheckRedSeedReport)("4. ��§ҹ����ҳ����ᴧ����Ǩ��㹡�÷��ͺ�س�Ҿ���紾ѹ�����", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterQualityForBuyReports)("5. ��§ҹ�š�õ�Ǩ�ͺ�س�Ҿ���紾ѹ������", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CheckQualityForMonth)("6. ��§ҹ����ҳ��õ�Ǩ�ͺ�س�Ҿ���紾ѹ�����ǻ�Ш���͹", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of QualityBetweenStorage)("7. ��§ҹ�š�õ�Ǩ�ͺ�س�Ҿ���紾ѹ��������ҧ������ѡ��", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterQualityHistoryReport)("8. ����ѵԤس�Ҿ���紾ѹ���", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterQualityActivity)("9. ��ػἹ��мš�ô��Թ�ҹ����Ԩ����㹡�кǹ��ü�Ե���紾ѹ���", GetType(String), True)

        predefinedReportsUpdater.AddPredefinedReport(Of CenterDailyProcess)("1. ẺἹ��ػ�š�û�Ѻ��ا��Ҿ���紾ѹ�������ѹ", GetType(String), True)

        predefinedReportsUpdater.AddPredefinedReport(Of CenterDailyProcess)("1. ẺἹ��ػ�š�û�Ѻ��ا��Ҿ���紾ѹ�������ѹ", GetType(String), True)

        'predefinedReportsUpdater.AddPredefinedReport(Of CenterTrialBalance)("1. �����ͧ", GetType(String), True)
        'predefinedReportsUpdater.AddPredefinedReport(Of CenterTrialBalanceV2)("2. �����ͧ 2", GetType(String), True)
        'predefinedReportsUpdater.AddPredefinedReport(Of CenterAccCost)("3. �ͧ�ѭ���Թ�ع��ع���¹���ͼ�Ե��Т��¾ѹ���ת", GetType(String), True)
        'predefinedReportsUpdater.AddPredefinedReport(Of CenterPayDate)("4. ��ػ�š���ԡ�����Թ������紾ѹ���������ɵá�����ٹ��", GetType(String), True)

        predefinedReportsUpdater.AddPredefinedReport(Of CenterTrialBalance)("01. �����ͧ����ٹ��", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterTrialBalanceV2)("02. ���������ٹ��", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterPayDate)("03. ��ػ���ԡ�����ɵá�", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterPayDateV2)("04. ��§ҹ���ԡ�����ɵá�", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterAccCost)("05. ��ػ�鹷ع���紾ѹ���", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of ReportReconciliation)("06. ��§ҹ����ѹ�짺���ͧ", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterTrialBalanceQuarter)("07. �����ͧ��������", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterTotalIndicators)("08. ��§ҹ�������Ţ��Ǫ���Ѵ�����", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterTotalIndicatorsV2)("09. ��§ҹ�������Ţ��Ǫ���Ѵ��������", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterPlanBudget01)("10. ��§ҹʧ�.301", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterPlanBudget02)("11. ��§ҹʧ�.302", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterPlanBudget02v2)("12. ��§ҹ�ç��� ʧ�.302", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterReportPlanTransfer03)("13. ��§ҹ Ἱ����Ѻ - ���� �Թ��Шӻէ�����ҳ", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterReportResultIncomeAndExpensesOfMonth)("14. ��§ҹ �š���Ѻ - ���� �Թ��Ш���͹", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterAccountGF)("15. ��§ҹ����Ѻ-��¨��� �Թ�ع��ع���¹", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of Transportation03)("16. ��ػ��ù�����§ҹ����Ѻ - ��¨���  (��.03)", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of TransportationPayDate)("17. ��ػ��ù��觡���ԡ�����ɵá�", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of TransportationAccCost)("18. ��ػ��ù��觵鹷ع��ü�Ե���紾ѹ���", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of TransportationQuarter)("19. ��ػ��ù�����§ҹ�������� (����� ��������������)", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of TransportationBudget)("20. ��ػ��ù�����§ҹ ʧ�.", GetType(String), True)

        Return New ModuleUpdater() {updater, predefinedReportsUpdater}
    End Function

    Public Overrides Sub Setup(application As XafApplication)
        MyBase.Setup(application)
        ' Manage various aspects of the application UI and behavior at the module level.
    End Sub
End Class
