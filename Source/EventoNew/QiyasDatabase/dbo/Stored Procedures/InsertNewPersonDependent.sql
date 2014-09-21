CREATE PROCEDURE [dbo].[InsertNewPersonDependent]
    @PersonDependentId int output ,
    @PersonId int,
    @DependentName nvarchar(150),
    @Gender nchar(1),
    @Age int,
    @DateOfBirth datetime,
    @Relation nvarchar(50),
    @DateModified datetime
AS
INSERT INTO [Person].[PersonDependent] (
    [PersonId],
    [DependentName],
    [Gender],
    [Age],
    [DateOfBirth],
    [Relation],
    [DateModified])
Values (
    @PersonId,
    @DependentName,
    @Gender,
    @Age,
    @DateOfBirth,
    @Relation,
    @DateModified)
Set @PersonDependentId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Person.PersonDependent
Where [PersonDependentId] = @@identity
