CREATE TABLE [ContentManagement].[Site] (
    [SiteId]                      INT              NOT NULL,
    [Name]                        NVARCHAR (50)    NULL,
    [IsActive]                    BIT              NULL,
    [TimeFormat]                  NVARCHAR (20)    NULL,
    [DateFormat]                  NVARCHAR (20)    NULL,
    [PostSize]                    INT              NULL,
    [DefaultSectionId]            INT              NULL,
    [DefaultCommentStatusId]      INT              NULL,
    [DefaultSecurityAccessTypeId] INT              NULL,
    [HomeNewsCount]               INT              NULL,
    [HomeEventsCount]             INT              NULL,
    [MasterPageTemplateId]        INT              NULL,
    [ShowFullTextArticles]        BIT              NULL,
    [AllowPostingComments]        BIT              NULL,
    [AllowAnonymousComments]      BIT              NULL,
    [RowGuid]                     UNIQUEIDENTIFIER CONSTRAINT [DF_Site_RowGuid] DEFAULT (newid()) ROWGUIDCOL NULL,
    [ModifiedDate]                DATETIME         CONSTRAINT [DF_Site_ModifiedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Site] PRIMARY KEY CLUSTERED ([SiteId] ASC),
    CONSTRAINT [FK_Site_ContentEntity] FOREIGN KEY ([SiteId]) REFERENCES [ContentManagement].[ContentEntity] ([ContentEntityId])
);

