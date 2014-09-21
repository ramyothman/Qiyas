CREATE TABLE [Organization].[Sponsor] (
    [SponsorId]      INT            IDENTITY (1, 1) NOT NULL,
    [SponsorName]    NVARCHAR (50)  NULL,
    [SponsorAddress] NVARCHAR (250) NULL,
    [SponsorEmail]   NVARCHAR (150) NULL,
    [SponsorPhone]   NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Sponsor] PRIMARY KEY CLUSTERED ([SponsorId] ASC)
);

