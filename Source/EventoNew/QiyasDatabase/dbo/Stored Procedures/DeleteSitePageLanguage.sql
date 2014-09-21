CREATE PROCEDURE [dbo].[DeleteSitePageLanguage]
    @SitePageLanguageId int

AS
Begin
 Delete [ContentManagement].[SitePageLanguage] where     [SitePageLanguageId] = @SitePageLanguageId
End
