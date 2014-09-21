CREATE PROCEDURE [dbo].[GetByIDMenuEntityItemLanguage]
    @MenuEntityItemId int

AS
BEGIN
Select MenuEntityItemId, Name, LanguageID, ParentId
From [ContentManagement].[MenuEntityItemLanguage]

WHERE [MenuEntityItemId] = @MenuEntityItemId
END

