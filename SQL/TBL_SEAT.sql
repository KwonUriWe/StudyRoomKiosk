USE [StudyRoomKiosk]
GO

/****** Object:  Table [dbo].[TBL_SEAT]    Script Date: 2020-05-14 오후 7:25:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TBL_SEAT](
	[seatNo] [varchar](2) NOT NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_TBL_SEAT] PRIMARY KEY CLUSTERED 
(
	[seatNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


--좌석 추가 반복문
DECLARE @i INT
SET @i = 1

WHILE @i<= 24
    BEGIN
        INSERT INTO [StudyRoomKiosk].[dbo].[TBL_SEAT] VALUES(
            @i,
            0
        )
        SET @i = @i + 1
   END

