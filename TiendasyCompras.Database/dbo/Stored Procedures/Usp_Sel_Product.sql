CREATE PROCEDURE [dbo].[Usp_Sel_Product]
AS
BEGIN
	SELECT
		P.Name,
		P.Description,
		PT.Name AS ProductType ,
		P.Brand,
		P.Price,
		P.Stock
	FROM [dbo].[Product] P 
	INNER JOIN [dbo].[ProductType] PT ON PT.Id=P.ProductTypeId
END