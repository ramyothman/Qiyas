CREATE PROCEDURE [dbo].[GetByIDPersonType]
    @PersonTypeId int

AS
BEGIN
Select PersonTypeId, BusinessEntityId, PersonPersonTypesId, ModifiedDate
From [Person].[PersonType]

WHERE [PersonTypeId] = @PersonTypeId
END
