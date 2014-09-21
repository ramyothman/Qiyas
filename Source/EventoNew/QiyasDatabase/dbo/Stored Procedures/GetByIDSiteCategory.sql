CREATE PROCEDURE [dbo].[GetByIDSiteCategory]
    @SiteCategoryId int

AS
BEGIN
Select SiteCategoryId, Name, RowGuid, ModifiedDate
From [ContentManagement].[SiteCategory]

WHERE [SiteCategoryId] = @SiteCategoryId
END
