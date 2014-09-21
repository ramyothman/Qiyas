CREATE TABLE [Conference].[Travel] (
    [ID]                   INT            IDENTITY (1, 1) NOT NULL,
    [Name]                 NVARCHAR (50)  NULL,
    [TransportationTypeID] INT            NULL,
    [Description]          NVARCHAR (200) NULL,
    [ConferenceID]         INT            NULL,
    CONSTRAINT [PK_Travel] PRIMARY KEY CLUSTERED ([ID] ASC)
);

