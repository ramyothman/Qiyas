CREATE PROCEDURE [dbo].[DeletePersonSCHealthSpeciality]
    @PersonSCHealthSpecialityId int

AS
Begin
 Delete [PGME].[PersonSCHealthSpeciality] where     [PersonSCHealthSpecialityId] = @PersonSCHealthSpecialityId
End
