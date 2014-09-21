CREATE TABLE [Conference].[AbstractAuthorsLanguage] (
    [AbstractAuthorLanguageId]        INT            IDENTITY (1, 1) NOT NULL,
    [AbstractAuthorId]                INT            NULL,
    [FirstName]                       NVARCHAR (50)  NULL,
    [FamilyName]                      NVARCHAR (50)  NULL,
    [Title]                           NVARCHAR (50)  NULL,
    [Degree]                          NVARCHAR (500) NULL,
    [Email]                           NVARCHAR (50)  NULL,
    [Address]                         NVARCHAR (500) NULL,
    [AffilitationDepartment]          NVARCHAR (50)  NULL,
    [AffilitationInstitutionHospital] NVARCHAR (50)  NULL,
    [AffilitationCity]                NVARCHAR (50)  NULL,
    [AffilitationCountry]             NVARCHAR (50)  NULL,
    [Country]                         NVARCHAR (50)  NULL,
    [POBox]                           NVARCHAR (50)  NULL,
    [ZipCode]                         NVARCHAR (50)  NULL,
    [City]                            NVARCHAR (50)  NULL,
    [LanguageID]                      INT            NOT NULL,
    CONSTRAINT [PK_AbstractAuthorsLanguage] PRIMARY KEY CLUSTERED ([AbstractAuthorLanguageId] ASC),
    CONSTRAINT [FK_AbstractAuthorsLanguage_AbstractAuthors] FOREIGN KEY ([AbstractAuthorId]) REFERENCES [Conference].[AbstractAuthors] ([AbstractAuthorId]) ON DELETE CASCADE ON UPDATE CASCADE
);

