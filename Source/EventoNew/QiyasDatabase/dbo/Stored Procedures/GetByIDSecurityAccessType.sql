CREATE PROCEDURE [dbo].[GetByIDSecurityAccessType]
    @SecurityAccessTypeId int

AS
BEGIN
Select SecurityAccessTypeId, Name, RowGuid, ModifiedDate
From [RoleSecurity].[SecurityAccessType]

WHERE [SecurityAccessTypeId] = @SecurityAccessTypeId
END
