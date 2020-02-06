Imports System.Data.SqlClient
Public Class MainClass

    ' Method for hiding panels
    Public Sub panelEvents(pnl_toshow As Panel, pnl_container As Panel, pnl_exclude As Panel)
        Dim panel As Panel
        For Each panel In pnl_container.Controls.OfType(Of Panel)()
            If Not panel.Equals(pnl_exclude) Then
                If panel.Visible = True Then
                    panel.Visible = False
                End If
            End If
        Next
        pnl_toshow.Visible = True
    End Sub

    ' Check for empty inputs
    Public Function emptyInput(grp_container As GroupBox)
        Dim input As TextBox
        Dim flag As Short = 0
        For Each input In grp_container.Controls.OfType(Of TextBox)()
            If input.Text = "" Then
                flag += 1
            End If
        Next

        ' Check flag if equals to zero
        If flag > 0 Then
            Return True
        End If

    End Function

    ' Populate combo box
    Public Sub comboPopulate(cmb_obj As ComboBox, items As Array)
        Dim item As String
        For Each item In items
            With cmb_obj
                .Items.Add(item)
            End With
        Next
    End Sub

    ' Empty textbox
    Public Sub emptyTextbox(grp_container As GroupBox)
        Dim txtBox As TextBox
        For Each txtBox In grp_container.Controls.OfType(Of TextBox)()
            txtBox.Clear()
        Next
    End Sub

    ' Empty combo box
    Public Sub emptyCombobox(grp_container As GroupBox)
        Dim cmbBox As ComboBox
        For Each cmbBox In grp_container.Controls.OfType(Of ComboBox)()
            cmbBox.ResetText()
        Next
    End Sub

    ' Panel main visiblity
    Public Sub hideMainPanel(pnl_toHide As Panel, pnl_toShow As Panel)
        pnl_toHide.Visible = False
        pnl_toShow.Visible = True
        pnl_toShow.BringToFront()
    End Sub

    ' Center object
    Public Sub centerObject(childObject As Object, parentForm As Form, marginTop As Short)

        ' Center About
        Dim locationPoint As Point
        locationPoint.X = ((parentForm.Width / 2) - (childObject.Width / 2))
        locationPoint.Y = ((parentForm.Height / 2) - (childObject.Height / 2)) + marginTop
        childObject.Location = locationPoint

    End Sub

End Class
