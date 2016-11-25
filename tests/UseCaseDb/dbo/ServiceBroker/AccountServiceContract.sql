CREATE CONTRACT [http://ssb/contracts/account]
(
	[http://ssb/messages/create-account] SENT BY INITIATOR,
	[http://ssb/messages/delete-account] SENT BY INITIATOR,
	[http://ssb/messages/account-created] SENT BY TARGET,
	[http://ssb/messages/account-deleted] SENT BY TARGET
)
