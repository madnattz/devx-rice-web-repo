Public Class ResultIncomeAndExpensesMonth
    Public DataOwner As String
    Public SiteNo As String
    Public SiteName As String
    Public SentDate As Date
    Public SentBy As String
    Public ResultYear As String
    Public ResultMonth As Integer

    Public ResultMonthDetailIncome As List(Of ResultMonthIncomeData)
    Public ResultMonthDetailExpenses As List(Of ResultMonthExpensesData)
    Public AccountGFMISDetailRV As List(Of AccountGFMISDetailRVDatas)
    Public AccountGFMISDetailPV As List(Of AccountGFMISDetailPVDatas)
End Class
