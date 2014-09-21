CREATE PROCEDURE [dbo].[InsertNewPersonPGMERegisteration]
    @PersonRegisterationId int output ,
    @PersonId int,
    @PersonProgramId int,
    @PersonRegisterationStatusId int,
    @RegisterationNumber nvarchar(50),
    @UniRegisterationNumber nvarchar(50)
AS
INSERT INTO [PGME].[PersonPGMERegisteration] (
    [PersonId],
    [PersonProgramId],
    [PersonRegisterationStatusId],
    [RegisterationNumber],
    [UniRegisterationNumber])
Values (
    @PersonId,
    @PersonProgramId,
    @PersonRegisterationStatusId,
    @RegisterationNumber,
    @UniRegisterationNumber)
Set @PersonRegisterationId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from PGME.PersonPGMERegisteration
Where [PersonRegisterationId] = @@identity
