CREATE PROCEDURE [dbo].[DeletePersonPhone]
    @Id int

AS
Begin
 Delete [Person].[PersonPhone] where     [Id] = @Id
End
