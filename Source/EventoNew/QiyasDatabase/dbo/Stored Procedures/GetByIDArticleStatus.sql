CREATE PROCEDURE [dbo].[GetByIDArticleStatus]
    @ArticleStatusId int

AS
BEGIN
Select ArticleStatusId, Name, RowGuid, ModifiedDate
From [ContentManagement].[ArticleStatus]

WHERE [ArticleStatusId] = @ArticleStatusId
END
