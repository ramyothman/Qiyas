CREATE PROCEDURE [dbo].[GetByIDSiteSection]
    @SiteSectionId int

AS
BEGIN
Select SiteSectionId, Name, SiteSectionParentId, SectionStatusId, SiteId, PersonId, SecurityAccessTypeId, RowGuid, ModifiedDate
From [ContentManagement].[SiteSection]

WHERE [SiteSectionId] = @SiteSectionId
END
