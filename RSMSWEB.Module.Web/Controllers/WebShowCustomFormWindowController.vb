
Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.ExpressApp.SystemModule
Imports RSMSWEB.Module.RSMS.Module.Controllers

Namespace RSMS.Module.Web.Controllers
    Public Interface IModelWebCustomFormPathNavigationItem
        Inherits IModelNavigationItem
        <Category("Data")> _
        Property CustomFormPath() As String
    End Interface

    Public Class WebShowCustomFormWindowController
        Inherits ShowCustomFormWindowController

        Protected Overrides Sub ShowCustomForm(model As IModelNavigationItem)
            Dim customFormPath As String = (CType(model, IModelWebCustomFormPathNavigationItem)).CustomFormPath
            DevExpress.ExpressApp.Web.WebWindow.CurrentRequestWindow.RegisterStartupScript("ShowCustomFormScriptKey", String.Format("window.open('{0}');", customFormPath))
        End Sub

    End Class
End Namespace



