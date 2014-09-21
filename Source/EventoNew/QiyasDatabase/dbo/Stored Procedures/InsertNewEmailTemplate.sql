
CREATE PROCEDURE [dbo].[InsertNewEmailTemplate]
    @EmailTemplateID int output ,
    @SystemEmailTypeID int,
    @ConferenceID int,
    @LanguageID int,
    @Name nvarchar(50),
    @Description nchar(10),
    @EmailContent ntext
AS
INSERT INTO [Conference].[EmailTemplate] (
    [SystemEmailTypeID],
    [ConferenceID],
    [LanguageID],
    [Name],
    [Description],
    [EmailContent])
Values (
    @SystemEmailTypeID,
    @ConferenceID,
    @LanguageID,
    @Name,
    @Description,
    @EmailContent)
Set @EmailTemplateID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.EmailTemplate
Where [EmailTemplateID] = @@identity
