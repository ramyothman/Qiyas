CREATE PROCEDURE [dbo].[UpdateAdmissionStayType]
    @OldAdmissionStayTypeId int,
    @Name nvarchar(250),
    @Duration int,
    @Code nvarchar(5),
    @AdmissionStayOrder int
AS
UPDATE [BedManagement].[AdmissionStayType]
SET
    Name = @Name,
    Duration = @Duration,
    Code = @Code,
    AdmissionStayOrder = @AdmissionStayOrder
WHERE [AdmissionStayTypeId] = @OLDAdmissionStayTypeId
IF @@ROWCOUNT > 0
Select * From BedManagement.AdmissionStayType 
Where [AdmissionStayTypeId] = @OLDAdmissionStayTypeId
