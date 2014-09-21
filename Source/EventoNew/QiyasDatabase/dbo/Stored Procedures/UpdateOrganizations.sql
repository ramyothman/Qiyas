CREATE PROCEDURE [dbo].[UpdateOrganizations]
    @OldOrganizationId int,
    @OrganizationName nvarchar(50),
    @OrganizationDescription nvarchar(50),
    @Phone1 nvarchar(20),
    @Phone2 nvarchar(20),
    @Phone3 nvarchar(20),
    @Fax1 nvarchar(20),
    @Fax2 nvarchar(20),
    @AddressLine1 nvarchar(60),
    @AddressLine2 nvarchar(60)
AS
UPDATE [HumanResources].[Organizations]
SET
    OrganizationName = @OrganizationName,
    OrganizationDescription = @OrganizationDescription,
    Phone1 = @Phone1,
    Phone2 = @Phone2,
    Phone3 = @Phone3,
    Fax1 = @Fax1,
    Fax2 = @Fax2,
    AddressLine1 = @AddressLine1,
    AddressLine2 = @AddressLine2
WHERE [OrganizationId] = @OLDOrganizationId
IF @@ROWCOUNT > 0
Select * From HumanResources.Organizations 
Where [OrganizationId] = @OLDOrganizationId
