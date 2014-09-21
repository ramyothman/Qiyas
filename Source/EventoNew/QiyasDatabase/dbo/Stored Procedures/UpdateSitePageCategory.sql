CREATE PROCEDURE [dbo].[UpdateSitePageCategory]
    @OldSitePageCategoryId int,
    @SiteCategoryId int,
    @SitePageId int,
    @ModifiedDate datetime
AS
UPDATE [ContentManagement].[SitePageCategory]
SET
    SiteCategoryId = @SiteCategoryId,
    SitePageId = @SitePageId,
    ModifiedDate = @ModifiedDate
WHERE [SitePageCategoryId] = @OLDSitePageCategoryId
IF @@ROWCOUNT > 0
Select * From ContentManagement.SitePageCategory 
Where [SitePageCategoryId] = @OLDSitePageCategoryId
