create PROCEDURE [dbo].[GetByLanguageIDLookupLanguages]
    @LanguageId int,
    @LookupName nvarchar(50)

AS
BEGIN
Select LookupLanguageId, LookupId, LanguageId, RefId, LookupValue, LookupValueDescription
From dbo.ViewLookups
WHERE [LanguageId] = @LanguageId and LookupName = @LookupName
END
