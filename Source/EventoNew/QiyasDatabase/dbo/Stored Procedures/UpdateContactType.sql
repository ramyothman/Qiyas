CREATE PROCEDURE [dbo].[UpdateContactType]
    @ContactTypeId int,
    @OldContactTypeId int,
    @Name nvarchar(50),
    @ModifiedDate datetime
AS
UPDATE [Person].[ContactType]
SET
    ContactTypeId = @ContactTypeId,
    Name = @Name,
    ModifiedDate = @ModifiedDate
WHERE [ContactTypeId] = @OLDContactTypeId
IF @@ROWCOUNT > 0
Select * From Person.ContactType 
Where [ContactTypeId] = @ContactTypeId
