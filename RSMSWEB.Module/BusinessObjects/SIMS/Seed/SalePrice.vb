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

'<ImageName("BO_Contact")> _
'<DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")> _
'<DefaultListViewOptions(MasterDetailMode.ListViewOnly, False, NewItemRowPosition.None)> _
'<Persistent("DatabaseTableName")> _
<DefaultClassOptions()> _
<XafDisplayName("�ҤҨ�˹������紾ѹ���")> _
Public Class SalePrice ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
    End Sub
    Protected Overrides Sub OnSaving()
        Me.LastUodateDate = Date.Now
        Me.LastUpdateBy = CType(SecuritySystem.CurrentUser, User).DisplayName
        MyBase.OnSaving()
    End Sub

    Dim fPlant As Plant
    <RuleRequiredField(DefaultContexts.Save)> _
    <XafDisplayName("�ת")> _
    Public Property Plant() As Plant
        Get
            Return fPlant
        End Get
        Set(ByVal value As Plant)
            SetPropertyValue(Of Plant)("Plant", fPlant, value)
        End Set
    End Property
    Dim fSeedType As SeedType
    <RuleRequiredField(DefaultContexts.Save)> _
    <DataSourceProperty("Plant.SeedTypes")> _
    <XafDisplayName("�ѹ���")> _
    Public Property SeedType() As SeedType
        Get
            Return fSeedType
        End Get
        Set(ByVal value As SeedType)
            SetPropertyValue(Of SeedType)("SeedType", fSeedType, value)
        End Set
    End Property

    Dim fSeedClass As SeedClass
    <RuleRequiredField(DefaultContexts.Save)> _
    <XafDisplayName("��鹾ѹ���")> _
    Public Property SeedClass() As SeedClass
        Get
            Return fSeedClass
        End Get
        Set(ByVal value As SeedClass)
            SetPropertyValue(Of SeedClass)("SeedClass", fSeedClass, value)
        End Set
    End Property
    Dim fPrice As Double
    <RuleValueComparison(DefaultContexts.Save, ValueComparisonType.GreaterThan, 0)> _
    <XafDisplayName("�ҤҨ�˹��� (�ҷ)")> _
    Public Property Price() As Double
        Get
            Return fPrice
        End Get
        Set(ByVal value As Double)
            SetPropertyValue(Of Double)("Price", fPrice, value)
        End Set
    End Property
    Dim fEffectiveDate As DateTime
    <RuleRequiredField(DefaultContexts.Save)> _
    <XafDisplayName("�ѹ���ѧ�Ѻ��")> _
    Public Property EffectiveDate() As DateTime
        Get
            Return fEffectiveDate
        End Get
        Set(ByVal value As DateTime)
            SetPropertyValue(Of DateTime)("EffectiveDate", fEffectiveDate, value)
        End Set
    End Property
    Dim fRemark As String
    <Size(200)> _
    <XafDisplayName("�����˵�")> _
    Public Property Remark() As String
        Get
            Return fRemark
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("Remark", fRemark, value)
        End Set
    End Property
    Dim fStatus As PublicEnum.PublicStatus
    <XafDisplayName("ʶҹ�")> _
    Public Property Status() As PublicEnum.PublicStatus
        Get
            Return fStatus
        End Get
        Set(ByVal value As PublicEnum.PublicStatus)
            SetPropertyValue(Of PublicEnum.PublicStatus)("Status", fStatus, value)
        End Set
    End Property
    Dim fLastUpdateBy As String
    <XafDisplayName("���ͼ���Ѻ��ا������")> _
     Public Property LastUpdateBy() As String
        Get
            Return fLastUpdateBy
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("LastUpdateBy", fLastUpdateBy, value)
        End Set
    End Property
    Dim fLastUodateDate As DateTime
    <XafDisplayName("�ѹ����Ѻ��ا���������ش")> _
    Public Property LastUodateDate() As DateTime
        Get
            Return fLastUodateDate
        End Get
        Set(ByVal value As DateTime)
            SetPropertyValue(Of DateTime)("LastUodateDate", fLastUodateDate, value)
        End Set
    End Property
End Class
