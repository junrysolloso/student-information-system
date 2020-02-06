Imports System.Data.SqlClient
Public Class StudentList

    Public Sub viewList(lvw_container As ListView, query As String)

        ' Clear the list 
        lvw_container.Clear()

        ' Variables declaration
        Dim dataTable As New DataTable
        Dim imglist As New ImageList

        ' Set image color depth
        imglist.ColorDepth = ColorDepth.Depth32Bit

        ' Set the size of the image
        lvw_container.LargeImageList = imglist
        lvw_container.LargeImageList.ImageSize = New System.Drawing.Size(200, 200)

        ' Error handling using try and catch
        Try

            ' Open connection
            openConnection()

            ' Build query
            Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter(query, sql_connection)

            ' Fill data table using build query
            dataAdapter.Fill(dataTable)

            ' Loop through the data
            For Each dataItem As DataRow In dataTable.Rows

                ' View image
                imglist.Images.Add(dataItem("Id"), System.Drawing.Image.FromFile(uploadsDirectory & "\Images\" & dataItem("Picture")))

                ' View fullname
                Dim listItem As ListViewItem = New ListViewItem
                listItem.Text = dataItem("Lastname").ToString() & " ," & dataItem("Firstname") & " " & dataItem("Middlename")
                listItem.ImageKey = dataItem("Id").ToString()
                lvw_container.Items.Add(listItem)

            Next
        Catch ex As Exception
            Console.WriteLine("You have an error: " & ex.Message)
        End Try

    End Sub
End Class
