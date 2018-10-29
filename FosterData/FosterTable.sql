CREATE TABLE [dbo].[FosterTable]
(
	[Family ID]					INT		IDENTITY (1, 1) NOT NULL,
	[Foster Family Name]		NVARCHAR	(50)		NULL,
	[Type of Home]				NVARCHAR	(50)		NULL,
	[Licensed Beds]				INT						NULL,
	[Occupied Beds]				INT						NULL,
	[Available Beds]			INT						NULL,
	[Min Age]					INT						NULL,
	[Max Age]					INT						NULL,
	[Gender Preferance]			NVARCHAR	(20)		NULL,
	[Managing Agency]			NVARCHAR	(20)		NULL,
	[Point of Contact]			NVARCHAR	(20)		NULL,
	[Comments]					NVARCHAR	(100)		NULL,
	PRIMARY KEY CLUSTERED ([Family ID] ASC)

)
