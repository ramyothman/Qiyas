CREATE PROCEDURE [dbo].[UpdateResearchChairs]
    @OldResearchChairId int,
    @Name nvarchar(50),
    @Description nvarchar(250),
    @Phone1 nvarchar(20),
    @Phone2 nvarchar(20),
    @Fax1 nvarchar(20),
    @Fax2 nvarchar(20)
AS
UPDATE [Organization].[ResearchChairs]
SET
    Name = @Name,
    Description = @Description,
    Phone1 = @Phone1,
    Phone2 = @Phone2,
    Fax1 = @Fax1,
    Fax2 = @Fax2
WHERE [ResearchChairId] = @OLDResearchChairId
IF @@ROWCOUNT > 0
Select * From Organization.ResearchChairs 
Where [ResearchChairId] = @OLDResearchChairId
