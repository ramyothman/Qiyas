CREATE VIEW [dbo].[GetAllSitePage]
AS
SELECT     ContentManagement.SitePage.SitePageId, ContentManagement.SitePage.SectionId, ContentManagement.SitePage.PageStatusId, 
                      ContentManagement.SitePage.SecurityAccessTypeId, ContentManagement.SitePage.CreatorId, ContentManagement.SitePage.UniquePageName, 
                      ContentManagement.SitePage.IsMainPage, ContentManagement.SitePage.RowGuid, ContentManagement.SitePage.RevisionDate, 
                      ContentManagement.SitePage.ModifiedDate, ContentManagement.SiteSection.SiteId
FROM         ContentManagement.SitePage INNER JOIN
                      ContentManagement.SiteSection ON ContentManagement.SitePage.SectionId = ContentManagement.SiteSection.SiteSectionId
