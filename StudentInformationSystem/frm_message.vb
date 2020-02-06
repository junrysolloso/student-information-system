Public Class frm_message
    Private Sub frm_loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Enable timer
        tmr_loading.Enabled = True

        ' Set message 
        lbl_message.Text = messageText

        ' Set lable to center
        Dim pointLocation As Point
        pointLocation.X = (Me.Width / 2) - (lbl_message.Width / 2)
        pointLocation.Y = Me.Height / 2 - (lbl_message.Height / 2)
        lbl_message.Location = pointLocation

    End Sub

    ' Timer click events
    Private Sub tmr_loading_Tick(sender As Object, e As EventArgs) Handles tmr_loading.Tick

        prg_loading.Value = prg_loading.Value + 50
        If prg_loading.Value = prg_loading.Maximum Then
            tmr_loading.Enabled = False
            Me.Close()
            Me.Dispose()
        End If

    End Sub
End Class