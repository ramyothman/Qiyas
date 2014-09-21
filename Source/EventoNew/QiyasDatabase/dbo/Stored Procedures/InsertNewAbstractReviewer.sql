CREATE PROCEDURE [dbo].[InsertNewAbstractReviewer]
    @AbstractReviewerId int output ,
    @PersonId int,
    @IsInternal bit,
    @DateCreated datetime,
    @IsActive bit
AS
INSERT INTO [Conference].[AbstractReviewer] (
    [PersonId],
    [IsInternal],
    [DateCreated],
    [IsActive])
Values (
    @PersonId,
    @IsInternal,
    @DateCreated,
    @IsActive)
Set @AbstractReviewerId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.AbstractReviewer
Where [AbstractReviewerId] = @@identity


