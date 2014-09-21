CREATE PROCEDURE [dbo].[UpdateSystemFolder]
    @SystemFolderId int,
    @OldSystemFolderId int,
    @Name nvarchar(150),
    @Path nvarchar(500)
AS
UPDATE [ContentManagement].[SystemFolder]
SET
    SystemFolderId = @SystemFolderId,
    Name = @Name,
    Path = @Path
WHERE [SystemFolderId] = @OLDSystemFolderId
IF @@ROWCOUNT > 0
Select * From ContentManagement.SystemFolder 
Where [SystemFolderId] = @SystemFolderId
