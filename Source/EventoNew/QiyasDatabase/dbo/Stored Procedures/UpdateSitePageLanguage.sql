CREATE PROCEDURE [dbo].[UpdateSitePageLanguage]
    @OldSitePageLanguageId int,
    @SitePageId int,
    @LanguageId int,
    @PageName nvarchar(250),
    @PageContent ntext,
    @AuthorAlias nvarchar(50),
    @PageAlias nvarchar(50),
    @ModifiedDate datetime
AS
UPDATE [ContentManagement].[SitePageLanguage]
SET
    SitePageId = @SitePageId,
    LanguageId = @LanguageId,
    PageName = @PageName,
    PageContent = @PageContent,
    AuthorAlias = @AuthorAlias,
    PageAlias = @PageAlias,
    ModifiedDate = @ModifiedDate
WHERE [SitePageLanguageId] = @OLDSitePageLanguageId
IF @@ROWCOUNT > 0
Select * From ContentManagement.SitePageLanguage 
Where [SitePageLanguageId] = @OLDSitePageLanguageId
