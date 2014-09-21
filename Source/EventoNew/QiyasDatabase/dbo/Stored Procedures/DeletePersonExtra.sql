CREATE PROCEDURE [dbo].[DeletePersonExtra]
    @PersonExtraId int

AS
Begin
 Delete [Person].[PersonExtra] where     [PersonExtraId] = @PersonExtraId
End
