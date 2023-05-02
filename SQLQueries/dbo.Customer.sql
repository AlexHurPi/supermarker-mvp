CREATE TABLE [dbo].[Customer] (
    [Customer_Id]          INT           IDENTITY (100000, 1) NOT NULL,
    [Customer_Name]        NVARCHAR (50) NOT NULL,
    [Customer_Observation] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Customer_Id] ASC)
);

