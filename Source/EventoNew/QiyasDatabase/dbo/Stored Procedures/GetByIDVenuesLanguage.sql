CREATE PROCEDURE [dbo].[GetByIDVenuesLanguage]
    @ID int

AS
BEGIN
Select ID, Name, Description, Location, Star, URL, Phone, Fax, Email, LanguageID, parentID
From [Conference].[VenuesLanguage]

WHERE [ID] = @ID
END
