USE [master]
GO

CREATE DATABASE [NationalCriminalDb]
GO

USE [NationalCriminalDb]
GO
/****** Object:  Table [dbo].[Criminal]    Script Date: 3/26/2017 7:49:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Criminal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Sex] [int] NOT NULL,
	[Weight] [decimal] NOT NULL,
	[Height] [decimal] NOT NULL,
	[Nationality] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_criminals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Criminal] ON 

INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (1, N'James', N'Butt', 34, 1, 67, 6, N'United States')
INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (3, N'Josephine', N'Darakjy', 67, 0, 45, 5, N'United States')
INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (4, N'Josephine', N'Darakjy', 67, 0, 45, 5, N'United States')
INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (5, N'Josephine', N'Darakjy', 67, 0, 45, 5, N'United States')
INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (6, N'Josephine', N'Darakjy', 67, 0, 45, 5, N'United States')
INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (7, N'Josephine', N'Darakjy', 67, 0, 45, 5, N'United States')
INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (8, N'Josephine', N'Darakjy', 67, 0, 45, 5, N'United States')
INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (9, N'Josephine', N'Darakjy', 67, 0, 45, 5, N'United States')
INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (10, N'Josephine', N'Darakjy', 67, 0, 45, 5, N'United States')
INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (11, N'Josephine', N'Darakjy', 67, 0, 45, 5, N'United States')
INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (12, N'Josephine', N'Darakjy', 67, 0, 45, 5, N'United States')
INSERT [dbo].[Criminal] ([Id], [FirstName], [LastName], [Age], [Sex], [Weight], [Height], [Nationality]) VALUES (13, N'Josephine', N'Darakjy', 67, 0, 45, 5, N'United States')
SET IDENTITY_INSERT [dbo].[Criminal] OFF
