Public Class PlanBudgetHeader01
    Public SiteNo As String
    Public SiteName As String
    Public SentDate As Date
    Public SentBy As String
    Public PlanYear As String
    Public PlanMonth As Integer
    Public PlanName As String
    Public ProjectName As String
    Public ActivityName As String
    Public Note As String
    Public Problem As String

    Public PlanBudgetDetails As List(Of PlanBudgetDetail01)
End Class
