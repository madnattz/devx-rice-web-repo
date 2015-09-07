Public Class KP5ReportDetail

    Private _FarmerNo As String
    Private _FarmerName As String
    Private _FarmerGroupNo As String
    Private _FarmerGroupName As String
    Private _AddressNo As String
    Private _Moo As String
    Private _Tambol As String
    Private _Amphur As String
    Private _Province As String
    Private _AreaSize As Integer
    Private _QuantityPerUnit As Integer
    Private _BuyQuantity As Integer
    Private _IsMaxBuyFarmer As Boolean
    Private _SeedPrice As Double

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
    Public Property AreaSize As Integer
        Get
            Return _AreaSize
        End Get
        Set(value As Integer)
            _AreaSize = value
        End Set
    End Property
    Public Property QuantityPerUnit As Integer
        Get
            Return _QuantityPerUnit
        End Get
        Set(value As Integer)
            _QuantityPerUnit = value
        End Set
    End Property
    
    Public Property BuyQuantity As Integer
        Get
            Return _BuyQuantity
        End Get
        Set(value As Integer)
            _BuyQuantity = value
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

    Public Property SeedPrice As Double
        Get
            Return _SeedPrice
        End Get
        Set(value As Double)
            _SeedPrice = value
        End Set
    End Property

End Class
