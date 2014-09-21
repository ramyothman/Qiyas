CREATE PROCEDURE [dbo].[InsertNewHotelLanguage]
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
    @ParentID int
AS
INSERT INTO [Conference].[HotelLanguage] (
    [Name],
    [Description],
    [Location],
    [Star],
    [URL],
    [Phone],
    [Fax],
    [Email],
    [LanguageID],
    [ParentID])
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
    @ParentID)
Set @ID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.HotelLanguage
Where [ID] = @@identity
