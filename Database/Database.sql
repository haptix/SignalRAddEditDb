
CREATE TABLE [dbo].[DevTest](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CampaignName] [varchar](255) NULL,
	[Date] [datetime] NULL,
	[Clicks] [int] NULL,
	[Impressions] [int] NULL,
	[AffiliateName] [varchar](255) NULL,
 CONSTRAINT [PK_DevTest] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


