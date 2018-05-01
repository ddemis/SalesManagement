CREATE PROCEDURE [dbo].[SalesMen_Districts_AddUpdate]
    @salesMenDetailsXml xml
AS

BEGIN
    SET NOCOUNT ON;

    DECLARE @salesMenDetailsDoc int
    EXEC sp_xml_preparedocument @salesMenDetailsDoc OUTPUT, @salesMenDetailsXml;

    WITH data AS (SELECT DistrictId, SalesManId, RepsonsabilityTypeId
    FROM OPENXML (@salesMenDetailsDoc, 'SalesMenDetails/SalesManDetails') 
    WITH (DistrictId int 'DistrictId',
          SalesManId int 'SalesManId',
          RepsonsabilityTypeId int 'RepsonsabilityTypeId'))
    MERGE SalesMen_Districts t USING data s on s.DistrictId = t.DistrictId and s.SalesManId = t.SalesManId

	WHEN MATCHED THEN UPDATE
	SET SalesManResponsabilityTypeId = (CASE s.RepsonsabilityTypeId WHEN 0 THEN null ELSE s.RepsonsabilityTypeId END)

    WHEN NOT MATCHED BY TARGET THEN INSERT (SalesManId, DistrictId, SalesManResponsabilityTypeId)
    VALUES (s.SalesManId, s.DistrictId, s.RepsonsabilityTypeId);
END
