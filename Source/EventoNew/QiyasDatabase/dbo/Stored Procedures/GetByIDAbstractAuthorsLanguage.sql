CREATE PROCEDURE [dbo].[GetByIDAbstractAuthorsLanguage]
    @AbstractAuthorLanguageId int

AS
BEGIN
Select AbstractAuthorLanguageId, AbstractAuthorId, FirstName, FamilyName, Title, Degree, Email, Address, AffilitationDepartment, AffilitationInstitutionHospital, AffilitationCity, AffilitationCountry, Country, POBox, ZipCode, City, LanguageID
From [Conference].[AbstractAuthorsLanguage]

WHERE [AbstractAuthorLanguageId] = @AbstractAuthorLanguageId
END

