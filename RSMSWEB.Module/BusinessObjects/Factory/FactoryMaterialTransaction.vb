Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Model
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

<DefaultClassOptions()> _
Public Class FactoryMaterialTransaction
    Inherits BaseObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
    End Sub

    Dim fDataOwner As Site
    <Browsable(False)> _
    Public Property DataOwner() As Site
        Get
            Return fDataOwner
        End Get
        Set(ByVal value As Site)
            SetPropertyValue(Of Site)("DataOwner", fDataOwner, value)
        End Set
    End Property

    Dim fTransactionType As PublicEnum.FactoryTransactionType
    <Size(50)> _
    Public Property TransactionType() As PublicEnum.FactoryTransactionType
        Get
            Return fTransactionType
        End Get
        Set(ByVal value As PublicEnum.FactoryTransactionType)
            SetPropertyValue(Of PublicEnum.FactoryTransactionType)("TransactionType", fTransactionType, value)
        End Set
    End Property
    Dim fRefNo As String
    <Size(50)> _
    Public Property RefNo() As String
        Get
            Return fRefNo
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("RefNo", fRefNo, value)
        End Set
    End Property
    'Dim fPickRefNo As String
    '<Size(50)> _
    'Public Property PickRefNo() As String
    '    Get
    '        Return fPickRefNo
    '    End Get
    '    Set(ByVal value As String)
    '        SetPropertyValue(Of String)("PickRefNo", fPickRefNo, value)
    '    End Set
    'End Property
    Dim fMaterialProduct As MaterialProduct
    Public Property MaterialProduct() As MaterialProduct
        Get
            Return fMaterialProduct
        End Get
        Set(ByVal value As MaterialProduct)
            SetPropertyValue(Of MaterialProduct)("MaterialProduct", fMaterialProduct, value)
        End Set
    End Property
    Dim fProductCode As String
    <Size(50)> _
    Public Property ProductCode() As String
        Get
            Return fProductCode
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("ProductCode", fProductCode, value)
        End Set
    End Property
    Dim fProductName As String
    Public Property ProductName() As String
        Get
            Return fProductName
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("ProductName", fProductName, value)
        End Set
    End Property
    Dim fIncome As Double
    Public Property Income() As Double
        Get
            Return fIncome
        End Get
        Set(ByVal value As Double)
            SetPropertyValue(Of Double)("Income", fIncome, value)
        End Set
    End Property
    Dim fOutcome As Double
    Public Property Outcome() As Double
        Get
            Return fOutcome
        End Get
        Set(ByVal value As Double)
            SetPropertyValue(Of Double)("Outcome", fOutcome, value)
        End Set
    End Property
    Dim fFactoryNo As PublicEnum.EnumFactoryNo
    Public Property FactoryNo() As PublicEnum.EnumFactoryNo
        Get
            Return fFactoryNo
        End Get
        Set(ByVal value As PublicEnum.EnumFactoryNo)
            SetPropertyValue(Of PublicEnum.EnumFactoryNo)("FactoryNo", fFactoryNo, value)
        End Set
    End Property
    Dim fTransactionDate As DateTime
    Public Property TransactionDate() As DateTime
        Get
            Return fTransactionDate
        End Get
        Set(ByVal value As DateTime)
            SetPropertyValue(Of DateTime)("TransactionDate", fTransactionDate, value)
        End Set
    End Property
    Dim fTransactionBy As String
    <Size(50)> _
    Public Property TransactionBy() As String
        Get
            Return fTransactionBy
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("TransactionBy", fTransactionBy, value)
        End Set
    End Property
    Dim fRemark As String
    <Size(200)> _
    Public Property Remark() As String
        Get
            Return fRemark
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("Remark", fRemark, value)
        End Set
    End Property
    Dim fIsDelete As Boolean
    <Browsable(False)> _
    Public Property IsDelete() As Boolean
        Get
            Return fIsDelete
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue(Of Boolean)("IsDelete", fIsDelete, value)
        End Set
    End Property

End Class
