CREATE PROCEDURE [dbo].[UpdateArticleLanguage]
    @OldArticleLanguageId int,
    @ArticleId int,
    @LanguageId int,
    @ArticleName nvarchar(50),
    @ArticleContent ntext,
    @ArticleAttachment nvarchar(255),
    @AuthorAlias nvarchar(50),
    @ArticleAlias nvarchar(50),
    @PostDate datetime,
    @PublishStartDate datetime,
    @PublishEndDate datetime,
    @RevisionDate datetime,
    @ModifiedDate datetime,
	@ArticleSummary nvarchar(500)
AS
UPDATE [ContentManagement].[ArticleLanguage]
SET
    ArticleId = @ArticleId,
    LanguageId = @LanguageId,
    ArticleName = @ArticleName,
    ArticleContent = @ArticleContent,
    ArticleAttachment = @ArticleAttachment,
    AuthorAlias = @AuthorAlias,
    ArticleAlias = @ArticleAlias,
    PostDate = @PostDate,
    PublishStartDate = @PublishStartDate,
    PublishEndDate = @PublishEndDate,
    RevisionDate = @RevisionDate,
    ModifiedDate = @ModifiedDate,
	ArticleSummary = @ArticleSummary
WHERE [ArticleLanguageId] = @OLDArticleLanguageId
IF @@ROWCOUNT > 0
Select * From ContentManagement.ArticleLanguage 
Where [ArticleLanguageId] = @OLDArticleLanguageId
