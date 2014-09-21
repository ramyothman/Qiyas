create PROCEDURE [dbo].[GetByCodeLanguage]
    @LanguageCode nvarchar(5)

AS
BEGIN
Select LanguageId, LanguageCode, Name
From [ContentManagement].[Language]

WHERE LanguageCode = @LanguageCode
END
