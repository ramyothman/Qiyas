CREATE PROCEDURE [dbo].[InsertNewResearchChairs]
    @ResearchChairId int output ,
    @Name nvarchar(50),
    @Description nvarchar(250),
    @Phone1 nvarchar(20),
    @Phone2 nvarchar(20),
    @Fax1 nvarchar(20),
    @Fax2 nvarchar(20)
AS
INSERT INTO [Organization].[ResearchChairs] (
    [Name],
    [Description],
    [Phone1],
    [Phone2],
    [Fax1],
    [Fax2])
Values (
    @Name,
    @Description,
    @Phone1,
    @Phone2,
    @Fax1,
    @Fax2)
Set @ResearchChairId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Organization.ResearchChairs
Where [ResearchChairId] = @@identity
