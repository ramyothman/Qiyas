CREATE PROCEDURE [dbo].[UpdateAbstractAuthors]
    @OldAbstractAuthorId int,
    @AbstractId int,
    @FirstName nvarchar(50),
    @FamilyName nvarchar(50),
    @Title nvarchar(50),
    @Degree nvarchar(500),
    @Email nvarchar(50),
    @Address nvarchar(500),
    @PhoneNumber nvarchar(50),
    @AffilitationDepartment nvarchar(50),
    @AffilitationInstitutionHospital nvarchar(50),
    @AffilitationCity nvarchar(50),
    @AffilitationCountry nvarchar(50),
    @Country nvarchar(50),
    @POBox nvarchar(50),
    @ZipCode nvarchar(50),
    @City nvarchar(50),
    @IsMainAuthor bit,
    @PhoneNumberAreaCode nvarchar(50)
AS
UPDATE [Conference].[AbstractAuthors]
SET
    AbstractId = @AbstractId,
    FirstName = @FirstName,
    FamilyName = @FamilyName,
    Title = @Title,
    Degree = @Degree,
    Email = @Email,
    Address = @Address,
    PhoneNumber = @PhoneNumber,
    AffilitationDepartment = @AffilitationDepartment,
    AffilitationInstitutionHospital = @AffilitationInstitutionHospital,
    AffilitationCity = @AffilitationCity,
    AffilitationCountry = @AffilitationCountry,
    Country = @Country,
    POBox = @POBox,
    ZipCode = @ZipCode,
    City = @City,
    IsMainAuthor = @IsMainAuthor,
    PhoneNumberAreaCode = @PhoneNumberAreaCode
WHERE [AbstractAuthorId] = @OLDAbstractAuthorId
IF @@ROWCOUNT > 0
Select * From Conference.AbstractAuthors 
Where [AbstractAuthorId] = @OLDAbstractAuthorId

