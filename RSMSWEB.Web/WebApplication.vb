Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Security.ClientServer

' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWebWebApplicationMembersTopicAll
Partial Public Class RSMSWEBAspNetApplication
    Inherits WebApplication
    Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
    Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
    Private module3 As RSMSWEB.Module.RSMSWEBModule
    Private module4 As RSMSWEB.Module.Web.RSMSWEBAspNetModule

    Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
    Private securityStrategyComplex1 As DevExpress.ExpressApp.Security.SecurityStrategyComplex
    Private authenticationStandard1 As DevExpress.ExpressApp.Security.AuthenticationStandard 
        Private auditTrailModule As DevExpress.ExpressApp.AuditTrail.AuditTrailModule
        Private objectsModule As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private chartModule As DevExpress.ExpressApp.Chart.ChartModule
        Private chartAspNetModule As DevExpress.ExpressApp.Chart.Web.ChartAspNetModule
        Private conditionalAppearanceModule As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
        Private fileAttachmentsAspNetModule As DevExpress.ExpressApp.FileAttachments.Web.FileAttachmentsAspNetModule
        Private htmlPropertyEditorAspNetModule As DevExpress.ExpressApp.HtmlPropertyEditor.Web.HtmlPropertyEditorAspNetModule
        Private pivotChartModuleBase As DevExpress.ExpressApp.PivotChart.PivotChartModuleBase
        Private pivotChartAspNetModule As DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule
        Private pivotGridModule As DevExpress.ExpressApp.PivotGrid.PivotGridModule
        Private pivotGridAspNetModule As DevExpress.ExpressApp.PivotGrid.Web.PivotGridAspNetModule
        Private reportsModuleV2 As DevExpress.ExpressApp.ReportsV2.ReportsModuleV2
        Private reportsAspNetModuleV2 As DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2
        Private treeListEditorsModuleBase As DevExpress.ExpressApp.TreeListEditors.TreeListEditorsModuleBase
        Private treeListEditorsAspNetModule As DevExpress.ExpressApp.TreeListEditors.Web.TreeListEditorsAspNetModule
        Private validationModule As DevExpress.ExpressApp.Validation.ValidationModule

    Public Sub New()
        InitializeComponent()
    End Sub
    
    Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
 
        args.ObjectSpaceProvider = New SecuredObjectSpaceProvider(DirectCast(Security, SecurityStrategyComplex), args.ConnectionString, args.Connection)
    End Sub
    Private Sub RSMSWEBAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
#If EASYTEST Then
        e.Updater.Update()
        e.Handled = True
#Else
        'If System.Diagnostics.Debugger.IsAttached Then
        e.Updater.Update()
        e.Handled = True
        'Else
        '    Dim message As String = "The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Constants.vbCrLf & _
        '        "This error occurred  because the automatic database update was disabled when the application was started without debugging." & Constants.vbCrLf & _
        '        "To avoid this error, you should either start the application under Visual Studio in debug mode, or modify the " & _
        '        "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & _
        '        "or manually create a database using the 'DBUpdater' tool." & Constants.vbCrLf & _
        '        "Anyway, refer to the following help topics for more detailed information:" & Constants.vbCrLf & _
        '        "'Update Application and Database Versions' at http://help.devexpress.com/#Xaf/CustomDocument2795" & Constants.vbCrLf & _
        '        "'Database Security References' at http://help.devexpress.com/#Xaf/CustomDocument3237" & Constants.vbCrLf & _
        '        "If this doesn't help, please contact our Support Team at http://www.devexpress.com/Support/Center/"

        '    If e.CompatibilityError IsNot Nothing AndAlso e.CompatibilityError.Exception IsNot Nothing Then
        '        message &= Constants.vbCrLf & Constants.vbCrLf & "Inner exception: " & e.CompatibilityError.Exception.Message
        '    End If
        '    Throw New InvalidOperationException(message)
        'End If
#End If
    End Sub
    Private Sub InitializeComponent()
        Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
        Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
        Me.module3 = New RSMSWEB.[Module].RSMSWEBModule()
        Me.module4 = New RSMSWEB.[Module].Web.RSMSWEBAspNetModule()
        Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
        Me.securityStrategyComplex1 = New DevExpress.ExpressApp.Security.SecurityStrategyComplex()
        Me.authenticationStandard1 = New DevExpress.ExpressApp.Security.AuthenticationStandard()
        Me.auditTrailModule = New DevExpress.ExpressApp.AuditTrail.AuditTrailModule()
        Me.objectsModule = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
        Me.chartModule = New DevExpress.ExpressApp.Chart.ChartModule()
        Me.chartAspNetModule = New DevExpress.ExpressApp.Chart.Web.ChartAspNetModule()
        Me.conditionalAppearanceModule = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
        Me.fileAttachmentsAspNetModule = New DevExpress.ExpressApp.FileAttachments.Web.FileAttachmentsAspNetModule()
        Me.htmlPropertyEditorAspNetModule = New DevExpress.ExpressApp.HtmlPropertyEditor.Web.HtmlPropertyEditorAspNetModule()
        Me.pivotChartModuleBase = New DevExpress.ExpressApp.PivotChart.PivotChartModuleBase()
        Me.pivotChartAspNetModule = New DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule()
        Me.pivotGridModule = New DevExpress.ExpressApp.PivotGrid.PivotGridModule()
        Me.pivotGridAspNetModule = New DevExpress.ExpressApp.PivotGrid.Web.PivotGridAspNetModule()
        Me.reportsModuleV2 = New DevExpress.ExpressApp.ReportsV2.ReportsModuleV2()
        Me.reportsAspNetModuleV2 = New DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2()
        Me.treeListEditorsModuleBase = New DevExpress.ExpressApp.TreeListEditors.TreeListEditorsModuleBase()
        Me.treeListEditorsAspNetModule = New DevExpress.ExpressApp.TreeListEditors.Web.TreeListEditorsAspNetModule()
        Me.validationModule = New DevExpress.ExpressApp.Validation.ValidationModule()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'securityStrategyComplex1
        '
        Me.securityStrategyComplex1.Authentication = Me.authenticationStandard1
        Me.securityStrategyComplex1.RoleType = GetType(RSMSWEB.[Module].Role)
        Me.securityStrategyComplex1.UserType = GetType(RSMSWEB.[Module].User)
        '
        'authenticationStandard1
        '
        Me.authenticationStandard1.LogonParametersType = GetType(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters)
        '
        'auditTrailModule
        '
        Me.auditTrailModule.AuditDataItemPersistentType = GetType(DevExpress.Persistent.BaseImpl.AuditDataItemPersistent)
        '
        'pivotChartModuleBase
        '
        Me.pivotChartModuleBase.ShowAdditionalNavigation = False
        '
        'reportsModuleV2
        '
        Me.reportsModuleV2.EnableInplaceReports = True
        Me.reportsModuleV2.ReportDataType = GetType(DevExpress.Persistent.BaseImpl.ReportDataV2)
        '
        'validationModule
        '
        Me.validationModule.AllowValidationDetailsAccess = True
        Me.validationModule.IgnoreWarningAndInformationRules = False
        '
        'RSMSWEBAspNetApplication
        '
        Me.ApplicationName = "RSMSWEB"
        Me.CollectionsEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit
        Me.Modules.Add(Me.module1)
        Me.Modules.Add(Me.module2)
        Me.Modules.Add(Me.auditTrailModule)
        Me.Modules.Add(Me.objectsModule)
        Me.Modules.Add(Me.chartModule)
        Me.Modules.Add(Me.conditionalAppearanceModule)
        Me.Modules.Add(Me.pivotChartModuleBase)
        Me.Modules.Add(Me.pivotGridModule)
        Me.Modules.Add(Me.reportsModuleV2)
        Me.Modules.Add(Me.treeListEditorsModuleBase)
        Me.Modules.Add(Me.validationModule)
        Me.Modules.Add(Me.module3)
        Me.Modules.Add(Me.chartAspNetModule)
        Me.Modules.Add(Me.fileAttachmentsAspNetModule)
        Me.Modules.Add(Me.htmlPropertyEditorAspNetModule)
        Me.Modules.Add(Me.pivotChartAspNetModule)
        Me.Modules.Add(Me.pivotGridAspNetModule)
        Me.Modules.Add(Me.reportsAspNetModuleV2)
        Me.Modules.Add(Me.treeListEditorsAspNetModule)
        Me.Modules.Add(Me.module4)
        Me.Modules.Add(Me.securityModule1)
        Me.Security = Me.securityStrategyComplex1
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
End Class

