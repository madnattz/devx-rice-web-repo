Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Security.Strategy
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Persistent.BaseImpl

' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic
Public Class Updater
    Inherits ModuleUpdater
    Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
        MyBase.New(objectSpace, currentDBVersion)
    End Sub

    '  Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
    '      MyBase.UpdateDatabaseAfterUpdateSchema()
    '      'Dim name As String = "MyName"
    '      'Dim theObject As DomainObject1 = ObjectSpace.FindObject(Of DomainObject1)(CriteriaOperator.Parse("Name=?", name))
    '      'If (theObject Is Nothing) Then
    '      '    theObject = ObjectSpace.CreateObject(Of DomainObject1)()
    '      '    theObject.Name = name
    '      'End If
    'Dim sampleUser As SecuritySystemUser = ObjectSpace.FindObject(Of SecuritySystemUser)(New BinaryOperator("UserName", "User"))
    'If sampleUser Is Nothing Then
    '	sampleUser = ObjectSpace.CreateObject(Of SecuritySystemUser)()
    '	sampleUser.UserName = "User"
    '	sampleUser.SetPassword("")
    'End If
    'Dim defaultRole As SecuritySystemRole = CreateDefaultRole()
    'sampleUser.Roles.Add(defaultRole)

    'Dim userAdmin As SecuritySystemUser = ObjectSpace.FindObject(Of SecuritySystemUser)(New BinaryOperator("UserName", "Admin"))
    'If userAdmin Is Nothing Then
    '	userAdmin = ObjectSpace.CreateObject(Of SecuritySystemUser)()
    '	userAdmin.UserName = "Admin"
    '	' Set a password if the standard authentication type is used
    '	userAdmin.SetPassword("")
    'End If
    '' If a role with the Administrators name doesn't exist in the database, create this role
    'Dim adminRole As SecuritySystemRole = ObjectSpace.FindObject(Of SecuritySystemRole)(New BinaryOperator("Name", "Administrators"))
    'If adminRole Is Nothing Then
    '	adminRole = ObjectSpace.CreateObject(Of SecuritySystemRole)()
    '	adminRole.Name = "Administrators"
    'End If
    'adminRole.IsAdministrative = True
    'userAdmin.Roles.Add(adminRole)
    'ObjectSpace.CommitChanges()
    '  End Sub

    Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
        MyBase.UpdateDatabaseAfterUpdateSchema()
        Dim IsUser As User = ObjectSpace.FindObject(Of User)(CriteriaOperator.Parse("UserName == 'admin'"))

        If IsUser Is Nothing Then
            Dim adminRole As Role = ObjectSpace.FindObject(Of Role)(New BinaryOperator("Name", SecurityStrategy.AdministratorRoleName))
            If adminRole Is Nothing Then
                adminRole = ObjectSpace.CreateObject(Of Role)()
                adminRole.Name = SecurityStrategy.AdministratorRoleName
                adminRole.IsAdministrative = True
                adminRole.Save()
            End If

            Dim user1 As User = ObjectSpace.FindObject(Of User)(New BinaryOperator("UserName", "admin"))
            If user1 Is Nothing Then
                user1 = ObjectSpace.CreateObject(Of User)()
                user1.UserName = "admin"
                ' Set a password if the standard authentication type is used 
                user1.SetPassword("")
                user1.Roles.Add(adminRole)
            End If

        End If
    End Sub

    Public Overrides Sub UpdateDatabaseBeforeUpdateSchema()
        MyBase.UpdateDatabaseBeforeUpdateSchema()
        'If (CurrentDBVersion < New Version("1.1.0.0") AndAlso CurrentDBVersion > New Version("0.0.0.0")) Then
        '    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName")
        'End If
    End Sub
	Private Function CreateDefaultRole() As SecuritySystemRole
		Dim defaultRole As SecuritySystemRole = ObjectSpace.FindObject(Of SecuritySystemRole)(New BinaryOperator("Name", "Default"))
		If defaultRole Is Nothing Then
			defaultRole = ObjectSpace.CreateObject(Of SecuritySystemRole)()
			defaultRole.Name = "Default"

			defaultRole.AddObjectAccessPermission(Of SecuritySystemUser)("[Oid] = CurrentUserId()", SecurityOperations.ReadOnlyAccess)
			defaultRole.AddMemberAccessPermission(Of SecuritySystemUser)("ChangePasswordOnFirstLogon", SecurityOperations.Write)
			defaultRole.AddMemberAccessPermission(Of SecuritySystemUser)("StoredPassword", SecurityOperations.Write)
			defaultRole.SetTypePermissionsRecursively(Of SecuritySystemRole)(SecurityOperations.Read, SecuritySystemModifier.Allow)
			defaultRole.SetTypePermissionsRecursively(Of ModelDifference)(SecurityOperations.ReadWriteAccess, SecuritySystemModifier.Allow)
			defaultRole.SetTypePermissionsRecursively(Of ModelDifferenceAspect)(SecurityOperations.ReadWriteAccess, SecuritySystemModifier.Allow)
		End If
		Return defaultRole
	End Function
End Class