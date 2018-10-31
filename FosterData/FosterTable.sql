CREATE TABLE [dbo].[FosterTable]
(
	[Family ID]					INT		IDENTITY (1, 1) NOT NULL,
	[Foster Family]				NVARCHAR	(50)		NULL,
	[Type of Home]				NVARCHAR	(50)		NULL,
	[Licensed Beds]				INT						NULL, --CHECK ([Licensed Beds]  >= 0),
	[Occupied Beds]				INT						NULL, --CHECK ([Occupied Beds]  <= [Licensed Beds]),
	[Available Beds]			INT						NULL, --CHECK ([Available Beds] <= [Licensed Beds]),
	[Min Age]					INT						NULL, --CHECK ([Min Age]		  >= 0),
	[Max Age]					INT						NULL, --CHECK ([Max Age]		  <= 18),
	[Preferred Gender]			NVARCHAR	(20)		NULL,
	[Agency]					NVARCHAR	(20)		NULL,
	[POC]						NVARCHAR	(50)		NULL,
	[Comments]					NVARCHAR	(100)		NULL,
	PRIMARY KEY CLUSTERED ([Family ID] ASC)
)
