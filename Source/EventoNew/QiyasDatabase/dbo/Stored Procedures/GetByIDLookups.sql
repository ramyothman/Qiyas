CREATE PROCEDURE [dbo].[GetByIDLookups]
    @LookupId int

AS
BEGIN
Select LookupId, LookupName, LookupFriendlyName
From [ContentManagement].[Lookups]

WHERE [LookupId] = @LookupId
END
