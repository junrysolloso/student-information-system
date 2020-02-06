SELECT 
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

FROM info_personal LEFT JOIN info_education ON info_personal.Id = info_education.Id LEFT JOIN info_contactperson ON info_personal.Id = info_contactperson.Id