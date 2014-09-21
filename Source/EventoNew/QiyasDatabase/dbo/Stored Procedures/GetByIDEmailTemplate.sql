
CREATE PROCEDURE [dbo].[GetByIDEmailTemplate]
    @EmailTemplateID int

AS
BEGIN
Select EmailTemplateID, SystemEmailTypeID, ConferenceID, LanguageID, Name, Description, EmailContent
From [Conference].[EmailTemplate]

WHERE [EmailTemplateID] = @EmailTemplateID
END
