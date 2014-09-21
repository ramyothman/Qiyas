CREATE PROCEDURE [aicaqiyasf].DeleteVisaRequest
    @VisaRequestID int

AS
Begin
 Delete [Conference].[VisaRequest] where     [VisaRequestID] = @VisaRequestID
End
