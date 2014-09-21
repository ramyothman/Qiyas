CREATE PROCEDURE [dbo].[UpdateContentEntity]
    @OldContentEntityId int,
    @ContentEntityType char(2),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [ContentManagement].[ContentEntity]
SET
    ContentEntityType = @ContentEntityType,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [ContentEntityId] = @OLDContentEntityId
IF @@ROWCOUNT > 0
Select * From ContentManagement.ContentEntity 
Where [ContentEntityId] = @OLDContentEntityId
