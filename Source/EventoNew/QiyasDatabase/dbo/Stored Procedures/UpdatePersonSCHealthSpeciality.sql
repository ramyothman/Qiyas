CREATE PROCEDURE [dbo].[UpdatePersonSCHealthSpeciality]
    @OldPersonSCHealthSpecialityId int,
    @PersonId int,
    @Score decimal(18,2),
    @DateTaken datetime,
    @LicensingNumber nvarchar(50),
    @RegisterationNumber nvarchar(50)
AS
UPDATE [PGME].[PersonSCHealthSpeciality]
SET
    PersonId = @PersonId,
    Score = @Score,
    DateTaken = @DateTaken,
    LicensingNumber = @LicensingNumber,
    RegisterationNumber = @RegisterationNumber
WHERE [PersonSCHealthSpecialityId] = @OLDPersonSCHealthSpecialityId
IF @@ROWCOUNT > 0
Select * From PGME.PersonSCHealthSpeciality 
Where [PersonSCHealthSpecialityId] = @OLDPersonSCHealthSpecialityId
