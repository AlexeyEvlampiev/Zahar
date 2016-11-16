CREATE PROCEDURE [dbo].[uspEcho01]
	@param1 int = 0,
	@param2 int,
	@udtt01 [dbo].[Udtt01] READONLY,
	@output1 INT OUTPUT,
	@output2 INT OUTPUT
AS
	
	SELECT @param1 AS Param1, @param2 AS Param2

	SELECT * FROM @udtt01 AS tbl1

	SET @output1 = @param1
	SET @output2 = @param2

RETURN 0
