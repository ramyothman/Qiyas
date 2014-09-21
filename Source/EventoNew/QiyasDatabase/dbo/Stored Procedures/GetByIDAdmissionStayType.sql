CREATE PROCEDURE [dbo].[GetByIDAdmissionStayType]
    @AdmissionStayTypeId int

AS
BEGIN
Select AdmissionStayTypeId, Name, Duration, Code, AdmissionStayOrder
From [BedManagement].[AdmissionStayType]

WHERE [AdmissionStayTypeId] = @AdmissionStayTypeId
END
