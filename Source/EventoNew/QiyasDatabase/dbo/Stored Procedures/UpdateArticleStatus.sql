CREATE PROCEDURE [dbo].[UpdateArticleStatus]
    @OldArticleStatusId int,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [ContentManagement].[ArticleStatus]
SET
    Name = @Name,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [ArticleStatusId] = @OLDArticleStatusId
IF @@ROWCOUNT > 0
Select * From ContentManagement.ArticleStatus 
Where [ArticleStatusId] = @OLDArticleStatusId
