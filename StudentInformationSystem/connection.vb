Imports System.Data.SqlClient

Module connection

    ' Public connection
    Public Property sql_connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\Visual Studio 2015\Projects\StudentInformationSystem\Database\StudentInformationSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30")

    ' SQL Command
    Public Property sql_command As New SqlCommand

    ' Public label
    Public Property lbl_toChange As System.Windows.Forms.Label

    ' Public form
    Public Property frm_toChange As System.Windows.Forms.Form

    ' Public tag
    Public Property tagName As String

    ' Declare variables for imagename
    Public Property imageName As String

    ' Message
    Public Property messageText As String

    ' Default uploads directory
    Public Property uploadsDirectory As String = "C:\Users\USER\Documents\Visual Studio 2015\Projects\StudentInformationSystem\StudentInformationSystem\Uploads"

    ' Query for list of students
    Public Property main_query = "SELECT 
    info_personal.Id,
    info_personal.dt_firstname AS  Firstname,
    info_personal.dt_lastname AS Lastname,
    info_personal.dt_middlename AS Middlename,
    info_personal.dt_gender AS Gender,
    info_personal.dt_bdate AS BirthDate,
    info_personal.dt_phone AS Phone,
    info_personal.dt_nationality AS Nationality,
    info_personal.dt_bplace AS BirthPlace,
    info_personal.dt_email AS Email,
    info_personal.dt_address AS Address,
    info_personal.dt_image AS Picture,
    info_education.dt_studentid AS StudentId,
    info_education.dt_program AS Program,
    info_education.dt_yearlevel AS YearLevel,
    info_education.dt_academicyear AS AcademicYear,
    info_education.dt_department AS Department,
    info_education.dt_dateenrolled AS DateEnrolled,
    info_contactperson.dt_firstname AS GuardianFirstname,
    info_contactperson.dt_lastname AS GuardianLastname,
    info_contactperson.dt_middlename AS GuardianMiddlename,
    info_contactperson.dt_relationship AS GuardianRelationship,
    info_contactperson.dt_phone AS GuardianPhone,
    info_contactperson.dt_email AS GuardianEmail,
    info_contactperson.dt_address AS GuardianAddress
    FROM info_personal LEFT JOIN info_education ON info_personal.Id = info_education.Id LEFT JOIN info_contactperson ON info_personal.Id = info_contactperson.Id"

    ' Open database connection
    Public Sub openConnection()

        Try
            If sql_connection.State <> ConnectionState.Open Then
                sql_connection.Open()
            End If
        Catch ex As Exception
            Console.WriteLine("You have an error: " & ex.Message)
        End Try
    End Sub

End Module
