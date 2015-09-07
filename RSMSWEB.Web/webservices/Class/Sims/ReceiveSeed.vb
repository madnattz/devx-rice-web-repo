Public Class ReceiveSeed

    Public SiteNo As Integer
    Public SiteName As String
    Public ReceiveNo As String
    Public ReceiveDate As Date
    Public ReceiveReason As Integer
    Public IsOtherReceiveType As Boolean
    Public ReceiveTypeOther As String
    Public RefNo As String
    Public ReceiveUser As String
    Public ReceiveUserPosition As String
    Public ApproveUser As String
    Public ApproveUserPosition As String
    Public Status As Integer
    Public Remark As String
    Public ReceiveSeedDetails As List(Of ReceiveSeedDetail)

End Class

Public Class ReceiveSeedDetail

    Public ReceiveSeed As Integer
    Public Plant As String
    Public SeedStatus As String
    Public SeedType As String
    Public SeedClass As String
    Public Season As String
    Public SeedYear As String
    Public MoneyType As String
    Public LotNo As String
    Public SeedSource As String
    Public FarmSource As String
    Public Quantity As Double
    Public Bags As Integer
    Public IsMixChemical As Boolean
    Public IsFinishProcess As Boolean

End Class
