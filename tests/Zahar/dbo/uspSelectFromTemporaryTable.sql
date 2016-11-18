CREATE PROCEDURE [dbo].[uspSelectFromTemporaryTable]
	@param1 int = 0,
	@param2 int
AS
	IF OBJECT_ID('tempdb..#SomeTempTable') IS NOT NULL DROP TABLE #SomeTempTable
	CREATE TABLE #SomeTempTable 
	(
		Id INT PRIMARY KEY IDENTITY(1, 1),
		Code NVARCHAR(75) NOT NULL
	)

	INSERT INTO #SomeTempTable (Code)
	VALUES ('Code 1'), ('Code 2')

	SELECT * FROM #SomeTempTable
	
	DROP TABLE #SomeTempTable
RETURN 0
