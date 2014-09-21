CREATE PROCEDURE [dbo].[InsertNewSitePageLanguage]
    @SitePageLanguageId int output ,
    @SitePageId int,
    @LanguageId int,
    @PageName nvarchar(250),
    @PageContent ntext,
    @AuthorAlias nvarchar(50),
    @PageAlias nvarchar(50),
    @ModifiedDate datetime
AS
INSERT INTO [ContentManagement].[SitePageLanguage] (
    [SitePageId],
    [LanguageId],
    [PageName],
    [PageContent],
    [AuthorAlias],
    [PageAlias],
    [ModifiedDate])
Values (
    @SitePageId,
    @LanguageId,
    @PageName,
    @PageContent,
    @AuthorAlias,
    @PageAlias,
    @ModifiedDate)
Set @SitePageLanguageId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.SitePageLanguage
Where [SitePageLanguageId] = @@identity
