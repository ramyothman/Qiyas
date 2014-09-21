CREATE PROCEDURE [dbo].[UpdateLookups]
    @OldLookupId int,
    @LookupName nvarchar(50),
    @LookupFriendlyName nvarchar(50)
AS
UPDATE [ContentManagement].[Lookups]
SET
    LookupName = @LookupName,
    LookupFriendlyName = @LookupFriendlyName
WHERE [LookupId] = @OLDLookupId
IF @@ROWCOUNT > 0
Select * From ContentManagement.Lookups 
Where [LookupId] = @OLDLookupId
