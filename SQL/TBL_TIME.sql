USE [StudyRoomKiosk]
GO

/****** Object:  Table [dbo].[TBL_TIME]    Script Date: 2020-05-14 오후 7:25:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TBL_TIME](
	[timeUse] [varchar](10) NOT NULL,
	[amount] [int] NOT NULL,
 CONSTRAINT [PK_TBL_TIME] PRIMARY KEY CLUSTERED 
(
	[timeUse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--시간 추가
  INSERT INTO [StudyRoomKiosk].[dbo].[TBL_TIME] VALUES
		('2시간', 3000),
		('3시간', 4000),
		('5시간', 6000),
		('7시간', 8000),
		('9시간', 10000),
		('종일', 12000),
		('1일', 27000),
		('3일', 43000),
		('5일', 56000),
		('1주', 84000),
		('2주', 130000),
		('8주', 240000)

  --장기 구분을 위해 추가
  ALTER TABLE [StudyRoomKiosk].[dbo].[TBL_TIME] ADD status bit ;
  UPDATE [StudyRoomKiosk].[dbo].[TBL_TIME] SET [statuse] = 'true' where timeUse like '%일' or timeUse like '%주'  ;
  UPDATE [StudyRoomKiosk].[dbo].[TBL_TIME] SET [statuse] = 'false' where timeUse like '%시간';