CREATE PROCEDURE [dbo].[GetByIDConferenceRegisterationsLanguage]
    @ConferenceRegistererId int

AS
BEGIN
Select ConferenceRegistererId, SponsorId, PersonId, ConferenceId, DateRegistered, DiscountAmount, AmountPaid, DiscountReason, RegitrationCategory, LicenseNumber, Address, POBox, ZipCode, City, Country, PhoneNumberCountryCode, PhoneNumberAreaCode, PhoneNumber, FaxNumberCountryCode, FaxNumberAreaCode, FaxNumber, MobileNumberCountryCode, MobileNumberAreaCode, MobileNumber, Email, AcademicInformationPosition, AcademicInformationDegree, AcademicInformationHealthCarePro, AcademicInformationHealthCareProValue, HospitalInstituteName, HospitalInstituteDepartment, HospitalInstituteAddress, HospitalInstituteZipCode, HospitalInstituteCity, HospitalInstituteCountry, HospitalInstitutePOBox, ConferenceRegistrationTypeId, PreConferenceWorkShopIncluded, SubscribeToNewsLetter, AOAAdministrator, AOARetired, AOAClinicalResearcher, AOABasicResearcher, AOATeacherEducator, AOAIndustryRepresentative, AOAClinicalPractitioner, AOAAlliedHealthProfessional, AOAStudent, AOAOther, AOAOtherText, AOAMCNAcuteKidneyInjury, AOAMCNChronicKidneyDisease, AOAMCNHypertension, AOAMCNGlomerulonephritis, AOAMCNNephrolithiasis, AOAMRRTHemodialysis, AOAMRRTPertionealDialysis, AOAMRRTCRRT, AOAMPediatricNephrology, AOAMGenetics, AOAMUrology, AOAMMineralMetabolism, AOAMAnemia, AOAMDiabetes, AOAMImmunology, AOAMPathology, AOAMIterventionalCCN, AOAMOther, AOAMOtherText, SponsorName, DeductedAmount, IsActive, IsMember, IsSelfSponsor, ConferenceRegistererParentId, LanguageID
From [Conference].[ConferenceRegisterationsLanguage]

WHERE [ConferenceRegistererId] = @ConferenceRegistererId
END
