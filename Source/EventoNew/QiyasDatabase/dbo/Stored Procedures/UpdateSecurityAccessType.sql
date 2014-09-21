CREATE PROCEDURE [dbo].[UpdateSecurityAccessType]
    @OldSecurityAccessTypeId int,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [RoleSecurity].[SecurityAccessType]
SET
    Name = @Name,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [SecurityAccessTypeId] = @OLDSecurityAccessTypeId
IF @@ROWCOUNT > 0
Select * From RoleSecurity.SecurityAccessType 
Where [SecurityAccessTypeId] = @OLDSecurityAccessTypeId
