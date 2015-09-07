<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CenterActivityReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CenterActivityReport))
        Dim StaticListLookUpSettings1 As DevExpress.XtraReports.Parameters.StaticListLookUpSettings = New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
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
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
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
        Me.XrTableCell81 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell82 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell83 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell84 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell85 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell86 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell88 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell89 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell90 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell91 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell93 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell94 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell95 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell96 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell97 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell98 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell99 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell100 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell101 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell102 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell103 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell104 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell105 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell106 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell107 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell108 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell109 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell110 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell111 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell112 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell113 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell114 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell115 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell116 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell117 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell118 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell119 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell120 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell121 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell122 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell123 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell125 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell126 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell127 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell128 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell129 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell130 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell131 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell132 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell133 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell134 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell135 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell136 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell137 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell138 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell139 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell140 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell141 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell142 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell143 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell144 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell145 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell146 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell147 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell148 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell149 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell150 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell151 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell152 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell153 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell154 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell155 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell156 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell157 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell158 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell159 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell160 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell162 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell163 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell164 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell165 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell166 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell167 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell168 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell169 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell170 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell171 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell172 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell173 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell174 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell175 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell176 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell177 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell178 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell179 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell180 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell181 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell182 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell183 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell184 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell185 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell186 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell187 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell188 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell189 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell190 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell191 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell192 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell193 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell194 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell195 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell196 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell197 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell199 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell200 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell201 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell202 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell203 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell204 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell205 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell206 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell207 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell208 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell209 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell210 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell211 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell212 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell213 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell214 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell215 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell216 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell217 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell218 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell219 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell220 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell221 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell222 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell223 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell224 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell225 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell226 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell227 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell228 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell229 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell230 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell231 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell232 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell233 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell234 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.SeasonPrm = New DevExpress.XtraReports.Parameters.Parameter()
        Me.YearPrm = New DevExpress.XtraReports.Parameters.Parameter()
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Group_Farmer = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SeedType_Lot = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell87 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell124 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell161 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell198 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 61.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 45.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        StoredProcQuery1.Name = "SP_GetReportActivity"
        QueryParameter1.Name = "@SeasonName"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.SeasonPrm]", GetType(String))
        QueryParameter2.Name = "@SeedYear"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.YearPrm]", GetType(String))
        StoredProcQuery1.Parameters.Add(QueryParameter1)
        StoredProcQuery1.Parameters.Add(QueryParameter2)
        StoredProcQuery1.StoredProcName = "SP_GetReportActivity"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {StoredProcQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.CalculatedField1")})
        Me.XrLabel1.Font = New System.Drawing.Font("Angsana New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 36.96296!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1117.0!, 30.58334!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Angsana New", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.ForeColor = System.Drawing.Color.Black
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(200.2084!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(716.5834!, 30.58334!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "แผนและผลการจัดทำแปลงขยายพันธุ์"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.SiteName")})
        Me.XrLabel4.Font = New System.Drawing.Font("Angsana New", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(205.4167!, 67.54633!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(706.1667!, 33.41668!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 61.80559!
        Me.PageFooter.Name = "PageFooter"
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader2, Me.GroupFooter1, Me.GroupHeader1, Me.GroupFooter2})
        Me.DetailReport.DataMember = "SP_GetReportActivity"
        Me.DetailReport.DataSource = Me.SqlDataSource1
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel20, Me.XrTable1})
        Me.Detail1.HeightF = 150.0!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        Me.Detail1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("SiteNo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("FarmerNo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'XrLabel20
        '
        Me.XrLabel20.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel20.BorderWidth = 1.0!
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.SeedType_Lot")})
        Me.XrLabel20.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(69.81244!, 150.0!)
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseBorderWidth = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UsePadding = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow4, Me.XrTableRow5, Me.XrTableRow6, Me.XrTableRow7, Me.XrTableRow8})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1117.0!, 150.0!)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell1, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell30, Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell33, Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell36, Me.XrTableCell37, Me.XrTableCell38, Me.XrTableCell39, Me.XrTableCell40, Me.XrTableCell41, Me.XrTableCell42, Me.XrTableCell43, Me.XrTableCell44, Me.XrTableCell45, Me.XrTableCell46, Me.XrTableCell47, Me.XrTableCell48, Me.XrTableCell49})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell2.RowSpan = 6
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UsePadding = False
        Me.XrTableCell2.Weight = 0.6981245988582675R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.SeedClassName")})
        Me.XrTableCell3.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell3.RowSpan = 6
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UsePadding = False
        Me.XrTableCell3.Weight = 0.417230147581233R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.GoalQuantity", "{0:#,#}")})
        Me.XrTableCell4.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell4.RowSpan = 6
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UsePadding = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell4.Weight = 0.37744873908534571R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.BuyQuantity", "{0:#,#}")})
        Me.XrTableCell5.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell5.RowSpan = 6
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UsePadding = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell5.Weight = 0.3574488830566408R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.TotalAreaSize", "{0:#,#}")})
        Me.XrTableCell6.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell6.RowSpan = 6
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UsePadding = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell6.Weight = 0.3574488830566408R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.Group_Farmer")})
        Me.XrTableCell7.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell7.RowSpan = 6
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UsePadding = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell7.Weight = 0.507448378934958R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell8.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "การปลูก"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell8.Weight = 0.3863572894746099R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell9.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "แผน"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell9.Weight = 0.30701796314171786R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell10.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UsePadding = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell10.Weight = 0.60513462148636987R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gOct1_2Plan", "{0:#,#}")})
        Me.XrTableCell11.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell11.StylePriority.UseBorders = False
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UsePadding = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell11.Weight = 0.20124936257844561R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gOct3_4Plan", "{0:#,#}")})
        Me.XrTableCell12.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell12.Weight = 0.21124936411215758R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gNov1_2Plan", "{0:#,#}")})
        Me.XrTableCell13.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell13.StylePriority.UseBorders = False
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UsePadding = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell13.Weight = 0.20125572356506083R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gNov3_4Plan", "{0:#,#}")})
        Me.XrTableCell1.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell1.Weight = 0.21124993631738251R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gDec1_2Plan", "{0:#,#}")})
        Me.XrTableCell26.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell26.StylePriority.UseBorders = False
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UsePadding = False
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell26.Weight = 0.2012502303949017R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gDec3_4Plan", "{0:#,#}")})
        Me.XrTableCell27.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell27.StylePriority.UseBorders = False
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.StylePriority.UsePadding = False
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell27.Weight = 0.21125085184574235R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJan1_2Plan", "{0:#,#}")})
        Me.XrTableCell28.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell28.StylePriority.UseBorders = False
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UsePadding = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell28.Weight = 0.20124962004266181R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJan3_4Plan", "{0:#,#}")})
        Me.XrTableCell29.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell29.StylePriority.UseBorders = False
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.StylePriority.UsePadding = False
        Me.XrTableCell29.StylePriority.UseTextAlignment = False
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell29.Weight = 0.21125024149350244R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gFeb1_2Plan", "{0:#,#}")})
        Me.XrTableCell30.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell30.StylePriority.UseBorders = False
        Me.XrTableCell30.StylePriority.UseFont = False
        Me.XrTableCell30.StylePriority.UsePadding = False
        Me.XrTableCell30.StylePriority.UseTextAlignment = False
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell30.Weight = 0.20124893339639188R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gFeb3_4Plan", "{0:#,#}")})
        Me.XrTableCell31.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell31.StylePriority.UseBorders = False
        Me.XrTableCell31.StylePriority.UseFont = False
        Me.XrTableCell31.StylePriority.UsePadding = False
        Me.XrTableCell31.StylePriority.UseTextAlignment = False
        Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell31.Weight = 0.2112526829024621R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gMar1_2Plan", "{0:#,#}")})
        Me.XrTableCell32.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell32.StylePriority.UseBorders = False
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.StylePriority.UsePadding = False
        Me.XrTableCell32.StylePriority.UseTextAlignment = False
        Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell32.Weight = 0.20124962004266181R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gMar3_4Plan", "{0:#,#}")})
        Me.XrTableCell33.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell33.StylePriority.UseBorders = False
        Me.XrTableCell33.StylePriority.UseFont = False
        Me.XrTableCell33.StylePriority.UsePadding = False
        Me.XrTableCell33.StylePriority.UseTextAlignment = False
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell33.Weight = 0.21124963114126255R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gApr1_2Plan", "{0:#,#}")})
        Me.XrTableCell34.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell34.StylePriority.UseBorders = False
        Me.XrTableCell34.StylePriority.UseFont = False
        Me.XrTableCell34.StylePriority.UsePadding = False
        Me.XrTableCell34.StylePriority.UseTextAlignment = False
        Me.XrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell34.Weight = 0.20125023039490172R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gApr3_4Plan", "{0:#,#}")})
        Me.XrTableCell35.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell35.StylePriority.UseBorders = False
        Me.XrTableCell35.StylePriority.UseFont = False
        Me.XrTableCell35.StylePriority.UsePadding = False
        Me.XrTableCell35.StylePriority.UseTextAlignment = False
        Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell35.Weight = 0.2112498600233525R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gMay1_2Plan", "{0:#,#}")})
        Me.XrTableCell36.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell36.StylePriority.UseBorders = False
        Me.XrTableCell36.StylePriority.UseFont = False
        Me.XrTableCell36.StylePriority.UsePadding = False
        Me.XrTableCell36.StylePriority.UseTextAlignment = False
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell36.Weight = 0.20125045978289405R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gMay3_4Plan", "{0:#,#}")})
        Me.XrTableCell37.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell37.StylePriority.UseBorders = False
        Me.XrTableCell37.StylePriority.UseFont = False
        Me.XrTableCell37.StylePriority.UsePadding = False
        Me.XrTableCell37.StylePriority.UseTextAlignment = False
        Me.XrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell37.Weight = 0.21124896164781082R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJun1_2Plan", "{0:#,#}")})
        Me.XrTableCell38.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell38.StylePriority.UseBorders = False
        Me.XrTableCell38.StylePriority.UseFont = False
        Me.XrTableCell38.StylePriority.UsePadding = False
        Me.XrTableCell38.StylePriority.UseTextAlignment = False
        Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell38.Weight = 0.20125078403244279R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell39.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJun3_4Plan", "{0:#,#}")})
        Me.XrTableCell39.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell39.StylePriority.UseBorders = False
        Me.XrTableCell39.StylePriority.UseFont = False
        Me.XrTableCell39.StylePriority.UsePadding = False
        Me.XrTableCell39.StylePriority.UseTextAlignment = False
        Me.XrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell39.Weight = 0.2112495719999026R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJul1_2Plan", "{0:#,#}")})
        Me.XrTableCell40.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell40.StylePriority.UseBorders = False
        Me.XrTableCell40.StylePriority.UseFont = False
        Me.XrTableCell40.StylePriority.UsePadding = False
        Me.XrTableCell40.StylePriority.UseTextAlignment = False
        Me.XrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell40.Weight = 0.20124977313679079R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJul3_4Plan", "{0:#,#}")})
        Me.XrTableCell41.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell41.StylePriority.UseBorders = False
        Me.XrTableCell41.StylePriority.UseFont = False
        Me.XrTableCell41.StylePriority.UsePadding = False
        Me.XrTableCell41.StylePriority.UseTextAlignment = False
        Me.XrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell41.Weight = 0.21125201340826968R
        '
        'XrTableCell42
        '
        Me.XrTableCell42.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gAug1_2Plan", "{0:#,#}")})
        Me.XrTableCell42.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell42.StylePriority.UseBorders = False
        Me.XrTableCell42.StylePriority.UseFont = False
        Me.XrTableCell42.StylePriority.UsePadding = False
        Me.XrTableCell42.StylePriority.UseTextAlignment = False
        Me.XrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell42.Weight = 0.20125017368035103R
        '
        'XrTableCell43
        '
        Me.XrTableCell43.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gAug3_4Plan", "{0:#,#}")})
        Me.XrTableCell43.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell43.StylePriority.UseBorders = False
        Me.XrTableCell43.StylePriority.UseFont = False
        Me.XrTableCell43.StylePriority.UsePadding = False
        Me.XrTableCell43.StylePriority.UseTextAlignment = False
        Me.XrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell43.Weight = 0.21124957199990257R
        '
        'XrTableCell44
        '
        Me.XrTableCell44.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gSep1_2Plan", "{0:#,#}")})
        Me.XrTableCell44.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell44.StylePriority.UseBorders = False
        Me.XrTableCell44.StylePriority.UseFont = False
        Me.XrTableCell44.StylePriority.UsePadding = False
        Me.XrTableCell44.StylePriority.UseTextAlignment = False
        Me.XrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell44.Weight = 0.20124956332825925R
        '
        'XrTableCell45
        '
        Me.XrTableCell45.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gSep3_4Plan", "{0:#,#}")})
        Me.XrTableCell45.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell45.StylePriority.UseBorders = False
        Me.XrTableCell45.StylePriority.UseFont = False
        Me.XrTableCell45.StylePriority.UsePadding = False
        Me.XrTableCell45.StylePriority.UseTextAlignment = False
        Me.XrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell45.Weight = 0.21125079270408614R
        '
        'XrTableCell46
        '
        Me.XrTableCell46.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.SumGrowPlan")})
        Me.XrTableCell46.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell46.StylePriority.UseBorders = False
        Me.XrTableCell46.StylePriority.UseFont = False
        Me.XrTableCell46.StylePriority.UsePadding = False
        Me.XrTableCell46.StylePriority.UseTextAlignment = False
        Me.XrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell46.Weight = 0.44513019473475451R
        '
        'XrTableCell47
        '
        Me.XrTableCell47.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gStartDate", "{0:d MMM yy}")})
        Me.XrTableCell47.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableCell47.StylePriority.UseBorders = False
        Me.XrTableCell47.StylePriority.UseFont = False
        Me.XrTableCell47.StylePriority.UsePadding = False
        Me.XrTableCell47.StylePriority.UseTextAlignment = False
        Me.XrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell47.Weight = 0.47513386836576754R
        '
        'XrTableCell48
        '
        Me.XrTableCell48.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gEndDate", "{0:d MMM yy}")})
        Me.XrTableCell48.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.StylePriority.UseBorders = False
        Me.XrTableCell48.StylePriority.UseFont = False
        Me.XrTableCell48.StylePriority.UseTextAlignment = False
        Me.XrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell48.Weight = 0.47513447871756442R
        '
        'XrTableCell49
        '
        Me.XrTableCell49.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell49.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell49.StylePriority.UseBorders = False
        Me.XrTableCell49.StylePriority.UseFont = False
        Me.XrTableCell49.StylePriority.UsePadding = False
        Me.XrTableCell49.Weight = 0.81093706819722677R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell50, Me.XrTableCell51, Me.XrTableCell52, Me.XrTableCell53, Me.XrTableCell54, Me.XrTableCell55, Me.XrTableCell56, Me.XrTableCell57, Me.XrTableCell58, Me.XrTableCell59, Me.XrTableCell60, Me.XrTableCell61, Me.XrTableCell62, Me.XrTableCell63, Me.XrTableCell64, Me.XrTableCell65, Me.XrTableCell66, Me.XrTableCell67, Me.XrTableCell68, Me.XrTableCell69, Me.XrTableCell70, Me.XrTableCell71, Me.XrTableCell72, Me.XrTableCell73, Me.XrTableCell74, Me.XrTableCell75, Me.XrTableCell76, Me.XrTableCell77, Me.XrTableCell78, Me.XrTableCell79, Me.XrTableCell80, Me.XrTableCell81, Me.XrTableCell82, Me.XrTableCell83, Me.XrTableCell84, Me.XrTableCell85, Me.XrTableCell86})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell51
        '
        Me.XrTableCell51.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell51.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell51.StylePriority.UseBorders = False
        Me.XrTableCell51.StylePriority.UseFont = False
        Me.XrTableCell51.StylePriority.UsePadding = False
        Me.XrTableCell51.Weight = 0.41723014758123289R
        '
        'XrTableCell52
        '
        Me.XrTableCell52.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell52.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell52.StylePriority.UseBorders = False
        Me.XrTableCell52.StylePriority.UseFont = False
        Me.XrTableCell52.StylePriority.UsePadding = False
        Me.XrTableCell52.StylePriority.UseTextAlignment = False
        Me.XrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell52.Weight = 0.37744873908534571R
        '
        'XrTableCell53
        '
        Me.XrTableCell53.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell53.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell53.Name = "XrTableCell53"
        Me.XrTableCell53.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell53.StylePriority.UseBorders = False
        Me.XrTableCell53.StylePriority.UseFont = False
        Me.XrTableCell53.StylePriority.UsePadding = False
        Me.XrTableCell53.StylePriority.UseTextAlignment = False
        Me.XrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell53.Weight = 0.3574488830566408R
        '
        'XrTableCell54
        '
        Me.XrTableCell54.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell54.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell54.StylePriority.UseBorders = False
        Me.XrTableCell54.StylePriority.UseFont = False
        Me.XrTableCell54.StylePriority.UsePadding = False
        Me.XrTableCell54.StylePriority.UseTextAlignment = False
        Me.XrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell54.Weight = 0.3574488830566408R
        '
        'XrTableCell55
        '
        Me.XrTableCell55.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell55.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell55.StylePriority.UseBorders = False
        Me.XrTableCell55.StylePriority.UseFont = False
        Me.XrTableCell55.StylePriority.UsePadding = False
        Me.XrTableCell55.StylePriority.UseTextAlignment = False
        Me.XrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell55.Weight = 0.507448378934958R
        '
        'XrTableCell56
        '
        Me.XrTableCell56.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell56.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.StylePriority.UseBorders = False
        Me.XrTableCell56.StylePriority.UseFont = False
        Me.XrTableCell56.StylePriority.UseTextAlignment = False
        Me.XrTableCell56.Text = "(ไร่)"
        Me.XrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell56.Weight = 0.3863572894746099R
        '
        'XrTableCell57
        '
        Me.XrTableCell57.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell57.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell57.Name = "XrTableCell57"
        Me.XrTableCell57.StylePriority.UseBorders = False
        Me.XrTableCell57.StylePriority.UseFont = False
        Me.XrTableCell57.StylePriority.UseTextAlignment = False
        Me.XrTableCell57.Text = "ผล"
        Me.XrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell57.Weight = 0.30701796314171786R
        '
        'XrTableCell58
        '
        Me.XrTableCell58.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell58.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell58.Name = "XrTableCell58"
        Me.XrTableCell58.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell58.StylePriority.UseBorders = False
        Me.XrTableCell58.StylePriority.UseFont = False
        Me.XrTableCell58.StylePriority.UsePadding = False
        Me.XrTableCell58.StylePriority.UseTextAlignment = False
        Me.XrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell58.Weight = 0.60513462148636987R
        '
        'XrTableCell59
        '
        Me.XrTableCell59.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell59.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gOct1_2Result", "{0:#,#}")})
        Me.XrTableCell59.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell59.Name = "XrTableCell59"
        Me.XrTableCell59.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell59.StylePriority.UseBorders = False
        Me.XrTableCell59.StylePriority.UseFont = False
        Me.XrTableCell59.StylePriority.UsePadding = False
        Me.XrTableCell59.StylePriority.UseTextAlignment = False
        Me.XrTableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell59.Weight = 0.20124936257844561R
        '
        'XrTableCell60
        '
        Me.XrTableCell60.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gOct3_4Result", "{0:#,#}")})
        Me.XrTableCell60.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell60.Name = "XrTableCell60"
        Me.XrTableCell60.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell60.StylePriority.UseBorders = False
        Me.XrTableCell60.StylePriority.UseFont = False
        Me.XrTableCell60.StylePriority.UsePadding = False
        Me.XrTableCell60.StylePriority.UseTextAlignment = False
        Me.XrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell60.Weight = 0.21124936411215758R
        '
        'XrTableCell61
        '
        Me.XrTableCell61.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell61.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gNov1_2Result", "{0:#,#}")})
        Me.XrTableCell61.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell61.Name = "XrTableCell61"
        Me.XrTableCell61.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell61.StylePriority.UseBorders = False
        Me.XrTableCell61.StylePriority.UseFont = False
        Me.XrTableCell61.StylePriority.UsePadding = False
        Me.XrTableCell61.StylePriority.UseTextAlignment = False
        Me.XrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell61.Weight = 0.20125572356506083R
        '
        'XrTableCell62
        '
        Me.XrTableCell62.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell62.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gNov3_4Result", "{0:#,#}")})
        Me.XrTableCell62.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell62.Name = "XrTableCell62"
        Me.XrTableCell62.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell62.StylePriority.UseBorders = False
        Me.XrTableCell62.StylePriority.UseFont = False
        Me.XrTableCell62.StylePriority.UsePadding = False
        Me.XrTableCell62.StylePriority.UseTextAlignment = False
        Me.XrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell62.Weight = 0.21124993631738251R
        '
        'XrTableCell63
        '
        Me.XrTableCell63.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell63.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gDec1_2Result", "{0:#,#}")})
        Me.XrTableCell63.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell63.Name = "XrTableCell63"
        Me.XrTableCell63.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell63.StylePriority.UseBorders = False
        Me.XrTableCell63.StylePriority.UseFont = False
        Me.XrTableCell63.StylePriority.UsePadding = False
        Me.XrTableCell63.StylePriority.UseTextAlignment = False
        Me.XrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell63.Weight = 0.2012502303949017R
        '
        'XrTableCell64
        '
        Me.XrTableCell64.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell64.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gDec3_4Result", "{0:#,#}")})
        Me.XrTableCell64.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell64.Name = "XrTableCell64"
        Me.XrTableCell64.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell64.StylePriority.UseBorders = False
        Me.XrTableCell64.StylePriority.UseFont = False
        Me.XrTableCell64.StylePriority.UsePadding = False
        Me.XrTableCell64.StylePriority.UseTextAlignment = False
        Me.XrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell64.Weight = 0.21125085184574235R
        '
        'XrTableCell65
        '
        Me.XrTableCell65.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell65.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJan1_2Result", "{0:#,#}")})
        Me.XrTableCell65.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell65.Name = "XrTableCell65"
        Me.XrTableCell65.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell65.StylePriority.UseBorders = False
        Me.XrTableCell65.StylePriority.UseFont = False
        Me.XrTableCell65.StylePriority.UsePadding = False
        Me.XrTableCell65.StylePriority.UseTextAlignment = False
        Me.XrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell65.Weight = 0.20124962004266181R
        '
        'XrTableCell66
        '
        Me.XrTableCell66.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell66.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJan3_4Result", "{0:#,#}")})
        Me.XrTableCell66.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell66.Name = "XrTableCell66"
        Me.XrTableCell66.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell66.StylePriority.UseBorders = False
        Me.XrTableCell66.StylePriority.UseFont = False
        Me.XrTableCell66.StylePriority.UsePadding = False
        Me.XrTableCell66.StylePriority.UseTextAlignment = False
        Me.XrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell66.Weight = 0.21125024149350244R
        '
        'XrTableCell67
        '
        Me.XrTableCell67.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell67.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gFeb1_2Result", "{0:#,#}")})
        Me.XrTableCell67.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell67.Name = "XrTableCell67"
        Me.XrTableCell67.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell67.StylePriority.UseBorders = False
        Me.XrTableCell67.StylePriority.UseFont = False
        Me.XrTableCell67.StylePriority.UsePadding = False
        Me.XrTableCell67.StylePriority.UseTextAlignment = False
        Me.XrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell67.Weight = 0.20124893339639188R
        '
        'XrTableCell68
        '
        Me.XrTableCell68.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell68.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gFeb3_4Result", "{0:#,#}")})
        Me.XrTableCell68.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell68.Name = "XrTableCell68"
        Me.XrTableCell68.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell68.StylePriority.UseBorders = False
        Me.XrTableCell68.StylePriority.UseFont = False
        Me.XrTableCell68.StylePriority.UsePadding = False
        Me.XrTableCell68.StylePriority.UseTextAlignment = False
        Me.XrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell68.Weight = 0.2112526829024621R
        '
        'XrTableCell69
        '
        Me.XrTableCell69.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell69.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gMar1_2Result", "{0:#,#}")})
        Me.XrTableCell69.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell69.Name = "XrTableCell69"
        Me.XrTableCell69.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell69.StylePriority.UseBorders = False
        Me.XrTableCell69.StylePriority.UseFont = False
        Me.XrTableCell69.StylePriority.UsePadding = False
        Me.XrTableCell69.StylePriority.UseTextAlignment = False
        Me.XrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell69.Weight = 0.20124962004266181R
        '
        'XrTableCell70
        '
        Me.XrTableCell70.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell70.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gMar3_4Result", "{0:#,#}")})
        Me.XrTableCell70.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell70.Name = "XrTableCell70"
        Me.XrTableCell70.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell70.StylePriority.UseBorders = False
        Me.XrTableCell70.StylePriority.UseFont = False
        Me.XrTableCell70.StylePriority.UsePadding = False
        Me.XrTableCell70.StylePriority.UseTextAlignment = False
        Me.XrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell70.Weight = 0.21124963114126255R
        '
        'XrTableCell71
        '
        Me.XrTableCell71.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell71.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gApr1_2Result", "{0:#,#}")})
        Me.XrTableCell71.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell71.Name = "XrTableCell71"
        Me.XrTableCell71.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell71.StylePriority.UseBorders = False
        Me.XrTableCell71.StylePriority.UseFont = False
        Me.XrTableCell71.StylePriority.UsePadding = False
        Me.XrTableCell71.StylePriority.UseTextAlignment = False
        Me.XrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell71.Weight = 0.20125023039490172R
        '
        'XrTableCell72
        '
        Me.XrTableCell72.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell72.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gApr3_4Result", "{0:#,#}")})
        Me.XrTableCell72.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell72.Name = "XrTableCell72"
        Me.XrTableCell72.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell72.StylePriority.UseBorders = False
        Me.XrTableCell72.StylePriority.UseFont = False
        Me.XrTableCell72.StylePriority.UsePadding = False
        Me.XrTableCell72.StylePriority.UseTextAlignment = False
        Me.XrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell72.Weight = 0.2112498600233525R
        '
        'XrTableCell73
        '
        Me.XrTableCell73.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell73.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gMay1_2Result", "{0:#,#}")})
        Me.XrTableCell73.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell73.Name = "XrTableCell73"
        Me.XrTableCell73.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell73.StylePriority.UseBorders = False
        Me.XrTableCell73.StylePriority.UseFont = False
        Me.XrTableCell73.StylePriority.UsePadding = False
        Me.XrTableCell73.StylePriority.UseTextAlignment = False
        Me.XrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell73.Weight = 0.20125045978289405R
        '
        'XrTableCell74
        '
        Me.XrTableCell74.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell74.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gMay3_4Result", "{0:#,#}")})
        Me.XrTableCell74.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell74.Name = "XrTableCell74"
        Me.XrTableCell74.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell74.StylePriority.UseBorders = False
        Me.XrTableCell74.StylePriority.UseFont = False
        Me.XrTableCell74.StylePriority.UsePadding = False
        Me.XrTableCell74.StylePriority.UseTextAlignment = False
        Me.XrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell74.Weight = 0.21124896164781082R
        '
        'XrTableCell75
        '
        Me.XrTableCell75.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell75.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJun1_2Result", "{0:#,#}")})
        Me.XrTableCell75.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell75.Name = "XrTableCell75"
        Me.XrTableCell75.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell75.StylePriority.UseBorders = False
        Me.XrTableCell75.StylePriority.UseFont = False
        Me.XrTableCell75.StylePriority.UsePadding = False
        Me.XrTableCell75.StylePriority.UseTextAlignment = False
        Me.XrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell75.Weight = 0.20125078403244279R
        '
        'XrTableCell76
        '
        Me.XrTableCell76.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell76.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJun3_4Result", "{0:#,#}")})
        Me.XrTableCell76.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell76.Name = "XrTableCell76"
        Me.XrTableCell76.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell76.StylePriority.UseBorders = False
        Me.XrTableCell76.StylePriority.UseFont = False
        Me.XrTableCell76.StylePriority.UsePadding = False
        Me.XrTableCell76.StylePriority.UseTextAlignment = False
        Me.XrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell76.Weight = 0.2112495719999026R
        '
        'XrTableCell77
        '
        Me.XrTableCell77.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell77.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJul1_2Result", "{0:#,#}")})
        Me.XrTableCell77.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell77.Name = "XrTableCell77"
        Me.XrTableCell77.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell77.StylePriority.UseBorders = False
        Me.XrTableCell77.StylePriority.UseFont = False
        Me.XrTableCell77.StylePriority.UsePadding = False
        Me.XrTableCell77.StylePriority.UseTextAlignment = False
        Me.XrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell77.Weight = 0.20124977313679079R
        '
        'XrTableCell78
        '
        Me.XrTableCell78.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell78.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gJul3_4Result", "{0:#,#}")})
        Me.XrTableCell78.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell78.Name = "XrTableCell78"
        Me.XrTableCell78.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell78.StylePriority.UseBorders = False
        Me.XrTableCell78.StylePriority.UseFont = False
        Me.XrTableCell78.StylePriority.UsePadding = False
        Me.XrTableCell78.StylePriority.UseTextAlignment = False
        Me.XrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell78.Weight = 0.21125201340826968R
        '
        'XrTableCell79
        '
        Me.XrTableCell79.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell79.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gAug1_2Result", "{0:#,#}")})
        Me.XrTableCell79.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell79.Name = "XrTableCell79"
        Me.XrTableCell79.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell79.StylePriority.UseBorders = False
        Me.XrTableCell79.StylePriority.UseFont = False
        Me.XrTableCell79.StylePriority.UsePadding = False
        Me.XrTableCell79.StylePriority.UseTextAlignment = False
        Me.XrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell79.Weight = 0.20125017368035103R
        '
        'XrTableCell80
        '
        Me.XrTableCell80.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell80.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gAug3_4Result", "{0:#,#}")})
        Me.XrTableCell80.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell80.Name = "XrTableCell80"
        Me.XrTableCell80.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell80.StylePriority.UseBorders = False
        Me.XrTableCell80.StylePriority.UseFont = False
        Me.XrTableCell80.StylePriority.UsePadding = False
        Me.XrTableCell80.StylePriority.UseTextAlignment = False
        Me.XrTableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell80.Weight = 0.21124957199990257R
        '
        'XrTableCell81
        '
        Me.XrTableCell81.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell81.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gSep1_2Result", "{0:#,#}")})
        Me.XrTableCell81.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell81.Name = "XrTableCell81"
        Me.XrTableCell81.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell81.StylePriority.UseBorders = False
        Me.XrTableCell81.StylePriority.UseFont = False
        Me.XrTableCell81.StylePriority.UsePadding = False
        Me.XrTableCell81.StylePriority.UseTextAlignment = False
        Me.XrTableCell81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell81.Weight = 0.20124956332825925R
        '
        'XrTableCell82
        '
        Me.XrTableCell82.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell82.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.gSep3_4Result", "{0:#,#}")})
        Me.XrTableCell82.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell82.Name = "XrTableCell82"
        Me.XrTableCell82.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell82.StylePriority.UseBorders = False
        Me.XrTableCell82.StylePriority.UseFont = False
        Me.XrTableCell82.StylePriority.UsePadding = False
        Me.XrTableCell82.StylePriority.UseTextAlignment = False
        Me.XrTableCell82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell82.Weight = 0.21125079270408614R
        '
        'XrTableCell83
        '
        Me.XrTableCell83.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell83.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.SumGrowResult")})
        Me.XrTableCell83.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell83.Name = "XrTableCell83"
        Me.XrTableCell83.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell83.StylePriority.UseBorders = False
        Me.XrTableCell83.StylePriority.UseFont = False
        Me.XrTableCell83.StylePriority.UsePadding = False
        Me.XrTableCell83.StylePriority.UseTextAlignment = False
        Me.XrTableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell83.Weight = 0.44513019473475451R
        '
        'XrTableCell84
        '
        Me.XrTableCell84.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell84.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell84.Name = "XrTableCell84"
        Me.XrTableCell84.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell84.StylePriority.UseBorders = False
        Me.XrTableCell84.StylePriority.UseFont = False
        Me.XrTableCell84.StylePriority.UsePadding = False
        Me.XrTableCell84.StylePriority.UseTextAlignment = False
        Me.XrTableCell84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell84.Weight = 0.47513386836576754R
        '
        'XrTableCell85
        '
        Me.XrTableCell85.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell85.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell85.Name = "XrTableCell85"
        Me.XrTableCell85.StylePriority.UseBorders = False
        Me.XrTableCell85.StylePriority.UseFont = False
        Me.XrTableCell85.StylePriority.UseTextAlignment = False
        Me.XrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell85.Weight = 0.47513447871756442R
        '
        'XrTableCell86
        '
        Me.XrTableCell86.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell86.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell86.Name = "XrTableCell86"
        Me.XrTableCell86.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell86.StylePriority.UseBorders = False
        Me.XrTableCell86.StylePriority.UseFont = False
        Me.XrTableCell86.StylePriority.UsePadding = False
        Me.XrTableCell86.Weight = 0.81093706819722677R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell87, Me.XrTableCell88, Me.XrTableCell89, Me.XrTableCell90, Me.XrTableCell91, Me.XrTableCell92, Me.XrTableCell93, Me.XrTableCell94, Me.XrTableCell95, Me.XrTableCell96, Me.XrTableCell97, Me.XrTableCell98, Me.XrTableCell99, Me.XrTableCell100, Me.XrTableCell101, Me.XrTableCell102, Me.XrTableCell103, Me.XrTableCell104, Me.XrTableCell105, Me.XrTableCell106, Me.XrTableCell107, Me.XrTableCell108, Me.XrTableCell109, Me.XrTableCell110, Me.XrTableCell111, Me.XrTableCell112, Me.XrTableCell113, Me.XrTableCell114, Me.XrTableCell115, Me.XrTableCell116, Me.XrTableCell117, Me.XrTableCell118, Me.XrTableCell119, Me.XrTableCell120, Me.XrTableCell121, Me.XrTableCell122, Me.XrTableCell123})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell88
        '
        Me.XrTableCell88.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell88.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell88.Name = "XrTableCell88"
        Me.XrTableCell88.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell88.StylePriority.UseBorders = False
        Me.XrTableCell88.StylePriority.UseFont = False
        Me.XrTableCell88.StylePriority.UsePadding = False
        Me.XrTableCell88.Weight = 0.417230147581233R
        '
        'XrTableCell89
        '
        Me.XrTableCell89.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell89.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell89.Name = "XrTableCell89"
        Me.XrTableCell89.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell89.StylePriority.UseBorders = False
        Me.XrTableCell89.StylePriority.UseFont = False
        Me.XrTableCell89.StylePriority.UsePadding = False
        Me.XrTableCell89.StylePriority.UseTextAlignment = False
        Me.XrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell89.Weight = 0.37744873908534571R
        '
        'XrTableCell90
        '
        Me.XrTableCell90.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell90.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell90.Name = "XrTableCell90"
        Me.XrTableCell90.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell90.StylePriority.UseBorders = False
        Me.XrTableCell90.StylePriority.UseFont = False
        Me.XrTableCell90.StylePriority.UsePadding = False
        Me.XrTableCell90.StylePriority.UseTextAlignment = False
        Me.XrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell90.Weight = 0.3574488830566408R
        '
        'XrTableCell91
        '
        Me.XrTableCell91.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell91.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell91.Name = "XrTableCell91"
        Me.XrTableCell91.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell91.StylePriority.UseBorders = False
        Me.XrTableCell91.StylePriority.UseFont = False
        Me.XrTableCell91.StylePriority.UsePadding = False
        Me.XrTableCell91.StylePriority.UseTextAlignment = False
        Me.XrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell91.Weight = 0.3574488830566408R
        '
        'XrTableCell92
        '
        Me.XrTableCell92.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell92.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell92.Name = "XrTableCell92"
        Me.XrTableCell92.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell92.StylePriority.UseBorders = False
        Me.XrTableCell92.StylePriority.UseFont = False
        Me.XrTableCell92.StylePriority.UsePadding = False
        Me.XrTableCell92.StylePriority.UseTextAlignment = False
        Me.XrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell92.Weight = 0.507448378934958R
        '
        'XrTableCell93
        '
        Me.XrTableCell93.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell93.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell93.Name = "XrTableCell93"
        Me.XrTableCell93.StylePriority.UseBorders = False
        Me.XrTableCell93.StylePriority.UseFont = False
        Me.XrTableCell93.StylePriority.UseTextAlignment = False
        Me.XrTableCell93.Text = "เก็บเกี่ยว"
        Me.XrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell93.Weight = 0.3863572894746099R
        '
        'XrTableCell94
        '
        Me.XrTableCell94.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell94.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell94.Name = "XrTableCell94"
        Me.XrTableCell94.StylePriority.UseBorders = False
        Me.XrTableCell94.StylePriority.UseFont = False
        Me.XrTableCell94.StylePriority.UseTextAlignment = False
        Me.XrTableCell94.Text = "แผน"
        Me.XrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell94.Weight = 0.30701796314171786R
        '
        'XrTableCell95
        '
        Me.XrTableCell95.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell95.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell95.Name = "XrTableCell95"
        Me.XrTableCell95.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell95.StylePriority.UseBorders = False
        Me.XrTableCell95.StylePriority.UseFont = False
        Me.XrTableCell95.StylePriority.UsePadding = False
        Me.XrTableCell95.StylePriority.UseTextAlignment = False
        Me.XrTableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell95.Weight = 0.60513462148636987R
        '
        'XrTableCell96
        '
        Me.XrTableCell96.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell96.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hOct1_2Plan", "{0:#,#}")})
        Me.XrTableCell96.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell96.Name = "XrTableCell96"
        Me.XrTableCell96.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell96.StylePriority.UseBorders = False
        Me.XrTableCell96.StylePriority.UseFont = False
        Me.XrTableCell96.StylePriority.UsePadding = False
        Me.XrTableCell96.StylePriority.UseTextAlignment = False
        Me.XrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell96.Weight = 0.20124936257844561R
        '
        'XrTableCell97
        '
        Me.XrTableCell97.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell97.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hOct3_4Plan", "{0:#,#}")})
        Me.XrTableCell97.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell97.Name = "XrTableCell97"
        Me.XrTableCell97.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell97.StylePriority.UseBorders = False
        Me.XrTableCell97.StylePriority.UseFont = False
        Me.XrTableCell97.StylePriority.UsePadding = False
        Me.XrTableCell97.StylePriority.UseTextAlignment = False
        Me.XrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell97.Weight = 0.21124936411215758R
        '
        'XrTableCell98
        '
        Me.XrTableCell98.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell98.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMay1_2Plan", "{0:#,#}")})
        Me.XrTableCell98.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell98.Name = "XrTableCell98"
        Me.XrTableCell98.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell98.StylePriority.UseBorders = False
        Me.XrTableCell98.StylePriority.UseFont = False
        Me.XrTableCell98.StylePriority.UsePadding = False
        Me.XrTableCell98.StylePriority.UseTextAlignment = False
        Me.XrTableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell98.Weight = 0.20125572356506083R
        '
        'XrTableCell99
        '
        Me.XrTableCell99.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell99.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMay3_4Plan", "{0:#,#}")})
        Me.XrTableCell99.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell99.Name = "XrTableCell99"
        Me.XrTableCell99.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell99.StylePriority.UseBorders = False
        Me.XrTableCell99.StylePriority.UseFont = False
        Me.XrTableCell99.StylePriority.UsePadding = False
        Me.XrTableCell99.StylePriority.UseTextAlignment = False
        Me.XrTableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell99.Weight = 0.21124993631738251R
        '
        'XrTableCell100
        '
        Me.XrTableCell100.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell100.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hDec1_2Plan", "{0:#,#}")})
        Me.XrTableCell100.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell100.Name = "XrTableCell100"
        Me.XrTableCell100.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell100.StylePriority.UseBorders = False
        Me.XrTableCell100.StylePriority.UseFont = False
        Me.XrTableCell100.StylePriority.UsePadding = False
        Me.XrTableCell100.StylePriority.UseTextAlignment = False
        Me.XrTableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell100.Weight = 0.2012502303949017R
        '
        'XrTableCell101
        '
        Me.XrTableCell101.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell101.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hDec3_4Plan", "{0:#,#}")})
        Me.XrTableCell101.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell101.Name = "XrTableCell101"
        Me.XrTableCell101.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell101.StylePriority.UseBorders = False
        Me.XrTableCell101.StylePriority.UseFont = False
        Me.XrTableCell101.StylePriority.UsePadding = False
        Me.XrTableCell101.StylePriority.UseTextAlignment = False
        Me.XrTableCell101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell101.Weight = 0.21125085184574235R
        '
        'XrTableCell102
        '
        Me.XrTableCell102.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell102.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJan1_2Plan", "{0:#,#}")})
        Me.XrTableCell102.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell102.Name = "XrTableCell102"
        Me.XrTableCell102.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell102.StylePriority.UseBorders = False
        Me.XrTableCell102.StylePriority.UseFont = False
        Me.XrTableCell102.StylePriority.UsePadding = False
        Me.XrTableCell102.StylePriority.UseTextAlignment = False
        Me.XrTableCell102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell102.Weight = 0.20124962004266181R
        '
        'XrTableCell103
        '
        Me.XrTableCell103.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell103.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJan3_4Plan", "{0:#,#}")})
        Me.XrTableCell103.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell103.Name = "XrTableCell103"
        Me.XrTableCell103.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell103.StylePriority.UseBorders = False
        Me.XrTableCell103.StylePriority.UseFont = False
        Me.XrTableCell103.StylePriority.UsePadding = False
        Me.XrTableCell103.StylePriority.UseTextAlignment = False
        Me.XrTableCell103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell103.Weight = 0.21125024149350244R
        '
        'XrTableCell104
        '
        Me.XrTableCell104.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell104.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hFeb1_2Plan", "{0:#,#}")})
        Me.XrTableCell104.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell104.Name = "XrTableCell104"
        Me.XrTableCell104.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell104.StylePriority.UseBorders = False
        Me.XrTableCell104.StylePriority.UseFont = False
        Me.XrTableCell104.StylePriority.UsePadding = False
        Me.XrTableCell104.StylePriority.UseTextAlignment = False
        Me.XrTableCell104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell104.Weight = 0.20124893339639188R
        '
        'XrTableCell105
        '
        Me.XrTableCell105.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell105.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hFeb3_4Plan", "{0:#,#}")})
        Me.XrTableCell105.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell105.Name = "XrTableCell105"
        Me.XrTableCell105.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell105.StylePriority.UseBorders = False
        Me.XrTableCell105.StylePriority.UseFont = False
        Me.XrTableCell105.StylePriority.UsePadding = False
        Me.XrTableCell105.StylePriority.UseTextAlignment = False
        Me.XrTableCell105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell105.Weight = 0.2112526829024621R
        '
        'XrTableCell106
        '
        Me.XrTableCell106.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell106.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMar1_2Plan", "{0:#,#}")})
        Me.XrTableCell106.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell106.Name = "XrTableCell106"
        Me.XrTableCell106.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell106.StylePriority.UseBorders = False
        Me.XrTableCell106.StylePriority.UseFont = False
        Me.XrTableCell106.StylePriority.UsePadding = False
        Me.XrTableCell106.StylePriority.UseTextAlignment = False
        Me.XrTableCell106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell106.Weight = 0.20124962004266181R
        '
        'XrTableCell107
        '
        Me.XrTableCell107.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell107.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMar3_4Plan", "{0:#,#}")})
        Me.XrTableCell107.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell107.Name = "XrTableCell107"
        Me.XrTableCell107.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell107.StylePriority.UseBorders = False
        Me.XrTableCell107.StylePriority.UseFont = False
        Me.XrTableCell107.StylePriority.UsePadding = False
        Me.XrTableCell107.StylePriority.UseTextAlignment = False
        Me.XrTableCell107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell107.Weight = 0.21124963114126255R
        '
        'XrTableCell108
        '
        Me.XrTableCell108.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell108.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hApr1_2Plan", "{0:#,#}")})
        Me.XrTableCell108.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell108.Name = "XrTableCell108"
        Me.XrTableCell108.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell108.StylePriority.UseBorders = False
        Me.XrTableCell108.StylePriority.UseFont = False
        Me.XrTableCell108.StylePriority.UsePadding = False
        Me.XrTableCell108.StylePriority.UseTextAlignment = False
        Me.XrTableCell108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell108.Weight = 0.20125023039490172R
        '
        'XrTableCell109
        '
        Me.XrTableCell109.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell109.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hApr3_4Plan", "{0:#,#}")})
        Me.XrTableCell109.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell109.Name = "XrTableCell109"
        Me.XrTableCell109.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell109.StylePriority.UseBorders = False
        Me.XrTableCell109.StylePriority.UseFont = False
        Me.XrTableCell109.StylePriority.UsePadding = False
        Me.XrTableCell109.StylePriority.UseTextAlignment = False
        Me.XrTableCell109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell109.Weight = 0.2112498600233525R
        '
        'XrTableCell110
        '
        Me.XrTableCell110.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell110.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMar1_2Plan", "{0:#,#}")})
        Me.XrTableCell110.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell110.Name = "XrTableCell110"
        Me.XrTableCell110.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell110.StylePriority.UseBorders = False
        Me.XrTableCell110.StylePriority.UseFont = False
        Me.XrTableCell110.StylePriority.UsePadding = False
        Me.XrTableCell110.StylePriority.UseTextAlignment = False
        Me.XrTableCell110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell110.Weight = 0.20125045978289405R
        '
        'XrTableCell111
        '
        Me.XrTableCell111.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell111.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMar3_4Plan", "{0:#,#}")})
        Me.XrTableCell111.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell111.Name = "XrTableCell111"
        Me.XrTableCell111.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell111.StylePriority.UseBorders = False
        Me.XrTableCell111.StylePriority.UseFont = False
        Me.XrTableCell111.StylePriority.UsePadding = False
        Me.XrTableCell111.StylePriority.UseTextAlignment = False
        Me.XrTableCell111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell111.Weight = 0.21124896164781082R
        '
        'XrTableCell112
        '
        Me.XrTableCell112.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell112.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJun1_2Plan", "{0:#,#}")})
        Me.XrTableCell112.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell112.Name = "XrTableCell112"
        Me.XrTableCell112.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell112.StylePriority.UseBorders = False
        Me.XrTableCell112.StylePriority.UseFont = False
        Me.XrTableCell112.StylePriority.UsePadding = False
        Me.XrTableCell112.StylePriority.UseTextAlignment = False
        Me.XrTableCell112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell112.Weight = 0.20125078403244279R
        '
        'XrTableCell113
        '
        Me.XrTableCell113.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell113.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJun3_4Plan", "{0:#,#}")})
        Me.XrTableCell113.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell113.Name = "XrTableCell113"
        Me.XrTableCell113.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell113.StylePriority.UseBorders = False
        Me.XrTableCell113.StylePriority.UseFont = False
        Me.XrTableCell113.StylePriority.UsePadding = False
        Me.XrTableCell113.StylePriority.UseTextAlignment = False
        Me.XrTableCell113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell113.Weight = 0.2112495719999026R
        '
        'XrTableCell114
        '
        Me.XrTableCell114.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell114.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJul1_2Plan", "{0:#,#}")})
        Me.XrTableCell114.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell114.Name = "XrTableCell114"
        Me.XrTableCell114.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell114.StylePriority.UseBorders = False
        Me.XrTableCell114.StylePriority.UseFont = False
        Me.XrTableCell114.StylePriority.UsePadding = False
        Me.XrTableCell114.StylePriority.UseTextAlignment = False
        Me.XrTableCell114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell114.Weight = 0.20124977313679079R
        '
        'XrTableCell115
        '
        Me.XrTableCell115.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell115.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJul3_4Plan", "{0:#,#}")})
        Me.XrTableCell115.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell115.Name = "XrTableCell115"
        Me.XrTableCell115.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell115.StylePriority.UseBorders = False
        Me.XrTableCell115.StylePriority.UseFont = False
        Me.XrTableCell115.StylePriority.UsePadding = False
        Me.XrTableCell115.StylePriority.UseTextAlignment = False
        Me.XrTableCell115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell115.Weight = 0.21125201340826968R
        '
        'XrTableCell116
        '
        Me.XrTableCell116.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell116.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hAug1_2Plan", "{0:#,#}")})
        Me.XrTableCell116.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell116.Name = "XrTableCell116"
        Me.XrTableCell116.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell116.StylePriority.UseBorders = False
        Me.XrTableCell116.StylePriority.UseFont = False
        Me.XrTableCell116.StylePriority.UsePadding = False
        Me.XrTableCell116.StylePriority.UseTextAlignment = False
        Me.XrTableCell116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell116.Weight = 0.20125017368035103R
        '
        'XrTableCell117
        '
        Me.XrTableCell117.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell117.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hAug3_4Plan", "{0:#,#}")})
        Me.XrTableCell117.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell117.Name = "XrTableCell117"
        Me.XrTableCell117.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell117.StylePriority.UseBorders = False
        Me.XrTableCell117.StylePriority.UseFont = False
        Me.XrTableCell117.StylePriority.UsePadding = False
        Me.XrTableCell117.StylePriority.UseTextAlignment = False
        Me.XrTableCell117.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell117.Weight = 0.21124957199990257R
        '
        'XrTableCell118
        '
        Me.XrTableCell118.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell118.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hSep1_2Plan", "{0:#,#}")})
        Me.XrTableCell118.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell118.Name = "XrTableCell118"
        Me.XrTableCell118.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell118.StylePriority.UseBorders = False
        Me.XrTableCell118.StylePriority.UseFont = False
        Me.XrTableCell118.StylePriority.UsePadding = False
        Me.XrTableCell118.StylePriority.UseTextAlignment = False
        Me.XrTableCell118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell118.Weight = 0.20124956332825925R
        '
        'XrTableCell119
        '
        Me.XrTableCell119.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell119.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hSep3_4Plan", "{0:#,#}")})
        Me.XrTableCell119.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell119.Name = "XrTableCell119"
        Me.XrTableCell119.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell119.StylePriority.UseBorders = False
        Me.XrTableCell119.StylePriority.UseFont = False
        Me.XrTableCell119.StylePriority.UsePadding = False
        Me.XrTableCell119.StylePriority.UseTextAlignment = False
        Me.XrTableCell119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell119.Weight = 0.21125079270408614R
        '
        'XrTableCell120
        '
        Me.XrTableCell120.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell120.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.SumHarvestPlan")})
        Me.XrTableCell120.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell120.Name = "XrTableCell120"
        Me.XrTableCell120.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell120.StylePriority.UseBorders = False
        Me.XrTableCell120.StylePriority.UseFont = False
        Me.XrTableCell120.StylePriority.UsePadding = False
        Me.XrTableCell120.StylePriority.UseTextAlignment = False
        Me.XrTableCell120.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell120.Weight = 0.44513019473475451R
        '
        'XrTableCell121
        '
        Me.XrTableCell121.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell121.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hStartDate", "{0:d MMM yy}")})
        Me.XrTableCell121.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell121.Name = "XrTableCell121"
        Me.XrTableCell121.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableCell121.StylePriority.UseBorders = False
        Me.XrTableCell121.StylePriority.UseFont = False
        Me.XrTableCell121.StylePriority.UsePadding = False
        Me.XrTableCell121.StylePriority.UseTextAlignment = False
        Me.XrTableCell121.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell121.Weight = 0.47513386836576754R
        '
        'XrTableCell122
        '
        Me.XrTableCell122.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell122.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hEndDate", "{0:d MMM yy}")})
        Me.XrTableCell122.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell122.Name = "XrTableCell122"
        Me.XrTableCell122.StylePriority.UseBorders = False
        Me.XrTableCell122.StylePriority.UseFont = False
        Me.XrTableCell122.StylePriority.UseTextAlignment = False
        Me.XrTableCell122.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell122.Weight = 0.47513447871756442R
        '
        'XrTableCell123
        '
        Me.XrTableCell123.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell123.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell123.Name = "XrTableCell123"
        Me.XrTableCell123.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell123.StylePriority.UseBorders = False
        Me.XrTableCell123.StylePriority.UseFont = False
        Me.XrTableCell123.StylePriority.UsePadding = False
        Me.XrTableCell123.Weight = 0.81093706819722677R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell124, Me.XrTableCell125, Me.XrTableCell126, Me.XrTableCell127, Me.XrTableCell128, Me.XrTableCell129, Me.XrTableCell130, Me.XrTableCell131, Me.XrTableCell132, Me.XrTableCell133, Me.XrTableCell134, Me.XrTableCell135, Me.XrTableCell136, Me.XrTableCell137, Me.XrTableCell138, Me.XrTableCell139, Me.XrTableCell140, Me.XrTableCell141, Me.XrTableCell142, Me.XrTableCell143, Me.XrTableCell144, Me.XrTableCell145, Me.XrTableCell146, Me.XrTableCell147, Me.XrTableCell148, Me.XrTableCell149, Me.XrTableCell150, Me.XrTableCell151, Me.XrTableCell152, Me.XrTableCell153, Me.XrTableCell154, Me.XrTableCell155, Me.XrTableCell156, Me.XrTableCell157, Me.XrTableCell158, Me.XrTableCell159, Me.XrTableCell160})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell125
        '
        Me.XrTableCell125.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell125.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell125.Name = "XrTableCell125"
        Me.XrTableCell125.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell125.StylePriority.UseBorders = False
        Me.XrTableCell125.StylePriority.UseFont = False
        Me.XrTableCell125.StylePriority.UsePadding = False
        Me.XrTableCell125.Weight = 0.417230147581233R
        '
        'XrTableCell126
        '
        Me.XrTableCell126.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell126.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell126.Name = "XrTableCell126"
        Me.XrTableCell126.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell126.StylePriority.UseBorders = False
        Me.XrTableCell126.StylePriority.UseFont = False
        Me.XrTableCell126.StylePriority.UsePadding = False
        Me.XrTableCell126.StylePriority.UseTextAlignment = False
        Me.XrTableCell126.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell126.Weight = 0.37744873908534571R
        '
        'XrTableCell127
        '
        Me.XrTableCell127.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell127.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell127.Name = "XrTableCell127"
        Me.XrTableCell127.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell127.StylePriority.UseBorders = False
        Me.XrTableCell127.StylePriority.UseFont = False
        Me.XrTableCell127.StylePriority.UsePadding = False
        Me.XrTableCell127.StylePriority.UseTextAlignment = False
        Me.XrTableCell127.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell127.Weight = 0.3574488830566408R
        '
        'XrTableCell128
        '
        Me.XrTableCell128.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell128.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell128.Name = "XrTableCell128"
        Me.XrTableCell128.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell128.StylePriority.UseBorders = False
        Me.XrTableCell128.StylePriority.UseFont = False
        Me.XrTableCell128.StylePriority.UsePadding = False
        Me.XrTableCell128.StylePriority.UseTextAlignment = False
        Me.XrTableCell128.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell128.Weight = 0.3574488830566408R
        '
        'XrTableCell129
        '
        Me.XrTableCell129.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell129.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell129.Name = "XrTableCell129"
        Me.XrTableCell129.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell129.StylePriority.UseBorders = False
        Me.XrTableCell129.StylePriority.UseFont = False
        Me.XrTableCell129.StylePriority.UsePadding = False
        Me.XrTableCell129.StylePriority.UseTextAlignment = False
        Me.XrTableCell129.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell129.Weight = 0.507448378934958R
        '
        'XrTableCell130
        '
        Me.XrTableCell130.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell130.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell130.Name = "XrTableCell130"
        Me.XrTableCell130.StylePriority.UseBorders = False
        Me.XrTableCell130.StylePriority.UseFont = False
        Me.XrTableCell130.StylePriority.UseTextAlignment = False
        Me.XrTableCell130.Text = "(ไร่)"
        Me.XrTableCell130.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell130.Weight = 0.3863572894746099R
        '
        'XrTableCell131
        '
        Me.XrTableCell131.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell131.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell131.Name = "XrTableCell131"
        Me.XrTableCell131.StylePriority.UseBorders = False
        Me.XrTableCell131.StylePriority.UseFont = False
        Me.XrTableCell131.StylePriority.UseTextAlignment = False
        Me.XrTableCell131.Text = "ผล"
        Me.XrTableCell131.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell131.Weight = 0.30701796314171786R
        '
        'XrTableCell132
        '
        Me.XrTableCell132.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell132.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell132.Name = "XrTableCell132"
        Me.XrTableCell132.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell132.StylePriority.UseBorders = False
        Me.XrTableCell132.StylePriority.UseFont = False
        Me.XrTableCell132.StylePriority.UsePadding = False
        Me.XrTableCell132.StylePriority.UseTextAlignment = False
        Me.XrTableCell132.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell132.Weight = 0.60513462148636987R
        '
        'XrTableCell133
        '
        Me.XrTableCell133.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell133.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hOct1_2Result", "{0:#,#}")})
        Me.XrTableCell133.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell133.Name = "XrTableCell133"
        Me.XrTableCell133.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell133.StylePriority.UseBorders = False
        Me.XrTableCell133.StylePriority.UseFont = False
        Me.XrTableCell133.StylePriority.UsePadding = False
        Me.XrTableCell133.StylePriority.UseTextAlignment = False
        Me.XrTableCell133.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell133.Weight = 0.20124936257844561R
        '
        'XrTableCell134
        '
        Me.XrTableCell134.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell134.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hOct3_4Result", "{0:#,#}")})
        Me.XrTableCell134.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell134.Name = "XrTableCell134"
        Me.XrTableCell134.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell134.StylePriority.UseBorders = False
        Me.XrTableCell134.StylePriority.UseFont = False
        Me.XrTableCell134.StylePriority.UsePadding = False
        Me.XrTableCell134.StylePriority.UseTextAlignment = False
        Me.XrTableCell134.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell134.Weight = 0.21124936411215758R
        '
        'XrTableCell135
        '
        Me.XrTableCell135.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell135.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMay1_2Result", "{0:#,#}")})
        Me.XrTableCell135.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell135.Name = "XrTableCell135"
        Me.XrTableCell135.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell135.StylePriority.UseBorders = False
        Me.XrTableCell135.StylePriority.UseFont = False
        Me.XrTableCell135.StylePriority.UsePadding = False
        Me.XrTableCell135.StylePriority.UseTextAlignment = False
        Me.XrTableCell135.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell135.Weight = 0.20125572356506083R
        '
        'XrTableCell136
        '
        Me.XrTableCell136.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell136.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMay3_4Result", "{0:#,#}")})
        Me.XrTableCell136.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell136.Name = "XrTableCell136"
        Me.XrTableCell136.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell136.StylePriority.UseBorders = False
        Me.XrTableCell136.StylePriority.UseFont = False
        Me.XrTableCell136.StylePriority.UsePadding = False
        Me.XrTableCell136.StylePriority.UseTextAlignment = False
        Me.XrTableCell136.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell136.Weight = 0.21124993631738251R
        '
        'XrTableCell137
        '
        Me.XrTableCell137.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell137.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hDec1_2Result", "{0:#,#}")})
        Me.XrTableCell137.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell137.Name = "XrTableCell137"
        Me.XrTableCell137.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell137.StylePriority.UseBorders = False
        Me.XrTableCell137.StylePriority.UseFont = False
        Me.XrTableCell137.StylePriority.UsePadding = False
        Me.XrTableCell137.StylePriority.UseTextAlignment = False
        Me.XrTableCell137.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell137.Weight = 0.2012502303949017R
        '
        'XrTableCell138
        '
        Me.XrTableCell138.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell138.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hDec3_4Result", "{0:#,#}")})
        Me.XrTableCell138.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell138.Name = "XrTableCell138"
        Me.XrTableCell138.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell138.StylePriority.UseBorders = False
        Me.XrTableCell138.StylePriority.UseFont = False
        Me.XrTableCell138.StylePriority.UsePadding = False
        Me.XrTableCell138.StylePriority.UseTextAlignment = False
        Me.XrTableCell138.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell138.Weight = 0.21125085184574235R
        '
        'XrTableCell139
        '
        Me.XrTableCell139.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell139.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJan1_2Result", "{0:#,#}")})
        Me.XrTableCell139.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell139.Name = "XrTableCell139"
        Me.XrTableCell139.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell139.StylePriority.UseBorders = False
        Me.XrTableCell139.StylePriority.UseFont = False
        Me.XrTableCell139.StylePriority.UsePadding = False
        Me.XrTableCell139.StylePriority.UseTextAlignment = False
        Me.XrTableCell139.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell139.Weight = 0.20124962004266181R
        '
        'XrTableCell140
        '
        Me.XrTableCell140.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell140.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJan3_4Result", "{0:#,#}")})
        Me.XrTableCell140.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell140.Name = "XrTableCell140"
        Me.XrTableCell140.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell140.StylePriority.UseBorders = False
        Me.XrTableCell140.StylePriority.UseFont = False
        Me.XrTableCell140.StylePriority.UsePadding = False
        Me.XrTableCell140.StylePriority.UseTextAlignment = False
        Me.XrTableCell140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell140.Weight = 0.21125024149350244R
        '
        'XrTableCell141
        '
        Me.XrTableCell141.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell141.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hFeb1_2Result", "{0:#,#}")})
        Me.XrTableCell141.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell141.Name = "XrTableCell141"
        Me.XrTableCell141.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell141.StylePriority.UseBorders = False
        Me.XrTableCell141.StylePriority.UseFont = False
        Me.XrTableCell141.StylePriority.UsePadding = False
        Me.XrTableCell141.StylePriority.UseTextAlignment = False
        Me.XrTableCell141.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell141.Weight = 0.20124893339639188R
        '
        'XrTableCell142
        '
        Me.XrTableCell142.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell142.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hFeb3_4Result", "{0:#,#}")})
        Me.XrTableCell142.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell142.Name = "XrTableCell142"
        Me.XrTableCell142.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell142.StylePriority.UseBorders = False
        Me.XrTableCell142.StylePriority.UseFont = False
        Me.XrTableCell142.StylePriority.UsePadding = False
        Me.XrTableCell142.StylePriority.UseTextAlignment = False
        Me.XrTableCell142.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell142.Weight = 0.2112526829024621R
        '
        'XrTableCell143
        '
        Me.XrTableCell143.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell143.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMar1_2Result", "{0:#,#}")})
        Me.XrTableCell143.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell143.Name = "XrTableCell143"
        Me.XrTableCell143.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell143.StylePriority.UseBorders = False
        Me.XrTableCell143.StylePriority.UseFont = False
        Me.XrTableCell143.StylePriority.UsePadding = False
        Me.XrTableCell143.StylePriority.UseTextAlignment = False
        Me.XrTableCell143.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell143.Weight = 0.20124962004266181R
        '
        'XrTableCell144
        '
        Me.XrTableCell144.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell144.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMar3_4Result", "{0:#,#}")})
        Me.XrTableCell144.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell144.Name = "XrTableCell144"
        Me.XrTableCell144.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell144.StylePriority.UseBorders = False
        Me.XrTableCell144.StylePriority.UseFont = False
        Me.XrTableCell144.StylePriority.UsePadding = False
        Me.XrTableCell144.StylePriority.UseTextAlignment = False
        Me.XrTableCell144.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell144.Weight = 0.21124963114126255R
        '
        'XrTableCell145
        '
        Me.XrTableCell145.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell145.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hApr1_2Result", "{0:#,#}")})
        Me.XrTableCell145.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell145.Name = "XrTableCell145"
        Me.XrTableCell145.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell145.StylePriority.UseBorders = False
        Me.XrTableCell145.StylePriority.UseFont = False
        Me.XrTableCell145.StylePriority.UsePadding = False
        Me.XrTableCell145.StylePriority.UseTextAlignment = False
        Me.XrTableCell145.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell145.Weight = 0.20125023039490172R
        '
        'XrTableCell146
        '
        Me.XrTableCell146.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell146.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hApr3_4Result", "{0:#,#}")})
        Me.XrTableCell146.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell146.Name = "XrTableCell146"
        Me.XrTableCell146.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell146.StylePriority.UseBorders = False
        Me.XrTableCell146.StylePriority.UseFont = False
        Me.XrTableCell146.StylePriority.UsePadding = False
        Me.XrTableCell146.StylePriority.UseTextAlignment = False
        Me.XrTableCell146.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell146.Weight = 0.2112498600233525R
        '
        'XrTableCell147
        '
        Me.XrTableCell147.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell147.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMar1_2Result", "{0:#,#}")})
        Me.XrTableCell147.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell147.Name = "XrTableCell147"
        Me.XrTableCell147.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell147.StylePriority.UseBorders = False
        Me.XrTableCell147.StylePriority.UseFont = False
        Me.XrTableCell147.StylePriority.UsePadding = False
        Me.XrTableCell147.StylePriority.UseTextAlignment = False
        Me.XrTableCell147.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell147.Weight = 0.20125045978289405R
        '
        'XrTableCell148
        '
        Me.XrTableCell148.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell148.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hMar3_4Result", "{0:#,#}")})
        Me.XrTableCell148.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell148.Name = "XrTableCell148"
        Me.XrTableCell148.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell148.StylePriority.UseBorders = False
        Me.XrTableCell148.StylePriority.UseFont = False
        Me.XrTableCell148.StylePriority.UsePadding = False
        Me.XrTableCell148.StylePriority.UseTextAlignment = False
        Me.XrTableCell148.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell148.Weight = 0.21124896164781082R
        '
        'XrTableCell149
        '
        Me.XrTableCell149.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell149.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJun1_2Result", "{0:#,#}")})
        Me.XrTableCell149.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell149.Name = "XrTableCell149"
        Me.XrTableCell149.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell149.StylePriority.UseBorders = False
        Me.XrTableCell149.StylePriority.UseFont = False
        Me.XrTableCell149.StylePriority.UsePadding = False
        Me.XrTableCell149.StylePriority.UseTextAlignment = False
        Me.XrTableCell149.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell149.Weight = 0.20125078403244279R
        '
        'XrTableCell150
        '
        Me.XrTableCell150.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell150.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJun3_4Result", "{0:#,#}")})
        Me.XrTableCell150.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell150.Name = "XrTableCell150"
        Me.XrTableCell150.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell150.StylePriority.UseBorders = False
        Me.XrTableCell150.StylePriority.UseFont = False
        Me.XrTableCell150.StylePriority.UsePadding = False
        Me.XrTableCell150.StylePriority.UseTextAlignment = False
        Me.XrTableCell150.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell150.Weight = 0.2112495719999026R
        '
        'XrTableCell151
        '
        Me.XrTableCell151.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell151.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJul1_2Result", "{0:#,#}")})
        Me.XrTableCell151.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell151.Name = "XrTableCell151"
        Me.XrTableCell151.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell151.StylePriority.UseBorders = False
        Me.XrTableCell151.StylePriority.UseFont = False
        Me.XrTableCell151.StylePriority.UsePadding = False
        Me.XrTableCell151.StylePriority.UseTextAlignment = False
        Me.XrTableCell151.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell151.Weight = 0.20124977313679079R
        '
        'XrTableCell152
        '
        Me.XrTableCell152.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell152.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hJul3_4Result", "{0:#,#}")})
        Me.XrTableCell152.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell152.Name = "XrTableCell152"
        Me.XrTableCell152.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell152.StylePriority.UseBorders = False
        Me.XrTableCell152.StylePriority.UseFont = False
        Me.XrTableCell152.StylePriority.UsePadding = False
        Me.XrTableCell152.StylePriority.UseTextAlignment = False
        Me.XrTableCell152.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell152.Weight = 0.21125201340826968R
        '
        'XrTableCell153
        '
        Me.XrTableCell153.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell153.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hAug1_2Result", "{0:#,#}")})
        Me.XrTableCell153.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell153.Name = "XrTableCell153"
        Me.XrTableCell153.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell153.StylePriority.UseBorders = False
        Me.XrTableCell153.StylePriority.UseFont = False
        Me.XrTableCell153.StylePriority.UsePadding = False
        Me.XrTableCell153.StylePriority.UseTextAlignment = False
        Me.XrTableCell153.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell153.Weight = 0.20125017368035103R
        '
        'XrTableCell154
        '
        Me.XrTableCell154.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell154.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hAug3_4Result", "{0:#,#}")})
        Me.XrTableCell154.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell154.Name = "XrTableCell154"
        Me.XrTableCell154.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell154.StylePriority.UseBorders = False
        Me.XrTableCell154.StylePriority.UseFont = False
        Me.XrTableCell154.StylePriority.UsePadding = False
        Me.XrTableCell154.StylePriority.UseTextAlignment = False
        Me.XrTableCell154.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell154.Weight = 0.21124957199990257R
        '
        'XrTableCell155
        '
        Me.XrTableCell155.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell155.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hSep1_2Result", "{0:#,#}")})
        Me.XrTableCell155.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell155.Name = "XrTableCell155"
        Me.XrTableCell155.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell155.StylePriority.UseBorders = False
        Me.XrTableCell155.StylePriority.UseFont = False
        Me.XrTableCell155.StylePriority.UsePadding = False
        Me.XrTableCell155.StylePriority.UseTextAlignment = False
        Me.XrTableCell155.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell155.Weight = 0.20124956332825925R
        '
        'XrTableCell156
        '
        Me.XrTableCell156.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell156.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.hSep3_4Result", "{0:#,#}")})
        Me.XrTableCell156.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell156.Name = "XrTableCell156"
        Me.XrTableCell156.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell156.StylePriority.UseBorders = False
        Me.XrTableCell156.StylePriority.UseFont = False
        Me.XrTableCell156.StylePriority.UsePadding = False
        Me.XrTableCell156.StylePriority.UseTextAlignment = False
        Me.XrTableCell156.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell156.Weight = 0.21125079270408614R
        '
        'XrTableCell157
        '
        Me.XrTableCell157.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell157.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.SumHarvestResult")})
        Me.XrTableCell157.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell157.Name = "XrTableCell157"
        Me.XrTableCell157.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell157.StylePriority.UseBorders = False
        Me.XrTableCell157.StylePriority.UseFont = False
        Me.XrTableCell157.StylePriority.UsePadding = False
        Me.XrTableCell157.StylePriority.UseTextAlignment = False
        Me.XrTableCell157.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell157.Weight = 0.44513019473475451R
        '
        'XrTableCell158
        '
        Me.XrTableCell158.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell158.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell158.Name = "XrTableCell158"
        Me.XrTableCell158.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell158.StylePriority.UseBorders = False
        Me.XrTableCell158.StylePriority.UseFont = False
        Me.XrTableCell158.StylePriority.UsePadding = False
        Me.XrTableCell158.StylePriority.UseTextAlignment = False
        Me.XrTableCell158.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell158.Weight = 0.47513386836576754R
        '
        'XrTableCell159
        '
        Me.XrTableCell159.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell159.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell159.Name = "XrTableCell159"
        Me.XrTableCell159.StylePriority.UseBorders = False
        Me.XrTableCell159.StylePriority.UseFont = False
        Me.XrTableCell159.StylePriority.UseTextAlignment = False
        Me.XrTableCell159.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell159.Weight = 0.47513447871756442R
        '
        'XrTableCell160
        '
        Me.XrTableCell160.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell160.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell160.Name = "XrTableCell160"
        Me.XrTableCell160.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell160.StylePriority.UseBorders = False
        Me.XrTableCell160.StylePriority.UseFont = False
        Me.XrTableCell160.StylePriority.UsePadding = False
        Me.XrTableCell160.Weight = 0.81093706819722677R
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell161, Me.XrTableCell162, Me.XrTableCell163, Me.XrTableCell164, Me.XrTableCell165, Me.XrTableCell166, Me.XrTableCell167, Me.XrTableCell168, Me.XrTableCell169, Me.XrTableCell170, Me.XrTableCell171, Me.XrTableCell172, Me.XrTableCell173, Me.XrTableCell174, Me.XrTableCell175, Me.XrTableCell176, Me.XrTableCell177, Me.XrTableCell178, Me.XrTableCell179, Me.XrTableCell180, Me.XrTableCell181, Me.XrTableCell182, Me.XrTableCell183, Me.XrTableCell184, Me.XrTableCell185, Me.XrTableCell186, Me.XrTableCell187, Me.XrTableCell188, Me.XrTableCell189, Me.XrTableCell190, Me.XrTableCell191, Me.XrTableCell192, Me.XrTableCell193, Me.XrTableCell194, Me.XrTableCell195, Me.XrTableCell196, Me.XrTableCell197})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell162
        '
        Me.XrTableCell162.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell162.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell162.Name = "XrTableCell162"
        Me.XrTableCell162.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell162.StylePriority.UseBorders = False
        Me.XrTableCell162.StylePriority.UseFont = False
        Me.XrTableCell162.StylePriority.UsePadding = False
        Me.XrTableCell162.Weight = 0.417230147581233R
        '
        'XrTableCell163
        '
        Me.XrTableCell163.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell163.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell163.Name = "XrTableCell163"
        Me.XrTableCell163.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell163.StylePriority.UseBorders = False
        Me.XrTableCell163.StylePriority.UseFont = False
        Me.XrTableCell163.StylePriority.UsePadding = False
        Me.XrTableCell163.StylePriority.UseTextAlignment = False
        Me.XrTableCell163.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell163.Weight = 0.37744873908534571R
        '
        'XrTableCell164
        '
        Me.XrTableCell164.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell164.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell164.Name = "XrTableCell164"
        Me.XrTableCell164.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell164.StylePriority.UseBorders = False
        Me.XrTableCell164.StylePriority.UseFont = False
        Me.XrTableCell164.StylePriority.UsePadding = False
        Me.XrTableCell164.StylePriority.UseTextAlignment = False
        Me.XrTableCell164.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell164.Weight = 0.3574488830566408R
        '
        'XrTableCell165
        '
        Me.XrTableCell165.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell165.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell165.Name = "XrTableCell165"
        Me.XrTableCell165.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell165.StylePriority.UseBorders = False
        Me.XrTableCell165.StylePriority.UseFont = False
        Me.XrTableCell165.StylePriority.UsePadding = False
        Me.XrTableCell165.StylePriority.UseTextAlignment = False
        Me.XrTableCell165.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell165.Weight = 0.3574488830566408R
        '
        'XrTableCell166
        '
        Me.XrTableCell166.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell166.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell166.Name = "XrTableCell166"
        Me.XrTableCell166.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell166.StylePriority.UseBorders = False
        Me.XrTableCell166.StylePriority.UseFont = False
        Me.XrTableCell166.StylePriority.UsePadding = False
        Me.XrTableCell166.StylePriority.UseTextAlignment = False
        Me.XrTableCell166.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell166.Weight = 0.507448378934958R
        '
        'XrTableCell167
        '
        Me.XrTableCell167.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell167.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell167.Name = "XrTableCell167"
        Me.XrTableCell167.StylePriority.UseBorders = False
        Me.XrTableCell167.StylePriority.UseFont = False
        Me.XrTableCell167.StylePriority.UseTextAlignment = False
        Me.XrTableCell167.Text = "จัดซื้อ"
        Me.XrTableCell167.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell167.Weight = 0.3863572894746099R
        '
        'XrTableCell168
        '
        Me.XrTableCell168.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell168.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell168.Name = "XrTableCell168"
        Me.XrTableCell168.StylePriority.UseBorders = False
        Me.XrTableCell168.StylePriority.UseFont = False
        Me.XrTableCell168.StylePriority.UseTextAlignment = False
        Me.XrTableCell168.Text = "แผน"
        Me.XrTableCell168.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell168.Weight = 0.30701796314171786R
        '
        'XrTableCell169
        '
        Me.XrTableCell169.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell169.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell169.Name = "XrTableCell169"
        Me.XrTableCell169.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell169.StylePriority.UseBorders = False
        Me.XrTableCell169.StylePriority.UseFont = False
        Me.XrTableCell169.StylePriority.UsePadding = False
        Me.XrTableCell169.StylePriority.UseTextAlignment = False
        Me.XrTableCell169.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell169.Weight = 0.60513462148636987R
        '
        'XrTableCell170
        '
        Me.XrTableCell170.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell170.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bOct1_2Plan", "{0:#,#}")})
        Me.XrTableCell170.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell170.Name = "XrTableCell170"
        Me.XrTableCell170.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell170.StylePriority.UseBorders = False
        Me.XrTableCell170.StylePriority.UseFont = False
        Me.XrTableCell170.StylePriority.UsePadding = False
        Me.XrTableCell170.StylePriority.UseTextAlignment = False
        Me.XrTableCell170.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell170.Weight = 0.20124936257844561R
        '
        'XrTableCell171
        '
        Me.XrTableCell171.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell171.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bOct3_4Plan", "{0:#,#}")})
        Me.XrTableCell171.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell171.Name = "XrTableCell171"
        Me.XrTableCell171.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell171.StylePriority.UseBorders = False
        Me.XrTableCell171.StylePriority.UseFont = False
        Me.XrTableCell171.StylePriority.UsePadding = False
        Me.XrTableCell171.StylePriority.UseTextAlignment = False
        Me.XrTableCell171.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell171.Weight = 0.21124936411215758R
        '
        'XrTableCell172
        '
        Me.XrTableCell172.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell172.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bNov1_2Plan", "{0:#,#}")})
        Me.XrTableCell172.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell172.Name = "XrTableCell172"
        Me.XrTableCell172.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell172.StylePriority.UseBorders = False
        Me.XrTableCell172.StylePriority.UseFont = False
        Me.XrTableCell172.StylePriority.UsePadding = False
        Me.XrTableCell172.StylePriority.UseTextAlignment = False
        Me.XrTableCell172.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell172.Weight = 0.20125572356506083R
        '
        'XrTableCell173
        '
        Me.XrTableCell173.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell173.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bNov3_4Plan", "{0:#,#}")})
        Me.XrTableCell173.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell173.Name = "XrTableCell173"
        Me.XrTableCell173.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell173.StylePriority.UseBorders = False
        Me.XrTableCell173.StylePriority.UseFont = False
        Me.XrTableCell173.StylePriority.UsePadding = False
        Me.XrTableCell173.StylePriority.UseTextAlignment = False
        Me.XrTableCell173.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell173.Weight = 0.21124993631738251R
        '
        'XrTableCell174
        '
        Me.XrTableCell174.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell174.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bDec1_2Plan", "{0:#,#}")})
        Me.XrTableCell174.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell174.Name = "XrTableCell174"
        Me.XrTableCell174.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell174.StylePriority.UseBorders = False
        Me.XrTableCell174.StylePriority.UseFont = False
        Me.XrTableCell174.StylePriority.UsePadding = False
        Me.XrTableCell174.StylePriority.UseTextAlignment = False
        Me.XrTableCell174.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell174.Weight = 0.2012502303949017R
        '
        'XrTableCell175
        '
        Me.XrTableCell175.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell175.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bDec3_4Plan", "{0:#,#}")})
        Me.XrTableCell175.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell175.Name = "XrTableCell175"
        Me.XrTableCell175.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell175.StylePriority.UseBorders = False
        Me.XrTableCell175.StylePriority.UseFont = False
        Me.XrTableCell175.StylePriority.UsePadding = False
        Me.XrTableCell175.StylePriority.UseTextAlignment = False
        Me.XrTableCell175.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell175.Weight = 0.21125085184574235R
        '
        'XrTableCell176
        '
        Me.XrTableCell176.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell176.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJan1_2Plan", "{0:#,#}")})
        Me.XrTableCell176.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell176.Name = "XrTableCell176"
        Me.XrTableCell176.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell176.StylePriority.UseBorders = False
        Me.XrTableCell176.StylePriority.UseFont = False
        Me.XrTableCell176.StylePriority.UsePadding = False
        Me.XrTableCell176.StylePriority.UseTextAlignment = False
        Me.XrTableCell176.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell176.Weight = 0.20124962004266181R
        '
        'XrTableCell177
        '
        Me.XrTableCell177.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell177.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJan3_4Plan", "{0:#,#}")})
        Me.XrTableCell177.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell177.Name = "XrTableCell177"
        Me.XrTableCell177.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell177.StylePriority.UseBorders = False
        Me.XrTableCell177.StylePriority.UseFont = False
        Me.XrTableCell177.StylePriority.UsePadding = False
        Me.XrTableCell177.StylePriority.UseTextAlignment = False
        Me.XrTableCell177.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell177.Weight = 0.21125024149350244R
        '
        'XrTableCell178
        '
        Me.XrTableCell178.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell178.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bFeb1_2Plan", "{0:#,#}")})
        Me.XrTableCell178.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell178.Name = "XrTableCell178"
        Me.XrTableCell178.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell178.StylePriority.UseBorders = False
        Me.XrTableCell178.StylePriority.UseFont = False
        Me.XrTableCell178.StylePriority.UsePadding = False
        Me.XrTableCell178.StylePriority.UseTextAlignment = False
        Me.XrTableCell178.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell178.Weight = 0.20124893339639188R
        '
        'XrTableCell179
        '
        Me.XrTableCell179.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell179.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bFeb3_4Plan", "{0:#,#}")})
        Me.XrTableCell179.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell179.Name = "XrTableCell179"
        Me.XrTableCell179.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell179.StylePriority.UseBorders = False
        Me.XrTableCell179.StylePriority.UseFont = False
        Me.XrTableCell179.StylePriority.UsePadding = False
        Me.XrTableCell179.StylePriority.UseTextAlignment = False
        Me.XrTableCell179.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell179.Weight = 0.2112526829024621R
        '
        'XrTableCell180
        '
        Me.XrTableCell180.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell180.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bMar1_2Plan", "{0:#,#}")})
        Me.XrTableCell180.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell180.Name = "XrTableCell180"
        Me.XrTableCell180.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell180.StylePriority.UseBorders = False
        Me.XrTableCell180.StylePriority.UseFont = False
        Me.XrTableCell180.StylePriority.UsePadding = False
        Me.XrTableCell180.StylePriority.UseTextAlignment = False
        Me.XrTableCell180.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell180.Weight = 0.20124962004266181R
        '
        'XrTableCell181
        '
        Me.XrTableCell181.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell181.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bMar3_4Plan", "{0:#,#}")})
        Me.XrTableCell181.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell181.Name = "XrTableCell181"
        Me.XrTableCell181.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell181.StylePriority.UseBorders = False
        Me.XrTableCell181.StylePriority.UseFont = False
        Me.XrTableCell181.StylePriority.UsePadding = False
        Me.XrTableCell181.StylePriority.UseTextAlignment = False
        Me.XrTableCell181.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell181.Weight = 0.21124963114126255R
        '
        'XrTableCell182
        '
        Me.XrTableCell182.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell182.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bApr1_2Plan", "{0:#,#}")})
        Me.XrTableCell182.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell182.Name = "XrTableCell182"
        Me.XrTableCell182.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell182.StylePriority.UseBorders = False
        Me.XrTableCell182.StylePriority.UseFont = False
        Me.XrTableCell182.StylePriority.UsePadding = False
        Me.XrTableCell182.StylePriority.UseTextAlignment = False
        Me.XrTableCell182.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell182.Weight = 0.20125023039490172R
        '
        'XrTableCell183
        '
        Me.XrTableCell183.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell183.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bApr3_4Plan", "{0:#,#}")})
        Me.XrTableCell183.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell183.Name = "XrTableCell183"
        Me.XrTableCell183.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell183.StylePriority.UseBorders = False
        Me.XrTableCell183.StylePriority.UseFont = False
        Me.XrTableCell183.StylePriority.UsePadding = False
        Me.XrTableCell183.StylePriority.UseTextAlignment = False
        Me.XrTableCell183.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell183.Weight = 0.2112498600233525R
        '
        'XrTableCell184
        '
        Me.XrTableCell184.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell184.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bMay1_2Plan", "{0:#,#}")})
        Me.XrTableCell184.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell184.Name = "XrTableCell184"
        Me.XrTableCell184.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell184.StylePriority.UseBorders = False
        Me.XrTableCell184.StylePriority.UseFont = False
        Me.XrTableCell184.StylePriority.UsePadding = False
        Me.XrTableCell184.StylePriority.UseTextAlignment = False
        Me.XrTableCell184.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell184.Weight = 0.20125045978289405R
        '
        'XrTableCell185
        '
        Me.XrTableCell185.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell185.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bMay3_4Plan", "{0:#,#}")})
        Me.XrTableCell185.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell185.Name = "XrTableCell185"
        Me.XrTableCell185.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell185.StylePriority.UseBorders = False
        Me.XrTableCell185.StylePriority.UseFont = False
        Me.XrTableCell185.StylePriority.UsePadding = False
        Me.XrTableCell185.StylePriority.UseTextAlignment = False
        Me.XrTableCell185.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell185.Weight = 0.21124896164781082R
        '
        'XrTableCell186
        '
        Me.XrTableCell186.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell186.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJun1_2Plan", "{0:#,#}")})
        Me.XrTableCell186.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell186.Name = "XrTableCell186"
        Me.XrTableCell186.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell186.StylePriority.UseBorders = False
        Me.XrTableCell186.StylePriority.UseFont = False
        Me.XrTableCell186.StylePriority.UsePadding = False
        Me.XrTableCell186.StylePriority.UseTextAlignment = False
        Me.XrTableCell186.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell186.Weight = 0.20125078403244279R
        '
        'XrTableCell187
        '
        Me.XrTableCell187.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell187.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJun3_4Plan", "{0:#,#}")})
        Me.XrTableCell187.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell187.Name = "XrTableCell187"
        Me.XrTableCell187.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell187.StylePriority.UseBorders = False
        Me.XrTableCell187.StylePriority.UseFont = False
        Me.XrTableCell187.StylePriority.UsePadding = False
        Me.XrTableCell187.StylePriority.UseTextAlignment = False
        Me.XrTableCell187.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell187.Weight = 0.2112495719999026R
        '
        'XrTableCell188
        '
        Me.XrTableCell188.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell188.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJul1_2Plan", "{0:#,#}")})
        Me.XrTableCell188.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell188.Name = "XrTableCell188"
        Me.XrTableCell188.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell188.StylePriority.UseBorders = False
        Me.XrTableCell188.StylePriority.UseFont = False
        Me.XrTableCell188.StylePriority.UsePadding = False
        Me.XrTableCell188.StylePriority.UseTextAlignment = False
        Me.XrTableCell188.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell188.Weight = 0.20124977313679079R
        '
        'XrTableCell189
        '
        Me.XrTableCell189.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell189.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJul3_4Plan", "{0:#,#}")})
        Me.XrTableCell189.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell189.Name = "XrTableCell189"
        Me.XrTableCell189.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell189.StylePriority.UseBorders = False
        Me.XrTableCell189.StylePriority.UseFont = False
        Me.XrTableCell189.StylePriority.UsePadding = False
        Me.XrTableCell189.StylePriority.UseTextAlignment = False
        Me.XrTableCell189.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell189.Weight = 0.21125201340826968R
        '
        'XrTableCell190
        '
        Me.XrTableCell190.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell190.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bAug1_2Plan", "{0:#,#}")})
        Me.XrTableCell190.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell190.Name = "XrTableCell190"
        Me.XrTableCell190.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell190.StylePriority.UseBorders = False
        Me.XrTableCell190.StylePriority.UseFont = False
        Me.XrTableCell190.StylePriority.UsePadding = False
        Me.XrTableCell190.StylePriority.UseTextAlignment = False
        Me.XrTableCell190.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell190.Weight = 0.20125017368035103R
        '
        'XrTableCell191
        '
        Me.XrTableCell191.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell191.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bAug3_4Plan", "{0:#,#}")})
        Me.XrTableCell191.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell191.Name = "XrTableCell191"
        Me.XrTableCell191.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell191.StylePriority.UseBorders = False
        Me.XrTableCell191.StylePriority.UseFont = False
        Me.XrTableCell191.StylePriority.UsePadding = False
        Me.XrTableCell191.StylePriority.UseTextAlignment = False
        Me.XrTableCell191.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell191.Weight = 0.21124957199990257R
        '
        'XrTableCell192
        '
        Me.XrTableCell192.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell192.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bSep1_2Plan", "{0:#,#}")})
        Me.XrTableCell192.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell192.Name = "XrTableCell192"
        Me.XrTableCell192.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell192.StylePriority.UseBorders = False
        Me.XrTableCell192.StylePriority.UseFont = False
        Me.XrTableCell192.StylePriority.UsePadding = False
        Me.XrTableCell192.StylePriority.UseTextAlignment = False
        Me.XrTableCell192.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell192.Weight = 0.20124956332825925R
        '
        'XrTableCell193
        '
        Me.XrTableCell193.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell193.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bSep3_4Plan", "{0:#,#}")})
        Me.XrTableCell193.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell193.Name = "XrTableCell193"
        Me.XrTableCell193.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell193.StylePriority.UseBorders = False
        Me.XrTableCell193.StylePriority.UseFont = False
        Me.XrTableCell193.StylePriority.UsePadding = False
        Me.XrTableCell193.StylePriority.UseTextAlignment = False
        Me.XrTableCell193.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell193.Weight = 0.21125079270408614R
        '
        'XrTableCell194
        '
        Me.XrTableCell194.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell194.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.SumBuyPlan")})
        Me.XrTableCell194.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell194.Name = "XrTableCell194"
        Me.XrTableCell194.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell194.StylePriority.UseBorders = False
        Me.XrTableCell194.StylePriority.UseFont = False
        Me.XrTableCell194.StylePriority.UsePadding = False
        Me.XrTableCell194.StylePriority.UseTextAlignment = False
        Me.XrTableCell194.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell194.Weight = 0.44513019473475451R
        '
        'XrTableCell195
        '
        Me.XrTableCell195.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell195.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bStartDate", "{0:d MMM yy}")})
        Me.XrTableCell195.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell195.Name = "XrTableCell195"
        Me.XrTableCell195.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableCell195.StylePriority.UseBorders = False
        Me.XrTableCell195.StylePriority.UseFont = False
        Me.XrTableCell195.StylePriority.UsePadding = False
        Me.XrTableCell195.StylePriority.UseTextAlignment = False
        Me.XrTableCell195.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell195.Weight = 0.47513386836576754R
        '
        'XrTableCell196
        '
        Me.XrTableCell196.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell196.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bEndDate", "{0:d MMM yy}")})
        Me.XrTableCell196.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell196.Name = "XrTableCell196"
        Me.XrTableCell196.StylePriority.UseBorders = False
        Me.XrTableCell196.StylePriority.UseFont = False
        Me.XrTableCell196.StylePriority.UseTextAlignment = False
        Me.XrTableCell196.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell196.Weight = 0.47513447871756442R
        '
        'XrTableCell197
        '
        Me.XrTableCell197.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell197.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell197.Name = "XrTableCell197"
        Me.XrTableCell197.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell197.StylePriority.UseBorders = False
        Me.XrTableCell197.StylePriority.UseFont = False
        Me.XrTableCell197.StylePriority.UsePadding = False
        Me.XrTableCell197.Weight = 0.81093706819722677R
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell198, Me.XrTableCell199, Me.XrTableCell200, Me.XrTableCell201, Me.XrTableCell202, Me.XrTableCell203, Me.XrTableCell204, Me.XrTableCell205, Me.XrTableCell206, Me.XrTableCell207, Me.XrTableCell208, Me.XrTableCell209, Me.XrTableCell210, Me.XrTableCell211, Me.XrTableCell212, Me.XrTableCell213, Me.XrTableCell214, Me.XrTableCell215, Me.XrTableCell216, Me.XrTableCell217, Me.XrTableCell218, Me.XrTableCell219, Me.XrTableCell220, Me.XrTableCell221, Me.XrTableCell222, Me.XrTableCell223, Me.XrTableCell224, Me.XrTableCell225, Me.XrTableCell226, Me.XrTableCell227, Me.XrTableCell228, Me.XrTableCell229, Me.XrTableCell230, Me.XrTableCell231, Me.XrTableCell232, Me.XrTableCell233, Me.XrTableCell234})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0R
        '
        'XrTableCell199
        '
        Me.XrTableCell199.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell199.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell199.Name = "XrTableCell199"
        Me.XrTableCell199.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell199.StylePriority.UseBorders = False
        Me.XrTableCell199.StylePriority.UseFont = False
        Me.XrTableCell199.StylePriority.UsePadding = False
        Me.XrTableCell199.Weight = 0.417230147581233R
        '
        'XrTableCell200
        '
        Me.XrTableCell200.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell200.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell200.Name = "XrTableCell200"
        Me.XrTableCell200.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell200.StylePriority.UseBorders = False
        Me.XrTableCell200.StylePriority.UseFont = False
        Me.XrTableCell200.StylePriority.UsePadding = False
        Me.XrTableCell200.StylePriority.UseTextAlignment = False
        Me.XrTableCell200.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell200.Weight = 0.37744873908534571R
        '
        'XrTableCell201
        '
        Me.XrTableCell201.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell201.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell201.Name = "XrTableCell201"
        Me.XrTableCell201.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell201.StylePriority.UseBorders = False
        Me.XrTableCell201.StylePriority.UseFont = False
        Me.XrTableCell201.StylePriority.UsePadding = False
        Me.XrTableCell201.StylePriority.UseTextAlignment = False
        Me.XrTableCell201.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell201.Weight = 0.3574488830566408R
        '
        'XrTableCell202
        '
        Me.XrTableCell202.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell202.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell202.Name = "XrTableCell202"
        Me.XrTableCell202.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell202.StylePriority.UseBorders = False
        Me.XrTableCell202.StylePriority.UseFont = False
        Me.XrTableCell202.StylePriority.UsePadding = False
        Me.XrTableCell202.StylePriority.UseTextAlignment = False
        Me.XrTableCell202.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell202.Weight = 0.3574488830566408R
        '
        'XrTableCell203
        '
        Me.XrTableCell203.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell203.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell203.Name = "XrTableCell203"
        Me.XrTableCell203.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell203.StylePriority.UseBorders = False
        Me.XrTableCell203.StylePriority.UseFont = False
        Me.XrTableCell203.StylePriority.UsePadding = False
        Me.XrTableCell203.StylePriority.UseTextAlignment = False
        Me.XrTableCell203.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell203.Weight = 0.507448378934958R
        '
        'XrTableCell204
        '
        Me.XrTableCell204.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell204.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell204.Name = "XrTableCell204"
        Me.XrTableCell204.StylePriority.UseBorders = False
        Me.XrTableCell204.StylePriority.UseFont = False
        Me.XrTableCell204.StylePriority.UseTextAlignment = False
        Me.XrTableCell204.Text = "(ตัน)"
        Me.XrTableCell204.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell204.Weight = 0.3863572894746099R
        '
        'XrTableCell205
        '
        Me.XrTableCell205.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell205.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell205.Name = "XrTableCell205"
        Me.XrTableCell205.StylePriority.UseBorders = False
        Me.XrTableCell205.StylePriority.UseFont = False
        Me.XrTableCell205.StylePriority.UseTextAlignment = False
        Me.XrTableCell205.Text = "ผล"
        Me.XrTableCell205.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell205.Weight = 0.30701796314171786R
        '
        'XrTableCell206
        '
        Me.XrTableCell206.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell206.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell206.Name = "XrTableCell206"
        Me.XrTableCell206.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell206.StylePriority.UseBorders = False
        Me.XrTableCell206.StylePriority.UseFont = False
        Me.XrTableCell206.StylePriority.UsePadding = False
        Me.XrTableCell206.StylePriority.UseTextAlignment = False
        Me.XrTableCell206.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell206.Weight = 0.60513462148636987R
        '
        'XrTableCell207
        '
        Me.XrTableCell207.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell207.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bOct1_2Result", "{0:#,#}")})
        Me.XrTableCell207.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell207.Name = "XrTableCell207"
        Me.XrTableCell207.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell207.StylePriority.UseBorders = False
        Me.XrTableCell207.StylePriority.UseFont = False
        Me.XrTableCell207.StylePriority.UsePadding = False
        Me.XrTableCell207.StylePriority.UseTextAlignment = False
        Me.XrTableCell207.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell207.Weight = 0.20124936257844561R
        '
        'XrTableCell208
        '
        Me.XrTableCell208.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell208.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bOct3_4Result", "{0:#,#}")})
        Me.XrTableCell208.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell208.Name = "XrTableCell208"
        Me.XrTableCell208.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell208.StylePriority.UseBorders = False
        Me.XrTableCell208.StylePriority.UseFont = False
        Me.XrTableCell208.StylePriority.UsePadding = False
        Me.XrTableCell208.StylePriority.UseTextAlignment = False
        Me.XrTableCell208.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell208.Weight = 0.21124936411215758R
        '
        'XrTableCell209
        '
        Me.XrTableCell209.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell209.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bNov1_2Result", "{0:#,#}")})
        Me.XrTableCell209.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell209.Name = "XrTableCell209"
        Me.XrTableCell209.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell209.StylePriority.UseBorders = False
        Me.XrTableCell209.StylePriority.UseFont = False
        Me.XrTableCell209.StylePriority.UsePadding = False
        Me.XrTableCell209.StylePriority.UseTextAlignment = False
        Me.XrTableCell209.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell209.Weight = 0.20125572356506083R
        '
        'XrTableCell210
        '
        Me.XrTableCell210.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell210.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bNov3_4Result", "{0:#,#}")})
        Me.XrTableCell210.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell210.Name = "XrTableCell210"
        Me.XrTableCell210.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell210.StylePriority.UseBorders = False
        Me.XrTableCell210.StylePriority.UseFont = False
        Me.XrTableCell210.StylePriority.UsePadding = False
        Me.XrTableCell210.StylePriority.UseTextAlignment = False
        Me.XrTableCell210.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell210.Weight = 0.21124993631738251R
        '
        'XrTableCell211
        '
        Me.XrTableCell211.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell211.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bDec1_2Result", "{0:#,#}")})
        Me.XrTableCell211.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell211.Name = "XrTableCell211"
        Me.XrTableCell211.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell211.StylePriority.UseBorders = False
        Me.XrTableCell211.StylePriority.UseFont = False
        Me.XrTableCell211.StylePriority.UsePadding = False
        Me.XrTableCell211.StylePriority.UseTextAlignment = False
        Me.XrTableCell211.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell211.Weight = 0.2012502303949017R
        '
        'XrTableCell212
        '
        Me.XrTableCell212.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell212.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bDec3_4Result", "{0:#,#}")})
        Me.XrTableCell212.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell212.Name = "XrTableCell212"
        Me.XrTableCell212.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell212.StylePriority.UseBorders = False
        Me.XrTableCell212.StylePriority.UseFont = False
        Me.XrTableCell212.StylePriority.UsePadding = False
        Me.XrTableCell212.StylePriority.UseTextAlignment = False
        Me.XrTableCell212.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell212.Weight = 0.21125085184574235R
        '
        'XrTableCell213
        '
        Me.XrTableCell213.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell213.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJan1_2Result", "{0:#,#}")})
        Me.XrTableCell213.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell213.Name = "XrTableCell213"
        Me.XrTableCell213.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell213.StylePriority.UseBorders = False
        Me.XrTableCell213.StylePriority.UseFont = False
        Me.XrTableCell213.StylePriority.UsePadding = False
        Me.XrTableCell213.StylePriority.UseTextAlignment = False
        Me.XrTableCell213.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell213.Weight = 0.20124962004266181R
        '
        'XrTableCell214
        '
        Me.XrTableCell214.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell214.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJan3_4Result", "{0:#,#}")})
        Me.XrTableCell214.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell214.Name = "XrTableCell214"
        Me.XrTableCell214.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell214.StylePriority.UseBorders = False
        Me.XrTableCell214.StylePriority.UseFont = False
        Me.XrTableCell214.StylePriority.UsePadding = False
        Me.XrTableCell214.StylePriority.UseTextAlignment = False
        Me.XrTableCell214.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell214.Weight = 0.21125024149350244R
        '
        'XrTableCell215
        '
        Me.XrTableCell215.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell215.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bFeb1_2Result", "{0:#,#}")})
        Me.XrTableCell215.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell215.Name = "XrTableCell215"
        Me.XrTableCell215.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell215.StylePriority.UseBorders = False
        Me.XrTableCell215.StylePriority.UseFont = False
        Me.XrTableCell215.StylePriority.UsePadding = False
        Me.XrTableCell215.StylePriority.UseTextAlignment = False
        Me.XrTableCell215.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell215.Weight = 0.20124893339639188R
        '
        'XrTableCell216
        '
        Me.XrTableCell216.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell216.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bFeb3_4Result", "{0:#,#}")})
        Me.XrTableCell216.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell216.Name = "XrTableCell216"
        Me.XrTableCell216.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell216.StylePriority.UseBorders = False
        Me.XrTableCell216.StylePriority.UseFont = False
        Me.XrTableCell216.StylePriority.UsePadding = False
        Me.XrTableCell216.StylePriority.UseTextAlignment = False
        Me.XrTableCell216.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell216.Weight = 0.2112526829024621R
        '
        'XrTableCell217
        '
        Me.XrTableCell217.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell217.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bMar1_2Result", "{0:#,#}")})
        Me.XrTableCell217.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell217.Name = "XrTableCell217"
        Me.XrTableCell217.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell217.StylePriority.UseBorders = False
        Me.XrTableCell217.StylePriority.UseFont = False
        Me.XrTableCell217.StylePriority.UsePadding = False
        Me.XrTableCell217.StylePriority.UseTextAlignment = False
        Me.XrTableCell217.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell217.Weight = 0.20124962004266181R
        '
        'XrTableCell218
        '
        Me.XrTableCell218.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell218.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bMar3_4Result", "{0:#,#}")})
        Me.XrTableCell218.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell218.Name = "XrTableCell218"
        Me.XrTableCell218.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell218.StylePriority.UseBorders = False
        Me.XrTableCell218.StylePriority.UseFont = False
        Me.XrTableCell218.StylePriority.UsePadding = False
        Me.XrTableCell218.StylePriority.UseTextAlignment = False
        Me.XrTableCell218.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell218.Weight = 0.21124963114126255R
        '
        'XrTableCell219
        '
        Me.XrTableCell219.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell219.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bApr1_2Result", "{0:#,#}")})
        Me.XrTableCell219.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell219.Name = "XrTableCell219"
        Me.XrTableCell219.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell219.StylePriority.UseBorders = False
        Me.XrTableCell219.StylePriority.UseFont = False
        Me.XrTableCell219.StylePriority.UsePadding = False
        Me.XrTableCell219.StylePriority.UseTextAlignment = False
        Me.XrTableCell219.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell219.Weight = 0.20125023039490172R
        '
        'XrTableCell220
        '
        Me.XrTableCell220.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell220.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bApr3_4Result", "{0:#,#}")})
        Me.XrTableCell220.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell220.Name = "XrTableCell220"
        Me.XrTableCell220.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell220.StylePriority.UseBorders = False
        Me.XrTableCell220.StylePriority.UseFont = False
        Me.XrTableCell220.StylePriority.UsePadding = False
        Me.XrTableCell220.StylePriority.UseTextAlignment = False
        Me.XrTableCell220.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell220.Weight = 0.2112498600233525R
        '
        'XrTableCell221
        '
        Me.XrTableCell221.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell221.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bMay1_2Result", "{0:#,#}")})
        Me.XrTableCell221.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell221.Name = "XrTableCell221"
        Me.XrTableCell221.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell221.StylePriority.UseBorders = False
        Me.XrTableCell221.StylePriority.UseFont = False
        Me.XrTableCell221.StylePriority.UsePadding = False
        Me.XrTableCell221.StylePriority.UseTextAlignment = False
        Me.XrTableCell221.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell221.Weight = 0.20125045978289405R
        '
        'XrTableCell222
        '
        Me.XrTableCell222.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell222.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bMay3_4Result", "{0:#,#}")})
        Me.XrTableCell222.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell222.Name = "XrTableCell222"
        Me.XrTableCell222.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell222.StylePriority.UseBorders = False
        Me.XrTableCell222.StylePriority.UseFont = False
        Me.XrTableCell222.StylePriority.UsePadding = False
        Me.XrTableCell222.StylePriority.UseTextAlignment = False
        Me.XrTableCell222.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell222.Weight = 0.21124896164781082R
        '
        'XrTableCell223
        '
        Me.XrTableCell223.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell223.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJun1_2Result", "{0:#,#}")})
        Me.XrTableCell223.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell223.Name = "XrTableCell223"
        Me.XrTableCell223.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell223.StylePriority.UseBorders = False
        Me.XrTableCell223.StylePriority.UseFont = False
        Me.XrTableCell223.StylePriority.UsePadding = False
        Me.XrTableCell223.StylePriority.UseTextAlignment = False
        Me.XrTableCell223.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell223.Weight = 0.20125078403244279R
        '
        'XrTableCell224
        '
        Me.XrTableCell224.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell224.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJun3_4Result", "{0:#,#}")})
        Me.XrTableCell224.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell224.Name = "XrTableCell224"
        Me.XrTableCell224.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell224.StylePriority.UseBorders = False
        Me.XrTableCell224.StylePriority.UseFont = False
        Me.XrTableCell224.StylePriority.UsePadding = False
        Me.XrTableCell224.StylePriority.UseTextAlignment = False
        Me.XrTableCell224.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell224.Weight = 0.2112495719999026R
        '
        'XrTableCell225
        '
        Me.XrTableCell225.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell225.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJul1_2Result", "{0:#,#}")})
        Me.XrTableCell225.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell225.Name = "XrTableCell225"
        Me.XrTableCell225.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell225.StylePriority.UseBorders = False
        Me.XrTableCell225.StylePriority.UseFont = False
        Me.XrTableCell225.StylePriority.UsePadding = False
        Me.XrTableCell225.StylePriority.UseTextAlignment = False
        Me.XrTableCell225.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell225.Weight = 0.20124977313679079R
        '
        'XrTableCell226
        '
        Me.XrTableCell226.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell226.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bJul3_4Result", "{0:#,#}")})
        Me.XrTableCell226.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell226.Name = "XrTableCell226"
        Me.XrTableCell226.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell226.StylePriority.UseBorders = False
        Me.XrTableCell226.StylePriority.UseFont = False
        Me.XrTableCell226.StylePriority.UsePadding = False
        Me.XrTableCell226.StylePriority.UseTextAlignment = False
        Me.XrTableCell226.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell226.Weight = 0.21125201340826968R
        '
        'XrTableCell227
        '
        Me.XrTableCell227.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell227.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bAug1_2Result", "{0:#,#}")})
        Me.XrTableCell227.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell227.Name = "XrTableCell227"
        Me.XrTableCell227.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell227.StylePriority.UseBorders = False
        Me.XrTableCell227.StylePriority.UseFont = False
        Me.XrTableCell227.StylePriority.UsePadding = False
        Me.XrTableCell227.StylePriority.UseTextAlignment = False
        Me.XrTableCell227.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell227.Weight = 0.20125017368035103R
        '
        'XrTableCell228
        '
        Me.XrTableCell228.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell228.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bAug3_4Result", "{0:#,#}")})
        Me.XrTableCell228.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell228.Name = "XrTableCell228"
        Me.XrTableCell228.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell228.StylePriority.UseBorders = False
        Me.XrTableCell228.StylePriority.UseFont = False
        Me.XrTableCell228.StylePriority.UsePadding = False
        Me.XrTableCell228.StylePriority.UseTextAlignment = False
        Me.XrTableCell228.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell228.Weight = 0.21124957199990257R
        '
        'XrTableCell229
        '
        Me.XrTableCell229.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell229.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bSep1_2Result", "{0:#,#}")})
        Me.XrTableCell229.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell229.Name = "XrTableCell229"
        Me.XrTableCell229.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell229.StylePriority.UseBorders = False
        Me.XrTableCell229.StylePriority.UseFont = False
        Me.XrTableCell229.StylePriority.UsePadding = False
        Me.XrTableCell229.StylePriority.UseTextAlignment = False
        Me.XrTableCell229.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell229.Weight = 0.20124956332825925R
        '
        'XrTableCell230
        '
        Me.XrTableCell230.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell230.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.bSep3_4Result", "{0:#,#}")})
        Me.XrTableCell230.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell230.Name = "XrTableCell230"
        Me.XrTableCell230.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100.0!)
        Me.XrTableCell230.StylePriority.UseBorders = False
        Me.XrTableCell230.StylePriority.UseFont = False
        Me.XrTableCell230.StylePriority.UsePadding = False
        Me.XrTableCell230.StylePriority.UseTextAlignment = False
        Me.XrTableCell230.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell230.Weight = 0.21125079270408614R
        '
        'XrTableCell231
        '
        Me.XrTableCell231.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell231.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SP_GetReportActivity.SumBuyResult")})
        Me.XrTableCell231.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell231.Name = "XrTableCell231"
        Me.XrTableCell231.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell231.StylePriority.UseBorders = False
        Me.XrTableCell231.StylePriority.UseFont = False
        Me.XrTableCell231.StylePriority.UsePadding = False
        Me.XrTableCell231.StylePriority.UseTextAlignment = False
        Me.XrTableCell231.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell231.Weight = 0.44513019473475451R
        '
        'XrTableCell232
        '
        Me.XrTableCell232.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell232.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell232.Name = "XrTableCell232"
        Me.XrTableCell232.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100.0!)
        Me.XrTableCell232.StylePriority.UseBorders = False
        Me.XrTableCell232.StylePriority.UseFont = False
        Me.XrTableCell232.StylePriority.UsePadding = False
        Me.XrTableCell232.StylePriority.UseTextAlignment = False
        Me.XrTableCell232.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell232.Weight = 0.47513386836576754R
        '
        'XrTableCell233
        '
        Me.XrTableCell233.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell233.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell233.Name = "XrTableCell233"
        Me.XrTableCell233.StylePriority.UseBorders = False
        Me.XrTableCell233.StylePriority.UseFont = False
        Me.XrTableCell233.StylePriority.UseTextAlignment = False
        Me.XrTableCell233.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell233.Weight = 0.47513447871756442R
        '
        'XrTableCell234
        '
        Me.XrTableCell234.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell234.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell234.Name = "XrTableCell234"
        Me.XrTableCell234.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell234.StylePriority.UseBorders = False
        Me.XrTableCell234.StylePriority.UseFont = False
        Me.XrTableCell234.StylePriority.UsePadding = False
        Me.XrTableCell234.Weight = 0.81093706819722677R
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel55, Me.XrLabel54, Me.XrLabel53, Me.XrLabel52, Me.XrLabel51, Me.XrLabel50, Me.XrLabel49, Me.XrLabel48, Me.XrLabel42, Me.XrLabel43, Me.XrLabel39, Me.XrLabel40, Me.XrLabel36, Me.XrLabel37, Me.XrLabel33, Me.XrLabel34, Me.XrLabel30, Me.XrLabel31, Me.XrLabel27, Me.XrLabel28, Me.XrLabel24, Me.XrLabel25, Me.XrLabel22, Me.XrLabel21, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel3, Me.XrLabel14, Me.XrLabel9, Me.XrLabel8, Me.XrLabel67, Me.XrLabel7, Me.XrLabel10, Me.XrLabel11, Me.XrLabel12, Me.XrLabel13, Me.XrLabel56, Me.XrLabel66, Me.XrLabel65, Me.XrLabel64, Me.XrLabel63, Me.XrLabel62, Me.XrLabel61, Me.XrLabel60, Me.XrLabel59, Me.XrLabel58, Me.XrLabel57, Me.XrLabel6, Me.XrLabel15, Me.XrPageInfo1, Me.XrLabel4, Me.XrLabel2, Me.XrLabel1})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("SiteNo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 173.6441!
        Me.GroupHeader2.KeepTogether = True
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.RepeatEveryPage = True
        '
        'XrLabel55
        '
        Me.XrLabel55.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel55.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(875.2407!, 147.4998!)
        Me.XrLabel55.Multiline = True
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(21.125!, 22.5!)
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "3-4"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel54
        '
        Me.XrLabel54.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel54.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(833.9907!, 147.4998!)
        Me.XrLabel54.Multiline = True
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(21.12494!, 22.5!)
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "3-4"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel53
        '
        Me.XrLabel53.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel53.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(792.7408!, 147.4996!)
        Me.XrLabel53.Multiline = True
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(21.12494!, 22.5!)
        Me.XrLabel53.StylePriority.UseBorders = False
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.Text = "3-4"
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel52
        '
        Me.XrLabel52.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel52.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(751.4907!, 147.4998!)
        Me.XrLabel52.Multiline = True
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(21.125!, 22.5!)
        Me.XrLabel52.StylePriority.UseBorders = False
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.Text = "3-4"
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel51
        '
        Me.XrLabel51.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel51.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(855.1157!, 147.4997!)
        Me.XrLabel51.Multiline = True
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(20.12518!, 22.5!)
        Me.XrLabel51.StylePriority.UseBorders = False
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.StylePriority.UseTextAlignment = False
        Me.XrLabel51.Text = "1-2"
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel50
        '
        Me.XrLabel50.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel50.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(813.8658!, 147.4996!)
        Me.XrLabel50.Multiline = True
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(20.125!, 22.5!)
        Me.XrLabel50.StylePriority.UseBorders = False
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.Text = "1-2"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel49
        '
        Me.XrLabel49.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel49.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(772.6158!, 147.4997!)
        Me.XrLabel49.Multiline = True
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(20.125!, 22.5!)
        Me.XrLabel49.StylePriority.UseBorders = False
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "1-2"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel48
        '
        Me.XrLabel48.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel48.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(731.3657!, 147.4997!)
        Me.XrLabel48.Multiline = True
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(20.125!, 22.5!)
        Me.XrLabel48.StylePriority.UseBorders = False
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        Me.XrLabel48.Text = "1-2"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel42
        '
        Me.XrLabel42.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel42.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(690.1157!, 147.4996!)
        Me.XrLabel42.Multiline = True
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(20.125!, 22.5!)
        Me.XrLabel42.StylePriority.UseBorders = False
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "1-2"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel43
        '
        Me.XrLabel43.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel43.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(710.2408!, 147.4998!)
        Me.XrLabel43.Multiline = True
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(21.12494!, 22.5!)
        Me.XrLabel43.StylePriority.UseBorders = False
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "3-4"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel39
        '
        Me.XrLabel39.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel39.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(648.8658!, 147.4997!)
        Me.XrLabel39.Multiline = True
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(20.125!, 22.5!)
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "1-2"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel40
        '
        Me.XrLabel40.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel40.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(668.9908!, 147.4998!)
        Me.XrLabel40.Multiline = True
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(21.12488!, 22.5!)
        Me.XrLabel40.StylePriority.UseBorders = False
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "3-4"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel36
        '
        Me.XrLabel36.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel36.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(607.6157!, 147.4996!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(20.125!, 22.5!)
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "1-2"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel37
        '
        Me.XrLabel37.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel37.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(627.7407!, 147.4998!)
        Me.XrLabel37.Multiline = True
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(21.125!, 22.5!)
        Me.XrLabel37.StylePriority.UseBorders = False
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "3-4"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel33
        '
        Me.XrLabel33.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel33.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(566.3658!, 147.4998!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(20.125!, 22.5!)
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "1-2"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel34.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(586.4907!, 147.4998!)
        Me.XrLabel34.Multiline = True
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(21.12494!, 22.5!)
        Me.XrLabel34.StylePriority.UseBorders = False
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = "3-4"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel30.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(525.1158!, 147.4996!)
        Me.XrLabel30.Multiline = True
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(20.125!, 22.5!)
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "1-2"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel31
        '
        Me.XrLabel31.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel31.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(545.2408!, 147.4998!)
        Me.XrLabel31.Multiline = True
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(21.12494!, 22.5!)
        Me.XrLabel31.StylePriority.UseBorders = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "3-4"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel27
        '
        Me.XrLabel27.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel27.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(483.8657!, 147.4997!)
        Me.XrLabel27.Multiline = True
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(20.125!, 22.5!)
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "1-2"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel28
        '
        Me.XrLabel28.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel28.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(503.9909!, 147.4998!)
        Me.XrLabel28.Multiline = True
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(21.12494!, 22.5!)
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "3-4"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel24.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(442.6158!, 147.4997!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(20.125!, 22.5!)
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "1-2"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel25
        '
        Me.XrLabel25.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel25.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(462.7409!, 147.4996!)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(21.125!, 22.5!)
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "3-4"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(421.4907!, 147.4996!)
        Me.XrLabel22.Multiline = True
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(21.125!, 22.5!)
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "3-4"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel21.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(401.3658!, 147.4996!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(20.125!, 22.5!)
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "1-2"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel19.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(1035.906!, 103.9764!)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(81.09399!, 69.66769!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "หมายเหตุ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ระบุเมื่อกิจกรรมเสร็จสิ้น)"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel18.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(988.3926!, 103.9764!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(47.51343!, 69.66766!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "วันที่คาดว่าจะเสร็จสิ้น"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(940.8792!, 103.9764!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(47.51331!, 69.66766!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "วันที่เริ่มดำเนินการ"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel16.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(896.3657!, 103.9764!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(44.51349!, 69.66766!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "รวมสะสมตั้งแต่เริ่มต้น"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(401.3657!, 103.9764!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(494.9999!, 24.17134!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "ปริมาณและช่วงเวลาในการจัดทำแปลง"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel14.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(340.8523!, 103.9764!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(60.5134!, 69.66766!)
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "ปริมาณซื้อคืนที่คาดว่าจะได้" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ตัน)"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(69.81242!, 103.9764!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(41.72304!, 69.66766!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "ชั้นพันธุ์"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(271.5149!, 103.9764!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(69.33746!, 69.66766!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "กิจกรรมแปลง"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel67
        '
        Me.XrLabel67.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel67.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel67.LocationFloat = New DevExpress.Utils.PointFloat(855.1158!, 128.1477!)
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel67.SizeF = New System.Drawing.SizeF(41.25!, 19.3519!)
        Me.XrLabel67.StylePriority.UseBorders = False
        Me.XrLabel67.StylePriority.UseFont = False
        Me.XrLabel67.StylePriority.UseTextAlignment = False
        Me.XrLabel67.Text = "ก.ย."
        Me.XrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(111.5355!, 103.9764!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(159.9795!, 24.17133!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "เป้าหมาย"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(111.5355!, 128.1477!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(37.7449!, 45.49638!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "การผลิต" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ตัน)"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(149.2803!, 128.1477!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(35.74487!, 45.49628!)
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "ซื้อคืน" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ตัน)"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel12.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(185.0252!, 128.1477!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(35.74489!, 45.49638!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "พื้นที่ " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ไร่)"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel13.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(220.7701!, 128.1477!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(50.7449!, 45.49638!)
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "เกษตรกร" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(กลุ่ม/ราย)"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel56
        '
        Me.XrLabel56.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel56.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(401.3658!, 128.1477!)
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel56.SizeF = New System.Drawing.SizeF(41.24997!, 19.3519!)
        Me.XrLabel56.StylePriority.UseBorders = False
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        Me.XrLabel56.Text = "ต.ค."
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel66
        '
        Me.XrLabel66.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel66.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(813.8658!, 128.1477!)
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(41.25!, 19.3519!)
        Me.XrLabel66.StylePriority.UseBorders = False
        Me.XrLabel66.StylePriority.UseFont = False
        Me.XrLabel66.StylePriority.UseTextAlignment = False
        Me.XrLabel66.Text = "ส.ค."
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel65
        '
        Me.XrLabel65.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel65.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(772.6158!, 128.1477!)
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(41.25!, 19.3519!)
        Me.XrLabel65.StylePriority.UseBorders = False
        Me.XrLabel65.StylePriority.UseFont = False
        Me.XrLabel65.StylePriority.UseTextAlignment = False
        Me.XrLabel65.Text = "ก.ค."
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel64
        '
        Me.XrLabel64.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel64.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel64.LocationFloat = New DevExpress.Utils.PointFloat(731.3657!, 128.1477!)
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel64.SizeF = New System.Drawing.SizeF(41.25!, 19.3519!)
        Me.XrLabel64.StylePriority.UseBorders = False
        Me.XrLabel64.StylePriority.UseFont = False
        Me.XrLabel64.StylePriority.UseTextAlignment = False
        Me.XrLabel64.Text = "มิ.ย."
        Me.XrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel63
        '
        Me.XrLabel63.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel63.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel63.LocationFloat = New DevExpress.Utils.PointFloat(690.1157!, 128.1477!)
        Me.XrLabel63.Name = "XrLabel63"
        Me.XrLabel63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel63.SizeF = New System.Drawing.SizeF(41.25!, 19.3519!)
        Me.XrLabel63.StylePriority.UseBorders = False
        Me.XrLabel63.StylePriority.UseFont = False
        Me.XrLabel63.StylePriority.UseTextAlignment = False
        Me.XrLabel63.Text = "พ.ค."
        Me.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel62
        '
        Me.XrLabel62.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel62.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(648.8658!, 128.1477!)
        Me.XrLabel62.Name = "XrLabel62"
        Me.XrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel62.SizeF = New System.Drawing.SizeF(41.25!, 19.3519!)
        Me.XrLabel62.StylePriority.UseBorders = False
        Me.XrLabel62.StylePriority.UseFont = False
        Me.XrLabel62.StylePriority.UseTextAlignment = False
        Me.XrLabel62.Text = "เม.ย."
        Me.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel61
        '
        Me.XrLabel61.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel61.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(607.6158!, 128.1477!)
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel61.SizeF = New System.Drawing.SizeF(41.25!, 19.3519!)
        Me.XrLabel61.StylePriority.UseBorders = False
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        Me.XrLabel61.Text = "มี.ค."
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel60
        '
        Me.XrLabel60.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel60.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(566.3658!, 128.1477!)
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(41.25!, 19.3519!)
        Me.XrLabel60.StylePriority.UseBorders = False
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        Me.XrLabel60.Text = "ก.พ."
        Me.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel59
        '
        Me.XrLabel59.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel59.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(525.1158!, 128.1477!)
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(41.25!, 19.3519!)
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.Text = "ม.ค"
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel58
        '
        Me.XrLabel58.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel58.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(483.8657!, 128.1477!)
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel58.SizeF = New System.Drawing.SizeF(41.25!, 19.3519!)
        Me.XrLabel58.StylePriority.UseBorders = False
        Me.XrLabel58.StylePriority.UseFont = False
        Me.XrLabel58.StylePriority.UseTextAlignment = False
        Me.XrLabel58.Text = "ธ.ค."
        Me.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel57
        '
        Me.XrLabel57.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel57.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(442.6158!, 128.1477!)
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(41.25!, 19.3519!)
        Me.XrLabel57.StylePriority.UseBorders = False
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        Me.XrLabel57.Text = "พ.ย."
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Font = New System.Drawing.Font("AngsanaUPC", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 103.9764!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(69.81242!, 69.66766!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "พันธุ์ข้าว"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel15.Font = New System.Drawing.Font("Angsana New", 14.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(1017.0!, 0.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "สมข 20103"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Angsana New", 12.0!)
        Me.XrPageInfo1.Format = "หน้า {0} จาก {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1017.0!, 77.96301!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.RunningBand = Me.GroupHeader2
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0001!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageBreak1})
        Me.GroupFooter1.HeightF = 65.58334!
        Me.GroupFooter1.Level = 1
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 63.58334!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("FullPlanName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 0.0!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.HeightF = 0.0!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'SeasonPrm
        '
        Me.SeasonPrm.Description = "ฤดู"
        StaticListLookUpSettings1.FilterString = Nothing
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("แล้ง", "แล้ง"))
        StaticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("ฝน", "ฝน"))
        Me.SeasonPrm.LookUpSettings = StaticListLookUpSettings1
        Me.SeasonPrm.Name = "SeasonPrm"
        '
        'YearPrm
        '
        Me.YearPrm.Description = "ปี"
        Me.YearPrm.Name = "YearPrm"
        '
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "SP_GetReportActivity"
        Me.CalculatedField1.Expression = "'ฤดู '  + [Parameters.SeasonPrm] + '  ปี ' +[Parameters.YearPrm]"
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'Group_Farmer
        '
        Me.Group_Farmer.DataMember = "SP_GetReportActivity"
        Me.Group_Farmer.Expression = "[TotalFarmerGroup] + '/' + [TotalFarmer]"
        Me.Group_Farmer.Name = "Group_Farmer"
        '
        'SeedType_Lot
        '
        Me.SeedType_Lot.DataMember = "SP_GetReportActivity"
        Me.SeedType_Lot.Expression = "[SeedTypeName] + ' ล็อต ' +[SeedLot]"
        Me.SeedType_Lot.Name = "SeedType_Lot"
        '
        'XrTableCell50
        '
        Me.XrTableCell50.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell50.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell50.StylePriority.UseBorders = False
        Me.XrTableCell50.StylePriority.UseFont = False
        Me.XrTableCell50.StylePriority.UsePadding = False
        Me.XrTableCell50.Weight = 0.6981245988582675R
        '
        'XrTableCell87
        '
        Me.XrTableCell87.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell87.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell87.Name = "XrTableCell87"
        Me.XrTableCell87.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell87.StylePriority.UseBorders = False
        Me.XrTableCell87.StylePriority.UseFont = False
        Me.XrTableCell87.StylePriority.UsePadding = False
        Me.XrTableCell87.Weight = 0.6981245988582675R
        '
        'XrTableCell124
        '
        Me.XrTableCell124.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell124.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell124.Name = "XrTableCell124"
        Me.XrTableCell124.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell124.StylePriority.UseBorders = False
        Me.XrTableCell124.StylePriority.UseFont = False
        Me.XrTableCell124.StylePriority.UsePadding = False
        Me.XrTableCell124.Weight = 0.6981245988582675R
        '
        'XrTableCell161
        '
        Me.XrTableCell161.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell161.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell161.Name = "XrTableCell161"
        Me.XrTableCell161.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell161.StylePriority.UseBorders = False
        Me.XrTableCell161.StylePriority.UseFont = False
        Me.XrTableCell161.StylePriority.UsePadding = False
        Me.XrTableCell161.Weight = 0.6981245988582675R
        '
        'XrTableCell198
        '
        Me.XrTableCell198.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell198.Font = New System.Drawing.Font("AngsanaUPC", 10.0!)
        Me.XrTableCell198.Name = "XrTableCell198"
        Me.XrTableCell198.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100.0!)
        Me.XrTableCell198.StylePriority.UseBorders = False
        Me.XrTableCell198.StylePriority.UseFont = False
        Me.XrTableCell198.StylePriority.UsePadding = False
        Me.XrTableCell198.Weight = 0.6981245988582675R
        '
        'CenterActivityReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageFooter, Me.DetailReport})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1, Me.Group_Farmer, Me.SeedType_Lot})
        Me.ComponentStorage.Add(Me.SqlDataSource1)
        Me.DataSource = Me.SqlDataSource1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(26, 26, 61, 45)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.SeasonPrm, Me.YearPrm})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "14.2"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents SeasonPrm As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents YearPrm As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
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
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell53 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell56 As DevExpress.XtraReports.UI.XRTableCell
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
    Friend WithEvents XrTableCell81 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell82 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell83 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell84 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell85 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell86 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell88 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell89 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell90 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell91 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell92 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell93 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell94 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell95 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell96 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell97 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell98 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell99 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell100 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell101 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell102 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell103 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell104 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell105 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell106 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell107 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell108 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell109 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell110 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell111 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell112 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell113 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell114 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell115 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell116 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell117 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell118 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell119 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell120 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell121 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell122 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell123 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell125 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell126 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell127 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell128 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell129 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell130 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell131 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell132 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell133 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell134 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell135 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell136 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell137 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell138 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell139 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell140 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell141 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell142 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell143 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell144 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell145 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell146 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell147 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell148 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell149 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell150 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell151 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell152 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell153 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell154 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell155 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell156 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell157 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell158 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell159 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell160 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell162 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell163 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell164 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell165 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell166 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell167 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell168 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell169 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell170 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell171 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell172 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell173 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell174 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell175 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell176 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell177 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell178 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell179 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell180 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell181 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell182 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell183 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell184 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell185 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell186 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell187 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell188 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell189 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell190 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell191 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell192 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell193 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell194 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell195 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell196 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell197 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell199 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell200 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell201 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell202 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell203 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell204 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell205 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell206 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell207 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell208 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell209 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell210 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell211 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell212 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell213 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell214 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell215 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell216 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell217 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell218 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell219 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell220 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell221 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell222 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell223 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell224 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell225 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell226 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell227 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell228 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell229 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell230 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell231 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell232 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell233 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell234 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel64 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel63 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Group_Farmer As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents SeedType_Lot As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell87 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell124 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell161 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell198 As DevExpress.XtraReports.UI.XRTableCell
End Class
