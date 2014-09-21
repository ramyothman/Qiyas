CREATE PROCEDURE [dbo].[UpdatePersonDependent]
    @OldPersonDependentId int,
    @PersonId int,
    @DependentName nvarchar(150),
    @Gender nchar(1),
    @Age int,
    @DateOfBirth datetime,
    @Relation nvarchar(50),
    @DateModified datetime
AS
UPDATE [Person].[PersonDependent]
SET
    PersonId = @PersonId,
    DependentName = @DependentName,
    Gender = @Gender,
    Age = @Age,
    DateOfBirth = @DateOfBirth,
    Relation = @Relation,
    DateModified = @DateModified
WHERE [PersonDependentId] = @OLDPersonDependentId
IF @@ROWCOUNT > 0
Select * From Person.PersonDependent 
Where [PersonDependentId] = @OLDPersonDependentId
