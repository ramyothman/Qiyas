CREATE PROCEDURE [dbo].[GetByIDEmployees]
    @EmployeeId int

AS
BEGIN
Select EmployeeId, EmployeeNumber, DepartmentId, DivisionId, FormalSiteUrl, NationalIdNumber, NationalIdType, ManagerId, BirthDate, MaritalStatus, Gender, HireDate, SalariedFlag, VacationHours, SickLeaveHours, CurrentFlag, RowGuid, ModifiedDate, Position
From [HumanResources].[Employees]

WHERE [EmployeeId] = @EmployeeId
END
