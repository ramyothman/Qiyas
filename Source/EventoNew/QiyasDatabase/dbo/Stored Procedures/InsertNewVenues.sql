CREATE PROCEDURE [dbo].[InsertNewVenues]
    @ID int output ,
    @Name nvarchar(50),
    @Description ntext,
    @Location nvarchar(50),
    @Star int,
    @URL nvarchar(100),
    @Phone nvarchar(50),
    @Fax nvarchar(50),
    @Email nvarchar(50)
AS
INSERT INTO [Conference].[Venues] (
    [Name],
    [Description],
    [Location],
    [Star],
    [URL],
    [Phone],
    [Fax],
    [Email])
Values (
    @Name,
    @Description,
    @Location,
    @Star,
    @URL,
    @Phone,
    @Fax,
    @Email)
Set @ID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.Venues
Where [ID] = @@identity
