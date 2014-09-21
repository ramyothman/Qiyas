CREATE PROCEDURE [dbo].[UpdateSiteCategory]
    @OldSiteCategoryId int,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [ContentManagement].[SiteCategory]
SET
    Name = @Name,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [SiteCategoryId] = @OLDSiteCategoryId
IF @@ROWCOUNT > 0
Select * From ContentManagement.SiteCategory 
Where [SiteCategoryId] = @OLDSiteCategoryId
