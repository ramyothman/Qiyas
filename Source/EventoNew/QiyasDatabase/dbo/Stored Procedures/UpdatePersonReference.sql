CREATE PROCEDURE [dbo].[UpdatePersonReference]
    @OldPersonReferenceId int,
    @PersonId int,
    @ReferenceFullName nvarchar(150),
    @ReferenceEmail nvarchar(150),
    @ReferenceAddress nvarchar(250),
    @ReferenceContactNumber nvarchar(50),
    @ReferenceMobileNumber nvarchar(50),
    @ReferenceLetterPath nvarchar(250),
    @ReferenceLetterMessage ntext,
    @ReferenceAcceptedPerson bit,
    @ReferenceInstitution nvarchar(150)
AS
UPDATE [PGME].[PersonReference]
SET
    PersonId = @PersonId,
    ReferenceFullName = @ReferenceFullName,
    ReferenceEmail = @ReferenceEmail,
    ReferenceAddress = @ReferenceAddress,
    ReferenceContactNumber = @ReferenceContactNumber,
    ReferenceMobileNumber = @ReferenceMobileNumber,
    ReferenceLetterPath = @ReferenceLetterPath,
    ReferenceLetterMessage = @ReferenceLetterMessage,
    ReferenceAcceptedPerson = @ReferenceAcceptedPerson,
    ReferenceInstitution = @ReferenceInstitution
WHERE [PersonReferenceId] = @OLDPersonReferenceId
IF @@ROWCOUNT > 0
Select * From PGME.PersonReference 
Where [PersonReferenceId] = @OLDPersonReferenceId
