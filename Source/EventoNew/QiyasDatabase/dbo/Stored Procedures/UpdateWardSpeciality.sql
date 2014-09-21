CREATE PROCEDURE [dbo].[UpdateWardSpeciality]
    @OldWardSpecialityId int,
    @WardId int,
    @SpecialityId int,
    @IsMain bit
AS
UPDATE [BedManagement].[WardSpeciality]
SET
    WardId = @WardId,
    SpecialityId = @SpecialityId,
    IsMain = @IsMain
WHERE [WardSpecialityId] = @OLDWardSpecialityId
IF @@ROWCOUNT > 0
Select * From BedManagement.WardSpeciality 
Where [WardSpecialityId] = @OLDWardSpecialityId
