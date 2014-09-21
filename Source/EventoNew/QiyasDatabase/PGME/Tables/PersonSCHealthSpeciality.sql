CREATE TABLE [PGME].[PersonSCHealthSpeciality] (
    [PersonSCHealthSpecialityId] INT             IDENTITY (1, 1) NOT NULL,
    [PersonId]                   INT             NULL,
    [Score]                      DECIMAL (18, 2) NULL,
    [DateTaken]                  DATETIME        NULL,
    [LicensingNumber]            NVARCHAR (50)   NULL,
    [RegisterationNumber]        NVARCHAR (50)   NULL,
    CONSTRAINT [PK_PersonSCHealthSpeciality] PRIMARY KEY CLUSTERED ([PersonSCHealthSpecialityId] ASC)
);

