Public Class ActivityPlanReportData

    Private _SiteNo As String
    Private _SiteName As String
    Private _PlantName As String
    Private _SeedTypeName As String
    Private _SeedClassName As String
    Private _SeasonName As String
    Private _SeedYear As String
    Private _SeedLot As String
    Private _GoalQuantity As Double
    Private _BuyQuantity As Double
    Private _TotalAreaSize As Integer
    Private _TotalFarmerGroup As Integer
    Private _TotalFarmer As Integer
    Private _SubmitDate As Date
    Private _SubmitBy As String

    Private _GrowPlanDetails As List(Of GrowPlanDetail)
    Private _HarvestPlanDetails As List(Of HarvestPlanDetail)
    Private _BuyPlanDetails As List(Of BuyPlanDetail)
    
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

    Public Property GoalQuantity As Double
        Get
            Return _GoalQuantity
        End Get
        Set(value As Double)
            _GoalQuantity = value
        End Set
    End Property
    Public Property BuyQuantity As Double
        Get
            Return _BuyQuantity
        End Get
        Set(value As Double)
            _BuyQuantity = value
        End Set
    End Property
    Public Property TotalAreaSize As Integer
        Get
            Return _TotalAreaSize
        End Get
        Set(value As Integer)
            _TotalAreaSize = value
        End Set
    End Property
    Public Property TotalFarmerGroup As Integer
        Get
            Return _TotalFarmerGroup
        End Get
        Set(value As Integer)
            _TotalFarmerGroup = value
        End Set
    End Property
    Public Property TotalFarmer As Integer
        Get
            Return _TotalFarmer
        End Get
        Set(value As Integer)
            _TotalFarmer = value
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
    Public Property GrowPlanDetails As List(Of GrowPlanDetail)
        Get
            Return _GrowPlanDetails
        End Get
        Set(value As List(Of GrowPlanDetail))
            _GrowPlanDetails = value
        End Set
    End Property
    Public Property HarvestPlanDetails As List(Of HarvestPlanDetail)
        Get
            Return _HarvestPlanDetails
        End Get
        Set(value As List(Of HarvestPlanDetail))
            _HarvestPlanDetails = value
        End Set
    End Property
    Public Property BuyPlanDetails As List(Of BuyPlanDetail)
        Get
            Return _BuyPlanDetails
        End Get
        Set(value As List(Of BuyPlanDetail))
            _BuyPlanDetails = value
        End Set
    End Property

End Class
