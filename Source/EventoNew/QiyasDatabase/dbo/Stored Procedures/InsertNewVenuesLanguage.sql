CREATE PROCEDURE [dbo].[InsertNewVenuesLanguage]
    @ID int output ,
    @Name nvarchar(50),
    @Description ntext,
    @Location nvarchar(50),
    @Star int,
    @URL nvarchar(100),
    @Phone nvarchar(50),
    @Fax nvarchar(50),
    @Email nvarchar(50),
    @LanguageID int,
    @parentID int
AS
INSERT INTO [Conference].[VenuesLanguage] (
    [Name],
    [Description],
    [Location],
    [Star],
    [URL],
    [Phone],
    [Fax],
    [Email],
    [LanguageID],
    [parentID])
Values (
    @Name,
    @Description,
    @Location,
    @Star,
    @URL,
    @Phone,
    @Fax,
    @Email,
    @LanguageID,
    @parentID)
Set @ID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.VenuesLanguage
Where [ID] = @@identity
