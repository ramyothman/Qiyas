CREATE PROCEDURE [dbo].[UpdateAbstractAuthorsLanguage]
    @OldAbstractAuthorLanguageId int,
    @AbstractAuthorId int,
    @FirstName nvarchar(50),
    @FamilyName nvarchar(50),
    @Title nvarchar(50),
    @Degree nvarchar(500),
    @Email nvarchar(50),
    @Address nvarchar(500),
    @AffilitationDepartment nvarchar(50),
    @AffilitationInstitutionHospital nvarchar(50),
    @AffilitationCity nvarchar(50),
    @AffilitationCountry nvarchar(50),
    @Country nvarchar(50),
    @POBox nvarchar(50),
    @ZipCode nvarchar(50),
    @City nvarchar(50),
    @LanguageID int
AS
UPDATE [Conference].[AbstractAuthorsLanguage]
SET
    AbstractAuthorId = @AbstractAuthorId,
    FirstName = @FirstName,
    FamilyName = @FamilyName,
    Title = @Title,
    Degree = @Degree,
    Email = @Email,
    Address = @Address,
    AffilitationDepartment = @AffilitationDepartment,
    AffilitationInstitutionHospital = @AffilitationInstitutionHospital,
    AffilitationCity = @AffilitationCity,
    AffilitationCountry = @AffilitationCountry,
    Country = @Country,
    POBox = @POBox,
    ZipCode = @ZipCode,
    City = @City,
    LanguageID = @LanguageID
WHERE [AbstractAuthorLanguageId] = @OLDAbstractAuthorLanguageId
IF @@ROWCOUNT > 0
Select * From Conference.AbstractAuthorsLanguage 
Where [AbstractAuthorLanguageId] = @OLDAbstractAuthorLanguageId

