CREATE PROCEDURE [dbo].[InsertNewArticleStatus]
    @ArticleStatusId int output ,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [ContentManagement].[ArticleStatus] (
    [Name],
    [RowGuid],
    [ModifiedDate])
Values (
    @Name,
    @RowGuid,
    @ModifiedDate)
Set @ArticleStatusId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.ArticleStatus
Where [ArticleStatusId] = @@identity
