CREATE PROCEDURE [dbo].[DeleteTravel]
    @ID int

AS
Begin
 Delete [Conference].[Travel] where     [ID] = @ID
End
