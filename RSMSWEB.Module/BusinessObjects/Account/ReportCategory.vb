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
<XafDisplayName("��������§ҹ ����Ѻ����觢�����")> _
<DefaultClassOptions()> _
Public Class ReportCategory ' Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (http://documentation.devexpress.com/#Xaf/CustomDocument3146).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).
    End Sub

    Private _ReportCatName As String
    <XafDisplayName("������§ҹ"), ToolTip("������§ҹ")> _
    <Index(0), VisibleInListView(True)> _
    <Persistent("ReportName"), RuleRequiredField(DefaultContexts.Save)> _
    Public Property ReportCatName() As String
        Get
            Return _ReportCatName
        End Get
        Set(ByVal value As String)
            SetPropertyValue("ReportCatName", _ReportCatName, value)
        End Set
    End Property

    <Association("ReportLog-ReportCategory", GetType(SubmitReportFile))> _
    Public ReadOnly Property ReportName() As XPCollection
        Get
            Return GetCollection("ReportName")
        End Get
    End Property

    '<Action(Caption:="My UI Action", ConfirmationMessage:="Are you sure?", ImageName:="Attention", AutoCommit:=True)> _
    'Public Sub ActionMethod()
    '    ' Trigger a custom business logic for the current record in the UI (http://documentation.devexpress.com/#Xaf/CustomDocument2619).
    '    Me.PersistentProperty = "Paid"
    'End Sub
End Class