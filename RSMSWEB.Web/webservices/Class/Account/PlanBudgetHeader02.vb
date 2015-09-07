Public Class PlanBudgetHeader02
    Public SiteNo As String
    Public SiteName As String
    Public SentDate As Date
    Public SentBy As String
    Public BudgetYear As String
    Public BudgetMonth As Integer
    Public PlanName As String
    Public ProjectName As String
    Public ActivityName As String
    Public SubActivityName As String

    Public PlanBudgetDetails As List(Of PlanBudgetDetail02)
End Class
