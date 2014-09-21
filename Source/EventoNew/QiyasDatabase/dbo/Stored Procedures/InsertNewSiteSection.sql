CREATE PROCEDURE [dbo].[InsertNewSiteSection]
    @SiteSectionId int,
    @Name nvarchar(50),
    @SiteSectionParentId int,
    @SectionStatusId int,
    @SiteId int,
    @PersonId int,
    @SecurityAccessTypeId int,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [ContentManagement].[SiteSection] (
    [SiteSectionId],
    [Name],
    [SiteSectionParentId],
    [SectionStatusId],
    [SiteId],
    [PersonId],
    [SecurityAccessTypeId],
    [RowGuid],
    [ModifiedDate])
Values (
    @SiteSectionId,
    @Name,
    @SiteSectionParentId,
    @SectionStatusId,
    @SiteId,
    @PersonId,
    @SecurityAccessTypeId,
    @RowGuid,
    @ModifiedDate)

IF @@ROWCOUNT > 0
Select * from ContentManagement.SiteSection
Where [SiteSectionId] = @SiteSectionId
