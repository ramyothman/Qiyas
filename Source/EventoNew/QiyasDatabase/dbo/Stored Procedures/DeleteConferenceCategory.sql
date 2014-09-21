CREATE PROCEDURE [dbo].[DeleteConferenceCategory]
    @ConferenceCategoryId int

AS
Begin
 Delete [Conference].[ConferenceCategory] where     [ConferenceCategoryId] = @ConferenceCategoryId
End
