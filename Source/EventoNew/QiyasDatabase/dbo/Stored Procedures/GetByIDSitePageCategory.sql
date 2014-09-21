CREATE PROCEDURE [dbo].[GetByIDSitePageCategory]
    @SitePageCategoryId int

AS
BEGIN
Select SitePageCategoryId, SiteCategoryId, SitePageId, ModifiedDate
From [ContentManagement].[SitePageCategory]

WHERE [SitePageCategoryId] = @SitePageCategoryId
END
