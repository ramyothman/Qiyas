CREATE PROCEDURE [dbo].[GetByIDArticle]
    @ArticleId int

AS
BEGIN
Select ArticleId, SiteSectionId, CreatorId, ArticleStatusId, AuthorId, PostDate, AllowLanguageSpecificTags, RowGuid, ModifiedDate, CommentsTypeId, EnableModeteration,SiteId
From dbo.GetAllArticle

WHERE [ArticleId] = @ArticleId
END
