CREATE PROCEDURE [dbo].[DeleteWardBed]
    @WardBedId int

AS
Begin
 Delete [BedManagement].[WardBed] where     [WardBedId] = @WardBedId
End
