CREATE PROCEDURE [dbo].[GetByIDPersonExtra]
    @PersonExtraId int

AS
BEGIN
Select PersonExtraId, NationalIdType, NationalId, Gender, Religion, BirthDate, BirthPlace, MaritalStatus, SpauseName, FatherGuardianName, FatherGuardianAddress, FatherGuardianContactNumber, EmergencyContactName, EmergencyContactAddress, EmergencyContactNumber, EmergencyContactEmail, SponsorId, SponsorStartDate, SponsorEndDate, SponsorCategoryId, IsGraduateTransfer, ReasonForSeekingTransfer, LevelRequired, OtherInformation
From [Person].[PersonExtra]

WHERE [PersonExtraId] = @PersonExtraId
END
