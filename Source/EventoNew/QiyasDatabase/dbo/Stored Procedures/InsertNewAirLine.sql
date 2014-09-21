CREATE PROCEDURE [dbo].[InsertNewAirLine]
    @ID int output ,
    @Name nvarchar(50)
AS
INSERT INTO [Conference].[AirLine] (
    [Name])
Values (
    @Name)
Set @ID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.AirLine
Where [ID] = @@identity
