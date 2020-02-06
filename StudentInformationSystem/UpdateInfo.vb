Imports System.Data.SqlClient

Public Class UpdateInfo
    Private Property sql_connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Visual Studio 2015\Projects\StudentInformationSystem\Database\StudentInformationSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    Public Sub mouseEventsUpdate(sender As Object, txtBox As TextBox)

        ' Get location
        txtBox.Location = sender.Location
        txtBox.Text = sender.Text
        txtBox.Visible = True

        ' Set global label name
        lbl_toChange = sender

        ' Set tag name
        tagName = sender.Tag

        ' Set label visibility to false
        sender.Visible = False

    End Sub

    Public Sub mouseEventsDone(sender As Object, keyId As String, dataSourceKey As String)

        ' Set textbox visibilty to false
        sender.Visible = False

        ' Set label visibility to true
        lbl_toChange.Visible = True

        ' Set label value
        lbl_toChange.Text = sender.Text

        ' Try to insert the data to database
        Try
            ' Open connection
            If sql_connection.State <> ConnectionState.Open Then
                sql_connection.Open()
            End If

            ' Build a query
            Using sql_connection
                With sql_command
                    .Connection = sql_connection
                    .CommandText = "UPDATE " & dataSourceKey & " SET " & tagName & " = '" + sender.Text + "' WHERE Id = '" + keyId + "'"

                    ' Check if execution successful
                    If .ExecuteNonQuery().Equals(1) Then
                        Console.WriteLine("Data updated.")
                    End If

                    .Dispose()
                End With
            End Using
        Catch ex As Exception
            Console.WriteLine("You have an error: " & ex.Message)
        End Try

    End Sub

End Class
