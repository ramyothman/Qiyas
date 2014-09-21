CREATE PROCEDURE [dbo].[GetByIDPersonRegisterationStatus]
    @PersonRegisterationStatusId int

AS
BEGIN
Select PersonRegisterationStatusId, Status
From [PGME].[PersonRegisterationStatus]

WHERE [PersonRegisterationStatusId] = @PersonRegisterationStatusId
END
