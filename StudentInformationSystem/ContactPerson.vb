Imports System.Data.SqlClient

Public Class ContactPerson
    Private Property sql_connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Visual Studio 2015\Projects\StudentInformationSystem\Database\StudentInformationSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    ' Insert data for personal information
    Public Sub insertContactPerson(data As Array)

        ' Error handling using try and catch
        Try

            ' Open connection
            If sql_connection.State <> ConnectionState.Open Then
                sql_connection.Open()
            End If

            'Building query
            Using sql_connection
                With sql_command
                    .Connection = sql_connection
                    .CommandText = "INSERT INTO info_contactperson (dt_firstname, dt_lastname, dt_middlename, dt_relationship, dt_phone, dt_email, dt_address) 
                    VALUES (@dt_firstname, @dt_lastname, @dt_middlename, @dt_relationship, @dt_phone, @dt_email, @dt_address)"
                    .Parameters.AddWithValue("@dt_firstname", data(0))
                    .Parameters.AddWithValue("@dt_lastname", data(1))
                    .Parameters.AddWithValue("@dt_middlename", data(2))
                    .Parameters.AddWithValue("@dt_relationship", data(3))
                    .Parameters.AddWithValue("@dt_phone", data(4))
                    .Parameters.AddWithValue("@dt_email", data(5))
                    .Parameters.AddWithValue("@dt_address", data(6))

                    ' Check if data is inserted
                    If .ExecuteNonQuery().Equals(1) Then
                        Console.WriteLine("Data inserted.")
                    Else
                        Console.WriteLine("Data insert failed.")
                    End If

                    ' Clear parameter
                    .Parameters.Clear()
                    .Dispose()
                End With
            End Using
        Catch ex As Exception
            Console.WriteLine("You have an error: " & ex.Message)
        End Try
    End Sub

    ' Delete personal information
    Public Sub deleteContactPerson(dataKey As String)

        ' Error handling using try and catch
        Try

            ' Open connection
            If sql_connection.State <> ConnectionState.Open Then
                sql_connection.Open()
            End If

            'Building query
            Using sql_connection
                With sql_command
                    .Connection = sql_connection
                    .CommandText = "DELETE FROM info_contactperson WHERE Id = @Id"
                    .Parameters.AddWithValue("@Id", dataKey)

                    ' Check if executed successful
                    If .ExecuteNonQuery().Equals(1) Then
                        Console.WriteLine("Contact person data deleted.")
                    End If

                    .Parameters.Clear()
                    .Dispose()
                End With
            End Using
        Catch ex As Exception
            Console.WriteLine("You have an error: " & ex.Message)
        End Try
    End Sub

End Class


