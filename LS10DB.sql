USE [NhmK22CNT3LS10db]
GO
/****** Object:  Table [dbo].[NhmAccount]    Script Date: 7/3/2024 10:38:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhmAccount](
	[NhmID] [int] IDENTITY(1,1) NOT NULL,
	[NhmUserName] [nvarchar](50) NULL,
	[NhmPassword] [nvarchar](50) NULL,
	[NhmFullName] [nvarchar](50) NULL,
	[NhmEmail] [nvarchar](50) NULL,
	[NhmPhone] [nvarchar](50) NULL,
	[NhmActive] [bit] NULL,
 CONSTRAINT [PK_NhmAccount] PRIMARY KEY CLUSTERED 
(
	[NhmID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhmAccount] ON 

INSERT [dbo].[NhmAccount] ([NhmID], [NhmUserName], [NhmPassword], [NhmFullName], [NhmEmail], [NhmPhone], [NhmActive]) VALUES (1, N'MinhNgo', N'123a', N'Ngo Hoang Mnih', N'minhngo140924@gmail.com', N'0362252912', 1)
SET IDENTITY_INSERT [dbo].[NhmAccount] OFF
GO
