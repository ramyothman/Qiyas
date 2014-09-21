CREATE PROCEDURE [dbo].[InsertNewEducationType]
    @EducationTypeId int output ,
    @EducationTypeName nvarchar(50)
AS
INSERT INTO [Person].[EducationType] (
    [EducationTypeName])
Values (
    @EducationTypeName)
Set @EducationTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Person.EducationType
Where [EducationTypeId] = @@identity
