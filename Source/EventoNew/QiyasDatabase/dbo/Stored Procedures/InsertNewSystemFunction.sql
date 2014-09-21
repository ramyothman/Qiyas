CREATE PROCEDURE [dbo].[InsertNewSystemFunction]
    @SystemFunctionId int output ,
    @Name nvarchar(50),
    @IsActive bit,
    @IsBackendFunction bit,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [RoleSecurity].[SystemFunction] (
    [Name],
    [IsActive],
    [IsBackendFunction],
    [RowGuid],
    [ModifiedDate])
Values (
    @Name,
    @IsActive,
    @IsBackendFunction,
    @RowGuid,
    @ModifiedDate)
Set @SystemFunctionId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from RoleSecurity.SystemFunction
Where [SystemFunctionId] = @@identity
