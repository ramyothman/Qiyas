CREATE PROCEDURE [dbo].[InsertNewDepartments]
    @DepartmentId int output ,
    @OrganizationId int,
    @DepartmentName nvarchar(50),
    @DepartmentDescription nvarchar(50),
    @Phone1 nvarchar(20),
    @Phone2 nvarchar(20),
    @Fax1 nvarchar(20),
    @Fax2 nvarchar(20),
    @AddressLine1 nvarchar(60),
    @AddressLine2 nvarchar(60)
AS
INSERT INTO [HumanResources].[Departments] (
    [OrganizationId],
    [DepartmentName],
    [DepartmentDescription],
    [Phone1],
    [Phone2],
    [Fax1],
    [Fax2],
    [AddressLine1],
    [AddressLine2])
Values (
    @OrganizationId,
    @DepartmentName,
    @DepartmentDescription,
    @Phone1,
    @Phone2,
    @Fax1,
    @Fax2,
    @AddressLine1,
    @AddressLine2)
Set @DepartmentId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from HumanResources.Departments
Where [DepartmentId] = @@identity
