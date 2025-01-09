USE [EDCL_Dhaka]
GO

/****** Object:  Table [dbo].[Inv_StockSalesTemp]    Script Date: 12/8/2024 11:05:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Inv_StockSalesTemp](
	[SalesTempId] [bigint] IDENTITY(1,1) NOT NULL,
	[Invoice] [nvarchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
	[BINNo] [nvarchar](50) NULL,
	[CustomerID] [bigint] NULL,
	[LadgerCode] [nvarchar](50) NULL,
	[StoreId] [int] NULL,
	[ItemId] [bigint] NOT NULL,
	[Qty] [float] NOT NULL,
	[Price] [numeric](22, 4) NOT NULL,
	[Total] [numeric](22, 4) NOT NULL,
	[ItemDiscountAmt] [numeric](22, 9) NOT NULL,
	[SDPercentage] [numeric](18, 2) NOT NULL,
	[SDAmount] [numeric](22, 9) NOT NULL,
	[ItemVatPer] [numeric](18, 2) NOT NULL,
	[FixedVATRate] [numeric](18, 2) NOT NULL,
	[ItemVat] [numeric](22, 9) NOT NULL,
	[NetTotal] [numeric](22, 9) NOT NULL,
	[InvoiceAmount] [numeric](22, 9) NOT NULL,
	[SalesType] [nvarchar](50) NULL,
	[NatureOfSupply] [nvarchar](70) NULL,
	[DeliveryPoint_Id] [bigint] NULL,
	[Remarks] [nvarchar](250) NULL,
	[OCODE] [nvarchar](10) NULL,
	[Create_User] [uniqueidentifier] NULL,
	[Create_Date] [datetime] NULL,
	[Edit_User] [uniqueidentifier] NULL,
	[Edit_Date] [datetime] NULL,
	[VehicleType_Id] [int] NULL,
	[VehicleNo] [nvarchar](100) NULL,
	[DiscountPercent] [float] NOT NULL,
	[ItemRateDiscPercent] [float] NOT NULL,
	[PO_RefNo] [varchar](50) NULL,
 CONSTRAINT [PK_Inv_StockSalesTemp] PRIMARY KEY CLUSTERED 
(
	[SalesTempId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF_Inv_StockSalesTemp_Qty]  DEFAULT ((0)) FOR [Qty]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF_Inv_StockSalesTemp_Price]  DEFAULT ((0)) FOR [Price]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF_Inv_StockSalesTemp_Total]  DEFAULT ((0)) FOR [Total]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF_Inv_StockSalesTemp_ItemDiscountAmt]  DEFAULT ((0)) FOR [ItemDiscountAmt]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF_Inv_StockSalesTemp_SDPercentage]  DEFAULT ((0)) FOR [SDPercentage]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF_Inv_StockSalesTemp_SDAmount]  DEFAULT ((0)) FOR [SDAmount]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF_Inv_StockSalesTemp_ItemVatPer]  DEFAULT ((0)) FOR [ItemVatPer]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF_Inv_StockSalesTemp_FixedVATRate]  DEFAULT ((0)) FOR [FixedVATRate]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF_Inv_StockSalesTemp_ItemVat]  DEFAULT ((0)) FOR [ItemVat]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF_Inv_StockSalesTemp_NetTotal]  DEFAULT ((0)) FOR [NetTotal]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF_Inv_StockSalesTemp_InvoiceAmount]  DEFAULT ((0)) FOR [InvoiceAmount]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF__Inv_Stock__Disco__5CF928C1]  DEFAULT ((0)) FOR [DiscountPercent]
GO

ALTER TABLE [dbo].[Inv_StockSalesTemp] ADD  CONSTRAINT [DF__Inv_Stock__ItemR__1631A61D]  DEFAULT ((0)) FOR [ItemRateDiscPercent]
GO


Select * From Inv_StockSalesTemp;
go

