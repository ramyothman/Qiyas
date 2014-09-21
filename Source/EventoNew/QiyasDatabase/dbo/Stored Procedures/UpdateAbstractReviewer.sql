CREATE PROCEDURE [dbo].[UpdateAbstractReviewer]
    @OldAbstractReviewerId int,
    @PersonId int,
    @IsInternal bit,
    @DateCreated datetime,
    @IsActive bit
AS
UPDATE [Conference].[AbstractReviewer]
SET
    PersonId = @PersonId,
    IsInternal = @IsInternal,
    DateCreated = @DateCreated,
    IsActive = @IsActive
WHERE [AbstractReviewerId] = @OLDAbstractReviewerId
IF @@ROWCOUNT > 0
Select * From Conference.AbstractReviewer 
Where [AbstractReviewerId] = @OLDAbstractReviewerId

