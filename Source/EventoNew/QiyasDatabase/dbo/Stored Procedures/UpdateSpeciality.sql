CREATE PROCEDURE [dbo].[UpdateSpeciality]
    @OldSpecialityId int,
    @SpecialityCode nvarchar(8),
    @SpecialityName nvarchar(150),
    @BedDisplayCode nvarchar(50)
AS
UPDATE [Organization].[Speciality]
SET
    SpecialityCode = @SpecialityCode,
    SpecialityName = @SpecialityName,
    BedDisplayCode = @BedDisplayCode
WHERE [SpecialityId] = @OLDSpecialityId
IF @@ROWCOUNT > 0
Select * From Organization.Speciality 
Where [SpecialityId] = @OLDSpecialityId
