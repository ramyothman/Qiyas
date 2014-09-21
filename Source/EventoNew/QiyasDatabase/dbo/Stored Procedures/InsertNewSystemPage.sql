CREATE PROCEDURE [dbo].[InsertNewSystemPage]
    @SystemPageId int,
    @Name nvarchar(50),
    @Path nvarchar(150),
    @SecurityAccessTypeId int,
    @IsActive bit,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime,
    @SystemFolderId int
AS
INSERT INTO [ContentManagement].[SystemPage] (
    [SystemPageId],
    [Name],
    [Path],
    [SecurityAccessTypeId],
    [IsActive],
    [RowGuid],
    [ModifiedDate],
    [SystemFolderId])
Values (
    @SystemPageId,
    @Name,
    @Path,
    @SecurityAccessTypeId,
    @IsActive,
    @RowGuid,
    @ModifiedDate,
    @SystemFolderId)

IF @@ROWCOUNT > 0
Select * from ContentManagement.SystemPage
Where [SystemPageId] = @SystemPageId
