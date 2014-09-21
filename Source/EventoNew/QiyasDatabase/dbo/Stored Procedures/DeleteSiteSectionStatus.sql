CREATE PROCEDURE [dbo].[DeleteSiteSectionStatus]
    @SiteSectionStatusId int

AS
Begin
 Delete [ContentManagement].[SiteSectionStatus] where     [SiteSectionStatusId] = @SiteSectionStatusId
End
