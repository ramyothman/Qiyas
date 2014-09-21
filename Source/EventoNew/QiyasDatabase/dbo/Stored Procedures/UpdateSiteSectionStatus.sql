CREATE PROCEDURE [dbo].[UpdateSiteSectionStatus]
    @OldSiteSectionStatusId int,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [ContentManagement].[SiteSectionStatus]
SET
    Name = @Name,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [SiteSectionStatusId] = @OLDSiteSectionStatusId
IF @@ROWCOUNT > 0
Select * From ContentManagement.SiteSectionStatus 
Where [SiteSectionStatusId] = @OLDSiteSectionStatusId
