CREATE PROCEDURE [dbo].[DeleteAdmissionStayType]
    @AdmissionStayTypeId int

AS
Begin
 Delete [BedManagement].[AdmissionStayType] where     [AdmissionStayTypeId] = @AdmissionStayTypeId
End
