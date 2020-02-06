Imports System.Data.SqlClient

Public Class ProfileView
    Private Property sql_connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Visual Studio 2015\Projects\StudentInformationSystem\Database\StudentInformationSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    ' Data arrays
    Dim dataKeys() As String = {"Id", "Firstname", "Lastname", "Middlename", "Gender", "BirthDate", "Phone", "Nationality", "BirthPlace", "Email", "Address", "StudentId", "Program", "YearLevel", "AcademicYear", "Department", "DateEnrolled", "GuardianFirstname", "GuardianLastname", "GuardianMiddlename", "GuardianRelationship", "GuardianPhone", "GuardianEmail", "GuardianAddress"}

    ' View profile data
    Public Sub viewProfile(txtBoxList() As Label, picBox As PictureBox, imageKeyData As String, displayName As Label)

        ' Show profile date
        Dim dataReader As SqlDataReader

        ' Error handling
        Try

            ' Open connection
            If sql_connection.State <> ConnectionState.Open Then
                sql_connection.Open()
            End If

            ' Build query
            Using sql_connection
                With sql_command
                    .Connection = sql_connection
                    .CommandText = main_query & " WHERE info_personal.Id = '" + imageKeyData + "'"
                    dataReader = .ExecuteReader()
                    While dataReader.Read()

                        ' Set name
                        displayName.Text = dataReader(dataKeys(1)) & " " & dataReader(dataKeys(2))

                        ' Get array lenght
                        Dim dataLenght As Integer = dataKeys.Length

                        ' Loop 
                        For key As Integer = 0 To dataLenght - 1
                            txtBoxList(key).Text = dataReader(dataKeys(key))
                        Next

                        ' Set image to picture box
                        picBox.Image = Image.FromFile(uploadsDirectory & "\Images\" & dataReader("Picture"))

                    End While
                End With

                ' Release all resources
                dataReader.Close()
                dataReader.Dispose()
                sql_command.Dispose()

            End Using
        Catch ex As Exception
            Console.WriteLine("You have an error: " & ex.Message)
        End Try
    End Sub

End Class
