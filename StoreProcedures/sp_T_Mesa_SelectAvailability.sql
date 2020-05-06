if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[[sp_T_Mesa_SelectAvailability]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_Mesa_SelectAvailability]
GO
CREATE PROCEDURE [dbo].[sp_T_Mesa_SelectAvailability](
	@Id_Local int
)
AS

SET NOCOUNT ON
SELECT     T_DistribucionxMesa.Numero_Mesa, T_Zona.Id_Local, T_DistribucionxMesa.Estado
FROM         T_Distribucion INNER JOIN
                      T_DistribucionxMesa ON T_Distribucion.Id_Distribucion = T_DistribucionxMesa.Id_Distribucion INNER JOIN
                      T_Zona ON T_Distribucion.Id_Zona = T_Zona.Id_Zona
WHERE     (T_DistribucionxMesa.Estado = 'OCUPADO' and T_Zona.Id_Local=@Id_Local)
GO