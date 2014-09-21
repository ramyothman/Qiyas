CREATE PROCEDURE [dbo].[InsertNewOrganizationLanguages]
    @OrganizationLanguagesId int output ,
    @OrganizationId int,
    @LanguageId int,
    @OrganizationName nvarchar(50),
    @OrganizationDescription nvarchar(50),
    @AddressLine1 nvarchar(60),
    @AddressLine2 nvarchar(60)
AS
INSERT INTO [HumanResources].[OrganizationLanguages] (
    [OrganizationId],
    [LanguageId],
    [OrganizationName],
    [OrganizationDescription],
    [AddressLine1],
    [AddressLine2])
Values (
    @OrganizationId,
    @LanguageId,
    @OrganizationName,
    @OrganizationDescription,
    @AddressLine1,
    @AddressLine2)
Set @OrganizationLanguagesId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from HumanResources.OrganizationLanguages
Where [OrganizationLanguagesId] = @@identity
