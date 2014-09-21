CREATE PROCEDURE [dbo].[UpdateWardRoomType]
    @OldWardRoomTypeId int,
    @WardRoomTypeName nvarchar(150)
AS
UPDATE [BedManagement].[WardRoomType]
SET
    WardRoomTypeName = @WardRoomTypeName
WHERE [WardRoomTypeId] = @OLDWardRoomTypeId
IF @@ROWCOUNT > 0
Select * From BedManagement.WardRoomType 
Where [WardRoomTypeId] = @OLDWardRoomTypeId
