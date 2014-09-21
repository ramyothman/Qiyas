CREATE TABLE [PGME].[PersonPGMERegisteration] (
    [PersonRegisterationId]       INT           IDENTITY (1, 1) NOT NULL,
    [PersonId]                    INT           NULL,
    [PersonProgramId]             INT           NULL,
    [PersonRegisterationStatusId] INT           NULL,
    [RegisterationNumber]         NVARCHAR (50) NULL,
    [UniRegisterationNumber]      NVARCHAR (50) NULL,
    CONSTRAINT [PK_PersonPGMERegisteration] PRIMARY KEY CLUSTERED ([PersonRegisterationId] ASC)
);

