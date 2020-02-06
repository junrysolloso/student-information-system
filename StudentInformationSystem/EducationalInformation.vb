Imports System.Data.SqlClient

Public Class EducationalInformation
    Private Property sql_connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Visual Studio 2015\Projects\StudentInformationSystem\Database\StudentInformationSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")
    ' Insert data for personal information
    Public Sub insertEducation(data As Array)

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
                    .CommandText = "INSERT INTO info_education (dt_studentid, dt_program, dt_yearlevel, dt_academicyear, dt_department, dt_dateenrolled) 
                    VALUES (@dt_studentid, @dt_program, @dt_yearlevel, @dt_academicyear, @dt_department, @dt_dateenrolled)"
                    .Parameters.AddWithValue("@dt_studentid", data(0))
                    .Parameters.AddWithValue("@dt_program", data(1))
                    .Parameters.AddWithValue("@dt_yearlevel", data(2))
                    .Parameters.AddWithValue("@dt_academicyear", data(3))
                    .Parameters.AddWithValue("@dt_department", data(4))
                    .Parameters.AddWithValue("@dt_dateenrolled", data(5))

                    ' Check if data is inserted
                    If .ExecuteNonQuery().Equals(1) Then

                        ' Log it
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
    Public Sub deleteEducation(dataKey As String)

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
                    .CommandText = "DELETE FROM info_education WHERE Id = @Id"
                    .Parameters.AddWithValue("@Id", dataKey)

                    ' Check if executed successful
                    If .ExecuteNonQuery().Equals(1) Then

                        ' Log it
                        Console.WriteLine("Educational data deleted.")

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
