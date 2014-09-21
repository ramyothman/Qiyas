CREATE PROCEDURE [dbo].[DeleteOrganizationLanguages]
    @OrganizationLanguagesId int

AS
Begin
 Delete [HumanResources].[OrganizationLanguages] where     [OrganizationLanguagesId] = @OrganizationLanguagesId
End
