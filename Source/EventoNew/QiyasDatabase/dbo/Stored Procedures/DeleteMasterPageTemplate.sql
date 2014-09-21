CREATE PROCEDURE [dbo].[DeleteMasterPageTemplate]
    @MasterPageTemplateId int

AS
Begin
 Delete [ContentManagement].[MasterPageTemplate] where     [MasterPageTemplateId] = @MasterPageTemplateId
End
