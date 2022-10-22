CREATE PROCEDURE [dbo].[Usp_Sel_Product_ById]
(@Id INT)
AS
BEGIN
	SELECT
		P.Name,
		P.Description,
		PT.Name,
		P.Brand,
		P.Price,
		P.Stock
	FROM [dbo].[Product] P 
	INNER JOIN [dbo].[ProductType] PT ON PT.Id=P.ProductTypeId
	WHERE P.Id=@Id
END