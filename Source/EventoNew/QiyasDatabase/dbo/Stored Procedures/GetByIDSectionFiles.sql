CREATE PROCEDURE [dbo].[GetByIDSectionFiles]
    @SectionFileId int

AS
BEGIN
Select SectionFileId, SectionFileName, SectionFilePath, SectionId, SecurityAccessTypeId
From [ContentManagement].[SectionFiles]

WHERE [SectionFileId] = @SectionFileId
END
