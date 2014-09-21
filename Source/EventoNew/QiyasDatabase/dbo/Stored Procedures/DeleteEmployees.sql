CREATE PROCEDURE [dbo].[DeleteEmployees]
    @EmployeeId int

AS
Begin
 Delete [HumanResources].[Employees] where     [EmployeeId] = @EmployeeId
End
