CREATE PROCEDURE [dbo].[DeleteAirLine]
    @ID int

AS
Begin
 Delete [Conference].[AirLine] where     [ID] = @ID
End
