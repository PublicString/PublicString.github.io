CREATE TABLE [dbo].[Position]
(
	[positionID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [positionType] TEXT NULL,
    [positionStartDate] DATE NULL, 
    [positionSalary] MONEY NULL, 
    [cvCriteria] TEXT NULL, 
    [interviewCriteria] TEXT NULL, 
    [generalCriteria] TEXT NULL, 
)
