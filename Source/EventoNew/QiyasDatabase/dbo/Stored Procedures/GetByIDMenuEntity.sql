CREATE PROCEDURE [dbo].[GetByIDMenuEntity]
    @MenuEntityId int

AS
BEGIN
Select MenuEntityId, MenuName, ContentEntityId,ContentEntityType
From [GetAllMenuEntity]

WHERE [MenuEntityId] = @MenuEntityId
END
