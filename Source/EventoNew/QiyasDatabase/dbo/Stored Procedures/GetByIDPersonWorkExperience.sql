CREATE PROCEDURE [dbo].[GetByIDPersonWorkExperience]
    @PersonWorkExperienceId int

AS
BEGIN
Select PersonWorkExperienceId, PersonId, Employer, PositionHeld, Responsibilities, StartDate, EndDate
From [Person].[PersonWorkExperience]

WHERE [PersonWorkExperienceId] = @PersonWorkExperienceId
END
