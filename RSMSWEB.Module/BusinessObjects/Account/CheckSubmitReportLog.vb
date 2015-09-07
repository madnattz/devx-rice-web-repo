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
Imports RSMSWEB.Module
Imports RSMSWEB.Module.PublicEnum

'<ImageName("BO_Contact")> _
'<DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")> _
'<DefaultListViewOptions(MasterDetailMode.ListViewOnly, False, NewItemRowPosition.None)> _
'<Persistent("DatabaseTableName")> _
<DefaultClassOptions()> _
<XafDisplayName("¢éÍÁÙÅ¡ÒÃà»Ô´»Ô´ÃÒÂ§Ò¹¢Í§ÈÙ¹ÂìÏ")> _
Public Class CheckSubmitReportLog ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        Me.ReportMonth = PublicEnum.EnumMonth.JAN
        Me.ReportQuarter = EnumQuarter.Quarter1
        ' Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
    End Sub

    Private _SiteNo As String
    <XafDisplayName("ÃËÑÊÈÙ¹ÂìÏ")> _
    Public Property SiteNo() As String
        Get
            Return _SiteNo
        End Get
        Set(ByVal value As String)
            SetPropertyValue("SiteNo", _SiteNo, value)
        End Set
    End Property

    Private _SiteName As Site
    <XafDisplayName("ª×èÍÈÙ¹Âì")> _
    Public Property SiteName() As Site
        Get
            Return _SiteName
        End Get
        Set(ByVal value As Site)
            SetPropertyValue("SiteName", _SiteName, value)
            If SiteName IsNot Nothing Then
                SiteOid = SiteName.Oid.ToString
            End If
        End Set
    End Property

    Private _SiteOid As String
    <XafDisplayName("OidÈÙ¹Âì")> _
    <VisibleInListView(False), VisibleInDetailView(False), VisibleInLookupListView(False)> _
    Public Property SiteOid() As String
        Get
            Return _SiteOid
        End Get
        Set(ByVal value As String)
            SetPropertyValue("SiteOid", _SiteOid, value)
        End Set
    End Property

    Private _ReportName As SettingReportName
    <XafDisplayName("ÃÒÂ§Ò¹")> _
    Public Property ReportName() As SettingReportName
        Get
            Return _ReportName
        End Get
        Set(ByVal value As SettingReportName)
            SetPropertyValue("ReportName", _ReportName, value)
        End Set
    End Property

    Private _ReportYear As String
    <XafDisplayName("»Õ§º»ÃÐÁÒ³")> _
    Public Property ReportYear() As String
        Get
            Return _ReportYear
        End Get
        Set(ByVal value As String)
            SetPropertyValue("ReportYear", _ReportYear, value)
        End Set
    End Property

    Private _ReportMonth As EnumMonth
    <XafDisplayName("à´×Í¹")> _
    Public Property ReportMonth() As EnumMonth
        Get
            Return _ReportMonth
        End Get
        Set(ByVal value As EnumMonth)
            SetPropertyValue("ReportMonth", _ReportMonth, value)
        End Set
    End Property

    Private _ReportQuarter As EnumQuarter
    <XafDisplayName("äµÃÁÒÊ")> _
    Public Property ReportQuarter() As EnumQuarter
        Get
            Return _ReportQuarter
        End Get
        Set(ByVal value As EnumQuarter)
            SetPropertyValue("ReportQuarter", _ReportQuarter, value)
        End Set
    End Property

    Private _StatusCheck As PublicEnum.SubmitReportCheck = PublicEnum.SubmitReportCheck.Close
    <XafDisplayName("Ê¶Ò¹Ð")> _
    Public Property StatusCheck() As PublicEnum.SubmitReportCheck
        Get
            Return _StatusCheck
        End Get
        Set(ByVal value As PublicEnum.SubmitReportCheck)
            SetPropertyValue("StatusCheck", _StatusCheck, value)
        End Set
    End Property
End Class
