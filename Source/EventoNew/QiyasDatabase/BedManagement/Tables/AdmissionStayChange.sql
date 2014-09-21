CREATE TABLE [BedManagement].[AdmissionStayChange] (
    [AdmissionStayChangeId] INT      IDENTITY (1, 1) NOT NULL,
    [PatientAdmissionId]    INT      NULL,
    [AdmissionStayTypeId]   INT      NULL,
    [ModifiedDate]          DATETIME NULL,
    CONSTRAINT [PK_AdmissionStayChange] PRIMARY KEY CLUSTERED ([AdmissionStayChangeId] ASC)
);

