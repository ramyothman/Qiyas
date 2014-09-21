CREATE PROCEDURE [dbo].[GetByIDTransportationTypeLanguage]
    @ID int

AS
BEGIN
Select ID, TypeName, LanguageID, ParentID
From [Conference].[TransportationTypeLanguage]

WHERE [ID] = @ID
END
