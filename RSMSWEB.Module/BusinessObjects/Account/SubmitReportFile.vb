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
Imports RSMSWEB.Module.FileSystemData.BusinessObjects
Imports DevExpress.ExpressApp.ConditionalAppearance
Imports RSMSWEB.Module.PublicEnum

'<ImageName("BO_Contact")> _
'<DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")> _
'<DefaultListViewOptions(MasterDetailMode.ListViewOnly, False, NewItemRowPosition.None)> _
'<Persistent("DatabaseTableName")> _
<XafDisplayName("Upload ไฟล์ excel รายงานของศูนย์ฯ")> _
<DefaultClassOptions, FileAttachment("File")> _
Public Class SubmitReportFile ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        Try
            ReportMonth = PublicEnum.EnumMonth.JAN
            ReportQuarter = EnumQuarter.Quarter1
            SiteNo = CType(SecuritySystem.CurrentUser, User).Site.SiteNo
            SiteName = CType(SecuritySystem.CurrentUser, User).Site.SiteName
            ReportBy = CType(SecuritySystem.CurrentUser, User).DisplayName
        Catch ex As Exception

        End Try
        ' Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
    End Sub

    Protected Overrides Sub OnSaved()
        'MyBase.OnSaved()
        'PostSubmitReportLog()
        SubmitCheck = False
    End Sub

    Protected Overrides Sub OnSaving()
        MyBase.OnSaving()
        PostSubmitReportLog()
    End Sub


    Private _SiteNo As String
    <XafDisplayName("รหัสศูนย์ฯ")> _
    Public Property SiteNo() As String
        Get
            Return _SiteNo
        End Get
        Set(ByVal value As String)
            SetPropertyValue("SiteNo", _SiteNo, value)
        End Set
    End Property

    Private _SiteName As String
    <XafDisplayName("ชื่อศูนย์")> _
    Public Property SiteName() As String
        Get
            Return _SiteName
        End Get
        Set(ByVal value As String)
            SetPropertyValue("SiteName", _SiteName, value)
        End Set
    End Property

    'Private _ReportName As String
    '<XafDisplayName("รายงาน")> _
    'Public Property ReportName() As String
    '    Get
    '        Return _ReportName
    '    End Get
    '    Set(ByVal value As String)
    '        SetPropertyValue("ReportName", _ReportName, value)
    '    End Set
    'End Property

    Private _ReportName As ReportCategory
    <XafDisplayName("ชื่อรายงาน")> _
    <Association("ReportLog-ReportCategory", GetType(ReportCategory))> _
    Public Property ReportName() As ReportCategory
        Get
            Return _ReportName
        End Get
        Set(ByVal value As ReportCategory)
            SetPropertyValue("ReportName", _ReportName, value)
        End Set
    End Property

    Private _ReportMonth As EnumMonth
    <XafDisplayName("เดือน")> _
    Public Property ReportMonth() As EnumMonth
        Get
            Return _ReportMonth
        End Get
        Set(ByVal value As EnumMonth)
            SetPropertyValue("ReportMonth", _ReportMonth, value)
        End Set
    End Property

    Private _ReportQuarter As EnumQuarter
    <XafDisplayName("ไตรมาส")> _
    Public Property ReportQuarter() As EnumQuarter
        Get
            Return _ReportQuarter
        End Get
        Set(ByVal value As EnumQuarter)
            SetPropertyValue("ReportQuarter", _ReportQuarter, value)
        End Set
    End Property

    Private _ReportYear As String
    <XafDisplayName("ปีงบประมาณ")> _
    Public Property ReportYear() As String
        Get
            Return _ReportYear
        End Get
        Set(ByVal value As String)
            SetPropertyValue("ReportYear", _ReportYear, value)
        End Set
    End Property

    Private _ReportDate As Date = Now
    <XafDisplayName("วันที่ส่งรายงาน")> _
    <Appearance("SubmitDateAcc", Enabled:=False, Context:="DetailView")> _
    Public Property ReportDate() As Date
        Get
            Return _ReportDate
        End Get
        Set(ByVal value As Date)
            SetPropertyValue("ReportDate", _ReportDate, value)
        End Set
    End Property

    Private _ReportBy As String
    <XafDisplayName("ผู้ส่งรายงาน")> _
    Public Property ReportBy() As String
        Get
            Return _ReportBy
        End Get
        Set(ByVal value As String)
            SetPropertyValue("ReportBy", _ReportBy, value)
        End Set
    End Property

    <XafDisplayName("ไฟล์")> _
    <VisibleInListView(False)> _
        <DevExpress.Xpo.Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never), NoForeignKey, ImmediatePostData> _
    Public Property File() As FileSystemStoreObject
        Get
            Return GetPropertyValue(Of FileSystemStoreObject)("File")
        End Get
        Set(ByVal value As FileSystemStoreObject)
            SetPropertyValue(Of FileSystemStoreObject)("File", value)
        End Set
    End Property

    Public Sub PostSubmitReportLog()
        Try
            If SubmitCheck = False Then
                Dim PostSubmitReportLog As SubmitReportLog = New SubmitReportLog(Session)
                PostSubmitReportLog.SiteNo = SiteNo
                PostSubmitReportLog.SiteName = SiteName
                PostSubmitReportLog.ReportName = ReportName.ReportCatName
                PostSubmitReportLog.ReportYear = ReportYear
                PostSubmitReportLog.ReportMonth = ReportMonth
                PostSubmitReportLog.ReportQuarter = ReportQuarter
                PostSubmitReportLog.ReportDate = ReportDate
                PostSubmitReportLog.ReportBy = ReportBy
                'MyBase.Save()
                SubmitCheck = True
                PostSubmitReportLog.Save()
            End If
        Catch ex As Exception
            Session.RollbackTransaction()
        End Try
    End Sub

End Class
