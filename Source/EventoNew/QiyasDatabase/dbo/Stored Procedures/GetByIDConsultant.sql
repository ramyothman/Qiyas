CREATE PROCEDURE [dbo].[GetByIDConsultant]
    @ConsultantId int

AS
BEGIN
Select ConsultantId, ConsultantCode
From [BedManagement].[Consultant]

WHERE [ConsultantId] = @ConsultantId
END
