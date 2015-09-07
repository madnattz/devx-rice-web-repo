Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class SeedReferenceData
    Private conn As String

    Public Sub New(connection As String)
        conn = connection
    End Sub

    Public Function GetPlans() As DataSet
        Try
            Dim cmd As String = "SP_Ref_GetPlant"
            Return SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetSeedStatus() As DataSet
        Try
            Dim cmd As String = "SP_Ref_GetSeedStatus"
            Return SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetSeedType(PlantID As String) As DataSet
        Try
            Dim cmd As String = "SP_Ref_GetSeedType"
            Dim prm As New SqlParameter("@PlantID", PlantID)
            Return SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd, prm)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetSeedClass() As DataSet
        Try
            Dim cmd As String = "SP_Ref_GetSeedClass"
            Return SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetSeason() As DataSet
        Try
            Dim cmd As String = "SP_Ref_GetSeason"
            Return SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetMoneyType() As DataSet
        Try
            Dim cmd As String = "SP_Ref_GetMoneyType"
            Return SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetSite() As DataSet
        Try
            Dim cmd As String = "SP_Ref_GetSite"
            Return SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetYear() As List(Of String)
        Dim list As New List(Of String)
        Dim _year As Integer = Date.Now.Year + 543
        For i As Integer = -3 To 25
            list.Add(_year - i)
        Next
        Return list
    End Function

    Public Function GetProvince() As DataSet
        Try
            Dim cmd As String = "SP_Ref_GetProvince"
            Return SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetDistrict(ProvinceOid As String) As DataSet
        Try
            Dim cmd As String = "SP_Ref_GetDistrict"
            Dim prm As New SqlParameter("@ProvinceOid", DbType.Guid)
            If ProvinceOid <> "-1" Then
                prm.Value = Guid.Parse(ProvinceOid)
            Else
                prm.Value = DBNull.Value
            End If

            Return SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd, prm)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetSubDistrict(DistricOid As String) As DataSet
        Try
            Dim cmd As String = "SP_Ref_GetSubDistrict"
            Dim prm As New SqlParameter("@DistrictOid", DbType.Guid)
            If DistricOid <> "-1" Then
                prm.Value = Guid.Parse(DistricOid)
            Else
                prm.Value = DBNull.Value
            End If

            Return SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd, prm)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetMaterial() As DataSet
        Try
            Dim cmd As String = "SP_Ref_GetMaterial"
            Return SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, cmd)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class

