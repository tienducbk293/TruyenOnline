USE [TruyenOnline]
GO
/****** Object:  Table [dbo].[Lists]    Script Date: 28/03/2018 12:56:10 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lists](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NameStory] [nvarchar](255) NOT NULL,
	[ChapterNumber] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stories]    Script Date: 28/03/2018 12:56:10 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDStory] [int] NOT NULL,
	[ChapNumber] [int] NOT NULL,
	[ChapName] [nvarchar](255) NOT NULL,
	[Content] [ntext] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Stories]  WITH CHECK ADD  CONSTRAINT [FK_Stories] FOREIGN KEY([IDStory])
REFERENCES [dbo].[Lists] ([ID])
GO
ALTER TABLE [dbo].[Stories] CHECK CONSTRAINT [FK_Stories]
GO
