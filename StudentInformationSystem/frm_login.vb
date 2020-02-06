Imports System.Data.SqlClient

Public Class frm_login

    ' Login button click
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        ' Declare connection string
        Dim sql_connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Visual Studio 2015\Projects\StudentInformationSystem\Database\StudentInformationSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")

        'Check if user exist
        Try

            ' Open connection
            If sql_connection.State <> ConnectionState.Open Then
                sql_connection.Open()
            End If

            Using sql_connection
                With sql_command
                    .Connection = sql_connection
                    .CommandText = "SELECT Id FROM info_user WHERE dt_username='" + txt_username.Text + "' AND dt_password='" + txt_password.Text + "'"

                    ' Check if user is existing
                    If .ExecuteScalar > 0 Then

                        ' Set form to enable
                        frm_toChange.Enabled = True

                        ' Close login form
                        Me.Close()

                        ' Release resources
                        Me.Dispose()

                    Else

                        ' Show messsage
                        messageText = "Your credentials is not correct."
                        frm_message.ShowDialog()

                    End If

                    .Dispose()
                End With
            End Using
        Catch ex As Exception
            Console.WriteLine("You have an error: " & ex.Message)
        End Try
    End Sub

    ' Close the form
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        frm_main.Close()
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set group box  to center
        Dim pointLocation As Point
        pointLocation.X = (Me.Width / 2) - (grp_login.Width / 2)
        pointLocation.Y = Me.Height / 2 - (grp_login.Height / 2)
        grp_login.Location = pointLocation

    End Sub
End Class