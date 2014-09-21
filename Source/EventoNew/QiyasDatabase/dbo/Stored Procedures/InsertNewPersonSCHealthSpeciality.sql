CREATE PROCEDURE [dbo].[InsertNewPersonSCHealthSpeciality]
    @PersonSCHealthSpecialityId int output ,
    @PersonId int,
    @Score decimal(18,2),
    @DateTaken datetime,
    @LicensingNumber nvarchar(50),
    @RegisterationNumber nvarchar(50)
AS
INSERT INTO [PGME].[PersonSCHealthSpeciality] (
    [PersonId],
    [Score],
    [DateTaken],
    [LicensingNumber],
    [RegisterationNumber])
Values (
    @PersonId,
    @Score,
    @DateTaken,
    @LicensingNumber,
    @RegisterationNumber)
Set @PersonSCHealthSpecialityId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from PGME.PersonSCHealthSpeciality
Where [PersonSCHealthSpecialityId] = @@identity
