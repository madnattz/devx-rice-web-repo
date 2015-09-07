Imports DevExpress.Web
Public Class Test1zx
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub ASPxButton1_Click(sender As Object, e As EventArgs) Handles ASPxButton1.Click
        '//ASPxLabel1.Text = ASPxTextBox1.Text
        RSMSWEBAspNetApplication.Redirect("#ShortcutViewID=CheckFarm_ListView")
    End Sub

    Private Sub CallBack1_Callback(source As Object, e As CallbackEventArgs) Handles CallBack1.Callback
        RSMSWEBAspNetApplication.Redirect(e.Parameter)
    End Sub
End Class