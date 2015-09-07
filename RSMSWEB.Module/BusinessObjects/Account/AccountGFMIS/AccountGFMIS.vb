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
<NavigationItem("รายรับ รายจ่าย เงินทุนหมุนฯ")> _
<XafDisplayName("GFMIS")> _
<DefaultClassOptions()> _
Public Class AccountGFMIS ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
    End Sub

    Protected Overrides Sub OnLoaded()
        Reset()
        MyBase.OnLoaded()
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

    Private _MonthTrialBalance As PublicEnum.EnumMonth
    <XafDisplayName("เดือน")> _
    <Index(0), VisibleInListView(True), VisibleInDetailView(True), VisibleInLookupListView(True)> _
    <RuleRequiredField(DefaultContexts.Save)> _
    Public Property MonthTrialBalance() As PublicEnum.EnumMonth
        Get
            Return _MonthTrialBalance
        End Get
        Set(ByVal value As PublicEnum.EnumMonth)
            SetPropertyValue("MonthTrialBalance", _MonthTrialBalance, value)
        End Set
    End Property

    Private _YearID As String
    <XafDisplayName("ปี")> _
    <Index(1), VisibleInListView(True), VisibleInDetailView(True), VisibleInLookupListView(True)> _
    Public Property YearID() As String
        Get
            Return _YearID
        End Get
        Set(ByVal value As String)
            SetPropertyValue("YearID", _YearID, value)
        End Set
    End Property

    <XafDisplayName("รายงาน รายรับ")> _
<Association("AccountGFMIS-AccountGFMISDetailRV", GetType(AccountGFMISDetailRV))> _
<DC.Aggregated()> _
    Public ReadOnly Property AccountGFMISDetailRV() As XPCollection(Of AccountGFMISDetailRV)
        Get
            Return GetCollection(Of AccountGFMISDetailRV)("AccountGFMISDetailRV")
        End Get
    End Property

    <XafDisplayName("รายงาน รายจ่าย")> _
<Association("AccountGFMIS-AccountGFMISDetailPV", GetType(AccountGFMISDetailPV))> _
<DC.Aggregated()> _
    Public ReadOnly Property AccountGFMISDetailPV() As XPCollection(Of AccountGFMISDetailPV)
        Get
            Return GetCollection(Of AccountGFMISDetailPV)("AccountGFMISDetailPV")
        End Get
    End Property

    '<Action(Caption:="My UI Action", ConfirmationMessage:="Are you sure?", ImageName:="Attention", AutoCommit:=True)> _
    'Public Sub ActionMethod()
    '    ' Trigger a custom business logic for the current record in the UI (http://documentation.devexpress.com/#Xaf/CustomDocument2619).
    '    Me.PersistentProperty = "Paid"
    'End Sub
End Class
