CREATE TABLE [dbo].[SalesMen_Districts]
(
	[SalesManId]						INT		NOT NULL,
	[DistrictId]						INT		NOT NULL,
	[SalesManResponsabilityTypeId]		INT		NOT NULL,

	CONSTRAINT [PK_SalesMen_Districts] PRIMARY KEY CLUSTERED ([SalesManId] ASC, [DistrictId] ASC),
	CONSTRAINT [FK_SalesMen_Districts_SalesMen] FOREIGN KEY ([SalesManId]) REFERENCES [dbo].[SalesMen] ([SalesManId]),
	CONSTRAINT [FK_SalesMen_Districts_Districts] FOREIGN KEY ([DistrictId]) REFERENCES [dbo].[Districts] ([DistrictId]),
	CONSTRAINT [FK_SalesMen_SalesManResponsabilityTypes] FOREIGN KEY ([SalesManResponsabilityTypeId]) REFERENCES [dbo].[SalesManResponsabilityTypes] ([SalesManResponsabilityTypeId])
)
