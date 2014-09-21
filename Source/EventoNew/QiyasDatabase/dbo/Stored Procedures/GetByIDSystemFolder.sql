CREATE PROCEDURE [dbo].[GetByIDSystemFolder]
    @SystemFolderId int

AS
BEGIN
Select SystemFolderId, Name, Path
From [ContentManagement].[SystemFolder]

WHERE [SystemFolderId] = @SystemFolderId
END
