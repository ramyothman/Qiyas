CREATE PROCEDURE [dbo].[UpdateEmployees]
    @EmployeeId int,
    @OldEmployeeId int,
    @EmployeeNumber nvarchar(50),
    @DepartmentId int,
    @DivisionId int,
    @FormalSiteUrl nvarchar(250),
    @NationalIdNumber nvarchar(50),
    @NationalIdType nchar(1),
    @ManagerId int,
    @BirthDate datetime,
    @MaritalStatus nchar(1),
    @Gender nchar(1),
    @HireDate datetime,
    @SalariedFlag bit,
    @VacationHours smallint,
    @SickLeaveHours smallint,
    @CurrentFlag bit,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime,
    @Position nvarchar(150)
AS
UPDATE [HumanResources].[Employees]
SET
    EmployeeId = @EmployeeId,
    EmployeeNumber = @EmployeeNumber,
    DepartmentId = @DepartmentId,
    DivisionId = @DivisionId,
    FormalSiteUrl = @FormalSiteUrl,
    NationalIdNumber = @NationalIdNumber,
    NationalIdType = @NationalIdType,
    ManagerId = @ManagerId,
    BirthDate = @BirthDate,
    MaritalStatus = @MaritalStatus,
    Gender = @Gender,
    HireDate = @HireDate,
    SalariedFlag = @SalariedFlag,
    VacationHours = @VacationHours,
    SickLeaveHours = @SickLeaveHours,
    CurrentFlag = @CurrentFlag,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate,
    Position = @Position
WHERE [EmployeeId] = @OLDEmployeeId
IF @@ROWCOUNT > 0
Select * From HumanResources.Employees 
Where [EmployeeId] = @EmployeeId
