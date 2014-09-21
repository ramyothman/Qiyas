CREATE PROCEDURE [dbo].[GetByIDTransportationType]
    @ID int

AS
BEGIN
Select ID, TypeName
From [Conference].[TransportationType]

WHERE [ID] = @ID
END
