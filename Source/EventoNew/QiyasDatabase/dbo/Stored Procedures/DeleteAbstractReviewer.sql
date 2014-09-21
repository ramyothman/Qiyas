CREATE PROCEDURE [dbo].[DeleteAbstractReviewer]
    @AbstractReviewerId int

AS
Begin
 Delete [Conference].[AbstractReviewer] where     [AbstractReviewerId] = @AbstractReviewerId
End

