CREATE PROCEDURE [dbo].[GetByIDContactType]
    @ContactTypeId int

AS
BEGIN
Select ContactTypeId, Name, ModifiedDate
From [Person].[ContactType]

WHERE [ContactTypeId] = @ContactTypeId
END
