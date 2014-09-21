CREATE PROCEDURE [dbo].[InsertNewSectionFiles]
    @SectionFileId int,
    @SectionFileName nvarchar(250),
    @SectionFilePath nvarchar(250),
    @SectionId int,
    @SecurityAccessTypeId int
AS
INSERT INTO [ContentManagement].[SectionFiles] (
    [SectionFileId],
    [SectionFileName],
    [SectionFilePath],
    [SectionId],
    [SecurityAccessTypeId])
Values (
    @SectionFileId,
    @SectionFileName,
    @SectionFilePath,
    @SectionId,
    @SecurityAccessTypeId)

IF @@ROWCOUNT > 0
Select * from ContentManagement.SectionFiles
Where [SectionFileId] = @SectionFileId
