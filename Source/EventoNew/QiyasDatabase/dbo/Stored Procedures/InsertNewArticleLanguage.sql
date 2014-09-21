CREATE PROCEDURE [dbo].[InsertNewArticleLanguage]
    @ArticleLanguageId int output ,
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
INSERT INTO [ContentManagement].[ArticleLanguage] (
    [ArticleId],
    [LanguageId],
    [ArticleName],
    [ArticleContent],
    [ArticleAttachment],
    [AuthorAlias],
    [ArticleAlias],
    [PostDate],
    [PublishStartDate],
    [PublishEndDate],
    [RevisionDate],
    [ModifiedDate],
	[ArticleSummary])
Values (
    @ArticleId,
    @LanguageId,
    @ArticleName,
    @ArticleContent,
    @ArticleAttachment,
    @AuthorAlias,
    @ArticleAlias,
    @PostDate,
    @PublishStartDate,
    @PublishEndDate,
    @RevisionDate,
    @ModifiedDate,
	@ArticleSummary)
Set @ArticleLanguageId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.ArticleLanguage
Where [ArticleLanguageId] = @@identity
