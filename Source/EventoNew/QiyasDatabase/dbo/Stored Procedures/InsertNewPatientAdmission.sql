CREATE PROCEDURE [dbo].[InsertNewPatientAdmission]
    @PatientAdmissionId int output ,
    @AdmissionStartDate datetime,
    @DischargeDate datetime,
    @AdmissionStayTypeId int,
    @DischargeTypeId int,
    @PatientCode nvarchar(8),
    @ConsultantId int,
    @SpecialityId int,
    @WardBedId int
AS
INSERT INTO [BedManagement].[PatientAdmission] (
    [AdmissionStartDate],
    [DischargeDate],
    [AdmissionStayTypeId],
    [DischargeTypeId],
    [PatientCode],
    [ConsultantId],
    [SpecialityId],
    [WardBedId])
Values (
    @AdmissionStartDate,
    @DischargeDate,
    @AdmissionStayTypeId,
    @DischargeTypeId,
    @PatientCode,
    @ConsultantId,
    @SpecialityId,
    @WardBedId)
Set @PatientAdmissionId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from BedManagement.PatientAdmission
Where [PatientAdmissionId] = @@identity
