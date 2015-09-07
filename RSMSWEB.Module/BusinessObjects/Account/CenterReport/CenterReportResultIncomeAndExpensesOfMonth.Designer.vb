<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CenterReportResultIncomeAndExpensesOfMonth
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
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CenterReportResultIncomeAndExpensesOfMonth))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim StoredProcQuery2 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter5 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter6 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary13 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary14 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary15 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary16 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary17 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary18 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary19 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary20 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary21 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim StaticListLookUpSettings1 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Me.dbSite = New DevExpress.Persistent.Base.ReportsV2.CollectionDataSource()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.NullTotalIn = New DevExpress.XtraReports.UI.CalculatedField()
        Me.dbIncome = New DevExpress.DataAccess.Sql.SqlDataSource()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NullExpendMonthIn = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TotalIncomeMonth = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrTableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.dbExpenses = New DevExpress.DataAccess.Sql.SqlDataSource()
        Me.NullTotalIncomeMonthIn = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NullIncomeMonthPreIn = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TotalIn = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TotalExpendMonthIn = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.YearID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.NullIncomeMonthPre = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrTable7 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NullIncomeMonth = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.NullTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.NullIncomeMonthIn = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.Total = New DevExpress.XtraReports.UI.CalculatedField()
        Me.NullExpendMonth = New DevExpress.XtraReports.UI.CalculatedField()
        Me.NullTotalIncomeMonth = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.NullExpendMonthPre = New DevExpress.XtraReports.UI.CalculatedField()
        Me.MonthID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.NullTotalExpendMonthIn = New DevExpress.XtraReports.UI.CalculatedField()
        Me.NullTotalExpendMonth = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TotalIncomeMonthIn = New DevExpress.XtraReports.UI.CalculatedField()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TotalExpendMonth = New DevExpress.XtraReports.UI.CalculatedField()
        Me.NullExpendPreIn = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SiteName = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.dbSite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'dbSite
        '
        Me.dbSite.Name = "dbSite"
        Me.dbSite.ObjectTypeName = "RSMSWEB.Module.Site"
        Me.dbSite.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[SiteNo]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
        Me.dbSite.TopReturnedRecords = 0
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 37.5!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'NullTotalIn
        '
        Me.NullTotalIn.DataMember = "SP_TrialBalanceExpenses"
        Me.NullTotalIn.DataSource = Me.dbIncome
        Me.NullTotalIn.Expression = "Iif([TotalIn]=0,NULL  , [TotalIn])"
        Me.NullTotalIn.Name = "NullTotalIn"
        '
        'dbIncome
        '
        Me.dbIncome.ConnectionName = "ConnectionString"
        Me.dbIncome.Name = "dbIncome"
        StoredProcQuery1.Name = "SP_TrialBalanceExpenses"
        QueryParameter1.Name = "@SiteNo"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.SiteName]", GetType(String))
        QueryParameter2.Name = "@YearID"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.YearID]", GetType(String))
        QueryParameter3.Name = "@CurMonth"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.MonthID]", GetType(String))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.StoredProcName = "SP_GetReportResultIncome"
        Me.dbIncome.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.dbIncome.ResultSchemaSerializable = resources.GetString("dbIncome.ResultSchemaSerializable")
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Text = "ใช้จ่าย"
        Me.XrTableCell18.Weight = 3.0R
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1125.0!, 28.375!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell30, Me.XrTableCell31, Me.XrTableCell32})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.R_ListID")})
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.RowSpan = 0
        Me.XrTableCell23.Weight = 0.59259256998697918R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.R_ListExpen")})
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrTableCell24.RowSpan = 0
        Me.XrTableCell24.StylePriority.UsePadding = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell24.Weight = 1.4074074300130208R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullIncomeMonthPreIn", "{0:n2}")})
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell25.StylePriority.UsePadding = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell25.Weight = 1.0R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullIncomeMonthIn", "{0:n2}")})
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell26.StylePriority.UsePadding = False
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell26.Weight = 1.0R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullTotalIncomeMonthIn", "{0:n2}")})
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell27.StylePriority.UsePadding = False
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell27.Weight = 1.0R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullExpendPreIn", "{0:n2}")})
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell28.StylePriority.UsePadding = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell28.Weight = 1.0R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullExpendMonthIn", "{0:n2}")})
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell29.StylePriority.UsePadding = False
        Me.XrTableCell29.StylePriority.UseTextAlignment = False
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell29.Weight = 1.0R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullTotalExpendMonthIn", "{0:n2}")})
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell30.StylePriority.UsePadding = False
        Me.XrTableCell30.StylePriority.UseTextAlignment = False
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell30.Weight = 1.0R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullTotalIn", "{0:n2}")})
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell31.RowSpan = 0
        Me.XrTableCell31.StylePriority.UsePadding = False
        Me.XrTableCell31.StylePriority.UseTextAlignment = False
        Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell31.Weight = 1.0R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell32.RowSpan = 0
        Me.XrTableCell32.StylePriority.UsePadding = False
        Me.XrTableCell32.StylePriority.UseTextAlignment = False
        Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell32.Weight = 1.0R
        '
        'XrTableCell67
        '
        Me.XrTableCell67.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullIncomeMonthPre")})
        Me.XrTableCell67.Name = "XrTableCell67"
        Me.XrTableCell67.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell67.StylePriority.UsePadding = False
        Me.XrTableCell67.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell67.Summary = XrSummary1
        Me.XrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell67.Weight = 1.0R
        '
        'XrTableCell63
        '
        Me.XrTableCell63.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullTotalExpendMonth", "{0:n2}")})
        Me.XrTableCell63.Name = "XrTableCell63"
        Me.XrTableCell63.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell63.StylePriority.UsePadding = False
        Me.XrTableCell63.StylePriority.UseTextAlignment = False
        Me.XrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell63.Weight = 1.0R
        '
        'NullExpendMonthIn
        '
        Me.NullExpendMonthIn.DataMember = "SP_TrialBalanceExpenses"
        Me.NullExpendMonthIn.DataSource = Me.dbIncome
        Me.NullExpendMonthIn.Expression = "Iif([ExpendMonth]=0,NULL  , [ExpendMonth])"
        Me.NullExpendMonthIn.Name = "NullExpendMonthIn"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1})
        Me.ReportHeader.HeightF = 88.375!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.SiteName", "ศูนย์เมล็ดพันธุ์ข้าว {0}")})
        Me.XrLabel2.Font = New System.Drawing.Font("Angsana New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 37.16666!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1125.0!, 28.20834!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "ศูนย์เมล็ดพันธุ์ข้าว...................................."
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.CalculatedField1", "รายงานรายรับ-รายจ่าย เงินทุนเหมุนเวียนเพื่อผลิตและขยายพันธุ์พืช  ประจำเดือน {0}")})
        Me.XrLabel1.Font = New System.Drawing.Font("Angsana New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1125.0!, 27.16667!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "รายงานรายรับ-รายจ่าย เงินทุนเหมุนเวียนเพื่อผลิตและขยายพันธุ์พืช  ประจำเดือน......" & _
    "............................"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TotalIncomeMonth
        '
        Me.TotalIncomeMonth.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.TotalIncomeMonth.Expression = "[IncomeMonthPre] + [IncomeMonth]"
        Me.TotalIncomeMonth.Name = "TotalIncomeMonth"
        '
        'XrTableCell74
        '
        Me.XrTableCell74.Name = "XrTableCell74"
        Me.XrTableCell74.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell74.RowSpan = 0
        Me.XrTableCell74.StylePriority.UsePadding = False
        Me.XrTableCell74.StylePriority.UseTextAlignment = False
        Me.XrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell74.Weight = 1.0R
        '
        'ReportFooter1
        '
        Me.ReportFooter1.HeightF = 43.75!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("R_ListID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 28.375!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable5
        '
        Me.XrTable5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable5.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(1125.0!, 28.375!)
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseTextAlignment = False
        Me.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell46, Me.XrTableCell47, Me.XrTableCell48, Me.XrTableCell49, Me.XrTableCell50, Me.XrTableCell51, Me.XrTableCell52, Me.XrTableCell53, Me.XrTableCell54, Me.XrTableCell55})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell46
        '
        Me.XrTableCell46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.R_ListID")})
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell46.StylePriority.UsePadding = False
        Me.XrTableCell46.StylePriority.UseTextAlignment = False
        Me.XrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell46.Weight = 0.5925925870639932R
        '
        'XrTableCell47
        '
        Me.XrTableCell47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.R_ListExpen")})
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell47.RowSpan = 0
        Me.XrTableCell47.StylePriority.UsePadding = False
        Me.XrTableCell47.StylePriority.UseTextAlignment = False
        Me.XrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell47.Weight = 1.4074069373916629R
        '
        'XrTableCell48
        '
        Me.XrTableCell48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullIncomeMonthPre")})
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell48.StylePriority.UsePadding = False
        Me.XrTableCell48.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell48.Summary = XrSummary2
        Me.XrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell48.Weight = 1.0R
        '
        'XrTableCell49
        '
        Me.XrTableCell49.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullIncomeMonth")})
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell49.StylePriority.UsePadding = False
        Me.XrTableCell49.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell49.Summary = XrSummary3
        Me.XrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell49.Weight = 1.0R
        '
        'XrTableCell50
        '
        Me.XrTableCell50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullTotalIncomeMonth")})
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell50.StylePriority.UsePadding = False
        Me.XrTableCell50.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell50.Summary = XrSummary4
        Me.XrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell50.Weight = 1.0R
        '
        'XrTableCell51
        '
        Me.XrTableCell51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullExpendMonthPre")})
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell51.StylePriority.UsePadding = False
        Me.XrTableCell51.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell51.Summary = XrSummary5
        Me.XrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell51.Weight = 1.0R
        '
        'XrTableCell52
        '
        Me.XrTableCell52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullExpendMonth")})
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell52.StylePriority.UsePadding = False
        Me.XrTableCell52.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell52.Summary = XrSummary6
        Me.XrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell52.Weight = 1.0R
        '
        'XrTableCell53
        '
        Me.XrTableCell53.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullTotalExpendMonth")})
        Me.XrTableCell53.Name = "XrTableCell53"
        Me.XrTableCell53.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell53.StylePriority.UsePadding = False
        Me.XrTableCell53.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:n2}"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell53.Summary = XrSummary7
        Me.XrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell53.Weight = 1.0R
        '
        'XrTableCell54
        '
        Me.XrTableCell54.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullTotal")})
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell54.RowSpan = 0
        Me.XrTableCell54.StylePriority.UsePadding = False
        Me.XrTableCell54.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:n2}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell54.Summary = XrSummary8
        Me.XrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell54.Weight = 1.0R
        '
        'XrTableCell55
        '
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell55.RowSpan = 0
        Me.XrTableCell55.StylePriority.UsePadding = False
        Me.XrTableCell55.StylePriority.UseTextAlignment = False
        Me.XrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell55.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "รวม"
        Me.XrTableCell5.Weight = 1.0R
        '
        'Detail2
        '
        Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable6})
        Me.Detail2.HeightF = 28.375!
        Me.Detail2.Name = "Detail2"
        '
        'XrTable6
        '
        Me.XrTable6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable6.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(1125.0!, 28.375!)
        Me.XrTable6.StylePriority.UseBorders = False
        Me.XrTable6.StylePriority.UseFont = False
        Me.XrTable6.StylePriority.UseTextAlignment = False
        Me.XrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell56, Me.XrTableCell57, Me.XrTableCell58, Me.XrTableCell59, Me.XrTableCell60, Me.XrTableCell61, Me.XrTableCell62, Me.XrTableCell63, Me.XrTableCell64, Me.XrTableCell65})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell56
        '
        Me.XrTableCell56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.P_ListID")})
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.RowSpan = 0
        Me.XrTableCell56.Weight = 0.59259256998697918R
        '
        'XrTableCell57
        '
        Me.XrTableCell57.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.P_ListExpen")})
        Me.XrTableCell57.Name = "XrTableCell57"
        Me.XrTableCell57.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.XrTableCell57.RowSpan = 0
        Me.XrTableCell57.StylePriority.UsePadding = False
        Me.XrTableCell57.StylePriority.UseTextAlignment = False
        Me.XrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell57.Weight = 1.4074074300130208R
        '
        'XrTableCell58
        '
        Me.XrTableCell58.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullIncomeMonthPre", "{0:n2}")})
        Me.XrTableCell58.Name = "XrTableCell58"
        Me.XrTableCell58.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell58.StylePriority.UsePadding = False
        Me.XrTableCell58.StylePriority.UseTextAlignment = False
        Me.XrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell58.Weight = 1.0R
        '
        'XrTableCell59
        '
        Me.XrTableCell59.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullIncomeMonth", "{0:n2}")})
        Me.XrTableCell59.Name = "XrTableCell59"
        Me.XrTableCell59.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell59.StylePriority.UsePadding = False
        Me.XrTableCell59.StylePriority.UseTextAlignment = False
        Me.XrTableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell59.Weight = 1.0R
        '
        'XrTableCell60
        '
        Me.XrTableCell60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullTotalIncomeMonth", "{0:n2}")})
        Me.XrTableCell60.Name = "XrTableCell60"
        Me.XrTableCell60.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell60.StylePriority.UsePadding = False
        Me.XrTableCell60.StylePriority.UseTextAlignment = False
        Me.XrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell60.Weight = 1.0R
        '
        'XrTableCell61
        '
        Me.XrTableCell61.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullExpendMonthPre", "{0:n2}")})
        Me.XrTableCell61.Name = "XrTableCell61"
        Me.XrTableCell61.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell61.StylePriority.UsePadding = False
        Me.XrTableCell61.StylePriority.UseTextAlignment = False
        Me.XrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell61.Weight = 1.0R
        '
        'XrTableCell62
        '
        Me.XrTableCell62.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullExpendMonth", "{0:n2}")})
        Me.XrTableCell62.Name = "XrTableCell62"
        Me.XrTableCell62.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell62.StylePriority.UsePadding = False
        Me.XrTableCell62.StylePriority.UseTextAlignment = False
        Me.XrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell62.Weight = 1.0R
        '
        'XrTableCell64
        '
        Me.XrTableCell64.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullTotal", "{0:n2}")})
        Me.XrTableCell64.Name = "XrTableCell64"
        Me.XrTableCell64.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell64.RowSpan = 0
        Me.XrTableCell64.StylePriority.UsePadding = False
        Me.XrTableCell64.StylePriority.UseTextAlignment = False
        Me.XrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell64.Weight = 1.0R
        '
        'XrTableCell65
        '
        Me.XrTableCell65.Name = "XrTableCell65"
        Me.XrTableCell65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell65.RowSpan = 0
        Me.XrTableCell65.StylePriority.UsePadding = False
        Me.XrTableCell65.StylePriority.UseTextAlignment = False
        Me.XrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell65.Weight = 1.0R
        '
        'dbExpenses
        '
        Me.dbExpenses.ConnectionName = "ConnectionString"
        Me.dbExpenses.Name = "dbExpenses"
        StoredProcQuery2.Name = "SP_IncomeAndExpensesOfMonth"
        QueryParameter4.Name = "@SiteNo"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.SiteName]", GetType(String))
        QueryParameter5.Name = "@YearID"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.YearID]", GetType(String))
        QueryParameter6.Name = "@CurMonth"
        QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.MonthID]", GetType(String))
        StoredProcQuery2.Parameters.Add(QueryParameter4)
        StoredProcQuery2.Parameters.Add(QueryParameter5)
        StoredProcQuery2.Parameters.Add(QueryParameter6)
        StoredProcQuery2.StoredProcName = "SP_GetReportResultExpenses"
        Me.dbExpenses.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery2})
        Me.dbExpenses.ResultSchemaSerializable = resources.GetString("dbExpenses.ResultSchemaSerializable")
        '
        'NullTotalIncomeMonthIn
        '
        Me.NullTotalIncomeMonthIn.DataMember = "SP_TrialBalanceExpenses"
        Me.NullTotalIncomeMonthIn.DataSource = Me.dbIncome
        Me.NullTotalIncomeMonthIn.Expression = "Iif([TotalIncomeMonthIn]=0, NULL , [TotalIncomeMonthIn])"
        Me.NullTotalIncomeMonthIn.Name = "NullTotalIncomeMonthIn"
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.RowSpan = 2
        Me.XrTableCell19.Text = "คงเหลือ"
        Me.XrTableCell19.Weight = 1.0R
        '
        'DetailReport1
        '
        Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2, Me.GroupHeader1})
        Me.DetailReport1.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.DetailReport1.DataSource = Me.dbExpenses
        Me.DetailReport1.FilterString = "Not IsNullOrEmpty([P_ListID])"
        Me.DetailReport1.Level = 1
        Me.DetailReport1.Name = "DetailReport1"
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Text = "ได้รับโอนเงิน"
        Me.XrTableCell15.Weight = 3.0R
        '
        'NullIncomeMonthPreIn
        '
        Me.NullIncomeMonthPreIn.DataMember = "SP_TrialBalanceExpenses"
        Me.NullIncomeMonthPreIn.DataSource = Me.dbIncome
        Me.NullIncomeMonthPreIn.Expression = "Iif([IncomeMonthPre]=0,NULL  , [IncomeMonthPre])"
        Me.NullIncomeMonthPreIn.Name = "NullIncomeMonthPreIn"
        '
        'XrTableCell22
        '
        Me.XrTableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullExpendPreIn")})
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell22.StylePriority.UsePadding = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        XrSummary9.FormatString = "{0:n2}"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell22.Summary = XrSummary9
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell22.Weight = 1.0R
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.HeightF = 50.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Angsana New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2, Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1125.0!, 50.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell15, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell20})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.RowSpan = 2
        Me.XrTableCell11.Text = "รหัส"
        Me.XrTableCell11.Weight = 0.59259256998697918R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.RowSpan = 2
        Me.XrTableCell12.Text = "รายการ"
        Me.XrTableCell12.Weight = 1.4074074300130208R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.RowSpan = 2
        Me.XrTableCell20.Text = "หมายเหตุ"
        Me.XrTableCell20.Weight = 1.0R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.RowSpan = 0
        Me.XrTableCell1.Weight = 0.59259256998697918R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.RowSpan = 0
        Me.XrTableCell2.Weight = 1.4074074300130208R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "สะสมยกมา"
        Me.XrTableCell3.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "เดือนนี้"
        Me.XrTableCell4.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "สะสมยกมา"
        Me.XrTableCell6.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "เดือนนี้"
        Me.XrTableCell7.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Text = "รวม"
        Me.XrTableCell8.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.RowSpan = 0
        Me.XrTableCell9.Weight = 1.0R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.RowSpan = 0
        Me.XrTableCell10.Weight = 1.0R
        '
        'TotalIn
        '
        Me.TotalIn.DataMember = "SP_TrialBalanceExpenses"
        Me.TotalIn.DataSource = Me.dbIncome
        Me.TotalIn.Expression = "[TotalIncomeMonthIn] - [TotalExpendMonthIn]"
        Me.TotalIn.Name = "TotalIn"
        '
        'TotalExpendMonthIn
        '
        Me.TotalExpendMonthIn.DataMember = "SP_TrialBalanceExpenses"
        Me.TotalExpendMonthIn.DataSource = Me.dbIncome
        Me.TotalExpendMonthIn.Expression = "[ExpendMonthPre] + [ExpendMonth]"
        Me.TotalExpendMonthIn.Name = "TotalExpendMonthIn"
        '
        'XrTableCell17
        '
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullIncomeMonthIn")})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell17.StylePriority.UsePadding = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        XrSummary10.FormatString = "{0:n2}"
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell17.Summary = XrSummary10
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell17.Weight = 1.0R
        '
        'XrTableCell73
        '
        Me.XrTableCell73.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullTotal")})
        Me.XrTableCell73.Name = "XrTableCell73"
        Me.XrTableCell73.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell73.RowSpan = 0
        Me.XrTableCell73.StylePriority.UsePadding = False
        Me.XrTableCell73.StylePriority.UseTextAlignment = False
        XrSummary11.FormatString = "{0:n2}"
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell73.Summary = XrSummary11
        Me.XrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell73.Weight = 1.0R
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'YearID
        '
        Me.YearID.Description = "ปีงบมาณมาณ"
        Me.YearID.Name = "YearID"
        '
        'NullIncomeMonthPre
        '
        Me.NullIncomeMonthPre.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.NullIncomeMonthPre.Expression = "Iif([IncomeMonthPre]=0,NULL  , [IncomeMonthPre])"
        Me.NullIncomeMonthPre.Name = "NullIncomeMonthPre"
        '
        'XrTable7
        '
        Me.XrTable7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable7.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrTable7.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable7.Name = "XrTable7"
        Me.XrTable7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.XrTable7.SizeF = New System.Drawing.SizeF(1125.0!, 28.375!)
        Me.XrTable7.StylePriority.UseBorders = False
        Me.XrTable7.StylePriority.UseFont = False
        Me.XrTable7.StylePriority.UseTextAlignment = False
        Me.XrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell66, Me.XrTableCell67, Me.XrTableCell68, Me.XrTableCell69, Me.XrTableCell70, Me.XrTableCell71, Me.XrTableCell72, Me.XrTableCell73, Me.XrTableCell74})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0R
        '
        'XrTableCell66
        '
        Me.XrTableCell66.Name = "XrTableCell66"
        Me.XrTableCell66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell66.RowSpan = 0
        Me.XrTableCell66.StylePriority.UsePadding = False
        Me.XrTableCell66.StylePriority.UseTextAlignment = False
        Me.XrTableCell66.Text = "รวม 3 งบ"
        Me.XrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell66.Weight = 1.9999999108235289R
        '
        'XrTableCell68
        '
        Me.XrTableCell68.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullIncomeMonth")})
        Me.XrTableCell68.Name = "XrTableCell68"
        Me.XrTableCell68.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell68.StylePriority.UsePadding = False
        Me.XrTableCell68.StylePriority.UseTextAlignment = False
        XrSummary12.FormatString = "{0:n2}"
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell68.Summary = XrSummary12
        Me.XrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell68.Weight = 1.0R
        '
        'XrTableCell69
        '
        Me.XrTableCell69.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullTotalIncomeMonth")})
        Me.XrTableCell69.Name = "XrTableCell69"
        Me.XrTableCell69.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell69.StylePriority.UsePadding = False
        Me.XrTableCell69.StylePriority.UseTextAlignment = False
        XrSummary13.FormatString = "{0:n2}"
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell69.Summary = XrSummary13
        Me.XrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell69.Weight = 1.0R
        '
        'XrTableCell70
        '
        Me.XrTableCell70.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullExpendMonthPre")})
        Me.XrTableCell70.Name = "XrTableCell70"
        Me.XrTableCell70.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell70.StylePriority.UsePadding = False
        Me.XrTableCell70.StylePriority.UseTextAlignment = False
        XrSummary14.FormatString = "{0:n2}"
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell70.Summary = XrSummary14
        Me.XrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell70.Weight = 1.0R
        '
        'XrTableCell71
        '
        Me.XrTableCell71.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullExpendMonth")})
        Me.XrTableCell71.Name = "XrTableCell71"
        Me.XrTableCell71.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell71.StylePriority.UsePadding = False
        Me.XrTableCell71.StylePriority.UseTextAlignment = False
        XrSummary15.FormatString = "{0:n2}"
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell71.Summary = XrSummary15
        Me.XrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell71.Weight = 1.0R
        '
        'XrTableCell72
        '
        Me.XrTableCell72.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_IncomeAndExpensesOfMonth.NullTotalExpendMonth")})
        Me.XrTableCell72.Name = "XrTableCell72"
        Me.XrTableCell72.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell72.StylePriority.UsePadding = False
        Me.XrTableCell72.StylePriority.UseTextAlignment = False
        XrSummary16.FormatString = "{0:n2}"
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell72.Summary = XrSummary16
        Me.XrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell72.Weight = 1.0R
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell14, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell33, Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell36})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell14.RowSpan = 0
        Me.XrTableCell14.StylePriority.UsePadding = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "รวมรายรับ"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell14.Weight = 1.9999999108235289R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullIncomeMonthPreIn")})
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell16.StylePriority.UsePadding = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        XrSummary17.FormatString = "{0:n2}"
        XrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell16.Summary = XrSummary17
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell16.Weight = 1.0R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullTotalIncomeMonthIn")})
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell21.StylePriority.UsePadding = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        XrSummary18.FormatString = "{0:n2}"
        XrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell21.Summary = XrSummary18
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell21.Weight = 1.0R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullExpendMonthIn")})
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell33.StylePriority.UsePadding = False
        Me.XrTableCell33.StylePriority.UseTextAlignment = False
        XrSummary19.FormatString = "{0:n2}"
        XrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell33.Summary = XrSummary19
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell33.Weight = 1.0R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullTotalExpendMonthIn")})
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell34.StylePriority.UsePadding = False
        Me.XrTableCell34.StylePriority.UseTextAlignment = False
        XrSummary20.FormatString = "{0:n2}"
        XrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell34.Summary = XrSummary20
        Me.XrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell34.Weight = 1.0R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_TrialBalanceExpenses.NullTotalIn")})
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell35.RowSpan = 0
        Me.XrTableCell35.StylePriority.UsePadding = False
        Me.XrTableCell35.StylePriority.UseTextAlignment = False
        XrSummary21.FormatString = "{0:n2}"
        XrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell35.Summary = XrSummary21
        Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell35.Weight = 1.0R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell36.RowSpan = 0
        Me.XrTableCell36.StylePriority.UsePadding = False
        Me.XrTableCell36.StylePriority.UseTextAlignment = False
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell36.Weight = 1.0R
        '
        'NullIncomeMonth
        '
        Me.NullIncomeMonth.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.NullIncomeMonth.Expression = "Iif([IncomeMonth]=0,NULL  , [IncomeMonth])"
        Me.NullIncomeMonth.Name = "NullIncomeMonth"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.GroupFooter1.HeightF = 28.375!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(1125.0!, 28.375!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail1.HeightF = 28.375!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'NullTotal
        '
        Me.NullTotal.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.NullTotal.Expression = "Iif([Total]=0,NULL  , [Total])"
        Me.NullTotal.Name = "NullTotal"
        '
        'NullIncomeMonthIn
        '
        Me.NullIncomeMonthIn.DataMember = "SP_TrialBalanceExpenses"
        Me.NullIncomeMonthIn.DataSource = Me.dbIncome
        Me.NullIncomeMonthIn.Expression = "Iif([IncomeMonth]=0,NULL  , [IncomeMonth])"
        Me.NullIncomeMonthIn.Name = "NullIncomeMonthIn"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable7})
        Me.GroupFooter2.HeightF = 28.375!
        Me.GroupFooter2.KeepTogether = True
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'Total
        '
        Me.Total.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.Total.Expression = "[TotalIncomeMonth] - [TotalExpendMonth]"
        Me.Total.Name = "Total"
        '
        'NullExpendMonth
        '
        Me.NullExpendMonth.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.NullExpendMonth.Expression = "Iif([ExpendMonth]=0,NULL  , [ExpendMonth])"
        Me.NullExpendMonth.Name = "NullExpendMonth"
        '
        'NullTotalIncomeMonth
        '
        Me.NullTotalIncomeMonth.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.NullTotalIncomeMonth.Expression = "Iif([TotalIncomeMonth]=0, NULL , [TotalIncomeMonth])"
        Me.NullTotalIncomeMonth.Name = "NullTotalIncomeMonth"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 67.70834!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'NullExpendMonthPre
        '
        Me.NullExpendMonthPre.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.NullExpendMonthPre.Expression = "Iif([ExpendMonthPre]=0,NULL  ,[ExpendMonthPre] )"
        Me.NullExpendMonthPre.Name = "NullExpendMonthPre"
        '
        'MonthID
        '
        Me.MonthID.Description = "ประจำเดือน"
        StaticListLookUpSettings1.FilterString = Nothing
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("1", "มกราคม"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("2", "กุมภาพันธ์"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("3", "มีนาคม"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("4", "เมษายน"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("5", "พฤษภาคม"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("6", "มิถุนายน"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("7", "กรกฎาคม"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("8", "สิงหาคม"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("9", "กันยายน"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("10", "ตุลาคม"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("11", "พฤศจิกายน"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("12", "ธันวาคม"))
        Me.MonthID.LookUpSettings = StaticListLookUpSettings1
        Me.MonthID.Name = "MonthID"
        '
        'NullTotalExpendMonthIn
        '
        Me.NullTotalExpendMonthIn.DataMember = "SP_TrialBalanceExpenses"
        Me.NullTotalExpendMonthIn.DataSource = Me.dbIncome
        Me.NullTotalExpendMonthIn.Expression = "Iif([TotalExpendMonthIn]=0, NULL ,[TotalExpendMonthIn])"
        Me.NullTotalExpendMonthIn.Name = "NullTotalExpendMonthIn"
        '
        'NullTotalExpendMonth
        '
        Me.NullTotalExpendMonth.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.NullTotalExpendMonth.Expression = "Iif([TotalExpendMonth]=0, NULL , [TotalExpendMonth])"
        Me.NullTotalExpendMonth.Name = "NullTotalExpendMonth"
        '
        'TotalIncomeMonthIn
        '
        Me.TotalIncomeMonthIn.DataMember = "SP_TrialBalanceExpenses"
        Me.TotalIncomeMonthIn.DataSource = Me.dbIncome
        Me.TotalIncomeMonthIn.Expression = "[IncomeMonthPre] + [IncomeMonth]"
        Me.TotalIncomeMonthIn.Name = "TotalIncomeMonthIn"
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupFooter1})
        Me.DetailReport.DataMember = "SP_TrialBalanceExpenses"
        Me.DetailReport.DataSource = Me.dbIncome
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.CalculatedField1.Expression = resources.GetString("CalculatedField1.Expression")
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'TotalExpendMonth
        '
        Me.TotalExpendMonth.DataMember = "SP_IncomeAndExpensesOfMonth"
        Me.TotalExpendMonth.Expression = "[ExpendMonthPre] + [ExpendMonth]"
        Me.TotalExpendMonth.Name = "TotalExpendMonth"
        '
        'NullExpendPreIn
        '
        Me.NullExpendPreIn.DataMember = "SP_TrialBalanceExpenses"
        Me.NullExpendPreIn.DataSource = Me.dbIncome
        Me.NullExpendPreIn.Expression = "Iif([ExpendMonthPre]=0,NULL  ,[ExpendMonthPre] )"
        Me.NullExpendPreIn.Name = "NullExpendPreIn"
        '
        'SiteName
        '
        Me.SiteName.Description = "ชื่อศูนย์"
        DynamicListLookUpSettings1.DataAdapter = Nothing
        DynamicListLookUpSettings1.DataMember = Nothing
        DynamicListLookUpSettings1.DataSource = Me.dbSite
        DynamicListLookUpSettings1.DisplayMember = "SiteName"
        DynamicListLookUpSettings1.FilterString = Nothing
        DynamicListLookUpSettings1.ValueMember = "SiteNo"
        Me.SiteName.LookUpSettings = DynamicListLookUpSettings1
        Me.SiteName.Name = "SiteName"
        '
        'CenterReportResultIncomeAndExpensesOfMonth
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter1, Me.DetailReport, Me.DetailReport1, Me.GroupFooter2})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.TotalIncomeMonth, Me.TotalExpendMonth, Me.Total, Me.CalculatedField1, Me.NullIncomeMonthPre, Me.NullExpendMonthPre, Me.NullIncomeMonth, Me.NullExpendMonth, Me.NullTotalIncomeMonth, Me.NullTotalExpendMonth, Me.NullTotal, Me.NullIncomeMonthPreIn, Me.NullIncomeMonthIn, Me.NullTotalIncomeMonthIn, Me.NullExpendPreIn, Me.NullExpendMonthIn, Me.NullTotalExpendMonthIn, Me.NullTotalIn, Me.TotalIn, Me.TotalExpendMonthIn, Me.TotalIncomeMonthIn})
        Me.ComponentStorage.Add(Me.dbExpenses)
        Me.ComponentStorage.Add(Me.dbIncome)
        Me.ComponentStorage.Add(Me.dbSite)
        Me.DataSource = Me.dbExpenses
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(24, 20, 68, 38)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.SiteName, Me.YearID, Me.MonthID})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "14.2"
        CType(Me.dbSite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents NullTotalIn As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents dbIncome As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell67 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell63 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NullExpendMonthIn As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalIncomeMonth As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrTableCell74 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell53 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Detail2 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell57 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell58 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell59 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell60 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell61 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell62 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell64 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell65 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents dbExpenses As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents NullTotalIncomeMonthIn As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NullIncomeMonthPreIn As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TotalIn As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TotalExpendMonthIn As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell73 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents YearID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents NullIncomeMonthPre As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrTable7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell66 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell68 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell69 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell70 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell71 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell72 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NullIncomeMonth As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents NullTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents NullIncomeMonthIn As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents Total As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents NullExpendMonth As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents NullTotalIncomeMonth As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents NullExpendMonthPre As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents MonthID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents NullTotalExpendMonthIn As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents NullTotalExpendMonth As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TotalIncomeMonthIn As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TotalExpendMonth As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents NullExpendPreIn As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents SiteName As DevExpress.XtraReports.Parameters.Parameter
    Protected WithEvents dbSite As DevExpress.Persistent.Base.ReportsV2.CollectionDataSource
End Class
