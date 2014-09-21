CREATE TABLE [BedManagement].[DischargeType] (
    [DischargeTypeId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (250) NULL,
    [DischargeCode]   NVARCHAR (5)   NULL,
    [DischargeOrder]  INT            NULL,
    CONSTRAINT [PK_DischargeType] PRIMARY KEY CLUSTERED ([DischargeTypeId] ASC)
);

