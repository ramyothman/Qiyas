CREATE PROCEDURE [dbo].[DeleteAdmissionStayChange]
    @AdmissionStayChangeId int

AS
Begin
 Delete [BedManagement].[AdmissionStayChange] where     [AdmissionStayChangeId] = @AdmissionStayChangeId
End
