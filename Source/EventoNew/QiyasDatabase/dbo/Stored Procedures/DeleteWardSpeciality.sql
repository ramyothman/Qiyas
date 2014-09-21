CREATE PROCEDURE [dbo].[DeleteWardSpeciality]
    @WardSpecialityId int

AS
Begin
 Delete [BedManagement].[WardSpeciality] where     [WardSpecialityId] = @WardSpecialityId
End
