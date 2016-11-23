CREATE PROCEDURE [dbo].[uspSelectFromTemporaryTable2]
	@param1 int = 0,
	@param2 int
AS
	IF OBJECT_ID('tempdb..#SomeTempTable2') IS NOT NULL DROP TABLE #SomeTempTable2
	CREATE TABLE #SomeTempTable2
	(
		Id INT PRIMARY KEY IDENTITY(1, 1),
		Code NVARCHAR(75) NOT NULL
	)

	INSERT INTO #SomeTempTable2 (Code)
	VALUES ('Code 1'), ('Code 2')

	SELECT * FROM #SomeTempTable2
	
	DROP TABLE #SomeTempTable2
RETURN 0
