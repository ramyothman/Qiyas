CREATE PROCEDURE [dbo].[UpdateOrganizationLanguages]
    @OldOrganizationLanguagesId int,
    @OrganizationId int,
    @LanguageId int,
    @OrganizationName nvarchar(50),
    @OrganizationDescription nvarchar(50),
    @AddressLine1 nvarchar(60),
    @AddressLine2 nvarchar(60)
AS
UPDATE [HumanResources].[OrganizationLanguages]
SET
    OrganizationId = @OrganizationId,
    LanguageId = @LanguageId,
    OrganizationName = @OrganizationName,
    OrganizationDescription = @OrganizationDescription,
    AddressLine1 = @AddressLine1,
    AddressLine2 = @AddressLine2
WHERE [OrganizationLanguagesId] = @OLDOrganizationLanguagesId
IF @@ROWCOUNT > 0
Select * From HumanResources.OrganizationLanguages 
Where [OrganizationLanguagesId] = @OLDOrganizationLanguagesId
