CREATE VIEW [dbo].[GetAllPerson]
AS
SELECT     BusinessEntityId, NameStyle, EmailPromotion, RowGuid, ModifiedDate, CreatedDate, NationalityCode, Gender, DateofBirth, PersonImage
FROM         Person.Person
