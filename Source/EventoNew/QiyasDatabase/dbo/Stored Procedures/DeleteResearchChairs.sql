CREATE PROCEDURE [dbo].[DeleteResearchChairs]
    @ResearchChairId int

AS
Begin
 Delete [Organization].[ResearchChairs] where     [ResearchChairId] = @ResearchChairId
End
