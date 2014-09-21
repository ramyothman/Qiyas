CREATE PROCEDURE [dbo].[GetByIDSiteSectionStatus]
    @SiteSectionStatusId int

AS
BEGIN
Select SiteSectionStatusId, Name, RowGuid, ModifiedDate
From [ContentManagement].[SiteSectionStatus]

WHERE [SiteSectionStatusId] = @SiteSectionStatusId
END
