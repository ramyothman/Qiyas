CREATE PROCEDURE [dbo].[DeleteSitePageCategory]
    @SitePageCategoryId int

AS
Begin
 Delete [ContentManagement].[SitePageCategory] where     [SitePageCategoryId] = @SitePageCategoryId
End
