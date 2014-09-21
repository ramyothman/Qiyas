CREATE PROCEDURE [dbo].[InsertNewPageStatus]
    @PageStatusId int output ,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [ContentManagement].[PageStatus] (
    [Name],
    [RowGuid],
    [ModifiedDate])
Values (
    @Name,
    @RowGuid,
    @ModifiedDate)
Set @PageStatusId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.PageStatus
Where [PageStatusId] = @@identity
