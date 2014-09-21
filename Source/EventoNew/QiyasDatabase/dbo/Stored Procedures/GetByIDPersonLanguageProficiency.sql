CREATE PROCEDURE [dbo].[GetByIDPersonLanguageProficiency]
    @PersonLanguageProficiencyId int

AS
BEGIN
Select PersonLanguageProficiencyId, PersonId, LanguageId, CanRead, CanWrite, CanSpeak
From [Person].[PersonLanguageProficiency]

WHERE [PersonLanguageProficiencyId] = @PersonLanguageProficiencyId
END
