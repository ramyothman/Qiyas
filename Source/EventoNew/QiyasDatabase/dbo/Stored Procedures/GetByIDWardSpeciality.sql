CREATE PROCEDURE [dbo].[GetByIDWardSpeciality]
    @WardSpecialityId int

AS
BEGIN
Select WardSpecialityId, WardId, SpecialityId, IsMain
From [BedManagement].[WardSpeciality]

WHERE [WardSpecialityId] = @WardSpecialityId
END
