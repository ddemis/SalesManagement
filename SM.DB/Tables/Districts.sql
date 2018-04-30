CREATE TABLE [dbo].[Districts]
(
	[DistrictId]	INT				IDENTITY(1, 1) NOT NULL,
	[Name]			VARCHAR(200)	NOT NULL

	CONSTRAINT [PK_DistrictId] PRIMARY KEY CLUSTERED ([DistrictId] ASC),
)
