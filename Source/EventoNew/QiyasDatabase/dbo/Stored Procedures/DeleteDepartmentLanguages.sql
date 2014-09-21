CREATE PROCEDURE [dbo].[DeleteDepartmentLanguages]
    @DepartmentLanguagesId int

AS
Begin
 Delete [HumanResources].[DepartmentLanguages] where     [DepartmentLanguagesId] = @DepartmentLanguagesId
End
