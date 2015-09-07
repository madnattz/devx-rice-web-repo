Public Class KP3ReportDetail

    Private _FarmerNo As String
    Private _FarmerName As String
    Private _FarmerGroupNo As String
    Private _FarmerGroupName As String
    Private _AddressNo As String
    Private _Moo As String
    Private _Tambol As String
    Private _Amphur As String
    Private _Province As String
    Private _GroupAddressNo As String
    Private _GroupMoo As String
    Private _GroupTambol As String
    Private _GroupAmphur As String
    Private _GroupProvince As String
    Private _AreaSize As Integer
    Private _SeedRecieveQuantity As Integer
    Private _SeedUseQuantity As Integer
    Private _SeedGoalQuantity As Integer
    Private _GrowStartDate As Date
    Private _GrowEndDate As Date
    Private _CheckFarmStartDate As Date
    Private _CheckFarmEndDate As Date
    Private _HarvestStartDate As Date
    Private _HarvestEndDate As Date
    Private _BuyStartDate As Date
    Private _BuyEndDate As Date
    Private _ProcessStartDate As Date
    Private _ProcessEndDate As Date
    Private _MarketStartDate As Date
    Private _MarketEndDate As Date
    Private _IsMaxBuyFarmer As Boolean

    Public Sub New()

    End Sub

    Public Property FarmerNo As String
        Get
            Return _FarmerNo
        End Get
        Set(value As String)
            _FarmerNo = value
        End Set
    End Property
    Public Property FarmerName As String
        Get
            Return _FarmerName
        End Get
        Set(value As String)
            _FarmerName = value
        End Set
    End Property
    Public Property FarmerGroupNo As String
        Get
            Return _FarmerGroupNo
        End Get
        Set(value As String)
            _FarmerGroupNo = value
        End Set
    End Property
    Public Property FarmerGroupName As String
        Get
            Return _FarmerGroupName
        End Get
        Set(value As String)
            _FarmerGroupName = value
        End Set
    End Property
    Public Property AddressNo As String
        Get
            Return _AddressNo
        End Get
        Set(value As String)
            _AddressNo = value
        End Set
    End Property
    Public Property Moo As String
        Get
            Return _Moo
        End Get
        Set(value As String)
            _Moo = value
        End Set
    End Property
    Public Property Tambol As String
        Get
            Return _Tambol
        End Get
        Set(value As String)
            _Tambol = value
        End Set
    End Property
    Public Property Amphur As String
        Get
            Return _Amphur
        End Get
        Set(value As String)
            _Amphur = value
        End Set
    End Property
    Public Property Province As String
        Get
            Return _Province
        End Get
        Set(value As String)
            _Province = value
        End Set
    End Property
    Public Property GroupAddressNo As String
        Get
            Return _GroupAddressNo
        End Get
        Set(value As String)
            _GroupAddressNo = value
        End Set
    End Property
    Public Property GroupMoo As String
        Get
            Return _GroupMoo
        End Get
        Set(value As String)
            _GroupMoo = value
        End Set
    End Property
    Public Property GroupTambol As String
        Get
            Return _GroupTambol
        End Get
        Set(value As String)
            _GroupTambol = value
        End Set
    End Property
    Public Property GroupAmphur As String
        Get
            Return _GroupAmphur
        End Get
        Set(value As String)
            _GroupAmphur = value
        End Set
    End Property
    Public Property GroupProvince As String
        Get
            Return _GroupProvince
        End Get
        Set(value As String)
            _GroupProvince = value
        End Set
    End Property
    Public Property AreaSize As Integer
        Get
            Return _AreaSize
        End Get
        Set(value As Integer)
            _AreaSize = value
        End Set
    End Property
    Public Property SeedRecieveQuantity As Integer
        Get
            Return _SeedRecieveQuantity
        End Get
        Set(value As Integer)
            _SeedRecieveQuantity = value
        End Set
    End Property
    Public Property SeedUseQuantity As Integer
        Get
            Return _SeedUseQuantity
        End Get
        Set(value As Integer)
            _SeedUseQuantity = value
        End Set
    End Property
    Public Property SeedGoalQuantity As Integer
        Get
            Return _SeedGoalQuantity
        End Get
        Set(value As Integer)
            _SeedGoalQuantity = value
        End Set
    End Property
    Public Property IsMaxBuyFarmer As Boolean
        Get
            Return _IsMaxBuyFarmer
        End Get
        Set(value As Boolean)
            _IsMaxBuyFarmer = value
        End Set
    End Property

    Public Property GrowStartDate As Date
        Get
            Return _GrowStartDate
        End Get
        Set(value As Date)
            _GrowStartDate = value
        End Set
    End Property
    Public Property GrowEndDate As Date
        Get
            Return _GrowEndDate
        End Get
        Set(value As Date)
            _GrowEndDate = value
        End Set
    End Property

    Public Property CheckFarmStartDate As Date
        Get
            Return _CheckFarmStartDate
        End Get
        Set(value As Date)
            _CheckFarmStartDate = value
        End Set
    End Property
    Public Property CheckFarmEndDate As Date
        Get
            Return _CheckFarmEndDate
        End Get
        Set(value As Date)
            _CheckFarmEndDate = value
        End Set
    End Property

    Public Property HarvestStartDate As Date
        Get
            Return _HarvestStartDate
        End Get
        Set(value As Date)
            _HarvestStartDate = value
        End Set
    End Property
    Public Property HarvestEndDate As Date
        Get
            Return _HarvestEndDate
        End Get
        Set(value As Date)
            _HarvestEndDate = value
        End Set
    End Property

    Public Property BuyStartDate As Date
        Get
            Return _BuyStartDate
        End Get
        Set(value As Date)
            _BuyStartDate = value
        End Set
    End Property
    Public Property BuyEndDate As Date
        Get
            Return _BuyEndDate
        End Get
        Set(value As Date)
            _BuyEndDate = value
        End Set
    End Property

    Public Property ProcessStartDate As Date
        Get
            Return _ProcessStartDate
        End Get
        Set(value As Date)
            _ProcessStartDate = value
        End Set
    End Property
    Public Property ProcessEndDate As Date
        Get
            Return _ProcessEndDate
        End Get
        Set(value As Date)
            _ProcessEndDate = value
        End Set
    End Property

    Public Property MarketStartDate As Date
        Get
            Return _MarketStartDate
        End Get
        Set(value As Date)
            _MarketStartDate = value
        End Set
    End Property
    Public Property MarketEndDate As Date
        Get
            Return _MarketEndDate
        End Get
        Set(value As Date)
            _MarketEndDate = value
        End Set
    End Property

End Class
