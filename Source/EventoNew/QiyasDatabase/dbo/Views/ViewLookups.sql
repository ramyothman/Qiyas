CREATE VIEW [dbo].[ViewLookups]
AS
SELECT     ContentManagement.Lookups.LookupId, ContentManagement.Lookups.LookupName, ContentManagement.Lookups.LookupFriendlyName, 
                      ContentManagement.LookupLanguages.LookupLanguageId, ContentManagement.LookupLanguages.LanguageId, ContentManagement.LookupLanguages.RefId, 
                      ContentManagement.LookupLanguages.LookupValue, ContentManagement.LookupLanguages.LookupValueDescription
FROM         ContentManagement.Lookups INNER JOIN
                      ContentManagement.LookupLanguages ON ContentManagement.Lookups.LookupId = ContentManagement.LookupLanguages.LookupId
