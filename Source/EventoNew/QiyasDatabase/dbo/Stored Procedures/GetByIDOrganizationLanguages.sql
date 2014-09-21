CREATE PROCEDURE [dbo].[GetByIDOrganizationLanguages]
    @OrganizationLanguagesId int

AS
BEGIN
Select OrganizationLanguagesId, OrganizationId, LanguageId, OrganizationName, OrganizationDescription, AddressLine1, AddressLine2
From [HumanResources].[OrganizationLanguages]

WHERE [OrganizationLanguagesId] = @OrganizationLanguagesId
END
