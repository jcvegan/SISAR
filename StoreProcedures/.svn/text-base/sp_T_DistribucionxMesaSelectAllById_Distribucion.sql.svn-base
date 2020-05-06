if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_DistribucionxMesaSelectAllById_Distribucion]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_DistribucionxMesaSelectAllById_Distribucion]
GO

CREATE PROCEDURE [dbo].[sp_T_DistribucionxMesaSelectAllById_Distribucion]
(
	@Id_Distribucion int
)

AS

SET NOCOUNT ON

SELECT DxM.[Id_Codigo_Mesa],
	DxM.[Posicion_X],
	DxM.[Posicion_Y],
	DxM.[Numero_Mesa],
	DxM.[Id_Distribucion],
	DxM.[Id_Mesa],
	DxM.[Estado],
	M.Id_Mesa,
	M.Descripcion,
	M.Imagen,
	M.Cantidad,
	M.Width,
	M.Height
FROM [T_DistribucionxMesa] as DxM inner join [T_Mesa] as M on DxM.Id_Mesa =M.Id_Mesa
WHERE [Id_Distribucion] = @Id_Distribucion
GO
