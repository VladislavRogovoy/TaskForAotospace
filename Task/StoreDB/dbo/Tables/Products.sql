CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StoreId] INT NOT NULL, 
    [Name] NCHAR(28) NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Products_ToTable] FOREIGN KEY ([StoreId]) REFERENCES [Stores]([Id])
)
