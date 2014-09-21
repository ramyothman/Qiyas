
CREATE PROCEDURE [dbo].[DeleteConferenceMainImages]
    @ConferenceMainImageId int

AS
Begin
 Delete [Conference].[ConferenceMainImages] where     [ConferenceMainImageId] = @ConferenceMainImageId
End
