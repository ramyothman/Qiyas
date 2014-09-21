CREATE PROCEDURE [dbo].[InsertNewAbstractReview]
    @AbstractReviewId int,
    @AbstractReviewerAssignmentId int,
    @AbstractStatusId int,
    @ReviewerFeedback ntext,
    @DateSubmitted datetime
AS
INSERT INTO [Conference].[AbstractReview] (
    [AbstractReviewId],
    [AbstractReviewerAssignmentId],
    [AbstractStatusId],
    [ReviewerFeedback],
    [DateSubmitted])
Values (
    @AbstractReviewId,
    @AbstractReviewerAssignmentId,
    @AbstractStatusId,
    @ReviewerFeedback,
    @DateSubmitted)

IF @@ROWCOUNT > 0
Select * from Conference.AbstractReview
Where [AbstractReviewId] = @AbstractReviewId


