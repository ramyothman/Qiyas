CREATE PROCEDURE [dbo].[InsertNewSpeciality]
    @SpecialityId int output ,
    @SpecialityCode nvarchar(8),
    @SpecialityName nvarchar(150),
    @BedDisplayCode nvarchar(50)
AS
INSERT INTO [Organization].[Speciality] (
    [SpecialityCode],
    [SpecialityName],
    [BedDisplayCode])
Values (
    @SpecialityCode,
    @SpecialityName,
    @BedDisplayCode)
Set @SpecialityId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Organization.Speciality
Where [SpecialityId] = @@identity
