CREATE PROCEDURE [dbo].[InsertNewTransportationType]
    @ID int output ,
    @TypeName nvarchar(50)
AS
INSERT INTO [Conference].[TransportationType] (
    [TypeName])
Values (
    @TypeName)
Set @ID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.TransportationType
Where [ID] = @@identity
