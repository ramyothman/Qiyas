CREATE PROCEDURE [dbo].[GetByIDPersonLanguages]
    @PersonLanguageId int

AS
BEGIN
Select PersonLanguageId, PersonId, LanguageId, Title, FirstName, MiddleName, LastName, Suffix, DisplayName
From [Person].[PersonLanguages]

WHERE [PersonLanguageId] = @PersonLanguageId
END
