Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Imports System.IO
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Security

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
'<System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://rsms.ricethailand.go.th/webservices/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class RiceService
    Inherits System.Web.Services.WebService

    Dim strConnection As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
    Const SecureCode As String = "NTiSecureCode"

    ''' <summary>
    ''' สำหรับตรวจสอบสิทธิ์การเข้าใช้งานด้วย Username และ Password
    ''' </summary>
    ''' <param name="UserID">ชื่อผู้ใช้งาน</param>
    ''' <param name="Password">รหัสผ่าน</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <WebMethod(Description:="ตรวจสอบสิทธิ์การเข้าใช้งานด้วย username และ password", EnableSession:=False)> _
    Public Function Authenticate(UserName As String, Password As String) As DataTable
        If Not (UserName = String.Empty Or Password = String.Empty) Then
            Dim objConn As SqlConnection = New SqlConnection(strConnection)
            Dim strCommand As String = String.Empty

            strCommand = "SELECT 2 AS Result, 'Login success for ' + A.UserName + '.' AS Message, A.Oid, A.UserName, A.StoredPassword, A.FirstName, A.LastName " & _
                                " " & _
                                "FROM dbo.[SecuritySystemUser] AS A " & _
                                "WHERE (A.UserName = N'" & UserName & "')"

            Dim ds As New DataSet
            ds = SqlHelper.ExecuteDataset(objConn, CommandType.Text, strCommand)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim tmpStoredPassword As String = (ds.Tables(0).Rows(0).Item("StoredPassword"))
                Dim chkResult As Boolean = SecurityUserBase.ComparePassword(tmpStoredPassword, Password)
                If chkResult Then
                    'Success
                    Return ds.Tables(0)
                Else
                    'รหัสผ่านผิด
                    Return ds.Tables(0) 'CreateTableResult(1, UserName)
                End If
            Else
                'ไม่พบ User นี้ในระบบ
                Return ds.Tables(0) 'CreateTableResult(0, UserName)
            End If
        End If
    End Function

    ''' <summary>
    ''' สำหรับ upload ไฟล์ข้อมูลเข้าสู่ระบบ
    ''' </summary>
    ''' <param name="f">file object</param>
    ''' <param name="fileName">ชื่อไฟล์</param>
    ''' <param name="SiteID">รหัสหน่วย/ศูนย์เมล็ดพันธุ์ข้าว</param>
    ''' <param name="SecurityKey">รหัสความปลอดภัย</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <WebMethod(Description:="สำหรับ upload ไฟล์ข้อมูลเข้าสู่ระบบ", EnableSession:=False)> _
    Public Function SendFile(ByVal f As Byte(), ByVal FileName As String, ByVal Description As String, ByVal Type As String, ByVal UserID As String, ByVal SiteID As String, ByVal SecurityKey As String) As String
        ' the byte array argument contains the content of the file
        ' the string argument contains the name and extension
        ' of the file passed in the byte array
        Try
            ' instance a memory stream and pass the
            ' byte array to its constructor
            Dim ms As New MemoryStream(f)

            ' instance a filestream pointing to the
            ' storage folder, use the original file name
            ' to name the resulting file
            Dim fs As New FileStream(ConfigurationManager.AppSettings("FileUploadPath").ToString & GenFilename(FileName), FileMode.Create)

            ' write the memory stream containing the original 
            ' file as a byte array to the filestream
            ms.WriteTo(fs)
            'Clean up
            ms.Close()
            fs.Close()
            fs.Dispose()

            ' Return OK if we made it this far 
            Return "OK"
        Catch ex As Exception
            ' Return the error message if the operation fails 
            Return ex.Message.ToString()
        End Try
    End Function

    ''' <summary>
    ''' สำหรับอ่านข้อมูลจังหวัด
    ''' </summary>
    ''' <param name="ProvinceId">รหัสจังหวัด</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <WebMethod(Description:="ข้อมูลจังหวัด", EnableSession:=False)> _
    Public Function GetUpdateProvince(ByVal ProvinceId As String) As DataTable
        Dim ds As DataSet
        Dim dt As DataTable
        ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "SP_GetProvince", New SqlParameter("@PROVINCE_ID", ProvinceId))
        dt = ds.Tables(0)
        Return dt
    End Function

    ''' <summary>
    ''' ข้อมูลอำเภอ/เขต
    ''' </summary>
    ''' <param name="ProvinceId">รหัสจังหวัด</param>
    ''' <param name="DistrictId">รหัสอำเภอ/เขต</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <WebMethod(Description:="ข้อมูลอำเภอ/เขต", EnableSession:=False)> _
    Public Function GetUpdateDistrict(ByVal ProvinceId As String, ByVal DistrictId As String) As DataTable
        Dim ds As DataSet
        Dim dt As DataTable
        ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "SP_GetDistrict", New SqlParameter("@PROVINCE_ID", ProvinceId), New SqlParameter("@DISTRICT_ID", DistrictId))
        dt = ds.Tables(0)
        Return dt
    End Function

    <WebMethod(Description:="ข้อมูลตำบล/แขวง", EnableSession:=False)> _
    Public Function GetUpdateSubDistrict(ByVal ProvinceId As String, ByVal DistrictId As String, ByVal SubDistrictId As String) As DataTable
        Dim ds As DataSet
        Dim dt As DataTable
        ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "SP_GetSubDistrict", New SqlParameter("@PROVINCE_ID", ProvinceId), New SqlParameter("@DISTRICT_ID", DistrictId), New SqlParameter("@SUB_DISTRICT_ID", SubDistrictId))
        dt = ds.Tables(0)
        Return dt
    End Function


    <WebMethod(Description:="ข้อมูลหน่วยงาน", EnableSession:=False)> _
    Public Function GetSiteInfo(ByVal SiteType As String, ByVal SiteNo As String) As DataTable
        Dim ds As DataSet
        Dim dt As DataTable
        ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "SP_GetSiteInfo", New SqlParameter("@SITE_TYPE", SiteType), New SqlParameter("@SITE_NO", SiteNo))
        dt = ds.Tables(0)
        Return dt
    End Function

    <WebMethod(Description:="ข้อมูล Account", EnableSession:=False)> _
    Public Function Account() As DataTable
        Dim ds As DataSet
        Dim dt As DataTable
        ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "SP_GetAccount")
        dt = ds.Tables(0)
        Return dt
    End Function

    <WebMethod(Description:="ข้อมูลพืช", EnableSession:=False)> _
    Public Function GetUpdatePlant() As DataTable
        Dim ds As DataSet
        Dim cmd As String = "SP_GetPlant"
        ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, cmd)

        Return ds.Tables(0)

    End Function


    ''' <summary>
    ''' สำหรับตั้งชื่อไฟล์ที่ทำการ upload file.
    ''' </summary>
    ''' <param name="str_filename">ชื่อไฟล์</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GenFilename(ByVal str_filename As String) As String
        Dim strFilename As String
        strFilename = Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & Now.Second & "_" & str_filename & ".xls"
        Return strFilename
    End Function

    <WebMethod(Description:="ส่งรายงาน ขพ.2", EnableSession:=False)> _
    Public Function SubmitDataKp2Report(SecureID As String, KP2Data As KP2ReportData) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertKP2Header(trans, KP2Data)
                '//Insert Detail
                WebserviceDBController.InsertKP2Detail(trans, headerNo, KP2Data.KP2ReportDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, KP2Data.SiteNo, KP2Data.SiteName, "รายงาน ขพ.2", KP2Data.SeedYear, KP2Data.SubmitDate, KP2Data.SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataKp2Report", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน ขพ.3", EnableSession:=False)> _
    Public Function SubmitDataKp3Report(SecureID As String, KP3Data As KP3ReportData) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertKP3Header(trans, KP3Data)
                '//Insert Detail
                WebserviceDBController.InsertKP3Detail(trans, headerNo, KP3Data.KP3ReportDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, KP3Data.SiteNo, KP3Data.SiteName, "รายงาน ขพ.3", KP3Data.SeedYear, KP3Data.SubmitDate, KP3Data.SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataKp3Report", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน ขพ.5", EnableSession:=False)> _
    Public Function SubmitDataKp5Report(SecureID As String, KP5Data As KP5ReportData) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertKP5Header(trans, KP5Data)
                '//Insert Detail
                WebserviceDBController.InsertKP5Detail(trans, headerNo, KP5Data.KP5ReportDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, KP5Data.SiteNo, KP5Data.SiteName, "รายงาน ขพ.5", KP5Data.SeedYear, KP5Data.SubmitDate, KP5Data.SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataKp5Report", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน แผนและผลการจัดทำแปลง", EnableSession:=False)> _
    Public Function SubmitDataPlanAndResultReport(SecureID As String, ReportData As List(Of ActivityPlanReportData)) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                For Each item As ActivityPlanReportData In ReportData
                    Dim headerNo As Integer = WebserviceDBController.InsertActivityPlanReportHeader(trans, item)
                    '//Insert Detail
                    WebserviceDBController.InsertGrowPlanDetail(trans, headerNo, item.GrowPlanDetails)
                    WebserviceDBController.InsertHarvestPlanDetail(trans, headerNo, item.HarvestPlanDetails)
                    WebserviceDBController.InsertBuyPlanDetail(trans, headerNo, item.BuyPlanDetails)

                Next
                WebserviceDBController.InsertSubmitReportLog(trans, ReportData(0).SiteNo, ReportData(0).SiteName, "รายงาน แผนและผลการจัดทำแปลงขยายพันธุ์", ReportData(0).SeedYear, ReportData(0).SubmitDate, ReportData(0).SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataPlanAndResultReport", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน แบบบันทึกการตรวจตัดสินแปลงขยายพันธุ์ข้าวอย่างเป็นทางการ", EnableSession:=False)> _
    Public Function SubmitDataCheckFarmReport(SecureID As String, CheckFarmData As CheckFarmHeader) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertCheckFarmHeader(trans, CheckFarmData)
                '//Insert DetailInsertCheckFarmHeader
                WebserviceDBController.InsertCheckFarmDetail(trans, headerNo, CheckFarmData.CheckFarmDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, CheckFarmData.SiteNo, CheckFarmData.SiteName, "รายงาน แบบบันทึกการตรวจตัดสินแปลงขยายพันธุ์ข้าวอย่างเป็นทางการ", CheckFarmData.SeedYear, CheckFarmData.SubmitDate, CheckFarmData.SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataCheckFarmReport", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน ผลการตรวจตัดสินคุณภาพแปลงขยายพันธุ์", EnableSession:=False)> _
    Public Function SubmitDataCheckFarmSummaryReport(SecureID As String, ReportData As List(Of CheckFarmSummaryHeader)) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                For Each item As CheckFarmSummaryHeader In ReportData
                    Dim headerNo As Integer = WebserviceDBController.InsertCheckFarmSummaryHeader(trans, item)
                    '//Insert Detail
                    WebserviceDBController.InsertCheckFarmSummaryDetail(trans, headerNo, item.CheckFarmSummaryDetails)
                Next

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData(0).SiteNo, ReportData(0).SiteName, "รายงาน ผลการตรวจตัดสินคุณภาพแปลงขยายพันธุ์", ReportData(0).SeedYear, ReportData(0).SubmitDate, ReportData(0).SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataCheckFarmSummaryReport", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงานปริมาณข้าวแดงที่ตรวจพบในการทดสอบคุณภาพเมล็ดพันธ์ข้าว", EnableSession:=False)> _
    Public Function SubmitCheckRedSeedReport(SecureID As String, ReportData As CheckRedSeedData) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                WebserviceDBController.InsertCheckRedSeed(trans, ReportData)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงานปริมาณข้าวแดงที่ตรวจพบในการทดสอบคุณภาพเมล็ดพันธ์ข้าว", ReportData.SeedYear, ReportData.SubmitDate, ReportData.SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitCheckRedSeedReport", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงานปริมาณการตรวจสอบคุณภาพเมล็ดพันธุ์ข้าวประจำเดือน", EnableSession:=False)> _
    Public Function SubmitCheckQualityForMonth(SecureID As String, ReportData As List(Of CheckQualityForMonthData)) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                For Each item As CheckQualityForMonthData In ReportData
                    WebserviceDBController.InsertCheckQualityForMonth(trans, item)
                Next

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData(0).SiteNo, ReportData(0).SiteName, "รายงานปริมาณการตรวจสอบคุณภาพเมล็ดพันธุ์ข้าวประจำเดือน", ReportData(0).SeedYear, ReportData(0).SubmitDate, ReportData(0).SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitCheckQualityForMonth", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน แบบแผนสรุปผลการปรับปรุงสภาพเมล็ดพันธุ์รายวัน", EnableSession:=False)> _
    Public Function SubmitDataDailyProcessReport(SecureID As String, DailyProcessData As DailyProcessHeader) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertDailyProcessHeader(trans, DailyProcessData)
                '//Insert DetailInsertCheckFarmHeader
                WebserviceDBController.InsertDailyProcessDetail(trans, headerNo, DailyProcessData.DailyProcessDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, DailyProcessData.SiteNo, DailyProcessData.SiteName, "แบบแผนสรุปผลการปรับปรุงสภาพเมล็ดพันธุ์รายวัน", DailyProcessData.ProcessYear, DailyProcessData.SubmitDate, DailyProcessData.SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataDailyProcessReport", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน ผลการทดสอบคุณภาพเมล็ดพันธุ์เพื่อจัดซื้อ", EnableSession:=False)> _
    Public Function SubmitDataQualityForBuyReport(SecureID As String, QualityForBuyData As QualityForBuyHeader) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertQualityForBuyHeader(trans, QualityForBuyData)
                '//Insert DetailInsertQualityForBuyHeader
                WebserviceDBController.InsertQualityForBuyDetail(trans, headerNo, QualityForBuyData.QualityForBuyDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, QualityForBuyData.SiteNo, QualityForBuyData.SiteName, "ผลการทดสอบคุณภาพเมล็ดพันธุ์เพื่อจัดซื้อ", QualityForBuyData.SeedYear, QualityForBuyData.SubmitDate, QualityForBuyData.SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataQualityForBuyReport", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน ประวัติคุณภาพเมล็ดพันธุ์", EnableSession:=False)> _
    Public Function SubmitDataQualityHistoryReport(SecureID As String, QualityHistoryData As List(Of QualityHistoryHeader)) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                For Each item As QualityHistoryHeader In QualityHistoryData
                    Dim headerNo As Integer = WebserviceDBController.InsertQualityHistoryHeader(trans, item)
                    '//Insert DetailInsertQualityForBuyHeader
                    WebserviceDBController.InsertQualityHistoryDetail(trans, headerNo, item.QualityHistoryDetails)

                Next
               
                WebserviceDBController.InsertSubmitReportLog(trans, QualityHistoryData(0).SiteNo, QualityHistoryData(0).SiteName, "ประวัติคุณภาพเมล็ดพันธุ์", QualityHistoryData(0).SeedYear, QualityHistoryData(0).SubmitDate, QualityHistoryData(0).SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataQualityHistoryReport", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    '//---------------- อ๊อด--------------------------------
#Region "================== รายงานผลการตรวจสอบคุณภาพเมล็ดพันธุ์ระหว่างการเก็บรักษา ประจำเดือน (กคภ 06) ===================="
    <WebMethod(Description:="ส่งรายงาน กคภ 06", EnableSession:=False)> _
    Public Function SubmitDataQBS06Report(SecureID As String, ReportData As QualityBetweenStorageHeader) As String '==QualityBetweenStorage==

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If


            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertReportQualityBetweenStorageHeader(trans, ReportData)
                '//Insert Detail
                WebserviceDBController.InsertReportQualityBetweenStorageDetail(trans, headerNo, ReportData.QualityBetweenStorageDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "ผลการตรวจสอบคุณภาพเมล็ดพันธุ์ระหว่างการเก็บรักษา", ReportData.SeedYear, ReportData.SubmitDate, ReportData.SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataQBS06Report", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function
#End Region

    '//-------------------------------- boy --------------------------------------
    '<WebMethod(Description:="ส่งรายงาน งบทดลอง", EnableSession:=False)> _
    'Public Function SubmitDataTrialBalance(SecureID As String, ReportData As TrialBalanceHeader) As String

    '    If SecureID = SecureCode Then

    '        Dim objConnection As New SqlClient.SqlConnection(strConnection)

    '        If objConnection.State = ConnectionState.Closed Then
    '            objConnection.Open()
    '        End If

    '        Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

    '        Try
    '            '//Insert Header
    '            Dim headerNo As Integer = WebserviceDBController.InsertTrialBalanceHeader(trans, ReportData)
    '            '//Insert Detail
    '            WebserviceDBController.InsertTrialBalanceDetail(trans, headerNo, ReportData.TrialBalanceDetails)

    '            WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงานงบทดลอง", ReportData.Year, ReportData.SentDate, ReportData.SentBy)

    '            trans.Commit()

    '            Return "Success"

    '        Catch ex As Exception
    '            trans.Rollback()
    '            WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataTrialBalance", ex.Message)
    '            Return "Fail"
    '        Finally
    '            trans.Dispose()
    '            objConnection.Close()
    '        End Try
    '    Else
    '        Return "Invalid Secure ID"
    '    End If

    'End Function

    '<WebMethod(Description:="ส่งรายงาน ต้นทุนเมล็ดพันธุ์", EnableSession:=False)> _
    'Public Function SubmitDataAccCost(SecureID As String, ReportData As AccCostHeader) As String

    '    If SecureID = SecureCode Then

    '        Dim objConnection As New SqlClient.SqlConnection(strConnection)

    '        If objConnection.State = ConnectionState.Closed Then
    '            objConnection.Open()
    '        End If

    '        Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

    '        Try
    '            '//Insert Header
    '            Dim headerNo As Integer = WebserviceDBController.InsertAccCostHeader(trans, ReportData)
    '            '//Insert Detail
    '            WebserviceDBController.InsertAccCostDetail(trans, headerNo, ReportData.AccCostDetail)

    '            WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงานต้นทุนเมล็ดพันธุ์", ReportData.SeedYear, ReportData.SentDate, ReportData.SentBy)

    '            trans.Commit()

    '            Return "Success"

    '        Catch ex As Exception
    '            trans.Rollback()
    '            WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataAccCost", ex.Message)
    '            Return "Fail"
    '        Finally
    '            trans.Dispose()
    '            objConnection.Close()
    '        End Try
    '    Else
    '        Return "Invalid Secure ID"
    '    End If

    'End Function

    '<WebMethod(Description:="ส่งรายงาน เบิกจ่ายเกษตรกร", EnableSession:=False)> _
    'Public Function SubmitDataPayDate(SecureID As String, ReportData As PayDateHeader) As String

    '    If SecureID = SecureCode Then

    '        Dim objConnection As New SqlClient.SqlConnection(strConnection)

    '        If objConnection.State = ConnectionState.Closed Then
    '            objConnection.Open()
    '        End If

    '        Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

    '        Try
    '            '//Insert Header
    '            Dim headerNo As Integer = WebserviceDBController.InsertPayDateHeader(trans, ReportData)
    '            '//Insert Detail
    '            WebserviceDBController.InsertPayDateDetail(trans, headerNo, ReportData.PayDateDetails)
    '            WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงานเบิกจ่ายเงินให้เกษตรกร", ReportData.SeedYear, ReportData.SentDate, ReportData.SentBy)

    '            trans.Commit()

    '            Return "Success"

    '        Catch ex As Exception
    '            trans.Rollback()
    '            WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataPayDate", ex.Message)
    '            Return "Fail"
    '        Finally
    '            trans.Dispose()
    '            objConnection.Close()
    '        End Try
    '    Else
    '        Return "Invalid Secure ID"
    '    End If

    'End Function

#Region "================== สรุปแผนและผลการดำเนินงานตามกิจกรรมในกระบวนการผลิตเมล็ดพันธุ์ ===================="
    <WebMethod(Description:="ส่งรายงานสรุปแผนและผลการดำเนินงานตามกิจกรรม", EnableSession:=False)> _
    Public Function SubmitDataQualityActivityReport(SecureID As String, ReportData As QualityActivityHeader) As String '

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertReportQualityActivityHeader(trans, ReportData)
                '//Insert Detail
                WebserviceDBController.InsertReportQualityActivityDetail(trans, headerNo, ReportData.QualityActivityDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "สรุปแผนและผลการดำเนินงานตามกิจกรรม", ReportData.SeedYear, ReportData.SubmitDate, ReportData.SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataQualityActivityReport", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function
#End Region


#Region "SIMS Functions"
    <WebMethod(Description:="ส่งข้อมูลการรับเมล็ดพันธุ์", EnableSession:=False)> _
    Public Function SubmitReceiveSeed(SecureID As String, Data As ReceiveSeed) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = SimsDBController.InsertReceiveSeed(trans, Data)
                '//Insert Detail
                SimsDBController.InsertReceiveSeedDeatil(trans, headerNo, Data.ReceiveSeedDetails)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitReceiveSeed", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function
#End Region

    '//============================================================================================

    <WebMethod(Description:="ส่งรายงาน งบทดลอง", EnableSession:=False)> _
    Public Function SubmitDataTrialBalance(SecureID As String, ReportData As TrialBalanceHeader) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertTrialBalanceHeader(trans, ReportData)
                '//Insert Detail
                WebserviceDBController.InsertTrialBalanceDetail(trans, headerNo, ReportData.TrialBalanceDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงาน งบทดลองรายศูนย์", ReportData.Year, ReportData.Month, ReportData.SentDate, ReportData.SentBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataTrialBalance", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน เบิกจ่ายเกษตรกร", EnableSession:=False)> _
    Public Function SubmitDataPayDate(SecureID As String, ReportData As PayDateHeader) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertPayDateHeader(trans, ReportData)
                '//Insert Detail
                WebserviceDBController.InsertPayDateDetail(trans, headerNo, ReportData.PayDateDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงาน สรุปการเบิกจ่ายเงินให้เกษตรกร", ReportData.FiscalYear, ReportData.SeedMonth, ReportData.SentDate, ReportData.SentBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataPayDate", ex.Message)
                trans.Rollback()
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน ต้นทุนเมล็ดพันธุ์", EnableSession:=False)> _
    Public Function SubmitDataAccCost(SecureID As String, ReportData As AccCostHeader) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertAccCostHeader(trans, ReportData)
                '//Insert Detail
                WebserviceDBController.InsertAccCostDetail(trans, headerNo, ReportData.AccCostDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงาน สรุปต้นทุนเมล็ดพันธุ์", ReportData.SeedYear, ReportData.SeedMonth, ReportData.SentDate, ReportData.SentBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataAccCost", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน งบทดลองรายเดือน", EnableSession:=False)> _
    Public Function SubmitDataTrialBalanceMonth(SecureID As String, ReportData As TrialBalanceMonthHeader) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertTrialBalanceMonthHeader(trans, ReportData)
                '//Insert Detail
                WebserviceDBController.InsertTrialBalanceMonthDetail(trans, headerNo, ReportData.TrialBalanceMonthDetail)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงาน งบทดลองรายเดือน", ReportData.BalanceYear, ReportData.BalanceMonth, ReportData.SentDate, ReportData.SentBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataTrialBalanceMonth", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน สงป.302", EnableSession:=False)> _
    Public Function SubmitDataPlanBudget02(SecureID As String, ReportData As PlanBudgetHeader02) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertPlanBudgetHeader02(trans, ReportData)
                '//Insert Detail
                WebserviceDBController.InsertPlanBudgetDetail02(trans, headerNo, ReportData.PlanBudgetDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงาน สงป. ", ReportData.BudgetYear, ReportData.BudgetMonth, ReportData.SentDate, ReportData.SentBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataPlanBudget02", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน แผนการรับ - จ่าย เงินประจำปีงบประมาณ", EnableSession:=False)> _
    Public Function SubmitDataTrialBalanceTransfer(SecureID As String, ReportData As PlanTrialBalanceTransfer03) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertPlanTransferHeader(trans, ReportData)
                '//Insert Detail
                WebserviceDBController.InsertPlanTransferDetailIncome(trans, headerNo, ReportData.PlanTransferDetailIncome)
                WebserviceDBController.InsertPlanTransferDetailExpenses(trans, headerNo, ReportData.PlanTransferDetailExpend)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงาน แผนการรับ - จ่าย เงินประจำปีงบประมาณ", ReportData.PlanYear, ReportData.SentDate, ReportData.SentBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataTrialBalanceTransfer", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ส่งรายงาน ผลการรับ - จ่าย เงินประจำเดือน", EnableSession:=False)> _
    Public Function SubmitDataIncomeAndExpensesMonth(SecureID As String, ReportData As ResultIncomeAndExpensesMonth) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertResultIncomeAndExpensesMonthHeader(trans, ReportData)
                '//Insert Detail
                WebserviceDBController.InsertResultMonthDetailIncome(trans, headerNo, ReportData.ResultMonthDetailIncome)
                WebserviceDBController.InsertResultMonthDetailExpenses(trans, headerNo, ReportData.ResultMonthDetailExpenses)
                WebserviceDBController.InsertAccountGFMISDetailRV(trans, headerNo, ReportData.AccountGFMISDetailRV)
                WebserviceDBController.InsertAccountGFMISDetailPV(trans, headerNo, ReportData.AccountGFMISDetailPV)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงาน รายรับ - รายจ่าย  (งท.03)", ReportData.ResultYear, ReportData.ResultMonth, 1, ReportData.SentDate, ReportData.SentBy)

                Dim UpdateSQL As String = "update CheckSubmitReportLog set StatusCheck = 1 " & _
                                     "where SiteNo = @SiteNo and " & _
                                     "	  ReportName = @ReportName and " & _
                                     "	  ReportYear = @ReportYear and " & _
                                     "	  ReportMonth = @ReportMonth"

                Dim prm(3) As SqlClient.SqlParameter
                prm(0) = New SqlParameter("@SiteNo", ReportData.SiteNo)
                prm(1) = New SqlParameter("@ReportName", "6bf906ad-9e7b-4418-827f-8b7bf7f16bfc")
                prm(2) = New SqlParameter("@ReportYear", ReportData.ResultYear)
                prm(3) = New SqlParameter("@ReportMonth", ReportData.ResultMonth)
                Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(strConnection, CommandType.Text, UpdateSQL, prm)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataIncomeAndExpensesMonth", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    <WebMethod(Description:="ตรวสอบสถานะเปิด/ปิด", EnableSession:=False)> _
    Public Function CheckCanSubmit(SiteNo As String, ReportName As String, ReportMonth As Integer, ReportYear As String, ReportQuarter As Integer) As Boolean
        'Dim ObjectSpace As IObjectSpace
        'ObjectSpace = WebApplication.Instance.CreateObjectSpace

        Dim SQL As String = "SELECT c.StatusCheck  FROM  dbo.CheckSubmitReportLog AS c left outer JOIN dbo.SettingReportName AS s ON c.ReportName = s.Oid " & _
                                        "where c.SiteNo = @SiteNo and " & _
                                        "	  s.ReportName = @ReportName and " & _
                                        "	  c.ReportYear = @ReportYear and " & _
                                        "	  c.ReportMonth = @ReportMonth and " & _
                                        "     c.ReportQuarter = @ReportQuarter"
        Dim prm(4) As SqlClient.SqlParameter
        prm(0) = New SqlParameter("@SiteNo", SiteNo)
        prm(1) = New SqlParameter("@ReportName", ReportName)
        prm(2) = New SqlParameter("@ReportYear", ReportYear)
        prm(3) = New SqlParameter("@ReportMonth", ReportMonth)
        prm(4) = New SqlParameter("@ReportQuarter", ReportQuarter)

        Dim ds As DataSet = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(strConnection, CommandType.Text, SQL, prm)
        Dim ret As Boolean = False

        Dim daysOfMonth As Integer = 0
        Dim sDate As New Date
        Dim eDate As New Date
        Dim sMonth As Integer = 0
        Dim eMonth As Integer = 0
        If ReportName = "รายงาน รายไตรมาส (งบดุล งบรายได้ค่าใช้จ่าย)" Then
            Select Case ReportQuarter
                Case "1"
                    sMonth = 12
                    eMonth = 1
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 544, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 544, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 15)
                Case "2"
                    sMonth = 3
                    eMonth = 4
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 15)
                Case "3"
                    sMonth = 6
                    eMonth = 7
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 15)
                Case "4"
                    sMonth = 9
                    eMonth = 10
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 15)
            End Select
        ElseIf ReportName = "รายงาน รายรับ - รายจ่าย  (งท.03)" Then
            Select Case ReportMonth
                Case 1
                    sMonth = 12
                    eMonth = 1
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 544, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 544, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 5)
                Case 2
                    sMonth = 1
                    eMonth = 2
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 5)
                Case 3
                    sMonth = 2
                    eMonth = 3
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 5)
                Case 4
                    sMonth = 3
                    eMonth = 4
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 5)
                Case 5
                    sMonth = 4
                    eMonth = 5
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 5)
                Case 6
                    sMonth = 5
                    eMonth = 6
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 5)
                Case 7
                    sMonth = 6
                    eMonth = 7
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 5)
                Case 8
                    sMonth = 7
                    eMonth = 8
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 5)
                Case 9
                    sMonth = 8
                    eMonth = 9
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 543, CInt(eMonth), 5)
                Case 10
                    sMonth = 9
                    eMonth = 10
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 544, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 544, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 544, CInt(eMonth), 5)
                Case 11
                    sMonth = 10
                    eMonth = 11
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 544, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 544, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 544, CInt(eMonth), 5)
                Case 12
                    sMonth = 11
                    eMonth = 12
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 544, (sMonth))
                    sDate = New Date(CInt(ReportYear) - 544, CInt(sMonth), daysOfMonth)
                    eDate = New Date(CInt(ReportYear) - 544, CInt(eMonth), 5)
            End Select
        Else
            Select Case ReportMonth
                Case 1
                    sMonth = 1
                    eMonth = 1
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 543, CUInt(eMonth), daysOfMonth)
                Case 2
                    sMonth = 2
                    eMonth = 2
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 543, CUInt(eMonth), daysOfMonth)
                Case 3
                    sMonth = 3
                    eMonth = 3
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 543, CUInt(eMonth), daysOfMonth)
                Case 4
                    sMonth = 4
                    eMonth = 4
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 543, CUInt(eMonth), daysOfMonth)
                Case 5
                    sMonth = 5
                    eMonth = 5
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 543, CUInt(eMonth), daysOfMonth)
                Case 6
                    sMonth = 6
                    eMonth = 6
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 543, CUInt(eMonth), daysOfMonth)
                Case 7
                    sMonth = 7
                    eMonth = 7
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 543, CUInt(eMonth), daysOfMonth)
                Case 8
                    sMonth = 8
                    eMonth = 8
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 543, CUInt(eMonth), daysOfMonth)
                Case 9
                    sMonth = 9
                    eMonth = 9
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 543, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 543, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 543, CUInt(eMonth), daysOfMonth)
                Case 10
                    sMonth = 10
                    eMonth = 10
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 544, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 544, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 544, CUInt(eMonth), daysOfMonth)
                Case 11
                    sMonth = 11
                    eMonth = 11
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 544, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 544, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 544, CUInt(eMonth), daysOfMonth)
                Case 12
                    sMonth = 12
                    eMonth = 12
                    daysOfMonth = DateTime.DaysInMonth(CInt(ReportYear) - 544, (eMonth))
                    sDate = New Date(CInt(ReportYear) - 544, CInt(sMonth), 24)
                    eDate = New Date(CInt(ReportYear) - 544, CUInt(eMonth), daysOfMonth)

            End Select
        End If
        If Date.Today.AddYears(543) > sDate And Date.Today.AddYears(543) <= eDate Then
            ret = True
        Else
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0).Item("StatusCheck").ToString = "0" Then
                    ret = True
                End If
            End If
        End If

        Return ret

    End Function

    <WebMethod(Description:="ส่งรายงาน งบทดลองรายไตรมาส", EnableSession:=False)> _
    Public Function SubmitDataTrialBalanceQuarter(SecureID As String, ReportData As TrialBalanceQuarterHeader) As String

        If SecureID = SecureCode Then


            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertTrialBalanceQuarterHeader(trans, ReportData)
                '//Insert Detail
                WebserviceDBController.InsertTrialBalanceQuarterDetail(trans, headerNo, ReportData.TrialBalanceQuarterDetail)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงาน รายไตรมาส (งบดุล งบรายได้ค่าใช้จ่าย)", ReportData.BalanceYear, 1, ReportData.BalanceQuarter, ReportData.SentDate, ReportData.SentBy)

                '//ตรวจสอบวันที่ 

                Dim UpdateSQL As String = "update CheckSubmitReportLog set StatusCheck = 1 " & _
                                        "where SiteNo = @SiteNo and " & _
                                        "	  ReportName = (select Oid from SettingReportName where  ReportName=@ReportName and GCRecord is null ) and " & _
                                        "	  ReportYear = @ReportYear and " & _
                                        "	  ReportQuarter = @ReportQuarter"

                Dim prm(3) As SqlClient.SqlParameter
                prm(0) = New SqlParameter("@SiteNo", ReportData.SiteNo)
                prm(1) = New SqlParameter("@ReportName", "รายงาน รายไตรมาส (งบดุล งบรายได้ค่าใช้จ่าย)")
                prm(2) = New SqlParameter("@ReportYear", ReportData.BalanceYear)
                prm(3) = New SqlParameter("@ReportQuarter", ReportData.BalanceQuarter)

                Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(strConnection, CommandType.Text, UpdateSQL, prm)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataTrialBalanceQuarter", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function


    <WebMethod(Description:="ส่งรายงาน สงป.301", EnableSession:=False)> _
    Public Function SubmitDataPlanBudget(SecureID As String, ReportData As PlanBudgetHeader01) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try
                '//Insert Header
                Dim headerNo As Integer = WebserviceDBController.InsertPlanBudgetHeader01(trans, ReportData)
                '//Insert Detail
                WebserviceDBController.InsertPlanBudgetDetails(trans, headerNo, ReportData.PlanBudgetDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, ReportData.SiteNo, ReportData.SiteName, "รายงาน สงป.", ReportData.PlanYear, ReportData.PlanMonth, ReportData.SentDate, ReportData.SentBy)

                Dim UpdateSQL As String = "update CheckSubmitReportLog set StatusCheck = 1 " & _
                                       "where SiteNo = @SiteNo and " & _
                                       "	  ReportName = @ReportName and " & _
                                       "	  ReportYear = @ReportYear and " & _
                                       "	  ReportMonth = @ReportMonth"

                Dim prm(3) As SqlClient.SqlParameter
                prm(0) = New SqlParameter("@SiteNo", ReportData.SiteNo)
                prm(1) = New SqlParameter("@ReportName", "a76015c7-5296-49ee-8808-af89b5dd7b03")
                prm(2) = New SqlParameter("@ReportYear", ReportData.PlanYear)
                prm(3) = New SqlParameter("@ReportMonth", ReportData.PlanMonth)

                Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(strConnection, CommandType.Text, UpdateSQL, prm)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitDataPlanBudget", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

    '//============================================================================================

    <WebMethod(Description:="ส่งรายงาน กคภ2556/02", EnableSession:=False)> _
    Public Function SubmitCheckQualityReport(SecureID As String, CheckQualityData As CheckQualityHeader) As String

        If SecureID = SecureCode Then

            Dim objConnection As New SqlClient.SqlConnection(strConnection)

            If objConnection.State = ConnectionState.Closed Then
                objConnection.Open()
            End If

            Dim trans As SqlClient.SqlTransaction = objConnection.BeginTransaction

            Try

                Dim headerNo As Integer = WebserviceDBController.InsertReportCheckQualityHeader(trans, CheckQualityData)

                WebserviceDBController.InsertReportCheckQualityDetail(trans, headerNo, CheckQualityData.CheckQualityDetails)

                WebserviceDBController.InsertSubmitReportLog(trans, CheckQualityData.SiteNo, CheckQualityData.SiteName, "ส่งรายงาน กคภ2556/02", CheckQualityData.SeedYear, CheckQualityData.SubmitDate, CheckQualityData.SubmitBy)

                trans.Commit()

                Return "Success"

            Catch ex As Exception
                trans.Rollback()
                WebserviceDBController.InsertErrorLog(strConnection, "SubmitCheckQualityReport", ex.Message)
                Return "Fail"
            Finally
                trans.Dispose()
                objConnection.Close()
            End Try
        Else
            Return "Invalid Secure ID"
        End If

    End Function

End Class