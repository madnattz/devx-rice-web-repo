' Developer Express Code Central Example:
' How to: Store file attachments in the file system instead of the database
' 
' Scenario
' The FileSystemData module provides the FileSystemStoreObject and
' FileSystemLinkObject classes that implement the IFileData interface for the use
' with our File Attachments module
' (https://documentation.devexpress.com/#Xaf/CustomDocument2781).
' FileSystemStoreObject
' - this class enables you to store uploaded files in a centralized file system
' location instead of the database. You can configure the file system store
' location via the static FileSystemDataModule.FileSystemStoreLocation
' property.
' FileSystemLinkObject - this class enables you to add soft links to
' real files instead of saving their contents to the database. Apparently, it is
' intended for use in Windows Forms applications only.
' 
' Refer to the following
' video to see this functionality in action: <a
' href='http://www.screencast.com/t/Xl1GMfxw'>http://www.screencast.com/t/Xl1GMfxw
' (http://www.screencast.com/t/Xl1GMfxw)</a>
' 
' Steps to implement
' 1. Copy and
' include the FileSystemData project into your solution and make sure it is built
' successfully.
' 
' 2. Invoke the Module Designer for the
' YourSolutionName.Module/Module.xx file by double-clicking it in Solution
' Explorer. Invoke the Toolbox (Alt+X+T) and then drag & drop the
' FileSystemDataModule component into the modules list on the left.
' 3. Define a
' FileSystemStoreObject or FileSystemLinkObject type properties within your
' business class as described in the eXpressApp Framework > Task-Based Help > How
' to: Implement File Data Properties
' (https://documentation.devexpress.com/#Xaf/CustomDocument2658) article. Make
' sure to decorate the container business class with the FileAttachmentAttribute
' (https://documentation.devexpress.com/#eXpressAppFramework/clsDevExpressPersistentBaseFileAttachmentAttributetopic)
' to provide additional commands for working with files. See the
' E965.Module\BusinessObjects\FileSystemStoreObjectDemo.xx and
' E965.Module\BusinessObjects\FileSystemLinkObjectDemo.xx source files for
' examples. 4. Make sure you do not override the
' DevExpress.Persistent.BaseImpl.BaseObject.OidInitializationMode property in your
' application and related modules, because the
' OidInitializationMode.AfterConstruction value is necessary for the correct
' operation of this module (in the example, the required default value is already
' set in the FileSystemDataModule class of this example module).
' 5. Modify
' YourSolutionName.Win/WinApplication.xx file to handle the
' CustomOpenFileWithDefaultProgram event of the
' DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule
' class as shown in the E965.Win\WinApplication.xx file. IMPORTANT NOTES
' 1. The
' current version of this example does not support the middle-tier scenario. Refer
' to the Q476039 (http://www.devexpress.com/issue=Q476039) ticket for more
' details. See Also:
' File Attachments Module Overview
' (http://documentation.devexpress.com/#Xaf/CustomDocument2781)
' Working with
' links to files instead of storing their contents in the database
' (http://dennisgaravsky.blogspot.ru/2012/10/working-with-links-to-files-instead-of.html)
' SQL
' Server FILESTREAM feature Overview
' (http://technet.microsoft.com/en-us/library/bb933993(v=sql.105).aspx)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E965

Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace FileSystemData.BusinessObjects
	''' <summary>
	''' This class enables you to store uploaded files in a centralized file system location instead of the database. You can configure the file system store location via the static FileSystemDataModule.FileSystemStoreLocation property.
	''' </summary>
	<DefaultProperty("FileName"), DeferredDeletion(False), OptimisticLocking(False)> _
	Public Class FileSystemStoreObject
		Inherits BaseObject
		Implements IFileData, IEmptyCheckable
		Private tempSourceStream_Renamed As Stream
		Private tempFileName As String = String.Empty
		Private Shared syncRoot As Object = New Object()
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
        End Sub
        <RuleRegularExpression("FileSystemStoreObject.RealFileName.RuleRegularExpression", DefaultContexts.Save, "(((http|https|ftp)\://)?[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;amp;%\$#\=~])*)|([a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6})"), EditorAlias("HyperLinkPropertyEditor")>
        Public ReadOnly Property RealFileName() As String
            Get
                If (Not String.IsNullOrEmpty(FileName)) AndAlso Oid <> Guid.Empty Then
                    Return Path.Combine(FileSystemDataModule.FileSystemStoreLocation, String.Format("{0}-{1}", Oid, FileName))
                End If
                Return Nothing
            End Get
        End Property

        <RuleRegularExpression("FileSystemStoreObject.PathFile.RuleRegularExpression", DefaultContexts.Save, "(((http|https|ftp)\://)?[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;amp;%\$#\=~])*)|([a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6})"), EditorAlias("HyperLinkPropertyEditor")>
        Public ReadOnly Property PathFile() As String
            Get
                If (Not String.IsNullOrEmpty(FileName)) AndAlso Oid <> Guid.Empty Then
                    Return "<a href=""" & Path.Combine(FileSystemDataModule.FileSystemStoreLocation, String.Format("{0}-{1}", Oid, FileName)) & """>" & "แสดงไฟล์" & "</a>"
                End If
                Return Nothing
            End Get
        End Property

		Protected Overridable Sub SaveFileToStore()
			If (Not String.IsNullOrEmpty(RealFileName)) Then
				Try
					Using destination As Stream = File.OpenWrite(RealFileName)
						FileSystemDataModule.CopyStream(TempSourceStream, destination)
						Size = CInt(Fix(destination.Length))
					End Using
				Catch exc As DirectoryNotFoundException
					Throw New UserFriendlyException(exc)
				End Try
			End If
		End Sub
		Private Sub RemoveOldFileFromStore()
			'Dennis: We need to remove the old file from the store when saving the current object.
			If (Not String.IsNullOrEmpty(tempFileName)) AndAlso tempFileName <> RealFileName Then 'B222892
				Try
					File.Delete(tempFileName)
					tempFileName = String.Empty
				Catch exc As DirectoryNotFoundException
					Throw New UserFriendlyException(exc)
				End Try
			End If
		End Sub
		Protected Overrides Sub OnSaving()
			MyBase.OnSaving()
			Guard.ArgumentNotNullOrEmpty(FileSystemDataModule.FileSystemStoreLocation, "FileSystemStoreLocation")
			SyncLock syncRoot
				If (Not Directory.Exists(FileSystemDataModule.FileSystemStoreLocation)) Then
					Directory.CreateDirectory(FileSystemDataModule.FileSystemStoreLocation)
				End If
			End SyncLock
			SaveFileToStore()
			RemoveOldFileFromStore()
		End Sub
		Protected Overrides Sub OnDeleting()
			'Dennis: We need to remove the old file from the store.
			Clear()
			MyBase.OnDeleting()
		End Sub
		Protected Overrides Sub Invalidate(ByVal disposing As Boolean)
			If disposing AndAlso TempSourceStream IsNot Nothing Then
				TempSourceStream.Close()
				TempSourceStream = Nothing
			End If
			MyBase.Invalidate(disposing)
		End Sub
#Region "IFileData Members"
        Public Sub Clear() Implements IFileData.Clear
            'Dennis: When clearing the file name property we need to save the name of the old file to remove it from the store in the future. You can also setup a separate service for that.
            If String.IsNullOrEmpty(tempFileName) Then
                tempFileName = RealFileName
            End If
            FileName = String.Empty
            Size = 0
        End Sub
        <Size(260)> _
        Public Property FileName() As String Implements IFileData.FileName
            Get
                Return GetPropertyValue(Of String)("FileName")
            End Get
            Set(ByVal value As String)
                SetPropertyValue("FileName", value)
            End Set
        End Property

        <Browsable(False)> _
        Public Property TempSourceStream() As Stream
            Get
                Return tempSourceStream_Renamed
            End Get
            Set(ByVal value As Stream)
                'Michael: The original Stream might be closed after a while (on the web too - T160753)
                If value Is Nothing Then
                    tempSourceStream_Renamed = Nothing
                Else
                    If value.Length > CLng(Fix(Integer.MaxValue)) Then
                        Throw New UserFriendlyException("File is too long")
                    End If
                    tempSourceStream_Renamed = New MemoryStream(CInt(Fix(value.Length)))
                    FileSystemDataModule.CopyStream(value, tempSourceStream_Renamed)
                    tempSourceStream_Renamed.Position = 0
                End If
            End Set
        End Property
        'Dennis: Fires when uploading a file.
        Private Sub LoadFromStream(ByVal fileName As String, ByVal source As Stream) Implements IFileData.LoadFromStream
            Me.FileName = fileName
            TempSourceStream = source
            'Dennis: When assigning a new file we need to save the name of the old file to remove it from the store in the future.
            If String.IsNullOrEmpty(tempFileName) Then
                tempFileName = RealFileName
            End If
        End Sub
        'Dennis: Fires when saving or opening a file.
        Private Sub SaveToStream(ByVal destination As Stream) Implements IFileData.SaveToStream
            Try
                If (Not String.IsNullOrEmpty(RealFileName)) Then
                    If destination Is Nothing Then
                        FileSystemDataModule.OpenFileWithDefaultProgram(RealFileName)
                    Else
                        FileSystemDataModule.CopyFileToStream(RealFileName, destination)
                    End If
                ElseIf TempSourceStream IsNot Nothing Then
                    FileSystemDataModule.CopyStream(TempSourceStream, destination)
                End If
            Catch exc As DirectoryNotFoundException
                Throw New UserFriendlyException(exc)
            Catch exc As FileNotFoundException
                Throw New UserFriendlyException(exc)
            End Try
        End Sub
        <Persistent()> _
        Public Property Size() As Integer
            Get
                Return GetPropertyValue(Of Integer)("Size")
            End Get
            Private Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Size", value)
            End Set
        End Property
        Public ReadOnly Property Size_impl() As Integer Implements IFileData.Size
            Get
                Return Me.Size
            End Get
        End Property
#End Region
#Region "IEmptyCheckable Members"
        Public ReadOnly Property IsEmpty() As Boolean Implements IEmptyCheckable.IsEmpty
            'T153149
            Get
                Return FileDataHelper.IsFileDataEmpty(Me) OrElse Not (Me.TempSourceStream IsNot Nothing OrElse File.Exists(RealFileName))
            End Get
        End Property
#End Region
	End Class
End Namespace