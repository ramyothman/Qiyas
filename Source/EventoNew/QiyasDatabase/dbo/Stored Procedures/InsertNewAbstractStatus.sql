CREATE PROCEDURE [dbo].[InsertNewAbstractStatus]
    @AbstractStatusId int,
    @Name nvarchar(50),
    @NameAr nvarchar(50)
AS
INSERT INTO [Conference].[AbstractStatus] (
    [AbstractStatusId],
    [Name],
    [NameAr])
Values (
    @AbstractStatusId,
    @Name,
    @NameAr)

IF @@ROWCOUNT > 0
Select * from Conference.AbstractStatus
Where [AbstractStatusId] = @AbstractStatusId


