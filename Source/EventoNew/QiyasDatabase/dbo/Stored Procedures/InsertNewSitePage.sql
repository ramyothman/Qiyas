CREATE PROCEDURE [dbo].[InsertNewSitePage]
    @SitePageId int,
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
INSERT INTO [ContentManagement].[SitePage] (
    [SitePageId],
    [SectionId],
    [PageStatusId],
    [SecurityAccessTypeId],
    [CreatorId],
    [UniquePageName],
    [IsMainPage],
    [RowGuid],
    [RevisionDate],
    [ModifiedDate])
Values (
    @SitePageId,
    @SectionId,
    @PageStatusId,
    @SecurityAccessTypeId,
    @CreatorId,
    @UniquePageName,
    @IsMainPage,
    @RowGuid,
    @RevisionDate,
    @ModifiedDate)

IF @@ROWCOUNT > 0
Select * from ContentManagement.SitePage
Where [SitePageId] = @SitePageId
