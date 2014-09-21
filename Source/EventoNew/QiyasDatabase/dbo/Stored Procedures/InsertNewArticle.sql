CREATE PROCEDURE [dbo].[InsertNewArticle]
    @ArticleId int,
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
INSERT INTO [ContentManagement].[Article] (
    [ArticleId],
    [SiteSectionId],
    [CreatorId],
    [ArticleStatusId],
    [AuthorId],
    [PostDate],
    [AllowLanguageSpecificTags],
    [RowGuid],
    [ModifiedDate],
    [CommentsTypeId],
    [EnableModeteration])
Values (
    @ArticleId,
    @SiteSectionId,
    @CreatorId,
    @ArticleStatusId,
    @AuthorId,
    @PostDate,
    @AllowLanguageSpecificTags,
    @RowGuid,
    @ModifiedDate,
    @CommentsTypeId,
    @EnableModeteration)

IF @@ROWCOUNT > 0
Select * from ContentManagement.Article
Where [ArticleId] = @ArticleId
