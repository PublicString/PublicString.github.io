CREATE TABLE [dbo].[Applicant]
(
	[applicantID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [title] TEXT NULL, 
    [firstName] TEXT NULL, 
    [lastName] TEXT NULL,
	[emailAddress] UNIQUEIDENTIFIER NOT NULL,
	[applicantType] TEXT NULL,
	[positionType] TEXT NULL
)
