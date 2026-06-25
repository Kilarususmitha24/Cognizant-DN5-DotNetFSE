SELECT
    OBJECT_NAME(object_id) AS TableName,
    index_id,
    avg_fragmentation_in_percent
FROM sys.dm_db_index_physical_stats
(
    DB_ID(),
    NULL,
    NULL,
    NULL,
    'LIMITED'
);