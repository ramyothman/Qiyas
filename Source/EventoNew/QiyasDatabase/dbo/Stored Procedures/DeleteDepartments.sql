CREATE PROCEDURE [dbo].[DeleteDepartments]
    @DepartmentId int

AS
Begin
 Delete [HumanResources].[Departments] where     [DepartmentId] = @DepartmentId
End
