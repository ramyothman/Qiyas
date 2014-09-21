CREATE PROCEDURE [dbo].[InsertNewMenuEntityItemLanguage]
    @MenuEntityItemId int output ,
    @Name nvarchar(50),
    @LanguageID int,
    @ParentId int
AS
INSERT INTO [ContentManagement].[MenuEntityItemLanguage] (
    [Name],
    [LanguageID],
    [ParentId])
Values (
    @Name,
    @LanguageID,
    @ParentId)
Set @MenuEntityItemId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.MenuEntityItemLanguage
Where [MenuEntityItemId] = @@identity


