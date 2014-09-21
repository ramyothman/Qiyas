CREATE PROCEDURE [dbo].[UpdateWardBed]
    @OldWardBedId int,
    @WardRoomId int,
    @BedNumber int,
    @BedCode nvarchar(50),
    @BedStatus nvarchar(1),
    @BedType nvarchar(50),
    @BedStatusPercentage int,
    @CurrentPatientCode nvarchar(8),
    @SpecialityId int
AS
UPDATE [BedManagement].[WardBed]
SET
    WardRoomId = @WardRoomId,
    BedNumber = @BedNumber,
    BedCode = @BedCode,
    BedStatus = @BedStatus,
    BedType = @BedType,
    BedStatusPercentage = @BedStatusPercentage,
    CurrentPatientCode = @CurrentPatientCode,
    SpecialityId = @SpecialityId
WHERE [WardBedId] = @OLDWardBedId
IF @@ROWCOUNT > 0
Select * From BedManagement.WardBed 
Where [WardBedId] = @OLDWardBedId
