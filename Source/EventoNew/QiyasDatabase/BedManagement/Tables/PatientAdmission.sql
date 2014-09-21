CREATE TABLE [BedManagement].[PatientAdmission] (
    [PatientAdmissionId]  INT          IDENTITY (1, 1) NOT NULL,
    [AdmissionStartDate]  DATETIME     NULL,
    [DischargeDate]       DATETIME     NULL,
    [AdmissionStayTypeId] INT          NULL,
    [DischargeTypeId]     INT          NULL,
    [PatientCode]         NVARCHAR (8) NULL,
    [ConsultantId]        INT          NULL,
    [SpecialityId]        INT          NULL,
    [WardBedId]           INT          NULL,
    CONSTRAINT [PK_PatientAdmission] PRIMARY KEY CLUSTERED ([PatientAdmissionId] ASC)
);

