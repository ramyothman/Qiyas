CREATE PROCEDURE [dbo].[InsertNewWardBed]
    @WardBedId int output ,
    @WardRoomId int,
    @BedNumber int,
    @BedCode nvarchar(50),
    @BedStatus nvarchar(1),
    @BedType nvarchar(50),
    @BedStatusPercentage int,
    @CurrentPatientCode nvarchar(8),
    @SpecialityId int
AS
INSERT INTO [BedManagement].[WardBed] (
    [WardRoomId],
    [BedNumber],
    [BedCode],
    [BedStatus],
    [BedType],
    [BedStatusPercentage],
    [CurrentPatientCode],
    [SpecialityId])
Values (
    @WardRoomId,
    @BedNumber,
    @BedCode,
    @BedStatus,
    @BedType,
    @BedStatusPercentage,
    @CurrentPatientCode,
    @SpecialityId)
Set @WardBedId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from BedManagement.WardBed
Where [WardBedId] = @@identity
