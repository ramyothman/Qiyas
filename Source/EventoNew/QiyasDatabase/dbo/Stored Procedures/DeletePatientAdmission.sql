CREATE PROCEDURE [dbo].[DeletePatientAdmission]
    @PatientAdmissionId int

AS
Begin
 Delete [BedManagement].[PatientAdmission] where     [PatientAdmissionId] = @PatientAdmissionId
End
