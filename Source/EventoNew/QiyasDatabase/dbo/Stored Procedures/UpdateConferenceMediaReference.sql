CREATE PROCEDURE [dbo].[UpdateConferenceMediaReference]
    @OldConferenceMediaReferenceId int,
    @ConferenceId int,
    @LanguageId int,
    @ReferenceOrder int,
    @Title nvarchar(250),
    @ReferenceUrl nvarchar(250),
    @ReferenceName nvarchar(150),
    @ReferenceLogo nvarchar(250),
    @PublishingDate datetime
AS
UPDATE [Conference].[ConferenceMediaReference]
SET
    ConferenceId = @ConferenceId,
    LanguageId = @LanguageId,
    ReferenceOrder = @ReferenceOrder,
    Title = @Title,
    ReferenceUrl = @ReferenceUrl,
    ReferenceName = @ReferenceName,
    ReferenceLogo = @ReferenceLogo,
    PublishingDate = @PublishingDate
WHERE [ConferenceMediaReferenceId] = @OLDConferenceMediaReferenceId
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceMediaReference 
Where [ConferenceMediaReferenceId] = @OLDConferenceMediaReferenceId
