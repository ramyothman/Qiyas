CREATE PROCEDURE [dbo].[GetByIDSystemPage]
    @SystemPageId int

AS
BEGIN
Select SystemPageId, Name, Path, SecurityAccessTypeId, IsActive, RowGuid, ModifiedDate, SystemFolderId
From [ContentManagement].[SystemPage]

WHERE [SystemPageId] = @SystemPageId
END
