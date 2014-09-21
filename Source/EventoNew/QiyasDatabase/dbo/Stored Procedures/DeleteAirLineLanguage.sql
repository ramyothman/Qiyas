CREATE PROCEDURE [dbo].[DeleteAirLineLanguage]
    @ID int

AS
Begin
 Delete [Conference].[AirLineLanguage] where     [ID] = @ID
End
