CREATE PROCEDURE [dbo].[GetByIDDivisions]
    @DivisionId int

AS
BEGIN
Select DivisionId, DepartmentId, DivisionName, DivisionDescription, Phone1, Phone2, Fax1, Fax2
From [HumanResources].[Divisions]

WHERE [DivisionId] = @DivisionId
END
