Public Class KP2ReportData

    Private _SiteNo As String
    Private _SiteName As String
    Private _PlantName As String
    Private _SeedTypeName As String
    Private _SeedClassName As String
    Private _SeasonName As String
    Private _SeedYear As String
    Private _SeedLot As String
    Private _SubmitDate As Date
    Private _SubmitBy As String
    Private _KP2ReportDetails As List(Of KP2ReportDetail)

    Public Sub New()

    End Sub

    Public Property SiteNo As String
        Get
            Return _SiteNo
        End Get
        Set(value As String)
            _SiteNo = value
        End Set
    End Property
    Public Property SiteName As String
        Get
            Return _SiteName
        End Get
        Set(value As String)
            _SiteName = value
        End Set
    End Property
    Public Property PlantName As String
        Get
            Return _PlantName
        End Get
        Set(value As String)
            _PlantName = value
        End Set
    End Property
    Public Property SeedTypeName As String
        Get
            Return _SeedTypeName
        End Get
        Set(value As String)
            _SeedTypeName = value
        End Set
    End Property
    Public Property SeedClassName As String
        Get
            Return _SeedClassName
        End Get
        Set(value As String)
            _SeedClassName = value
        End Set
    End Property
    Public Property SeasonName As String
        Get
            Return _SeasonName
        End Get
        Set(value As String)
            _SeasonName = value
        End Set
    End Property
    Public Property SeedYear As String
        Get
            Return _SeedYear
        End Get
        Set(value As String)
            _SeedYear = value
        End Set
    End Property
    Public Property SeedLot As String
        Get
            Return _SeedLot
        End Get
        Set(value As String)
            _SeedLot = value
        End Set
    End Property
    Public Property SubmitDate As Date
        Get
            Return _SubmitDate
        End Get
        Set(value As Date)
            _SubmitDate = value
        End Set
    End Property
    Public Property SubmitBy As String
        Get
            Return _SubmitBy
        End Get
        Set(value As String)
            _SubmitBy = value
        End Set
    End Property
    Public Property KP2ReportDetails As List(Of KP2ReportDetail)
        Get
            Return _KP2ReportDetails
        End Get
        Set(value As List(Of KP2ReportDetail))
            _KP2ReportDetails = value
        End Set
    End Property

End Class
