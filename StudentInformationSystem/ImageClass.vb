Imports System.Data.SqlClient
Public Class ImageClass

    ' Method for moving and inserting image
    Public Sub insertImage(imageName As String)

        ' Variable declarations
        Dim fileName As String
        Dim fileDestination As String
        Dim rowNumber As String
        Dim studentName As String

        ' Error handling 
        Try

            ' Open connection
            openConnection()

            ' Get row number for the last data inserted
            sql_command.Connection = sql_connection
            sql_command.CommandText = "SELECT MAX(Id) FROM info_personal"
            rowNumber = sql_command.ExecuteScalar()

            ' Get name using row number for the last data inserted
            sql_command.CommandText = "SELECT dt_firstname FROM info_personal WHERE Id='" + rowNumber + "'"
            studentName = sql_command.ExecuteScalar()

            ' Set file directory
            fileDestination = uploadsDirectory & "\Images\" & studentName & rowNumber & ".jpg"

            ' Move/Copy file to the destination folder
            FileCopy(imageName, fileDestination)

            ' Set filename to be used on the database
            fileName = studentName & rowNumber & ".jpg"

            ' Build query command

            With sql_command
                .CommandText = "UPDATE info_personal SET dt_image=@dt_image WHERE Id = '" + rowNumber + "'"
                .Parameters.AddWithValue("@dt_image", fileName.ToString)

                ' Check if the data is inserted
                If .ExecuteNonQuery().Equals(1) Then
                    Console.WriteLine("Image inserted.")
                End If

                ' Clear parameters
                .Parameters.Clear()
                .Dispose()
            End With

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

End Class
