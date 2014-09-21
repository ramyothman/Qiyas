CREATE PROCEDURE [dbo].[InsertNewConsultant]
    @ConsultantId int,
    @ConsultantCode nvarchar(50)
AS
INSERT INTO [BedManagement].[Consultant] (
    [ConsultantId],
    [ConsultantCode])
Values (
    @ConsultantId,
    @ConsultantCode)

IF @@ROWCOUNT > 0
Select * from BedManagement.Consultant
Where [ConsultantId] = @ConsultantId
