CREATE PROCEDURE [dbo].[GetByIDPatientAdmission]
    @PatientAdmissionId int

AS
BEGIN
Select PatientAdmissionId, AdmissionStartDate, DischargeDate, AdmissionStayTypeId, DischargeTypeId, PatientCode, ConsultantId, SpecialityId, WardBedId
From [BedManagement].[PatientAdmission]

WHERE [PatientAdmissionId] = @PatientAdmissionId
END
