CREATE PROCEDURE [dbo].[InsertNewCommentStatus]
    @CommentStatusId int output ,
    @CommentStatusName nvarchar(50)
AS
INSERT INTO [ContentManagement].[CommentStatus] (
    [CommentStatusName])
Values (
    @CommentStatusName)
Set @CommentStatusId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.CommentStatus
Where [CommentStatusId] = @@identity
