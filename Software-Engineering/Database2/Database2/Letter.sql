CREATE TABLE [dbo].[Letter]
(
	[letterID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [acceptanceTemplate] TEXT NULL, 
    [rejectionTemplate] TEXT NULL
)
