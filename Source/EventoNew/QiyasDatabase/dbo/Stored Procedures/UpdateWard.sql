CREATE PROCEDURE [dbo].[UpdateWard]
    @OldWardId int,
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
UPDATE [BedManagement].[Ward]
SET
    WardCode = @WardCode,
    WardDescription = @WardDescription,
    BedsNumber = @BedsNumber,
    WardCapacity = @WardCapacity,
    RoomsNumber = @RoomsNumber,
    WardType = @WardType,
    WardPhone = @WardPhone,
    WardColor = @WardColor,
    WardOrder = @WardOrder
WHERE [WardId] = @OLDWardId
IF @@ROWCOUNT > 0
Select * From BedManagement.Ward 
Where [WardId] = @OLDWardId
