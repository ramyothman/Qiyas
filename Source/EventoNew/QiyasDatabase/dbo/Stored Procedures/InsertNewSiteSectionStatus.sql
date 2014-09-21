CREATE PROCEDURE [dbo].[InsertNewSiteSectionStatus]
    @SiteSectionStatusId int output ,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [ContentManagement].[SiteSectionStatus] (
    [Name],
    [RowGuid],
    [ModifiedDate])
Values (
    @Name,
    @RowGuid,
    @ModifiedDate)
Set @SiteSectionStatusId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.SiteSectionStatus
Where [SiteSectionStatusId] = @@identity
