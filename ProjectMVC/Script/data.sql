SET IDENTITY_INSERT [dbo].[User] ON
INSERT INTO [dbo].[User] ([Id], [FirstName], [LastName]) VALUES (1, N'Peter', N'Jhonson')
INSERT INTO [dbo].[User] ([Id], [FirstName], [LastName]) VALUES (2, N'Joseph', N'Berkeley')
INSERT INTO [dbo].[User] ([Id], [FirstName], [LastName]) VALUES (3, N'Joe', N'Thompson')
INSERT INTO [dbo].[User] ([Id], [FirstName], [LastName]) VALUES (4, N'Pedro', N'Perez')

INSERT INTO [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (1, N'2019-08-31 12:00:00', N'2019-09-28 12:00:00', 3)
INSERT INTO [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (2, N'2019-09-02 12:00:00', N'2019-09-10 12:00:00', 1)
INSERT INTO [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (3, N'2019-09-05 12:00:00', N'2019-10-25 12:00:00', 8)
INSERT INTO [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (4, N'2019-09-09 12:00:00', N'2019-09-28 12:00:00', 5)
INSERT INTO [dbo].[Project] ([Id], [StartDate], [EndDate], [Credits]) VALUES (5, N'2019-09-24 12:00:00', N'2019-12-12 12:00:00', 11)

INSERT INTO [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AsignedDate]) VALUES (1, 1, 1, N'2019-09-08 12:00:00')
INSERT INTO [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AsignedDate]) VALUES (2, 2, 1, N'2019-09-08 12:00:00')
INSERT INTO [dbo].[UserProject] ([UserId], [ProjectId], [IsActive], [AsignedDate]) VALUES (2, 3, 0, N'2019-09-08 12:00:00')

SET IDENTITY_INSERT [dbo].[Project] OFF

