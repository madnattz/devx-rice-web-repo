Public Class DailyProcessHeader

    Public SiteNo As String
    Public SiteName As String
    Public SubmitDate As Date
    Public SubmitBy As String
    Public StartDate As Date
    Public EndDate As Date
    Public ProcessWeek As Integer
    Public ProcessMonth As Integer
    Public ProcessYear As String
    Public ProcessDateFullName As String

    Public DailyProcessDetails As List(Of DailyProcessDetail)

    Public Sub New()
    End Sub

End Class
