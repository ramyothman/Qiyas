CREATE PROCEDURE [dbo].[InsertNewPersonReference]
    @PersonReferenceId int output ,
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
INSERT INTO [PGME].[PersonReference] (
    [PersonId],
    [ReferenceFullName],
    [ReferenceEmail],
    [ReferenceAddress],
    [ReferenceContactNumber],
    [ReferenceMobileNumber],
    [ReferenceLetterPath],
    [ReferenceLetterMessage],
    [ReferenceAcceptedPerson],
    [ReferenceInstitution])
Values (
    @PersonId,
    @ReferenceFullName,
    @ReferenceEmail,
    @ReferenceAddress,
    @ReferenceContactNumber,
    @ReferenceMobileNumber,
    @ReferenceLetterPath,
    @ReferenceLetterMessage,
    @ReferenceAcceptedPerson,
    @ReferenceInstitution)
Set @PersonReferenceId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from PGME.PersonReference
Where [PersonReferenceId] = @@identity
