
CREATE PROCEDURE [dbo].[GetByIDSystemEmailType]
    @SystemEmailTypeID int

AS
BEGIN
Select SystemEmailTypeID, Name
From [Conference].[SystemEmailType]

WHERE [SystemEmailTypeID] = @SystemEmailTypeID
END
