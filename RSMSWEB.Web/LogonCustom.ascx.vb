Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Web.UI
Imports DevExpress.ExpressApp.Web.Templates
Imports DevExpress.ExpressApp.Templates

Partial Public Class LogonCustom
    Inherits TemplateContent
    Public Overrides ReadOnly Property DefaultContainer() As IActionContainer
        Get
            Return Nothing
        End Get
    End Property
    Public Overrides Sub SetStatus(ByVal statusMessages As ICollection(Of String))
    End Sub
    Public Overrides ReadOnly Property ViewSiteControl() As Object
        Get
            Return VSC
        End Get
    End Property

End Class
