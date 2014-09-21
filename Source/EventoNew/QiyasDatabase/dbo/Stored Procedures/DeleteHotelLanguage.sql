CREATE PROCEDURE [dbo].[DeleteHotelLanguage]
    @ID int

AS
Begin
 Delete [Conference].[HotelLanguage] where     [ID] = @ID
End
