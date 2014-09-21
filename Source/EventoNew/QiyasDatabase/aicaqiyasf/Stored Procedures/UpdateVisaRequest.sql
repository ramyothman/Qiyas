CREATE PROCEDURE [aicaqiyasf].UpdateVisaRequest
    @OldVisaRequestID int,
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
UPDATE [Conference].[VisaRequest]
SET
    ConferenceID = @ConferenceID,
    PersonID = @PersonID,
    Country = @Country,
    City = @City,
    Religion = @Religion,
    JobTitle = @JobTitle,
    Company = @Company,
    PassportAttachment = @PassportAttachment,
    IsOrganizationApproved = @IsOrganizationApproved,
    IsTaken = @IsTaken,
    VisaAttachment = @VisaAttachment
WHERE [VisaRequestID] = @OLDVisaRequestID
IF @@ROWCOUNT > 0
Select * From Conference.VisaRequest 
Where [VisaRequestID] = @OLDVisaRequestID
