CREATE PROCEDURE [dbo].[GetByIDResearchChairs]
    @ResearchChairId int

AS
BEGIN
Select ResearchChairId, Name, Description, Phone1, Phone2, Fax1, Fax2
From [Organization].[ResearchChairs]

WHERE [ResearchChairId] = @ResearchChairId
END
