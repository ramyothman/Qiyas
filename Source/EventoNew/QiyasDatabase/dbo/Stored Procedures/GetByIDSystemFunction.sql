CREATE PROCEDURE [dbo].[GetByIDSystemFunction]
    @SystemFunctionId int

AS
BEGIN
Select SystemFunctionId, Name, IsActive, IsBackendFunction, RowGuid, ModifiedDate
From [RoleSecurity].[SystemFunction]

WHERE [SystemFunctionId] = @SystemFunctionId
END
