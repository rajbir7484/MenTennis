SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (1, N'Serbia')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (2, N'Spain')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (3, N'Russia')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (4, N'Austria')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (5, N'Greece')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (6, N'Switzerland')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (7, N'Germany')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (8, N'Argentina')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (9, N'Italy')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (10, N'France')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (11, N'Canada')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (12, N'Belgium')
GO
INSERT [dbo].[Countries] ([Id], [CountryName]) VALUES (13, N'Brazil')
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[MensRankings] ON 
GO
INSERT [dbo].[MensRankings] ([Id], [PlayerName], [Points], [CountryId]) VALUES (1, N'Novak Djokovic', 12030, 1)
GO
INSERT [dbo].[MensRankings] ([Id], [PlayerName], [Points], [CountryId]) VALUES (2, N'Rafael Nadal', 9850, 2)
GO
INSERT [dbo].[MensRankings] ([Id], [PlayerName], [Points], [CountryId]) VALUES (3, N'Daniil Medvedev', 9735, 3)
GO
INSERT [dbo].[MensRankings] ([Id], [PlayerName], [Points], [CountryId]) VALUES (4, N'Dominic Thiem', 9125, 4)
GO
INSERT [dbo].[MensRankings] ([Id], [PlayerName], [Points], [CountryId]) VALUES (5, N'Stefanos Tsitsipas', 6660, 5)
GO
INSERT [dbo].[MensRankings] ([Id], [PlayerName], [Points], [CountryId]) VALUES (6, N'Roger Federer', 6630, 6)
GO
INSERT [dbo].[MensRankings] ([Id], [PlayerName], [Points], [CountryId]) VALUES (7, N'Alexander Zverev', 5615, 7)
GO
INSERT [dbo].[MensRankings] ([Id], [PlayerName], [Points], [CountryId]) VALUES (8, N'Andrey Rublev', 5019, 3)
GO
INSERT [dbo].[MensRankings] ([Id], [PlayerName], [Points], [CountryId]) VALUES (9, N'Diego Schwartzman', 3640, 8)
GO
INSERT [dbo].[MensRankings] ([Id], [PlayerName], [Points], [CountryId]) VALUES (10, N'Matteo Berrettini', 3480, 9)
GO
SET IDENTITY_INSERT [dbo].[MensRankings] OFF
GO
SET IDENTITY_INSERT [dbo].[Schedules] ON 
GO
INSERT [dbo].[Schedules] ([Id], [Tournament], [Dates], [Host], [DefendingChampion], [CountryId]) VALUES (1, N'Open 13 Provence', N'Mar 8-15', N'Marseille, France', N'Stefanos Tsitsipas', 5)
GO
INSERT [dbo].[Schedules] ([Id], [Tournament], [Dates], [Host], [DefendingChampion], [CountryId]) VALUES (2, N'Chile Dove Men+Care Open', N'Mar 8-15', N'Santiago, Chile', N'Thiago Seyboth Wild', 13)
GO
INSERT [dbo].[Schedules] ([Id], [Tournament], [Dates], [Host], [DefendingChampion], [CountryId]) VALUES (3, N'Qatar ExxonMobil Open', N'Mar 8-14', N'Doha, Qatar', N'Andrey Rublev', 3)
GO
INSERT [dbo].[Schedules] ([Id], [Tournament], [Dates], [Host], [DefendingChampion], [CountryId]) VALUES (4, N'Dubai Duty Free Tennis Championships', N'Mar 15-21', N'Dubai, UAE', N'Novak Djokovic', 1)
GO
INSERT [dbo].[Schedules] ([Id], [Tournament], [Dates], [Host], [DefendingChampion], [CountryId]) VALUES (5, N'French Open', N'May 23-Jun 7', N'Paris, France', N'Rafael Nadal', 2)
GO
SET IDENTITY_INSERT [dbo].[Schedules] OFF
GO
SET IDENTITY_INSERT [dbo].[GrandWinners] ON 
GO
INSERT [dbo].[GrandWinners] ([Id], [Tournament], [WinnerName], [RunnerUp], [Year]) VALUES (1, N'Australian Open', N'Novak Djokovic', N'Daniil Medvedev', 2021)
GO
INSERT [dbo].[GrandWinners] ([Id], [Tournament], [WinnerName], [RunnerUp], [Year]) VALUES (2, N'French Open', N'Rafael Nadal', N'Novak Djokovic', 2020)
GO
INSERT [dbo].[GrandWinners] ([Id], [Tournament], [WinnerName], [RunnerUp], [Year]) VALUES (3, N'U.S. Open', N'Dominic Thiem', N'Alexander Zverev', 2020)
GO
INSERT [dbo].[GrandWinners] ([Id], [Tournament], [WinnerName], [RunnerUp], [Year]) VALUES (4, N'Australian Open', N'Novak Djokovic', N'Dominic Thiem', 2020)
GO
INSERT [dbo].[GrandWinners] ([Id], [Tournament], [WinnerName], [RunnerUp], [Year]) VALUES (5, N'U.S. Open', N'Rafael Nadal', N'Daniil Medvedev', 2019)
GO
INSERT [dbo].[GrandWinners] ([Id], [Tournament], [WinnerName], [RunnerUp], [Year]) VALUES (6, N'Wimbledon', N'Novak Djokovic', N'Roger Federer', 2019)
GO
SET IDENTITY_INSERT [dbo].[GrandWinners] OFF
GO
