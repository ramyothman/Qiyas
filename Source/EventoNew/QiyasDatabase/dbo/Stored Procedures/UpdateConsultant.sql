CREATE PROCEDURE [dbo].[UpdateConsultant]
    @ConsultantId int,
    @OldConsultantId int,
    @ConsultantCode nvarchar(50)
AS
UPDATE [BedManagement].[Consultant]
SET
    ConsultantId = @ConsultantId,
    ConsultantCode = @ConsultantCode
WHERE [ConsultantId] = @OLDConsultantId
IF @@ROWCOUNT > 0
Select * From BedManagement.Consultant 
Where [ConsultantId] = @ConsultantId
