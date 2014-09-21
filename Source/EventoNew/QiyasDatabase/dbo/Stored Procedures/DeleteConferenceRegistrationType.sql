CREATE PROCEDURE DeleteConferenceRegistrationType
    @ConferenceRegistrationTypeId int

AS
Begin
 Delete [Conference].[ConferenceRegistrationType] where     [ConferenceRegistrationTypeId] = @ConferenceRegistrationTypeId
End
