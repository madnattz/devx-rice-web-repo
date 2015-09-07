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

        predefinedReportsUpdater.AddPredefinedReport(Of CenterKP2Report)("1. รายชื่อเกษตรกรแนบข้อตกลงการจัดทำแปลงขยายพันธุ์พืช (ขพ.2)", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterKP3Report)("2. รายชื่อเกษตรกรผู้จัดทำแปลงขยายพันธุ์ (ขพ.3)", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterKP5Report)("3. ประมาณการผลผลิตเพื่อการจัดซื้อเมล็ดพันธุ์คืนจากแปลงขยายพันธุ์ (ขพ.5)", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterActivityReport)("4. แผนและผลการจัดทำแปลงขยายพันธุ์ (สมข 20103)", GetType(String), True)

        predefinedReportsUpdater.AddPredefinedReport(Of CheckQualityBeforeGrowReport)("1. รายงานผลการทดสอบคุณภาพเมล็ดพันธุ์เพื่อยืนยันคุณภาพ/ก่อนจัดทำแปลง", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterCheckFarmReport)("2. แบบบันทึกการตรวจตัดสินแปลงขยายพันธุ์ข้าวอย่างเป็นทางการ", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterCheckFarmSummaryReport)("3. รายงานผลการตรวจตัดสินคุณภาพแปลงขยายพันธุ์", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterCheckRedSeedReport)("4. รายงานปริมาณข้าวแดงที่ตรวจพบในการทดสอบคุณภาพเมล็ดพันธ์ข้าว", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterQualityForBuyReports)("5. รายงานผลการตรวจสอบคุณภาพเมล็ดพันธุ์ข้าว", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CheckQualityForMonth)("6. รายงานปริมาณการตรวจสอบคุณภาพเมล็ดพันธุ์ข้าวประจำเดือน", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of QualityBetweenStorage)("7. รายงานผลการตรวจสอบคุณภาพเมล็ดพันธุ์ระหว่างการเก็บรักษา", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterQualityHistoryReport)("8. ประวัติคุณภาพเมล็ดพันธุ์", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterQualityActivity)("9. สรุปแผนและผลการดำเนินงานตามกิจกรรมในกระบวนการผลิตเมล็ดพันธุ์", GetType(String), True)

        predefinedReportsUpdater.AddPredefinedReport(Of CenterDailyProcess)("1. แบบแผนสรุปผลการปรับปรุงสภาพเมล็ดพันธุ์รายวัน", GetType(String), True)

        predefinedReportsUpdater.AddPredefinedReport(Of CenterDailyProcess)("1. แบบแผนสรุปผลการปรับปรุงสภาพเมล็ดพันธุ์รายวัน", GetType(String), True)

        'predefinedReportsUpdater.AddPredefinedReport(Of CenterTrialBalance)("1. งบทดลอง", GetType(String), True)
        'predefinedReportsUpdater.AddPredefinedReport(Of CenterTrialBalanceV2)("2. งบทดลอง 2", GetType(String), True)
        'predefinedReportsUpdater.AddPredefinedReport(Of CenterAccCost)("3. ของบัญชีเงินทุนหมุนเวียนเพื่อผลิตและขยายพันธุ์พืช", GetType(String), True)
        'predefinedReportsUpdater.AddPredefinedReport(Of CenterPayDate)("4. สรุปผลการเบิกจ่ายเงินค่าเมล็ดพันธุ์ให้แก่เกษตรกรรายศูนย์", GetType(String), True)

        predefinedReportsUpdater.AddPredefinedReport(Of CenterTrialBalance)("01. งบทดลองรายศูนย์", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterTrialBalanceV2)("02. รายได้รายศูนย์", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterPayDate)("03. สรุปผลเบิกจ่ายเกษตรกร", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterPayDateV2)("04. รายงานผลเบิกจ่ายเกษตรกร", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterAccCost)("05. สรุปต้นทุนเมล็ดพันธุ์", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of ReportReconciliation)("06. รายงานสัมพันธ์งบทดลอง", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterTrialBalanceQuarter)("07. งบทดลองรายไตรมาส", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterTotalIndicators)("08. รายงานรวมตัวเลขตัวชี้วัดรายได้", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterTotalIndicatorsV2)("09. รายงานรวมตัวเลขตัวชี้วัดค่าใช้จ่าย", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterPlanBudget01)("10. รายงานสงป.301", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterPlanBudget02)("11. รายงานสงป.302", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterPlanBudget02v2)("12. รายงานโครงการ สงป.302", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterReportPlanTransfer03)("13. รายงาน แผนการรับ - จ่าย เงินประจำปีงบประมาณ", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterReportResultIncomeAndExpensesOfMonth)("14. รายงาน ผลการรับ - จ่าย เงินประจำเดือน", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of CenterAccountGF)("15. รายงานรายรับ-รายจ่าย เงินทุนหมุนเวียน", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of Transportation03)("16. สรุปการนำส่งรายงานรายรับ - รายจ่าย  (งท.03)", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of TransportationPayDate)("17. สรุปการนำส่งการเบิกจ่ายเกษตรกร", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of TransportationAccCost)("18. สรุปการนำส่งต้นทุนการผลิตเมล็ดพันธุ์", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of TransportationQuarter)("19. สรุปการนำส่งรายงานรายไตรมาส (งบดุล งบรายได้ค่าใช้จ่าย)", GetType(String), True)
        predefinedReportsUpdater.AddPredefinedReport(Of TransportationBudget)("20. สรุปการนำส่งรายงาน สงป.", GetType(String), True)

        Return New ModuleUpdater() {updater, predefinedReportsUpdater}
    End Function

    Public Overrides Sub Setup(application As XafApplication)
        MyBase.Setup(application)
        ' Manage various aspects of the application UI and behavior at the module level.
    End Sub
End Class
