CREATE PROCEDURE [dbo].[GetByIDSitePage]
    @SitePageId int

AS
BEGIN
Select SitePageId, SectionId, PageStatusId, SecurityAccessTypeId, CreatorId, UniquePageName, IsMainPage, RowGuid, RevisionDate, ModifiedDate,SiteId
From [dbo].[GetAllSitePage] 

WHERE [SitePageId] = @SitePageId
END
