USE [SchoolManagement]
GO
/****** Object:  Table [dbo].[Event_StudentMapping]    Script Date: 17-06-2021 16:30:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event_StudentMapping](
	[Event_StudentId] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NULL,
	[StudentId] [int] NULL,
 CONSTRAINT [PK_Event_StudentMapping] PRIMARY KEY CLUSTERED 
(
	[Event_StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 17-06-2021 16:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[EventId] [int] IDENTITY(1,1) NOT NULL,
	[EventName] [varchar](50) NULL,
	[EventDate] [datetime] NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 17-06-2021 16:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1000,1) NOT NULL,
	[StudentName] [varchar](100) NULL,
	[Gender] [char](2) NULL,
	[Email] [varchar](20) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserCredentails]    Script Date: 17-06-2021 16:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserCredentails](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[UserName] [varchar](20) NULL,
	[Password] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_UserCredentails] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Event_StudentMapping] ON 

INSERT [dbo].[Event_StudentMapping] ([Event_StudentId], [EventId], [StudentId]) VALUES (1, 1, 1000)
INSERT [dbo].[Event_StudentMapping] ([Event_StudentId], [EventId], [StudentId]) VALUES (2, 2, 1001)
INSERT [dbo].[Event_StudentMapping] ([Event_StudentId], [EventId], [StudentId]) VALUES (3, 1, 1002)
SET IDENTITY_INSERT [dbo].[Event_StudentMapping] OFF
GO
SET IDENTITY_INSERT [dbo].[Events] ON 

INSERT [dbo].[Events] ([EventId], [EventName], [EventDate]) VALUES (1, N'New Year Celebration', CAST(N'2021-12-31T00:00:00.000' AS DateTime))
INSERT [dbo].[Events] ([EventId], [EventName], [EventDate]) VALUES (2, N'Chritsmas', CAST(N'2021-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Events] ([EventId], [EventName], [EventDate]) VALUES (3, N'Cultural Events', CAST(N'2021-08-04T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Events] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [StudentName], [Gender], [Email], [IsActive], [CreatedDate], [ModifyDate]) VALUES (1000, N'Aadil', N'M ', N'testuser@test.com', 1, CAST(N'2021-06-17T15:49:47.057' AS DateTime), NULL)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Gender], [Email], [IsActive], [CreatedDate], [ModifyDate]) VALUES (1001, N'John', N'M ', N'john@test.com', 1, CAST(N'2021-06-17T15:51:10.483' AS DateTime), NULL)
INSERT [dbo].[Student] ([StudentId], [StudentName], [Gender], [Email], [IsActive], [CreatedDate], [ModifyDate]) VALUES (1002, N'Brandon', N'M ', N'brandon@test.com', 1, CAST(N'2021-06-17T15:51:37.573' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[UserCredentails] ON 

INSERT [dbo].[UserCredentails] ([UserId], [FirstName], [LastName], [UserName], [Password], [CreatedDate]) VALUES (1, N'John', N'Brandon', N'techsupport', N'123456', CAST(N'2021-06-16T17:09:07.080' AS DateTime))
INSERT [dbo].[UserCredentails] ([UserId], [FirstName], [LastName], [UserName], [Password], [CreatedDate]) VALUES (2, N'Sean', N'Aitken', N'sean001', N'123456', CAST(N'2021-06-16T17:09:07.080' AS DateTime))
SET IDENTITY_INSERT [dbo].[UserCredentails] OFF
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[UserCredentails] ADD  CONSTRAINT [DF_UserCredentails_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Event_StudentMapping]  WITH CHECK ADD  CONSTRAINT [FK_Event_StudentMapping_Events] FOREIGN KEY([EventId])
REFERENCES [dbo].[Events] ([EventId])
GO
ALTER TABLE [dbo].[Event_StudentMapping] CHECK CONSTRAINT [FK_Event_StudentMapping_Events]
GO
ALTER TABLE [dbo].[Event_StudentMapping]  WITH CHECK ADD  CONSTRAINT [FK_Event_StudentMapping_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[Event_StudentMapping] CHECK CONSTRAINT [FK_Event_StudentMapping_Student]
GO
/****** Object:  StoredProcedure [dbo].[AddStudent]    Script Date: 17-06-2021 16:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddStudent] @StudentName VARCHAR(100)
	,@Gender CHAR(2)
	,@Email VARCHAR(20)
	,@IsActive BIT = 1,
	 @EventId int
AS
INSERT INTO Student (
	StudentName
	,Gender
	,Email
	,IsActive
	)
VALUES (
	@StudentName
	,@Gender
	,@Email
	,@IsActive
	)

	 Declare @StudentId  int = SCOPE_IDENTITY()  
	--Declare @StudentId  int = (Select max(StudentId)+1 from Student)

insert into [dbo].[Event_StudentMapping] ([EventId] , [StudentId]) values(@EventId , @StudentId)

GO
/****** Object:  StoredProcedure [dbo].[GetEventParticipants]    Script Date: 17-06-2021 16:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetEventParticipants]
AS
SELECT st.StudentId
	,st.StudentName
	,ev.EventName
	,ev.EventDate
	,ev.EventId
FROM Student st
INNER JOIN [dbo].[Event_StudentMapping] stMapping ON st.StudentId = stMapping.StudentId
INNER JOIN Events ev ON ev.EventId = stMapping.EventId
GO
/****** Object:  StoredProcedure [dbo].[GetEvents]    Script Date: 17-06-2021 16:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	 PROCEDURE [dbo].[GetEvents]
AS
Select EventId , EventName from dbo.Events 

GO
