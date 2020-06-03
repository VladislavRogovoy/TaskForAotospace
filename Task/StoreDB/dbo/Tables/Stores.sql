CREATE TABLE [dbo].[Stores]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Address] NCHAR(50) NOT NULL, 
    [OperatingMode] NCHAR(20) NOT NULL
)
