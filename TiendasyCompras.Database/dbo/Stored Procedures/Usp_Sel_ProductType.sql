CREATE PROCEDURE [dbo].[Usp_Sel_ProductType]
AS
BEGIN
	SELECT
		Id,
		Name
	FROM [dbo].[ProductType]
END
