Public Class QualityActivityHeader

    Public SiteNo As String
    Public SiteName As String
    Public PlantName As String
    Public SeedTypeName As String
    Public SeedClassName As String
    Public SeasonName As String
    Public SeedYear As String
    Public SeedLot As String
    Public SeedGoal As Integer
    Public BuyGoal As Integer
    Public TotalGrowArea As Integer
    Public TotalGroup As Integer
    Public TotalFarmer As Integer
    Public SubmitDate As Date
    Public SubmitBy As String

    Public QualityActivityDetails As List(Of QualityActivityDetail)

    '//Detail

End Class