CREATE TABLE [dbo].[Provider] (
    [Provider_Id]          INT           IDENTITY (100000, 1) NOT NULL,
    [Provider_Name]        NVARCHAR (50) NOT NULL,
    [Provider_Observation] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Provider_Id] ASC)
);

