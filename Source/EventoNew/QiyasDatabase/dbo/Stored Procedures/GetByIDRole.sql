CREATE PROCEDURE [dbo].[GetByIDRole]
    @RoleId int

AS
BEGIN
Select RoleId, Name, IsActive, RowGuid, ModifiedDate
From [RoleSecurity].[Role]

WHERE [RoleId] = @RoleId
END
