Imports Microsoft.ApplicationBlocks.Data
Imports DevExpress.Web
Imports DevExpress.Data

Public Class ctlSimsReport02
    Inherits System.Web.UI.UserControl

    Private conn As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
    Private RefData As New SeedReferenceData(conn)

    Private Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        LoadPlant(cmbPlant)
        LoadSeedStatus(cmbSeedStatus)
        cmbSeedStatus.SelectedIndex = 1
        cmbSeedStatus.SelectedItem = cmbSeedStatus.Items.FindByText("ซื้อคืน")
        LoadSeedType(cmbSeedType, "-1")
        LoadSeedClass(cmbSeedClass)
        LoadSeason(cmbSeason)
        LoadMoneyType(cmbMoneyType)
        LoadYear(cmbYear)
        LoadSite(cmbSite)
    End Sub

    Public Sub LoadPlant(combobox As DevExpress.Web.ASPxComboBox)
        combobox.DataSource = RefData.GetPlans
        combobox.TextField = "PlantName"
        combobox.ValueField = "PlantID"
        combobox.DataBind()

        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", -1))
        combobox.SelectedIndex = 0

    End Sub

    Public Sub LoadSeedStatus(combobox As DevExpress.Web.ASPxComboBox)
        combobox.DataSource = RefData.GetSeedStatus
        combobox.TextField = "SeedStatusName"
        combobox.ValueField = "SeedStatusID"
        combobox.DataBind()

        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", -1))
        combobox.SelectedIndex = 0
    End Sub

    Public Sub LoadSeedType(combobox As DevExpress.Web.ASPxComboBox, PlantId As String)
        Dim ds As DataSet = RefData.GetSeedType(PlantId)
        If ds.Tables(0).Rows.Count > 0 Then
            combobox.DataSource = ds
            combobox.TextField = "SeedName"
            combobox.ValueField = "SeedID"
            combobox.DataBind()
        Else
            combobox.Items.Clear()
        End If
        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", -1))
        combobox.SelectedIndex = 0
    End Sub

    Public Sub LoadSeedClass(combobox As DevExpress.Web.ASPxComboBox)
        combobox.DataSource = RefData.GetSeedClass
        combobox.TextField = "ClassName"
        combobox.ValueField = "ClassID"
        combobox.DataBind()

        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", -1))
        combobox.SelectedIndex = 0
    End Sub

    Public Sub LoadSeason(combobox As DevExpress.Web.ASPxComboBox)
        combobox.DataSource = RefData.GetSeason
        combobox.TextField = "SeasonName"
        combobox.ValueField = "SeasonID"
        combobox.DataBind()

        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", -1))
        combobox.SelectedIndex = 0
    End Sub

    Public Sub LoadMoneyType(combobox As DevExpress.Web.ASPxComboBox)
        combobox.DataSource = RefData.GetMoneyType
        combobox.TextField = "MoneyTypeName"
        combobox.ValueField = "MoneyTypeId"
        combobox.DataBind()

        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", -1))
        combobox.SelectedIndex = 0
    End Sub

    Public Sub LoadYear(combobox As DevExpress.Web.ASPxComboBox)
        Dim list = RefData.GetYear
        combobox.Items.Clear()
        For i As Integer = 0 To list.Count - 1
            combobox.Items.Add(New DevExpress.Web.ListEditItem(list(i), list(i)))
        Next

        combobox.Items.Insert(0, New DevExpress.Web.ListEditItem("ทั้งหมด", -1))
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
            Dim cmd As String = "SP_Sims_Report02_PickRawSeed"
            Dim prm(9) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@SiteNo", DbType.Int32)
            If cmbSite.SelectedIndex <> 0 Then
                prm(0).Value = cmbSite.Value
            Else
                prm(0).Value = DBNull.Value
            End If
            prm(1) = New SqlClient.SqlParameter("@PlantName", DbType.String)
            If cmbPlant.SelectedIndex <> 0 Then
                prm(1).Value = cmbPlant.Text
            Else
                prm(1).Value = DBNull.Value
            End If
            prm(2) = New SqlClient.SqlParameter("@SeedType", DbType.String)
            If cmbSeedType.SelectedIndex <> 0 Then
                prm(2).Value = cmbSeedType.Text
            Else
                prm(2).Value = DBNull.Value
            End If
            prm(3) = New SqlClient.SqlParameter("@SeedClass", DbType.String)
            If cmbSeedClass.SelectedIndex <> 0 Then
                prm(3).Value = cmbSeedClass.Text
            Else
                prm(3).Value = DBNull.Value
            End If
            prm(4) = New SqlClient.SqlParameter("@Season", DbType.String)
            If cmbSeason.SelectedIndex <> 0 Then
                prm(4).Value = cmbSeason.Text
            Else
                prm(4).Value = DBNull.Value
            End If
            prm(5) = New SqlClient.SqlParameter("@SeedYear", DbType.String)
            If cmbYear.SelectedIndex <> 0 Then
                prm(5).Value = cmbYear.Text
            Else
                prm(5).Value = DBNull.Value
            End If
            prm(6) = New SqlClient.SqlParameter("@MoneyType", DbType.String)
            If cmbMoneyType.SelectedIndex <> 0 Then
                prm(6).Value = cmbMoneyType.Text
            Else
                prm(6).Value = DBNull.Value
            End If
            prm(7) = New SqlClient.SqlParameter("@LotNo", DbType.Int32)
            If txtLotNo.Text <> "000" And Not txtLotNo.Text.ToLower.Contains("x") Then
                prm(7).Value = Convert.ToInt32(txtLotNo.Text)
            Else
                prm(7).Value = DBNull.Value
            End If
            prm(8) = New SqlClient.SqlParameter("@StartDate", DbType.Date)
            If dpkStartDate.Text <> "" Then
                prm(8).Value = dpkStartDate.Value
            Else
                prm(8).Value = DBNull.Value
            End If
            prm(9) = New SqlClient.SqlParameter("@EndDate", DbType.Date)
            If dpkEndDate.Text <> "" Then
                prm(9).Value = dpkEndDate.Value
            Else
                prm(9).Value = DBNull.Value
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

    Private Sub cmbSeedType_Callback(sender As Object, e As DevExpress.Web.CallbackEventArgsBase) Handles cmbSeedType.Callback
        LoadSeedType(cmbSeedType, e.Parameter)
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
        ASPxGridViewExporter1.WriteXlsToResponse(Date.Today.ToString("ddMMyy") & "_บัญชีรายการจ่ายเมล็ดพันธุ์ซื้อคืน", True)
    End Sub

   
End Class