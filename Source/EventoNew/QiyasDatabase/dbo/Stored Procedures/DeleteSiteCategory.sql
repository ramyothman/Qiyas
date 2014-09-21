CREATE PROCEDURE [dbo].[DeleteSiteCategory]
    @SiteCategoryId int

AS
Begin
 Delete [ContentManagement].[SiteCategory] where     [SiteCategoryId] = @SiteCategoryId
End
