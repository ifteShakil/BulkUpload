TRUNCATE TABLE Inv_StockReceive_Temp

select * from Inv_StockReceive_Temp

select * from Inv_TransactionID
select * from Inv_StockReceive ORDER BY iD DESC
SELECT * FROM Inv_Supplier WHERE SupplierType = 'Foreign' AND iD=2130
UPDATE Inv_Supplier SET SupplierType = 'Foreign' WHERE iD=2130
SELECT SupplierType,* FROM Inv_Supplier WHERE  iD=2130


select * from Inv_StockReceive
GO

TRUNCATE TABLE Inv_StockSalesTemp

select * from Inv_StockSalesTemp
