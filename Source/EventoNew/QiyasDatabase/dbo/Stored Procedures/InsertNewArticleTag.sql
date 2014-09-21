CREATE PROCEDURE [dbo].[InsertNewArticleTag]
    @ArticleTagId int output ,
    @ArticleId int,
    @Name nvarchar(50),
    @LanguageId int,
    @PostDate datetime
AS
INSERT INTO [ContentManagement].[ArticleTag] (
    [ArticleId],
    [Name],
    [LanguageId],
    [PostDate])
Values (
    @ArticleId,
    @Name,
    @LanguageId,
    @PostDate)
Set @ArticleTagId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.ArticleTag
Where [ArticleTagId] = @@identity
