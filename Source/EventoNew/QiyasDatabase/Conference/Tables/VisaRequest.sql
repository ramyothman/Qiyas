CREATE TABLE [Conference].[VisaRequest] (
    [VisaRequestID]          INT            IDENTITY (1, 1) NOT NULL,
    [ConferenceID]           INT            NULL,
    [PersonID]               INT            NULL,
    [Country]                NVARCHAR (50)  NULL,
    [City]                   NVARCHAR (50)  NULL,
    [Religion]               NVARCHAR (50)  NULL,
    [JobTitle]               NVARCHAR (50)  NULL,
    [Company]                NVARCHAR (50)  NULL,
    [PassportAttachment]     NVARCHAR (250) NULL,
    [IsOrganizationApproved] BIT            NULL,
    [IsTaken]                BIT            NULL,
    [VisaAttachment]         NVARCHAR (250) NULL,
    CONSTRAINT [PK_VisaRequest] PRIMARY KEY CLUSTERED ([VisaRequestID] ASC)
);

