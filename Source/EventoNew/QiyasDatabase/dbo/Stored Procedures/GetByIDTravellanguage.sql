CREATE PROCEDURE [dbo].[GetByIDTravellanguage]
    @ID int

AS
BEGIN
Select ID, Name, TransportationTypeID, Description, ParentID, LanguageID
From [Conference].[Travellanguage]

WHERE [ID] = @ID
END
