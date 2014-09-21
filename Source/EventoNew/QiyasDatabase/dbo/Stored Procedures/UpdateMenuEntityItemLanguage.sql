CREATE PROCEDURE [dbo].[UpdateMenuEntityItemLanguage]
    @OldMenuEntityItemId int,
    @Name nvarchar(50),
    @LanguageID int,
    @ParentId int
AS
UPDATE [ContentManagement].[MenuEntityItemLanguage]
SET
    Name = @Name,
    LanguageID = @LanguageID,
    ParentId = @ParentId
WHERE [MenuEntityItemId] = @OLDMenuEntityItemId
IF @@ROWCOUNT > 0
Select * From ContentManagement.MenuEntityItemLanguage 
Where [MenuEntityItemId] = @OLDMenuEntityItemId

