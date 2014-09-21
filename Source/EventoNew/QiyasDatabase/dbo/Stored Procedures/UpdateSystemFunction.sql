CREATE PROCEDURE [dbo].[UpdateSystemFunction]
    @OldSystemFunctionId int,
    @Name nvarchar(50),
    @IsActive bit,
    @IsBackendFunction bit,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [RoleSecurity].[SystemFunction]
SET
    Name = @Name,
    IsActive = @IsActive,
    IsBackendFunction = @IsBackendFunction,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [SystemFunctionId] = @OLDSystemFunctionId
IF @@ROWCOUNT > 0
Select * From RoleSecurity.SystemFunction 
Where [SystemFunctionId] = @OLDSystemFunctionId
