CREATE PROCEDURE [dbo].[InsertNewPersonEducation]
    @PersonEducationId int output ,
    @PersonId int,
    @InstitutionName nvarchar(50),
    @Degree nvarchar(50),
    @StartDate datetime,
    @GraduationDate datetime,
    @FinalGrade nvarchar(50)
AS
INSERT INTO [Person].[PersonEducation] (
    [PersonId],
    [InstitutionName],
    [Degree],
    [StartDate],
    [GraduationDate],
    [FinalGrade])
Values (
    @PersonId,
    @InstitutionName,
    @Degree,
    @StartDate,
    @GraduationDate,
    @FinalGrade)
Set @PersonEducationId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Person.PersonEducation
Where [PersonEducationId] = @@identity
