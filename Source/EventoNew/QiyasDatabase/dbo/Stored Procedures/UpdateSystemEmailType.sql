
CREATE PROCEDURE [dbo].[UpdateSystemEmailType]
    @SystemEmailTypeID int,
    @OldSystemEmailTypeID int,
    @Name nvarchar(50)
AS
UPDATE [Conference].[SystemEmailType]
SET
    SystemEmailTypeID = @SystemEmailTypeID,
    Name = @Name
WHERE [SystemEmailTypeID] = @OLDSystemEmailTypeID
IF @@ROWCOUNT > 0
Select * From Conference.SystemEmailType 
Where [SystemEmailTypeID] = @SystemEmailTypeID
