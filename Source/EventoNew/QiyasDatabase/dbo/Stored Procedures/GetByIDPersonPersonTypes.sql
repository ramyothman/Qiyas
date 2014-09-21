CREATE PROCEDURE [dbo].[GetByIDPersonPersonTypes]
    @PersonPersonTypesId int

AS
BEGIN
Select PersonPersonTypesId, Name, RowGuid, ModifiedDate
From [Person].[PersonPersonTypes]

WHERE [PersonPersonTypesId] = @PersonPersonTypesId
END
