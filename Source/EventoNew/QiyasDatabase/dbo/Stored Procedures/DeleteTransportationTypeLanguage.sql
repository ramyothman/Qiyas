CREATE PROCEDURE [dbo].[DeleteTransportationTypeLanguage]
    @ID int

AS
Begin
 Delete [Conference].[TransportationTypeLanguage] where     [ID] = @ID
End
