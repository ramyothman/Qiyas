CREATE PROCEDURE [dbo].[InsertNewBusinessEntityContact]
    @ContactTypeId int,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime,
    @PersonId int
AS
INSERT INTO [Person].[BusinessEntityContact] (
    [ContactTypeId],
    [RowGuid],
    [ModifiedDate],
    [PersonId])
Values (
    @ContactTypeId,
    @RowGuid,
    @ModifiedDate,
    @PersonId)

IF @@ROWCOUNT > 0
Select * from Person.BusinessEntityContact
Where [PersonId] = @PersonId
