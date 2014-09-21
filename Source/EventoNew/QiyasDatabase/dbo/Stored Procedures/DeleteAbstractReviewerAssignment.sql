CREATE PROCEDURE [dbo].[DeleteAbstractReviewerAssignment]
    @AbstractReviewerAssignmentId int

AS
Begin
 Delete [Conference].[AbstractReviewerAssignment] where     [AbstractReviewerAssignmentId] = @AbstractReviewerAssignmentId
End

