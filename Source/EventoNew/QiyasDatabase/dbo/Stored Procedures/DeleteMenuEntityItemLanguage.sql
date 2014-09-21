CREATE PROCEDURE [dbo].[DeleteMenuEntityItemLanguage]
    @MenuEntityItemId int
   

AS
Begin
 Delete [ContentManagement].[MenuEntityItemLanguage] where     [MenuEntityItemId] = @MenuEntityItemId 
   
End

