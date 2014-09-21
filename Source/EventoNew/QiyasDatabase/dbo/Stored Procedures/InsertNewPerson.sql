CREATE PROCEDURE [dbo].[InsertNewPerson]
    @BusinessEntityId int,
    @NameStyle bit,
    @EmailPromotion int,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime,
    @CreatedDate datetime,
    @NationalityCode char(3),
    @Gender char(1),
    @DateOfBirth datetime,
    @PersonImage nvarchar(250)
AS
INSERT INTO [Person].[Person] (
    [BusinessEntityId],
    [NameStyle],
    [EmailPromotion],
    [RowGuid],
    [ModifiedDate],
    [CreatedDate],
    [NationalityCode],
    Gender,
    DateOfBirth,
    PersonImage)
Values (
    @BusinessEntityId,
    @NameStyle,
    @EmailPromotion,
    @RowGuid,
    @ModifiedDate,
    @CreatedDate,
    @NationalityCode,
    @Gender,
    @DateOfBirth,
    @PersonImage)

IF @@ROWCOUNT > 0
Select * from Person.Person
Where [BusinessEntityId] = @BusinessEntityId
