Create PROCEDURE [dbo].[DeleteSitePageCategoryBySitePageId]
    @SitePageId int

AS
Begin
 Delete [ContentManagement].[SitePageCategory] where     SitePageId = @SitePageId
End
