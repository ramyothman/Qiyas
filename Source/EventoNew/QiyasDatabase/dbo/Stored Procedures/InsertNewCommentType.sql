CREATE PROCEDURE [dbo].[InsertNewCommentType]
    @CommentTypeId int output ,
    @CommentTypeName nvarchar(50)
AS
INSERT INTO [ContentManagement].[CommentType] (
    [CommentTypeName])
Values (
    @CommentTypeName)
Set @CommentTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.CommentType
Where [CommentTypeId] = @@identity
