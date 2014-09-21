CREATE PROCEDURE [dbo].[InsertNewConferenceMediaReference]
    @ConferenceMediaReferenceId int output ,
    @ConferenceId int,
    @LanguageId int,
    @ReferenceOrder int,
    @Title nvarchar(250),
    @ReferenceUrl nvarchar(250),
    @ReferenceName nvarchar(150),
    @ReferenceLogo nvarchar(250),
    @PublishingDate datetime
AS
INSERT INTO [Conference].[ConferenceMediaReference] (
    [ConferenceId],
    [LanguageId],
    [ReferenceOrder],
    [Title],
    [ReferenceUrl],
    [ReferenceName],
    [ReferenceLogo],
    [PublishingDate])
Values (
    @ConferenceId,
    @LanguageId,
    @ReferenceOrder,
    @Title,
    @ReferenceUrl,
    @ReferenceName,
    @ReferenceLogo,
    @PublishingDate)
Set @ConferenceMediaReferenceId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceMediaReference
Where [ConferenceMediaReferenceId] = @@identity
