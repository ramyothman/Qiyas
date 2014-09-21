CREATE TABLE [Conference].[TransportationType] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [TypeName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TransportationType] PRIMARY KEY CLUSTERED ([ID] ASC)
);

