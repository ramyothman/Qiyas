
CREATE PROCEDURE [dbo].[DeleteEmailTemplate]
    @EmailTemplateID int

AS
Begin
 Delete [Conference].[EmailTemplate] where     [EmailTemplateID] = @EmailTemplateID
End
