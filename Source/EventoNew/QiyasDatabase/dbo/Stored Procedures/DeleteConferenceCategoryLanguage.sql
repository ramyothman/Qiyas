CREATE PROCEDURE [dbo].[DeleteConferenceCategoryLanguage]
    @ConferenceCategoryId int

AS
Begin
 Delete [Conference].[ConferenceCategoryLanguage] where     [ConferenceCategoryId] = @ConferenceCategoryId
End
