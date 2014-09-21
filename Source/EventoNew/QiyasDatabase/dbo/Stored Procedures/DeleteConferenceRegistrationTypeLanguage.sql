CREATE PROCEDURE DeleteConferenceRegistrationTypeLanguage
    @ConferenceRegistrationTypeId int

AS
Begin
 Delete [Conference].[ConferenceRegistrationTypeLanguage] where     [ConferenceRegistrationTypeId] = @ConferenceRegistrationTypeId
End
