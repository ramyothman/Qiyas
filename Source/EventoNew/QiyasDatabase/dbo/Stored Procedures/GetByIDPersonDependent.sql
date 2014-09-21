CREATE PROCEDURE [dbo].[GetByIDPersonDependent]
    @PersonDependentId int

AS
BEGIN
Select PersonDependentId, PersonId, DependentName, Gender, Age, DateOfBirth, Relation, DateModified
From [Person].[PersonDependent]

WHERE [PersonDependentId] = @PersonDependentId
END
