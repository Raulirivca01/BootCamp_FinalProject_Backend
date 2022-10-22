 CREATE PROC [dbo].[Usp_Ins_Product]
 (@Name VARCHAR(50),
  @Description VARCHAR(100),
  @ProductTypeId INT,
  @Brand VARCHAR(50),
  @Price VARCHAR(50),
  @Stock INT)
  AS
  BEGIN
	
	INSERT INTO [dbo].[Product]
	(Name,Description,ProductTypeId,Brand,Price,Stock) 
	VALUES 
	(@Name,@Description,@ProductTypeId,@Brand,@Price,@Stock)

  END