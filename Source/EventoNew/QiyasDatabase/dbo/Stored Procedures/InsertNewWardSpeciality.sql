CREATE PROCEDURE [dbo].[InsertNewWardSpeciality]
    @WardSpecialityId int output ,
    @WardId int,
    @SpecialityId int,
    @IsMain bit
AS
INSERT INTO [BedManagement].[WardSpeciality] (
    [WardId],
    [SpecialityId],
    [IsMain])
Values (
    @WardId,
    @SpecialityId,
    @IsMain)
Set @WardSpecialityId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from BedManagement.WardSpeciality
Where [WardSpecialityId] = @@identity
