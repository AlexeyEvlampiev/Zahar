CREATE PROCEDURE [dbo].[uspEcho01]
	@FirstInputParameter int = 0,
	@SecondInputParameter int,
	@FirstTableValueParam [dbo].[Udtt01] READONLY,	
	@FirstOutputParameter INT OUTPUT,
	@SecondOutputParameter INT OUTPUT,
	@SecondTableValueParam [dbo].[Udtt02] READONLY
AS
	
	SELECT 
		@FirstInputParameter  AS Field1, 
		@SecondInputParameter AS Field2

	SELECT * FROM @FirstTableValueParam

	SET @FirstOutputParameter = @FirstInputParameter
	SET @SecondOutputParameter = @SecondInputParameter

	SELECT * FROM @SecondTableValueParam

RETURN (-123)
