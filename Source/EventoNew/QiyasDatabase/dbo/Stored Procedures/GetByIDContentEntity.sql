CREATE PROCEDURE [dbo].[GetByIDContentEntity]
    @ContentEntityId int

AS
BEGIN
Select ContentEntityId, ContentEntityType, RowGuid, ModifiedDate
From [ContentManagement].[ContentEntity]

WHERE [ContentEntityId] = @ContentEntityId
END
