CREATE PROCEDURE [dbo].[InsertNewLanguage]
    @LanguageId int output ,
    @LanguageCode nvarchar(5),
    @Name nvarchar(50)
AS
INSERT INTO [ContentManagement].[Language] (
    [LanguageCode],
    [Name])
Values (
    @LanguageCode,
    @Name)
Set @LanguageId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.Language
Where [LanguageId] = @@identity
