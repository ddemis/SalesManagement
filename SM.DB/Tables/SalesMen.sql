CREATE TABLE [dbo].[SalesMen]
(
	[SalesManId]		INT				IDENTITY(1, 1) NOT NULL,
	[FirstName]			VARCHAR(30)		NOT NULL,
	[LastName]			VARCHAR(30)		NOT NULL,
	[DateOfBirth]		DATETIME2(7)	NOT NULL,
	[Age]				INT				NULL

	CONSTRAINT [PK_SalesManId] PRIMARY KEY CLUSTERED ([SalesManId] ASC),
)
