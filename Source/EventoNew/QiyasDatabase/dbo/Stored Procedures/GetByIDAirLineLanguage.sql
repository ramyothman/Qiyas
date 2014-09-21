CREATE PROCEDURE [dbo].[GetByIDAirLineLanguage]
    @ID int

AS
BEGIN
Select ID, Name, LanguageID, AirLineParentID
From [Conference].[AirLineLanguage]

WHERE [ID] = @ID
END
