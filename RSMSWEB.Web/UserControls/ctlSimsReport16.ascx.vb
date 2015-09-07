Imports Microsoft.ApplicationBlocks.Data
Imports DevExpress.Web
Imports DevExpress.Data

Public Class ctlSimsReport16
    Inherits System.Web.UI.UserControl

    Private conn As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
    Private RefData As New SeedReferenceData(conn)

    Private Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        LoadSite(cmbSite)
        LoadProvince(cmbProvince)
    End Sub

    Public Sub LoadProvince(combobox As DevExpress.Web.ASPxComboBox)
        combobox.DataSource = RefData.GetProvince
        combobox.TextField = "ProvinceName"
        combobox.ValueField = "Oid"
        combobox.DataBind()

        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", "-1"))
        combobox.SelectedIndex = 0

    End Sub

    Public Sub LoadDistrict(combobox As DevExpress.Web.ASPxComboBox, ProviceOid As String)
        combobox.Items.Clear()
        combobox.DataSource = RefData.GetDistrict(ProviceOid)
        combobox.TextField = "DistrictName"
        combobox.ValueField = "Oid"
        combobox.DataBind()

        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", "-1"))
        combobox.SelectedIndex = 0

    End Sub

    Public Sub LoadSubDistrict(combobox As DevExpress.Web.ASPxComboBox, DistrictOid As String)
        combobox.Items.Clear()
        combobox.DataSource = RefData.GetSubDistrict(DistrictOid)
        combobox.TextField = "SubDistrictName"
        combobox.ValueField = "Oid"
        combobox.DataBind()

        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", "-1"))
        combobox.SelectedIndex = 0

    End Sub

    Public Sub LoadSite(combobox As DevExpress.Web.ASPxComboBox)
        combobox.DataSource = RefData.GetSite
        combobox.TextField = "SiteName"
        combobox.ValueField = "SiteNo"
        combobox.DataBind()

        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", -1))
        combobox.SelectedIndex = 0
    End Sub

    Public Sub LoadData()
        Try

            Dim ds As New DataSet
            Dim cmd As String = "SP_Sims_Report16_ReserveSeed"
            Dim prm(5) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@SiteNo", DbType.Int32)
            If cmbSite.SelectedIndex <> 0 Then
                prm(0).Value = cmbSite.Value
            Else
                prm(0).Value = DBNull.Value
            End If
            prm(1) = New SqlClient.SqlParameter("@ProvinceName", DbType.String)
            If cmbProvince.SelectedIndex <> 0 Then
                prm(1).Value = cmbProvince.Text
            Else
                prm(1).Value = DBNull.Value
            End If
            prm(2) = New SqlClient.SqlParameter("@DistrictName", DbType.String)
            If cmbDistric.SelectedIndex <> 0 Then
                prm(2).Value = cmbDistric.Text
            Else
                prm(2).Value = DBNull.Value
            End If
            prm(3) = New SqlClient.SqlParameter("@SubDistrictName", DbType.String)
            If cmbSubDistric.SelectedIndex <> 0 Then
                prm(3).Value = cmbSubDistric.Text
            Else
                prm(3).Value = DBNull.Value
            End If
            prm(4) = New SqlClient.SqlParameter("@StartDate", DbType.Date)
            If dpkStartDate.Text <> "" Then
                prm(4).Value = dpkStartDate.Value
            Else
                prm(4).Value = DBNull.Value
            End If
            prm(5) = New SqlClient.SqlParameter("@EndDate", DbType.Date)
            If dpkEndDate.Text <> "" Then
                prm(5).Value = dpkEndDate.Value
            Else
                prm(5).Value = DBNull.Value
            End If

            ds = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd, prm)
            gvData.DataSource = ds.Tables(0)
            gvData.DataBind()

        Catch ex As Exception
            '//Response.Write(ex.Message)
            gvData.DataSource = Nothing
            gvData.DataBind()
        End Try
    End Sub

    Private Sub gvData_CustomCallback(sender As Object, e As ASPxGridViewCustomCallbackEventArgs) Handles gvData.CustomCallback
        If e.Parameters.Length > 0 Then
            Dim args = e.Parameters.Split(",")
            Dim order As ColumnSortOrder
            If args(0) = "ASC" Then
                order = ColumnSortOrder.Ascending
            Else
                order = ColumnSortOrder.Descending
            End If
            Dim collName As String = args(1).ToString

            gvData.ClearSort()
            gvData.SortBy(gvData.Columns(collName), order)
        End If

        LoadData()

    End Sub

    Private Sub gvData_PageIndexChanged(sender As Object, e As EventArgs) Handles gvData.PageIndexChanged
        '//gvData.PageIndex = e.ToString
        LoadData()
    End Sub

    Private Sub gvData_PageSizeChanged(sender As Object, e As EventArgs) Handles gvData.PageSizeChanged
        LoadData()
    End Sub

    'Protected Sub btnExportData_Click(sender As Object, e As EventArgs) Handles btnExportData.Click
    '    LoadData()
    '    ASPxGridViewExporter1.WriteXlsToResponse(Date.Today.ToString("ddMMyy") & "_บัญชีการสั่งจอง_สำรองเมล็ดพันธุ์", True)
    'End Sub

    Private Sub cmbDistric_Callback(sender As Object, e As CallbackEventArgsBase) Handles cmbDistric.Callback
        LoadDistrict(sender, e.Parameter)
    End Sub

    Private Sub cmbSubDistric_Callback(sender As Object, e As CallbackEventArgsBase) Handles cmbSubDistric.Callback
        LoadSubDistrict(sender, e.Parameter)
    End Sub

End Class