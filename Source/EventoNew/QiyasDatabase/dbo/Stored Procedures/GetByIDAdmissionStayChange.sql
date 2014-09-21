CREATE PROCEDURE [dbo].[GetByIDAdmissionStayChange]
    @AdmissionStayChangeId int

AS
BEGIN
Select AdmissionStayChangeId, PatientAdmissionId, AdmissionStayTypeId, ModifiedDate
From [BedManagement].[AdmissionStayChange]

WHERE [AdmissionStayChangeId] = @AdmissionStayChangeId
END
