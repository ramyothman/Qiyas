CREATE PROCEDURE [dbo].[GetByIDAbstractReviewerAssignment]
    @AbstractReviewerAssignmentId int

AS
BEGIN
Select AbstractReviewerAssignmentId, AbstractReviewerId, AbstractId, HasAcceptedReview, DateAssigned, DateAccepted
From [Conference].[AbstractReviewerAssignment]

WHERE [AbstractReviewerAssignmentId] = @AbstractReviewerAssignmentId
END

