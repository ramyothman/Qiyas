CREATE PROCEDURE [dbo].[UpdateRole]
    @OldRoleId int,
    @Name nvarchar(50),
    @IsActive bit,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [RoleSecurity].[Role]
SET
    Name = @Name,
    IsActive = @IsActive,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [RoleId] = @OLDRoleId
IF @@ROWCOUNT > 0
Select * From RoleSecurity.Role 
Where [RoleId] = @OLDRoleId
