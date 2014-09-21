CREATE PROCEDURE [dbo].[InsertNewSite]
    @SiteId int,
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
INSERT INTO [ContentManagement].[Site] (
    [SiteId],
    [Name],
    [IsActive],
    [TimeFormat],
    [DateFormat],
    [PostSize],
    [DefaultSectionId],
    [DefaultCommentStatusId],
    [DefaultSecurityAccessTypeId],
    [HomeNewsCount],
    [HomeEventsCount],
    [MasterPageTemplateId],
    [ShowFullTextArticles],
    [AllowPostingComments],
    [AllowAnonymousComments],
    [RowGuid],
    [ModifiedDate])
Values (
    @SiteId,
    @Name,
    @IsActive,
    @TimeFormat,
    @DateFormat,
    @PostSize,
    @DefaultSectionId,
    @DefaultCommentStatusId,
    @DefaultSecurityAccessTypeId,
    @HomeNewsCount,
    @HomeEventsCount,
    @MasterPageTemplateId,
    @ShowFullTextArticles,
    @AllowPostingComments,
    @AllowAnonymousComments,
    @RowGuid,
    @ModifiedDate)

IF @@ROWCOUNT > 0
Select * from ContentManagement.Site
Where [SiteId] = @SiteId
