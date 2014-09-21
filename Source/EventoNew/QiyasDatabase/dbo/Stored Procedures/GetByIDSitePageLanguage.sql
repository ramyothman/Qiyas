CREATE PROCEDURE [dbo].[GetByIDSitePageLanguage]
    @SitePageLanguageId int

AS
BEGIN
Select SitePageLanguageId, SitePageId, LanguageId, PageName, PageContent, AuthorAlias, PageAlias, ModifiedDate
From [ContentManagement].[SitePageLanguage]

WHERE [SitePageLanguageId] = @SitePageLanguageId
END
