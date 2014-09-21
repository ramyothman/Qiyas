CREATE PROCEDURE [dbo].[UpdateProgramType]
    @OldProgramTypeId int,
    @ProgramTypeName nvarchar(50)
AS
UPDATE [PGME].[ProgramType]
SET
    ProgramTypeName = @ProgramTypeName
WHERE [ProgramTypeId] = @OLDProgramTypeId
IF @@ROWCOUNT > 0
Select * From PGME.ProgramType 
Where [ProgramTypeId] = @OLDProgramTypeId
