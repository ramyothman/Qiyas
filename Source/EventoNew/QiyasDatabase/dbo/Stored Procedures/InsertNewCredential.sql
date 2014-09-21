CREATE PROCEDURE [dbo].[InsertNewCredential]
    @BusinessEntityId int,
    @Username nvarchar(60),
    @PasswordHash nvarchar(128),
    @PasswordSalt nvarchar(10),
    @ActivationCode nvarchar(128),
    @IsActivated bit,
    @IsActive bit,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [Person].[Credential] (
    [BusinessEntityId],
    [Username],
    [PasswordHash],
    [PasswordSalt],
    [ActivationCode],
    [IsActivated],
    [IsActive],
    [RowGuid],
    [ModifiedDate])
Values (
    @BusinessEntityId,
    @Username,
    @PasswordHash,
    @PasswordSalt,
    @ActivationCode,
    @IsActivated,
    @IsActive,
    @RowGuid,
    @ModifiedDate)

IF @@ROWCOUNT > 0
Select * from Person.Credential
Where [BusinessEntityId] = @BusinessEntityId
