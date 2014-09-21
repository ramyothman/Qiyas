CREATE PROCEDURE [dbo].[UpdateSitePage]
    @SitePageId int,
    @OldSitePageId int,
    @SectionId int,
    @PageStatusId int,
    @SecurityAccessTypeId int,
    @CreatorId int,
    @UniquePageName nvarchar(50),
    @IsMainPage bit,
    @RowGuid uniqueidentifier,
    @RevisionDate datetime,
    @ModifiedDate datetime
AS
UPDATE [ContentManagement].[SitePage]
SET
    SitePageId = @SitePageId,
    SectionId = @SectionId,
    PageStatusId = @PageStatusId,
    SecurityAccessTypeId = @SecurityAccessTypeId,
    CreatorId = @CreatorId,
    UniquePageName = @UniquePageName,
    IsMainPage = @IsMainPage,
    RowGuid = @RowGuid,
    RevisionDate = @RevisionDate,
    ModifiedDate = @ModifiedDate
WHERE [SitePageId] = @OLDSitePageId
IF @@ROWCOUNT > 0
Select * From ContentManagement.SitePage 
Where [SitePageId] = @SitePageId
