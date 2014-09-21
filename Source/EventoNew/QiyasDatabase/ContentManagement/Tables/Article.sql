CREATE TABLE [ContentManagement].[Article] (
    [ArticleId]                 INT              NOT NULL,
    [SiteSectionId]             INT              NULL,
    [CreatorId]                 INT              NULL,
    [ArticleStatusId]           INT              NULL,
    [AuthorId]                  INT              NULL,
    [PostDate]                  DATETIME         NULL,
    [AllowLanguageSpecificTags] BIT              NULL,
    [RowGuid]                   UNIQUEIDENTIFIER CONSTRAINT [DF_Article_RowGuid] DEFAULT (newid()) ROWGUIDCOL NULL,
    [ModifiedDate]              DATETIME         CONSTRAINT [DF_Article_ModifiedDate] DEFAULT (getdate()) NULL,
    [CommentsTypeId]            INT              NULL,
    [EnableModeteration]        BIT              NULL,
    CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED ([ArticleId] ASC),
    CONSTRAINT [FK_Article_ArticleStatus] FOREIGN KEY ([ArticleStatusId]) REFERENCES [ContentManagement].[ArticleStatus] ([ArticleStatusId]),
    CONSTRAINT [FK_Article_CommentType] FOREIGN KEY ([CommentsTypeId]) REFERENCES [ContentManagement].[CommentType] ([CommentTypeId]),
    CONSTRAINT [FK_Article_ContentEntity] FOREIGN KEY ([ArticleId]) REFERENCES [ContentManagement].[ContentEntity] ([ContentEntityId]),
    CONSTRAINT [FK_Article_Person] FOREIGN KEY ([CreatorId]) REFERENCES [Person].[Person] ([BusinessEntityId]),
    CONSTRAINT [FK_Article_Person1] FOREIGN KEY ([AuthorId]) REFERENCES [Person].[Person] ([BusinessEntityId]),
    CONSTRAINT [FK_Article_SiteSection] FOREIGN KEY ([SiteSectionId]) REFERENCES [ContentManagement].[SiteSection] ([SiteSectionId]) ON DELETE CASCADE ON UPDATE CASCADE
);

