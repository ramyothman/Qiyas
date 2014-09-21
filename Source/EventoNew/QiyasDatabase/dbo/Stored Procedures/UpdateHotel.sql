CREATE PROCEDURE [dbo].[UpdateHotel]
    @OldID int,
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
UPDATE [Conference].[Hotel]
SET
    Name = @Name,
    Description = @Description,
    Location = @Location,
    Star = @Star,
    URL = @URL,
    Phone = @Phone,
    Fax = @Fax,
    Email = @Email,
	ConferenceID = @ConferenceID
WHERE [ID] = @OLDID
IF @@ROWCOUNT > 0
Select * From Conference.Hotel 
Where [ID] = @OLDID
