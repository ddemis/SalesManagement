CREATE TABLE [dbo].[SalesManResponsabilityTypes]
(
	[SalesManResponsabilityTypeId]		INT				NOT NULL,
	[SalesManResponsabilityTypeName]	VARCHAR(200)	NOT NULL,

	CONSTRAINT [PK_SalesManResponsabilityTypes] PRIMARY KEY CLUSTERED ([SalesManResponsabilityTypeId] ASC),
)
