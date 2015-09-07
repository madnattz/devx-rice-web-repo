Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SimsDBController

    Public Sub New()

    End Sub

    '//-----------------------------Receive Seed Header -------------------------------------
    Public Shared Function InsertReceiveSeed(sqlTransaction As SqlClient.SqlTransaction, objReceiveSeed As ReceiveSeed) As Integer
        Dim cmd As String = "SP_SIMS_ReceiveSeed_Insert"
        Dim prm(13) As SqlClient.SqlParameter
        prm(0) = New SqlClient.SqlParameter("@SiteNo", objReceiveSeed.SiteNo)
        prm(1) = New SqlClient.SqlParameter("@SiteName", objReceiveSeed.SiteName)
        prm(2) = New SqlClient.SqlParameter("@ReceiveNo", objReceiveSeed.ReceiveNo)
        prm(3) = New SqlClient.SqlParameter("@ReceiveDate", objReceiveSeed.ReceiveDate)
        prm(4) = New SqlClient.SqlParameter("@ReceiveReason", objReceiveSeed.ReceiveReason)
        prm(5) = New SqlClient.SqlParameter("@IsOtherReceiveType", objReceiveSeed.IsOtherReceiveType)
        prm(6) = New SqlClient.SqlParameter("@ReceiveTypeOther", objReceiveSeed.ReceiveTypeOther)
        prm(7) = New SqlClient.SqlParameter("@RefNo", objReceiveSeed.RefNo)
        prm(8) = New SqlClient.SqlParameter("@ReceiveUser", objReceiveSeed.ReceiveUser)
        prm(9) = New SqlClient.SqlParameter("@ReceiveUserPosition", objReceiveSeed.ReceiveUserPosition)
        prm(10) = New SqlClient.SqlParameter("@ApproveUser", objReceiveSeed.ApproveUser)
        prm(11) = New SqlClient.SqlParameter("@ApproveUserPosition", objReceiveSeed.ApproveUserPosition)
        prm(12) = New SqlClient.SqlParameter("@Status", objReceiveSeed.Status)
        prm(13) = New SqlClient.SqlParameter("@Remark", objReceiveSeed.Remark)
       
        Return Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteScalar(sqlTransaction, CommandType.StoredProcedure, cmd, prm)

    End Function

    Public Shared Sub InsertReceiveSeedDeatil(sqlTransaction As SqlClient.SqlTransaction, HeaderNo As Integer, objDetails As List(Of ReceiveSeedDetail))
        For Each item As ReceiveSeedDetail In objDetails
            Dim cmd As String = "SP_SIMS_ReceiveSeedDetail_Insert"
            Dim prm(14) As SqlClient.SqlParameter
            prm(0) = New SqlClient.SqlParameter("@ReceiveSeed", HeaderNo)
            prm(1) = New SqlClient.SqlParameter("@Plant", item.Plant)
            prm(2) = New SqlClient.SqlParameter("@SeedStatus", item.SeedStatus)
            prm(3) = New SqlClient.SqlParameter("@SeedType", item.SeedType)
            prm(4) = New SqlClient.SqlParameter("@SeedClass", item.SeedClass)
            prm(5) = New SqlClient.SqlParameter("@Season", item.Season)
            prm(6) = New SqlClient.SqlParameter("@SeedYear", item.SeedYear)
            prm(7) = New SqlClient.SqlParameter("@MoneyType", item.MoneyType)
            prm(8) = New SqlClient.SqlParameter("@LotNo", item.LotNo)
            prm(9) = New SqlClient.SqlParameter("@SeedSource", item.SeedSource)
            prm(10) = New SqlClient.SqlParameter("@FarmSource", item.FarmSource)
            prm(11) = New SqlClient.SqlParameter("@Quantity", item.Quantity)
            prm(12) = New SqlClient.SqlParameter("@Bags", item.Bags)
            prm(13) = New SqlClient.SqlParameter("@IsMixChemical", item.IsMixChemical)
            prm(14) = New SqlClient.SqlParameter("@IsFinishProcess", item.IsFinishProcess)

            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.StoredProcedure, cmd, prm)
        Next

    End Sub

End Class
