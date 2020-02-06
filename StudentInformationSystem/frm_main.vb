Imports System.IO

Public Class frm_main

    ' Initialize Classes
    Dim classMain As New MainClass

    ' Array for populating combobox
    Dim nationalities() As String = {"Filipino", "American", "Australian", "Canadian"}
    Dim yearLevel() As String = {"1st Year", "2nd Year", "3rd Year", "4th Year"}
    Dim program() As String = {"BSIT", "BSBA", "BSED", "BEED", "HTM", "BSCRIM", "AB"}
    Dim department() As String = {"ICT", "Teacher Ed", "Business Ed", "CAS", "Tourism"}
    Dim gender() As String = {"Male", "Female"}
    Dim dataSourceKey() As String = {"info_personal", "info_education", "info_contactperson"}

    ' Form load
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' InitializeComponent class
        Dim studentlist As New StudentList

        ' Show home panel first
        classMain.hideMainPanel(pnl_profile, pnl_main)
        classMain.panelEvents(pnl_home, pnl_main, pnl_sidebar)

        ' Populate combo box for gender
        classMain.comboPopulate(txt_st_gender, gender)

        ' Populate combo box for nationality
        classMain.comboPopulate(txt_st_nationality, nationalities)

        ' Populate combo box for department
        classMain.comboPopulate(txt_ed_department, department)

        ' Populate combo box for program
        classMain.comboPopulate(txt_ed_program, program)

        ' Populate combo box for year level
        classMain.comboPopulate(txt_ed_yearlevel, yearLevel)

        ' View list of students
        studentlist.viewList(list_profile, main_query)

        ' Set form
        frm_toChange = sender

        ' Show form
        frm_login.Show(Me)

    End Sub

    ' Home button   
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

        ' Form loading
        frm_loading.ShowDialog(Me)
        classMain.panelEvents(pnl_home, pnl_main, pnl_sidebar)

    End Sub

    ' Search button
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_list.Click

        ' Show loading
        frm_loading.ShowDialog(Me)
        ' InitializeComponent class
        Dim studentlist As New StudentList

        ' Panel visibility
        classMain.panelEvents(pnl_list, pnl_main, pnl_sidebar)

        ' View list of students
        StudentList.viewList(list_profile, main_query)

    End Sub

    ' Add new button
    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click

        ' Form loading
        frm_loading.ShowDialog(Me)
        classMain.panelEvents(pnl_addnew, pnl_main, pnl_sidebar)

    End Sub

    ' Close button
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

        ' Show message
        messageText = "Thank you & come again!"
        frm_message.ShowDialog(Me)

        ' Close the main form
        Me.Close()

    End Sub

    ' Upload picture
    Private Sub btn_st_add_Click(sender As Object, e As EventArgs) Handles btn_st_addpic.Click

        ' Error handling
        Try

            ' Clear picture box first
            txt_st_picture.Image.Dispose()

            ' Filter for accepted files
            FileDialog.Filter = "JPEG|*.jpg"

            ' Open file dialog box
            If FileDialog.ShowDialog() = DialogResult.OK Then

                ' Set image name
                imageName = FileDialog.FileName

                ' Get file info
                Dim fileInfo As New FileInfo(imageName)
                Dim imageStream As Stream = fileInfo.OpenRead
                Dim imageData(imageStream.Length) As Byte
                imageStream.Read(imageData, 0, fileInfo.Length)

                ' Check file size
                If fileInfo.Length > 500000 Then
                    MsgBox(vbInformation, vbOK, "Image size exceeds the maximum lenght.")
                    Exit Sub
                End If

                ' Show image in picture box 
                txt_st_picture.Image = Image.FromFile(imageName)
                txt_st_picture.BackgroundImageLayout = ImageLayout.Stretch

            End If
        Catch ex As Exception
            Console.WriteLine("You have an error: " & ex.Message)
        End Try

    End Sub

    Private Sub btn_st_addstudent_Click(sender As Object, e As EventArgs) Handles btn_st_addstudent.Click

        ' Check empty inputs
        If classMain.emptyInput(grp_personalinfo) Then
            messageText = "You have empty fields."
            frm_message.ShowDialog(Me)
            Exit Sub
        ElseIf classMain.emptyInput(grp_educationinfo) Then
            messageText = "You have empty fields."
            frm_message.ShowDialog(Me)
            Exit Sub
        ElseIf classMain.emptyInput(grp_contactperson) Then
            messageText = "You have empty fields."
            frm_message.ShowDialog(Me)
            Exit Sub
        ElseIf IsNothing(imageName) Then
            messageText = "No image selected."
            frm_message.ShowDialog(Me)
            Exit Sub
        End If

        'Initialize class
        Dim classPersonalInformation As New PersonalInformation
        Dim classContactPerson As New ContactPerson
        Dim classEducationInformation As New EducationalInformation
        Dim imageClass As New ImageClass

        'Insert personal informtion
        Dim dataPersonalInformation() As String = {txt_st_firtname.Text(), txt_st_lastname.Text(), txt_st_middlename.Text(), txt_st_gender.Text(), txt_st_bday.Text(), txt_st_phone.Text(), txt_st_nationality.Text(), txt_st_bplace.Text(), txt_st_email.Text(), txt_st_address.Text(), imageName}
        classPersonalInformation.insertPersonal(dataPersonalInformation)

        ' Insert contact person
        Dim dataContactPerson() As String = {txt_cp_firstname.Text(), txt_cp_middlename.Text(), txt_cp_lastname.Text(), txt_cp_relationship.Text(), txt_cp_email.Text(), txt_cp_phone.Text(), txt_cp_address.Text()}
        classContactPerson.insertContactPerson(dataContactPerson)

        ' Insert educational information
        Dim dataEducationInformation() As String = {txt_ed_studentid.Text(), txt_ed_program.Text(), txt_ed_yearlevel.Text(), txt_ed_academicyear.Text(), txt_ed_department.Text(), txt_ed_dateenrolled.Text()}
        classEducationInformation.insertEducation(dataEducationInformation)

        ' Upload/Insert image
        imageClass.insertImage(imageName)

        ' Clear text box
        classMain.emptyTextbox(grp_personalinfo)
        classMain.emptyTextbox(grp_contactperson)
        classMain.emptyTextbox(grp_educationinfo)

        ' Clear combo box
        classMain.emptyCombobox(grp_personalinfo)
        classMain.emptyCombobox(grp_educationinfo)

        ' Reset image from picture box to default
        txt_st_picture.Image = Image.FromFile(uploadsDirectory & "\Icons\Actions\Dark\ic_account_circle_dark_48dp.png")
        txt_st_picture.BackgroundImageLayout = ImageLayout.Stretch

        ' Hide panel
        classMain.panelEvents(pnl_home, pnl_main, pnl_sidebar)

        ' Show message
        messageText = "Data successfully added."
        frm_message.ShowDialog(Me)

    End Sub

    ' Search bar
    Private Sub txt_addon_search_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_addon_search.KeyUp

        ' InitializeComponent class
        Dim studentlist As New StudentList

        ' Get value of input
        Dim addon_string As String = txt_addon_search.Text()

        ' Check if textbox if empty
        If addon_string = "" Then
            studentlist.viewList(list_profile, main_query)
        Else
            studentlist.viewList(list_profile, main_query & " WHERE info_personal.dt_lastname LIKE '%" + addon_string + "%' OR info_personal.dt_firstname LIKE '%" + addon_string + "%'")
        End If

    End Sub

    ' Profile panel close button
    Private Sub btn_vp_close_Click(sender As Object, e As EventArgs) Handles btn_vp_close.Click

        ' Form loading
        frm_loading.ShowDialog(Me)

        classMain.hideMainPanel(pnl_profile, pnl_main)

    End Sub

    ' List view item selected
    Private Sub list_profile_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles list_profile.ItemSelectionChanged

        ' Form loading
        frm_loading.ShowDialog(Me)

        ' Initialize class
        Dim profileView As New ProfileView

        ' Variable declaration
        Dim listLabel() As Label

        ' Label array
        listLabel = {txt_vp_st_rowid, txt_vp_st_firstname, txt_vp_st_lastname, txt_vp_st_middlename, txt_vp_st_gender, txt_vp_st_bdate, txt_vp_st_phone, txt_vp_st_nationality, txt_vp_st_bplace, txt_vp_st_email, txt_vp_st_address, txt_vp_st_studentid, txt_vp_st_program, txt_vp_st_yearlevel, txt_vp_st_academicyear, txt_vp_st_department, txt_vp_st_dateenrolled, grd_vp_st_firstname, grd_vp_st_middlename, grd_vp_st_lastname, grd_vp_st_relationship, grd_vp_st_phone, grd_vp_st_email, grd_vp_st_address}

        ' View profile
        profileView.viewProfile(listLabel, pic_vp_profile, e.Item.ImageKey, lbl_student_profile)

        ' Panel visibilty
        classMain.hideMainPanel(pnl_main, pnl_profile)

    End Sub

    Private Sub txt_field_personal_click(sender As Object, e As EventArgs) Handles txt_vp_st_firstname.Click, txt_vp_st_lastname.Click, txt_vp_st_middlename.Click, txt_vp_st_gender.Click, txt_vp_st_bdate.Click, txt_vp_st_phone.Click, txt_vp_st_nationality.Click, txt_vp_st_bplace.Click, txt_vp_st_email.Click, txt_vp_st_address.Click

        ' Initialize class
        Dim updateInfoData As New UpdateInfo
        updateInfoData.mouseEventsUpdate(sender, txt_vp_st_update_personal)

    End Sub

    Private Sub txt_field_education_click(sender As Object, e As EventArgs) Handles txt_vp_st_studentid.Click, txt_vp_st_program.Click, txt_vp_st_yearlevel.Click, txt_vp_st_academicyear.Click, txt_vp_st_department.Click, txt_vp_st_dateenrolled.Click

        ' Initialize class
        Dim updateInfoData As New UpdateInfo
        updateInfoData.mouseEventsUpdate(sender, txt_vp_st_update_education)

    End Sub

    Private Sub txt_field_contact_click(sender As Object, e As EventArgs) Handles grd_vp_st_firstname.Click, grd_vp_st_middlename.Click, grd_vp_st_lastname.Click, grd_vp_st_relationship.Click, grd_vp_st_phone.Click, grd_vp_st_email.Click, grd_vp_st_address.Click

        ' Initialize class
        Dim updateInfoData As New UpdateInfo
        updateInfoData.mouseEventsUpdate(sender, txt_vp_st_update_contact)

    End Sub

    Private Sub txt_vp_st_update_personal_MouseLeave(sender As Object, e As EventArgs) Handles txt_vp_st_update_personal.MouseLeave

        ' Initialize class
        Dim updateInfoData As New UpdateInfo
        updateInfoData.mouseEventsDone(sender, txt_vp_st_rowid.Text, dataSourceKey(0))

    End Sub

    Private Sub txt_vp_st_update_education_MouseLeave(sender As Object, e As EventArgs) Handles txt_vp_st_update_education.MouseLeave

        ' Initialize class
        Dim updateInfoData As New UpdateInfo
        updateInfoData.mouseEventsDone(sender, txt_vp_st_rowid.Text, dataSourceKey(1))

    End Sub

    Private Sub txt_vp_st_update_contact_MouseLeave(sender As Object, e As EventArgs) Handles txt_vp_st_update_contact.MouseLeave

        ' Initialize class
        Dim updateInfoData As New UpdateInfo
        updateInfoData.mouseEventsDone(sender, txt_vp_st_rowid.Text, dataSourceKey(2))

    End Sub

    ' Refresh list view
    Private Sub pic_data_refresh_Click(sender As Object, e As EventArgs) Handles pic_data_refresh.Click

        ' Form loading
        frm_loading.ShowDialog(Me)

        ' InitializeComponent class
        Dim studentlist As New StudentList

        ' Refresh list
        studentlist.viewList(list_profile, main_query)

    End Sub

    ' Deleter student profile
    Private Sub btn_delete_profile_Click(sender As Object, e As EventArgs) Handles btn_delete_profile.Click

        ' Initialize classes
        Dim profileIinfo As New PersonalInformation
        Dim contactPerson As New ContactPerson
        Dim educationProfile As New EducationalInformation

        ' Call methods 
        profileIinfo.deletePersonal(txt_vp_st_rowid.Text)
        contactPerson.deleteContactPerson(txt_vp_st_rowid.Text)
        educationProfile.deleteEducation(txt_vp_st_rowid.Text)

        ' Hide panel
        classMain.hideMainPanel(pnl_profile, pnl_main)

        ' InitializeComponent class
        Dim studentlist As New StudentList

        ' Refresh list
        studentlist.viewList(list_profile, main_query)

        ' Show message
        messageText = "Data successfully deleted."
        frm_message.ShowDialog(Me)

    End Sub

    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click

        ' Show about form
        frm_about.ShowDialog(Me)

    End Sub
End Class
