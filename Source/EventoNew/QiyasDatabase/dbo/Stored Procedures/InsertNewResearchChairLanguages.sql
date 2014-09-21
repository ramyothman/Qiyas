CREATE PROCEDURE [dbo].[InsertNewResearchChairLanguages]
    @ResearchChairLanguagesId int output ,
    @ResearchChairId int,
    @LanguageId int,
    @Name nvarchar(50),
    @Description nvarchar(250)
AS
INSERT INTO [Organization].[ResearchChairLanguages] (
    [ResearchChairId],
    [LanguageId],
    [Name],
    [Description])
Values (
    @ResearchChairId,
    @LanguageId,
    @Name,
    @Description)
Set @ResearchChairLanguagesId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Organization.ResearchChairLanguages
Where [ResearchChairLanguagesId] = @@identity
