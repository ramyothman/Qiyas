Create PROCEDURE [aicaqiyasf].DeleteConferenceRegistrationItems
    @ConferenceRegistrationItemID int

AS
Begin
 Delete [Conference].[ConferenceRegistrationItems] where     [ConferenceRegistrationItemID] = @ConferenceRegistrationItemID
End
