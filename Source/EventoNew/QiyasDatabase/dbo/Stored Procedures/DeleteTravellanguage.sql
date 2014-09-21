CREATE PROCEDURE [dbo].[DeleteTravellanguage]
    @ID int

AS
Begin
 Delete [Conference].[Travellanguage] where     [ID] = @ID
End
