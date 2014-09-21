CREATE PROCEDURE [dbo].[DeleteSectionFiles]
    @SectionFileId int

AS
Begin
 Delete [ContentManagement].[SectionFiles] where     [SectionFileId] = @SectionFileId
End
