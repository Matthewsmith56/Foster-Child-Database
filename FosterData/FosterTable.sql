CREATE TABLE [dbo].[FosterTable]
(
	[Family ID]					INT		IDENTITY (1, 1) NOT NULL,
	[Foster Family Name]		NVARCHAR	(50)		NULL,
	[Type of Home]				NVARCHAR	(50)		NULL,
	[Number of Licensed Beds]	INT						NULL,
	[Number of Occupied Beds]	INT						NULL,
	[Number of Available Beds]	INT						NULL,
	[Minimum Age]				INT						NULL,
	[Maximum Age]				INT						NULL,
	[Gender Preferance]			NVARCHAR	(20)		NULL,
	[Managing Agency]			NVARCHAR	(20)		NULL,
	[Point of Contact]			NVARCHAR	(20)		NULL,
	[Comments]					NVARCHAR	(100)		NULL,
	PRIMARY KEY CLUSTERED ([Family ID] ASC)

)
