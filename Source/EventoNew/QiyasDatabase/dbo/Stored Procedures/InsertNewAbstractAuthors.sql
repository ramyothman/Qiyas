CREATE PROCEDURE [dbo].[InsertNewAbstractAuthors]
    @AbstractAuthorId int output ,
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
INSERT INTO [Conference].[AbstractAuthors] (
    [AbstractId],
    [FirstName],
    [FamilyName],
    [Title],
    [Degree],
    [Email],
    [Address],
    [PhoneNumber],
    [AffilitationDepartment],
    [AffilitationInstitutionHospital],
    [AffilitationCity],
    [AffilitationCountry],
    [Country],
    [POBox],
    [ZipCode],
    [City],
    [IsMainAuthor],
    [PhoneNumberAreaCode])
Values (
    @AbstractId,
    @FirstName,
    @FamilyName,
    @Title,
    @Degree,
    @Email,
    @Address,
    @PhoneNumber,
    @AffilitationDepartment,
    @AffilitationInstitutionHospital,
    @AffilitationCity,
    @AffilitationCountry,
    @Country,
    @POBox,
    @ZipCode,
    @City,
    @IsMainAuthor,
    @PhoneNumberAreaCode)
Set @AbstractAuthorId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.AbstractAuthors
Where [AbstractAuthorId] = @@identity


