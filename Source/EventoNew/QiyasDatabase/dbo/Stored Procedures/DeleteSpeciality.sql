CREATE PROCEDURE [dbo].[DeleteSpeciality]
    @SpecialityId int

AS
Begin
 Delete [Organization].[Speciality] where     [SpecialityId] = @SpecialityId
End
