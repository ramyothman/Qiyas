CREATE PROCEDURE [dbo].[UpdateSiteSection]
    @SiteSectionId int,
    @OldSiteSectionId int,
    @Name nvarchar(50),
    @SiteSectionParentId int,
    @SectionStatusId int,
    @SiteId int,
    @PersonId int,
    @SecurityAccessTypeId int,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [ContentManagement].[SiteSection]
SET
    SiteSectionId = @SiteSectionId,
    Name = @Name,
    SiteSectionParentId = @SiteSectionParentId,
    SectionStatusId = @SectionStatusId,
    SiteId = @SiteId,
    PersonId = @PersonId,
    SecurityAccessTypeId = @SecurityAccessTypeId,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [SiteSectionId] = @OLDSiteSectionId
IF @@ROWCOUNT > 0
Select * From ContentManagement.SiteSection 
Where [SiteSectionId] = @SiteSectionId
