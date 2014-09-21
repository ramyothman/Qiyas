CREATE PROCEDURE [dbo].[DeleteHotel]
    @ID int

AS
Begin
 Delete [Conference].[Hotel] where     [ID] = @ID
End
