CREATE PROCEDURE [dbo].[UpdateResearchChairLanguages]
    @OldResearchChairLanguagesId int,
    @ResearchChairId int,
    @LanguageId int,
    @Name nvarchar(50),
    @Description nvarchar(250)
AS
UPDATE [Organization].[ResearchChairLanguages]
SET
    ResearchChairId = @ResearchChairId,
    LanguageId = @LanguageId,
    Name = @Name,
    Description = @Description
WHERE [ResearchChairLanguagesId] = @OLDResearchChairLanguagesId
IF @@ROWCOUNT > 0
Select * From Organization.ResearchChairLanguages 
Where [ResearchChairLanguagesId] = @OLDResearchChairLanguagesId
