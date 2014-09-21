CREATE PROCEDURE [dbo].[UpdatePatientAdmission]
    @OldPatientAdmissionId int,
    @AdmissionStartDate datetime,
    @DischargeDate datetime,
    @AdmissionStayTypeId int,
    @DischargeTypeId int,
    @PatientCode nvarchar(8),
    @ConsultantId int,
    @SpecialityId int,
    @WardBedId int
AS
UPDATE [BedManagement].[PatientAdmission]
SET
    AdmissionStartDate = @AdmissionStartDate,
    DischargeDate = @DischargeDate,
    AdmissionStayTypeId = @AdmissionStayTypeId,
    DischargeTypeId = @DischargeTypeId,
    PatientCode = @PatientCode,
    ConsultantId = @ConsultantId,
    SpecialityId = @SpecialityId,
    WardBedId = @WardBedId
WHERE [PatientAdmissionId] = @OLDPatientAdmissionId
IF @@ROWCOUNT > 0
Select * From BedManagement.PatientAdmission 
Where [PatientAdmissionId] = @OLDPatientAdmissionId
