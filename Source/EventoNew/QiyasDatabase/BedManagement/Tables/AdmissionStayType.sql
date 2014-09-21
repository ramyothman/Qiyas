CREATE TABLE [BedManagement].[AdmissionStayType] (
    [AdmissionStayTypeId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]                NVARCHAR (250) NULL,
    [Duration]            INT            NULL,
    [Code]                NVARCHAR (5)   NULL,
    [AdmissionStayOrder]  INT            NULL,
    CONSTRAINT [PK_AdmissionStayType] PRIMARY KEY CLUSTERED ([AdmissionStayTypeId] ASC)
);

