CREATE PROCEDURE [dbo].[DeleteLookupLanguages]
    @LookupLanguageId int

AS
Begin
 Delete [ContentManagement].[LookupLanguages] where     [LookupLanguageId] = @LookupLanguageId
End
