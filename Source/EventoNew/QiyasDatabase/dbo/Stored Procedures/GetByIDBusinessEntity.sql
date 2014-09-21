CREATE PROCEDURE [dbo].[GetByIDBusinessEntity]
    @BusinessEntityId int

AS
BEGIN
Select BusinessEntityId, RowGuid, ModifiedDate
From [Person].[BusinessEntity]

WHERE [BusinessEntityId] = @BusinessEntityId
END
