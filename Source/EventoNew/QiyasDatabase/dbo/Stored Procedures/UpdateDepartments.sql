CREATE PROCEDURE [dbo].[UpdateDepartments]
    @OldDepartmentId int,
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
UPDATE [HumanResources].[Departments]
SET
    OrganizationId = @OrganizationId,
    DepartmentName = @DepartmentName,
    DepartmentDescription = @DepartmentDescription,
    Phone1 = @Phone1,
    Phone2 = @Phone2,
    Fax1 = @Fax1,
    Fax2 = @Fax2,
    AddressLine1 = @AddressLine1,
    AddressLine2 = @AddressLine2
WHERE [DepartmentId] = @OLDDepartmentId
IF @@ROWCOUNT > 0
Select * From HumanResources.Departments 
Where [DepartmentId] = @OLDDepartmentId
