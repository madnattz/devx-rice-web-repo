<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReportReconciliation
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
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter5 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter6 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportReconciliation))
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim DynamicListLookUpSettings2 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim DynamicListLookUpSettings3 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim StaticListLookUpSettings1 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
        Dim StaticListLookUpSettings2 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
        Me.dbSite = New DevExpress.Persistent.Base.ReportsV2.CollectionDataSource()
        Me.dbAccount = New DevExpress.Persistent.Base.ReportsV2.CollectionDataSource()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell79 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell80 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Year = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
        Me.SiteName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.StartAccount = New DevExpress.XtraReports.Parameters.Parameter()
        Me.EndAccount = New DevExpress.XtraReports.Parameters.Parameter()
        Me.StartMonth = New DevExpress.XtraReports.Parameters.Parameter()
        Me.EndMonth = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.dbSite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'dbSite
        '
        Me.dbSite.Name = "dbSite"
        Me.dbSite.ObjectTypeName = "RSMSWEB.Module.Site"
        Me.dbSite.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[SiteNo]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
        Me.dbSite.TopReturnedRecords = 0
        '
        'dbAccount
        '
        Me.dbAccount.Name = "dbAccount"
        Me.dbAccount.ObjectTypeName = "RSMSWEB.Module.Account"
        Me.dbAccount.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[AccountID]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
        Me.dbAccount.TopReturnedRecords = 0
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 36.08333!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1966.0!, 36.08333!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell42, Me.XrTableCell38, Me.XrTableCell57, Me.XrTableCell58, Me.XrTableCell59, Me.XrTableCell60, Me.XrTableCell61, Me.XrTableCell62, Me.XrTableCell63, Me.XrTableCell64, Me.XrTableCell65, Me.XrTableCell66, Me.XrTableCell67, Me.XrTableCell68, Me.XrTableCell69, Me.XrTableCell70, Me.XrTableCell71, Me.XrTableCell72, Me.XrTableCell73, Me.XrTableCell74, Me.XrTableCell75, Me.XrTableCell76, Me.XrTableCell77, Me.XrTableCell78, Me.XrTableCell79, Me.XrTableCell80})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell42
        '
        Me.XrTableCell42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.AccountID")})
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.Weight = 4.1065417267896516R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.AccountName")})
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell38.StylePriority.UsePadding = False
        Me.XrTableCell38.StylePriority.UseTextAlignment = False
        Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell38.Weight = 6.8802580547933418R
        '
        'XrTableCell57
        '
        Me.XrTableCell57.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM10", "{0:n2}")})
        Me.XrTableCell57.Name = "XrTableCell57"
        Me.XrTableCell57.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell57.StylePriority.UsePadding = False
        Me.XrTableCell57.StylePriority.UseTextAlignment = False
        Me.XrTableCell57.Text = "ยอดยกมา"
        Me.XrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell57.Weight = 2.297655636234845R
        '
        'XrTableCell58
        '
        Me.XrTableCell58.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM10", "{0:n2}")})
        Me.XrTableCell58.Name = "XrTableCell58"
        Me.XrTableCell58.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell58.StylePriority.UsePadding = False
        Me.XrTableCell58.StylePriority.UseTextAlignment = False
        Me.XrTableCell58.Text = "ยอดยกไป"
        Me.XrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell58.Weight = 2.2545463491108593R
        '
        'XrTableCell59
        '
        Me.XrTableCell59.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM11", "{0:n2}")})
        Me.XrTableCell59.Name = "XrTableCell59"
        Me.XrTableCell59.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell59.StylePriority.UsePadding = False
        Me.XrTableCell59.StylePriority.UseTextAlignment = False
        Me.XrTableCell59.Text = "ยอดยกมา"
        Me.XrTableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell59.Weight = 2.0174576569320859R
        '
        'XrTableCell60
        '
        Me.XrTableCell60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM11", "{0:n2}")})
        Me.XrTableCell60.Name = "XrTableCell60"
        Me.XrTableCell60.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell60.StylePriority.UsePadding = False
        Me.XrTableCell60.StylePriority.UseTextAlignment = False
        Me.XrTableCell60.Text = "ยอดยกไป"
        Me.XrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell60.Weight = 2.1403414744403246R
        '
        'XrTableCell61
        '
        Me.XrTableCell61.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM12", "{0:n2}")})
        Me.XrTableCell61.Name = "XrTableCell61"
        Me.XrTableCell61.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell61.StylePriority.UsePadding = False
        Me.XrTableCell61.StylePriority.UseTextAlignment = False
        Me.XrTableCell61.Text = "ยอดยกมา"
        Me.XrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell61.Weight = 2.0877643835197657R
        '
        'XrTableCell62
        '
        Me.XrTableCell62.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM12", "{0:n2}")})
        Me.XrTableCell62.Name = "XrTableCell62"
        Me.XrTableCell62.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell62.StylePriority.UsePadding = False
        Me.XrTableCell62.StylePriority.UseTextAlignment = False
        Me.XrTableCell62.Text = "ยอดยกไป"
        Me.XrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell62.Weight = 2.0900866132796279R
        '
        'XrTableCell63
        '
        Me.XrTableCell63.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM1", "{0:n2}")})
        Me.XrTableCell63.Name = "XrTableCell63"
        Me.XrTableCell63.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell63.StylePriority.UsePadding = False
        Me.XrTableCell63.StylePriority.UseTextAlignment = False
        Me.XrTableCell63.Text = "ยอดยกมา"
        Me.XrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell63.Weight = 2.1372630624925275R
        '
        'XrTableCell64
        '
        Me.XrTableCell64.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM1", "{0:n2}")})
        Me.XrTableCell64.Name = "XrTableCell64"
        Me.XrTableCell64.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell64.StylePriority.UsePadding = False
        Me.XrTableCell64.StylePriority.UseTextAlignment = False
        Me.XrTableCell64.Text = "ยอดยกไป"
        Me.XrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell64.Weight = 2.0807831289179877R
        '
        'XrTableCell65
        '
        Me.XrTableCell65.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM2", "{0:n2}")})
        Me.XrTableCell65.Name = "XrTableCell65"
        Me.XrTableCell65.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell65.StylePriority.UsePadding = False
        Me.XrTableCell65.StylePriority.UseTextAlignment = False
        Me.XrTableCell65.Text = "ยอดยกมา"
        Me.XrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell65.Weight = 2.285318537892568R
        '
        'XrTableCell66
        '
        Me.XrTableCell66.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM2", "{0:n2}")})
        Me.XrTableCell66.Name = "XrTableCell66"
        Me.XrTableCell66.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell66.StylePriority.UsePadding = False
        Me.XrTableCell66.StylePriority.UseTextAlignment = False
        Me.XrTableCell66.Text = "ยอดยกไป"
        Me.XrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell66.Weight = 2.4174934772352019R
        '
        'XrTableCell67
        '
        Me.XrTableCell67.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM3", "{0:n2}")})
        Me.XrTableCell67.Name = "XrTableCell67"
        Me.XrTableCell67.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell67.StylePriority.UsePadding = False
        Me.XrTableCell67.StylePriority.UseTextAlignment = False
        Me.XrTableCell67.Text = "ยอดยกมา"
        Me.XrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell67.Weight = 2.3627866048168449R
        '
        'XrTableCell68
        '
        Me.XrTableCell68.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM3", "{0:n2}")})
        Me.XrTableCell68.Name = "XrTableCell68"
        Me.XrTableCell68.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell68.StylePriority.UsePadding = False
        Me.XrTableCell68.StylePriority.UseTextAlignment = False
        Me.XrTableCell68.Text = "ยอดยกไป"
        Me.XrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell68.Weight = 2.4919570211570075R
        '
        'XrTableCell69
        '
        Me.XrTableCell69.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM4", "{0:n2}")})
        Me.XrTableCell69.Name = "XrTableCell69"
        Me.XrTableCell69.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell69.StylePriority.UsePadding = False
        Me.XrTableCell69.StylePriority.UseTextAlignment = False
        Me.XrTableCell69.Text = "ยอดยกมา"
        Me.XrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell69.Weight = 2.4799172162417586R
        '
        'XrTableCell70
        '
        Me.XrTableCell70.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM4", "{0:n2}")})
        Me.XrTableCell70.Name = "XrTableCell70"
        Me.XrTableCell70.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell70.StylePriority.UsePadding = False
        Me.XrTableCell70.StylePriority.UseTextAlignment = False
        Me.XrTableCell70.Text = "ยอดยกไป"
        Me.XrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell70.Weight = 2.5277926264799619R
        '
        'XrTableCell71
        '
        Me.XrTableCell71.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM5", "{0:n2}")})
        Me.XrTableCell71.Name = "XrTableCell71"
        Me.XrTableCell71.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell71.StylePriority.UsePadding = False
        Me.XrTableCell71.StylePriority.UseTextAlignment = False
        Me.XrTableCell71.Text = "ยอดยกมา"
        Me.XrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell71.Weight = 2.3728400433195538R
        '
        'XrTableCell72
        '
        Me.XrTableCell72.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM5", "{0:n2}")})
        Me.XrTableCell72.Name = "XrTableCell72"
        Me.XrTableCell72.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell72.StylePriority.UsePadding = False
        Me.XrTableCell72.StylePriority.UseTextAlignment = False
        Me.XrTableCell72.Text = "ยอดยกไป"
        Me.XrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell72.Weight = 2.2186417197632609R
        '
        'XrTableCell73
        '
        Me.XrTableCell73.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM6", "{0:n2}")})
        Me.XrTableCell73.Name = "XrTableCell73"
        Me.XrTableCell73.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell73.StylePriority.UsePadding = False
        Me.XrTableCell73.StylePriority.UseTextAlignment = False
        Me.XrTableCell73.Text = "ยอดยกมา"
        Me.XrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell73.Weight = 2.3226404585214411R
        '
        'XrTableCell74
        '
        Me.XrTableCell74.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM6", "{0:n2}")})
        Me.XrTableCell74.Name = "XrTableCell74"
        Me.XrTableCell74.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell74.StylePriority.UsePadding = False
        Me.XrTableCell74.StylePriority.UseTextAlignment = False
        Me.XrTableCell74.Text = "ยอดยกไป"
        Me.XrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell74.Weight = 2.3729313999815291R
        '
        'XrTableCell75
        '
        Me.XrTableCell75.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM7", "{0:n2}")})
        Me.XrTableCell75.Name = "XrTableCell75"
        Me.XrTableCell75.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell75.StylePriority.UsePadding = False
        Me.XrTableCell75.StylePriority.UseTextAlignment = False
        Me.XrTableCell75.Text = "ยอดยกมา"
        Me.XrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell75.Weight = 2.2292503690048244R
        '
        'XrTableCell76
        '
        Me.XrTableCell76.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM7", "{0:n2}")})
        Me.XrTableCell76.Name = "XrTableCell76"
        Me.XrTableCell76.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell76.StylePriority.UsePadding = False
        Me.XrTableCell76.StylePriority.UseTextAlignment = False
        Me.XrTableCell76.Text = "ยอดยกไป"
        Me.XrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell76.Weight = 2.1874159205222519R
        '
        'XrTableCell77
        '
        Me.XrTableCell77.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM8", "{0:n2}")})
        Me.XrTableCell77.Name = "XrTableCell77"
        Me.XrTableCell77.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell77.StylePriority.UsePadding = False
        Me.XrTableCell77.StylePriority.UseTextAlignment = False
        Me.XrTableCell77.Text = "ยอดยกมา"
        Me.XrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell77.Weight = 2.4147638439934207R
        '
        'XrTableCell78
        '
        Me.XrTableCell78.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM8", "{0:n2}")})
        Me.XrTableCell78.Name = "XrTableCell78"
        Me.XrTableCell78.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell78.StylePriority.UsePadding = False
        Me.XrTableCell78.StylePriority.UseTextAlignment = False
        Me.XrTableCell78.Text = "ยอดยกไป"
        Me.XrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell78.Weight = 2.4147638439934207R
        '
        'XrTableCell79
        '
        Me.XrTableCell79.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.FM9", "{0:n2}")})
        Me.XrTableCell79.Name = "XrTableCell79"
        Me.XrTableCell79.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell79.StylePriority.UsePadding = False
        Me.XrTableCell79.StylePriority.UseTextAlignment = False
        Me.XrTableCell79.Text = "ยอดยกมา"
        Me.XrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell79.Weight = 2.4147638439934207R
        '
        'XrTableCell80
        '
        Me.XrTableCell80.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.TM9", "{0:n2}")})
        Me.XrTableCell80.Name = "XrTableCell80"
        Me.XrTableCell80.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell80.StylePriority.UsePadding = False
        Me.XrTableCell80.StylePriority.UseTextAlignment = False
        Me.XrTableCell80.Text = "ยอดยกไป"
        Me.XrTableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell80.Weight = 2.4147638439934207R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 48.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 47.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Year
        '
        Me.Year.Description = "ปี"
        Me.Year.Name = "Year"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1, Me.XrTable1})
        Me.ReportHeader.HeightF = 115.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportTrialBalanceMonth.SiteName")})
        Me.XrLabel2.Font = New System.Drawing.Font("Angsana New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 23.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1966.0!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.Year, "Text", "รายงานงบทดลองสัมพันธ์ ปีงบประมาณ {0:yyyy}")})
        Me.XrLabel1.Font = New System.Drawing.Font("Angsana New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1966.0!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "รายงานงบทดลองสัมพันธ์"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 65.00002!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1966.0!, 49.99998!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell31, Me.XrTableCell34, Me.XrTableCell36})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.RowSpan = 2
        Me.XrTableCell1.Text = "รหัสบัญชี"
        Me.XrTableCell1.Weight = 1.8631817430144988R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.RowSpan = 2
        Me.XrTableCell2.Text = "ชื่อบัญชี"
        Me.XrTableCell2.Weight = 3.1216468679167404R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "ต.ค."
        Me.XrTableCell3.Weight = 2.065381817070278R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "พ.ย."
        Me.XrTableCell4.Weight = 1.8864376325791568R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "ธ.ค."
        Me.XrTableCell5.Weight = 1.8955361040790772R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "ม.ค."
        Me.XrTableCell6.Weight = 1.9137722372514347R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "ก.พ."
        Me.XrTableCell7.Weight = 2.1337146528820634R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Text = "มี.ค."
        Me.XrTableCell8.Weight = 2.2026493829232154R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Text = "เม.ย."
        Me.XrTableCell9.Weight = 2.2720492635968808R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Text = "พ.ค."
        Me.XrTableCell10.Weight = 2.0832039946763792R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Text = "มิ.ย."
        Me.XrTableCell11.Weight = 2.1304320103090841R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Text = "ก.ค."
        Me.XrTableCell31.Weight = 2.0038862240223843R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Text = "ส.ค."
        Me.XrTableCell34.Weight = 2.1912078651614664R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Text = "ก.ย."
        Me.XrTableCell36.Weight = 2.1912098622556044R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell24, Me.XrTableCell15, Me.XrTableCell25, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell26, Me.XrTableCell30, Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell23, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell32, Me.XrTableCell33, Me.XrTableCell35, Me.XrTableCell37, Me.XrTableCell39, Me.XrTableCell40, Me.XrTableCell41})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.RowSpan = 0
        Me.XrTableCell12.Text = "รหัสบัญชี"
        Me.XrTableCell12.Weight = 4.106542274548854R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.RowSpan = 0
        Me.XrTableCell13.Text = "ชื่อบัญชี"
        Me.XrTableCell13.Weight = 6.8802601805020736R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Text = "ยอดยกมา"
        Me.XrTableCell14.Weight = 2.297655636234845R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Text = "ยอดยกไป"
        Me.XrTableCell24.Weight = 2.2545463491108593R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Text = "ยอดยกมา"
        Me.XrTableCell15.Weight = 2.0174576569320859R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Text = "ยอดยกไป"
        Me.XrTableCell25.Weight = 2.1403414744403246R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Text = "ยอดยกมา"
        Me.XrTableCell16.Weight = 2.0877643835197657R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Text = "ยอดยกไป"
        Me.XrTableCell17.Weight = 2.0900866132796279R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Text = "ยอดยกมา"
        Me.XrTableCell26.Weight = 2.1372630624925275R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Text = "ยอดยกไป"
        Me.XrTableCell30.Weight = 2.0807831289179877R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Text = "ยอดยกมา"
        Me.XrTableCell27.Weight = 2.285318537892568R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Text = "ยอดยกไป"
        Me.XrTableCell28.Weight = 2.4174934772352019R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Text = "ยอดยกมา"
        Me.XrTableCell29.Weight = 2.3627866048168449R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Text = "ยอดยกไป"
        Me.XrTableCell23.Weight = 2.4919570211570075R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Text = "ยอดยกมา"
        Me.XrTableCell18.Weight = 2.4799172162417586R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Text = "ยอดยกไป"
        Me.XrTableCell19.Weight = 2.5277926264799619R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Text = "ยอดยกมา"
        Me.XrTableCell20.Weight = 2.3728400433195538R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Text = "ยอดยกไป"
        Me.XrTableCell21.Weight = 2.2186417197632609R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Text = "ยอดยกมา"
        Me.XrTableCell22.Weight = 2.3226404585214411R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Text = "ยอดยกไป"
        Me.XrTableCell32.Weight = 2.3729313999815291R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Text = "ยอดยกมา"
        Me.XrTableCell33.Weight = 2.2292503690048244R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Text = "ยอดยกไป"
        Me.XrTableCell35.Weight = 2.1874159205222519R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.Text = "ยอดยกมา"
        Me.XrTableCell37.Weight = 2.4147638439934207R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.Text = "ยอดยกไป"
        Me.XrTableCell39.Weight = 2.4147638439934207R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.Text = "ยอดยกมา"
        Me.XrTableCell40.Weight = 2.4147638439934207R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.Text = "ยอดยกไป"
        Me.XrTableCell41.Weight = 2.4147638439934207R
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 100.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "SP_GetReportTrialBalanceMonth"
        QueryParameter1.Name = "@SiteName"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.SiteName]", GetType(String))
        QueryParameter2.Name = "@StartAccount"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.StartAccount]", GetType(String))
        QueryParameter3.Name = "@EndAccount"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.EndAccount]", GetType(String))
        QueryParameter4.Name = "@StartbalanceMonth"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.StartMonth]", GetType(String))
        QueryParameter5.Name = "@EndbalanceMonth"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.EndMonth]", GetType(String))
        QueryParameter6.Name = "@balanceYear"
        QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.Year]", GetType(String))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.Parameters.Add(QueryParameter4)
        StoredProcQuery1.Parameters.Add(QueryParameter5)
        StoredProcQuery1.Parameters.Add(QueryParameter6)
        StoredProcQuery1.StoredProcName = "SP_GetReportTrialBalanceMonth"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'SiteName
        '
        Me.SiteName.Description = "ชื่อศูนย์"
        DynamicListLookUpSettings1.DataAdapter = Nothing
        DynamicListLookUpSettings1.DataMember = Nothing
        DynamicListLookUpSettings1.DataSource = Me.dbSite
        DynamicListLookUpSettings1.DisplayMember = "SiteName"
        DynamicListLookUpSettings1.FilterString = Nothing
        DynamicListLookUpSettings1.ValueMember = "SiteName"
        Me.SiteName.LookUpSettings = DynamicListLookUpSettings1
        Me.SiteName.Name = "SiteName"
        '
        'StartAccount
        '
        Me.StartAccount.Description = "จากบัญชี"
        DynamicListLookUpSettings2.DataAdapter = Nothing
        DynamicListLookUpSettings2.DataMember = Nothing
        DynamicListLookUpSettings2.DataSource = Me.dbAccount
        DynamicListLookUpSettings2.DisplayMember = "AccountName"
        DynamicListLookUpSettings2.FilterString = Nothing
        DynamicListLookUpSettings2.ValueMember = "AccountID"
        Me.StartAccount.LookUpSettings = DynamicListLookUpSettings2
        Me.StartAccount.Name = "StartAccount"
        '
        'EndAccount
        '
        Me.EndAccount.Description = "ถึง"
        DynamicListLookUpSettings3.DataAdapter = Nothing
        DynamicListLookUpSettings3.DataMember = Nothing
        DynamicListLookUpSettings3.DataSource = Me.dbAccount
        DynamicListLookUpSettings3.DisplayMember = "AccountName"
        DynamicListLookUpSettings3.FilterString = Nothing
        DynamicListLookUpSettings3.ValueMember = "AccountID"
        Me.EndAccount.LookUpSettings = DynamicListLookUpSettings3
        Me.EndAccount.Name = "EndAccount"
        '
        'StartMonth
        '
        Me.StartMonth.Description = "จากเดือน"
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
        Me.StartMonth.LookUpSettings = StaticListLookUpSettings1
        Me.StartMonth.Name = "StartMonth"
        '
        'EndMonth
        '
        Me.EndMonth.Description = "ถึง"
        StaticListLookUpSettings2.FilterString = Nothing
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("1", "มกราคม"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("2", "กุมภาพันธ์"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("3", "มีนาคม"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("4", "เมษายน"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("5", "พฤษภาคม"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("6", "มิถุนายน"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("7", "กรกฎาคม"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("8", "สิงหาคม"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("9", "กันยายน"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("10", "ตุลาคม"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("11", "พฤศจิกายน"))
        StaticListLookUpSettings2.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("12", "ธันวาคม"))
        Me.EndMonth.LookUpSettings = StaticListLookUpSettings2
        Me.EndMonth.Name = "EndMonth"
        '
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "SP_GetReportTrialBalanceMonth"
        Me.CalculatedField1.Expression = "Iif([TM1] != [FM2] , [ForeColor]=[Red]  , [FM2])"
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'ReportReconciliation
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1})
        Me.ComponentStorage.Add(Me.dbSite)
        Me.ComponentStorage.Add(Me.dbAccount)
        Me.ComponentStorage.Add(Me.SqlDataSource1)
        Me.DataSource = Me.SqlDataSource1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(16, 18, 48, 47)
        Me.PageHeight = 827
        Me.PageWidth = 2000
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.SiteName, Me.StartAccount, Me.EndAccount, Me.StartMonth, Me.EndMonth, Me.Year})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "14.2"
        CType(Me.dbSite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Year As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Protected WithEvents dbSite As DevExpress.Persistent.Base.ReportsV2.CollectionDataSource
    Protected WithEvents dbAccount As DevExpress.Persistent.Base.ReportsV2.CollectionDataSource
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents SiteName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents StartAccount As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents EndAccount As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents StartMonth As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents EndMonth As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell57 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell58 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell59 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell60 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell61 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell62 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell63 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell64 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell65 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell66 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell67 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell68 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell69 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell70 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell71 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell72 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell73 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell74 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell75 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell76 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell77 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell78 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell79 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell80 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
