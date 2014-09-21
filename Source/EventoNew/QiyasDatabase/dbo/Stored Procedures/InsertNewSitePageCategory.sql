CREATE PROCEDURE [dbo].[InsertNewSitePageCategory]
    @SitePageCategoryId int output ,
    @SiteCategoryId int,
    @SitePageId int,
    @ModifiedDate datetime
AS
INSERT INTO [ContentManagement].[SitePageCategory] (
    [SiteCategoryId],
    [SitePageId],
    [ModifiedDate])
Values (
    @SiteCategoryId,
    @SitePageId,
    @ModifiedDate)
Set @SitePageCategoryId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.SitePageCategory
Where [SitePageCategoryId] = @@identity
