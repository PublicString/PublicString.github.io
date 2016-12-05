CREATE TABLE [dbo].[Application]
(
	[applicationID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [applicationType] TEXT NULL, 
    [applicationInformation] TEXT NULL
)
