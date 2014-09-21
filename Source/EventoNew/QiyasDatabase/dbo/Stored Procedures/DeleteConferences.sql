CREATE PROCEDURE DeleteConferences
    @ConferenceId int

AS
Begin
 Delete [Conference].[Conferences] where     [ConferenceId] = @ConferenceId
End
