Public Class QualityForBuyHeader

    Public SiteNo As String
    Public SiteName As String
    Public PlantName As String
    Public SeedTypeName As String
    Public SeedClassName As String
    Public SeasonName As String
    Public SeedYear As String
    Public SeedLot As String
    Public SubmitDate As Date
    Public SubmitBy As String
    Public QualityForBuyDetails As List(Of QualityForBuyDetail)

    Public Sub New()
    End Sub

End Class
