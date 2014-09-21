CREATE TABLE [Organization].[SponsorCategory] (
    [SponsorCategoryId] INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName]      NVARCHAR (50) NULL,
    CONSTRAINT [PK_SponsorCategory] PRIMARY KEY CLUSTERED ([SponsorCategoryId] ASC)
);

