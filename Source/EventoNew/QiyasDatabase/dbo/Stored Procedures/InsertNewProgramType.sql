CREATE PROCEDURE [dbo].[InsertNewProgramType]
    @ProgramTypeId int output ,
    @ProgramTypeName nvarchar(50)
AS
INSERT INTO [PGME].[ProgramType] (
    [ProgramTypeName])
Values (
    @ProgramTypeName)
Set @ProgramTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from PGME.ProgramType
Where [ProgramTypeId] = @@identity
