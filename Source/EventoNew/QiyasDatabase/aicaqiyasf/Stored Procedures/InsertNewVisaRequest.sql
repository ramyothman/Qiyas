CREATE PROCEDURE [aicaqiyasf].InsertNewVisaRequest
    @VisaRequestID int output ,
    @ConferenceID int,
    @PersonID int,
    @Country nvarchar(50),
    @City nvarchar(50),
    @Religion nvarchar(50),
    @JobTitle nvarchar(50),
    @Company nvarchar(50),
    @PassportAttachment nvarchar(250),
    @IsOrganizationApproved bit,
    @IsTaken bit,
    @VisaAttachment nvarchar(250)
AS
INSERT INTO [Conference].[VisaRequest] (
    [ConferenceID],
    [PersonID],
    [Country],
    [City],
    [Religion],
    [JobTitle],
    [Company],
    [PassportAttachment],
    [IsOrganizationApproved],
    [IsTaken],
    [VisaAttachment])
Values (
    @ConferenceID,
    @PersonID,
    @Country,
    @City,
    @Religion,
    @JobTitle,
    @Company,
    @PassportAttachment,
    @IsOrganizationApproved,
    @IsTaken,
    @VisaAttachment)
Set @VisaRequestID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.VisaRequest
Where [VisaRequestID] = @@identity
