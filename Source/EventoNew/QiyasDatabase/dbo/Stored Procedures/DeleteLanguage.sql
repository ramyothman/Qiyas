CREATE PROCEDURE [dbo].[DeleteLanguage]
    @LanguageId int

AS
Begin
 Delete [ContentManagement].[Language] where     [LanguageId] = @LanguageId
End
