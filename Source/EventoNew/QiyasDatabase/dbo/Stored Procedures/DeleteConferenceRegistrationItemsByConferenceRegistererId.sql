
CREATE PROCEDURE [dbo].[DeleteConferenceRegistrationItemsByConferenceRegistererId]
    @ConferenceRegistererId int

AS
Begin
 Delete [Conference].[ConferenceRegistrationItems] where     ConferenceRegistererId = @ConferenceRegistererId
End


