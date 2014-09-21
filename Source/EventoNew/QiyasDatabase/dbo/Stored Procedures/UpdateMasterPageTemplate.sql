CREATE PROCEDURE [dbo].[UpdateMasterPageTemplate]
    @OldMasterPageTemplateId int,
    @Name nvarchar(50),
    @Path nvarchar(255),
    @ClassName nvarchar(50),
    @MasterPageContent nvarchar(50)
AS
UPDATE [ContentManagement].[MasterPageTemplate]
SET
    Name = @Name,
    Path = @Path,
    ClassName = @ClassName,
    MasterPageContent = @MasterPageContent
WHERE [MasterPageTemplateId] = @OLDMasterPageTemplateId
IF @@ROWCOUNT > 0
Select * From ContentManagement.MasterPageTemplate 
Where [MasterPageTemplateId] = @OLDMasterPageTemplateId
