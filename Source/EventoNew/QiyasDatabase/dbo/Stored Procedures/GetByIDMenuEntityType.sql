CREATE PROCEDURE [dbo].[GetByIDMenuEntityType]
    @MenuEntityTypeId int

AS
BEGIN
Select MenuEntityTypeId, Name
From [ContentManagement].[MenuEntityType]

WHERE [MenuEntityTypeId] = @MenuEntityTypeId
END
