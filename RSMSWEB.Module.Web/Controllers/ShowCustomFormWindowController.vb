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

' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppWindowControllertopic.
Public MustInherit Class ShowCustomFormWindowController
    Inherits WindowController
    Private navigationController As ShowNavigationItemController
    Public Sub New()
        TargetWindowType = WindowType.Main
    End Sub
    Protected Overrides Sub OnActivated()
        MyBase.OnActivated()
        navigationController = Frame.GetController(Of ShowNavigationItemController)()
        If navigationController IsNot Nothing Then
            AddHandler navigationController.CustomShowNavigationItem, AddressOf navigationController_CustomShowNavigationItem
        End If
    End Sub
    Protected Overrides Sub OnDeactivated()
        If navigationController IsNot Nothing Then
            RemoveHandler navigationController.CustomShowNavigationItem, AddressOf navigationController_CustomShowNavigationItem
        End If
        MyBase.OnDeactivated()
    End Sub
    Private Sub navigationController_CustomShowNavigationItem(ByVal sender As Object, ByVal e As CustomShowNavigationItemEventArgs)
        If e.ActionArguments.SelectedChoiceActionItem.Id = "CustomForm" Then
            ShowCustomForm(TryCast(e.ActionArguments.SelectedChoiceActionItem.Model, IModelNavigationItem))
            e.Handled = True
        End If
    End Sub
    Protected MustOverride Sub ShowCustomForm(ByVal model As IModelNavigationItem)
End Class
