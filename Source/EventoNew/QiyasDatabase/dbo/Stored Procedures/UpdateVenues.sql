CREATE PROCEDURE [dbo].[UpdateVenues]
    @OldID int,
    @Name nvarchar(50),
    @Description ntext,
    @Location nvarchar(50),
    @Star int,
    @URL nvarchar(100),
    @Phone nvarchar(50),
    @Fax nvarchar(50),
    @Email nvarchar(50)
AS
UPDATE [Conference].[Venues]
SET
    Name = @Name,
    Description = @Description,
    Location = @Location,
    Star = @Star,
    URL = @URL,
    Phone = @Phone,
    Fax = @Fax,
    Email = @Email
WHERE [ID] = @OLDID
IF @@ROWCOUNT > 0
Select * From Conference.Venues 
Where [ID] = @OLDID
