﻿CREATE PROCEDURE [dbo].[InsertNewConferenceRegisterations]
    @ConferenceRegistererId int output ,
    @SponsorId int,
    @PersonId int,
    @ConferenceId int,
    @DateRegistered datetime,
    @DiscountAmount decimal(18,2),
    @AmountPaid decimal(18,2),
    @DiscountReason nvarchar(150),
    @RegitrationCategory nvarchar(50),
    @LicenseNumber nvarchar(50),
    @Address nvarchar(50),
    @POBox nvarchar(50),
    @ZipCode nvarchar(50),
    @City nvarchar(50),
    @Country nvarchar(50),
    @PhoneNumberCountryCode nvarchar(50),
    @PhoneNumberAreaCode nvarchar(50),
    @PhoneNumber nvarchar(50),
    @FaxNumberCountryCode nvarchar(50),
    @FaxNumberAreaCode nvarchar(50),
    @FaxNumber nvarchar(50),
    @MobileNumberCountryCode nvarchar(50),
    @MobileNumberAreaCode nvarchar(50),
    @MobileNumber nvarchar(50),
    @Email nvarchar(50),
    @AcademicInformationPosition nvarchar(50),
    @AcademicInformationDegree nvarchar(50),
    @AcademicInformationHealthCarePro bit,
    @AcademicInformationHealthCareProValue nvarchar(50),
    @HospitalInstituteName nvarchar(50),
    @HospitalInstituteDepartment nvarchar(50),
    @HospitalInstituteAddress nvarchar(50),
    @HospitalInstituteZipCode nvarchar(50),
    @HospitalInstituteCity nvarchar(50),
    @HospitalInstituteCountry nvarchar(50),
    @HospitalInstitutePOBox nvarchar(50),
    @ConferenceRegistrationTypeId int,
    @PreConferenceWorkShopIncluded bit,
    @SubscribeToNewsLetter bit,
    @AOAAdministrator bit,
    @AOARetired bit,
    @AOAClinicalResearcher bit,
    @AOABasicResearcher bit,
    @AOATeacherEducator bit,
    @AOAIndustryRepresentative bit,
    @AOAClinicalPractitioner bit,
    @AOAAlliedHealthProfessional bit,
    @AOAStudent bit,
    @AOAOther bit,
    @AOAOtherText nvarchar(500),
    @AOAMCNAcuteKidneyInjury bit,
    @AOAMCNChronicKidneyDisease bit,
    @AOAMCNHypertension bit,
    @AOAMCNGlomerulonephritis bit,
    @AOAMCNNephrolithiasis bit,
    @AOAMRRTHemodialysis bit,
    @AOAMRRTPertionealDialysis bit,
    @AOAMRRTCRRT bit,
    @AOAMPediatricNephrology bit,
    @AOAMGenetics bit,
    @AOAMUrology bit,
    @AOAMMineralMetabolism bit,
    @AOAMAnemia bit,
    @AOAMDiabetes bit,
    @AOAMImmunology bit,
    @AOAMPathology bit,
    @AOAMIterventionalCCN bit,
    @AOAMOther bit,
    @AOAMOtherText nvarchar(500),
    @SponsorName nvarchar(250),
    @DeductedAmount decimal(18,2),
    @IsActive bit ,
    @IsMember bit,
    @IsSelfSponsor bit
AS
INSERT INTO [Conference].[ConferenceRegisterations] (
    [SponsorId],
    [PersonId],
    [ConferenceId],
    [DateRegistered],
    [DiscountAmount],
    [AmountPaid],
    [DiscountReason],
    [RegitrationCategory],
    [LicenseNumber],
    [Address],
    [POBox],
    [ZipCode],
    [City],
    [Country],
    [PhoneNumberCountryCode],
    [PhoneNumberAreaCode],
    [PhoneNumber],
    [FaxNumberCountryCode],
    [FaxNumberAreaCode],
    [FaxNumber],
    [MobileNumberCountryCode],
    [MobileNumberAreaCode],
    [MobileNumber],
    [Email],
    [AcademicInformationPosition],
    [AcademicInformationDegree],
    [AcademicInformationHealthCarePro],
    [AcademicInformationHealthCareProValue],
    [HospitalInstituteName],
    [HospitalInstituteDepartment],
    [HospitalInstituteAddress],
    [HospitalInstituteZipCode],
    [HospitalInstituteCity],
    [HospitalInstituteCountry],
    [HospitalInstitutePOBox],
    [ConferenceRegistrationTypeId],
    [PreConferenceWorkShopIncluded],
    [SubscribeToNewsLetter],
    [AOAAdministrator],
    [AOARetired],
    [AOAClinicalResearcher],
    [AOABasicResearcher],
    [AOATeacherEducator],
    [AOAIndustryRepresentative],
    [AOAClinicalPractitioner],
    [AOAAlliedHealthProfessional],
    [AOAStudent],
    [AOAOther],
    [AOAOtherText],
    [AOAMCNAcuteKidneyInjury],
    [AOAMCNChronicKidneyDisease],
    [AOAMCNHypertension],
    [AOAMCNGlomerulonephritis],
    [AOAMCNNephrolithiasis],
    [AOAMRRTHemodialysis],
    [AOAMRRTPertionealDialysis],
    [AOAMRRTCRRT],
    [AOAMPediatricNephrology],
    [AOAMGenetics],
    [AOAMUrology],
    [AOAMMineralMetabolism],
    [AOAMAnemia],
    [AOAMDiabetes],
    [AOAMImmunology],
    [AOAMPathology],
    [AOAMIterventionalCCN],
    [AOAMOther],
    [AOAMOtherText],
    SponsorName,
    DeductedAmount,
    IsActive,
    IsMember,
    IsSelfSponsor)
Values (
    @SponsorId,
    @PersonId,
    @ConferenceId,
    @DateRegistered,
    @DiscountAmount,
    @AmountPaid,
    @DiscountReason,
    @RegitrationCategory,
    @LicenseNumber,
    @Address,
    @POBox,
    @ZipCode,
    @City,
    @Country,
    @PhoneNumberCountryCode,
    @PhoneNumberAreaCode,
    @PhoneNumber,
    @FaxNumberCountryCode,
    @FaxNumberAreaCode,
    @FaxNumber,
    @MobileNumberCountryCode,
    @MobileNumberAreaCode,
    @MobileNumber,
    @Email,
    @AcademicInformationPosition,
    @AcademicInformationDegree,
    @AcademicInformationHealthCarePro,
    @AcademicInformationHealthCareProValue,
    @HospitalInstituteName,
    @HospitalInstituteDepartment,
    @HospitalInstituteAddress,
    @HospitalInstituteZipCode,
    @HospitalInstituteCity,
    @HospitalInstituteCountry,
    @HospitalInstitutePOBox,
    @ConferenceRegistrationTypeId,
    @PreConferenceWorkShopIncluded,
    @SubscribeToNewsLetter,
    @AOAAdministrator,
    @AOARetired,
    @AOAClinicalResearcher,
    @AOABasicResearcher,
    @AOATeacherEducator,
    @AOAIndustryRepresentative,
    @AOAClinicalPractitioner,
    @AOAAlliedHealthProfessional,
    @AOAStudent,
    @AOAOther,
    @AOAOtherText,
    @AOAMCNAcuteKidneyInjury,
    @AOAMCNChronicKidneyDisease,
    @AOAMCNHypertension,
    @AOAMCNGlomerulonephritis,
    @AOAMCNNephrolithiasis,
    @AOAMRRTHemodialysis,
    @AOAMRRTPertionealDialysis,
    @AOAMRRTCRRT,
    @AOAMPediatricNephrology,
    @AOAMGenetics,
    @AOAMUrology,
    @AOAMMineralMetabolism,
    @AOAMAnemia,
    @AOAMDiabetes,
    @AOAMImmunology,
    @AOAMPathology,
    @AOAMIterventionalCCN,
    @AOAMOther,
    @AOAMOtherText,
    @SponsorName,
    @DeductedAmount,
    @IsActive,
    @IsMember,
    @IsSelfSponsor)
Set @ConferenceRegistererId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceRegisterations
Where [ConferenceRegistererId] = @@identity