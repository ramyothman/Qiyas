CREATE PROCEDURE [dbo].[InsertNewAbstractAuthorsLanguage]
    @AbstractAuthorLanguageId int output ,
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
INSERT INTO [Conference].[AbstractAuthorsLanguage] (
    [AbstractAuthorId],
    [FirstName],
    [FamilyName],
    [Title],
    [Degree],
    [Email],
    [Address],
    [AffilitationDepartment],
    [AffilitationInstitutionHospital],
    [AffilitationCity],
    [AffilitationCountry],
    [Country],
    [POBox],
    [ZipCode],
    [City],
    [LanguageID])
Values (
    @AbstractAuthorId,
    @FirstName,
    @FamilyName,
    @Title,
    @Degree,
    @Email,
    @Address,
    @AffilitationDepartment,
    @AffilitationInstitutionHospital,
    @AffilitationCity,
    @AffilitationCountry,
    @Country,
    @POBox,
    @ZipCode,
    @City,
    @LanguageID)
Set @AbstractAuthorLanguageId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.AbstractAuthorsLanguage
Where [AbstractAuthorLanguageId] = @@identity


