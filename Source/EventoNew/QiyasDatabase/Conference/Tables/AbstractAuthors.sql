CREATE TABLE [Conference].[AbstractAuthors] (
    [AbstractAuthorId]                INT            IDENTITY (1, 1) NOT NULL,
    [AbstractId]                      INT            NULL,
    [FirstName]                       NVARCHAR (50)  NULL,
    [FamilyName]                      NVARCHAR (50)  NULL,
    [Title]                           NVARCHAR (50)  NULL,
    [Degree]                          NVARCHAR (500) NULL,
    [Email]                           NVARCHAR (50)  NULL,
    [Address]                         NVARCHAR (500) NULL,
    [PhoneNumber]                     NVARCHAR (50)  NULL,
    [AffilitationDepartment]          NVARCHAR (50)  NULL,
    [AffilitationInstitutionHospital] NVARCHAR (50)  NULL,
    [AffilitationCity]                NVARCHAR (50)  NULL,
    [AffilitationCountry]             NVARCHAR (50)  NULL,
    [Country]                         NVARCHAR (50)  NULL,
    [POBox]                           NVARCHAR (50)  NULL,
    [ZipCode]                         NVARCHAR (50)  NULL,
    [City]                            NVARCHAR (50)  NULL,
    [IsMainAuthor]                    BIT            NULL,
    [PhoneNumberAreaCode]             NVARCHAR (50)  NULL,
    CONSTRAINT [PK_AbstractAuthors] PRIMARY KEY CLUSTERED ([AbstractAuthorId] ASC),
    CONSTRAINT [FK_AbstractAuthors_Abstracts] FOREIGN KEY ([AbstractId]) REFERENCES [Conference].[Abstracts] ([AbstractId]) ON DELETE CASCADE ON UPDATE CASCADE
);

