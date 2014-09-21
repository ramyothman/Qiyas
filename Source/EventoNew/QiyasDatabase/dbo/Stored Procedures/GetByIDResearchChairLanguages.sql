CREATE PROCEDURE [dbo].[GetByIDResearchChairLanguages]
    @ResearchChairLanguagesId int

AS
BEGIN
Select ResearchChairLanguagesId, ResearchChairId, LanguageId, Name, Description
From [Organization].[ResearchChairLanguages]

WHERE [ResearchChairLanguagesId] = @ResearchChairLanguagesId
END
