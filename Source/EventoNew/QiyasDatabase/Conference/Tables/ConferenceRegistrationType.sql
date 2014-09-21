CREATE TABLE [Conference].[ConferenceRegistrationType] (
    [ConferenceRegistrationTypeId] INT             IDENTITY (1, 1) NOT NULL,
    [ConferenceId]                 INT             NULL,
    [Name]                         NVARCHAR (50)   NULL,
    [Fee]                          DECIMAL (18, 2) NULL,
    [GroupName]                    NVARCHAR (50)   NULL,
    [StartDate]                    DATETIME        NULL,
    [EndDate]                      DATETIME        NULL,
    [EarlyRegistrationEndDate]     DATETIME        NULL,
    [LateFee]                      DECIMAL (18, 2) NULL,
    [ConferenceScheduleID]         INT             NULL,
    [OfferStartDate]               DATETIME        NULL,
    [OfferEndDate]                 DATETIME        NULL,
    [OfferFee]                     DECIMAL (18, 2) NULL,
    [HaveOffer]                    BIT             NULL,
    [MustRegister]                 BIT             NULL,
    CONSTRAINT [PK_ConferenceRegistrationType] PRIMARY KEY CLUSTERED ([ConferenceRegistrationTypeId] ASC)
);

