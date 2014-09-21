CREATE PROCEDURE [dbo].[GetByIDSite]
    @SiteId int

AS
BEGIN
Select SiteId, Name, IsActive, TimeFormat, DateFormat, PostSize, DefaultSectionId, DefaultCommentStatusId, DefaultSecurityAccessTypeId, HomeNewsCount, HomeEventsCount, MasterPageTemplateId, ShowFullTextArticles, AllowPostingComments, AllowAnonymousComments, RowGuid, ModifiedDate
From [ContentManagement].[Site]

WHERE [SiteId] = @SiteId
END
