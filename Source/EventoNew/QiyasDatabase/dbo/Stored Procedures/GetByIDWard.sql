CREATE PROCEDURE [dbo].[GetByIDWard]
    @WardId int

AS
BEGIN
Select WardId, WardCode, WardDescription, BedsNumber, WardCapacity, RoomsNumber, WardType, WardPhone, WardColor, WardOrder
From [BedManagement].[Ward]

WHERE [WardId] = @WardId
END
