CREATE PROCEDURE [dbo].[InsertNewLookupLanguages]
    @LookupLanguageId int output ,
    @LookupId int,
    @LanguageId int,
    @RefId int,
    @LookupValue nvarchar(50),
    @LookupValueDescription nvarchar(50)
AS
INSERT INTO [ContentManagement].[LookupLanguages] (
    [LookupId],
    [LanguageId],
    [RefId],
    [LookupValue],
    [LookupValueDescription])
Values (
    @LookupId,
    @LanguageId,
    @RefId,
    @LookupValue,
    @LookupValueDescription)
Set @LookupLanguageId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.LookupLanguages
Where [LookupLanguageId] = @@identity
