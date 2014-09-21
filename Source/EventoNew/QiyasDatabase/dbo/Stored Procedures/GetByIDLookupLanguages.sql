CREATE PROCEDURE [dbo].[GetByIDLookupLanguages]
    @LookupLanguageId int

AS
BEGIN
Select LookupLanguageId, LookupId, LanguageId, RefId, LookupValue, LookupValueDescription
From [ContentManagement].[LookupLanguages]

WHERE [LookupLanguageId] = @LookupLanguageId
END
