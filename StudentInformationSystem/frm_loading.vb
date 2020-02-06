Public Class frm_loading
    Private Sub frm_loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Enable timer
        tmr_loading.Enabled = True

    End Sub

    Private Sub tmr_loading_Tick(sender As Object, e As EventArgs) Handles tmr_loading.Tick

        prg_loading.Value = prg_loading.Value + 50
        If prg_loading.Value = prg_loading.Maximum Then

            ' Disable timer
            tmr_loading.Enabled = False

            ' Close the form
            Me.Close()

            ' Dispose the object
            Me.Dispose()

        End If

    End Sub
End Class