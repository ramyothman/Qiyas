CREATE PROCEDURE [dbo].[UpdateDepartmentLanguages]
    @OldDepartmentLanguagesId int,
    @DepartmentId int,
    @LanguageId int,
    @DepartmentName nvarchar(50),
    @DepartmentDescription nvarchar(50),
    @AddressLine1 nvarchar(60),
    @AddressLine2 nvarchar(60)
AS
UPDATE [HumanResources].[DepartmentLanguages]
SET
    DepartmentId = @DepartmentId,
    LanguageId = @LanguageId,
    DepartmentName = @DepartmentName,
    DepartmentDescription = @DepartmentDescription,
    AddressLine1 = @AddressLine1,
    AddressLine2 = @AddressLine2
WHERE [DepartmentLanguagesId] = @OLDDepartmentLanguagesId
IF @@ROWCOUNT > 0
Select * From HumanResources.DepartmentLanguages 
Where [DepartmentLanguagesId] = @OLDDepartmentLanguagesId
