USE [StudyRoomKiosk]
GO

/****** Object:  Table [dbo].[TBL_MEMBER]    Script Date: 2020-06-10 오후 5:19:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TBL_MEMBER](
	--회원 번호
	[memberNo] [int] NOT NULL,
	--회원 이름
	[name] [varchar](20) NULL,
	--회원생일
	[dateBirth] [varchar](6) NULL,
	--회원 성별
	[gender] [varchar](6) NULL,
	--회원 휴대폰 통신사
	[newsAgency] [varchar](10) NULL,
	--회원 휴대폰 번호
	[phoneNum] [varchar](20) NOT NULL,
	--서비스 종료 시간
	[expiredTime] [datetime] NULL,
	--선택 좌석 번호
	[seatNo] [int] NULL,
	--마지막 접속 날짜
	[checkInDate] [datetime] NULL,
	--비회원/정회원 여부
	[memberBool] [bit] NOT NULL,
 CONSTRAINT [PK_TBL_MEMBER_1] PRIMARY KEY CLUSTERED 
(
	[phoneNum] ASC
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


