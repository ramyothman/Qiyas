CREATE PROCEDURE [dbo].[GetByIDAbstractReview]
    @AbstractReviewId int

AS
BEGIN
Select AbstractReviewId, AbstractReviewerAssignmentId, AbstractStatusId, ReviewerFeedback, DateSubmitted
From [Conference].[AbstractReview]

WHERE [AbstractReviewId] = @AbstractReviewId
END

