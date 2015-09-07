<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CenterPayDate
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CenterPayDate))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim DynamicListLookUpSettings2 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim DynamicListLookUpSettings3 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Me.CollectionDataSource1 = New DevExpress.Persistent.Base.ReportsV2.CollectionDataSource()
        Me.dbSite = New DevExpress.Persistent.Base.ReportsV2.CollectionDataSource()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Percent = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.SeasonName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SeedYear = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
        Me.PerTotalFamer = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Score = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PerNotOverDueCount = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Total = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TotalScore = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ScoreAndWeight = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ScoreAndWeightDt = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalNotOverDueCount1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TotalNotOverDueCount2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TotalNotOverDueCount3 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TotalOverDueCount = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SUMTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PerTotalNotOver1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PerTotalNotOver2 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PerTotalNotOver3 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PerOverDueCount = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SUMNotOverDueCount = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SUMScore = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SUMFamer = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TotalSum = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CfPercent = New DevExpress.XtraReports.UI.CalculatedField()
        Me.PrmSiteStar = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PrmSiteEnd = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.CollectionDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbSite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'CollectionDataSource1
        '
        Me.CollectionDataSource1.Name = "CollectionDataSource1"
        Me.CollectionDataSource1.ObjectTypeName = "RSMSWEB.Module.Season"
        Me.CollectionDataSource1.TopReturnedRecords = 0
        '
        'dbSite
        '
        Me.dbSite.Name = "dbSite"
        Me.dbSite.ObjectTypeName = "RSMSWEB.Module.Site"
        Me.dbSite.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[SiteNo]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
        Me.dbSite.TopReturnedRecords = 0
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 32.29167!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1120.0!, 32.29167!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell20})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.SiteName")})
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell11.StylePriority.UsePadding = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "ศมข."
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell11.Weight = 1.6292845228337383R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.TotalWeight", "{0:n2}")})
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell12.Weight = 0.99999995096790151R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.TotalAmount", "{0:n2}")})
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell13.StylePriority.UsePadding = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "จำนวนเงิน (บาท)"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell13.Weight = 1.1606684294948235R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.TotalFamer", "{0:#,#}")})
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell14.StylePriority.UsePadding = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "จำนวนเกษตรกรทั้งหมด (ราย)"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell14.Weight = 1.0401673402761742R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.OverDueCount", "{0:#,#}")})
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell15.StylePriority.UsePadding = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "จำนวนเกษตรกรที่ได้รับเงินเกิน 15 วัน (ราย)"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell15.Weight = 0.94644346457827055R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.NotOverDueCount", "{0:#,#}")})
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell16.StylePriority.UsePadding = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.Text = "จำนวนเกษตรกรที่ได้รับเงินภายใน 15 วัน (ราย)"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell16.Weight = 0.978840846183518R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.TotalScore", "{0:n2}")})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell17.StylePriority.UsePadding = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell17.Weight = 0.89401071642220786R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.Score")})
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell18.StylePriority.UsePadding = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell18.Weight = 0.80581241195030229R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.Percent, "Text", "")})
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Text = "5"
        Me.XrTableCell19.Weight = 0.82594217923122693R
        '
        'Percent
        '
        Me.Percent.Description = "ร้อยละ"
        Me.Percent.Name = "Percent"
        '
        'XrTableCell20
        '
        Me.XrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.ScoreAndWeightDt", "{0:n2}")})
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell20.StylePriority.UsePadding = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell20.Weight = 0.71883013806183715R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 49.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 42.70833!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.XrLabel2, Me.XrLabel1})
        Me.ReportHeader.HeightF = 137.5!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 66.66666!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1120.0!, 70.83334!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell3, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "ศมข."
        Me.XrTableCell1.Weight = 1.6292845228337383R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "ปริมาณ กก."
        Me.XrTableCell2.Weight = 0.99999995096790151R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "จำนวนเงิน (บาท)"
        Me.XrTableCell4.Weight = 1.1606684294948235R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "จำนวนเกษตรกรทั้งหมด (ราย)"
        Me.XrTableCell3.Weight = 1.0401673402761742R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "จำนวนเกษตรกรที่ได้รับเงินเกิน 15 วัน (ราย)"
        Me.XrTableCell5.Weight = 0.94644346457827055R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "จำนวนเกษตรกรที่ได้รับเงินภายใน 15 วัน (ราย)"
        Me.XrTableCell6.Weight = 0.978840846183518R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "ร้อยละของการควบคุม ภายใน 15 วัน"
        Me.XrTableCell7.Weight = 0.89401071642220786R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Text = "คะแนนที่ได้รับ"
        Me.XrTableCell8.Weight = 0.80581241195030229R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Text = "น้ำหนัก "
        Me.XrTableCell9.Weight = 0.82594217923122693R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Text = "คะแนน X  น้ำหนัก"
        Me.XrTableCell10.Weight = 0.71883013806183715R
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.CfPercent", "ตัวชี้วัด  3.2  การเบิกจ่ายเงินค่าเมล็ดพันธุ์ให้แก่เกษตรกร  (ร้อยละ {0})")})
        Me.XrLabel2.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 23.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1120.0!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1120.0!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "สรุปผลการเบิกจ่ายเงินค่าเมล็ดพันธุ์ให้แก่เกษตรกรรายศูนย์"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 43.75!
        Me.PageFooter.Name = "PageFooter"
        '
        'SeasonName
        '
        Me.SeasonName.Description = "ฤดู"
        DynamicListLookUpSettings1.DataAdapter = Nothing
        DynamicListLookUpSettings1.DataMember = Nothing
        DynamicListLookUpSettings1.DataSource = Me.CollectionDataSource1
        DynamicListLookUpSettings1.DisplayMember = "SeasonName"
        DynamicListLookUpSettings1.FilterString = Nothing
        DynamicListLookUpSettings1.ValueMember = "SeasonName"
        Me.SeasonName.LookUpSettings = DynamicListLookUpSettings1
        Me.SeasonName.Name = "SeasonName"
        '
        'SeedYear
        '
        Me.SeedYear.Description = "ปี"
        Me.SeedYear.Name = "SeedYear"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "SP_GetReportPayDate"
        QueryParameter1.Name = "@StartSite"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.PrmSiteStar]", GetType(String))
        QueryParameter2.Name = "@EndSite"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.PrmSiteEnd]", GetType(String))
        QueryParameter3.Name = "@SeasonName"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.SeasonName]", GetType(String))
        QueryParameter4.Name = "@Year"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.SeedYear]", GetType(String))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.Parameters.Add(QueryParameter4)
        StoredProcQuery1.StoredProcName = "SP_GetReportPayDate"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'PerTotalFamer
        '
        Me.PerTotalFamer.DataMember = "SP_GetReportPayDate"
        Me.PerTotalFamer.Expression = "[TotalFamer]"
        Me.PerTotalFamer.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.PerTotalFamer.Name = "PerTotalFamer"
        '
        'Score
        '
        Me.Score.DataMember = "SP_GetReportPayDate"
        Me.Score.Expression = "Iif([TotalScore]<=80,1  , Iif([TotalScore]<=85,2  ,Iif([TotalScore]<=90,3  ,Iif([" & _
    "TotalScore]<=95,4  ,Iif([TotalScore]<=100,5  ,NULL ) ) ) ))"
        Me.Score.Name = "Score"
        '
        'PerNotOverDueCount
        '
        Me.PerNotOverDueCount.DataMember = "SP_GetReportPayDate"
        Me.PerNotOverDueCount.Expression = "[NotOverDueCount]"
        Me.PerNotOverDueCount.Name = "PerNotOverDueCount"
        '
        'Total
        '
        Me.Total.DataMember = "SP_GetReportPayDate"
        Me.Total.Expression = "([PerNotOverDueCount] / [PerTotalFamer])"
        Me.Total.Name = "Total"
        '
        'TotalScore
        '
        Me.TotalScore.DataMember = "SP_GetReportPayDate"
        Me.TotalScore.Expression = "[Total] * 100"
        Me.TotalScore.Name = "TotalScore"
        '
        'ScoreAndWeight
        '
        Me.ScoreAndWeight.DataMember = "SP_GetReportPayDate"
        Me.ScoreAndWeight.Expression = "([Score] * [CfPercent])"
        Me.ScoreAndWeight.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.ScoreAndWeight.Name = "ScoreAndWeight"
        '
        'ScoreAndWeightDt
        '
        Me.ScoreAndWeightDt.DataMember = "SP_GetReportPayDate"
        Me.ScoreAndWeightDt.Expression = "[ScoreAndWeight] / 100"
        Me.ScoreAndWeightDt.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.ScoreAndWeightDt.Name = "ScoreAndWeightDt"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3, Me.XrLabel20, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3})
        Me.GroupFooter1.HeightF = 190.75!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(1120.0!, 32.29167!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell30})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell21.StylePriority.UsePadding = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.Text = "รวม"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell21.Weight = 1.6292845228337383R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.TotalWeight")})
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell22.StylePriority.UsePadding = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell22.Summary = XrSummary1
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell22.Weight = 0.99999995096790151R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.TotalAmount")})
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell23.StylePriority.UsePadding = False
        Me.XrTableCell23.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell23.Summary = XrSummary2
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell23.Weight = 1.1606684294948235R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.TotalFamer")})
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell24.StylePriority.UsePadding = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:#,#}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell24.Summary = XrSummary3
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell24.Weight = 1.0401673402761742R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.OverDueCount")})
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell25.StylePriority.UsePadding = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:#,#}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell25.Summary = XrSummary4
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell25.Weight = 0.94644346457827055R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.NotOverDueCount")})
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell26.StylePriority.UsePadding = False
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:#,#}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell26.Summary = XrSummary5
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell26.Weight = 0.978840846183518R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.TotalSum", "{0:n2}")})
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell27.StylePriority.UsePadding = False
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell27.Weight = 0.89401071642220786R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.SUMScore")})
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell28.StylePriority.UsePadding = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell28.Weight = 0.80581241195030229R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Weight = 0.82594217923122693R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell30.StylePriority.UsePadding = False
        Me.XrTableCell30.StylePriority.UseTextAlignment = False
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell30.Weight = 0.71883013806183715R
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.PerOverDueCount", "{0:n2}")})
        Me.XrLabel20.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(721.2864!, 131.9999!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(98.95837!, 23.0!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.Text = "XrLabel20"
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.PerTotalNotOver3", "{0:n2}")})
        Me.XrLabel19.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(721.2864!, 109.0!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(98.95837!, 23.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.Text = "XrLabel19"
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.PerTotalNotOver2", "{0:n2}")})
        Me.XrLabel18.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(721.2865!, 85.99999!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(98.95831!, 23.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "XrLabel18"
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(646.9752!, 131.9999!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(74.31128!, 23.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "คิดเป็นร้อยละ"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(646.9752!, 109.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(74.31128!, 23.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "คิดเป็นร้อยละ"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(646.9752!, 85.99999!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(74.31128!, 23.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "คิดเป็นร้อยละ"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(646.9751!, 63.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(74.31128!, 23.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "คิดเป็นร้อยละ"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.PerTotalNotOver1", "{0:n2}")})
        Me.XrLabel13.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(721.2864!, 63.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(98.95831!, 23.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "XrLabel13"
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.SUMTotal", "รวมทั้งสิ้น   {0:n2}  ราย")})
        Me.XrLabel12.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(530.4766!, 155.0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(116.4987!, 23.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(329.96!, 155.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(200.5164!, 23.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.OverDueCount")})
        Me.XrLabel10.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(530.4764!, 132.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(116.4987!, 23.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        XrSummary6.FormatString = "จำนวน   {0:#,#}  ราย"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel10.Summary = XrSummary6
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.NotOverDueCount3")})
        Me.XrLabel9.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(530.4765!, 109.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(116.4987!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        XrSummary7.FormatString = "จำนวน   {0:#,#}  ราย"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel9.Summary = XrSummary7
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.NotOverDueCount2")})
        Me.XrLabel8.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(530.4764!, 85.99999!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(116.4987!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        XrSummary8.FormatString = "จำนวน   {0:#,#}  ราย"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel8.Summary = XrSummary8
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(329.96!, 132.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(200.5164!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "เบิกจ่ายเกิน  15  วัน"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(329.96!, 109.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(200.5164!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "สามารถเบิกจ่ายภายใน  11 - 15  วัน"
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(329.96!, 85.99999!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(200.5164!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "สามารถเบิกจ่ายภายใน  6 - 10  วัน  "
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(329.96!, 63.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(200.5164!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "สามารถเบิกจ่ายภายใน  5  วัน  "
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportPayDate.NotOverDueCount1")})
        Me.XrLabel3.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(530.4764!, 63.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(116.4987!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        XrSummary9.FormatString = "จำนวน   {0:#,#}  ราย"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel3.Summary = XrSummary9
        '
        'TotalNotOverDueCount1
        '
        Me.TotalNotOverDueCount1.DataMember = "SP_GetReportPayDate"
        Me.TotalNotOverDueCount1.Expression = "[].Sum([NotOverDueCount1])"
        Me.TotalNotOverDueCount1.Name = "TotalNotOverDueCount1"
        '
        'TotalNotOverDueCount2
        '
        Me.TotalNotOverDueCount2.DataMember = "SP_GetReportPayDate"
        Me.TotalNotOverDueCount2.Expression = "[].Sum([NotOverDueCount2])"
        Me.TotalNotOverDueCount2.Name = "TotalNotOverDueCount2"
        '
        'TotalNotOverDueCount3
        '
        Me.TotalNotOverDueCount3.DataMember = "SP_GetReportPayDate"
        Me.TotalNotOverDueCount3.Expression = "[].Sum([NotOverDueCount3])"
        Me.TotalNotOverDueCount3.Name = "TotalNotOverDueCount3"
        '
        'TotalOverDueCount
        '
        Me.TotalOverDueCount.DataMember = "SP_GetReportPayDate"
        Me.TotalOverDueCount.Expression = "[].Sum([OverDueCount])"
        Me.TotalOverDueCount.Name = "TotalOverDueCount"
        '
        'SUMTotal
        '
        Me.SUMTotal.DataMember = "SP_GetReportPayDate"
        Me.SUMTotal.Expression = "[TotalNotOverDueCount1] + [TotalNotOverDueCount2] + [TotalNotOverDueCount3] + [To" & _
    "talOverDueCount]"
        Me.SUMTotal.Name = "SUMTotal"
        '
        'PerTotalNotOver1
        '
        Me.PerTotalNotOver1.DataMember = "SP_GetReportPayDate"
        Me.PerTotalNotOver1.Expression = "([].Avg([TotalNotOverDueCount1]) / [SUMTotal]) * 100"
        Me.PerTotalNotOver1.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.PerTotalNotOver1.Name = "PerTotalNotOver1"
        '
        'PerTotalNotOver2
        '
        Me.PerTotalNotOver2.DataMember = "SP_GetReportPayDate"
        Me.PerTotalNotOver2.Expression = "([].Avg([TotalNotOverDueCount2]) / [SUMTotal]) * 100"
        Me.PerTotalNotOver2.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.PerTotalNotOver2.Name = "PerTotalNotOver2"
        '
        'PerTotalNotOver3
        '
        Me.PerTotalNotOver3.DataMember = "SP_GetReportPayDate"
        Me.PerTotalNotOver3.Expression = "([].Avg([TotalNotOverDueCount3]) / [SUMTotal]) * 100"
        Me.PerTotalNotOver3.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.PerTotalNotOver3.Name = "PerTotalNotOver3"
        '
        'PerOverDueCount
        '
        Me.PerOverDueCount.DataMember = "SP_GetReportPayDate"
        Me.PerOverDueCount.Expression = "([].Avg([TotalOverDueCount]) / [SUMTotal]) * 100"
        Me.PerOverDueCount.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.PerOverDueCount.Name = "PerOverDueCount"
        '
        'SUMNotOverDueCount
        '
        Me.SUMNotOverDueCount.DataMember = "SP_GetReportPayDate"
        Me.SUMNotOverDueCount.Expression = "[].Sum([NotOverDueCount])"
        Me.SUMNotOverDueCount.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.SUMNotOverDueCount.Name = "SUMNotOverDueCount"
        '
        'SUMScore
        '
        Me.SUMScore.DataMember = "SP_GetReportPayDate"
        Me.SUMScore.Expression = "Iif([SUMNotOverDueCount]<=80,1  , Iif([SUMNotOverDueCount]<=85,2  ,Iif([SUMNotOve" & _
    "rDueCount]<=90,3  ,Iif([SUMNotOverDueCount]<=95,4  ,Iif([SUMNotOverDueCount]<=10" & _
    "0,5  ,NULL ) ) ) ))"
        Me.SUMScore.Name = "SUMScore"
        '
        'SUMFamer
        '
        Me.SUMFamer.DataMember = "SP_GetReportPayDate"
        Me.SUMFamer.Expression = "[].Sum([TotalFamer])"
        Me.SUMFamer.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.SUMFamer.Name = "SUMFamer"
        '
        'TotalSum
        '
        Me.TotalSum.DataMember = "SP_GetReportPayDate"
        Me.TotalSum.Expression = "([SUMNotOverDueCount] / [SUMFamer]) * 100"
        Me.TotalSum.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.TotalSum.Name = "TotalSum"
        '
        'CfPercent
        '
        Me.CfPercent.DataMember = "SP_GetReportPayDate"
        Me.CfPercent.Expression = "[Parameters.Percent]"
        Me.CfPercent.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
        Me.CfPercent.Name = "CfPercent"
        '
        'PrmSiteStar
        '
        Me.PrmSiteStar.Description = "ชื่อศูยน์"
        DynamicListLookUpSettings2.DataAdapter = Nothing
        DynamicListLookUpSettings2.DataMember = Nothing
        DynamicListLookUpSettings2.DataSource = Me.dbSite
        DynamicListLookUpSettings2.DisplayMember = "SiteName"
        DynamicListLookUpSettings2.FilterString = Nothing
        DynamicListLookUpSettings2.ValueMember = "SiteNo"
        Me.PrmSiteStar.LookUpSettings = DynamicListLookUpSettings2
        Me.PrmSiteStar.Name = "PrmSiteStar"
        '
        'PrmSiteEnd
        '
        Me.PrmSiteEnd.Description = "ถึง"
        DynamicListLookUpSettings3.DataAdapter = Nothing
        DynamicListLookUpSettings3.DataMember = Nothing
        DynamicListLookUpSettings3.DataSource = Me.dbSite
        DynamicListLookUpSettings3.DisplayMember = "SiteName"
        DynamicListLookUpSettings3.FilterString = Nothing
        DynamicListLookUpSettings3.ValueMember = "SiteNo"
        Me.PrmSiteEnd.LookUpSettings = DynamicListLookUpSettings3
        Me.PrmSiteEnd.Name = "PrmSiteEnd"
        '
        'CenterPayDate
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageFooter, Me.GroupFooter1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.PerTotalFamer, Me.PerNotOverDueCount, Me.Score, Me.Total, Me.TotalScore, Me.ScoreAndWeight, Me.ScoreAndWeightDt, Me.TotalNotOverDueCount1, Me.TotalNotOverDueCount2, Me.TotalNotOverDueCount3, Me.TotalOverDueCount, Me.SUMTotal, Me.PerTotalNotOver1, Me.PerTotalNotOver2, Me.PerTotalNotOver3, Me.PerOverDueCount, Me.SUMNotOverDueCount, Me.SUMScore, Me.SUMFamer, Me.TotalSum, Me.CfPercent})
        Me.ComponentStorage.Add(Me.CollectionDataSource1)
        Me.ComponentStorage.Add(Me.SqlDataSource1)
        Me.ComponentStorage.Add(Me.dbSite)
        Me.DataSource = Me.SqlDataSource1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(20, 29, 49, 43)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.PrmSiteStar, Me.PrmSiteEnd, Me.SeasonName, Me.SeedYear, Me.Percent})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "14.2"
        CType(Me.CollectionDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbSite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents SeasonName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Protected WithEvents CollectionDataSource1 As DevExpress.Persistent.Base.ReportsV2.CollectionDataSource
    Friend WithEvents SeedYear As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PerTotalFamer As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Score As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents PerNotOverDueCount As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Total As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TotalScore As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents ScoreAndWeight As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents ScoreAndWeightDt As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalNotOverDueCount1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TotalNotOverDueCount2 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TotalNotOverDueCount3 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TotalOverDueCount As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents SUMTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PerTotalNotOver1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PerTotalNotOver2 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents PerTotalNotOver3 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PerOverDueCount As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SUMNotOverDueCount As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents SUMScore As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents SUMFamer As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TotalSum As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Percent As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents CfPercent As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents PrmSiteStar As DevExpress.XtraReports.Parameters.Parameter
    Protected WithEvents dbSite As DevExpress.Persistent.Base.ReportsV2.CollectionDataSource
    Friend WithEvents PrmSiteEnd As DevExpress.XtraReports.Parameters.Parameter
End Class
