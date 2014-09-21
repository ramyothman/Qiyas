CREATE PROCEDURE [dbo].[UpdatePageStatus]
    @OldPageStatusId int,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [ContentManagement].[PageStatus]
SET
    Name = @Name,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [PageStatusId] = @OLDPageStatusId
IF @@ROWCOUNT > 0
Select * From ContentManagement.PageStatus 
Where [PageStatusId] = @OLDPageStatusId
