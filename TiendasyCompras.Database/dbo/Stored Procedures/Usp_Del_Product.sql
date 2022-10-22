 CREATE PROC [dbo].[Usp_Del_Product]
 (@Id INT)
 AS
 BEGIN

	DELETE FROM [dbo].[Product]
	WHERE Id = @Id

 END