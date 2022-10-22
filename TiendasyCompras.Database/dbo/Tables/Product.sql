CREATE TABLE [dbo].[Product]
(
	[Id]		    INT         IDENTITY (1, 1) NOT NULL,
	[Name]		    VARCHAR(50) NULL,
	[Description]   VARCHAR(100)NULL,
	[ProductTypeId] INT		    NULL,
	[Brand]         VARCHAR(50) NULL,
	[Price]			VARCHAR(50) NULL,
	[Stock]			INT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ProductTypeId]) REFERENCES [dbo].[ProductType] ([Id])
)