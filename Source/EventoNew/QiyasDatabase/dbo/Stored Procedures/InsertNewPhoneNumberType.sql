CREATE PROCEDURE [dbo].[InsertNewPhoneNumberType]
    @PhoneNumberTypeId int output ,
    @Name nvarchar(50),
    @ModifiedDate datetime
AS
INSERT INTO [Person].[PhoneNumberType] (
    [Name],
    [ModifiedDate])
Values (
    @Name,
    @ModifiedDate)
Set @PhoneNumberTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Person.PhoneNumberType
Where [PhoneNumberTypeId] = @@identity
