CREATE PROCEDURE [dbo].[GetByIDLanguage]
    @LanguageId int

AS
BEGIN
Select LanguageId, LanguageCode, Name
From [ContentManagement].[Language]

WHERE [LanguageId] = @LanguageId
END
