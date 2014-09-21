CREATE PROCEDURE [dbo].[GetByIDSpeciality]
    @SpecialityId int

AS
BEGIN
Select SpecialityId, SpecialityCode, SpecialityName, BedDisplayCode
From [Organization].[Speciality]

WHERE [SpecialityId] = @SpecialityId
END
