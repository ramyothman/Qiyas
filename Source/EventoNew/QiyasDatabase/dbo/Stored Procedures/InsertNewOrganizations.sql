CREATE PROCEDURE [dbo].[InsertNewOrganizations]
    @OrganizationId int output ,
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
INSERT INTO [HumanResources].[Organizations] (
    [OrganizationName],
    [OrganizationDescription],
    [Phone1],
    [Phone2],
    [Phone3],
    [Fax1],
    [Fax2],
    [AddressLine1],
    [AddressLine2])
Values (
    @OrganizationName,
    @OrganizationDescription,
    @Phone1,
    @Phone2,
    @Phone3,
    @Fax1,
    @Fax2,
    @AddressLine1,
    @AddressLine2)
Set @OrganizationId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from HumanResources.Organizations
Where [OrganizationId] = @@identity
