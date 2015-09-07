Public Class TrialBalanceHeader

    Public SiteNo As String
    Public SiteName As String
    Public BalanceDate As Date
    Public SentDate As Date
    Public Month As Integer
    Public Year As String
    Public SentBy As String

    Public TrialBalanceDetails As List(Of TrialBalanceDetail)

End Class

