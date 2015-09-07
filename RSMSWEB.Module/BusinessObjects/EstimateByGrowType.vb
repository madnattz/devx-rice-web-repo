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
Public Class EstimateByGrowType ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
    End Sub

    Private fGrowType As GrowType
    <ImmediatePostData> _
    <RuleRequiredField(DefaultContexts.Save)> _
    Public Property GrowType() As GrowType
        Get
            Return fGrowType
        End Get
        Set(ByVal value As GrowType)
            SetPropertyValue("GrowType", fGrowType, value)
        End Set
    End Property

    Dim fSeedUsePerArea As Double
    <ImmediatePostData> _
    <RuleRequiredField(DefaultContexts.Save)> _
     Public Property SeedUsePerArea() As Double
        Get
            Return fSeedUsePerArea
        End Get
        Set(ByVal value As Double)
            SetPropertyValue(Of Double)("SeedUsePerArea", fSeedUsePerArea, value)
        End Set
    End Property

    Dim fQuantityPerArea As Double
    <ImmediatePostData> _
    <RuleRequiredField(DefaultContexts.Save)> _
     Public Property QuantityPerArea() As Double
        Get
            Return fQuantityPerArea
        End Get
        Set(ByVal value As Double)
            SetPropertyValue(Of Double)("QuantityPerArea", fQuantityPerArea, value)
        End Set
    End Property

    Private fSeedPrice As SeedPrice
    <ImmediatePostData> _
    <Association("SeedPrice-EstimateByGrowTypes", GetType(SeedPrice))> _
     Public Property SeedPrice() As SeedPrice
        Get
            Return fSeedPrice
        End Get
        Set(ByVal value As SeedPrice)
            SetPropertyValue("SeedPrice", fSeedPrice, value)
        End Set
    End Property


End Class
