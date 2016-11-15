SELECT 
	s.[Name],
	(
		SELECT p.[name] AS [Name], QUOTENAME(s.[name]) + '.' + QUOTENAME(p.[name]) AS [FullName]
		FROM sys.procedures AS p
		WHERE p.schema_id = s.schema_id
		AND p.is_ms_shipped = 0
		FOR XML RAW('Procedure'), TYPE
	)
FROM sys.schemas AS s
WHERE s.[name] NOT IN (
	'db_accessadmin'
	,'db_backupoperator'
	,'db_datareader'
	,'db_datawriter'
	,'db_ddladmin'
	,'db_denydatareader'
	,'db_denydatawriter'
	,'db_owner'
	,'db_securityadmin'
	,'guest'
	,'INFORMATION_SCHEMA'
	,'sys')
ORDER BY s.[name]
FOR XML RAW('Schema'), ROOT('Catalog')

