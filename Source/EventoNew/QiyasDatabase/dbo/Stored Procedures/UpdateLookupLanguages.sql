CREATE PROCEDURE [dbo].[UpdateLookupLanguages]
    @OldLookupLanguageId int,
    @LookupId int,
    @LanguageId int,
    @RefId int,
    @LookupValue nvarchar(50),
    @LookupValueDescription nvarchar(50)
AS
UPDATE [ContentManagement].[LookupLanguages]
SET
    LookupId = @LookupId,
    LanguageId = @LanguageId,
    RefId = @RefId,
    LookupValue = @LookupValue,
    LookupValueDescription = @LookupValueDescription
WHERE [LookupLanguageId] = @OLDLookupLanguageId
IF @@ROWCOUNT > 0
Select * From ContentManagement.LookupLanguages 
Where [LookupLanguageId] = @OLDLookupLanguageId
