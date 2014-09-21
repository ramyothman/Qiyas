CREATE PROCEDURE [dbo].[InsertNewContactType]
    @ContactTypeId int,
    @Name nvarchar(50),
    @ModifiedDate datetime
AS
INSERT INTO [Person].[ContactType] (
    [ContactTypeId],
    [Name],
    [ModifiedDate])
Values (
    @ContactTypeId,
    @Name,
    @ModifiedDate)

IF @@ROWCOUNT > 0
Select * from Person.ContactType
Where [ContactTypeId] = @ContactTypeId
