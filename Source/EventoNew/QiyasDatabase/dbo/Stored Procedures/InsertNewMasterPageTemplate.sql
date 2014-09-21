CREATE PROCEDURE [dbo].[InsertNewMasterPageTemplate]
    @MasterPageTemplateId int output ,
    @Name nvarchar(50),
    @Path nvarchar(255),
    @ClassName nvarchar(50),
    @MasterPageContent nvarchar(50)
AS
INSERT INTO [ContentManagement].[MasterPageTemplate] (
    [Name],
    [Path],
    [ClassName],
    [MasterPageContent])
Values (
    @Name,
    @Path,
    @ClassName,
    @MasterPageContent)
Set @MasterPageTemplateId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.MasterPageTemplate
Where [MasterPageTemplateId] = @@identity
