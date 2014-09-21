CREATE PROCEDURE [dbo].[DeleteDivisions]
    @DivisionId int

AS
Begin
 Delete [HumanResources].[Divisions] where     [DivisionId] = @DivisionId
End
