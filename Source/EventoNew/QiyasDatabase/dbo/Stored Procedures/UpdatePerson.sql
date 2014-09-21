CREATE PROCEDURE [dbo].[UpdatePerson]
    @BusinessEntityId int,
    @OldBusinessEntityId int,
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
UPDATE [Person].[Person]
SET
    BusinessEntityId = @BusinessEntityId,
    NameStyle = @NameStyle,
    EmailPromotion = @EmailPromotion,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate,
    CreatedDate = @CreatedDate,
    NationalityCode = @NationalityCode,
    Gender = @Gender,
    DateofBirth = @DateOfBirth,
    PersonImage = @PersonImage
WHERE [BusinessEntityId] = @OLDBusinessEntityId
IF @@ROWCOUNT > 0
Select * From Person.Person 
Where [BusinessEntityId] = @BusinessEntityId
