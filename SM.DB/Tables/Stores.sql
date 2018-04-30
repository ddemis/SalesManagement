CREATE TABLE [dbo].[Stores]
(
	[StoreId]		INT				IDENTITY(1, 1) NOT NULL,
	[Name]			VARCHAR(200)	NOT NULL,
	[DistrictId]	INT				NOT NULL,

	CONSTRAINT [PK_Stores] PRIMARY KEY CLUSTERED ([StoreId] ASC),
	CONSTRAINT [FK_Stores_Districts] FOREIGN KEY ([DistrictId]) REFERENCES [dbo].[Districts] ([DistrictId]) ON DELETE CASCADE
)
