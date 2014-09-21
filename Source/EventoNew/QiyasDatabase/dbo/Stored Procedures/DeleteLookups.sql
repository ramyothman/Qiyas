CREATE PROCEDURE [dbo].[DeleteLookups]
    @LookupId int

AS
Begin
 Delete [ContentManagement].[Lookups] where     [LookupId] = @LookupId
End
