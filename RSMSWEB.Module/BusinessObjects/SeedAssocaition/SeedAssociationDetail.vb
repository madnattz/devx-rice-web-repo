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
'<NavigationItem("ข้อมูลสมาคมผู้รวบรวม/ชมรมผู้ผลิตเมล็ดพันธุ์")> _
<XafDisplayName("ข้อมูลรายละเอียด")> _
<NonPersistent> _
Public Class SeedAssociationDetail ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
    End Sub

    'Private _PersistentProperty As String
    '<XafDisplayName("My display name"), ToolTip("My hint message")> _
    '<ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(False)> _
    '<Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)> _
    'Public Property PersistentProperty() As String
    '    Get
    '        Return _PersistentProperty
    '    End Get
    '    Set(ByVal value As String)
    '        SetPropertyValue("PersistentProperty", _PersistentProperty, value)
    '    End Set
    'End Property

    '<Action(Caption:="My UI Action", ConfirmationMessage:="Are you sure?", ImageName:="Attention", AutoCommit:=True)> _
    'Public Sub ActionMethod()
    '    ' Trigger a custom business logic for the current record in the UI (http://documentation.devexpress.com/#Xaf/CustomDocument2619).
    '    Me.PersistentProperty = "Paid"
    'End Sub

    Dim _ItemNo As String
    <XafDisplayName("ลำดับ")> _
    <Index(0)> _
    <VisibleInDetailView(True), VisibleInListView(True)> _
    Public Property ItemNo() As String
        Get
            Return _ItemNo
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("ItemNo", _ItemNo, value)
        End Set
    End Property

    Dim _FullName As String
    <XafDisplayName("ชื่อ - นามสกุล")> _
    <VisibleInDetailView(True), VisibleInListView(True)> _
    Public Property FullName() As String
        Get
            Return _FullName
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("FullName", _FullName, value)
        End Set
    End Property


    Dim _FullAdress As String
    <XafDisplayName("ทีอยู่")> _
    <VisibleInDetailView(True), VisibleInListView(True)> _
    Public Property FullAdress() As String
        Get
            Return _FullAdress
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("FullAdress", _FullAdress, value)
        End Set
    End Property

    Dim _BusinessType As String
    <XafDisplayName("ประเภทธุรกิจ")> _
    <VisibleInDetailView(True), VisibleInListView(True)> _
    Public Property BusinessType() As String
        Get
            Return _BusinessType
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("BusinessType", _BusinessType, value)
        End Set
    End Property

    Dim _BusinessName As String
    <XafDisplayName("ชื่อธุรกิจ")> _
    <VisibleInDetailView(True), VisibleInListView(True)> _
    Public Property BusinessName() As String
        Get
            Return _BusinessName
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("BusinessName", _BusinessName, value)
        End Set
    End Property

    Dim _TelephoneNo As String
    <XafDisplayName("โทรศัพท์")> _
    <VisibleInDetailView(True), VisibleInListView(True)> _
    Public Property TelephoneNo() As String
        Get
            Return _TelephoneNo
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("TelephoneNo", _TelephoneNo, value)
        End Set
    End Property


    Dim _Position As String
    <XafDisplayName("ตำแหน่ง")> _
    <VisibleInDetailView(True), VisibleInListView(True)> _
    Public Property Position() As String
        Get
            Return _Position
        End Get
        Set(ByVal value As String)
            SetPropertyValue(Of String)("Position", _Position, value)
        End Set
    End Property



End Class
