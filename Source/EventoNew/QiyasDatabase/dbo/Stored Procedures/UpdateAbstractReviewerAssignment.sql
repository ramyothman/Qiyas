CREATE PROCEDURE [dbo].[UpdateAbstractReviewerAssignment]
    @OldAbstractReviewerAssignmentId int,
    @AbstractReviewerId int,
    @AbstractId int,
    @HasAcceptedReview bit,
    @DateAssigned datetime,
    @DateAccepted datetime
AS
UPDATE [Conference].[AbstractReviewerAssignment]
SET
    AbstractReviewerId = @AbstractReviewerId,
    AbstractId = @AbstractId,
    HasAcceptedReview = @HasAcceptedReview,
    DateAssigned = @DateAssigned,
    DateAccepted = @DateAccepted
WHERE [AbstractReviewerAssignmentId] = @OLDAbstractReviewerAssignmentId
IF @@ROWCOUNT > 0
Select * From Conference.AbstractReviewerAssignment 
Where [AbstractReviewerAssignmentId] = @OLDAbstractReviewerAssignmentId

