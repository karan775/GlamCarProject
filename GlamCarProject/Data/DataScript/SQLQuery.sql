SET IDENTITY_INSERT [dbo].[CarSale] ON
INSERT INTO [dbo].[CarSale] ([CarSaleId], [CustomerId], [SalePersonId], [AgreedAmount], [SaleDate]) VALUES (1, 1, 1, 65000, N'2020-12-10 10:02:00')
INSERT INTO [dbo].[CarSale] ([CarSaleId], [CustomerId], [SalePersonId], [AgreedAmount], [SaleDate]) VALUES (2, 2, 3, 75000, N'2020-12-12 10:02:00')
INSERT INTO [dbo].[CarSale] ([CarSaleId], [CustomerId], [SalePersonId], [AgreedAmount], [SaleDate]) VALUES (3, 3, 2, 45000, N'2021-01-20 10:02:00')
SET IDENTITY_INSERT [dbo].[CarSale] OFF


SET IDENTITY_INSERT [dbo].[Center] ON
INSERT INTO [dbo].[Center] ([CenterNo], [Name], [Address], [OpeningDate]) VALUES (1, N'Hamilton east', N'hamilton east', N'2020-01-23 10:03:00')
INSERT INTO [dbo].[Center] ([CenterNo], [Name], [Address], [OpeningDate]) VALUES (2, N'Frankton', N'newton road', N'2019-09-11 10:04:00')
INSERT INTO [dbo].[Center] ([CenterNo], [Name], [Address], [OpeningDate]) VALUES (3, N'Te aroha', N'Ulster steet', N'2020-12-16 10:04:00')
SET IDENTITY_INSERT [dbo].[Center] OFF


SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([CustomerId], [Name], [Address], [Phone]) VALUES (1, N'Manik Arora', N'21 maitland street frankton', N'0223456789')
INSERT INTO [dbo].[Customer] ([CustomerId], [Name], [Address], [Phone]) VALUES (2, N'nav KAUR', N'pyespa tauranga tauranga', N'0225068196')
INSERT INTO [dbo].[Customer] ([CustomerId], [Name], [Address], [Phone]) VALUES (3, N'Pari', N'10 te aroha street', N'0213456789')
INSERT INTO [dbo].[Customer] ([CustomerId], [Name], [Address], [Phone]) VALUES (4, N'Lisa', N'pyespa tauranga tauranga', N'0225068196')
SET IDENTITY_INSERT [dbo].[Customer] OFF


SET IDENTITY_INSERT [dbo].[SalePerson] ON
INSERT INTO [dbo].[SalePerson] ([SalePersonId], [Name], [Address], [CenterNo], [CentersCenterNo], [isSenior]) VALUES (1, N'Denny', N'83 waterside Dr', 1, NULL, 1)
INSERT INTO [dbo].[SalePerson] ([SalePersonId], [Name], [Address], [CenterNo], [CentersCenterNo], [isSenior]) VALUES (2, N'Mille', N'10 te aroha street', 4, NULL, 1)
INSERT INTO [dbo].[SalePerson] ([SalePersonId], [Name], [Address], [CenterNo], [CentersCenterNo], [isSenior]) VALUES (3, N'Sunny', N'34 tearoha', 2, NULL, 0)
SET IDENTITY_INSERT [dbo].[SalePerson] OFF
