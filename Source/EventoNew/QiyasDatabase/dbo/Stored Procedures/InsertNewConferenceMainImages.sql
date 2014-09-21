
CREATE PROCEDURE [dbo].[InsertNewConferenceMainImages]
    @ConferenceMainImageId int output ,
    @PhotoPath nvarchar(250),
    @ConferenceId int,
    @LanguageId int,
    @PhotoLink nvarchar(250),
    @PhotoTitle nvarchar(50),
    @PhotoDescription nvarchar(150)
AS
INSERT INTO [Conference].[ConferenceMainImages] (
    [PhotoPath],
    [ConferenceId],
    [LanguageId],
    [PhotoLink],
    [PhotoTitle],
    [PhotoDescription])
Values (
    @PhotoPath,
    @ConferenceId,
    @LanguageId,
    @PhotoLink,
    @PhotoTitle,
    @PhotoDescription)
Set @ConferenceMainImageId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceMainImages
Where [ConferenceMainImageId] = @@identity
