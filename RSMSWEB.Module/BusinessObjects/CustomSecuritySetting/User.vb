
Imports System
Imports System.Text
Imports System.Collections.Generic
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Security
Imports DevExpress.Persistent.Validation
Imports DevExpress.Persistent.Base.Security
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Utils
Imports Microsoft.VisualBasic
Imports System.Linq
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.DC
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.Model

<DefaultClassOptions()> _
<ImageName("BO_User")> _
<XafDisplayName("�����ҹ�к�")> _
Public Class User
    Inherits BaseObject
    Implements ISecurityUser, IAuthenticationStandardUser, IAuthenticationActiveDirectoryUser, ISecurityUserWithRoles, IOperationPermissionProvider

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

#Region "ISecurityUser Members"
    Private _userName As String = String.Empty
    Private ReadOnly Property UserName_() As String Implements ISecurityUser.UserName, IAuthenticationStandardUser.UserName
        Get
            Return _userName
        End Get
    End Property

    <RuleRequiredField("EmployeeUserNameRequired", DefaultContexts.Save), RuleUniqueValue("EmployeeUserNameIsUnique", DefaultContexts.Save, "The login with the entered user name was already registered within the system.")> _
    Public Property UserName() As String Implements IAuthenticationActiveDirectoryUser.UserName
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            SetPropertyValue("UserName", _userName, value)
        End Set
    End Property

    Private _DisplayName As String
    <XafDisplayName("���� - ���ʡ��")> _
    Public Property DisplayName() As String
        Get
            Return _DisplayName
        End Get
        Set(ByVal value As String)
            SetPropertyValue("DisplayName", _DisplayName, value)
        End Set
    End Property

    Private _Site As Site
    <XafDisplayName("ȹ�����紾ѹ������")> _
    <DataSourceCriteria("SiteType='Factory' or SiteType='Center'")> _
    Public Property Site As Site
        Get
            Return _Site
        End Get
        Set(value As Site)
            SetPropertyValue("Site", _Site, value)
        End Set
    End Property


    Private _isActive As Boolean = True
    Private ReadOnly Property IsActive_() As Boolean Implements ISecurityUser.IsActive
        Get
            Return _isActive
        End Get
    End Property

    Public Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue("IsActive", _isActive, value)
        End Set
    End Property
#End Region

#Region "IAuthenticationStandardUser Members"
    Private _changePasswordOnFirstLogon As Boolean
    Public Property ChangePasswordOnFirstLogon() As Boolean Implements IAuthenticationStandardUser.ChangePasswordOnFirstLogon
        Get
            Return _changePasswordOnFirstLogon
        End Get
        Set(ByVal value As Boolean)
            SetPropertyValue("ChangePasswordOnFirstLogon", _changePasswordOnFirstLogon, value)
        End Set
    End Property
    Private _storedPassword As String
    <Browsable(False), Size(SizeAttribute.Unlimited), Persistent(), SecurityBrowsable()> _
    Protected Property StoredPassword() As String
        Get
            Return _storedPassword
        End Get
        Set(ByVal value As String)
            _storedPassword = value
        End Set
    End Property
    Public Function ComparePassword(ByVal password As String) As Boolean Implements IAuthenticationStandardUser.ComparePassword
        Return SecurityUserBase.ComparePassword(Me._storedPassword, password)
    End Function
    Public Sub SetPassword(ByVal password As String) Implements IAuthenticationStandardUser.SetPassword
        Me._storedPassword = (New PasswordCryptographer()).GenerateSaltedPassword(password)
        OnChanged("StoredPassword")
    End Sub
#End Region

#Region "ISecurityUserWithRoles Members"
    Private ReadOnly Property ISecurityUserWithRoles_Roles() As IList(Of ISecurityRole) Implements ISecurityUserWithRoles.Roles
        Get
            Dim result As IList(Of ISecurityRole) = New List(Of ISecurityRole)()
            For Each role As Role In Roles
                result.Add(role)
            Next role
            Return result
        End Get
    End Property
#End Region
    <XafDisplayName("�Է�������ҹ")> _
    <Association("Users-Roles"), RuleRequiredField("RoleIsRequired", DefaultContexts.Save, TargetCriteria:="IsActive", CustomMessageTemplate:="An active employee must have at least one role assigned")> _
    Public ReadOnly Property Roles() As XPCollection(Of Role)
        Get
            Return GetCollection(Of Role)("Roles")
        End Get

    End Property


#Region "IOperationPermissionProvider Members"
    Private Function IOperationPermissionProvider_GetPermissions() As IEnumerable(Of IOperationPermission) Implements IOperationPermissionProvider.GetPermissions
        Return New IOperationPermission() {}
    End Function
    Private Function IOperationPermissionProvider_GetChildren() As IEnumerable(Of IOperationPermissionProvider) Implements IOperationPermissionProvider.GetChildren
        Return New EnumerableConverter(Of IOperationPermissionProvider, Role)(Roles)
    End Function
#End Region
End Class
