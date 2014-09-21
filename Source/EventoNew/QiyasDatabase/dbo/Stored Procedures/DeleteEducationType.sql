CREATE PROCEDURE [dbo].[DeleteEducationType]
    @EducationTypeId int

AS
Begin
 Delete [Person].[EducationType] where     [EducationTypeId] = @EducationTypeId
End
