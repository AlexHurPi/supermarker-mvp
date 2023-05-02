CREATE TABLE [dbo].[Purchase] (
    [Purchase_Id]          INT            IDENTITY (100000, 1) NOT NULL,
    [Provider_Id]          NVARCHAR (50)  NOT NULL,
    [Purchase_ProductId]   INT            NOT NULL,
    [Purchase_Pay_Mode]    NVARCHAR (50)  NOT NULL,
    [Total_Purchase]       INT            NOT NULL,
    [Purchase_Observation] NVARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([Purchase_Id] ASC)
);

