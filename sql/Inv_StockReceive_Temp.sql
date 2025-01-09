USE [EDCL_Dhaka]
GO

/****** Object:  Table [dbo].[Inv_StockReceive_Temp]    Script Date: 11/27/2024 1:07:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Inv_StockReceive_Temp](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ChallanNo] [nvarchar](50) NULL,
	[BOMNo] [nvarchar](50) NULL,
	[ChallanDate] [datetime] NULL,
	[ChallanRef] [nvarchar](50) NULL,
	[PortId] [int] NULL,
	[PoType] [nvarchar](200) NULL,
	[PoRefNo] [nvarchar](50) NULL,
	[JobNo] [nvarchar](50) NULL,
	[ProductGroup] [int] NULL,
	[ProductId] [int] NULL,
	[UnitId] [int] NULL,
	[Qty] [float] NULL,
	[Currency] [nvarchar](50) NULL,
	[Rate] [float] NULL,
	[Total] [float] NULL,
	[ConvRate] [float] NULL,
	[TotalConvAmount] [float] NULL,
	[CDPer] [float] NULL,
	[CDValue] [float] NULL,
	[RDPer] [float] NULL,
	[RDValue] [float] NULL,
	[AITPer] [float] NULL,
	[AITValue] [float] NULL,
	[ATPer] [float] NOT NULL,
	[ATValue] [float] NULL,
	[SD_Rate] [float] NULL,
	[SD] [float] NULL,
	[VAT_Rate] [float] NULL,
	[VAT] [float] NULL,
	[RebatePer] [float] NULL,
	[Rebate] [float] NULL,
	[TotalPriceIncVAT] [float] NULL,
	[StockOpiningBalance] [float] NULL,
	[StockOpiningBalValue] [float] NULL,
	[StockClosinigBalance] [float] NULL,
	[StockClosinigBalValue] [float] NULL,
	[Barcode] [nvarchar](50) NULL,
	[SupplierId] [int] NULL,
	[SupplierLedgerCode] [nvarchar](50) NULL,
	[PurchaseLedgerCode] [nvarchar](50) NULL,
	[StoreId] [int] NULL,
	[VDS_Applicable] [bit] NULL,
	[VAT_AccountCode] [nvarchar](50) NULL,
	[Create_User] [uniqueidentifier] NULL,
	[Create_Date] [datetime] NULL,
	[Edit_User] [uniqueidentifier] NULL,
	[Edit_Date] [datetime] NULL,
	[OCode] [nvarchar](50) NULL,
	[BatchNo] [nvarchar](50) NULL,
	[HSCODE] [nvarchar](50) NULL,
	[BillofEntryDate] [date] NULL,
	[VATStatus] [bit] NOT NULL,
	[Remarks] [nvarchar](20) NULL,
	[ActualQty] [float] NULL,
	[FreeQty] [float] NULL,
	[ATVPer] [float] NULL,
	[ATVValue] [float] NULL,
	[BankId] [int] NULL,
	[PurchaseType] [nvarchar](50) NULL,
	[BankAccountsId] [int] NULL,
 CONSTRAINT [PK_Inv_StockReceive_Temp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_Rate]  DEFAULT ((0)) FOR [Rate]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_Total]  DEFAULT ((0)) FOR [Total]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_ConvRate]  DEFAULT ((0)) FOR [ConvRate]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_TotalConvAmount]  DEFAULT ((0)) FOR [TotalConvAmount]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_CDPer]  DEFAULT ((0)) FOR [CDPer]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_CDValue]  DEFAULT ((0)) FOR [CDValue]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_RDPer]  DEFAULT ((0)) FOR [RDPer]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_RDValue]  DEFAULT ((0)) FOR [RDValue]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_ATPer]  DEFAULT ((0)) FOR [ATPer]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_ATValue]  DEFAULT ((0)) FOR [ATValue]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_SD_Rate]  DEFAULT ((0)) FOR [SD_Rate]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_SD]  DEFAULT ((0)) FOR [SD]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_VAT_Rate]  DEFAULT ((0)) FOR [VAT_Rate]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_VAT]  DEFAULT ((0)) FOR [VAT]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_RebatePer]  DEFAULT ((0)) FOR [RebatePer]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_Rebate]  DEFAULT ((0.0)) FOR [Rebate]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_TotalPriceIncVAT]  DEFAULT ((0)) FOR [TotalPriceIncVAT]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_StockOpiningBalance]  DEFAULT ((0)) FOR [StockOpiningBalance]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_StockOpiningBalValue]  DEFAULT ((0)) FOR [StockOpiningBalValue]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_StockClosinigBalance]  DEFAULT ((0)) FOR [StockClosinigBalance]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  CONSTRAINT [DF_Inv_StockReceive_Temp_StockClosinigBalValue]  DEFAULT ((0)) FOR [StockClosinigBalValue]
GO

ALTER TABLE [dbo].[Inv_StockReceive_Temp] ADD  DEFAULT ((1)) FOR [VATStatus]
GO

Select * From Inv_StockReceive_Temp;
Go


