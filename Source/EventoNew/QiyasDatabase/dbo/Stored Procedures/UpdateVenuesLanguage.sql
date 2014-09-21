CREATE PROCEDURE [dbo].[UpdateVenuesLanguage]
    @OldID int,
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
UPDATE [Conference].[VenuesLanguage]
SET
    Name = @Name,
    Description = @Description,
    Location = @Location,
    Star = @Star,
    URL = @URL,
    Phone = @Phone,
    Fax = @Fax,
    Email = @Email,
    LanguageID = @LanguageID,
    parentID = @parentID
WHERE [ID] = @OLDID
IF @@ROWCOUNT > 0
Select * From Conference.VenuesLanguage 
Where [ID] = @OLDID
