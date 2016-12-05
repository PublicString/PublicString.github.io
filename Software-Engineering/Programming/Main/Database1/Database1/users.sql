CREATE TABLE [dbo].[users]
(
	[user_id] INT NOT NULL PRIMARY KEY, 
    [user_username] NCHAR(40) NOT NULL, 
    [user_password] NCHAR(20) NOT NULL, 
    [user_rights] INT NOT NULL DEFAULT 0
)
