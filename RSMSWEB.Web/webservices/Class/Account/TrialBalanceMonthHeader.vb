Public Class TrialBalanceMonthHeader
    Public SiteNo As String
    Public SiteName As String
    Public BalanceDate As Date
    Public SentDate As Date
    Public BalanceMonth As Integer
    Public BalanceYear As String
    Public SentBy As String

    Public TrialBalanceMonthDetail As List(Of TrialBalanceMonthDetail)

End Class
