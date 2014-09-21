CREATE PROCEDURE [dbo].[GetByIDDepartmentLanguages]
    @DepartmentLanguagesId int

AS
BEGIN
Select DepartmentLanguagesId, DepartmentId, LanguageId, DepartmentName, DepartmentDescription, AddressLine1, AddressLine2
From [HumanResources].[DepartmentLanguages]

WHERE [DepartmentLanguagesId] = @DepartmentLanguagesId
END
