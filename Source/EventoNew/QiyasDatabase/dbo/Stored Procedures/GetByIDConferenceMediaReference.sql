CREATE PROCEDURE [dbo].[GetByIDConferenceMediaReference]
    @ConferenceMediaReferenceId int

AS
BEGIN
Select ConferenceMediaReferenceId, ConferenceId, LanguageId, ReferenceOrder, Title, ReferenceUrl, ReferenceName, ReferenceLogo, PublishingDate
From [Conference].[ConferenceMediaReference]

WHERE [ConferenceMediaReferenceId] = @ConferenceMediaReferenceId
END
