
CREATE PROCEDURE [dbo].[InsertNewSystemEmailType]
    @SystemEmailTypeID int,
    @Name nvarchar(50)
AS
INSERT INTO [Conference].[SystemEmailType] (
    [SystemEmailTypeID],
    [Name])
Values (
    @SystemEmailTypeID,
    @Name)

IF @@ROWCOUNT > 0
Select * from Conference.SystemEmailType
Where [SystemEmailTypeID] = @SystemEmailTypeID
