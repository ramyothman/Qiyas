CREATE TABLE [PGME].[PersonRegisterationStatus] (
    [PersonRegisterationStatusId] INT           IDENTITY (1, 1) NOT NULL,
    [Status]                      NVARCHAR (50) NULL,
    CONSTRAINT [PK_PersonRegisterationStatus] PRIMARY KEY CLUSTERED ([PersonRegisterationStatusId] ASC)
);

