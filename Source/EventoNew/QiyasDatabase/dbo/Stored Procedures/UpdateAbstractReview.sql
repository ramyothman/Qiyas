CREATE PROCEDURE [dbo].[UpdateAbstractReview]
    @AbstractReviewId int,
    @OldAbstractReviewId int,
    @AbstractReviewerAssignmentId int,
    @AbstractStatusId int,
    @ReviewerFeedback ntext,
    @DateSubmitted datetime
AS
UPDATE [Conference].[AbstractReview]
SET
    AbstractReviewId = @AbstractReviewId,
    AbstractReviewerAssignmentId = @AbstractReviewerAssignmentId,
    AbstractStatusId = @AbstractStatusId,
    ReviewerFeedback = @ReviewerFeedback,
    DateSubmitted = @DateSubmitted
WHERE [AbstractReviewId] = @OLDAbstractReviewId
IF @@ROWCOUNT > 0
Select * From Conference.AbstractReview 
Where [AbstractReviewId] = @AbstractReviewId

