CREATE PROCEDURE [dbo].[GetByIDOrganizations]
    @OrganizationId int

AS
BEGIN
Select OrganizationId, OrganizationName, OrganizationDescription, Phone1, Phone2, Phone3, Fax1, Fax2, AddressLine1, AddressLine2
From [HumanResources].[Organizations]

WHERE [OrganizationId] = @OrganizationId
END
