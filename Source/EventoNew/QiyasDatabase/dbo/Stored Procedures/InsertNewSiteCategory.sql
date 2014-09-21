CREATE PROCEDURE [dbo].[InsertNewSiteCategory]
    @SiteCategoryId int output ,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [ContentManagement].[SiteCategory] (
    [Name],
    [RowGuid],
    [ModifiedDate])
Values (
    @Name,
    @RowGuid,
    @ModifiedDate)
Set @SiteCategoryId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.SiteCategory
Where [SiteCategoryId] = @@identity
