CREATE TABLE [dbo].[Sell] (
    [Sell_Id]          INT           IDENTITY (100000, 1) NOT NULL,
    [Sell_Customer_id] INT           NOT NULL,
    [Sell_Total]       INT           NOT NULL,
    [Sell_Pay_Mode]    NVARCHAR (50) NOT NULL,
    [Sell_Observation] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Sell_Id] ASC)
);

