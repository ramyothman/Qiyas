CREATE PROCEDURE [dbo].[GetByIDPerson]
    @BusinessEntityId int

AS
BEGIN
Select BusinessEntityId, NameStyle, EmailPromotion, RowGuid, ModifiedDate, CreatedDate, NationalityCode,Gender,DateofBirth,PersonImage
From [Person].[Person]

WHERE [BusinessEntityId] = @BusinessEntityId
END
