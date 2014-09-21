CREATE PROCEDURE [dbo].[GetByIDPageStatus]
    @PageStatusId int

AS
BEGIN
Select PageStatusId, Name, RowGuid, ModifiedDate
From [ContentManagement].[PageStatus]

WHERE [PageStatusId] = @PageStatusId
END
