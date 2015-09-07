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
Imports DevExpress.Xpo.DB
Imports System.Configuration
Imports Microsoft.ApplicationBlocks.Data
'<ImageName("BO_Contact")> _
'<DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")> _
'<DefaultListViewOptions(MasterDetailMode.ListViewOnly, False, NewItemRowPosition.None)> _
'<Persistent("DatabaseTableName")> _
'<NavigationItem("ข้อมูลสมาคมผู้รวบรวม/ชมรมผู้ผลิตเมล็ดพันธุ์")> _
<DefaultClassOptions(), XafDisplayName("สมาคมผู้รวบรวมและจำหน่ายเมล็ดพันธุ์ข้าว (Rice Seed Complier and Supplier Association)")> _
Public Class SeedAssosiation ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        Address = New CustomAddress(Session)
        SearchData = SearchByData.All
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

    Dim _Address As CustomAddress
    <DC.Aggregated, ExpandObjectMembers(ExpandObjectMembers.Always)> _
    <VisibleInListView(False)> _
    Public Property Address() As CustomAddress
        Get
            Return _Address
        End Get
        Set(ByVal value As CustomAddress)
            SetPropertyValue(Of CustomAddress)("Address", _Address, value)
        End Set
    End Property

    <XafDisplayName("ที่ทำการสมาคม")> _
    <VisibleInDetailView(False), VisibleInListView(True)> _
    Public ReadOnly Property FullAddress As String
        Get
            Return Address.FullAddress
        End Get
    End Property

    Dim _SearchData As SearchByData
    <XafDisplayName("ค้นหา")> _
    <VisibleInDetailView(True), VisibleInListView(False)> _
    Public Property SearchData() As SearchByData
        Get
            Return _SearchData
        End Get
        Set(ByVal value As SearchByData)
            SetPropertyValue(Of SearchByData)("SearchData", _SearchData, value)
            OnChanged("SeedAssociationLists")
        End Set
    End Property

    Dim CollectionList As New BindingList(Of SeedAssociationDetail)
    <Action(Caption:="ดึงข้อมูล", ConfirmationMessage:="ท่านต้องการดึงข้อมูลใช่หรือไม่?", ImageName:="Action_Grant", AutoCommit:=True)> _
    Public Function LoadData()

        Dim strConnection As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        'Dim dal As IDataLayer = XpoDefault.GetDataLayer(MSSqlConnectionProvider.GetConnectionString(strConnection), AutoCreateOption.None)
        'Dim Session1 As New Session(dal)
        'Dim data As SelectedData
        Dim ds As DataSet
        Dim cmd As String = ""
        Select Case SearchData
            Case SearchByData.All
                cmd = "SP_GetSeedAssociationAllData"
            Case SearchByData.Committes
                cmd = "SP_GetSeedAssociationCommittes"
            Case SearchByData.Members
                cmd = "SP_GetSeedAssociationMembers"
            Case SearchByData.SeedClubs
                cmd = "SP_GetSeedAssociationSeedClubs"
        End Select

        ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, cmd)
        GetSP_Data(ds, SearchData)

    End Function
    Public Function GetSP_Data(Data As DataSet, SearchData As Integer)
        SeedAssociationLists.Clear()
        Try
            If Data.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To Data.Tables(0).Rows.Count - 1
                    Dim TmpData As New SeedAssociationDetail(Session)
                    TmpData.ItemNo = Data.Tables(0).Rows(i).Item("Row")
                    TmpData.FullName = Data.Tables(0).Rows(i).Item("FullName")
                    TmpData.FullAdress = Data.Tables(0).Rows(i).Item("FullAddress")
                    TmpData.BusinessType = Data.Tables(0).Rows(i).Item("BusinessType")
                    TmpData.BusinessName = Data.Tables(0).Rows(i).Item("BusinessName")
                    TmpData.TelephoneNo = Data.Tables(0).Rows(i).Item("TelephoneNo")
                    If SearchData = 3 Then
                        TmpData.BusinessType = Data.Tables(0).Rows(i).Item("BusinessType")
                        TmpData.BusinessName = Data.Tables(0).Rows(i).Item("SeedClubs")
                        TmpData.Position = Data.Tables(0).Rows(i).Item("ClubPosition")
                    Else
                        TmpData.Position = Data.Tables(0).Rows(i).Item("AssoPosition")
                    End If

                    CollectionList.Add(TmpData)
                Next

                'For Each row As SelectStatementResultRow In Data.ResultSet(0).Rows
                '    If row IsNot Nothing Then
                '        Dim TmpData As New SeedAssociationDetail(Session)
                '        TmpData.FullName = row.Values(0)
                '        TmpData.FullAdress = row.Values(1)
                '        TmpData.BusinessType = row.Values(2)
                '        TmpData.BusinessName = row.Values(3)
                '        TmpData.TelephoneNo = row.Values(4)
                '        TmpData.Position = row.Values(5)
                '        CollectionList.Add(TmpData)
                '    End If
                'Next
            End If
            Return CollectionList
        Catch ex As Exception
            Return False
        End Try
    End Function
    <XafDisplayName("รายชื่อสมาชิก")> _
    Public ReadOnly Property SeedAssociationLists() As BindingList(Of SeedAssociationDetail)
        Get
            Return CollectionList
        End Get
    End Property

End Class
Public Enum SearchByData
    <XafDisplayName(" - - - - - ทั้งหมด - - - - - "), ImageName("Action_View_Chart")>
    All = 0
    <XafDisplayName("คณะกรรมการสมาคมผู้รวบรวมและจำหน่ายเมล็ดพันธุ์ข้าว"), ImageName("BO_Customer")>
    Committes = 1
    <XafDisplayName("สมาชิกสมาคมผู้รวบรวมและจำหน่ายเมล็ดพันธุ์ข้าว"), ImageName("BO_Person")>
    Members = 2
    <XafDisplayName("ชมรมผู้ผิลตและจำหน่ายเมล็ดพันธุ์ข้าว"), ImageName("BO_Resume")>
    SeedClubs = 3
End Enum