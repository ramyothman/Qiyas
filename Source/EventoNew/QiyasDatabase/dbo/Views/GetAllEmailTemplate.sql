CREATE VIEW [dbo].[GetAllEmailTemplate]
AS
SELECT     EmailTemplateID, SystemEmailTypeID, ConferenceID, LanguageID, Name, Description, EmailContent
FROM         Conference.EmailTemplate
