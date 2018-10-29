CREATE TABLE [dbo].[FosterTable]
(
	[Family ID]					INT		IDENTITY (1, 1) NOT NULL,
	[Foster Family Name]		NVARCHAR	(50)		NULL,
	[Type of Home]				NVARCHAR	(50)		NULL,
	[Licensed Beds]				INT						NOT NULL, CHECK ([Licensed Beds]  >= 0),
	[Occupied Beds]				INT						NOT NULL, CHECK ([Occupied Beds]  <= [Licensed Beds]),
	[Available Beds]			INT						NOT NULL, CHECK ([Available Beds] <= [Licensed Beds]),
	[Min Age]					INT						NOT NULL, CHECK ([Min Age]		  >= 0),
	[Max Age]					INT						NOT NULL, CHECK ([Max Age]		  <= 18),
	[Gender Preferance]			NVARCHAR	(20)		NULL,
	[Managing Agency]			NVARCHAR	(20)		NULL,
	[Point of Contact]			NVARCHAR	(20)		NULL,
	[Comments]					NVARCHAR	(100)		NULL,
	PRIMARY KEY CLUSTERED ([Family ID] ASC)
)
