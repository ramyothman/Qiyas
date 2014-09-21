CREATE PROCEDURE [dbo].[InsertNewContentEntity]
    @ContentEntityId int output ,
    @ContentEntityType char(2),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [ContentManagement].[ContentEntity] (
    [ContentEntityType],
    [RowGuid],
    [ModifiedDate])
Values (
    @ContentEntityType,
    @RowGuid,
    @ModifiedDate)
Set @ContentEntityId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.ContentEntity
Where [ContentEntityId] = @@identity
