CREATE TABLE [PGME].[PersonReference] (
    [PersonReferenceId]       INT            IDENTITY (1, 1) NOT NULL,
    [PersonId]                INT            NULL,
    [ReferenceFullName]       NVARCHAR (150) NULL,
    [ReferenceEmail]          NVARCHAR (150) NULL,
    [ReferenceAddress]        NVARCHAR (250) NULL,
    [ReferenceContactNumber]  NVARCHAR (50)  NULL,
    [ReferenceMobileNumber]   NVARCHAR (50)  NULL,
    [ReferenceLetterPath]     NVARCHAR (250) NULL,
    [ReferenceLetterMessage]  NTEXT          NULL,
    [ReferenceAcceptedPerson] BIT            NULL,
    [ReferenceInstitution]    NVARCHAR (150) NULL,
    CONSTRAINT [PK_PersonReference] PRIMARY KEY CLUSTERED ([PersonReferenceId] ASC)
);

