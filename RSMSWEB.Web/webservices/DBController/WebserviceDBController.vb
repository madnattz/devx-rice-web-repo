Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class WebserviceDBController

    Public Sub New()

    End Sub

    Public Shared Sub InsertErrorLog(conn As String, decription As String, error_log As String)
        Dim cmd As String = "SP_WebServiceErrorLog_Insert"
        Dim prm(2) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@decription", decription)
        prm(1) = New SqlClient.SqlParameter("@error_log", error_log)

        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, cmd, prm)

    End Sub

    Public Shared Sub InsertSubmitReportLog(sqlTransaction As SqlClient.SqlTransaction, SiteNo As String, SiteName As String, ReportName As String, ReportYear As String, ReportDate As DateTime, ReportBy As String)
        Dim cmd As String = "SP_InsertSubmitReportLog_plan"
        Dim prm(5) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", SiteName)
        prm(2) = New SqlClient.SqlParameter("@ReportName", ReportName)
        prm(3) = New SqlClient.SqlParameter("@ReportYear", ReportYear)
        prm(4) = New SqlClient.SqlParameter("@ReportDate", ReportDate)
        prm(5) = New SqlClient.SqlParameter("@ReportBy", ReportBy)

        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Sub

    '//-------------------------------------- ขพ.2 ------------------------------------------
    Public Shared Function InsertKP2Header(sqlTransaction As SqlClient.SqlTransaction, objReportData As KP2ReportData) As Integer
        Dim cmd As String = "SP_InsertReportKP2Header"
        Dim prm(9) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@PlantName", objReportData.PlantName)
        prm(3) = New SqlClient.SqlParameter("@SeedTypeName", objReportData.SeedTypeName)
        prm(4) = New SqlClient.SqlParameter("@SeedClassName", objReportData.SeedClassName)
        prm(5) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(6) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(7) = New SqlClient.SqlParameter("@SeedLot", objReportData.SeedLot)
        prm(8) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(9) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertKP2Detail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of KP2ReportDetail))
        For Each item As KP2ReportDetail In objDetails
            Dim cmd As String = "SP_InsertReportKP2Detail"
            Dim prm(14) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@FarmerNo", item.FarmerNo)
            prm(2) = New SqlClient.SqlParameter("@FarmerName", item.FarmerName)
            prm(3) = New SqlClient.SqlParameter("@FarmerGroupNo", item.FarmerGroupNo)
            prm(4) = New SqlClient.SqlParameter("@FarmerGroupName", item.FarmerGroupName)
            prm(5) = New SqlClient.SqlParameter("@AddressNo", item.AddressNo)
            prm(6) = New SqlClient.SqlParameter("@Moo", item.Moo)
            prm(7) = New SqlClient.SqlParameter("@Tambol", item.Tambol)
            prm(8) = New SqlClient.SqlParameter("@Amphur", item.Amphur)
            prm(9) = New SqlClient.SqlParameter("@Province", item.Province)
            prm(10) = New SqlClient.SqlParameter("@AreaSize", item.AreaSize)
            prm(11) = New SqlClient.SqlParameter("@SeedUseQuantity", item.SeedUseQuantity)
            prm(12) = New SqlClient.SqlParameter("@SeedGoalQuantity", item.SeedGoalQuantity)
            prm(13) = New SqlClient.SqlParameter("@SeedSource", item.SeedSource)
            prm(14) = New SqlClient.SqlParameter("@IsMaxBuyFarmer", item.IsMaxBuyFarmer)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub
    '//--------------------------------------End ขพ.2 ------------------------------------------

    '//-------------------------------------- ขพ.3 ------------------------------------------
    Public Shared Function InsertKP3Header(sqlTransaction As SqlClient.SqlTransaction, objReportData As KP3ReportData) As Integer
        Dim cmd As String = "SP_InsertReportKP3Header"
        Dim prm(9) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@PlantName", objReportData.PlantName)
        prm(3) = New SqlClient.SqlParameter("@SeedTypeName", objReportData.SeedTypeName)
        prm(4) = New SqlClient.SqlParameter("@SeedClassName", objReportData.SeedClassName)
        prm(5) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(6) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(7) = New SqlClient.SqlParameter("@SeedLot", objReportData.SeedLot)
        prm(8) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(9) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertKP3Detail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of KP3ReportDetail))
        For Each item As KP3ReportDetail In objDetails
            Dim cmd As String = "SP_InsertReportKP3Detail"
            Dim prm(31) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@FarmerNo", item.FarmerNo)
            prm(2) = New SqlClient.SqlParameter("@FarmerName", item.FarmerName)
            prm(3) = New SqlClient.SqlParameter("@FarmerGroupNo", item.FarmerGroupNo)
            prm(4) = New SqlClient.SqlParameter("@FarmerGroupName", item.FarmerGroupName)
            prm(5) = New SqlClient.SqlParameter("@AddressNo", item.AddressNo)
            prm(6) = New SqlClient.SqlParameter("@Moo", item.Moo)
            prm(7) = New SqlClient.SqlParameter("@Tambol", item.Tambol)
            prm(8) = New SqlClient.SqlParameter("@Amphur", item.Amphur)
            prm(9) = New SqlClient.SqlParameter("@Province", item.Province)
            prm(10) = New SqlClient.SqlParameter("@GroupAddressNo", item.GroupAddressNo)
            prm(11) = New SqlClient.SqlParameter("@GroupMoo", item.GroupMoo)
            prm(12) = New SqlClient.SqlParameter("@GroupTambol", item.GroupTambol)
            prm(13) = New SqlClient.SqlParameter("@GroupAmphur", item.GroupAmphur)
            prm(14) = New SqlClient.SqlParameter("@GroupProvince", item.GroupProvince)
            prm(15) = New SqlClient.SqlParameter("@AreaSize", item.AreaSize)
            prm(16) = New SqlClient.SqlParameter("@SeedReceiveQuantity", item.SeedRecieveQuantity)
            prm(17) = New SqlClient.SqlParameter("@SeedUseQuantity", item.SeedUseQuantity)
            prm(18) = New SqlClient.SqlParameter("@SeedGoalQuantity", item.SeedGoalQuantity)
            prm(19) = New SqlClient.SqlParameter("@GrowStartDate", item.GrowStartDate)
            prm(20) = New SqlClient.SqlParameter("@GrowEndDate", item.GrowEndDate)
            prm(21) = New SqlClient.SqlParameter("@CheckFarmStartDate", item.CheckFarmStartDate)
            prm(22) = New SqlClient.SqlParameter("@CheckFarmEndDate", item.CheckFarmEndDate)
            prm(23) = New SqlClient.SqlParameter("@HarvestStartDate", item.HarvestStartDate)
            prm(24) = New SqlClient.SqlParameter("@HarvestEndDate", item.HarvestEndDate)
            prm(25) = New SqlClient.SqlParameter("@BuyStartDate", item.BuyStartDate)
            prm(26) = New SqlClient.SqlParameter("@BuyEndDate", item.BuyEndDate)
            prm(27) = New SqlClient.SqlParameter("@ProcessStartDate", item.ProcessStartDate)
            prm(28) = New SqlClient.SqlParameter("@ProcessEndDate", item.ProcessEndDate)
            prm(29) = New SqlClient.SqlParameter("@MarketStartDate", item.MarketStartDate)
            prm(30) = New SqlClient.SqlParameter("@MarketEndDate", item.MarketEndDate)
            prm(31) = New SqlClient.SqlParameter("@IsMaxBuyFarmer", item.IsMaxBuyFarmer)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub
    '//--------------------------------------End ขพ.3 ------------------------------------------

    '//-------------------------------------- ขพ.5 ------------------------------------------
    Public Shared Function InsertKP5Header(sqlTransaction As SqlClient.SqlTransaction, objReportData As KP5ReportData) As Integer
        Dim cmd As String = "SP_InsertReportKP5Header"
        Dim prm(9) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@PlantName", objReportData.PlantName)
        prm(3) = New SqlClient.SqlParameter("@SeedTypeName", objReportData.SeedTypeName)
        prm(4) = New SqlClient.SqlParameter("@SeedClassName", objReportData.SeedClassName)
        prm(5) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(6) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(7) = New SqlClient.SqlParameter("@SeedLot", objReportData.SeedLot)
        prm(8) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(9) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertKP5Detail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of KP5ReportDetail))
        For Each item As KP5ReportDetail In objDetails
            Dim cmd As String = "SP_InsertReportKP5Detail"
            Dim prm(14) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@FarmerNo", item.FarmerNo)
            prm(2) = New SqlClient.SqlParameter("@FarmerName", item.FarmerName)
            prm(3) = New SqlClient.SqlParameter("@FarmerGroupNo", item.FarmerGroupNo)
            prm(4) = New SqlClient.SqlParameter("@FarmerGroupName", item.FarmerGroupName)
            prm(5) = New SqlClient.SqlParameter("@AddressNo", item.AddressNo)
            prm(6) = New SqlClient.SqlParameter("@Moo", item.Moo)
            prm(7) = New SqlClient.SqlParameter("@Tambol", item.Tambol)
            prm(8) = New SqlClient.SqlParameter("@Amphur", item.Amphur)
            prm(9) = New SqlClient.SqlParameter("@Province", item.Province)
            prm(10) = New SqlClient.SqlParameter("@AreaSize", item.AreaSize)
            prm(11) = New SqlClient.SqlParameter("@QuantityPerUnit", item.QuantityPerUnit)
            prm(12) = New SqlClient.SqlParameter("@BuyQuantity", item.BuyQuantity)
            prm(13) = New SqlClient.SqlParameter("@SeedPrice", item.SeedPrice)
            prm(14) = New SqlClient.SqlParameter("@IsMaxBuyFarmer", item.IsMaxBuyFarmer)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub
    '//--------------------------------------End ขพ.5 ------------------------------------------

    '//-------------------------------------- รายงานแผนและผลการจัดทำแปลง ------------------------------------------
    Public Shared Function InsertActivityPlanReportHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As ActivityPlanReportData) As Integer
        Dim cmd As String = "SP_InsertReportActivityPlanHeader"
        Dim prm(14) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@PlantName", objReportData.PlantName)
        prm(3) = New SqlClient.SqlParameter("@SeedTypeName", objReportData.SeedTypeName)
        prm(4) = New SqlClient.SqlParameter("@SeedClassName", objReportData.SeedClassName)
        prm(5) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(6) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(7) = New SqlClient.SqlParameter("@SeedLot", objReportData.SeedLot)
        prm(8) = New SqlClient.SqlParameter("@GoalQuantity", objReportData.GoalQuantity)
        prm(9) = New SqlClient.SqlParameter("@BuyQuantity", objReportData.BuyQuantity)
        prm(10) = New SqlClient.SqlParameter("@TotalAreaSize", objReportData.TotalAreaSize)
        prm(11) = New SqlClient.SqlParameter("@TotalFarmerGroup", objReportData.TotalFarmerGroup)
        prm(12) = New SqlClient.SqlParameter("@TotalFarmer", objReportData.TotalFarmer)
        prm(13) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(14) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertGrowPlanDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of GrowPlanDetail))
        For Each item As GrowPlanDetail In objDetails
            Dim cmd As String = "SP_InsertReportGrowPlanDetail"
            Dim prm(50) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@StartDate", item.StartDate)
            prm(2) = New SqlClient.SqlParameter("@EndDate", item.EndDate)
            prm(3) = New SqlClient.SqlParameter("@Oct1_2Plan", item.Oct1_2Plan)
            prm(4) = New SqlClient.SqlParameter("@Oct1_2Result", item.Oct1_2Result)
            prm(5) = New SqlClient.SqlParameter("@Oct3_4Plan", item.Oct3_4Plan)
            prm(6) = New SqlClient.SqlParameter("@Oct3_4Result", item.Oct3_4Result)
            prm(7) = New SqlClient.SqlParameter("@Nov1_2Plan", item.Nov1_2Plan)
            prm(8) = New SqlClient.SqlParameter("@Nov1_2Result", item.Nov1_2Result)
            prm(9) = New SqlClient.SqlParameter("@Nov3_4Plan", item.Nov3_4Plan)
            prm(10) = New SqlClient.SqlParameter("@Nov3_4Result", item.Nov3_4Result)
            prm(11) = New SqlClient.SqlParameter("@Dec1_2Plan", item.Dec1_2Plan)
            prm(12) = New SqlClient.SqlParameter("@Dec1_2Result", item.Dec1_2Result)
            prm(13) = New SqlClient.SqlParameter("@Dec3_4Plan", item.Dec3_4Plan)
            prm(14) = New SqlClient.SqlParameter("@Dec3_4Result", item.Dec3_4Result)
            prm(15) = New SqlClient.SqlParameter("@Jan1_2Plan", item.Jan1_2Plan)
            prm(16) = New SqlClient.SqlParameter("@Jan1_2Result", item.Jan1_2Result)
            prm(17) = New SqlClient.SqlParameter("@Jan3_4Plan", item.Jan3_4Plan)
            prm(18) = New SqlClient.SqlParameter("@Jan3_4Result", item.Jan3_4Result)
            prm(19) = New SqlClient.SqlParameter("@Feb1_2Plan", item.Feb1_2Plan)
            prm(20) = New SqlClient.SqlParameter("@Feb1_2Result", item.Feb1_2Result)
            prm(21) = New SqlClient.SqlParameter("@Feb3_4Plan", item.Feb3_4Plan)
            prm(22) = New SqlClient.SqlParameter("@Feb3_4Result", item.Feb3_4Result)
            prm(23) = New SqlClient.SqlParameter("@Mar1_2Plan", item.Mar1_2Plan)
            prm(24) = New SqlClient.SqlParameter("@Mar1_2Result", item.Mar1_2Result)
            prm(25) = New SqlClient.SqlParameter("@Mar3_4Plan", item.Mar3_4Plan)
            prm(26) = New SqlClient.SqlParameter("@Mar3_4Result", item.Mar3_4Result)
            prm(27) = New SqlClient.SqlParameter("@Apr1_2Plan", item.Apr1_2Plan)
            prm(28) = New SqlClient.SqlParameter("@Apr1_2Result", item.Apr1_2Result)
            prm(29) = New SqlClient.SqlParameter("@Apr3_4Plan", item.Apr3_4Plan)
            prm(30) = New SqlClient.SqlParameter("@Apr3_4Result", item.Apr3_4Result)
            prm(31) = New SqlClient.SqlParameter("@May1_2Plan", item.May1_2Plan)
            prm(32) = New SqlClient.SqlParameter("@May1_2Result", item.May1_2Result)
            prm(33) = New SqlClient.SqlParameter("@May3_4Plan", item.May3_4Plan)
            prm(34) = New SqlClient.SqlParameter("@May3_4Result", item.May3_4Result)
            prm(35) = New SqlClient.SqlParameter("@Jun1_2Plan", item.Jun1_2Plan)
            prm(36) = New SqlClient.SqlParameter("@Jun1_2Result", item.Jun1_2Result)
            prm(37) = New SqlClient.SqlParameter("@Jun3_4Plan", item.Jun3_4Plan)
            prm(38) = New SqlClient.SqlParameter("@Jun3_4Result", item.Jun3_4Result)
            prm(39) = New SqlClient.SqlParameter("@Jul1_2Plan", item.Jul1_2Plan)
            prm(40) = New SqlClient.SqlParameter("@Jul1_2Result", item.Jul1_2Result)
            prm(41) = New SqlClient.SqlParameter("@Jul3_4Plan", item.Jul3_4Plan)
            prm(42) = New SqlClient.SqlParameter("@Jul3_4Result", item.Jul3_4Result)
            prm(43) = New SqlClient.SqlParameter("@Aug1_2Plan", item.Aug1_2Plan)
            prm(44) = New SqlClient.SqlParameter("@Aug1_2Result", item.Aug1_2Result)
            prm(45) = New SqlClient.SqlParameter("@Aug3_4Plan", item.Aug3_4Plan)
            prm(46) = New SqlClient.SqlParameter("@Aug3_4Result", item.Aug3_4Result)
            prm(47) = New SqlClient.SqlParameter("@Sep1_2Plan", item.Sep1_2Plan)
            prm(48) = New SqlClient.SqlParameter("@Sep1_2Result", item.Sep1_2Result)
            prm(49) = New SqlClient.SqlParameter("@Sep3_4Plan", item.Sep3_4Plan)
            prm(50) = New SqlClient.SqlParameter("@Sep3_4Result", item.Sep3_4Result)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub

    Public Shared Sub InsertHarvestPlanDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of HarvestPlanDetail))
        For Each item As HarvestPlanDetail In objDetails
            Dim cmd As String = "SP_InsertReportHarvestPlanDetail"
            Dim prm(50) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@StartDate", item.StartDate)
            prm(2) = New SqlClient.SqlParameter("@EndDate", item.EndDate)
            prm(3) = New SqlClient.SqlParameter("@Oct1_2Plan", item.Oct1_2Plan)
            prm(4) = New SqlClient.SqlParameter("@Oct1_2Result", item.Oct1_2Result)
            prm(5) = New SqlClient.SqlParameter("@Oct3_4Plan", item.Oct3_4Plan)
            prm(6) = New SqlClient.SqlParameter("@Oct3_4Result", item.Oct3_4Result)
            prm(7) = New SqlClient.SqlParameter("@Nov1_2Plan", item.Nov1_2Plan)
            prm(8) = New SqlClient.SqlParameter("@Nov1_2Result", item.Nov1_2Result)
            prm(9) = New SqlClient.SqlParameter("@Nov3_4Plan", item.Nov3_4Plan)
            prm(10) = New SqlClient.SqlParameter("@Nov3_4Result", item.Nov3_4Result)
            prm(11) = New SqlClient.SqlParameter("@Dec1_2Plan", item.Dec1_2Plan)
            prm(12) = New SqlClient.SqlParameter("@Dec1_2Result", item.Dec1_2Result)
            prm(13) = New SqlClient.SqlParameter("@Dec3_4Plan", item.Dec3_4Plan)
            prm(14) = New SqlClient.SqlParameter("@Dec3_4Result", item.Dec3_4Result)
            prm(15) = New SqlClient.SqlParameter("@Jan1_2Plan", item.Jan1_2Plan)
            prm(16) = New SqlClient.SqlParameter("@Jan1_2Result", item.Jan1_2Result)
            prm(17) = New SqlClient.SqlParameter("@Jan3_4Plan", item.Jan3_4Plan)
            prm(18) = New SqlClient.SqlParameter("@Jan3_4Result", item.Jan3_4Result)
            prm(19) = New SqlClient.SqlParameter("@Feb1_2Plan", item.Feb1_2Plan)
            prm(20) = New SqlClient.SqlParameter("@Feb1_2Result", item.Feb1_2Result)
            prm(21) = New SqlClient.SqlParameter("@Feb3_4Plan", item.Feb3_4Plan)
            prm(22) = New SqlClient.SqlParameter("@Feb3_4Result", item.Feb3_4Result)
            prm(23) = New SqlClient.SqlParameter("@Mar1_2Plan", item.Mar1_2Plan)
            prm(24) = New SqlClient.SqlParameter("@Mar1_2Result", item.Mar1_2Result)
            prm(25) = New SqlClient.SqlParameter("@Mar3_4Plan", item.Mar3_4Plan)
            prm(26) = New SqlClient.SqlParameter("@Mar3_4Result", item.Mar3_4Result)
            prm(27) = New SqlClient.SqlParameter("@Apr1_2Plan", item.Apr1_2Plan)
            prm(28) = New SqlClient.SqlParameter("@Apr1_2Result", item.Apr1_2Result)
            prm(29) = New SqlClient.SqlParameter("@Apr3_4Plan", item.Apr3_4Plan)
            prm(30) = New SqlClient.SqlParameter("@Apr3_4Result", item.Apr3_4Result)
            prm(31) = New SqlClient.SqlParameter("@May1_2Plan", item.May1_2Plan)
            prm(32) = New SqlClient.SqlParameter("@May1_2Result", item.May1_2Result)
            prm(33) = New SqlClient.SqlParameter("@May3_4Plan", item.May3_4Plan)
            prm(34) = New SqlClient.SqlParameter("@May3_4Result", item.May3_4Result)
            prm(35) = New SqlClient.SqlParameter("@Jun1_2Plan", item.Jun1_2Plan)
            prm(36) = New SqlClient.SqlParameter("@Jun1_2Result", item.Jun1_2Result)
            prm(37) = New SqlClient.SqlParameter("@Jun3_4Plan", item.Jun3_4Plan)
            prm(38) = New SqlClient.SqlParameter("@Jun3_4Result", item.Jun3_4Result)
            prm(39) = New SqlClient.SqlParameter("@Jul1_2Plan", item.Jul1_2Plan)
            prm(40) = New SqlClient.SqlParameter("@Jul1_2Result", item.Jul1_2Result)
            prm(41) = New SqlClient.SqlParameter("@Jul3_4Plan", item.Jul3_4Plan)
            prm(42) = New SqlClient.SqlParameter("@Jul3_4Result", item.Jul3_4Result)
            prm(43) = New SqlClient.SqlParameter("@Aug1_2Plan", item.Aug1_2Plan)
            prm(44) = New SqlClient.SqlParameter("@Aug1_2Result", item.Aug1_2Result)
            prm(45) = New SqlClient.SqlParameter("@Aug3_4Plan", item.Aug3_4Plan)
            prm(46) = New SqlClient.SqlParameter("@Aug3_4Result", item.Aug3_4Result)
            prm(47) = New SqlClient.SqlParameter("@Sep1_2Plan", item.Sep1_2Plan)
            prm(48) = New SqlClient.SqlParameter("@Sep1_2Result", item.Sep1_2Result)
            prm(49) = New SqlClient.SqlParameter("@Sep3_4Plan", item.Sep3_4Plan)
            prm(50) = New SqlClient.SqlParameter("@Sep3_4Result", item.Sep3_4Result)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub

    Public Shared Sub InsertBuyPlanDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of BuyPlanDetail))
        For Each item As BuyPlanDetail In objDetails
            Dim cmd As String = "SP_InsertReportBuyPlanDetail"
            Dim prm(50) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@StartDate", item.StartDate)
            prm(2) = New SqlClient.SqlParameter("@EndDate", item.EndDate)
            prm(3) = New SqlClient.SqlParameter("@Oct1_2Plan", item.Oct1_2Plan)
            prm(4) = New SqlClient.SqlParameter("@Oct1_2Result", item.Oct1_2Result)
            prm(5) = New SqlClient.SqlParameter("@Oct3_4Plan", item.Oct3_4Plan)
            prm(6) = New SqlClient.SqlParameter("@Oct3_4Result", item.Oct3_4Result)
            prm(7) = New SqlClient.SqlParameter("@Nov1_2Plan", item.Nov1_2Plan)
            prm(8) = New SqlClient.SqlParameter("@Nov1_2Result", item.Nov1_2Result)
            prm(9) = New SqlClient.SqlParameter("@Nov3_4Plan", item.Nov3_4Plan)
            prm(10) = New SqlClient.SqlParameter("@Nov3_4Result", item.Nov3_4Result)
            prm(11) = New SqlClient.SqlParameter("@Dec1_2Plan", item.Dec1_2Plan)
            prm(12) = New SqlClient.SqlParameter("@Dec1_2Result", item.Dec1_2Result)
            prm(13) = New SqlClient.SqlParameter("@Dec3_4Plan", item.Dec3_4Plan)
            prm(14) = New SqlClient.SqlParameter("@Dec3_4Result", item.Dec3_4Result)
            prm(15) = New SqlClient.SqlParameter("@Jan1_2Plan", item.Jan1_2Plan)
            prm(16) = New SqlClient.SqlParameter("@Jan1_2Result", item.Jan1_2Result)
            prm(17) = New SqlClient.SqlParameter("@Jan3_4Plan", item.Jan3_4Plan)
            prm(18) = New SqlClient.SqlParameter("@Jan3_4Result", item.Jan3_4Result)
            prm(19) = New SqlClient.SqlParameter("@Feb1_2Plan", item.Feb1_2Plan)
            prm(20) = New SqlClient.SqlParameter("@Feb1_2Result", item.Feb1_2Result)
            prm(21) = New SqlClient.SqlParameter("@Feb3_4Plan", item.Feb3_4Plan)
            prm(22) = New SqlClient.SqlParameter("@Feb3_4Result", item.Feb3_4Result)
            prm(23) = New SqlClient.SqlParameter("@Mar1_2Plan", item.Mar1_2Plan)
            prm(24) = New SqlClient.SqlParameter("@Mar1_2Result", item.Mar1_2Result)
            prm(25) = New SqlClient.SqlParameter("@Mar3_4Plan", item.Mar3_4Plan)
            prm(26) = New SqlClient.SqlParameter("@Mar3_4Result", item.Mar3_4Result)
            prm(27) = New SqlClient.SqlParameter("@Apr1_2Plan", item.Apr1_2Plan)
            prm(28) = New SqlClient.SqlParameter("@Apr1_2Result", item.Apr1_2Result)
            prm(29) = New SqlClient.SqlParameter("@Apr3_4Plan", item.Apr3_4Plan)
            prm(30) = New SqlClient.SqlParameter("@Apr3_4Result", item.Apr3_4Result)
            prm(31) = New SqlClient.SqlParameter("@May1_2Plan", item.May1_2Plan)
            prm(32) = New SqlClient.SqlParameter("@May1_2Result", item.May1_2Result)
            prm(33) = New SqlClient.SqlParameter("@May3_4Plan", item.May3_4Plan)
            prm(34) = New SqlClient.SqlParameter("@May3_4Result", item.May3_4Result)
            prm(35) = New SqlClient.SqlParameter("@Jun1_2Plan", item.Jun1_2Plan)
            prm(36) = New SqlClient.SqlParameter("@Jun1_2Result", item.Jun1_2Result)
            prm(37) = New SqlClient.SqlParameter("@Jun3_4Plan", item.Jun3_4Plan)
            prm(38) = New SqlClient.SqlParameter("@Jun3_4Result", item.Jun3_4Result)
            prm(39) = New SqlClient.SqlParameter("@Jul1_2Plan", item.Jul1_2Plan)
            prm(40) = New SqlClient.SqlParameter("@Jul1_2Result", item.Jul1_2Result)
            prm(41) = New SqlClient.SqlParameter("@Jul3_4Plan", item.Jul3_4Plan)
            prm(42) = New SqlClient.SqlParameter("@Jul3_4Result", item.Jul3_4Result)
            prm(43) = New SqlClient.SqlParameter("@Aug1_2Plan", item.Aug1_2Plan)
            prm(44) = New SqlClient.SqlParameter("@Aug1_2Result", item.Aug1_2Result)
            prm(45) = New SqlClient.SqlParameter("@Aug3_4Plan", item.Aug3_4Plan)
            prm(46) = New SqlClient.SqlParameter("@Aug3_4Result", item.Aug3_4Result)
            prm(47) = New SqlClient.SqlParameter("@Sep1_2Plan", item.Sep1_2Plan)
            prm(48) = New SqlClient.SqlParameter("@Sep1_2Result", item.Sep1_2Result)
            prm(49) = New SqlClient.SqlParameter("@Sep3_4Plan", item.Sep3_4Plan)
            prm(50) = New SqlClient.SqlParameter("@Sep3_4Result", item.Sep3_4Result)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub

    '//-----------------------------------------------end-------------------------------------------

    '//-------------------------------------- แบบบันทึกการตรวจตัดสินแปลงขยายพันธุ์ข้าวอย่างเป็นทางการ -----------------------------------------------
    Public Shared Function InsertCheckFarmHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As CheckFarmHeader) As Integer
        Dim cmd As String = "SP_InsertReportCheckFarmHeader"
        Dim prm(9) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@PlantName", objReportData.PlantName)
        prm(3) = New SqlClient.SqlParameter("@SeedTypeName", objReportData.SeedTypeName)
        prm(4) = New SqlClient.SqlParameter("@SeedClassName", objReportData.SeedClassName)
        prm(5) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(6) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(7) = New SqlClient.SqlParameter("@SeedLot", objReportData.SeedLot)
        prm(8) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(9) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

   Public Shared Sub InsertCheckFarmDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of CheckFarmDetail))
        For Each item As CheckFarmDetail In objDetails
            Dim cmd As String = "SP_InsertReportCheckFarmDetail"
            Dim prm(21) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@FarmerNo", item.FarmerNo)
            prm(2) = New SqlClient.SqlParameter("@FarmerName", item.FarmerName)
            prm(3) = New SqlClient.SqlParameter("@GrowAreaSize", item.GrowAreaSize)
            prm(4) = New SqlClient.SqlParameter("@EstimateResultPerArea", item.EstimateResultPerArea)
            prm(5) = New SqlClient.SqlParameter("@CheckPeriod", item.CheckPeriod)
            prm(6) = New SqlClient.SqlParameter("@GrowTypeString", item.GrowTypeString)
            prm(7) = New SqlClient.SqlParameter("@OtherSeedValue", item.OtherSeedValue)
            prm(8) = New SqlClient.SqlParameter("@RedSeedValue", item.RedSeedValue)
            prm(9) = New SqlClient.SqlParameter("@Disease", item.Disease)
            prm(10) = New SqlClient.SqlParameter("@Bug", item.Bug)
            prm(11) = New SqlClient.SqlParameter("@Weed", item.Weed)
            prm(12) = New SqlClient.SqlParameter("@Broken", item.Broken)
            prm(13) = New SqlClient.SqlParameter("@Distance", item.Distance)
            prm(14) = New SqlClient.SqlParameter("@DamageArea", item.DamageArea)
            prm(15) = New SqlClient.SqlParameter("@CheckDate", item.CheckDate)
            prm(16) = New SqlClient.SqlParameter("@CheckResults", item.CheckResults)
            prm(17) = New SqlClient.SqlParameter("@Remark", item.Remark)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub

    '//-------------------------------------- End แบบบันทึกการตรวจตัดสินแปลงขยายพันธุ์ข้าวอย่างเป็นทางการ ------------------------------------------

    '//-------------------------------------- แบบบันทึกการตรวจตัดสินคุณภาพแปลงขยายพันธุ์-----------------------------------------------
    Public Shared Function InsertCheckFarmSummaryHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As CheckFarmSummaryHeader) As Integer
        Dim cmd As String = "SP_InsertReportCheckFarmSummaryHeader"
        Dim prm(10) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@PlantName", objReportData.PlantName)
        prm(3) = New SqlClient.SqlParameter("@SeedTypeName", objReportData.SeedTypeName)
        prm(4) = New SqlClient.SqlParameter("@SeedClassName", objReportData.SeedClassName)
        prm(5) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(6) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(7) = New SqlClient.SqlParameter("@SeedLot", objReportData.SeedLot)
        prm(8) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(9) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)
        prm(10) = New SqlClient.SqlParameter("@Remark", objReportData.Remark)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertCheckFarmSummaryDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of CheckFarmSummaryDetail))
        For Each item As CheckFarmSummaryDetail In objDetails
            Dim cmd As String = "SP_InsertReportCheckFarmSummaryDetail"
            'Dim prm(7) As SqlClient.SqlParameter
            'prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            'prm(1) = New SqlClient.SqlParameter("@MonthNo", item.MonthNo)
            'prm(2) = New SqlClient.SqlParameter("@SeedYear", item.SeedYear)
            'prm(3) = New SqlClient.SqlParameter("@PlanSize", item.PlanSize)
            'prm(4) = New SqlClient.SqlParameter("@CheckSize", item.CheckSize)
            'prm(5) = New SqlClient.SqlParameter("@PassSize", item.PassSize)
            'prm(6) = New SqlClient.SqlParameter("@FullDamageSize", item.FullDamageSize)
            'prm(7) = New SqlClient.SqlParameter("@FailReason", item.FailReason)

            Dim prm(60) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@OctPlanSize", item.OctPlanSize)
            prm(2) = New SqlClient.SqlParameter("@OctCheckSize", item.OctCheckSize)
            prm(3) = New SqlClient.SqlParameter("@OctPassSize", item.OctPassSize)
            prm(4) = New SqlClient.SqlParameter("@OctFullDamageSize", item.OctFullDamageSize)
            prm(5) = New SqlClient.SqlParameter("@OctFailReason", item.OctFailReason)
            prm(6) = New SqlClient.SqlParameter("@NovPlanSize", item.NovPlanSize)
            prm(7) = New SqlClient.SqlParameter("@NovCheckSize", item.NovCheckSize)
            prm(8) = New SqlClient.SqlParameter("@NovPassSize", item.NovPassSize)
            prm(9) = New SqlClient.SqlParameter("@NovFullDamageSize", item.NovFullDamageSize)
            prm(10) = New SqlClient.SqlParameter("@NovFailReason", item.NovFailReason)
            prm(11) = New SqlClient.SqlParameter("@DecPlanSize", item.DecPlanSize)
            prm(12) = New SqlClient.SqlParameter("@DecCheckSize", item.DecCheckSize)
            prm(13) = New SqlClient.SqlParameter("@DecPassSize", item.DecPassSize)
            prm(14) = New SqlClient.SqlParameter("@DecFullDamageSize", item.DecFullDamageSize)
            prm(15) = New SqlClient.SqlParameter("@DecFailReason", item.DecFailReason)
            prm(16) = New SqlClient.SqlParameter("@JanPlanSize", item.JanPlanSize)
            prm(17) = New SqlClient.SqlParameter("@JanCheckSize", item.JanCheckSize)
            prm(18) = New SqlClient.SqlParameter("@JanPassSize", item.JanPassSize)
            prm(19) = New SqlClient.SqlParameter("@JanFullDamageSize", item.JanFullDamageSize)
            prm(20) = New SqlClient.SqlParameter("@JanFailReason", item.JanFailReason)
            prm(21) = New SqlClient.SqlParameter("@FebPlanSize", item.FebPlanSize)
            prm(22) = New SqlClient.SqlParameter("@FebCheckSize", item.FebCheckSize)
            prm(23) = New SqlClient.SqlParameter("@FebPassSize", item.FebPassSize)
            prm(24) = New SqlClient.SqlParameter("@FebFullDamageSize", item.FebFullDamageSize)
            prm(25) = New SqlClient.SqlParameter("@FebFailReason", item.FebFailReason)
            prm(26) = New SqlClient.SqlParameter("@MarPlanSize", item.MarPlanSize)
            prm(27) = New SqlClient.SqlParameter("@MarCheckSize", item.MarCheckSize)
            prm(28) = New SqlClient.SqlParameter("@MarPassSize", item.MarPassSize)
            prm(29) = New SqlClient.SqlParameter("@MarFullDamageSize", item.MarFullDamageSize)
            prm(30) = New SqlClient.SqlParameter("@MarFailReason", item.MarFailReason)
            prm(31) = New SqlClient.SqlParameter("@AprPlanSize", item.AprPlanSize)
            prm(32) = New SqlClient.SqlParameter("@AprCheckSize", item.AprCheckSize)
            prm(33) = New SqlClient.SqlParameter("@AprPassSize", item.AprPassSize)
            prm(34) = New SqlClient.SqlParameter("@AprFullDamageSize", item.AprFullDamageSize)
            prm(35) = New SqlClient.SqlParameter("@AprFailReason", item.AprFailReason)
            prm(36) = New SqlClient.SqlParameter("@MayPlanSize", item.MayPlanSize)
            prm(37) = New SqlClient.SqlParameter("@MayCheckSize", item.MayCheckSize)
            prm(38) = New SqlClient.SqlParameter("@MayPassSize", item.MayPassSize)
            prm(39) = New SqlClient.SqlParameter("@MayFullDamageSize", item.MayFullDamageSize)
            prm(40) = New SqlClient.SqlParameter("@MayFailReason", item.MayFailReason)
            prm(41) = New SqlClient.SqlParameter("@JunPlanSize", item.JunPlanSize)
            prm(42) = New SqlClient.SqlParameter("@JunCheckSize", item.JunCheckSize)
            prm(43) = New SqlClient.SqlParameter("@JunPassSize", item.JunPassSize)
            prm(44) = New SqlClient.SqlParameter("@JunFullDamageSize", item.JunFullDamageSize)
            prm(45) = New SqlClient.SqlParameter("@JunFailReason", item.JunFailReason)
            prm(46) = New SqlClient.SqlParameter("@JulPlanSize", item.JulPlanSize)
            prm(47) = New SqlClient.SqlParameter("@JulCheckSize", item.JulCheckSize)
            prm(48) = New SqlClient.SqlParameter("@JulPassSize", item.JulPassSize)
            prm(49) = New SqlClient.SqlParameter("@JulFullDamageSize", item.JulFullDamageSize)
            prm(50) = New SqlClient.SqlParameter("@JulFailReason", item.JulFailReason)
            prm(51) = New SqlClient.SqlParameter("@AugPlanSize", item.AugPlanSize)
            prm(52) = New SqlClient.SqlParameter("@AugCheckSize", item.AugCheckSize)
            prm(53) = New SqlClient.SqlParameter("@AugPassSize", item.AugPassSize)
            prm(54) = New SqlClient.SqlParameter("@AugFullDamageSize", item.AugFullDamageSize)
            prm(55) = New SqlClient.SqlParameter("@AugFailReason", item.AugFailReason)
            prm(56) = New SqlClient.SqlParameter("@SepPlanSize", item.SepPlanSize)
            prm(57) = New SqlClient.SqlParameter("@SepCheckSize", item.SepCheckSize)
            prm(58) = New SqlClient.SqlParameter("@SepPassSize", item.SepPassSize)
            prm(59) = New SqlClient.SqlParameter("@SepFullDamageSize", item.SepFullDamageSize)
            prm(60) = New SqlClient.SqlParameter("@SepFailReason", item.SepFailReason)
          
            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

        Next

    End Sub

    '//-------------------------------------- End แบบบันทึกการตรวจตัดสินแปลงขยายพันธุ์ข้าวอย่างเป็นทางการ ------------------------------------------
    Public Shared Sub InsertCheckRedSeed(sqlTransaction As SqlClient.SqlTransaction, objReportData As CheckRedSeedData)
        Dim cmd As String = "SP_InsertReportCheckRedSeed"
        Dim prm(43) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(3) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(4) = New SqlClient.SqlParameter("@MainSeedAll", objReportData.MainSeedAll)
        prm(5) = New SqlClient.SqlParameter("@MainSeedNoRedSeed", objReportData.MainSeedNoRedSeed)
        prm(6) = New SqlClient.SqlParameter("@MainSeedRedSeed", objReportData.MainSeedRedSeed)
        prm(7) = New SqlClient.SqlParameter("@Main1", objReportData.Main1)
        prm(8) = New SqlClient.SqlParameter("@Main2", objReportData.Main2)
        prm(9) = New SqlClient.SqlParameter("@Main3", objReportData.Main3)
        prm(10) = New SqlClient.SqlParameter("@Main4", objReportData.Main4)
        prm(11) = New SqlClient.SqlParameter("@Main5", objReportData.Main5)
        prm(12) = New SqlClient.SqlParameter("@Main6_10", objReportData.Main6_10)
        prm(13) = New SqlClient.SqlParameter("@Main11_15", objReportData.Main11_15)
        prm(14) = New SqlClient.SqlParameter("@Main16_20", objReportData.Main16_20)
        prm(15) = New SqlClient.SqlParameter("@Main21_25", objReportData.Main21_25)
        prm(16) = New SqlClient.SqlParameter("@Main26_30", objReportData.Main26_30)
        prm(17) = New SqlClient.SqlParameter("@Main31_40", objReportData.Main31_40)
        prm(18) = New SqlClient.SqlParameter("@Main41_50", objReportData.Main41_50)
        prm(19) = New SqlClient.SqlParameter("@Main51_100", objReportData.Main51_100)
        prm(20) = New SqlClient.SqlParameter("@Main101_150", objReportData.Main101_150)
        prm(21) = New SqlClient.SqlParameter("@Main151_200", objReportData.Main151_200)
        prm(22) = New SqlClient.SqlParameter("@MainMore200", objReportData.MainMore200)
        prm(23) = New SqlClient.SqlParameter("@BuySeedAll", objReportData.BuySeedAll)
        prm(24) = New SqlClient.SqlParameter("@BuySeedNoRedSeed", objReportData.BuySeedNoRedSeed)
        prm(25) = New SqlClient.SqlParameter("@BuySeedRedSeed", objReportData.BuySeedRedSeed)
        prm(26) = New SqlClient.SqlParameter("@Buy1", objReportData.Buy1)
        prm(27) = New SqlClient.SqlParameter("@Buy2", objReportData.Buy2)
        prm(28) = New SqlClient.SqlParameter("@Buy3", objReportData.Buy3)
        prm(29) = New SqlClient.SqlParameter("@Buy4", objReportData.Buy4)
        prm(30) = New SqlClient.SqlParameter("@Buy5", objReportData.Buy5)
        prm(31) = New SqlClient.SqlParameter("@Buy6_10", objReportData.Buy6_10)
        prm(32) = New SqlClient.SqlParameter("@Buy11_15", objReportData.Buy11_15)
        prm(33) = New SqlClient.SqlParameter("@Buy16_20", objReportData.Buy16_20)
        prm(34) = New SqlClient.SqlParameter("@Buy21_25", objReportData.Buy21_25)
        prm(35) = New SqlClient.SqlParameter("@Buy26_30", objReportData.Buy26_30)
        prm(36) = New SqlClient.SqlParameter("@Buy31_40", objReportData.Buy31_40)
        prm(37) = New SqlClient.SqlParameter("@Buy41_50", objReportData.Buy41_50)
        prm(38) = New SqlClient.SqlParameter("@Buy51_100", objReportData.Buy51_100)
        prm(39) = New SqlClient.SqlParameter("@Buy101_150", objReportData.Buy101_150)
        prm(40) = New SqlClient.SqlParameter("@Buy151_200", objReportData.Buy151_200)
        prm(41) = New SqlClient.SqlParameter("@BuyMore200", objReportData.BuyMore200)
        prm(42) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(43) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)

        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Sub


    Public Shared Sub InsertCheckQualityForMonth(sqlTransaction As SqlClient.SqlTransaction, objReportData As CheckQualityForMonthData)
        Dim cmd As String = "SP_InsertReportCheckQualityForMonth"
        Dim prm(32) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@CheckMonthNo", objReportData.CheckMonthNo)
        prm(1) = New SqlClient.SqlParameter("@CheckMonthName", objReportData.CheckMonthName)
        prm(2) = New SqlClient.SqlParameter("@CheckYear", objReportData.CheckYear)
        prm(3) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(4) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(5) = New SqlClient.SqlParameter("@SeedTypeName", objReportData.SeedTypeName)
        prm(6) = New SqlClient.SqlParameter("@SeedClassName", objReportData.SeedClassName)
        prm(7) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(8) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(9) = New SqlClient.SqlParameter("@SeedLot", objReportData.SeedLot)
        prm(10) = New SqlClient.SqlParameter("@StepName", objReportData.StepName)
        prm(11) = New SqlClient.SqlParameter("@SampleCount", objReportData.SampleCount)
        prm(12) = New SqlClient.SqlParameter("@Wet", objReportData.Wet)
        prm(13) = New SqlClient.SqlParameter("@Compound", objReportData.Compound)
        prm(14) = New SqlClient.SqlParameter("@Grow", objReportData.Grow)
        prm(15) = New SqlClient.SqlParameter("@Strong", objReportData.Strong)
        prm(16) = New SqlClient.SqlParameter("@PureSeed", objReportData.PureSeed)
        prm(17) = New SqlClient.SqlParameter("@OtherSeed", objReportData.OtherSeed)
        prm(18) = New SqlClient.SqlParameter("@OtherRice", objReportData.OtherRice)
        prm(19) = New SqlClient.SqlParameter("@RedSeed", objReportData.RedSeed)
        prm(20) = New SqlClient.SqlParameter("@GreenSeed", objReportData.GreenSeed)
        prm(21) = New SqlClient.SqlParameter("@FloatSeed", objReportData.FloatSeed)
        prm(22) = New SqlClient.SqlParameter("@Insect", objReportData.Insect)
        prm(23) = New SqlClient.SqlParameter("@DiseaseSeed", objReportData.DiseaseSeed)
        prm(24) = New SqlClient.SqlParameter("@KOH", objReportData.KOH)
        prm(25) = New SqlClient.SqlParameter("@Iodine", objReportData.Iodine)
        prm(26) = New SqlClient.SqlParameter("@StickySeed", objReportData.StickySeed)
        prm(27) = New SqlClient.SqlParameter("@AATest", objReportData.AATest)
        prm(28) = New SqlClient.SqlParameter("@AllTestCount", objReportData.AllTestCount)
        prm(29) = New SqlClient.SqlParameter("@PassQuantity", objReportData.PassQuantity)
        prm(30) = New SqlClient.SqlParameter("@Remark", objReportData.Remark)
        prm(31) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(32) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)
        
        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Sub

    '//-------------------------------------- แบบแผนสรุปผลการปรับปรุงสภาพเมล็ดพันธุ์รายวัน -----------------------------------------------
    Public Shared Function InsertDailyProcessHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As DailyProcessHeader) As Integer
        Dim cmd As String = "SP_InsertReportDailyProcessHeader"
        Dim prm(7) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@ProcessYear", objReportData.ProcessYear)
        prm(3) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(4) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)
        prm(5) = New SqlClient.SqlParameter("@ProcessWeek", objReportData.ProcessWeek)
        prm(6) = New SqlClient.SqlParameter("@ProcessMonth", objReportData.ProcessMonth)
        prm(7) = New SqlClient.SqlParameter("@ProcessDateFullName", objReportData.ProcessDateFullName)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertDailyProcessDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of DailyProcessDetail))
        For Each item As DailyProcessDetail In objDetails
            Dim cmd As String = "SP_InsertReportDailyProcessDetail"
            Dim prm(12) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@ProcessDate", item.ProcessDate)
            prm(2) = New SqlClient.SqlParameter("@PlantName", item.PlantName)
            prm(3) = New SqlClient.SqlParameter("@SeedName", item.SeedName)
            prm(4) = New SqlClient.SqlParameter("@ClassName", item.ClassName)
            prm(5) = New SqlClient.SqlParameter("@SeasonName", item.SeasonName)
            prm(6) = New SqlClient.SqlParameter("@SeedYear", item.SeedYear)
            prm(7) = New SqlClient.SqlParameter("@OutputQuantity", item.OutputQuantity)
            prm(8) = New SqlClient.SqlParameter("@NormalTime", item.NormalTime)
            prm(9) = New SqlClient.SqlParameter("@OverTime", item.OverTime)
            prm(10) = New SqlClient.SqlParameter("@ShiftTime", item.ShiftTime)
            prm(11) = New SqlClient.SqlParameter("@ImproveComplete", item.ImproveComplete)
            prm(12) = New SqlClient.SqlParameter("@FactoryName", item.FactoryName)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

        Next

    End Sub

    '//-------------------------------------- End แบบแผนสรุปผลการปรับปรุงสภาพเมล็ดพันธุ์รายวัน ------------------------------------------

    '//-------------------------------------- รายงานผลการทดสอบคุณภาพเมล็ดพันธุ์เพื่อจัดซื้อ-----------------------------------------------
    Public Shared Function InsertQualityForBuyHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As QualityForBuyHeader) As Integer
        Dim cmd As String = "SP_InsertReportQualityForBuyHeader"
        Dim prm(9) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@PlantName", objReportData.PlantName)
        prm(3) = New SqlClient.SqlParameter("@SeedTypeName", objReportData.SeedTypeName)
        prm(4) = New SqlClient.SqlParameter("@SeedClassName", objReportData.SeedClassName)
        prm(5) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(6) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(7) = New SqlClient.SqlParameter("@SeedLot", objReportData.SeedLot)
        prm(8) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(9) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertQualityForBuyDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of QualityForBuyDetail))
        For Each item As QualityForBuyDetail In objDetails
            Dim cmd As String = "SP_InsertReportQualityForBuyDetail"
            Dim prm(15) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@SampleNo", item.SampleNo)
            prm(2) = New SqlClient.SqlParameter("@PlanFarmerNo", item.PlanFarmerNo)
            prm(3) = New SqlClient.SqlParameter("@PlanFarmerName", item.PlanFarmerName)
            prm(4) = New SqlClient.SqlParameter("@ClassName", item.ClassName)
            prm(5) = New SqlClient.SqlParameter("@Quantity", item.Quantity)
            prm(6) = New SqlClient.SqlParameter("@WetSeed", item.WetSeed)
            prm(7) = New SqlClient.SqlParameter("@PureSeed", item.PureSeed)
            prm(8) = New SqlClient.SqlParameter("@CompoundSeed", item.CompoundSeed)
            prm(9) = New SqlClient.SqlParameter("@OtherRiceSeed", item.OtherRiceSeed)
            prm(10) = New SqlClient.SqlParameter("@RedSeed", item.RedSeed)
            prm(11) = New SqlClient.SqlParameter("@GrowSeed", item.GrowSeed)
            prm(12) = New SqlClient.SqlParameter("@OtherSeed", item.OtherSeed)
            prm(13) = New SqlClient.SqlParameter("@CheckDate", item.CheckDate)
            prm(14) = New SqlClient.SqlParameter("@CheckResult", item.CheckResult)
            prm(15) = New SqlClient.SqlParameter("@ExampleNo", item.ExampleNo)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

        Next

    End Sub

    '//-------------------------------------- End รายงานผลการทดสอบคุณภาพเมล็ดพันธุ์เพื่อจัดซื้อ ------------------------------------------

    '//-------------------------------------- รายงาน ประวัติคุณภาพเมล็ดพันธุ์-----------------------------------------------
    Public Shared Function InsertQualityHistoryHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As QualityHistoryHeader) As Integer
        Dim cmd As String = "SP_InsertReportQualityHistoryHeader"
        Dim prm(9) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@PlantName", objReportData.PlantName)
        prm(3) = New SqlClient.SqlParameter("@SeedTypeName", objReportData.SeedTypeName)
        prm(4) = New SqlClient.SqlParameter("@SeedClassName", objReportData.SeedClassName)
        prm(5) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(6) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(7) = New SqlClient.SqlParameter("@SeedLot", objReportData.SeedLot)
        prm(8) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(9) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertQualityHistoryDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of QualityHistoryDetail))
        For Each item As QualityHistoryDetail In objDetails
            Dim cmd As String = "SP_InsertReportQualityHistoryDetail"
            Dim prm(18) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@ForBuyWetSeed", item.ForBuyWetSeed)
            prm(2) = New SqlClient.SqlParameter("@ForBuyGrowSeed", item.ForBuyGrowSeed)
            prm(3) = New SqlClient.SqlParameter("@ForBuyRedSeed", item.ForBuyRedSeed)
            prm(4) = New SqlClient.SqlParameter("@ForBuyOtherSeed", item.ForBuyOtherSeed)
            prm(5) = New SqlClient.SqlParameter("@ForBuyCheckDate", item.ForBuyCheckDate)
            prm(6) = New SqlClient.SqlParameter("@BeforeWetSeed", item.BeforeWetSeed)
            prm(7) = New SqlClient.SqlParameter("@BeforeGrowSeed", item.BeforeGrowSeed)
            prm(8) = New SqlClient.SqlParameter("@BeforeCompound", item.BeforeCompound)
            prm(9) = New SqlClient.SqlParameter("@BeforeDate", item.BeforeDate)
            prm(10) = New SqlClient.SqlParameter("@AfterWetSeed", item.AfterWetSeed)
            prm(11) = New SqlClient.SqlParameter("@AfterGrowSeed", item.AfterGrowSeed)
            prm(12) = New SqlClient.SqlParameter("@AfterStrongSeed", item.AfterStrongSeed)
            prm(13) = New SqlClient.SqlParameter("@AfterPureSeed", item.AfterPureSeed)
            prm(14) = New SqlClient.SqlParameter("@AfterCompound", item.AfterCompound)
            prm(15) = New SqlClient.SqlParameter("@AfterRedSeed", item.AfterRedSeed)
            prm(16) = New SqlClient.SqlParameter("@AfterOtherSeed", item.AfterOtherSeed)
            prm(17) = New SqlClient.SqlParameter("@AfterWeight", item.AfterWeight)
            prm(18) = New SqlClient.SqlParameter("@AfterDate", item.AfterDate)


            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub

    '//-------------------------------------- End รายงาน ประวัติคุณภาพเมล็ดพันธุ์ ------------------------------------------

#Region "======================== รายงานผลการตรวจสอบคุณภาพเมล็ดพันธุ์ระหว่างการเก็บรักษา ประจำเดือน (กคภ 06)======================="
    Public Shared Function InsertReportQualityBetweenStorageHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As QualityBetweenStorageHeader) As Integer
        Dim CMD As String = "SP_InsertReportQualityBetweenStorageHeader"
        Dim Prm(5) As SqlClient.SqlParameter
        Prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        Prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        Prm(2) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        Prm(3) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        Prm(4) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        Prm(5) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)
        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, CMD, Prm)


    End Function
    Public Shared Sub InsertReportQualityBetweenStorageDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of QualityBetweenStorageDetail))
        For Each Item As QualityBetweenStorageDetail In objDetails
            Dim Cmd As String = "SP_InsertReportQualityBetweenStorageDetail"
            Dim Prm(16) As SqlClient.SqlParameter
            Prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            Prm(1) = New SqlClient.SqlParameter("@PlantName", Item.PlantName)
            Prm(2) = New SqlClient.SqlParameter("@SeedTypeName", Item.SeedTypeName)
            Prm(3) = New SqlClient.SqlParameter("@SeedClassName", Item.SeedClassName)
            Prm(4) = New SqlClient.SqlParameter("@SeasonName", Item.SeasonName)
            Prm(5) = New SqlClient.SqlParameter("@SeedYear", Item.SeedYear)
            Prm(6) = New SqlClient.SqlParameter("@SeedLot", Item.SeedLot)
            Prm(7) = New SqlClient.SqlParameter("@BuyDate", Item.BuyDate)
            Prm(8) = New SqlClient.SqlParameter("@ProcessDate", Item.ProcessDate)
            Prm(9) = New SqlClient.SqlParameter("@DiffProcessDate", Item.DiffProcessDate)
            Prm(10) = New SqlClient.SqlParameter("@Wet", Item.Wet)
            Prm(11) = New SqlClient.SqlParameter("@Grow", Item.Grow)
            Prm(12) = New SqlClient.SqlParameter("@Strong", Item.Strong)
            Prm(13) = New SqlClient.SqlParameter("@SeedWeight", Item.SeedWeight)
            Prm(14) = New SqlClient.SqlParameter("@LabDate", Item.LabDate)
            Prm(15) = New SqlClient.SqlParameter("@DiffProcess", Item.DiffProcess)
            Prm(16) = New SqlClient.SqlParameter("@DiffMonthBuy", Item.DiffMonthBuy)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, Cmd, Prm)

        Next

    End Sub
#End Region

    '//--------------------------- boy------------------------------

    '//-------------------------------------- งบ ทดลอง------------------------------------------
    'Public Shared Function InsertTrialBalanceHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As TrialBalanceHeader) As Integer
    '    Dim cmd As String = "SP_InsertTrialBalanceHeader"
    '    Dim prm(5) As SqlClient.SqlParameter

    '    'prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
    '    prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
    '    prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
    '    prm(2) = New SqlClient.SqlParameter("@BalanceDate", objReportData.BalanceDate)
    '    prm(3) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
    '    prm(4) = New SqlClient.SqlParameter("@Year", objReportData.Year)
    '    prm(5) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

    '    Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    'End Function

    'Public Shared Sub InsertTrialBalanceDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of TrialBalanceDetail))
    '    For Each item As TrialBalanceDetail In objDetails
    '        Dim cmd As String = "SP_InsertTrialBalanceDetail"
    '        Dim prm(3) As SqlClient.SqlParameter

    '        prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
    '        prm(1) = New SqlClient.SqlParameter("@AccountID", item.AccountID)
    '        prm(2) = New SqlClient.SqlParameter("@AccountName", item.AccountName)
    '        prm(3) = New SqlClient.SqlParameter("@TotalBalance", item.TotalBalance)

    '        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
    '    Next

    'End Sub
    '//--------------------------------------End -----------------------------------------

    '//-------------------------------------- ต้นทุนเมล็ดพันธุ์------------------------------------------
    'Public Shared Function InsertAccCostHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As AccCostHeader) As Integer
    '    Dim cmd As String = "SP_InsertAccCostHeader"
    '    Dim prm(8) As SqlClient.SqlParameter

    '    'prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
    '    prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
    '    prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
    '    prm(2) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
    '    prm(3) = New SqlClient.SqlParameter("@Plant", objReportData.Plant)
    '    prm(4) = New SqlClient.SqlParameter("@Seed", objReportData.Seed)
    '    prm(5) = New SqlClient.SqlParameter("@SeedType", objReportData.SeedType)
    '    prm(6) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
    '    prm(7) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
    '    prm(8) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

    '    Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    'End Function

    Public Shared Sub InsertAccCostDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetail As AccCostDetail)
        Dim cmd As String = "SP_InsertAccCostDetail"
        Dim prm(11) As SqlClient.SqlParameter

        prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
        prm(1) = New SqlClient.SqlParameter("@AmountSeed", objDetail.AmountSeed)
        prm(2) = New SqlClient.SqlParameter("@AmountSeedGood", objDetail.AmountSeedGood)
        prm(3) = New SqlClient.SqlParameter("@AmountSeedOut", objDetail.AmountSeedOut)
        prm(4) = New SqlClient.SqlParameter("@TotalSeed", objDetail.TotalSeed)
        prm(5) = New SqlClient.SqlParameter("@TotalMaterials", objDetail.TotalMaterials)
        prm(6) = New SqlClient.SqlParameter("@TotalOil", objDetail.TotalOil)
        prm(7) = New SqlClient.SqlParameter("@TotalChemical", objDetail.TotalChemical)
        prm(8) = New SqlClient.SqlParameter("@PriceSeedGood", objDetail.PriceSeedGood)
        prm(9) = New SqlClient.SqlParameter("@PriceSeedOutUsage", objDetail.PriceSeedOutUsage)
        prm(10) = New SqlClient.SqlParameter("@CostPriceSeedGood", objDetail.CostPriceSeedGood)
        prm(11) = New SqlClient.SqlParameter("@CostPriceSeedOutUsage", objDetail.CostPriceSeedOutUsage)

        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Sub
    '//--------------------------------------End -----------------------------------------

    '//-------------------------------------- เบิกจ่ายเกษตรกร------------------------------------------
    'Public Shared Function InsertPayDateHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As PayDateHeader) As Integer
    '    Dim cmd As String = "SP_InsertPayDateHeader"
    '    Dim prm(5) As SqlClient.SqlParameter

    '    'prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
    '    prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
    '    prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
    '    prm(2) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
    '    prm(3) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
    '    prm(4) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
    '    prm(5) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

    '    Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    'End Function

    'Public Shared Sub InsertPayDateDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of PayDateDetail))
    '    For Each item As PayDateDetail In objDetails
    '        Dim cmd As String = "SP_InsertPayDateDetail"
    '        Dim prm(6) As SqlClient.SqlParameter

    '        prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
    '        prm(1) = New SqlClient.SqlParameter("@TotalWeight", item.TotalWeight)
    '        prm(2) = New SqlClient.SqlParameter("@TotalAmount", item.TotalAmount)
    '        prm(3) = New SqlClient.SqlParameter("@TotalFamer", item.TotalFamer)
    '        prm(4) = New SqlClient.SqlParameter("@TotalDays", item.TotalDays)
    '        prm(5) = New SqlClient.SqlParameter("@WeightDate", item.WeightDate)
    '        prm(6) = New SqlClient.SqlParameter("@PayDate", item.PayDate)

    '        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
    '    Next

    'End Sub
    '//--------------------------------------End -----------------------------------------
#Region "======================== สรุปแผนและผลการดำเนินงานตามกิจกรรมในกระบวนการผลิตเมล็ดพันธุ์======================="
    Public Shared Function InsertReportQualityActivityHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As QualityActivityHeader) As Integer
        Dim CMD As String = "SP_InsertReportQualityActivityHeader"
        Dim Prm(14) As SqlClient.SqlParameter
        Prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        Prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        Prm(2) = New SqlClient.SqlParameter("@PlantName", objReportData.PlantName)
        Prm(3) = New SqlClient.SqlParameter("@SeedTypeName", objReportData.SeedTypeName)
        Prm(4) = New SqlClient.SqlParameter("@SeedClassName", objReportData.SeedClassName)
        Prm(5) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        Prm(6) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        Prm(7) = New SqlClient.SqlParameter("@SeedLot", objReportData.SeedLot)
        Prm(8) = New SqlClient.SqlParameter("@SeedGoal", objReportData.SeedGoal)
        Prm(9) = New SqlClient.SqlParameter("@BuyGoal", objReportData.BuyGoal)
        Prm(10) = New SqlClient.SqlParameter("@TotalGrowArea", objReportData.TotalGrowArea)
        Prm(11) = New SqlClient.SqlParameter("@TotalGroup", objReportData.TotalGroup)
        Prm(12) = New SqlClient.SqlParameter("@TotalFarmer", objReportData.TotalFarmer)
        Prm(13) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        Prm(14) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)
        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, CMD, Prm)


    End Function
    Public Shared Sub InsertReportQualityActivityDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of QualityActivityDetail))
        For Each Item As QualityActivityDetail In objDetails
            Dim Cmd As String = "SP_InsertReportQualityActivityDetail"
            Dim Prm(17) As SqlClient.SqlParameter
            Prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            Prm(1) = New SqlClient.SqlParameter("@ActivityNo", Item.ActivityNo)
            Prm(2) = New SqlClient.SqlParameter("@PlanName", Item.PlanName)
            Prm(3) = New SqlClient.SqlParameter("@PlanUnit", Item.PlanUnit)
            Prm(4) = New SqlClient.SqlParameter("@OctValue", Item.OctValue)
            Prm(5) = New SqlClient.SqlParameter("@NovValue", Item.NovValue)
            Prm(6) = New SqlClient.SqlParameter("@DecValue", Item.DecValue)
            Prm(7) = New SqlClient.SqlParameter("@JanValue", Item.JanValue)
            Prm(8) = New SqlClient.SqlParameter("@FebValue", Item.FebValue)
            Prm(9) = New SqlClient.SqlParameter("@MarValue", Item.MarValue)
            Prm(10) = New SqlClient.SqlParameter("@AprValue", Item.AprValue)
            Prm(11) = New SqlClient.SqlParameter("@MayValue", Item.MayValue)
            Prm(12) = New SqlClient.SqlParameter("@JunValue", Item.JunValue)
            Prm(13) = New SqlClient.SqlParameter("@JulValue", Item.JulValue)
            Prm(14) = New SqlClient.SqlParameter("@AugValue", Item.AugValue)
            Prm(15) = New SqlClient.SqlParameter("@SepValue", Item.SepValue)
            Prm(16) = New SqlClient.SqlParameter("@AllValue", Item.AllValue)
            Prm(17) = New SqlClient.SqlParameter("@DiffValue", Item.DiffValue)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, Cmd, Prm)

        Next

    End Sub
#End Region


    '//===========================================================================================
    'Public Shared Sub InsertSubmitReportLog(sqlTransaction As SqlClient.SqlTransaction, SiteNo As String, SiteName As String, ReportName As String, ReportYear As String, ReportMonth As Integer, ReportDate As DateTime, ReportBy As String)
    '    Dim cmd As String = "SP_InsertSubmitReportLog"
    '    Dim prm(6) As SqlClient.SqlParameter
    '    prm(0) = New SqlClient.SqlParameter("@SiteNo", SiteNo)
    '    prm(1) = New SqlClient.SqlParameter("@SiteName", SiteName)
    '    prm(2) = New SqlClient.SqlParameter("@ReportName", ReportName)
    '    prm(3) = New SqlClient.SqlParameter("@ReportYear", ReportYear)
    '    prm(4) = New SqlClient.SqlParameter("@ReportMonth", ReportMonth)
    '    prm(5) = New SqlClient.SqlParameter("@ReportDate", ReportDate)
    '    prm(6) = New SqlClient.SqlParameter("@ReportBy", ReportBy)

    '    Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    'End Sub

    '//-------------------------------------------------------------------------------------------------------------------------------------------------

    '//-------------------------------------- งบ ทดลอง------------------------------------------
    Public Shared Function InsertTrialBalanceHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As TrialBalanceHeader) As Integer
        Dim cmd As String = "SP_InsertTrialBalanceHeader"
        Dim prm(6) As SqlClient.SqlParameter

        'prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@BalanceDate", objReportData.BalanceDate)
        prm(3) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
        prm(4) = New SqlClient.SqlParameter("@Month", objReportData.Month)
        prm(5) = New SqlClient.SqlParameter("@Year", objReportData.Year)
        prm(6) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertTrialBalanceDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of TrialBalanceDetail))
        For Each item As TrialBalanceDetail In objDetails
            Dim cmd As String = "SP_InsertTrialBalanceDetail"
            Dim prm(3) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@AccountID", item.AccountID)
            prm(2) = New SqlClient.SqlParameter("@AccountName", item.AccountName)
            prm(3) = New SqlClient.SqlParameter("@TotalBalance", item.TotalBalance)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub
    '//--------------------------------------End -----------------------------------------

    '//-------------------------------------- เบิกจ่ายเกษตรกร------------------------------------------
    Public Shared Function InsertPayDateHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As PayDateHeader) As Integer
        Dim cmd As String = "SP_InsertPayDateHeader"
        Dim prm(7) As SqlClient.SqlParameter

        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
        prm(3) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(4) = New SqlClient.SqlParameter("@SeedMonth", objReportData.SeedMonth)
        prm(5) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(6) = New SqlClient.SqlParameter("@FiscalYear", objReportData.FiscalYear)
        prm(7) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertPayDateDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of PayDateDetail))
        For Each item As PayDateDetail In objDetails
            Dim cmd As String = "SP_InsertPayDateDetail"
            Dim prm(12) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@SeedName", item.SeedName)
            prm(2) = New SqlClient.SqlParameter("@SeedClass", item.SeedClass)
            prm(3) = New SqlClient.SqlParameter("@BatchNo", item.BatchNo)
            prm(4) = New SqlClient.SqlParameter("@RefNo", item.RefNo)
            prm(5) = New SqlClient.SqlParameter("@WeightDate", item.WeightDate)
            prm(6) = New SqlClient.SqlParameter("@RefDate", item.RefDate)
            prm(7) = New SqlClient.SqlParameter("@CenterPayDate", item.CenterPayDate)
            prm(8) = New SqlClient.SqlParameter("@PayDate", item.PayDate)
            prm(9) = New SqlClient.SqlParameter("@TotalDays", item.TotalDays)
            prm(10) = New SqlClient.SqlParameter("@TotalFamer", item.TotalFamer)
            prm(11) = New SqlClient.SqlParameter("@TotalWeight", item.TotalWeight)
            prm(12) = New SqlClient.SqlParameter("@TotalAmount", item.TotalAmount)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub
    '//--------------------------------------End -----------------------------------------

    '//-------------------------------------- ต้นทุนเมล็ดพันธุ์------------------------------------------
    Public Shared Function InsertAccCostHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As AccCostHeader) As Integer
        Dim cmd As String = "SP_InsertAccCostHeader"
        Dim prm(7) As SqlClient.SqlParameter

        'prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
        prm(3) = New SqlClient.SqlParameter("@SeasonName", objReportData.SeasonName)
        prm(4) = New SqlClient.SqlParameter("@SeedMonth", objReportData.SeedMonth)
        prm(5) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(6) = New SqlClient.SqlParameter("@SeedFiscalYear", objReportData.SeedFiscalYear)
        prm(7) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertAccCostDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of AccCostDetail))
        Dim cmd As String = "SP_InsertAccCostDetail"
        For Each item As AccCostDetail In objDetails
            Dim prm(16) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@Plant", item.Plant)
            prm(2) = New SqlClient.SqlParameter("@Seed", item.Seed)
            prm(3) = New SqlClient.SqlParameter("@SeedType", item.SeedType)
            prm(4) = New SqlClient.SqlParameter("@SeasonName", item.SeasonName)
            prm(5) = New SqlClient.SqlParameter("@SeedYear", item.SeedYear)
            prm(6) = New SqlClient.SqlParameter("@AmountSeed", item.AmountSeed)
            prm(7) = New SqlClient.SqlParameter("@AmountSeedGood", item.AmountSeedGood)
            prm(8) = New SqlClient.SqlParameter("@AmountSeedOut", item.AmountSeedOut)
            prm(9) = New SqlClient.SqlParameter("@TotalSeed", item.TotalSeed)
            prm(10) = New SqlClient.SqlParameter("@TotalMaterials", item.TotalMaterials)
            prm(11) = New SqlClient.SqlParameter("@TotalOil", item.TotalOil)
            prm(12) = New SqlClient.SqlParameter("@TotalChemical", item.TotalChemical)
            prm(13) = New SqlClient.SqlParameter("@PriceSeedGood", item.PriceSeedGood)
            prm(14) = New SqlClient.SqlParameter("@PriceSeedOutUsage", item.PriceSeedOutUsage)
            prm(15) = New SqlClient.SqlParameter("@CostPriceSeedGood", item.CostPriceSeedGood)
            prm(16) = New SqlClient.SqlParameter("@CostPriceSeedOutUsage", item.CostPriceSeedOutUsage)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub
    '//--------------------------------------End -----------------------------------------

    '//-------------------------------------- งบทดลองรายเดือน------------------------------------------
    Public Shared Function InsertTrialBalanceMonthHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As TrialBalanceMonthHeader) As Integer
        Dim cmd As String = "SP_InsertTrialBalanceMonthHeader"
        Dim prm(6) As SqlClient.SqlParameter

        'prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@BalanceDate", objReportData.BalanceDate)
        prm(3) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
        prm(4) = New SqlClient.SqlParameter("@BalanceMonth", objReportData.BalanceMonth)
        prm(5) = New SqlClient.SqlParameter("@BalanceYear", objReportData.BalanceYear)
        prm(6) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertTrialBalanceMonthDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of TrialBalanceMonthDetail))
        For Each item As TrialBalanceMonthDetail In objDetails
            Dim cmd As String = "SP_InsertTrialBalanceMonthDetail"
            Dim prm(5) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@AccountID", item.AccountID)
            prm(2) = New SqlClient.SqlParameter("@AccountName", item.AccountName)
            prm(3) = New SqlClient.SqlParameter("@ForwardDrCr", item.ForwardDrCr)
            prm(4) = New SqlClient.SqlParameter("@CurrentDrCr", item.CurrentDrCr)
            prm(5) = New SqlClient.SqlParameter("@TotalDrCr", item.TotalDrCr)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub
    '//--------------------------------------End -----------------------------------------

    '//-------------------------------------- งบทดลองรายไตรมาส------------------------------------------
    Public Shared Function InsertTrialBalanceQuarterHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As TrialBalanceQuarterHeader) As Integer
        Dim cmd As String = "SP_InsertTrialBalanceQuarterHeader"
        Dim prm(6) As SqlClient.SqlParameter

        'prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@BalanceDate", objReportData.BalanceDate)
        prm(3) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
        prm(4) = New SqlClient.SqlParameter("@BalanceQuarter", objReportData.BalanceQuarter)
        prm(5) = New SqlClient.SqlParameter("@BalanceYear", objReportData.BalanceYear)
        prm(6) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertTrialBalanceQuarterDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of TrialBalanceQuarterDetail))
        For Each item As TrialBalanceQuarterDetail In objDetails
            Dim cmd As String = "SP_InsertTrialBalanceQuarterDetail"
            Dim prm(4) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@AccountID", item.AccountID)
            prm(2) = New SqlClient.SqlParameter("@AccountName", item.AccountName)
            prm(3) = New SqlClient.SqlParameter("@TotalDr", item.TotalDr)
            prm(4) = New SqlClient.SqlParameter("@TotalCr", item.TotalCr)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub
    '//--------------------------------------End -----------------------------------------

    '//-------------------------------------- สงป.301------------------------------------------
    Public Shared Function InsertPlanBudgetHeader01(sqlTransaction As SqlClient.SqlTransaction, objReportData As PlanBudgetHeader01) As Integer
        Dim cmd As String = "SP_InsertPlanBudgetHeader01"
        Dim prm(10) As SqlClient.SqlParameter

        'prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
        prm(3) = New SqlClient.SqlParameter("@PlanYear", objReportData.PlanYear)
        prm(4) = New SqlClient.SqlParameter("@PlanMonth", objReportData.PlanMonth)
        prm(5) = New SqlClient.SqlParameter("@PlanName", objReportData.PlanName)
        prm(6) = New SqlClient.SqlParameter("@ProjectName", objReportData.ProjectName)
        prm(7) = New SqlClient.SqlParameter("@ActivityName", objReportData.ActivityName)
        prm(8) = New SqlClient.SqlParameter("@Note", objReportData.Note)
        prm(9) = New SqlClient.SqlParameter("@Problem", objReportData.Problem)
        prm(10) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertPlanBudgetDetails(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of PlanBudgetDetail01))
        Dim cmd As String = "SP_InsertPlanBudgetDetail01"
        For Each item As PlanBudgetDetail01 In objDetails
            Dim prm(2) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@ActivityName", item.ActivityName)
            prm(2) = New SqlClient.SqlParameter("@Classifier", item.Classifier)

            Dim PlanBudgetId As Integer = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
            'item.PlanBudgetDetailMonths
            'item.ResultBudgets
            ' For Each detail1 As PlanBudgetDetailMonth01 In item.PlanBudgetDetailMonths
            InsertPlanBudgetDetailMonths(sqlTransaction, PlanBudgetId, item.PlanBudgetDetailMonth)
            'Next
            'For Each detail2 As ResultBudget01 In item.ResultBudgets
            InsertSP_InsertResultBudgets(sqlTransaction, PlanBudgetId, item.ResultBudget)
            'Next
        Next

    End Sub

    Public Shared Sub InsertPlanBudgetDetailMonths(sqlTransaction As SqlClient.SqlTransaction, PlanBudgetDetail As Integer, objDetail As PlanBudgetDetailMonth01)
        Dim cmd As String = "SP_InsertPlanBudgetDetailMonth01"
        'For Each item As PlanBudgetDetailMonth01 In objDetails
        Dim prm(12) As SqlClient.SqlParameter

        prm(0) = New SqlClient.SqlParameter("@PlanBudgetDetail", PlanBudgetDetail)
        prm(1) = New SqlClient.SqlParameter("@October", objDetail.October)
        prm(2) = New SqlClient.SqlParameter("@November", objDetail.November)
        prm(3) = New SqlClient.SqlParameter("@December", objDetail.December)
        prm(4) = New SqlClient.SqlParameter("@January", objDetail.January)
        prm(5) = New SqlClient.SqlParameter("@February", objDetail.February)
        prm(6) = New SqlClient.SqlParameter("@March", objDetail.March)
        prm(7) = New SqlClient.SqlParameter("@April", objDetail.April)
        prm(8) = New SqlClient.SqlParameter("@May", objDetail.May)
        prm(9) = New SqlClient.SqlParameter("@June", objDetail.June)
        prm(10) = New SqlClient.SqlParameter("@July", objDetail.July)
        prm(11) = New SqlClient.SqlParameter("@August", objDetail.August)
        prm(12) = New SqlClient.SqlParameter("@September", objDetail.September)

        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        ' Next

    End Sub

    Public Shared Sub InsertSP_InsertResultBudgets(sqlTransaction As SqlClient.SqlTransaction, PlanBudgetDetail As Integer, objDetail As ResultBudget01)
        Dim cmd As String = "SP_InsertResultBudget01"
        'For Each item As ResultBudget01 In objDetails
        Dim prm(12) As SqlClient.SqlParameter

        prm(0) = New SqlClient.SqlParameter("@PlanBudgetDetail", PlanBudgetDetail)
        prm(1) = New SqlClient.SqlParameter("@October", objDetail.October)
        prm(2) = New SqlClient.SqlParameter("@November", objDetail.November)
        prm(3) = New SqlClient.SqlParameter("@December", objDetail.December)
        prm(4) = New SqlClient.SqlParameter("@January", objDetail.January)
        prm(5) = New SqlClient.SqlParameter("@February", objDetail.February)
        prm(6) = New SqlClient.SqlParameter("@March", objDetail.March)
        prm(7) = New SqlClient.SqlParameter("@April", objDetail.April)
        prm(8) = New SqlClient.SqlParameter("@May", objDetail.May)
        prm(9) = New SqlClient.SqlParameter("@June", objDetail.June)
        prm(10) = New SqlClient.SqlParameter("@July", objDetail.July)
        prm(11) = New SqlClient.SqlParameter("@August", objDetail.August)
        prm(12) = New SqlClient.SqlParameter("@September", objDetail.September)

        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        'Next

    End Sub
    '//--------------------------------------End -----------------------------------------

    '//-------------------------------------- สงป.302------------------------------------------
    Public Shared Function InsertPlanBudgetHeader02(sqlTransaction As SqlClient.SqlTransaction, objReportData As PlanBudgetHeader02) As Integer
        Dim cmd As String = "SP_InsertPlanBudgetHeader02"
        Dim prm(9) As SqlClient.SqlParameter

        'prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
        prm(3) = New SqlClient.SqlParameter("@BudgetYear", objReportData.BudgetYear)
        prm(4) = New SqlClient.SqlParameter("@BudgetMonth", objReportData.BudgetMonth)
        prm(5) = New SqlClient.SqlParameter("@PlanName", objReportData.PlanName)
        prm(6) = New SqlClient.SqlParameter("@ProjectName", objReportData.ProjectName)
        prm(7) = New SqlClient.SqlParameter("@ActivityName", objReportData.ActivityName)
        prm(8) = New SqlClient.SqlParameter("@SubActivityName", objReportData.SubActivityName)
        prm(9) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertPlanBudgetDetail02(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of PlanBudgetDetail02))
        Dim cmd As String = "SP_InsertPlanBudgetDetail02"
        For Each item As PlanBudgetDetail02 In objDetails
            Dim prm(4) As SqlClient.SqlParameter

            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@ProjectSubActivityName", item.ProjectSubActivityName)
            prm(2) = New SqlClient.SqlParameter("@PlanBudgetType", item.PlanBudgetType)
            prm(3) = New SqlClient.SqlParameter("@ExpenseID", item.ExpenseID)
            prm(4) = New SqlClient.SqlParameter("@ExpenseName", item.ExpenseName)

            Dim PlanBudgetId As Integer = Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
            'item.PlanBudgetDetailMonths
            'item.ResultBudgets
            ' For Each detail1 As PlanBudgetDetailMonth01 In item.PlanBudgetDetailMonths
            InsertPlanBudgetDetailMonth02(sqlTransaction, PlanBudgetId, item.PlanBudgetDetailMonth)
            'Next
            'For Each detail2 As ResultBudget01 In item.ResultBudgets
            InsertSP_InsertResultBudget02(sqlTransaction, PlanBudgetId, item.ResultBudget)
            'Next
        Next

    End Sub

    Public Shared Sub InsertPlanBudgetDetailMonth02(sqlTransaction As SqlClient.SqlTransaction, PlanBudgetDetail As Integer, objDetail As PlanBudgetDetailMonth02)
        Dim cmd As String = "SP_InsertPlanBudgetDetailMonth02"
        'For Each item As PlanBudgetDetailMonth01 In objDetails
        Dim prm(12) As SqlClient.SqlParameter

        prm(0) = New SqlClient.SqlParameter("@PlanBudgetDetail", PlanBudgetDetail)
        prm(1) = New SqlClient.SqlParameter("@October", objDetail.October)
        prm(2) = New SqlClient.SqlParameter("@November", objDetail.November)
        prm(3) = New SqlClient.SqlParameter("@December", objDetail.December)
        prm(4) = New SqlClient.SqlParameter("@January", objDetail.January)
        prm(5) = New SqlClient.SqlParameter("@February", objDetail.February)
        prm(6) = New SqlClient.SqlParameter("@March", objDetail.March)
        prm(7) = New SqlClient.SqlParameter("@April", objDetail.April)
        prm(8) = New SqlClient.SqlParameter("@May", objDetail.May)
        prm(9) = New SqlClient.SqlParameter("@June", objDetail.June)
        prm(10) = New SqlClient.SqlParameter("@July", objDetail.July)
        prm(11) = New SqlClient.SqlParameter("@August", objDetail.August)
        prm(12) = New SqlClient.SqlParameter("@September", objDetail.September)

        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        ' Next

    End Sub

    Public Shared Sub InsertSP_InsertResultBudget02(sqlTransaction As SqlClient.SqlTransaction, PlanBudgetDetail As Integer, objDetail As ResultBudget02)
        Dim cmd As String = "SP_InsertResultBudget02"
        'For Each item As ResultBudget01 In objDetails
        Dim prm(12) As SqlClient.SqlParameter

        prm(0) = New SqlClient.SqlParameter("@PlanBudgetDetail", PlanBudgetDetail)
        prm(1) = New SqlClient.SqlParameter("@October", objDetail.October)
        prm(2) = New SqlClient.SqlParameter("@November", objDetail.November)
        prm(3) = New SqlClient.SqlParameter("@December", objDetail.December)
        prm(4) = New SqlClient.SqlParameter("@January", objDetail.January)
        prm(5) = New SqlClient.SqlParameter("@February", objDetail.February)
        prm(6) = New SqlClient.SqlParameter("@March", objDetail.March)
        prm(7) = New SqlClient.SqlParameter("@April", objDetail.April)
        prm(8) = New SqlClient.SqlParameter("@May", objDetail.May)
        prm(9) = New SqlClient.SqlParameter("@June", objDetail.June)
        prm(10) = New SqlClient.SqlParameter("@July", objDetail.July)
        prm(11) = New SqlClient.SqlParameter("@August", objDetail.August)
        prm(12) = New SqlClient.SqlParameter("@September", objDetail.September)

        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        'Next

    End Sub
    '//--------------------------------------End -----------------------------------------

    '//-------------------------------------- แผนการรับ - จ่าย เงินประจำปีงบประมาณ ------------------------------------------
    Public Shared Function InsertPlanTransferHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As PlanTrialBalanceTransfer03) As Integer
        Dim cmd As String = "SP_InsertPlanTransferHeader"
        Dim prm(5) As SqlClient.SqlParameter

        'prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(0) = New SqlClient.SqlParameter("@DataOwner", objReportData.DataOwner)
        prm(1) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(2) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(3) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
        prm(4) = New SqlClient.SqlParameter("@PlanYear", objReportData.PlanYear)
        prm(5) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertPlanTransferDetailIncome(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of TrialBalanceTransferIncomeData))
        Dim cmd As String = "SP_InsertPlanTransferDetailIncome"
        For Each item As TrialBalanceTransferIncomeData In objDetails
            Dim prm(15) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@SettingIncomeOid", item.SettingIncomeOid)
            prm(2) = New SqlClient.SqlParameter("@CatalogueNo", item.CatalogueNo)
            prm(3) = New SqlClient.SqlParameter("@listIncome", item.listIncome)
            prm(4) = New SqlClient.SqlParameter("@October", item.October)
            prm(5) = New SqlClient.SqlParameter("@November", item.November)
            prm(6) = New SqlClient.SqlParameter("@December", item.December)
            prm(7) = New SqlClient.SqlParameter("@January", item.January)
            prm(8) = New SqlClient.SqlParameter("@February", item.February)
            prm(9) = New SqlClient.SqlParameter("@March", item.March)
            prm(10) = New SqlClient.SqlParameter("@April", item.April)
            prm(11) = New SqlClient.SqlParameter("@May", item.May)
            prm(12) = New SqlClient.SqlParameter("@June", item.June)
            prm(13) = New SqlClient.SqlParameter("@July", item.July)
            prm(14) = New SqlClient.SqlParameter("@August", item.August)
            prm(15) = New SqlClient.SqlParameter("@September", item.September)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub

    Public Shared Sub InsertPlanTransferDetailExpenses(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of TrialBalanceTransferExpensesData))
        Dim cmd As String = "SP_InsertPlanTransferDetailExpenses"
        For Each item As TrialBalanceTransferExpensesData In objDetails
            Dim prm(15) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@SettingExpensesOid", item.SettingExpensesOid)
            prm(2) = New SqlClient.SqlParameter("@CatalogueNo", item.CatalogueNo)
            prm(3) = New SqlClient.SqlParameter("@listExpenses", item.listExpenses)
            prm(4) = New SqlClient.SqlParameter("@October", item.October)
            prm(5) = New SqlClient.SqlParameter("@November", item.November)
            prm(6) = New SqlClient.SqlParameter("@December", item.December)
            prm(7) = New SqlClient.SqlParameter("@January", item.January)
            prm(8) = New SqlClient.SqlParameter("@February", item.February)
            prm(9) = New SqlClient.SqlParameter("@March", item.March)
            prm(10) = New SqlClient.SqlParameter("@April", item.April)
            prm(11) = New SqlClient.SqlParameter("@May", item.May)
            prm(12) = New SqlClient.SqlParameter("@June", item.June)
            prm(13) = New SqlClient.SqlParameter("@July", item.July)
            prm(14) = New SqlClient.SqlParameter("@August", item.August)
            prm(15) = New SqlClient.SqlParameter("@September", item.September)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub
    '//--------------------------------------End -----------------------------------------

    '//-------------------------------------- ผลการรับ - จ่าย เงินประจำเดือน ------------------------------------------
    Public Shared Function InsertResultIncomeAndExpensesMonthHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As ResultIncomeAndExpensesMonth) As Integer
        Dim cmd As String = "SP_InsertResultIncomeAndExpensesMonthHeader"
        Dim prm(6) As SqlClient.SqlParameter

        'prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(0) = New SqlClient.SqlParameter("@DataOwner", objReportData.DataOwner)
        prm(1) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(2) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(3) = New SqlClient.SqlParameter("@SentDate", objReportData.SentDate)
        prm(4) = New SqlClient.SqlParameter("@ResultYear", objReportData.ResultYear)
        prm(5) = New SqlClient.SqlParameter("@ResultMonth", objReportData.ResultMonth)
        prm(6) = New SqlClient.SqlParameter("@SentBy", objReportData.SentBy)

        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertResultMonthDetailIncome(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of ResultMonthIncomeData))
        Dim cmd As String = "SP_InsertResultMonthDetailIncome"
        For Each item As ResultMonthIncomeData In objDetails
            Dim prm(6) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@ResultIncomeOid", item.ResultIncomeOid)
            prm(2) = New SqlClient.SqlParameter("@listID", item.listID)
            prm(3) = New SqlClient.SqlParameter("@listIncome", item.listIncome)
            prm(4) = New SqlClient.SqlParameter("@IncomeMonth", item.IncomeMonth)
            prm(5) = New SqlClient.SqlParameter("@ExpendMonth", item.ExpendMonth)
            prm(6) = New SqlClient.SqlParameter("@Note", item.Note)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub

    Public Shared Sub InsertResultMonthDetailExpenses(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of ResultMonthExpensesData))
        Dim cmd As String = "SP_InsertResultMonthDetailExpenses"
        For Each item As ResultMonthExpensesData In objDetails
            Dim prm(6) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@ResultExpensesOid", item.ResultExpensesOid)
            prm(2) = New SqlClient.SqlParameter("@listID", item.listID)
            prm(3) = New SqlClient.SqlParameter("@listExpenses", item.listExpenses)
            prm(4) = New SqlClient.SqlParameter("@IncomeMonth", item.IncomeMonth)
            prm(5) = New SqlClient.SqlParameter("@ExpendMonth", item.ExpendMonth)
            prm(6) = New SqlClient.SqlParameter("@Note", item.Note)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub

    Public Shared Sub InsertAccountGFMISDetailRV(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of AccountGFMISDetailRVDatas))
        Dim cmd As String = "SP_InsertAccountDetailRV"
        For Each item As AccountGFMISDetailRVDatas In objDetails
            Dim prm(3) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@listGF", item.listGF)
            prm(2) = New SqlClient.SqlParameter("@CodeGF", item.CodeGF)
            prm(3) = New SqlClient.SqlParameter("@AmountIncome", item.AmountIncome)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub

    Public Shared Sub InsertAccountGFMISDetailPV(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of AccountGFMISDetailPVDatas))
        Dim cmd As String = "SP_InsertAccountDetailPV"
        For Each item As AccountGFMISDetailPVDatas In objDetails
            Dim prm(3) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@listGF", item.listGF)
            prm(2) = New SqlClient.SqlParameter("@CodeGF", item.CodeGF)
            prm(3) = New SqlClient.SqlParameter("@AmountExpenses", item.AmountExpenses)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub
    '//--------------------------------------End -----------------------------------------
    Public Shared Sub InsertSubmitReportLog(sqlTransaction As SqlClient.SqlTransaction, SiteNo As String, SiteName As String, ReportName As String, ReportYear As String, ReportMonth As Integer, ReportQuarter As Integer, ReportDate As DateTime, ReportBy As String)
        Dim cmd As String = "SP_InsertSubmitReportLog"
        Dim prm(7) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", SiteName)
        prm(2) = New SqlClient.SqlParameter("@ReportName", ReportName)
        prm(3) = New SqlClient.SqlParameter("@ReportYear", ReportYear)
        prm(4) = New SqlClient.SqlParameter("@ReportMonth", ReportMonth)
        prm(5) = New SqlClient.SqlParameter("@ReportQuarter", ReportQuarter)
        prm(6) = New SqlClient.SqlParameter("@ReportDate", ReportDate)
        prm(7) = New SqlClient.SqlParameter("@ReportBy", ReportBy)

        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Sub

    Public Shared Sub InsertSubmitReportLog(sqlTransaction As SqlClient.SqlTransaction, SiteNo As String, SiteName As String, ReportName As String, ReportYear As String, ReportMonth As Integer, ReportDate As DateTime, ReportBy As String)
        Dim cmd As String = "SP_InsertSubmitReportLog_noQuater"
        Dim prm(6) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", SiteName)
        prm(2) = New SqlClient.SqlParameter("@ReportName", ReportName)
        prm(3) = New SqlClient.SqlParameter("@ReportYear", ReportYear)
        prm(4) = New SqlClient.SqlParameter("@ReportMonth", ReportMonth)
        prm(5) = New SqlClient.SqlParameter("@ReportDate", ReportDate)
        prm(6) = New SqlClient.SqlParameter("@ReportBy", ReportBy)

        Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Sub

    '//============================================================================================


    '//-------------------------------------- กคภ2556/02 ------------------------------------------

    Public Shared Function InsertReportCheckQualityHeader(sqlTransaction As SqlClient.SqlTransaction, objReportData As CheckQualityHeader) As Integer
        Dim cmd As String = "SP_InsertReportCheckQualityHeader"
        Dim prm(6) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReportData.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReportData.SiteName)
        prm(2) = New SqlClient.SqlParameter("@SeedClassName ", objReportData.SeedClass)
        prm(3) = New SqlClient.SqlParameter("@SeasonName", objReportData.Season)
        prm(4) = New SqlClient.SqlParameter("@SeedYear", objReportData.SeedYear)
        prm(5) = New SqlClient.SqlParameter("@SubmitDate", objReportData.SubmitDate)
        prm(6) = New SqlClient.SqlParameter("@SubmitBy", objReportData.SubmitBy)
        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
    End Function


    Public Shared Sub InsertReportCheckQualityDetail(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of CheckQualityDetail))
        For Each item As CheckQualityDetail In objDetails
            Dim cmd As String = "SP_InsertReportCheckQualityDetail"
            Dim prm(18) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@HeaderNo", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@SampleNo", item.SampleNo)
            prm(2) = New SqlClient.SqlParameter("@SeedLot", item.LotNo)
            prm(3) = New SqlClient.SqlParameter("@HarvestDate", item.HarvestDate)
            prm(4) = New SqlClient.SqlParameter("@SeedSource", item.SampleSource)
            prm(5) = New SqlClient.SqlParameter("@Bags", item.Bags)
            prm(6) = New SqlClient.SqlParameter("@Quantity", item.SeedWeight)
            prm(7) = New SqlClient.SqlParameter("@Wet", item.Wet)
            prm(8) = New SqlClient.SqlParameter("@Grow", item.Grow)
            prm(9) = New SqlClient.SqlParameter("@PureSeed", item.PureSeed)
            prm(10) = New SqlClient.SqlParameter("@OtherSeed", item.OtherSeed)
            prm(11) = New SqlClient.SqlParameter("@Compound", item.Compound)
            prm(12) = New SqlClient.SqlParameter("@RedSeed ", item.RedSeed)
            prm(13) = New SqlClient.SqlParameter("@StickySeed", item.StickySeed)
            prm(14) = New SqlClient.SqlParameter("@Strong", item.Strong)
            prm(15) = New SqlClient.SqlParameter("@CheckDate", item.LabDate)
            prm(16) = New SqlClient.SqlParameter("@CheckResult", item.CheckResults)
            prm(17) = New SqlClient.SqlParameter("@Remark", item.Remark)
            prm(18) = New SqlClient.SqlParameter("@SeedTypeName", item.SeedTypeName)
            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub
    '//--------------------------------------End กคภ2556/02 ------------------------------------------

End Class
