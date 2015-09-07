Public Class AccCostHeader
    Public SiteNo As String
    Public SiteName As String
    Public SentDate As Date
    Public SeasonName As String
    Public SeedMonth As Integer
    Public SeedYear As String
    Public SeedFiscalYear As String
    Public SentBy As String

    'Public AccCostDetail As AccCostDetail
    Public AccCostDetails As List(Of AccCostDetail)

End Class
