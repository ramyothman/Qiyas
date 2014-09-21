CREATE PROCEDURE [dbo].[GetByIDMasterPageTemplate]
    @MasterPageTemplateId int

AS
BEGIN
Select MasterPageTemplateId, Name, Path, ClassName, MasterPageContent
From [ContentManagement].[MasterPageTemplate]

WHERE [MasterPageTemplateId] = @MasterPageTemplateId
END
