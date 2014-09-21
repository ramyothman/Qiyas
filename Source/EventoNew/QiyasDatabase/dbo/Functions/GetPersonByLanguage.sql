-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[GetPersonByLanguage]
(	
	-- Add the parameters for the function here
	@LanguageCode nvarchar(5)
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT     Person.Person.BusinessEntityId, Person.Person.NameStyle, Person.Person.EmailPromotion, Person.Person.RowGuid, Person.Person.ModifiedDate, 
                      Person.Person.CreatedDate, Person.Person.NationalityCode, Person.PersonLanguages.PersonLanguageId, Person.PersonLanguages.LanguageId, 
                      Person.PersonLanguages.Title, Person.PersonLanguages.FirstName, Person.PersonLanguages.MiddleName, Person.PersonLanguages.LastName, 
                      Person.PersonLanguages.Suffix, Person.PersonLanguages.DisplayName, ContentManagement.Language.LanguageCode, Person.Credential.Username, 
                      ContentManagement.Language.Name, Person.Credential.PasswordHash, Person.Credential.PasswordSalt, Person.Credential.ActivationCode, 
                      Person.Credential.IsActivated, Person.Credential.IsActive, Person.Credential.RowGuid AS Expr1, Person.Credential.ModifiedDate AS Expr2
FROM         Person.Person INNER JOIN
                      Person.PersonLanguages ON Person.Person.BusinessEntityId = Person.PersonLanguages.PersonId INNER JOIN
                      ContentManagement.Language ON Person.PersonLanguages.LanguageId = ContentManagement.Language.LanguageId INNER JOIN
                      Person.Credential ON Person.Person.BusinessEntityId = Person.Credential.BusinessEntityId
     Where LanguageCode = @LanguageCode
)
