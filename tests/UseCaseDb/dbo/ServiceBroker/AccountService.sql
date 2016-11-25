CREATE SERVICE [http://ssb/services/account]
	ON QUEUE [dbo].[AccountQueue]
	(
		[http://ssb/contracts/account]
	)
