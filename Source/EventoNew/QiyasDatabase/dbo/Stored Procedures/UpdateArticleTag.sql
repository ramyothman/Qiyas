CREATE PROCEDURE [dbo].[UpdateArticleTag]
    @OldArticleTagId int,
    @ArticleId int,
    @Name nvarchar(50),
    @LanguageId int,
    @PostDate datetime
AS
UPDATE [ContentManagement].[ArticleTag]
SET
    ArticleId = @ArticleId,
    Name = @Name,
    LanguageId = @LanguageId,
    PostDate = @PostDate
WHERE [ArticleTagId] = @OLDArticleTagId
IF @@ROWCOUNT > 0
Select * From ContentManagement.ArticleTag 
Where [ArticleTagId] = @OLDArticleTagId
