CREATE PROCEDURE [dbo].[GetByIDWardBed]
    @WardBedId int

AS
BEGIN
Select WardBedId, WardRoomId, BedNumber, BedCode, BedStatus, BedType, BedStatusPercentage, CurrentPatientCode, SpecialityId
From [BedManagement].[WardBed]

WHERE [WardBedId] = @WardBedId
END
