Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.ExpressApp.Layout
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.ExpressApp.Model.NodeGenerators
Imports DevExpress.Xpo

' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppViewControllertopic.
Partial Public Class ViewController1
    Inherits ViewController

    Private objSpace As IObjectSpace

    Public Sub New()
        InitializeComponent()
        ' Target required Views (via the TargetXXX properties) and create their Actions.
    End Sub
    Protected Overrides Sub OnActivated()
        MyBase.OnActivated()
        ' Perform various tasks depending on the target View.
    End Sub
    Protected Overrides Sub OnViewControlsCreated()
        MyBase.OnViewControlsCreated()
        ' Access and customize the target View control.
    End Sub
    Protected Overrides Sub OnDeactivated()
        ' Unsubscribe from previously subscribed events and release other references and resources.
        MyBase.OnDeactivated()
    End Sub

    Private Sub ParametrizedAction1_Execute(sender As Object, e As ParametrizedActionExecuteEventArgs)

    End Sub

    Private Sub PopupWindowShowAction1_Execute(sender As Object, e As PopupWindowShowActionExecuteEventArgs) Handles PopupWindowShowAction1.Execute
        Dim obj As CheckReportLogYearParameter = e.PopupWindowViewCurrentObject
        Dim _year As String = obj.CheckYear

        '//====================
        Dim result As IList(Of Site) = objSpace.GetObjects(Of Site)(CriteriaOperator.Parse("SiteType = 3"))
        Dim reportnames() As String = {"รายงาน รายรับ - รายจ่าย  (งท.03)", "รายงาน สงป."}
        Dim reportnamesquarter As String = "รายงาน รายไตรมาส (งบดุล งบรายได้ค่าใช้จ่าย)"
        If result.Count >= 0 Then
            For Each TblSite As Site In result
                For i As Integer = 0 To 11
                    For j As Integer = 0 To reportnames.Length - 1
                        Dim objDetail = objSpace.CreateObject(Of CheckSubmitReportLog)()
                        Dim objReport As SettingReportName = objSpace.FindObject(Of SettingReportName)(CriteriaOperator.Parse("ReportName = ?", reportnames(j)))
                        objDetail.SiteNo = TblSite.SiteNo
                        objDetail.SiteName = TblSite
                        objDetail.SiteOid = TblSite.Oid.ToString
                        objDetail.ReportName = objReport
                        objDetail.ReportYear = _year
                        objDetail.ReportMonth = i + 1
                        objDetail.ReportQuarter = PublicEnum.EnumQuarter.Quarter1
                        objDetail.StatusCheck = PublicEnum.SubmitReportCheck.Close
                        objDetail.Save()
                    Next
                Next

                For l As Integer = 0 To 3
                    Dim objDetail = objSpace.CreateObject(Of CheckSubmitReportLog)()
                    Dim objReport As SettingReportName = objSpace.FindObject(Of SettingReportName)(CriteriaOperator.Parse("ReportName = ?", reportnamesquarter))
                    objDetail.SiteNo = TblSite.SiteNo
                    objDetail.SiteName = TblSite
                    objDetail.SiteOid = TblSite.Oid.ToString
                    objDetail.ReportName = objReport
                    objDetail.ReportYear = _year
                    objDetail.ReportMonth = PublicEnum.EnumMonth.JAN
                    objDetail.ReportQuarter = l + 1
                    objDetail.StatusCheck = PublicEnum.SubmitReportCheck.Close
                    objDetail.Save()
                Next
            Next
        End If

        '//===================

        objSpace.CommitChanges()
        View.ObjectSpace.Refresh()
    End Sub


    Dim objYearParam As CheckReportLogYearParameter
    Private Sub PopupWindowShowAction1_CustomizePopupWindowParams(sender As Object, e As CustomizePopupWindowParamsEventArgs) Handles PopupWindowShowAction1.CustomizePopupWindowParams
        objSpace = Application.CreateObjectSpace()
        objYearParam = objSpace.CreateObject(Of CheckReportLogYearParameter)()
        Dim dv As DetailView = Application.CreateDetailView(objSpace, objYearParam)
        dv.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit
        e.View = dv

    End Sub
End Class
