CREATE PROCEDURE [dbo].[GetByIDDepartments]
    @DepartmentId int

AS
BEGIN
Select DepartmentId, OrganizationId, DepartmentName, DepartmentDescription, Phone1, Phone2, Fax1, Fax2, AddressLine1, AddressLine2
From [HumanResources].[Departments]

WHERE [DepartmentId] = @DepartmentId
END
