CREATE PROCEDURE [dbo].[DeleteResearchChairLanguages]
    @ResearchChairLanguagesId int

AS
Begin
 Delete [Organization].[ResearchChairLanguages] where     [ResearchChairLanguagesId] = @ResearchChairLanguagesId
End
