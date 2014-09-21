CREATE PROCEDURE [dbo].[UpdateSectionFiles]
    @SectionFileId int,
    @OldSectionFileId int,
    @SectionFileName nvarchar(250),
    @SectionFilePath nvarchar(250),
    @SectionId int,
    @SecurityAccessTypeId int
AS
UPDATE [ContentManagement].[SectionFiles]
SET
    SectionFileId = @SectionFileId,
    SectionFileName = @SectionFileName,
    SectionFilePath = @SectionFilePath,
    SectionId = @SectionId,
    SecurityAccessTypeId = @SecurityAccessTypeId
WHERE [SectionFileId] = @OLDSectionFileId
IF @@ROWCOUNT > 0
Select * From ContentManagement.SectionFiles 
Where [SectionFileId] = @SectionFileId
