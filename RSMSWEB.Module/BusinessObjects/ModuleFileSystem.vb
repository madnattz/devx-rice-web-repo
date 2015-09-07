﻿Imports System
Imports System.IO
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports System.Collections.Generic
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Utils

Namespace FileSystemData
    <Description("This module provides the FileSystemStoreObject and FileSystemLinkObject classes that enable you to store uploaded files in a file system instead of the database.")> _
    Partial Public NotInheritable Class FileSystemDataModule
        Inherits ModuleBase

        Public Shared ReadBytesSize As Integer = &H1000
        Public Shared FileSystemStoreLocation As String = String.Format("{0}FileData", PathHelper.GetApplicationFolder())
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Shared Sub CopyFileToStream(ByVal sourceFileName As String, ByVal destination As Stream)
            If String.IsNullOrEmpty(sourceFileName) OrElse destination Is Nothing Then
                Return
            End If
            Using source As Stream = File.OpenRead(sourceFileName)
                CopyStream(source, destination)
            End Using
        End Sub
        Public Shared Sub OpenFileWithDefaultProgram(ByVal sourceFileName As String)
            Guard.ArgumentNotNullOrEmpty(sourceFileName, "sourceFileName")
            System.Diagnostics.Process.Start(sourceFileName)
        End Sub
        Public Shared Sub CopyStream(ByVal source As Stream, ByVal destination As Stream)
            If source Is Nothing OrElse destination Is Nothing Then
                Return
            End If
            Dim buffer(ReadBytesSize - 1) As Byte
            Dim read As Integer = 0
            read = source.Read(buffer, 0, buffer.Length)
            Do While read > 0
                destination.Write(buffer, 0, read)
                read = source.Read(buffer, 0, buffer.Length)
            Loop
        End Sub


#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()

        End Sub

#End Region

    End Class
End Namespace

