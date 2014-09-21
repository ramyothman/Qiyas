CREATE PROCEDURE [dbo].[InsertNewHotel]
    @ID int output ,
    @Name nvarchar(50),
    @Description ntext,
    @Location nvarchar(50),
    @Star int,
    @URL nvarchar(100),
    @Phone nvarchar(50),
    @Fax nvarchar(50),
    @Email nvarchar(50),
	@ConferenceID int
AS
INSERT INTO [Conference].[Hotel] (
    [Name],
    [Description],
    [Location],
    [Star],
    [URL],
    [Phone],
    [Fax],
    [Email],
	ConferenceID)
Values (
    @Name,
    @Description,
    @Location,
    @Star,
    @URL,
    @Phone,
    @Fax,
    @Email,
	@ConferenceID)
Set @ID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.Hotel
Where [ID] = @@identity
