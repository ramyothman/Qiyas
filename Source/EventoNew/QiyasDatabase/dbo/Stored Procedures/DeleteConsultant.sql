CREATE PROCEDURE [dbo].[DeleteConsultant]
    @ConsultantId int

AS
Begin
 Delete [BedManagement].[Consultant] where     [ConsultantId] = @ConsultantId
End
