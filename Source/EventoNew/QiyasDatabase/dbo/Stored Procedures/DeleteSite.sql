CREATE PROCEDURE [dbo].[DeleteSite]
    @SiteId int

AS
Begin
 Delete [ContentManagement].[Site] where     [SiteId] = @SiteId
End
