if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ZonaSelectAllById_Local]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ZonaSelectAllById_Local]
GO

CREATE PROCEDURE [dbo].[sp_T_ZonaSelectAllById_Local]
(
	@Id_Local int
)

AS

SET NOCOUNT ON

SELECT [Id_Zona],
	[Nombre],
	[Descripcion],
	[Id_Local],
	[Aforo]
FROM [T_Zona]
WHERE [Id_Local] = @Id_Local
GO
