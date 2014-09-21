CREATE PROCEDURE [dbo].[InsertNewSystemFolder]
    @SystemFolderId int,
    @Name nvarchar(150),
    @Path nvarchar(500)
AS
INSERT INTO [ContentManagement].[SystemFolder] (
    [SystemFolderId],
    [Name],
    [Path])
Values (
    @SystemFolderId,
    @Name,
    @Path)

IF @@ROWCOUNT > 0
Select * from ContentManagement.SystemFolder
Where [SystemFolderId] = @SystemFolderId
