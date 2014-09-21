CREATE PROCEDURE [dbo].[GetByIDPersonSCHealthSpeciality]
    @PersonSCHealthSpecialityId int

AS
BEGIN
Select PersonSCHealthSpecialityId, PersonId, Score, DateTaken, LicensingNumber, RegisterationNumber
From [PGME].[PersonSCHealthSpeciality]

WHERE [PersonSCHealthSpecialityId] = @PersonSCHealthSpecialityId
END
