CREATE PROCEDURE [dbo].[InsertNewEmailAddress]
    @EmailAddressId int output ,
    @BusinessEntityId int,
    @EmailAddressTypeId int,
    @Email nvarchar(60),
    @EmailVerified bit,
    @EmailVerificationHash nvarchar(128),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [Person].[EmailAddress] (
    [BusinessEntityId],
    [EmailAddressTypeId],
    [Email],
    [EmailVerified],
    [EmailVerificationHash],
    [RowGuid],
    [ModifiedDate])
Values (
    @BusinessEntityId,
    @EmailAddressTypeId,
    @Email,
    @EmailVerified,
    @EmailVerificationHash,
    @RowGuid,
    @ModifiedDate)
Set @EmailAddressId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Person.EmailAddress
Where [EmailAddressId] = @@identity
