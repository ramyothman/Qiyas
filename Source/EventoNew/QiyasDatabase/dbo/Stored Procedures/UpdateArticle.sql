CREATE PROCEDURE [dbo].[UpdateArticle]
    @ArticleId int,
    @OldArticleId int,
    @SiteSectionId int,
    @CreatorId int,
    @ArticleStatusId int,
    @AuthorId int,
    @PostDate datetime,
    @AllowLanguageSpecificTags bit,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime,
    @CommentsTypeId int,
    @EnableModeteration bit
AS
UPDATE [ContentManagement].[Article]
SET
    ArticleId = @ArticleId,
    SiteSectionId = @SiteSectionId,
    CreatorId = @CreatorId,
    ArticleStatusId = @ArticleStatusId,
    AuthorId = @AuthorId,
    PostDate = @PostDate,
    AllowLanguageSpecificTags = @AllowLanguageSpecificTags,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate,
    CommentsTypeId = @CommentsTypeId,
    EnableModeteration = @EnableModeteration
WHERE [ArticleId] = @OLDArticleId
IF @@ROWCOUNT > 0
Select * From ContentManagement.Article 
Where [ArticleId] = @ArticleId
