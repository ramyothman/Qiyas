CREATE PROCEDURE [dbo].[UpdateSystemPage]
    @SystemPageId int,
    @OldSystemPageId int,
    @Name nvarchar(50),
    @Path nvarchar(150),
    @SecurityAccessTypeId int,
    @IsActive bit,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime,
    @SystemFolderId int
AS
UPDATE [ContentManagement].[SystemPage]
SET
    SystemPageId = @SystemPageId,
    Name = @Name,
    Path = @Path,
    SecurityAccessTypeId = @SecurityAccessTypeId,
    IsActive = @IsActive,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate,
    SystemFolderId = @SystemFolderId
WHERE [SystemPageId] = @OLDSystemPageId
IF @@ROWCOUNT > 0
Select * From ContentManagement.SystemPage 
Where [SystemPageId] = @SystemPageId
