CREATE PROCEDURE [dbo].[DeleteAbstractReview]
    @AbstractReviewId int

AS
Begin
 Delete [Conference].[AbstractReview] where     [AbstractReviewId] = @AbstractReviewId
End

