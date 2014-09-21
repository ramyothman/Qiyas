CREATE PROCEDURE [dbo].[InsertNewAdmissionStayType]
    @AdmissionStayTypeId int output ,
    @Name nvarchar(250),
    @Duration int,
    @Code nvarchar(5),
    @AdmissionStayOrder int
AS
INSERT INTO [BedManagement].[AdmissionStayType] (
    [Name],
    [Duration],
    [Code],
    [AdmissionStayOrder])
Values (
    @Name,
    @Duration,
    @Code,
    @AdmissionStayOrder)
Set @AdmissionStayTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from BedManagement.AdmissionStayType
Where [AdmissionStayTypeId] = @@identity
