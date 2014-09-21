CREATE PROCEDURE [dbo].[GetByIDAbstractAuthors]
    @AbstractAuthorId int

AS
BEGIN
Select AbstractAuthorId, AbstractId, FirstName, FamilyName, Title, Degree, Email, Address, PhoneNumber, AffilitationDepartment, AffilitationInstitutionHospital, AffilitationCity, AffilitationCountry, Country, POBox, ZipCode, City, IsMainAuthor, PhoneNumberAreaCode
From [Conference].[AbstractAuthors]

WHERE [AbstractAuthorId] = @AbstractAuthorId
END

