CREATE PROCEDURE [dbo].[GetByIDAbstractStatus]
    @AbstractStatusId int

AS
BEGIN
Select AbstractStatusId, Name, NameAr
From [Conference].[AbstractStatus]

WHERE [AbstractStatusId] = @AbstractStatusId
END

