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

Partial Public Class SimsNavigateController
    Inherits WindowController
    Public Sub New()
        InitializeComponent()
        RegisterActions(components)
        TargetWindowType = WindowType.Main
    End Sub

    Protected Overrides Sub OnActivated()
        MyBase.OnActivated()
        Dim showNavigationItemController As ShowNavigationItemController = Frame.GetController(Of ShowNavigationItemController)()
        AddHandler showNavigationItemController.CustomShowNavigationItem, AddressOf showNavigationItemController_CustomShowNavigationItem
    End Sub

    Protected Overrides Sub OnDeactivated()
        MyBase.OnDeactivated()
    End Sub

    Private Sub showNavigationItemController_CustomShowNavigationItem(ByVal sender As Object, ByVal e As CustomShowNavigationItemEventArgs)
        Dim pageUrl As String = ""
        Dim NavigateID As String = e.ActionArguments.SelectedChoiceActionItem.Id
        If NavigateID.Contains("SimsReport") Then
            Select Case NavigateID
                Case "SimsReport01_Nav"
                    pageUrl = "Report01.aspx"
                Case "SimsReport02_Nav"
                    pageUrl = "Report02.aspx"
                Case "SimsReport03_Nav"
                    pageUrl = "Report03.aspx"
                Case "SimsReport04_Nav"
                    pageUrl = "Report03.aspx"
                Case "SimsReport05_Nav"
                    pageUrl = "Report05.aspx"
                Case "SimsReport06_Nav"
                    pageUrl = "Report06.aspx"
                Case "SimsReport07_Nav"
                    pageUrl = "Report07.aspx"
                Case "SimsReport08_Nav"
                    pageUrl = "Report08.aspx"
                Case "SimsReport09_Nav"
                    pageUrl = "Report09.aspx"
                Case "SimsReport10_Nav"
                    pageUrl = "Report10.aspx"
                Case "SimsReport11_Nav"
                    pageUrl = "Report11.aspx"
                Case "SimsReport12_Nav"
                    pageUrl = "Report12.aspx"
                Case "SimsReport13_Nav"
                    pageUrl = "Report13.aspx"
                Case "SimsReport14_Nav"
                    pageUrl = "Report14.aspx"
                Case "SimsReport15_Nav"
                    pageUrl = "Report15.aspx"
                Case "SimsReport16_Nav"
                    pageUrl = "Report16.aspx"
                Case "SimsReport17_Nav"
                    pageUrl = "Report17.aspx"
                Case Else
                    '//e.Handled = False
            End Select
            DevExpress.ExpressApp.Web.WebWindow.CurrentRequestWindow.RegisterStartupScript( _
                        "ShowCustomFormScriptKey", String.Format("window.open('SimsReports/{0}','{1}');", pageUrl, NavigateID))
            e.Handled = True
        End If
    End Sub

End Class
