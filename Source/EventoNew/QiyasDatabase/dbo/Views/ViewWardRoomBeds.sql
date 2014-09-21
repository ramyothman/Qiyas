CREATE VIEW [dbo].[ViewWardRoomBeds]
AS
SELECT     BedManagement.WardRoom.WardId, BedManagement.WardRoom.RoomNumber, BedManagement.WardRoom.RoomColor, 
                      BedManagement.WardRoom.BedsNumber, BedManagement.WardRoom.Capacity, BedManagement.WardRoom.IsPrivate, BedManagement.WardRoom.RoomPhone, 
                      BedManagement.WardRoom.WardRoomTypeId, BedManagement.WardRoom.IsClosed, BedManagement.WardBed.WardBedId, 
                      BedManagement.WardBed.WardRoomId, BedManagement.WardBed.BedNumber, BedManagement.WardBed.BedCode, BedManagement.WardBed.BedStatus, 
                      BedManagement.WardBed.BedType, BedManagement.WardBed.BedStatusPercentage, BedManagement.WardBed.CurrentPatientCode, 
                      BedManagement.WardBed.SpecialityId
FROM         BedManagement.WardRoom INNER JOIN
                      BedManagement.WardBed ON BedManagement.WardRoom.WardRoomId = BedManagement.WardBed.WardRoomId
