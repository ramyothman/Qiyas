CREATE PROCEDURE [dbo].[DeleteSiteSection]
    @SiteSectionId int

AS
Begin
 Delete [ContentManagement].[SiteSection] where     [SiteSectionId] = @SiteSectionId
End
