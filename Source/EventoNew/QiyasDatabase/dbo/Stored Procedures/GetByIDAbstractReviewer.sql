CREATE PROCEDURE [dbo].[GetByIDAbstractReviewer]
    @AbstractReviewerId int

AS
BEGIN
Select AbstractReviewerId, PersonId, IsInternal, DateCreated, IsActive
From [Conference].[AbstractReviewer]

WHERE [AbstractReviewerId] = @AbstractReviewerId
END

