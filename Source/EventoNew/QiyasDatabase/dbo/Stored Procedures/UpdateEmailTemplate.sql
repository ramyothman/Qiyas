
CREATE PROCEDURE [dbo].[UpdateEmailTemplate]
    @OldEmailTemplateID int,
    @SystemEmailTypeID int,
    @ConferenceID int,
    @LanguageID int,
    @Name nvarchar(50),
    @Description nchar(10),
    @EmailContent ntext
AS
UPDATE [Conference].[EmailTemplate]
SET
    SystemEmailTypeID = @SystemEmailTypeID,
    ConferenceID = @ConferenceID,
    LanguageID = @LanguageID,
    Name = @Name,
    Description = @Description,
    EmailContent = @EmailContent
WHERE [EmailTemplateID] = @OLDEmailTemplateID
IF @@ROWCOUNT > 0
Select * From Conference.EmailTemplate 
Where [EmailTemplateID] = @OLDEmailTemplateID
