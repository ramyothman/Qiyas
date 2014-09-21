CREATE PROCEDURE [dbo].[InsertNewDepartmentLanguages]
    @DepartmentLanguagesId int output ,
    @DepartmentId int,
    @LanguageId int,
    @DepartmentName nvarchar(50),
    @DepartmentDescription nvarchar(50),
    @AddressLine1 nvarchar(60),
    @AddressLine2 nvarchar(60)
AS
INSERT INTO [HumanResources].[DepartmentLanguages] (
    [DepartmentId],
    [LanguageId],
    [DepartmentName],
    [DepartmentDescription],
    [AddressLine1],
    [AddressLine2])
Values (
    @DepartmentId,
    @LanguageId,
    @DepartmentName,
    @DepartmentDescription,
    @AddressLine1,
    @AddressLine2)
Set @DepartmentLanguagesId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from HumanResources.DepartmentLanguages
Where [DepartmentLanguagesId] = @@identity
