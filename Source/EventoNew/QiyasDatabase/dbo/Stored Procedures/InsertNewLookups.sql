CREATE PROCEDURE [dbo].[InsertNewLookups]
    @LookupId int output ,
    @LookupName nvarchar(50),
    @LookupFriendlyName nvarchar(50)
AS
INSERT INTO [ContentManagement].[Lookups] (
    [LookupName],
    [LookupFriendlyName])
Values (
    @LookupName,
    @LookupFriendlyName)
Set @LookupId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.Lookups
Where [LookupId] = @@identity
