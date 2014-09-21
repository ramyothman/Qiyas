CREATE PROCEDURE [dbo].[UpdateAdmissionStayChange]
    @OldAdmissionStayChangeId int,
    @PatientAdmissionId int,
    @AdmissionStayTypeId int,
    @ModifiedDate datetime
AS
UPDATE [BedManagement].[AdmissionStayChange]
SET
    PatientAdmissionId = @PatientAdmissionId,
    AdmissionStayTypeId = @AdmissionStayTypeId,
    ModifiedDate = @ModifiedDate
WHERE [AdmissionStayChangeId] = @OLDAdmissionStayChangeId
IF @@ROWCOUNT > 0
Select * From BedManagement.AdmissionStayChange 
Where [AdmissionStayChangeId] = @OLDAdmissionStayChangeId
