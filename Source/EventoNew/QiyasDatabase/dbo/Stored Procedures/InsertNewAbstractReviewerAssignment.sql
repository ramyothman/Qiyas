CREATE PROCEDURE [dbo].[InsertNewAbstractReviewerAssignment]
    @AbstractReviewerAssignmentId int output ,
    @AbstractReviewerId int,
    @AbstractId int,
    @HasAcceptedReview bit,
    @DateAssigned datetime,
    @DateAccepted datetime
AS
Declare @Result as int
Select @Result = AbstractReviewerAssignmentId From [Conference].[AbstractReviewerAssignment] where AbstractId = @AbstractId and AbstractReviewerId = @AbstractReviewerId
if(@Result is null)
begin
INSERT INTO [Conference].[AbstractReviewerAssignment] (
    [AbstractReviewerId],
    [AbstractId],
    [HasAcceptedReview],
    [DateAssigned],
    [DateAccepted])
Values (
    @AbstractReviewerId,
    @AbstractId,
    @HasAcceptedReview,
    @DateAssigned,
    @DateAccepted)
Set @AbstractReviewerAssignmentId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.AbstractReviewerAssignment
Where [AbstractReviewerAssignmentId] = @@identity
end
else
begin
Select * from Conference.AbstractReviewerAssignment
Where [AbstractReviewerAssignmentId] = @Result
end

