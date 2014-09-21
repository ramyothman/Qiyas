CREATE PROCEDURE [dbo].[GetByIDPersonPublication]
    @PersonPublicationId int

AS
BEGIN
Select PersonPublicationId, PersonId, PublicationTitle, PublicationAbstract, PublicationAttachmentPath
From [Person].[PersonPublication]

WHERE [PersonPublicationId] = @PersonPublicationId
END
