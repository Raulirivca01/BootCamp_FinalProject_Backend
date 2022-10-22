CREATE PROC [dbo].[Usp_Upd_Product]
 (@Id INT,
  @Name VARCHAR(50),
  @Description VARCHAR(100),
  @ProductTypeId INT,
  @Brand VARCHAR(50),
  @Price VARCHAR(50),
  @Stock INT)
 AS
 BEGIN

	UPDATE [dbo].[Product] SET
		Name = @Name,
		Description = @Description,
		ProductTypeId = @ProductTypeId,
		Brand = @Brand,
		Price = @Price,
		Stock=@Stock
	WHERE Id = @Id

 END