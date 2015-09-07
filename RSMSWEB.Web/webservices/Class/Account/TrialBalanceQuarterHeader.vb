Public Class TrialBalanceQuarterHeader
    Public SiteNo As String
    Public SiteName As String
    Public BalanceDate As Date
    Public SentDate As Date
    Public BalanceQuarter As String
    Public BalanceYear As String
    Public SentBy As String

    Public TrialBalanceQuarterDetail As List(Of TrialBalanceQuarterDetail)
End Class
