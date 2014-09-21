CREATE PROCEDURE [dbo].[InsertNewWard]
    @WardId int output ,
    @WardCode nvarchar(8),
    @WardDescription nvarchar(50),
    @BedsNumber int,
    @WardCapacity int,
    @RoomsNumber int,
    @WardType nvarchar(1),
    @WardPhone nvarchar(14),
    @WardColor nvarchar(10),
    @WardOrder int
AS
INSERT INTO [BedManagement].[Ward] (
    [WardCode],
    [WardDescription],
    [BedsNumber],
    [WardCapacity],
    [RoomsNumber],
    [WardType],
    [WardPhone],
    [WardColor],
    [WardOrder])
Values (
    @WardCode,
    @WardDescription,
    @BedsNumber,
    @WardCapacity,
    @RoomsNumber,
    @WardType,
    @WardPhone,
    @WardColor,
    @WardOrder)
Set @WardId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from BedManagement.Ward
Where [WardId] = @@identity
