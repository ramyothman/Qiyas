﻿CREATE TABLE [HumanResources].[Employees] (
    [EmployeeId]       INT              NOT NULL,
    [EmployeeNumber]   NVARCHAR (50)    NULL,
    [DepartmentId]     INT              NULL,
    [DivisionId]       INT              NULL,
    [FormalSiteUrl]    NVARCHAR (250)   NULL,
    [NationalIdNumber] NVARCHAR (50)    NULL,
    [NationalIdType]   NCHAR (1)        NULL,
    [ManagerId]        INT              NULL,
    [BirthDate]        DATETIME         NULL,
    [MaritalStatus]    NCHAR (1)        NULL,
    [Gender]           NCHAR (1)        NULL,
    [HireDate]         DATETIME         NULL,
    [SalariedFlag]     BIT              NULL,
    [VacationHours]    SMALLINT         NULL,
    [SickLeaveHours]   SMALLINT         NULL,
    [CurrentFlag]      BIT              NULL,
    [RowGuid]          UNIQUEIDENTIFIER CONSTRAINT [DF_Employees_RowGuid] DEFAULT (newid()) ROWGUIDCOL NULL,
    [ModifiedDate]     DATETIME         NULL,
    [Position]         NVARCHAR (150)   NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([EmployeeId] ASC),
    CONSTRAINT [FK_Employees_Departments] FOREIGN KEY ([DepartmentId]) REFERENCES [HumanResources].[Departments] ([DepartmentId]),
    CONSTRAINT [FK_Employees_Divisions] FOREIGN KEY ([DivisionId]) REFERENCES [HumanResources].[Divisions] ([DivisionId]),
    CONSTRAINT [FK_Employees_Employees] FOREIGN KEY ([ManagerId]) REFERENCES [HumanResources].[Employees] ([EmployeeId]),
    CONSTRAINT [FK_Employees_Person] FOREIGN KEY ([EmployeeId]) REFERENCES [Person].[Person] ([BusinessEntityId]) ON DELETE CASCADE ON UPDATE CASCADE
);
