CREATE PROCEDURE [dbo].[UpdateSite]
    @SiteId int,
    @OldSiteId int,
    @Name nvarchar(50),
    @IsActive bit,
    @TimeFormat nvarchar(20),
    @DateFormat nvarchar(20),
    @PostSize int,
    @DefaultSectionId int,
    @DefaultCommentStatusId int,
    @DefaultSecurityAccessTypeId int,
    @HomeNewsCount int,
    @HomeEventsCount int,
    @MasterPageTemplateId int,
    @ShowFullTextArticles bit,
    @AllowPostingComments bit,
    @AllowAnonymousComments bit,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [ContentManagement].[Site]
SET
    SiteId = @SiteId,
    Name = @Name,
    IsActive = @IsActive,
    TimeFormat = @TimeFormat,
    DateFormat = @DateFormat,
    PostSize = @PostSize,
    DefaultSectionId = @DefaultSectionId,
    DefaultCommentStatusId = @DefaultCommentStatusId,
    DefaultSecurityAccessTypeId = @DefaultSecurityAccessTypeId,
    HomeNewsCount = @HomeNewsCount,
    HomeEventsCount = @HomeEventsCount,
    MasterPageTemplateId = @MasterPageTemplateId,
    ShowFullTextArticles = @ShowFullTextArticles,
    AllowPostingComments = @AllowPostingComments,
    AllowAnonymousComments = @AllowAnonymousComments,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [SiteId] = @OLDSiteId
IF @@ROWCOUNT > 0
Select * From ContentManagement.Site 
Where [SiteId] = @SiteId
