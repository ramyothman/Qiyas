
CREATE PROCEDURE [dbo].[GetByIDMenuEntityPosition]
    @MenuEntityPositionID int

AS
BEGIN
Select MenuEntityPositionID, Name
From [ContentManagement].[MenuEntityPosition]

WHERE [MenuEntityPositionID] = @MenuEntityPositionID
END
