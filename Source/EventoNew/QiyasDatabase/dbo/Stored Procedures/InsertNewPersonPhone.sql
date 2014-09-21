CREATE PROCEDURE [dbo].[InsertNewPersonPhone]
    @Id int output ,
    @BusinessEntityId int,
    @PhoneNumber nvarchar(25),
    @PhoneNumberTypeId int,
    @ModifiedDate datetime,
    @PhoneVerified bit,
    @PhoneVerificationCode nvarchar(50)
AS
INSERT INTO [Person].[PersonPhone] (
    [BusinessEntityId],
    [PhoneNumber],
    [PhoneNumberTypeId],
    [ModifiedDate],
    [PhoneVerified],
    [PhoneVerificationCode])
Values (
    @BusinessEntityId,
    @PhoneNumber,
    @PhoneNumberTypeId,
    @ModifiedDate,
    @PhoneVerified,
    @PhoneVerificationCode)
Set @Id = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Person.PersonPhone
Where [Id] = @@identity
