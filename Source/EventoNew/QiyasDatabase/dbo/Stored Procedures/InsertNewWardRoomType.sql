CREATE PROCEDURE [dbo].[InsertNewWardRoomType]
    @WardRoomTypeId int output ,
    @WardRoomTypeName nvarchar(150)
AS
INSERT INTO [BedManagement].[WardRoomType] (
    [WardRoomTypeName])
Values (
    @WardRoomTypeName)
Set @WardRoomTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from BedManagement.WardRoomType
Where [WardRoomTypeId] = @@identity
