Create PROCEDURE [dbo].[GetByPageIDLanguageIdSitePageLanguage]
    @SitePageId int,
    @LanguageId int

AS
BEGIN
Select SitePageLanguageId, SitePageId, LanguageId, PageName, PageContent, AuthorAlias, PageAlias, ModifiedDate
From [ContentManagement].[SitePageLanguage]

WHERE SitePageId = @SitePageId and LanguageId = @LanguageId
END
