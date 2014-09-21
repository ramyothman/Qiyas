CREATE PROCEDURE [dbo].[GetByIDHotelLanguage]
    @ID int

AS
BEGIN
Select ID, Name, Description, Location, Star, URL, Phone, Fax, Email, LanguageID, ParentID
From [Conference].[HotelLanguage]

WHERE [ID] = @ID
END
