CREATE PROCEDURE [dbo].[GetByIDPersonEducation]
    @PersonEducationId int

AS
BEGIN
Select PersonEducationId, PersonId, InstitutionName, Degree, StartDate, GraduationDate, FinalGrade
From [Person].[PersonEducation]

WHERE [PersonEducationId] = @PersonEducationId
END
