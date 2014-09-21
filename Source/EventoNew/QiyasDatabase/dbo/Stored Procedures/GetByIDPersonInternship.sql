CREATE PROCEDURE [dbo].[GetByIDPersonInternship]
    @PersonInternshipId int

AS
BEGIN
Select PersonInternshipId, PersonId, Service, Institution, Evaluation, StartDate, EndDate
From [Person].[PersonInternship]

WHERE [PersonInternshipId] = @PersonInternshipId
END
