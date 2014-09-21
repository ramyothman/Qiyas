CREATE PROCEDURE [dbo].[UpdateBusinessEntityContact]
    @ContactTypeId int,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime,
    @PersonId int,
    @OldPersonId int
AS
UPDATE [Person].[BusinessEntityContact]
SET
    ContactTypeId = @ContactTypeId,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate,
    PersonId = @PersonId
WHERE [PersonId] = @OLDPersonId
IF @@ROWCOUNT > 0
Select * From Person.BusinessEntityContact 
Where [PersonId] = @PersonId
