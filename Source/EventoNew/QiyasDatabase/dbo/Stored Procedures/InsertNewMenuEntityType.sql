CREATE PROCEDURE [dbo].[InsertNewMenuEntityType]
    @MenuEntityTypeId int output ,
    @Name nvarchar(50)
AS
INSERT INTO [ContentManagement].[MenuEntityType] (
    [Name])
Values (
    @Name)
Set @MenuEntityTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.MenuEntityType
Where [MenuEntityTypeId] = @@identity
