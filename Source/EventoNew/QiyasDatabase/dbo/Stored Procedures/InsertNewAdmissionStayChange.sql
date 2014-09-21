CREATE PROCEDURE [dbo].[InsertNewAdmissionStayChange]
    @AdmissionStayChangeId int output ,
    @PatientAdmissionId int,
    @AdmissionStayTypeId int,
    @ModifiedDate datetime
AS
INSERT INTO [BedManagement].[AdmissionStayChange] (
    [PatientAdmissionId],
    [AdmissionStayTypeId],
    [ModifiedDate])
Values (
    @PatientAdmissionId,
    @AdmissionStayTypeId,
    @ModifiedDate)
Set @AdmissionStayChangeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from BedManagement.AdmissionStayChange
Where [AdmissionStayChangeId] = @@identity
