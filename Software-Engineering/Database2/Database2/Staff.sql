CREATE TABLE [dbo].[Staff]
(
	[staffID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [title] TEXT NOT NULL, 
    [firstName] TEXT NULL, 
    [lastName] TEXT NULL, 
    [role] TEXT NOT NULL, 
    [emailAddress] UNIQUEIDENTIFIER NOT NULL
)
