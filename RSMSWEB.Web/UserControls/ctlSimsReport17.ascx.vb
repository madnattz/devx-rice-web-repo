Imports Microsoft.ApplicationBlocks.Data
Imports DevExpress.Web
Imports DevExpress.Data

Public Class ctlSimsReport17
    Inherits System.Web.UI.UserControl

    Private conn As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
    Private RefData As New SeedReferenceData(conn)

    Private Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        LoadSite(cmbSite)
        LoadMoneyType(cmbMoneyType)
        LoadMaterial(cmbMaterial)
    End Sub

    Public Sub LoadMoneyType(combobox As DevExpress.Web.ASPxComboBox)
        combobox.DataSource = RefData.GetMoneyType
        combobox.TextField = "MoneyTypeName"
        combobox.ValueField = "MoneyTypeId"
        combobox.DataBind()

        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", -1))
        combobox.SelectedIndex = 0
    End Sub

    Public Sub LoadMaterial(combobox As DevExpress.Web.ASPxComboBox)
        combobox.DataSource = RefData.GetMaterial
        combobox.TextField = "MaterialName"
        combobox.ValueField = "MaterialCode"
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
            Dim cmd As String = "SP_Sims_Report17_MaterialTransaction"
            Dim prm(4) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@SiteNo", DbType.Int32)
            If cmbSite.SelectedIndex <> 0 Then
                prm(0).Value = cmbSite.Value
            Else
                prm(0).Value = DBNull.Value
            End If
            prm(1) = New SqlClient.SqlParameter("@MoneyTypeName", DbType.String)
            If cmbMoneyType.SelectedIndex <> 0 Then
                prm(1).Value = cmbMoneyType.Text
            Else
                prm(1).Value = DBNull.Value
            End If
            prm(2) = New SqlClient.SqlParameter("@MaterialName", DbType.String)
            If cmbMaterial.SelectedIndex <> 0 Then
                prm(2).Value = cmbMaterial.Text
            Else
                prm(2).Value = DBNull.Value
            End If
            prm(3) = New SqlClient.SqlParameter("@StartDate", DbType.Date)
            If dpkStartDate.Text <> "" Then
                prm(3).Value = dpkStartDate.Value
            Else
                prm(3).Value = DBNull.Value
            End If
            prm(4) = New SqlClient.SqlParameter("@EndDate", DbType.Date)
            If dpkEndDate.Text <> "" Then
                prm(4).Value = dpkEndDate.Value
            Else
                prm(4).Value = DBNull.Value
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

    Protected Sub btnExportData_Click(sender As Object, e As EventArgs) Handles btnExportData.Click
        LoadData()
        ASPxGridViewExporter1.WriteXlsToResponse(Date.Today.ToString("ddMMyy") & "_บัญชีวัสดุการผลิตคงคลัง", True)
    End Sub


End Class