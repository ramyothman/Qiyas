CREATE PROCEDURE [dbo].[GetByIDAirLine]
    @ID int

AS
BEGIN
Select ID, Name
From [Conference].[AirLine]

WHERE [ID] = @ID
END
