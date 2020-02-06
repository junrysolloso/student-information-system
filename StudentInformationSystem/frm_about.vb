Public Class frm_about
    Private Sub frm_about_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialize class
        Dim mainClass As New MainClass

        ' Copyright text
        lbl_copyright.Text = "Copyright " & Application.CompanyName & ". All rights reserved."

        ' Set system version
        lbl_systemversion.Text = "Version " & Application.ProductVersion

        ' Center label objects
        mainClass.centerObject(lbl_about, Me, -100)
        mainClass.centerObject(lbl_systemname, Me, -50)
        mainClass.centerObject(lbl_systemversion, Me, -10)
        mainClass.centerObject(lbl_copyright, Me, 20)

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

        ' Close the form
        Me.Close()

    End Sub
End Class