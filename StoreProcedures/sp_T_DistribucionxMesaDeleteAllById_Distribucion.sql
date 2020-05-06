if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_DistribucionxMesaDeleteAllById_Distribucion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_DistribucionxMesaDeleteAllById_Distribucion]
GO

CREATE PROCEDURE [dbo].[sp_T_DistribucionxMesaDeleteAllById_Distribucion]
(
	@Id_Distribucion int
)

AS

SET NOCOUNT ON

DELETE FROM [T_DistribucionxMesa]
WHERE [Id_Distribucion] = @Id_Distribucion
GO
