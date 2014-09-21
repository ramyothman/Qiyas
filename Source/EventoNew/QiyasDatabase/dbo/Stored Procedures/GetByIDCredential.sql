CREATE PROCEDURE [dbo].[GetByIDCredential]
    @BusinessEntityId int

AS
BEGIN
Select BusinessEntityId, Username, PasswordHash, PasswordSalt, ActivationCode, IsActivated, IsActive, RowGuid, ModifiedDate
From [Person].[Credential]

WHERE [BusinessEntityId] = @BusinessEntityId
END
