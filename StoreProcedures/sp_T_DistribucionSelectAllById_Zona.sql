if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_DistribucionSelectAllById_Zona]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_DistribucionSelectAllById_Zona]
GO

CREATE PROCEDURE [dbo].[sp_T_DistribucionSelectAllById_Zona]
(
	@Id_Zona int
)

AS

SET NOCOUNT ON

SELECT [Id_Distribucion],
	[Nombre],
	[Descripcion],
	[Id_Zona],
	[Estado]
FROM [T_Distribucion]
WHERE [Id_Zona] = @Id_Zona
ORDER BY [Estado] DESC
GO
