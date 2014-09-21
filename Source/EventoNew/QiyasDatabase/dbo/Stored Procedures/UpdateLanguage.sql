CREATE PROCEDURE [dbo].[UpdateLanguage]
    @OldLanguageId int,
    @LanguageCode nvarchar(5),
    @Name nvarchar(50)
AS
UPDATE [ContentManagement].[Language]
SET
    LanguageCode = @LanguageCode,
    Name = @Name
WHERE [LanguageId] = @OLDLanguageId
IF @@ROWCOUNT > 0
Select * From ContentManagement.Language 
Where [LanguageId] = @OLDLanguageId
