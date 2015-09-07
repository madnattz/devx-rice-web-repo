Public Class DataUtil

    Public Shared Function GatDateString(objDate As Object) As String
        Try
            Return Convert.ToDateTime(objDate).ToString("d MMMM yyyy", New System.Globalization.CultureInfo("th-TH"))
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class
