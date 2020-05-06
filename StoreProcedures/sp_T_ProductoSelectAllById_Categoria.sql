if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ProductoSelectAllById_Categoria]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ProductoSelectAllById_Categoria]
GO

CREATE PROCEDURE [dbo].[sp_T_ProductoSelectAllById_Categoria]
(
	@Id_Categoria int
)

AS

SET NOCOUNT ON

SELECT [Id_Producto],
	[Nombre],
	[Descripcion],
	[PrecioUnitario],
	[Imagen],
	[Observacion],
	[Id_Categoria],
	[Id_Moneda]
FROM [T_Producto]
WHERE [Id_Categoria] = @Id_Categoria
GO
