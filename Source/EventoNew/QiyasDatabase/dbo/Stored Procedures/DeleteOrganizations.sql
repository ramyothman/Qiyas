CREATE PROCEDURE [dbo].[DeleteOrganizations]
    @OrganizationId int

AS
Begin
 Delete [HumanResources].[Organizations] where     [OrganizationId] = @OrganizationId
End
