CREATE TABLE [Organization].[ResearchChairs] (
    [ResearchChairId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (50)  NULL,
    [Description]     NVARCHAR (250) NULL,
    [Phone1]          NVARCHAR (20)  NULL,
    [Phone2]          NVARCHAR (20)  NULL,
    [Fax1]            NVARCHAR (20)  NULL,
    [Fax2]            NVARCHAR (20)  NULL,
    CONSTRAINT [PK_ResearchChairs] PRIMARY KEY CLUSTERED ([ResearchChairId] ASC)
);

