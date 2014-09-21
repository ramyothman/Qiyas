CREATE PROCEDURE [dbo].[InsertNewMenuEntity]
    @MenuEntityId int output ,
    @MenuName nvarchar(50),
    @ContentEntityId int
AS
INSERT INTO [ContentManagement].[MenuEntity] (
    [MenuName],
    [ContentEntityId])
Values (
    @MenuName,
    @ContentEntityId)
Set @MenuEntityId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.MenuEntity
Where [MenuEntityId] = @@identity
