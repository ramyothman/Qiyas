CREATE PROCEDURE [aicaqiyasf].GetByIDVisaRequest
    @VisaRequestID int

AS
BEGIN
Select VisaRequestID, ConferenceID, PersonID, Country, City, Religion, JobTitle, Company, PassportAttachment, IsOrganizationApproved, IsTaken, VisaAttachment
From [Conference].[VisaRequest]

WHERE [VisaRequestID] = @VisaRequestID
END
