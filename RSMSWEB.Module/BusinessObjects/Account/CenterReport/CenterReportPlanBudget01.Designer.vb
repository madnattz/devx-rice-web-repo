<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CenterReportPlanBudget01
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
        Dim StaticListLookUpSettings1 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
        Dim DynamicListLookUpSettings2 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim DynamicListLookUpSettings3 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim DynamicListLookUpSettings4 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim StoredProcQuery1 As DevExpress.DataAccess.Sql.StoredProcQuery = New DevExpress.DataAccess.Sql.StoredProcQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter5 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter6 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CenterReportPlanBudget01))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.label59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label120 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label119 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label115 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label114 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label73 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label106 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.dbPlanName = New DevExpress.Persistent.Base.ReportsV2.CollectionDataSource()
        Me.dbProjectName = New DevExpress.Persistent.Base.ReportsV2.CollectionDataSource()
        Me.dbActivityName = New DevExpress.Persistent.Base.ReportsV2.CollectionDataSource()
        Me.dbSiteName = New DevExpress.Persistent.Base.ReportsV2.CollectionDataSource()
        Me.PrmSiteName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PrmPlanYear = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PrmPlanMonth = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PrmPlanName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PrmProjectName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PrmActivityName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
        CType(Me.dbPlanName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbActivityName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbSiteName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 100.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 60.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label59, Me.label120, Me.label119, Me.label115, Me.label114, Me.label73, Me.label20, Me.label22, Me.label23, Me.label24, Me.label25, Me.label26, Me.label8, Me.label7, Me.label6, Me.label5, Me.label3, Me.label9, Me.label50, Me.label40, Me.label39, Me.label38, Me.label37, Me.label21, Me.label19, Me.label18, Me.label4, Me.label2, Me.label1, Me.label15, Me.label14, Me.label13, Me.label12, Me.label11, Me.label10, Me.label106, Me.XrLabel1, Me.XrLabel2, Me.XrLabel25})
        Me.PageHeader.HeightF = 159.7502!
        Me.PageHeader.Name = "PageHeader"
        '
        'label59
        '
        Me.label59.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label59.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 59.6667!)
        Me.label59.Name = "label59"
        Me.label59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label59.SizeF = New System.Drawing.SizeF(447.5!, 23.0!)
        Me.label59.StylePriority.UseFont = False
        Me.label59.StylePriority.UseTextAlignment = False
        Me.label59.Text = "แผนการปฎิบัติงาน : รายงานเป็นรายไตรมาส / ผลการปฎิบัติงาน : รายงานเป็นรายเดือน "
        Me.label59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'label120
        '
        Me.label120.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.label120.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.label120.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_ReportPlanBudget01.SiteName")})
        Me.label120.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label120.LocationFloat = New DevExpress.Utils.PointFloat(71.875!, 29.1667!)
        Me.label120.Name = "label120"
        Me.label120.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label120.SizeF = New System.Drawing.SizeF(285.8759!, 23.0!)
        Me.label120.StylePriority.UseBorderDashStyle = False
        Me.label120.StylePriority.UseBorders = False
        Me.label120.StylePriority.UseFont = False
        Me.label120.StylePriority.UseTextAlignment = False
        Me.label120.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'label119
        '
        Me.label119.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label119.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 29.16669!)
        Me.label119.Name = "label119"
        Me.label119.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label119.SizeF = New System.Drawing.SizeF(71.875!, 23.0!)
        Me.label119.StylePriority.UseFont = False
        Me.label119.StylePriority.UseTextAlignment = False
        Me.label119.Text = "หน่วยงาน :"
        Me.label119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'label115
        '
        Me.label115.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.label115.LocationFloat = New DevExpress.Utils.PointFloat(1284.0!, 0.0!)
        Me.label115.Name = "label115"
        Me.label115.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label115.SizeF = New System.Drawing.SizeF(94.0!, 23.0!)
        Me.label115.StylePriority.UseFont = False
        Me.label115.StylePriority.UseTextAlignment = False
        Me.label115.Text = "สงป - 301"
        Me.label115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label114
        '
        Me.label114.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label114.LocationFloat = New DevExpress.Utils.PointFloat(1284.0!, 61.75003!)
        Me.label114.Name = "label114"
        Me.label114.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label114.SizeF = New System.Drawing.SizeF(94.0!, 23.0!)
        Me.label114.StylePriority.UseFont = False
        Me.label114.StylePriority.UseTextAlignment = False
        Me.label114.Text = "หน่วย : บาท"
        Me.label114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label73
        '
        Me.label73.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_ReportPlanBudget01.Year", "แบบจัดทำแผน / รายงานผลการปฎิบัติงานและการใช้จ่ายงบประมาณ กรมการข้าว ประจำปีงบประม" & _
                    "าณ พ.ศ.{0}")})
        Me.label73.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.label73.LocationFloat = New DevExpress.Utils.PointFloat(0.000213623!, 0.0!)
        Me.label73.Name = "label73"
        Me.label73.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label73.SizeF = New System.Drawing.SizeF(1284.0!, 23.08332!)
        Me.label73.StylePriority.UseFont = False
        Me.label73.StylePriority.UseTextAlignment = False
        Me.label73.Text = "แบบจัดทำแผน / รายงานผลการปฎิบัติงานและการใช้จ่ายงบประมาณ กรมการข้าว ประจำปีงบประม" & _
    "าณ พ.ศ."
        Me.label73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label20
        '
        Me.label20.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label20.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label20.LocationFloat = New DevExpress.Utils.PointFloat(1286.292!, 134.75!)
        Me.label20.Name = "label20"
        Me.label20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label20.SizeF = New System.Drawing.SizeF(45.29166!, 25.0!)
        Me.label20.StylePriority.UseBorders = False
        Me.label20.StylePriority.UseFont = False
        Me.label20.StylePriority.UseTextAlignment = False
        Me.label20.Text = "ก.ย."
        Me.label20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label22
        '
        Me.label22.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label22.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label22.LocationFloat = New DevExpress.Utils.PointFloat(1235.75!, 134.75!)
        Me.label22.Name = "label22"
        Me.label22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label22.SizeF = New System.Drawing.SizeF(50.54169!, 25.0!)
        Me.label22.StylePriority.UseBorders = False
        Me.label22.StylePriority.UseFont = False
        Me.label22.StylePriority.UseTextAlignment = False
        Me.label22.Text = "ส.ค."
        Me.label22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label23
        '
        Me.label23.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label23.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label23.LocationFloat = New DevExpress.Utils.PointFloat(1182.083!, 134.75!)
        Me.label23.Name = "label23"
        Me.label23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label23.SizeF = New System.Drawing.SizeF(53.66669!, 25.0!)
        Me.label23.StylePriority.UseBorders = False
        Me.label23.StylePriority.UseFont = False
        Me.label23.StylePriority.UseTextAlignment = False
        Me.label23.Text = "ก.ค."
        Me.label23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label24
        '
        Me.label24.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label24.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label24.LocationFloat = New DevExpress.Utils.PointFloat(1118.0!, 109.75!)
        Me.label24.Multiline = True
        Me.label24.Name = "label24"
        Me.label24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label24.SizeF = New System.Drawing.SizeF(64.08334!, 50.0!)
        Me.label24.StylePriority.UseBorders = False
        Me.label24.StylePriority.UseFont = False
        Me.label24.StylePriority.UseTextAlignment = False
        Me.label24.Text = "แผน" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ก.ค. - ก.ย."
        Me.label24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label25
        '
        Me.label25.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label25.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label25.LocationFloat = New DevExpress.Utils.PointFloat(1182.083!, 109.75!)
        Me.label25.Name = "label25"
        Me.label25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label25.SizeF = New System.Drawing.SizeF(149.5!, 25.0!)
        Me.label25.StylePriority.UseBorders = False
        Me.label25.StylePriority.UseFont = False
        Me.label25.StylePriority.UseTextAlignment = False
        Me.label25.Text = "ผล"
        Me.label25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label26
        '
        Me.label26.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label26.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label26.LocationFloat = New DevExpress.Utils.PointFloat(1118.0!, 84.75002!)
        Me.label26.Name = "label26"
        Me.label26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label26.SizeF = New System.Drawing.SizeF(213.5833!, 25.0!)
        Me.label26.StylePriority.UseBorders = False
        Me.label26.StylePriority.UseFont = False
        Me.label26.StylePriority.UseTextAlignment = False
        Me.label26.Text = "ไตรมาส 4 (ก.ค. - ก.ย.)"
        Me.label26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label8
        '
        Me.label8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(754.9167!, 109.75!)
        Me.label8.Name = "label8"
        Me.label8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label8.SizeF = New System.Drawing.SizeF(149.5!, 25.0!)
        Me.label8.StylePriority.UseBorders = False
        Me.label8.StylePriority.UseFont = False
        Me.label8.StylePriority.UseTextAlignment = False
        Me.label8.Text = "ผล"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label7
        '
        Me.label7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(690.8334!, 109.75!)
        Me.label7.Multiline = True
        Me.label7.Name = "label7"
        Me.label7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label7.SizeF = New System.Drawing.SizeF(64.08334!, 50.0!)
        Me.label7.StylePriority.UseBorders = False
        Me.label7.StylePriority.UseFont = False
        Me.label7.StylePriority.UseTextAlignment = False
        Me.label7.Text = "แผน" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ม.ค. - มี.ค."
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(754.9167!, 134.75!)
        Me.label6.Name = "label6"
        Me.label6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label6.SizeF = New System.Drawing.SizeF(53.66669!, 25.0!)
        Me.label6.StylePriority.UseBorders = False
        Me.label6.StylePriority.UseFont = False
        Me.label6.StylePriority.UseTextAlignment = False
        Me.label6.Text = "ม.ค."
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label5
        '
        Me.label5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(808.5834!, 134.75!)
        Me.label5.Name = "label5"
        Me.label5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label5.SizeF = New System.Drawing.SizeF(50.54169!, 25.0!)
        Me.label5.StylePriority.UseBorders = False
        Me.label5.StylePriority.UseFont = False
        Me.label5.StylePriority.UseTextAlignment = False
        Me.label5.Text = "ก.พ."
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(859.1251!, 134.75!)
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label3.SizeF = New System.Drawing.SizeF(45.29166!, 25.0!)
        Me.label3.StylePriority.UseBorders = False
        Me.label3.StylePriority.UseFont = False
        Me.label3.StylePriority.UseTextAlignment = False
        Me.label3.Text = "มี.ค."
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label9
        '
        Me.label9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(690.8334!, 84.75002!)
        Me.label9.Name = "label9"
        Me.label9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label9.SizeF = New System.Drawing.SizeF(213.5833!, 25.0!)
        Me.label9.StylePriority.UseBorders = False
        Me.label9.StylePriority.UseFont = False
        Me.label9.StylePriority.UseTextAlignment = False
        Me.label9.Text = "ไตรมาส 2 (ม.ค. - มี.ค.)"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label50
        '
        Me.label50.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label50.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label50.LocationFloat = New DevExpress.Utils.PointFloat(1331.584!, 84.75012!)
        Me.label50.Name = "label50"
        Me.label50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label50.SizeF = New System.Drawing.SizeF(49.75!, 75.0!)
        Me.label50.StylePriority.UseBorders = False
        Me.label50.StylePriority.UseFont = False
        Me.label50.StylePriority.UseTextAlignment = False
        Me.label50.Text = "คงเหลือ"
        Me.label50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label40
        '
        Me.label40.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label40.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label40.LocationFloat = New DevExpress.Utils.PointFloat(645.5417!, 134.75!)
        Me.label40.Name = "label40"
        Me.label40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label40.SizeF = New System.Drawing.SizeF(45.29166!, 25.0!)
        Me.label40.StylePriority.UseBorders = False
        Me.label40.StylePriority.UseFont = False
        Me.label40.StylePriority.UseTextAlignment = False
        Me.label40.Text = "ธ.ค."
        Me.label40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label39
        '
        Me.label39.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label39.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label39.LocationFloat = New DevExpress.Utils.PointFloat(594.9999!, 134.75!)
        Me.label39.Name = "label39"
        Me.label39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label39.SizeF = New System.Drawing.SizeF(50.54169!, 25.0!)
        Me.label39.StylePriority.UseBorders = False
        Me.label39.StylePriority.UseFont = False
        Me.label39.StylePriority.UseTextAlignment = False
        Me.label39.Text = "พ.ย."
        Me.label39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label38
        '
        Me.label38.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label38.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label38.LocationFloat = New DevExpress.Utils.PointFloat(542.1667!, 134.75!)
        Me.label38.Name = "label38"
        Me.label38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label38.SizeF = New System.Drawing.SizeF(52.83337!, 25.0!)
        Me.label38.StylePriority.UseBorders = False
        Me.label38.StylePriority.UseFont = False
        Me.label38.StylePriority.UseTextAlignment = False
        Me.label38.Text = "ต.ค."
        Me.label38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label37
        '
        Me.label37.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label37.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label37.LocationFloat = New DevExpress.Utils.PointFloat(477.2502!, 109.75!)
        Me.label37.Multiline = True
        Me.label37.Name = "label37"
        Me.label37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label37.SizeF = New System.Drawing.SizeF(64.91653!, 50.0!)
        Me.label37.StylePriority.UseBorders = False
        Me.label37.StylePriority.UseFont = False
        Me.label37.StylePriority.UseTextAlignment = False
        Me.label37.Text = "แผน" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ตค. - ธ.ค."
        Me.label37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label21
        '
        Me.label21.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label21.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label21.LocationFloat = New DevExpress.Utils.PointFloat(542.1667!, 109.75!)
        Me.label21.Name = "label21"
        Me.label21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label21.SizeF = New System.Drawing.SizeF(148.6667!, 25.0!)
        Me.label21.StylePriority.UseBorders = False
        Me.label21.StylePriority.UseFont = False
        Me.label21.StylePriority.UseTextAlignment = False
        Me.label21.Text = "ผล"
        Me.label21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label19
        '
        Me.label19.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label19.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label19.LocationFloat = New DevExpress.Utils.PointFloat(420.4583!, 109.75!)
        Me.label19.Name = "label19"
        Me.label19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label19.SizeF = New System.Drawing.SizeF(56.79166!, 49.99998!)
        Me.label19.StylePriority.UseBorders = False
        Me.label19.StylePriority.UseFont = False
        Me.label19.StylePriority.UseTextAlignment = False
        Me.label19.Text = "ผล"
        Me.label19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label18
        '
        Me.label18.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label18.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label18.LocationFloat = New DevExpress.Utils.PointFloat(353.2501!, 109.75!)
        Me.label18.Name = "label18"
        Me.label18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label18.SizeF = New System.Drawing.SizeF(67.20825!, 50.00002!)
        Me.label18.StylePriority.UseBorders = False
        Me.label18.StylePriority.UseFont = False
        Me.label18.StylePriority.UseTextAlignment = False
        Me.label18.Text = "แผน"
        Me.label18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label4
        '
        Me.label4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(478.0834!, 84.75002!)
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label4.SizeF = New System.Drawing.SizeF(212.7501!, 25.0!)
        Me.label4.StylePriority.UseBorders = False
        Me.label4.StylePriority.UseFont = False
        Me.label4.StylePriority.UseTextAlignment = False
        Me.label4.Text = "ไตรมาส 1 (ต.ค. - ธ.ค.)"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(353.2501!, 84.75002!)
        Me.label2.Name = "label2"
        Me.label2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label2.SizeF = New System.Drawing.SizeF(124.0!, 25.0!)
        Me.label2.StylePriority.UseBorders = False
        Me.label2.StylePriority.UseFont = False
        Me.label2.StylePriority.UseTextAlignment = False
        Me.label2.Text = "รวมทั้งสิ้น"
        Me.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0.000213623!, 84.75002!)
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label1.SizeF = New System.Drawing.SizeF(264.6665!, 75.00003!)
        Me.label1.StylePriority.UseBorders = False
        Me.label1.StylePriority.UseFont = False
        Me.label1.StylePriority.UseTextAlignment = False
        Me.label1.Text = "โครงการ/กิจกรรมสำคัญ"
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label15
        '
        Me.label15.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label15.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label15.LocationFloat = New DevExpress.Utils.PointFloat(904.4167!, 84.75002!)
        Me.label15.Name = "label15"
        Me.label15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label15.SizeF = New System.Drawing.SizeF(213.5833!, 25.0!)
        Me.label15.StylePriority.UseBorders = False
        Me.label15.StylePriority.UseFont = False
        Me.label15.StylePriority.UseTextAlignment = False
        Me.label15.Text = "ไตรมาส 3 (เม.ย. - มิ.ย.)"
        Me.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label14
        '
        Me.label14.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label14.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label14.LocationFloat = New DevExpress.Utils.PointFloat(968.4995!, 109.75!)
        Me.label14.Name = "label14"
        Me.label14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label14.SizeF = New System.Drawing.SizeF(149.5!, 25.0!)
        Me.label14.StylePriority.UseBorders = False
        Me.label14.StylePriority.UseFont = False
        Me.label14.StylePriority.UseTextAlignment = False
        Me.label14.Text = "ผล"
        Me.label14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label13
        '
        Me.label13.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label13.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.label13.LocationFloat = New DevExpress.Utils.PointFloat(904.4167!, 109.75!)
        Me.label13.Multiline = True
        Me.label13.Name = "label13"
        Me.label13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label13.SizeF = New System.Drawing.SizeF(64.08334!, 50.0!)
        Me.label13.StylePriority.UseBorders = False
        Me.label13.StylePriority.UseFont = False
        Me.label13.StylePriority.UseTextAlignment = False
        Me.label13.Text = "แผน" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "เม.ย. - มิ.ย."
        Me.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label12
        '
        Me.label12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label12.LocationFloat = New DevExpress.Utils.PointFloat(968.4995!, 134.75!)
        Me.label12.Name = "label12"
        Me.label12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label12.SizeF = New System.Drawing.SizeF(53.66669!, 25.0!)
        Me.label12.StylePriority.UseBorders = False
        Me.label12.StylePriority.UseFont = False
        Me.label12.StylePriority.UseTextAlignment = False
        Me.label12.Text = "เม.ย."
        Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label11
        '
        Me.label11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label11.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label11.LocationFloat = New DevExpress.Utils.PointFloat(1022.166!, 134.75!)
        Me.label11.Name = "label11"
        Me.label11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label11.SizeF = New System.Drawing.SizeF(50.54181!, 25.0!)
        Me.label11.StylePriority.UseBorders = False
        Me.label11.StylePriority.UseFont = False
        Me.label11.StylePriority.UseTextAlignment = False
        Me.label11.Text = "พ.ค."
        Me.label11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label10
        '
        Me.label10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.label10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label10.LocationFloat = New DevExpress.Utils.PointFloat(1072.708!, 134.75!)
        Me.label10.Name = "label10"
        Me.label10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label10.SizeF = New System.Drawing.SizeF(45.29169!, 25.0!)
        Me.label10.StylePriority.UseBorders = False
        Me.label10.StylePriority.UseFont = False
        Me.label10.StylePriority.UseTextAlignment = False
        Me.label10.Text = "มิ.ย."
        Me.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label106
        '
        Me.label106.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.label106.LocationFloat = New DevExpress.Utils.PointFloat(441.3333!, 30.1667!)
        Me.label106.Name = "label106"
        Me.label106.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label106.SizeF = New System.Drawing.SizeF(417.7916!, 23.0!)
        Me.label106.StylePriority.UseFont = False
        Me.label106.StylePriority.UseTextAlignment = False
        Me.label106.Text = "รายงานผลไตรมาสที่.........ณ เดือน..........................................      " & _
    "            "
        Me.label106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_ReportPlanBudget01.ไตรมาส")})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(591.9998!, 23.16671!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(25.74945!, 23.0!)
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_ReportPlanBudget01.เดือน")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(666.4164!, 23.1667!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(153.125!, 23.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel25
        '
        Me.XrLabel25.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel25.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(264.6667!, 84.75011!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(88.58313!, 75.00004!)
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "หน่วย"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'dbPlanName
        '
        Me.dbPlanName.Name = "dbPlanName"
        Me.dbPlanName.ObjectTypeName = "RSMSWEB.Module.SettingPlan"
        Me.dbPlanName.TopReturnedRecords = 0
        '
        'dbProjectName
        '
        Me.dbProjectName.Name = "dbProjectName"
        Me.dbProjectName.ObjectTypeName = "RSMSWEB.Module.SettingProject"
        Me.dbProjectName.TopReturnedRecords = 0
        '
        'dbActivityName
        '
        Me.dbActivityName.Name = "dbActivityName"
        Me.dbActivityName.ObjectTypeName = "RSMSWEB.Module.SettingActivity"
        Me.dbActivityName.TopReturnedRecords = 0
        '
        'dbSiteName
        '
        Me.dbSiteName.Name = "dbSiteName"
        Me.dbSiteName.ObjectTypeName = "RSMSWEB.Module.Site"
        Me.dbSiteName.TopReturnedRecords = 0
        '
        'PrmSiteName
        '
        Me.PrmSiteName.Description = "ชื่อศูนย์"
        DynamicListLookUpSettings1.DataAdapter = Nothing
        DynamicListLookUpSettings1.DataSource = Me.dbSiteName
        DynamicListLookUpSettings1.DisplayMember = "SiteName"
        DynamicListLookUpSettings1.FilterString = Nothing
        DynamicListLookUpSettings1.ValueMember = "SiteName"
        Me.PrmSiteName.LookUpSettings = DynamicListLookUpSettings1
        Me.PrmSiteName.Name = "PrmSiteName"
        '
        'PrmPlanYear
        '
        Me.PrmPlanYear.Description = "ปีงบประมาณ"
        Me.PrmPlanYear.Name = "PrmPlanYear"
        '
        'PrmPlanMonth
        '
        Me.PrmPlanMonth.Description = "ประจำเดือน"
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
        Me.PrmPlanMonth.LookUpSettings = StaticListLookUpSettings1
        Me.PrmPlanMonth.Name = "PrmPlanMonth"
        '
        'PrmPlanName
        '
        Me.PrmPlanName.Description = "ชื่อแผน"
        DynamicListLookUpSettings2.DataAdapter = Nothing
        DynamicListLookUpSettings2.DataSource = Me.dbPlanName
        DynamicListLookUpSettings2.DisplayMember = "PlanName"
        DynamicListLookUpSettings2.FilterString = Nothing
        DynamicListLookUpSettings2.ValueMember = "PlanName"
        Me.PrmPlanName.LookUpSettings = DynamicListLookUpSettings2
        Me.PrmPlanName.Name = "PrmPlanName"
        '
        'PrmProjectName
        '
        Me.PrmProjectName.Description = "ชื่อโครงการ"
        DynamicListLookUpSettings3.DataAdapter = Nothing
        DynamicListLookUpSettings3.DataSource = Me.dbProjectName
        DynamicListLookUpSettings3.DisplayMember = "ProjectName"
        DynamicListLookUpSettings3.FilterString = Nothing
        DynamicListLookUpSettings3.ValueMember = "ProjectName"
        Me.PrmProjectName.LookUpSettings = DynamicListLookUpSettings3
        Me.PrmProjectName.Name = "PrmProjectName"
        '
        'PrmActivityName
        '
        Me.PrmActivityName.Description = "ชื่อกิจกรรมหลัก"
        DynamicListLookUpSettings4.DataAdapter = Nothing
        DynamicListLookUpSettings4.DataSource = Me.dbActivityName
        DynamicListLookUpSettings4.DisplayMember = "ActivityName"
        DynamicListLookUpSettings4.FilterString = Nothing
        DynamicListLookUpSettings4.ValueMember = "ActivityName"
        Me.PrmActivityName.LookUpSettings = DynamicListLookUpSettings4
        Me.PrmActivityName.Name = "PrmActivityName"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "SP_GetReportPlanBudgetMonth01"
        QueryParameter1.Name = "@SiteName"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.PrmSiteName]", GetType(String))
        QueryParameter2.Name = "@PlanYear"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.PrmPlanYear]", GetType(String))
        QueryParameter3.Name = "@PlanMonth"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.PrmPlanMonth]", GetType(Integer))
        QueryParameter4.Name = "@PlanName"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.PrmPlanName]", GetType(String))
        QueryParameter5.Name = "@ProjectName"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.PrmProjectName]", GetType(String))
        QueryParameter6.Name = "@ActivityName"
        QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.PrmActivityName]", GetType(String))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.Parameters.Add(QueryParameter3)
        StoredProcQuery1.Parameters.Add(QueryParameter4)
        StoredProcQuery1.Parameters.Add(QueryParameter5)
        StoredProcQuery1.Parameters.Add(QueryParameter6)
        StoredProcQuery1.StoredProcName = "SP_GetReportPlanBudgetMonth01"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'CenterReportPlanBudget01
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
        Me.ComponentStorage.Add(Me.dbPlanName)
        Me.ComponentStorage.Add(Me.dbProjectName)
        Me.ComponentStorage.Add(Me.dbActivityName)
        Me.ComponentStorage.Add(Me.dbSiteName)
        Me.ComponentStorage.Add(Me.SqlDataSource1)
        Me.DataSource = Me.dbPlanName
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(7, 10, 60, 100)
        Me.PageHeight = 827
        Me.PageWidth = 1400
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.PrmSiteName, Me.PrmPlanYear, Me.PrmPlanMonth, Me.PrmPlanName, Me.PrmProjectName, Me.PrmActivityName})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "14.2"
        CType(Me.dbPlanName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbProjectName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbActivityName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbSiteName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents label59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label120 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label119 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label115 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label114 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label73 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label106 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Protected WithEvents dbPlanName As DevExpress.Persistent.Base.ReportsV2.CollectionDataSource
    Protected WithEvents dbProjectName As DevExpress.Persistent.Base.ReportsV2.CollectionDataSource
    Protected WithEvents dbActivityName As DevExpress.Persistent.Base.ReportsV2.CollectionDataSource
    Protected WithEvents dbSiteName As DevExpress.Persistent.Base.ReportsV2.CollectionDataSource
    Friend WithEvents PrmSiteName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PrmPlanYear As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PrmPlanMonth As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PrmPlanName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PrmProjectName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PrmActivityName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
End Class
