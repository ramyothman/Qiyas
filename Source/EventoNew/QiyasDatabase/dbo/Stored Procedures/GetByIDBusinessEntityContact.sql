CREATE PROCEDURE [dbo].[GetByIDBusinessEntityContact]
    @PersonId int

AS
BEGIN
Select ContactTypeId, RowGuid, ModifiedDate, PersonId
From [Person].[BusinessEntityContact]

WHERE [PersonId] = @PersonId
END
