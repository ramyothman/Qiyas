CREATE PROCEDURE [dbo].[GetByIDEducationType]
    @EducationTypeId int

AS
BEGIN
Select EducationTypeId, EducationTypeName
From [Person].[EducationType]

WHERE [EducationTypeId] = @EducationTypeId
END
