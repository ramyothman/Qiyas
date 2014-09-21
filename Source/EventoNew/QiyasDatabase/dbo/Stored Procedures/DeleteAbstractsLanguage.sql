CREATE PROCEDURE [dbo].[DeleteAbstractsLanguage]
    @AbstractLanguageId int

AS
Begin
 Delete [Conference].[AbstractsLanguage] where     [AbstractLanguageId] = @AbstractLanguageId
End

