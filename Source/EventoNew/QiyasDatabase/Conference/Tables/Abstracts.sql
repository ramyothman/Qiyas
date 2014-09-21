﻿CREATE TABLE [Conference].[Abstracts] (
    [AbstractId]           INT             IDENTITY (1, 1) NOT NULL,
    [PersonId]             INT             NULL,
    [ConferenceId]         INT             NULL,
    [ConferenceCategoryId] INT             NULL,
    [AbstractTitle]        NVARCHAR (500)  NULL,
    [AbstractIntro]        NTEXT           NULL,
    [AbstractAuthors]      NVARCHAR (4000) NULL,
    [CoverLetter]          NTEXT           NULL,
    [IsAccepted]           BIT             NULL,
    [AcceptanceType]       NVARCHAR (50)   NULL,
    [PresentationPath]     NVARCHAR (500)  NULL,
    [PosterPath]           NVARCHAR (500)  NULL,
    [Topic]                NVARCHAR (250)  NULL,
    [Background]           NTEXT           NULL,
    [Methods]              NTEXT           NULL,
    [Results]              NTEXT           NULL,
    [Conclusions]          NTEXT           NULL,
    [AbstractTerms]        NTEXT           NULL,
    [AbstractKeywords]     NVARCHAR (500)  NULL,
    [DocumentPath1]        NVARCHAR (250)  NULL,
    [DocumentPath2]        NVARCHAR (250)  NULL,
    [DocumentPath3]        NVARCHAR (250)  NULL,
    [RevisionNumber]       INT             NULL,
    [ParentID]             INT             NULL,
    [AbstractStatusId]     INT             NULL,
    [CreatedDate]          DATETIME        CONSTRAINT [DF_Abstracts_CreatedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Abstracts] PRIMARY KEY CLUSTERED ([AbstractId] ASC),
    CONSTRAINT [FK_Abstracts_AbstractStatus] FOREIGN KEY ([AbstractStatusId]) REFERENCES [Conference].[AbstractStatus] ([AbstractStatusId])
);
