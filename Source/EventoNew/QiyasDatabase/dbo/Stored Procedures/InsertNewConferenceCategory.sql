CREATE PROCEDURE [dbo].[InsertNewConferenceCategory]
    @ConferenceCategoryId int output ,
    @CategoryName nvarchar(50),
    @ConferenceId int
AS
INSERT INTO [Conference].[ConferenceCategory] (
    [CategoryName],
    [ConferenceId])
Values (
    @CategoryName,
    @ConferenceId)
Set @ConferenceCategoryId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceCategory
Where [ConferenceCategoryId] = @@identity
