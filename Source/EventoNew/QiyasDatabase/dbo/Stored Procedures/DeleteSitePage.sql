CREATE PROCEDURE [dbo].[DeleteSitePage]
    @SitePageId int

AS
Begin
 Delete [ContentManagement].[SitePage] where     [SitePageId] = @SitePageId
End
