USE [StudyRoomKiosk]
GO

/****** Object:  Table [dbo].[TBL_MEMBER]    Script Date: 2020-05-18 ¿ÀÈÄ 1:48:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TBL_MEMBER](
	[memberNo] [varchar](7) NOT NULL,
	[name] [varchar](20) NULL,
	[dateBirth] [varchar](6) NULL,
	[gender] [varchar](6) NULL,
	[newsAgency] [varchar](10) NULL,
	[phoneNum] [varchar](20) NULL,
	[expiredTime] [datetime] NULL,
	[seatNo] [int] NULL,
	[checkInDate] [datetime] NULL,
	[whether] [bit] NULL,
 CONSTRAINT [PK_TBL_MEMBER] PRIMARY KEY CLUSTERED 
(
	[memberNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[TBL_MEMBER]  WITH CHECK ADD  CONSTRAINT [FK_TBL_MEMBER_TBL_SEAT] FOREIGN KEY([seatNo])
REFERENCES [dbo].[TBL_SEAT] ([seatNo])
GO

ALTER TABLE [dbo].[TBL_MEMBER] CHECK CONSTRAINT [FK_TBL_MEMBER_TBL_SEAT]
GO


