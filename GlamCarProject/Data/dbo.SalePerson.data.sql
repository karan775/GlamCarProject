SET IDENTITY_INSERT [dbo].[SalePerson] ON
INSERT INTO [dbo].[SalePerson] ([SalePersonId], [Name], [Address], [CenterNo], [CentersCenterNo], [isSenior]) VALUES (1, N'Denny', N'83 waterside Dr', 1, NULL, 1)
INSERT INTO [dbo].[SalePerson] ([SalePersonId], [Name], [Address], [CenterNo], [CentersCenterNo], [isSenior]) VALUES (2, N'Mille', N'10 te aroha street', 4, NULL, 1)
INSERT INTO [dbo].[SalePerson] ([SalePersonId], [Name], [Address], [CenterNo], [CentersCenterNo], [isSenior]) VALUES (3, N'Sunny', N'34 tearoha', 2, NULL, 0)
SET IDENTITY_INSERT [dbo].[SalePerson] OFF
